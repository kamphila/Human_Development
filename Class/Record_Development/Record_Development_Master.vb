Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Record_Development_Master
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Private _doc_date As DateTime = DateTime.Now.Date
    Private _doc_code As String = String.Empty
    Private _ann_master As String = String.Empty
    Private _course_master As String = String.Empty
    Private _main_hour As Decimal
    Private _year As String = String.Empty
    Private _edition As Integer
    Private _qty_people As Integer

    Public Sub New()

    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub

    Public Property doc_date() As DateTime
        Get
            Return _doc_date 
        End Get
        Set(value As DateTime)
            _doc_date = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("doc_date"))
        End Set
    End Property

    Public Property doc_code() As String
        Get
            Return _doc_code
        End Get
        Set(value As String)
            _doc_code = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("doc_code"))
        End Set
    End Property

    Public Property ann_master() As String
        Get
            Return _ann_master
        End Get
        Set(value As String)
            _ann_master = value
        End Set
    End Property

    Public Property course_master() As String
        Get
            Return _course_master
        End Get
        Set(value As String)
            _course_master = value
        End Set
    End Property

    Public Property main_hour() As Decimal
        Get
            Return _main_hour
        End Get
        Set(value As Decimal)
            _main_hour = value
        End Set
    End Property

    Public Property year() As String
        Get
            Return _year
        End Get
        Set(value As String)
            _year = value
        End Set
    End Property

    Public Property edition() As Integer
        Get
            Return _edition
        End Get
        Set(value As Integer)
            _edition = value
        End Set
    End Property

    Public Property qty_people As Integer
        Get
            Return _qty_people
        End Get
        Set(value As Integer)
            _qty_people = value
        End Set
    End Property

    Public ReadOnly Property expannual_master() As Cls_Annual_Master
        Get
            Return New Cls_Annual_Master(_ann_master)
        End Get
    End Property

    Public ReadOnly Property expcourse_master() As Cls_Course_Master
        Get
            Return New Cls_Course_Master(_course_master)
        End Get
    End Property

    Public Sub Clear()
        var_id = String.Empty
        _doc_date = DateTime.Now.Date
        _doc_code = String.Empty
        _ann_master = String.Empty
        _course_master = String.Empty
        _main_hour = 0
        _year = String.Empty
        _edition = 0
        _qty_people = 0
    End Sub

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        pmethSetproperty(dt)
        Return True
    End Function

    Function Retreive(BegDate As DateTime, EndDate As DateTime) As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            Dim cmd As New OleDbCommand
            If var_id.Length > 0 Then
                strwc = " and rdm_id='" & var_id.ToString() & "'"
            End If
            strcommand = "SELECT * FROM hd_resultdev_master WHERE corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & " and rdm_date between ? and ? "
            strcommand = strcommand & vbCrLf & "ORDER BY rdm_code"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", BegDate)
            cmd.Parameters.AddWithValue("@p2", EndDate)
            dt = SqlDB.GetDataTable(cmd)

            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and rdm_id='" & var_id.ToString() & "'"
            End If
            strcommand = "SELECT * FROM hd_resultdev_master WHERE corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "ORDER BY rdm_code"
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Update(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Try
            strcommand = "update hd_resultdev_master set "
            strcommand = strcommand & vbCrLf & "corp =?"
            strcommand = strcommand & vbCrLf & ",branch =?"
            strcommand = strcommand & vbCrLf & ",rdm_date =?"
            strcommand = strcommand & vbCrLf & ",rdm_code =?"
            strcommand = strcommand & vbCrLf & ",rdm_annual_master =?"
            strcommand = strcommand & vbCrLf & ",rdm_course_master =?"
            strcommand = strcommand & vbCrLf & ",rdm_main_hour =?"
            strcommand = strcommand & vbCrLf & ",rdm_ann_year =?"
            strcommand = strcommand & vbCrLf & ",rdm_ann_edition =?"
            strcommand = strcommand & vbCrLf & ",rdm_ann_qty_people =?"
            strcommand = strcommand & vbCrLf & ",rdm_edit_by =?"
            strcommand = strcommand & vbCrLf & ",rdm_edit_date =?"
            strcommand = strcommand & vbCrLf & "where rdm_id=?"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _doc_date)
            cmd.Parameters.AddWithValue("@p4", _doc_code)
            cmd.Parameters.AddWithValue("@p5", _ann_master)
            cmd.Parameters.AddWithValue("@p6", _course_master)
            cmd.Parameters.AddWithValue("@p7", _main_hour)
            cmd.Parameters.AddWithValue("@p8", _year)
            cmd.Parameters.AddWithValue("@p9", _edition)
            cmd.Parameters.AddWithValue("@p10", _qty_people)
            cmd.Parameters.AddWithValue("@p11", GBUsername)
            cmd.Parameters.AddWithValue("@p12", DateTime.Now)
            cmd.Parameters.AddWithValue("@p13", var_id)
            SqlDB.Exec(cmd)
            message = "บันทึกข้อมูลเรียบร้อย"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Add(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = String.Empty
        Try
            strcommand = "insert into hd_resultdev_master ("
            strcommand = strcommand & vbCrLf & "corp,branch,rdm_id,rdm_date,rdm_code,rdm_annual_master,rdm_course_master"
            strcommand = strcommand & vbCrLf & ",rdm_main_hour,rdm_ann_year,rdm_ann_edition,rdm_ann_qty_people"
            strcommand = strcommand & vbCrLf & ",rdm_create_by,rdm_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _doc_date)
            cmd.Parameters.AddWithValue("@p5", _doc_code)
            cmd.Parameters.AddWithValue("@p6", _ann_master)
            cmd.Parameters.AddWithValue("@p7", _course_master)
            cmd.Parameters.AddWithValue("@p8", _main_hour)
            cmd.Parameters.AddWithValue("@p9", _year)
            cmd.Parameters.AddWithValue("@p10", _edition)
            cmd.Parameters.AddWithValue("@p11", _qty_people)
            cmd.Parameters.AddWithValue("@p12", GBUsername)
            cmd.Parameters.AddWithValue("@p13", DateTime.Now)
            SqlDB.Exec(cmd)
            message = "บันทึกข้อมูลเรียบร้อยแล้ว"
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
        Dim bSucc As Boolean = True
        Try
            strcommand = "delete from hd_resultdev_master "
            strcommand = strcommand & vbCrLf & "where rdm_id=? "
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
        _doc_date = cNull(dt.Rows(0).Item("rdm_date"), "D")
        _doc_code = cNull(dt.Rows(0).Item("rdm_code"), "S")
        _ann_master = cNull(dt.Rows(0).Item("rdm_annual_master"), "S")
        _course_master = cNull(dt.Rows(0).Item("rdm_course_master"), "S")
        _main_hour = cNull(dt.Rows(0).Item("rdm_main_hour"), "N")
        _year = cNull(dt.Rows(0).Item("rdm_ann_year"), "S")
        _edition = cNull(dt.Rows(0).Item("rdm_ann_edition"), "N")
        _qty_people = cNull(dt.Rows(0).Item("rdm_ann_qty_people"), "N")
    End Sub

    Public ReadOnly Property Item_RecordDevDetail() As Collection
        Get
            Return pmethGetRecordDevDetail()
        End Get
    End Property

    Private Function pmethGetRecordDevDetail() As Collection
        Dim Col_Data As New Collection
        Dim RecordDevDetail As New Record_Development_Detail
        RecordDevDetail.resultdev_master = var_id
        Dim dt As DataTable = RecordDevDetail.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim RecordDevDetail2 As New Record_Development_Detail
                RecordDevDetail2.id = cNull(dt.Rows(row).Item("rdd_id"), "S")
                RecordDevDetail2.resultdev_master = cNull(dt.Rows(row).Item("rdd_resultdev_master"), "S")
                RecordDevDetail2.annual_detail = cNull(dt.Rows(row).Item("rdd_annual_detail"), "S")
                RecordDevDetail2.seq = cNull(dt.Rows(row).Item("rdd_seq"), "N")
                RecordDevDetail2.person_data = cNull(dt.Rows(row).Item("rdd_person_data"), "S")
                RecordDevDetail2.position = cNull(dt.Rows(row).Item("rdd_position"), "S")
                RecordDevDetail2.station = cNull(dt.Rows(row).Item("rdd_station"), "S")
                RecordDevDetail2.join = cNull(dt.Rows(row).Item("rdd_join"), "S")
                RecordDevDetail2.passed = cNull(dt.Rows(row).Item("rdd_passed"), "S")
                RecordDevDetail2.score = cNull(dt.Rows(row).Item("rdd_score"), "N")
                Col_Data.Add(RecordDevDetail2)
            Next
        End If
        Return Col_Data
    End Function
End Class
