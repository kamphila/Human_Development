Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_HD_Course_Exam
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged


    Private _course_master As String = String.Empty
    Private _exam_master As String = String.Empty
    Private _seq As Integer = 0
    Private _create_by As String = String.Empty
    Private _edit_by As String = String.Empty

    Public Sub New()
    End Sub
    Public Sub New(id As String)
        Me.getById(id)
    End Sub

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        SetProperty(dt)
        Return True
    End Function


#Region "Property"
    Public Property course_master() As String
        Get
            Return _course_master
        End Get
        Set(ByVal value As String)
            _course_master = value
        End Set
    End Property

    Public Property exam_master() As String
        Get
            Return _exam_master
        End Get
        Set(ByVal value As String)
            _exam_master = value
        End Set
    End Property

    Public Property seq() As Integer
        Get
            Return _seq
        End Get
        Set(ByVal value As Integer)
            _seq = value
        End Set
    End Property

    Public Property create_by() As String
        Get
            Return _create_by
        End Get
        Set(ByVal value As String)
            _create_by = value
        End Set
    End Property

    Public Property edit_by() As String
        Get
            Return _edit_by
        End Get
        Set(ByVal value As String)
            _edit_by = value
        End Set
    End Property
#End Region

#Region "Exp Property"
    Public ReadOnly Property expHD_Course_Item() As Cls_HD_Exam_Master
        Get
            Return New Cls_HD_Exam_Master(_exam_master)
        End Get
    End Property
#End Region

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and cex_id ='" & var_id.ToString() & "'"
            End If
            If _course_master.Length > 0 Then
                strwc = strwc + " and cex_course_master ='" & _course_master.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_course_exam where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by cex_seq "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Public Sub SetProperty(dt As DataTable)
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                _course_master = cNull(dt.Rows(row).Item("cex_course_master"), "S")
                _exam_master = cNull(dt.Rows(row).Item("cex_exam_master"), "S")
                _seq = cNull(dt.Rows(row).Item("cex_seq"), "N")
                _create_by = cNull(dt.Rows(row).Item("cex_create_by"), "S")
                _edit_by = cNull(dt.Rows(row).Item("cex_edit_by"), "S")
            Next
        End If
    End Sub

    Sub Delete(SqlDB As Cls_SqlDB)
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Try
            strcommand = "delete from hd_course_exam "
            strcommand = strcommand & vbCrLf & "where cex_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd)
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
        End Try
    End Sub

    Function Save(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = String.Empty
        bSucc = True

        Try
            If id = String.Empty Then
                'Insert
                strcommand = "insert into hd_course_exam(corp,branch,cex_id,cex_course_master,cex_exam_master,cex_seq"
                strcommand = strcommand & vbCrLf & ",cex_create_by,cex_create_date"
                strcommand = strcommand & vbCrLf & " ) values(?,?,?,?,?,?,?,?)"
                cmd = SqlDB.CreateCommand(strcommand)
                var_id = SqlDB.GenKeyValue()
                cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
                cmd.Parameters.AddWithValue("@p2", Branch_id)
                cmd.Parameters.AddWithValue("@p3", var_id)
                cmd.Parameters.AddWithValue("@p4", _course_master)
                cmd.Parameters.AddWithValue("@p5", _exam_master)
                cmd.Parameters.AddWithValue("@p6", _seq)
                cmd.Parameters.AddWithValue("@p7", GBUsername)
                cmd.Parameters.AddWithValue("@p8", DateTime.Now)
                SqlDB.Exec(cmd)
            Else
                'Update
                strcommand = "update hd_course_exam "
                strcommand = strcommand & vbCrLf & "set cex_course_master = ? "
                strcommand = strcommand & vbCrLf & ",cex_exam_master = ? "
                strcommand = strcommand & vbCrLf & ",cex_seq = ? "
                strcommand = strcommand & vbCrLf & ",cex_edit_by= ? "
                strcommand = strcommand & vbCrLf & ",cex_edit_date= ? "
                strcommand = strcommand & vbCrLf & "where cex_id = ? "
                cmd = SqlDB.CreateCommand(strcommand)
                cmd.Parameters.AddWithValue("@p1", _course_master)
                cmd.Parameters.AddWithValue("@p4", _exam_master)
                cmd.Parameters.AddWithValue("@p2", _seq)
                cmd.Parameters.AddWithValue("@p13", GBUsername)
                cmd.Parameters.AddWithValue("@p14", DateTime.Now)
                cmd.Parameters.AddWithValue("@p15", var_id)
                SqlDB.Exec(cmd)
            End If
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            bSucc = False
        End Try

        Return bSucc
    End Function

End Class
