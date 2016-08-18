Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Annual_Detail
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub

#End Region

#Region "Property"
    Private _annual_master As String = String.Empty
    Public Property annual_master() As String
        Get
            Return _annual_master
        End Get
        Set(value As String)
            _annual_master = value
        End Set
    End Property

    Private _person_data As String = String.Empty
    Public Property person_data() As String
        Get
            Return _person_data
        End Get
        Set(value As String)
            _person_data = value
        End Set
    End Property

    Private _position As String
    Public Property position() As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            _position = value
        End Set
    End Property

    Private _RoadMap As String
    Public Property RoadMap() As String
        Get
            Return _RoadMap
        End Get
        Set(ByVal value As String)
            _RoadMap = value
        End Set
    End Property

    Private _seq As Integer
    Public Property seq() As Integer
        Get
            Return _seq
        End Get
        Set(value As Integer)
            _seq = value
        End Set
    End Property

    Public message As String
#End Region

#Region "EXP Property"
    Public ReadOnly Property expperson_data() As cls_person
        Get
            Return New cls_person(_person_data)
        End Get
    End Property

    Public ReadOnly Property expposition() As Cls_Position
        Get
            Return New Cls_Position(_position)
        End Get
    End Property

    Public ReadOnly Property expRoadMap() As Cls_HD_Roadmap_Master
        Get
            Return New Cls_HD_Roadmap_Master(_RoadMap)
        End Get
    End Property
#End Region

#Region "Clear"
    Public Sub clear()
        var_id = ""
        _annual_master = String.Empty
        _person_data = String.Empty
        _seq = 0
    End Sub
#End Region

#Region "Function"
    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        SetProperty(dt)
        Return True
    End Function

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and and_id='" & var_id.ToString() & "'"
            End If
            If _annual_master <> String.Empty Then
                strwc = strwc & " and and_annual_master = '" & _annual_master.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_annual_detail where corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "order by and_annual_master,and_seq"
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Save(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = ""
        Try
            strcommand = "insert into hd_annual_detail("
            strcommand = strcommand & vbCrLf & "corp,branch,and_id,and_annual_master,and_seq,and_person_data,and_position,and_roadmap "
            strcommand = strcommand & vbCrLf & ",and_create_by,and_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _annual_master)
            cmd.Parameters.AddWithValue("@p5", _seq)
            cmd.Parameters.AddWithValue("@p6", _person_data)
            cmd.Parameters.AddWithValue("@p7", _position)
            cmd.Parameters.AddWithValue("@p8", _RoadMap)
            cmd.Parameters.AddWithValue("@p9", GBUsername)
            cmd.Parameters.AddWithValue("@p10", DateTime.Now)
            SqlDB.Exec(cmd)
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Update(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = String.Empty

        Try
            strcommand = "update hd_annual_detail"
            strcommand = strcommand & vbCrLf & " set corp = ? "
            strcommand = strcommand & vbCrLf & ",branch = ? "
            strcommand = strcommand & vbCrLf & ",and_annual_master = ? "
            strcommand = strcommand & vbCrLf & ",and_seq = ? "
            strcommand = strcommand & vbCrLf & ",and_person_data = ? "
            strcommand = strcommand & vbCrLf & ",and_edit_by =? "
            strcommand = strcommand & vbCrLf & ",and_edit_date =? "
            strcommand = strcommand & vbCrLf & "where and_id =? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _annual_master)
            cmd.Parameters.AddWithValue("@p4", _seq)
            cmd.Parameters.AddWithValue("@p5", _person_data)
            cmd.Parameters.AddWithValue("@p6", GBUsername)
            cmd.Parameters.AddWithValue("@p7", DateTime.Now)
            cmd.Parameters.AddWithValue("@p8", var_id)
            SqlDB.Exec(cmd)
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Delete(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Try
            strcommand = "delete from hd_annual_detail "
            strcommand = strcommand & vbCrLf & "where and_id =? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd)
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            bSucc = False
        End Try
        Return bSucc
    End Function

#End Region

#Region "SetProperty"
    Public Sub SetProperty(dt As DataTable)
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                _annual_master = cNull(dt.Rows(row).Item("and_annual_master"), "S")
                _seq = cNull(dt.Rows(row).Item("and_seq"), "N")
                _person_data = cNull(dt.Rows(row).Item("and_person_data"), "S")
            Next
        End If
    End Sub
#End Region

End Class
