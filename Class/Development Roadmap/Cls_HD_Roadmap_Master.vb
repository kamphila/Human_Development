Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_HD_Roadmap_Master
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged


#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(id As String)
        If String.Empty.Equals(id) = False Then
            Me.getById(id)
        End If
    End Sub
#End Region


#Region "Property"
    Private _docDate As DateTime
    Private _docCode As String

#Region "Item"
    Public Property docDate() As DateTime
        Get
            Return _docDate
        End Get
        Set(ByVal value As DateTime)
            _docDate = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("docDate"))
        End Set
    End Property

    Public Property docCode() As String
        Get
            Return _docCode
        End Get
        Set(value As String)
            _docCode = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("docCode"))
        End Set
    End Property

    Private _position As String
    Public Property position() As String
        Get
            Return _position
        End Get
        Set(ByVal value As String)
            _position = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("position"))
        End Set
    End Property

    Private _station As String
    Public Property station() As String
        Get
            Return _station
        End Get
        Set(ByVal value As String)
            _station = value
        End Set
    End Property

    Public ReadOnly Property Item_RoadMapDetail() As Collection
        Get
            Return pmethGetRoadMapDetail()
        End Get
    End Property
#End Region

#Region "Exp Property"
    Public ReadOnly Property expHD_Position() As Cls_Position
        Get
            Return New Cls_Position(_position)
        End Get
    End Property
#End Region

#End Region

