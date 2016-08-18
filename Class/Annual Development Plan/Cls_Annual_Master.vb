Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Annual_Master
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Private _doc_date As DateTime = DateTime.Now.Date
    Private _doc_code As String = String.Empty
    Private _course_master As String = String.Empty
    Private _main_hour As Decimal = 0
    Private _year As String = String.Empty
    Private _edition As Integer = 0
    Private _qty As Integer = 0
    Private _position As String = String.Empty
    Private _roadmap As String = String.Empty
    Private _begdate As DateTime = DateTime.Now.Date
    Private _enddate As DateTime = DateTime.Now.Date
    Private _begtime As Decimal = 0
    Private _endtime As Decimal = 0
    Private _place As String = String.Empty
    Private _step As String = String.Empty
    Private _paystep As String = String.Empty

#Region "Constructure"

    Public Sub New()
    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub
#End Region

#Region "Property"
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
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("main_hour"))
        End Set
    End Property

    Public Property year() As String
        Get
            Return _year
        End Get
        Set(value As String)
            _year = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("year"))
        End Set
    End Property

    Public Property edition() As Integer
        Get
            Return _edition
        End Get
        Set(value As Integer)
            _edition = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("edition"))
        End Set
    End Property

    Public Property qty() As Integer
        Get
            Return _qty
        End Get
        Set(value As Integer)
            _qty = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("qty"))
        End Set
    End Property

    Public Property position() As String
        Get
            Return _position
        End Get
        Set(value As String)
            _position = value
        End Set
    End Property

    Public Property roadmap() As String
        Get
            Return _roadmap
        End Get
        Set(value As String)
            _roadmap = value
        End Set
    End Property

    Public Property begdate() As DateTime
        Get
            Return _begdate
        End Get
        Set(value As DateTime)
            _begdate = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("begdate"))
        End Set
    End Property

    Public Property enddate() As DateTime
        Get
            Return _enddate
        End Get
        Set(value As DateTime)
            _enddate = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("enddate"))
        End Set
    End Property

    Public Property begtime() As Decimal
        Get
            Return _begtime
        End Get
        Set(value As Decimal)
            _begtime = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("begtime"))
        End Set
    End Property

    Public Property endtime() As Decimal
        Get
            Return _endtime
        End Get
        Set(value As Decimal)
            _endtime = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("endtime"))
        End Set
    End Property

    Public Property place() As String
        Get
            Return _place
        End Get
        Set(value As String)
            _place = value
        End Set
    End Property

    Public Property getstep() As String
        Get
            Return _step
        End Get
        Set(value As String)
            _step = value
        End Set
    End Property

    Public Property paystep() As String
        Get
            Return _paystep
        End Get
        Set(value As String)
            _paystep = value
        End Set
    End Property

#End Region

#Region "EXP Property"
    Public ReadOnly Property expcourse() As Cls_HD_Course
        Get
            Return New Cls_HD_Course(New Cls_Course_Master(_course_master).course)
        End Get
    End Property

    Public ReadOnly Property expcourse_Master() As Cls_Course_Master
        Get
            Return New Cls_Course_Master(_course_master)
        End Get
    End Property

    Public ReadOnly Property expposition() As Cls_Position
        Get
            Return New Cls_Position(_position)
        End Get
    End Property

    Public ReadOnly Property exproammap() As Cls_HD_Roadmap_Master
        Get
            Return New Cls_HD_Roadmap_Master(_roadmap)
        End Get
    End Property

    Public ReadOnly Property expplace() As Cls_HD_Place
        Get
            Return New Cls_HD_Place(_place)
        End Get
    End Property

#End Region

#Region "Clear"
    Public Sub Clear()
        var_id = String.Empty
        _doc_date = DateTime.Now.Date
        _doc_code = String.Empty
        _course_master = String.Empty
        _main_hour = 0
        _year = String.Empty
        _edition = 0
        _qty = 0
        _position = String.Empty
        _roadmap = String.Empty
        _begdate = DateTime.Now.Date
        _enddate = DateTime.Now.Date
        _begtime = 0
        _endtime = 0
        _place = String.Empty
        _step = String.Empty
        _paystep = String.Empty
    End Sub

#End Region

