Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_HD_Roadmap_Detail
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub
#End Region

#Region "Property"

#Region "Item"
    Private _roadmap_master As String
    Public Property roadmap_master() As String
        Get
            Return _roadmap_master
        End Get
        Set(ByVal value As String)
            _roadmap_master = value
        End Set
    End Property

    Private _course_master As String = String.Empty
    Public Property course_master() As String
        Get
            Return _course_master
        End Get
        Set(ByVal value As String)
            _course_master = value
        End Set
    End Property

    Private _seq As Integer
    Public Property seq() As Integer
        Get
            Return _seq
        End Get
        Set(ByVal value As Integer)
            _seq = value
        End Set
    End Property

    Private _yearMonthFlag As String
    Public Property yearMonthFlag() As String
        Get
            Return _yearMonthFlag
        End Get
        Set(value As String)
            _yearMonthFlag = value
        End Set
    End Property

    Private _year1 As String
    Public Property year1() As String
        Get
            Return _year1
        End Get
        Set(ByVal value As String)
            _year1 = value
        End Set
    End Property

    Private _year2 As String
    Public Property year2() As String
        Get
            Return _year2
        End Get
        Set(ByVal value As String)
            _year2 = value
        End Set
    End Property

    Private _year3 As String
    Public Property year3() As String
        Get
            Return _year3
        End Get
        Set(ByVal value As String)
            _year3 = value
        End Set
    End Property

    Private _year4 As String
    Public Property year4() As String
        Get
            Return _year4
        End Get
        Set(ByVal value As String)
            _year4 = value
        End Set
    End Property

    Private _year5 As String
    Public Property year5() As String
        Get
            Return _year5
        End Get
        Set(ByVal value As String)
            _year5 = value
        End Set
    End Property

    Private _year6 As String
    Public Property year6() As String
        Get
            Return _year6
        End Get
        Set(ByVal value As String)
            _year6 = value
        End Set
    End Property

    Private _year7 As String
    Public Property year7() As String
        Get
            Return _year7
        End Get
        Set(ByVal value As String)
            _year7 = value
        End Set
    End Property

    Private _year8 As String
    Public Property year8() As String
        Get
            Return _year8
        End Get
        Set(ByVal value As String)
            _year8 = value
        End Set
    End Property

    Private _year9 As String
    Public Property year9() As String
        Get
            Return _year9
        End Get
        Set(ByVal value As String)
            _year9 = value
        End Set
    End Property

    Private _year10 As String
    Public Property year10() As String
        Get
            Return _year10
        End Get
        Set(ByVal value As String)
            _year10 = value
        End Set
    End Property

    Private _begmonth As Integer
    Public Property begmonth() As Integer
        Get
            Return _begmonth
        End Get
        Set(value As Integer)
            _begmonth = value
        End Set
    End Property

    Private _endmonth As Integer
    Public Property endmonth() As Integer
        Get
            Return _endmonth
        End Get
        Set(value As Integer)
            _endmonth = value
        End Set
    End Property

#End Region

#Region "Exp Property"
    Public ReadOnly Property expHD_Course_Master() As Cls_Course_Master
        Get
            Return New Cls_Course_Master(_course_master)
        End Get
    End Property
#End Region

#End Region