#Region "Function"

    Public Sub clear()
        var_id = ""
        _docDate = DateTime.Now.Date()
        _docCode = String.Empty
        _position = String.Empty
    End Sub
    Public Sub clear(mode As String)
        If mode = GBMod.Edit Then
            _docDate = DateTime.Now.Date()
            _position = String.Empty
        End If
    End Sub

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        pmethSetproperty(dt)
        Return True
    End Function

    Private Function pmethGetRoadMapDetail() As Collection
        Dim Col_Data As New Collection
        Dim Rdd As New Cls_HD_Roadmap_Detail()
        Rdd.roadmap_master = var_id
        Dim dt As DataTable = Rdd.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim IRdd As New Cls_HD_Roadmap_Detail
                IRdd.id = cNull(dt.Rows(row).Item("rdd_id"), "S")
                IRdd.roadmap_master = cNull(dt.Rows(row).Item("rdd_roadmap_master"), "S")
                IRdd.course_master = cNull(dt.Rows(row).Item("rdd_course_master"), "S")
                IRdd.seq = cNull(dt.Rows(row).Item("rdd_seq"), "N")
                IRdd.yearMonthFlag = cNull(dt.Rows(row).Item("rdd_year_month_flag"), "S")
                IRdd.year1 = cNull(dt.Rows(row).Item("rdd_year1"), "S")
                IRdd.year2 = cNull(dt.Rows(row).Item("rdd_year2"), "S")
                IRdd.year3 = cNull(dt.Rows(row).Item("rdd_year3"), "S")
                IRdd.year4 = cNull(dt.Rows(row).Item("rdd_year4"), "S")
                IRdd.year5 = cNull(dt.Rows(row).Item("rdd_year5"), "S")
                IRdd.year6 = cNull(dt.Rows(row).Item("rdd_year6"), "S")
                IRdd.year7 = cNull(dt.Rows(row).Item("rdd_year7"), "S")
                IRdd.year8 = cNull(dt.Rows(row).Item("rdd_year8"), "S")
                IRdd.year9 = cNull(dt.Rows(row).Item("rdd_year9"), "S")
                IRdd.year10 = cNull(dt.Rows(row).Item("rdd_year10"), "S")
                IRdd.begmonth = cNull(dt.Rows(row).Item("rdd_begmonth"), "N")
                IRdd.endmonth = cNull(dt.Rows(row).Item("rdd_endmonth"), "N")
                Col_Data.Add(IRdd)
            Next
        End If
        Return Col_Data
    End Function


    Function Retreive(BegDate As DateTime, EndDate As DateTime) As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            Dim cmd As New OleDbCommand
            If GBBranch <> "ALL" Then
                strwc = " and branch ='" & GBBranch.ToString() & "'"
            End If
            If var_id.Length > 0 Then
                strwc = strwc + " and rdm_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_roadmap_master where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & " and rdm_date between ? and ? "
            strcommand = strcommand & vbCrLf & "order by rdm_code "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", BegDate)
            cmd.Parameters.AddWithValue("@p2", EndDate)
            dt = SqlDB.GetDataTable(cmd)
            Return dt

        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable

            If GBBranch <> "ALL" Then
                strwc = " and branch ='" & GBBranch.ToString() & "'"
            End If
            If var_id.Length > 0 Then
                strwc = strwc + " and rdm_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_roadmap_master where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by rdm_code "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt

            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Retreive(strCourse As String, strPosition As String) As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            strcommand = "select hdm.rdm_id,hdm.rdm_code,hdm.rdm_date,hdd.rdd_course_master,hdm.rdm_position "
            strcommand = strcommand & vbCrLf & " from hd_roadmap_master hdm "
            strcommand = strcommand & vbCrLf & " inner join hd_roadmap_detail hdd on hdm.rdm_id = hdd.rdd_roadmap_master "
            strcommand = strcommand & vbCrLf & " where hdm.corp='" & GBCorp & "'"

            If String.IsNullOrEmpty(strCourse) <> True Then
                strcommand = strcommand & vbCrLf & " and hdd.rdd_course_master = ? "
            End If
            If String.IsNullOrEmpty(strPosition) <> True Then
                strcommand = strcommand & vbCrLf & " and hdm.rdm_position = ? "
            End If
            strcommand = strcommand & vbCrLf & " order by hdm.rdm_code , hdm.rdm_date "
            cmd = SqlDB.CreateCommand(strcommand)
            If String.IsNullOrEmpty(strCourse) <> True Then
                cmd.Parameters.AddWithValue("@p1", strCourse)
            End If
            If String.IsNullOrEmpty(strPosition) <> True Then
                cmd.Parameters.AddWithValue("@p2", strPosition)
            End If
            dt = SqlDB.GetDataTable(cmd)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function


    Function RetreiveByPositionRoadMapMaster(positionName As String, stationName As String) As DataTable
        Try
            Dim dt As New DataTable
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim strcommand As String = String.Empty
            strcommand = "select hdr.* from hd_roadmap_master hdr "
            strcommand = strcommand & vbCrLf & "left outer join station s on s.id = hdr.rdm_station"
            strcommand = strcommand & vbCrLf & "left outer join position p on p.id = hdr.rdm_position"
            strcommand = strcommand & vbCrLf & "where hdr.corp='" & GBCorp & "'"
            strcommand = strcommand & vbCrLf & "and s.status ='1' "
            strcommand = strcommand & vbCrLf & "and p.status ='1' "
            If positionName <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and p.name_01 like ? "
            End If
            If stationName <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and s.name_01 like ? "
            End If
            strcommand = strcommand & vbCrLf & "order by hdr.rdm_code "
            cmd = SqlDB.CreateCommand(strcommand)
            If positionName <> String.Empty Then
                cmd.Parameters.AddWithValue("@p1", "%" & positionName.ToString() & "%")
            End If
            If stationName <> String.Empty Then
                cmd.Parameters.AddWithValue("@p2", "%" & stationName.ToString() & "%")
            End If
            dt = SqlDB.GetDataTable(cmd)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Add(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = ""
        Try
            strcommand = "insert into hd_roadmap_master("
            strcommand = strcommand & vbCrLf & "corp,branch,rdm_id,rdm_date,rdm_code"
            strcommand = strcommand & vbCrLf & ",rdm_position,rdm_station,rdm_create_by,rdm_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", Config.GBBranch)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _docDate)
            cmd.Parameters.AddWithValue("@p5", _docCode)
            cmd.Parameters.AddWithValue("@p6", _position)
            cmd.Parameters.AddWithValue("@p7", _station)
            cmd.Parameters.AddWithValue("@p8", GBUsername)
            cmd.Parameters.AddWithValue("@p9", DateTime.Now)
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
        Try
            Dim cmd As New OleDbCommand
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim strErrmsg As String = ""
            strcommand = "update hd_roadmap_master"
            strcommand = strcommand & vbCrLf & "set rdm_date = ?"
            strcommand = strcommand & vbCrLf & ",rdm_position = ?"
            strcommand = strcommand & vbCrLf & ",rdm_station = ?"
            strcommand = strcommand & vbCrLf & ",rdm_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",rdm_edit_date = ?"
            strcommand = strcommand & vbCrLf & "where rdm_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", _docDate)
            cmd.Parameters.AddWithValue("@p2", _position)
            cmd.Parameters.AddWithValue("@p3", _station)
            cmd.Parameters.AddWithValue("@p4", GBUsername)
            cmd.Parameters.AddWithValue("@p5", DateTime.Now)
            cmd.Parameters.AddWithValue("@p6", id)
            SqlDB.Exec(cmd)
            'message = "บันทึกข้อมูลเรียบร้อยแล้ว"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Delete(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim bSucc As Boolean = True
        Try
            strcommand = "delete from hd_roadmap_master "
            strcommand = strcommand & vbCrLf & "where rdm_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd)
            bSucc = True
            message = "ลบข้อมูลเรียบร้อยแล้ว"
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            bSucc = False
        End Try
        Return bSucc
    End Function

    Private Sub pmethSetproperty(dt As DataTable)
        var_id = cNull(dt.Rows(0).Item("rdm_id"), "S")
        _docCode = cNull(dt.Rows(0).Item("rdm_code"), "S")
        _docDate = cNull(dt.Rows(0).Item("rdm_date"), "D")
        _position = cNull(dt.Rows(0).Item("rdm_position"), "S")
        _station = cNull(dt.Rows(0).Item("rdm_station"), "S")
    End Sub

#End Region

End Class