#Region "Function ADD UPDATE DELETE RETREIVE GETBYID EMPTY"
    Function empty(GedMod As String) As Boolean
        If GedMod <> GBMod.Edit Then
            var_id = String.Empty
        End If
        var_id = String.Empty
        _doc_code = String.Empty
        Return True
    End Function

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
                strwc = " and anm_id='" & var_id.ToString() & "'"
            End If
            If _step.Length > 0 Then
                strwc = strwc & " and anm_step = '" & _step.ToString() & "'"
            End If

            If _paystep.Length > 0 Then
                strwc = strwc & " and anm_paystep = '" & _paystep.ToString() & "'"
            End If

            strcommand = "select * from hd_annual_master where corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & " and anm_date between ? and ? "
            strcommand = strcommand & vbCrLf & "order by anm_code "
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
                strwc = " and anm_id='" & var_id.ToString() & "'"
            End If
            If _step.Length > 0 Then
                strwc = strwc & " and anm_step = '" & _step.ToString() & "'"
            End If

            If _paystep.Length > 0 Then
                strwc = strwc & " and anm_paystep = '" & _paystep.ToString() & "'"
            End If

            strcommand = "select * from hd_annual_master where corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "order by anm_code "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function


    Function RetreiveByCourseName() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            Dim cmd As New OleDbCommand
            If var_id.Length > 0 Then
                strwc = " and anm.anm_id='" & var_id.ToString() & "'"
            End If

            If _course_master.Length > 0 Then
                strwc = strwc & " and anm.anm_course_master = '" & _course_master.ToString() & "'"
            End If

            If _year.Length > 0 Then
                strwc = strwc & " and anm.anm_year = '" & _year.ToString() & "'"
            End If

            If _edition > 0 Then
                strwc = strwc & " and anm.anm_edition = '" & _edition.ToString() & "'"
            End If

            strcommand = "SELECT *,CONCAT(anm.anm_code,'-',hc.cos_name) AS anm_name"
            strcommand = strcommand & vbCrLf & "FROM hd_annual_master anm"
            strcommand = strcommand & vbCrLf & "LEFT OUTER JOIN hd_course_master hcm  ON hcm.cms_id = anm.anm_course_master"
            strcommand = strcommand & vbCrLf & "LEFT OUTER JOIN hd_course hc ON hc.cos_id = hcm.cms_course"
            strcommand = strcommand & vbCrLf & "WHERE anm.corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "AND anm.anm_step IN('1','2') "
            'strcommand = strcommand & vbCrLf & "AND anm.anm_paystep NOT IN('2') "
            strcommand = strcommand & vbCrLf & "ORDER BY anm.anm_code "
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
            strcommand = "update hd_annual_master set "
            strcommand = strcommand & vbCrLf & "corp = ? "
            strcommand = strcommand & vbCrLf & ",branch = ? "
            strcommand = strcommand & vbCrLf & ",anm_date = ? "
            strcommand = strcommand & vbCrLf & ",anm_code = ? "
            strcommand = strcommand & vbCrLf & ",anm_course_master = ? "
            strcommand = strcommand & vbCrLf & ",anm_main_hour = ? " '5
            strcommand = strcommand & vbCrLf & ",anm_year = ? "
            strcommand = strcommand & vbCrLf & ",anm_edition = ? "

            strcommand = strcommand & vbCrLf & ",anm_qty_people = ? "
            strcommand = strcommand & vbCrLf & ",anm_position = ? "
            strcommand = strcommand & vbCrLf & ",anm_roadmap = ? " '10

            strcommand = strcommand & vbCrLf & ",anm_begdate = ? "
            strcommand = strcommand & vbCrLf & ",anm_enddate = ? "
            strcommand = strcommand & vbCrLf & ",anm_begtime = ? "
            strcommand = strcommand & vbCrLf & ",anm_endtime = ? "
            strcommand = strcommand & vbCrLf & ",anm_place = ? " '15

            strcommand = strcommand & vbCrLf & ",anm_step = ? " '16
            strcommand = strcommand & vbCrLf & ",anm_paystep = ? " '17

            strcommand = strcommand & vbCrLf & ",anm_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",anm_edit_date = ? "
            strcommand = strcommand & vbCrLf & "where anm_id =?"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _doc_date)
            cmd.Parameters.AddWithValue("@p4", _doc_code)
            cmd.Parameters.AddWithValue("@p5", _course_master)
            cmd.Parameters.AddWithValue("@p6", _main_hour) '5
            cmd.Parameters.AddWithValue("@p7", _year)
            cmd.Parameters.AddWithValue("@p8", _edition)
            cmd.Parameters.AddWithValue("@p9", _qty)
            cmd.Parameters.AddWithValue("@p10", _position)
            cmd.Parameters.AddWithValue("@p11", _roadmap) '5

            cmd.Parameters.AddWithValue("@p12", _begdate)
            cmd.Parameters.AddWithValue("@p13", _enddate)
            cmd.Parameters.AddWithValue("@p14", _begtime)
            cmd.Parameters.AddWithValue("@p15", _endtime)
            cmd.Parameters.AddWithValue("@p16", _place) '5

            cmd.Parameters.AddWithValue("@p17", _step)
            cmd.Parameters.AddWithValue("@p18", _paystep)

            cmd.Parameters.AddWithValue("@p19", GBUsername)
            cmd.Parameters.AddWithValue("@p20", DateTime.Now)
            cmd.Parameters.AddWithValue("@p21", var_id)
            SqlDB.Exec(cmd)
            message = "บันทึกข้อมูลเรียบร้อยแล้ว"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function UpdateFrom_Budget(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Try
            strcommand = "update hd_annual_master set "
            strcommand = strcommand & vbCrLf & "corp = ? "
            strcommand = strcommand & vbCrLf & ",anm_paystep = ? " '17
            strcommand = strcommand & vbCrLf & ",anm_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",anm_edit_date = ? "
            strcommand = strcommand & vbCrLf & "where anm_id =?"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", _paystep)
            cmd.Parameters.AddWithValue("@p3", GBUsername)
            cmd.Parameters.AddWithValue("@p4", DateTime.Now)
            cmd.Parameters.AddWithValue("@p5", var_id)
            SqlDB.Exec(cmd)
            message = "บันทึกข้อมูลเรียบร้อยแล้ว"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function UpdateFrom_Register(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Try
            strcommand = "update hd_annual_master set "
            strcommand = strcommand & vbCrLf & "corp = ? "
            strcommand = strcommand & vbCrLf & ",anm_step = ? " '17
            strcommand = strcommand & vbCrLf & ",anm_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",anm_edit_date = ? "
            strcommand = strcommand & vbCrLf & "where anm_id =?"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", _step)
            cmd.Parameters.AddWithValue("@p3", GBUsername)
            cmd.Parameters.AddWithValue("@p4", DateTime.Now)
            cmd.Parameters.AddWithValue("@p5", var_id)
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
        Dim strErrmsg As String = ""
        Try
            strcommand = "insert into hd_annual_master("
            strcommand = strcommand & vbCrLf & "corp,branch,anm_id,anm_date,anm_code,anm_course_master,anm_main_hour,anm_year"
            strcommand = strcommand & vbCrLf & ",anm_edition,anm_qty_people,anm_position,anm_roadmap,anm_begdate,anm_enddate"
            strcommand = strcommand & vbCrLf & ",anm_begtime,anm_endtime,anm_place,anm_step,anm_paystep,anm_create_by,anm_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p1", var_Branch_id)
            cmd.Parameters.AddWithValue("@p2", var_id)
            cmd.Parameters.AddWithValue("@p3", _doc_date)
            cmd.Parameters.AddWithValue("@p4", _doc_code)
            cmd.Parameters.AddWithValue("@p5", _course_master)
            cmd.Parameters.AddWithValue("@p6", _main_hour)
            cmd.Parameters.AddWithValue("@p7", _year)
            cmd.Parameters.AddWithValue("@p8", _edition)
            cmd.Parameters.AddWithValue("@p9", _qty)
            cmd.Parameters.AddWithValue("@p10", _position)
            cmd.Parameters.AddWithValue("@p11", _roadmap)

            cmd.Parameters.AddWithValue("@p12", _begdate)
            cmd.Parameters.AddWithValue("@p13", _enddate)
            cmd.Parameters.AddWithValue("@p14", _begtime)
            cmd.Parameters.AddWithValue("@p15", _endtime)
            cmd.Parameters.AddWithValue("@p16", _place)
            cmd.Parameters.AddWithValue("@p17", _step)
            cmd.Parameters.AddWithValue("@p18", _paystep)
            cmd.Parameters.AddWithValue("@p19", GBUsername)
            cmd.Parameters.AddWithValue("@p20", DateTime.Now)
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
            strcommand = "delete from hd_annual_master "
            strcommand = strcommand & vbCrLf & "where anm_id =? "
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
#End Region

#Region "Set Property CNull &  Load Collection"
    Private Sub pmethSetproperty(dt As DataTable)
        _doc_date = cNull(dt.Rows(0).Item("anm_date"), "D")
        _doc_code = cNull(dt.Rows(0).Item("anm_code"), "S")
        _course_master = cNull(dt.Rows(0).Item("anm_course_master"), "S")
        _main_hour = cNull(dt.Rows(0).Item("anm_main_hour"), "N")
        _year = cNull(dt.Rows(0).Item("anm_year"), "S")
        _edition = cNull(dt.Rows(0).Item("anm_edition"), "N")
        _qty = cNull(dt.Rows(0).Item("anm_qty_people"), "N")
        _position = cNull(dt.Rows(0).Item("anm_position"), "S")
        _roadmap = cNull(dt.Rows(0).Item("anm_roadmap"), "S")
        _begdate = cNull(dt.Rows(0).Item("anm_begdate"), "D")
        _enddate = cNull(dt.Rows(0).Item("anm_enddate"), "D")
        _begtime = cNull(dt.Rows(0).Item("anm_begtime"), "N")
        _endtime = cNull(dt.Rows(0).Item("anm_endtime"), "N")
        _place = cNull(dt.Rows(0).Item("anm_place"), "S")
        _step = cNull(dt.Rows(0).Item("anm_step"), "S")
        _paystep = cNull(dt.Rows(0).Item("anm_paystep"), "S")

    End Sub

    Public ReadOnly Property Item_AnnualDetail() As Collection
        Get
            Return pmethGetAnnualDetail()
        End Get
    End Property

    Public ReadOnly Property Item_AnnualBudget() As Collection
        Get
            Return pmethGetAnnualBudget()
        End Get
    End Property

    Private Function pmethGetAnnualDetail() As Collection
        Dim Col_Data As New Collection
        Dim annd As New Cls_Annual_Detail()
        annd.annual_master = var_id
        Dim dt As DataTable = annd.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim Andd2 As New Cls_Annual_Detail
                Andd2.id = cNull(dt.Rows(row).Item("and_id"), "S")
                Andd2.annual_master = cNull(dt.Rows(row).Item("and_annual_master"), "S")
                Andd2.seq = cNull(dt.Rows(row).Item("and_seq"), "N")
                Andd2.person_data = cNull(dt.Rows(row).Item("and_person_data"), "S")
                Andd2.position = cNull(dt.Rows(row).Item("and_position"), "S")
                Col_Data.Add(Andd2)
            Next
        End If
        Return Col_Data
    End Function

    Private Function pmethGetAnnualBudget() As Collection
        Dim Col_Data As New Collection
        Dim anb As New Cls_Annual_Budget()
        anb.annual_master = var_id
        Dim dt As DataTable = anb.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim anb2 As New Cls_Annual_Budget
                anb2.id = cNull(dt.Rows(row).Item("anb_id"), "S")
                anb2.annual_master = cNull(dt.Rows(row).Item("anb_annual_master"), "S")
                anb2.cost = cNull(dt.Rows(row).Item("anb_cost"), "S")
                anb2.seq = cNull(dt.Rows(row).Item("anb_seq"), "S")
                anb2.qty_people = cNull(dt.Rows(row).Item("anb_qty_people"), "N")
                anb2.rate = cNull(dt.Rows(row).Item("anb_rate"), "N")
                anb2.amt_money = cNull(dt.Rows(row).Item("anb_amt_money"), "N")

                'Andd2.seq = cNull(dt.Rows(row).Item("and_seq"), "N")
                'Andd2.person_data = cNull(dt.Rows(row).Item("and_person_data"), "S")
                'Andd2.position = cNull(dt.Rows(row).Item("and_position"), "S")

                Col_Data.Add(anb2)
            Next
        End If
        Return Col_Data
    End Function

#End Region

End Class