#Region "Function"

    Public Sub clear()
        var_id = ""
        _roadmap_master = String.Empty
        _course_master = String.Empty
        _seq = 0
        _yearMonthFlag = String.Empty
        _year1 = String.Empty
        _year2 = String.Empty
        _year3 = String.Empty
        _year4 = String.Empty
        _year5 = String.Empty
        _year6 = String.Empty
        _year7 = String.Empty
        _year8 = String.Empty
        _year9 = String.Empty
        _year10 = String.Empty
        _begmonth = 0
        _endmonth = 0
    End Sub

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
                strwc = " and rdd_id ='" & var_id.ToString() & "'"
            End If
            If _roadmap_master.Length > 0 Then
                strwc = strwc + " and rdd_roadmap_master ='" & _roadmap_master.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_roadmap_detail where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by rdd_roadmap_master,rdd_seq"
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function RetreiveByPositionRoadMapDetail(stationTypeCode As String, positionName As String) As DataTable
        Try
            Dim dt As New DataTable
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim strcommand As String = String.Empty
            strcommand = "select hrd.* from hd_roadmap_master hrm"
            strcommand = strcommand & vbCrLf & "inner join hd_roadmap_detail hrd on hrd.rdd_roadmap_master = hrm.rdm_id"
            strcommand = strcommand & vbCrLf & "left outer join station s on s.id = hrm.rdm_station"
            strcommand = strcommand & vbCrLf & "left outer join position p on p.id = hrm.rdm_position"
            strcommand = strcommand & vbCrLf & "where hrm.corp='" & GBCorp & "'"
            strcommand = strcommand & vbCrLf & "and s.status ='1' and p.status ='1'"
            strcommand = strcommand & vbCrLf & " and s.st_type  = ? "
            If positionName <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and p.name_01 like ? "
            End If
            strcommand = strcommand & vbCrLf & "order by hrd.rdd_roadmap_master,hrd.rdd_seq"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", stationTypeCode.ToString())
            If positionName <> String.Empty Then
                cmd.Parameters.AddWithValue("@p2", "%" & positionName.ToString() & "%")
            End If
            dt = SqlDB.GetDataTable(cmd)
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
            strcommand = "insert into hd_roadmap_detail("
            strcommand = strcommand & vbCrLf & "corp,branch,rdd_id,rdd_roadmap_master,rdd_course_master"
            strcommand = strcommand & vbCrLf & ",rdd_seq,rdd_year_month_flag,rdd_year1,rdd_year2,rdd_year3,rdd_year4,rdd_year5"
            strcommand = strcommand & vbCrLf & ",rdd_year6,rdd_year7,rdd_year8,rdd_year9,rdd_year10,rdd_begmonth,rdd_endmonth,rdd_create_by"
            strcommand = strcommand & vbCrLf & ",rdd_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", Config.GBBranch)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _roadmap_master)
            cmd.Parameters.AddWithValue("@p5", _course_master)
            cmd.Parameters.AddWithValue("@p6", _seq)
            cmd.Parameters.AddWithValue("@p7", _yearMonthFlag)
            cmd.Parameters.AddWithValue("@p8", _year1)
            cmd.Parameters.AddWithValue("@p9", _year2)
            cmd.Parameters.AddWithValue("@p10", _year3)
            cmd.Parameters.AddWithValue("@p11", _year4)
            cmd.Parameters.AddWithValue("@p12", _year5)
            cmd.Parameters.AddWithValue("@p13", _year6)
            cmd.Parameters.AddWithValue("@p14", _year7)
            cmd.Parameters.AddWithValue("@p15", _year8)
            cmd.Parameters.AddWithValue("@p16", _year9)
            cmd.Parameters.AddWithValue("@p17", _year10)
            cmd.Parameters.AddWithValue("@p18", _begmonth)
            cmd.Parameters.AddWithValue("@p19", _endmonth)
            cmd.Parameters.AddWithValue("@p20", GBUsername)
            cmd.Parameters.AddWithValue("@p21", DateTime.Now)
            SqlDB.Exec(cmd)
            'message = "บันทึกข้อมูลเรียบร้อยแล้ว"
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
        Dim strErrmsg As String = ""
        Try
            strcommand = "update hd_roadmap_detail"
            strcommand = strcommand & vbCrLf & "set corp = ?"
            strcommand = strcommand & vbCrLf & ",rdd_roadmap_master = ?"
            strcommand = strcommand & vbCrLf & ",rdd_course_master = ?"
            strcommand = strcommand & vbCrLf & ",rdd_seq = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year_month_flag =?"
            strcommand = strcommand & vbCrLf & ",rdd_year1 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year2 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year3 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year4 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year5 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year6 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year7 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year8 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year9 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_year10 = ?"
            strcommand = strcommand & vbCrLf & ",rdd_begmonth =?"
            strcommand = strcommand & vbCrLf & ",rdd_endmonth =?"
            strcommand = strcommand & vbCrLf & ",rdd_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",rdd_edit_date = ?"
            strcommand = strcommand & vbCrLf & "where rdd_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", _roadmap_master)
            cmd.Parameters.AddWithValue("@p3", _course_master)
            cmd.Parameters.AddWithValue("@p4", _seq)
            cmd.Parameters.AddWithValue("@p5", _yearMonthFlag)
            cmd.Parameters.AddWithValue("@p6", _year1)
            cmd.Parameters.AddWithValue("@p7", _year2)
            cmd.Parameters.AddWithValue("@p8", _year3)
            cmd.Parameters.AddWithValue("@p9", _year4)
            cmd.Parameters.AddWithValue("@p10", _year5)
            cmd.Parameters.AddWithValue("@p11", _year6)
            cmd.Parameters.AddWithValue("@p12", _year7)
            cmd.Parameters.AddWithValue("@p13", _year8)
            cmd.Parameters.AddWithValue("@p14", _year9)
            cmd.Parameters.AddWithValue("@p15", _year10)
            cmd.Parameters.AddWithValue("@p16", _begmonth)
            cmd.Parameters.AddWithValue("@p17", _endmonth)
            cmd.Parameters.AddWithValue("@p18", GBUsername)
            cmd.Parameters.AddWithValue("@p19", DateTime.Now)
            cmd.Parameters.AddWithValue("@p20", var_id)
            SqlDB.Exec(cmd)
            'message = "แก้ไขข้อมูลเรียบร้อยแล้ว"
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
            strcommand = "delete from hd_roadmap_detail "
            strcommand = strcommand & vbCrLf & "where rdd_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd)
        Catch ex As Exception
            bSucc = False
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
        End Try
        Return bSucc
    End Function

    Public Sub SetProperty(dt As DataTable)
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                _course_master = cNull(dt.Rows(row).Item("rdd_course_master"), "S")
                _roadmap_master = cNull(dt.Rows(row).Item("rdd_roadmap_master"), "S")
                _seq = cNull(dt.Rows(row).Item("rdd_seq"), "N")
                _year1 = cNull(dt.Rows(row).Item("rdd_year1"), "S")
                _year2 = cNull(dt.Rows(row).Item("rdd_year2"), "S")
                _year3 = cNull(dt.Rows(row).Item("rdd_year3"), "S")
                _year4 = cNull(dt.Rows(row).Item("rdd_year4"), "S")
                _year5 = cNull(dt.Rows(row).Item("rdd_year5"), "S")
                _year6 = cNull(dt.Rows(row).Item("rdd_year6"), "S")
                _year7 = cNull(dt.Rows(row).Item("rdd_year7"), "S")
                _year8 = cNull(dt.Rows(row).Item("rdd_year8"), "S")
                _year9 = cNull(dt.Rows(row).Item("rdd_year9"), "S")
                _year10 = cNull(dt.Rows(row).Item("rdd_year10"), "S")
            Next
        End If
    End Sub

#End Region

End Class
