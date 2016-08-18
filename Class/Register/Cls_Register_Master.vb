Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Register_Master
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
            'RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course_master"))
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
            'RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("year"))
        End Set
    End Property

    Public Property edition() As Integer
        Get
            Return _edition
        End Get
        Set(value As Integer)
            _edition = value
            'RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("edition"))
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
                strwc = " and reg_id='" & var_id.ToString() & "'"
            End If
            strcommand = "SELECT * FROM hd_register_master WHERE corp = '" & GBCorp & "'" & strwc
            strcommand = strcommand + " and reg_date between ? and ? "
            strcommand = strcommand + " ORDER BY reg_code"
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
                strwc = " and reg_id='" & var_id.ToString() & "'"
            End If
            strcommand = "SELECT * FROM hd_register_master WHERE corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "ORDER BY reg_code"
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function


    Function ChkDuplicate() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If _ann_master.Length > 0 Then
                strwc = " and reg_ann_master='" & _ann_master.ToString() & "'"
            Else
                dt.Clear()
                Return dt
                Exit Function
            End If
            strcommand = "SELECT * FROM hd_register_master WHERE corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "ORDER BY reg_code"
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
            strcommand = "update hd_register_master set "
            strcommand = strcommand & vbCrLf & "corp = ?"
            strcommand = strcommand & vbCrLf & ",branch = ?"
            strcommand = strcommand & vbCrLf & ",reg_date =?"
            strcommand = strcommand & vbCrLf & ",reg_code =?"
            strcommand = strcommand & vbCrLf & ",reg_ann_master =?"
            strcommand = strcommand & vbCrLf & ",reg_course_master =?"
            strcommand = strcommand & vbCrLf & ",reg_main_hour =?"
            strcommand = strcommand & vbCrLf & ",reg_ann_year =?"
            strcommand = strcommand & vbCrLf & ",reg_ann_edition =?"
            strcommand = strcommand & vbCrLf & ",reg_ann_qty_people =?"
            strcommand = strcommand & vbCrLf & ",reg_edit_by =?"
            strcommand = strcommand & vbCrLf & ",reg_edit_date =?"
            strcommand = strcommand & vbCrLf & " where reg_id =?"
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
            message = "บันทึกข้อมูลเรียบร้อยแล้ว"
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
            strcommand = "insert into hd_register_master ("
            strcommand = strcommand & vbCrLf & "corp,branch,reg_id,reg_date,reg_code,reg_ann_master,reg_course_master"
            strcommand = strcommand & vbCrLf & ",reg_main_hour,reg_ann_year,reg_ann_edition,reg_ann_qty_people"
            strcommand = strcommand & vbCrLf & ",reg_create_by,reg_create_date"
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

    Function Delete(SqlDb As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String
        Dim bSucc As Boolean = True
        Try
            strcommand = "delete from hd_register_master "
            strcommand = strcommand & vbCrLf & "where reg_id =? "
            cmd = SqlDb.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDb.Exec(cmd)
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
        _doc_date = cNull(dt.Rows(0).Item("reg_date"), "D")
        _doc_code = cNull(dt.Rows(0).Item("reg_code"), "S")
        _ann_master = cNull(dt.Rows(0).Item("reg_ann_master"), "S")
        _course_master = cNull(dt.Rows(0).Item("reg_course_master"), "S")
        _main_hour = cNull(dt.Rows(0).Item("reg_main_hour"), "N")
        _year = cNull(dt.Rows(0).Item("reg_ann_year"), "S")
        _edition = cNull(dt.Rows(0).Item("reg_ann_edition"), "N")
        _qty_people = cNull(dt.Rows(0).Item("reg_ann_qty_people"), "N")
    End Sub

    Public ReadOnly Property Item_RegisterDetail() As Collection
        Get
            Return pmethGetRegisterDetail()
        End Get
    End Property

    Private Function pmethGetRegisterDetail() As Collection
        Dim Col_Data As New Collection
        Dim Register_Detail As New Cls_Register_Detail
        Register_Detail.register = var_id
        Dim dt As DataTable = Register_Detail.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim register2_detail As New Cls_Register_Detail
                register2_detail.id = cNull(dt.Rows(row).Item("red_id"), "S")
                register2_detail.register = cNull(dt.Rows(row).Item("red_register"), "S")
                register2_detail.seq = cNull(dt.Rows(row).Item("red_seq"), "N")
                register2_detail.annual_detail = cNull(dt.Rows(row).Item("red_annual_detail"), "S")
                register2_detail.person_data = cNull(dt.Rows(row).Item("red_person_data"), "S")
                register2_detail.position = cNull(dt.Rows(row).Item("red_position"), "S")
                register2_detail.station = cNull(dt.Rows(row).Item("red_station"), "S")
                register2_detail.join = cNull(dt.Rows(row).Item("red_join"), "S")
                register2_detail.reg_datetime = cNull(dt.Rows(row).Item("red_reg_datetime"), "D")
                Col_Data.Add(register2_detail)
            Next
        End If
        Return Col_Data
    End Function
End Class
