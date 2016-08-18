Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Budget_Master
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Private _doc_date As DateTime = DateTime.Now.Date
    Private _doc_code As String = String.Empty
    Private _annual_master As String = String.Empty

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

    Public Property annual_master() As String
        Get
            Return _annual_master
        End Get
        Set(value As String)
            _annual_master = value
        End Set
    End Property

    Public ReadOnly Property expannual_master() As Cls_Annual_Master
        Get
            Return New Cls_Annual_Master(_annual_master)
        End Get
    End Property

    Public Sub Clear()
        var_id = String.Empty
        _doc_date = DateTime.Now.Date
        _doc_code = String.Empty
        _annual_master = String.Empty

    End Sub

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
                strwc = " and bum_id= '" & var_id.ToString() & "'"
            End If
            strcommand = "SELECT * FROM hd_budget_master WHERE corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & " and bum_date between ? and ? "
            strcommand = strcommand & vbCrLf & " ORDER BY bum_code "
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
                strwc = " and bum_id= '" & var_id.ToString() & "'"
            End If
            strcommand = "SELECT * FROM hd_budget_master WHERE corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "ORDER BY bum_code"
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
            strcommand = "update hd_budget_master set "
            strcommand = strcommand & vbCrLf & "corp = ? "
            strcommand = strcommand & vbCrLf & ",branch = ? "
            strcommand = strcommand & vbCrLf & ",bum_date = ? "
            strcommand = strcommand & vbCrLf & ",bum_code = ? "
            strcommand = strcommand & vbCrLf & ",bum_annual_master = ? "
            strcommand = strcommand & vbCrLf & ",bum_edit_by = ? "
            strcommand = strcommand & vbCrLf & ",bum_edit_date = ? "
            strcommand = strcommand & vbCrLf & " where bum_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _doc_date)
            cmd.Parameters.AddWithValue("@p4", _doc_code)
            cmd.Parameters.AddWithValue("@p5", _annual_master)
            cmd.Parameters.AddWithValue("@p6", GBUsername)
            cmd.Parameters.AddWithValue("@p7", DateTime.Now)
            cmd.Parameters.AddWithValue("@p8", var_id)
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
            strcommand = "insert into hd_budget_master ("
            strcommand = strcommand & vbCrLf & "corp,branch,bum_id,bum_date,bum_code,bum_annual_master,bum_create_by,bum_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _doc_date)
            cmd.Parameters.AddWithValue("@p5", _doc_code)
            cmd.Parameters.AddWithValue("@p6", _annual_master)
            cmd.Parameters.AddWithValue("@p7", GBUsername)
            cmd.Parameters.AddWithValue("@p8", DateTime.Now)
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
            strcommand = "delete from hd_budget_master  "
            strcommand = strcommand & vbCrLf & "where bum_id =? "
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
        _doc_date = cNull(dt.Rows(0).Item("bum_date"), "D")
        _doc_code = cNull(dt.Rows(0).Item("bum_code"), "S")
        _annual_master = cNull(dt.Rows(0).Item("bum_annual_master"), "S")
    End Sub

    Public ReadOnly Property Item_BudgetDetail() As Collection
        Get
            Return pmethGetBudgetDetail()
        End Get
    End Property

    Private Function pmethGetBudgetDetail() As Collection
        Dim Col_Data As New Collection
        Dim Budget_Detail As New Cls_Budget_Detail
        Budget_Detail.budget_master = var_id
        Dim dt As DataTable = Budget_Detail.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim budget2_detail As New Cls_Budget_Detail
                budget2_detail.id = cNull(dt.Rows(row).Item("bud_id"), "S")
                budget2_detail.budget_master = cNull(dt.Rows(row).Item("bud_budget_master"), "S")
                budget2_detail.annual_budget = cNull(dt.Rows(row).Item("bud_annual_budget"), "S")
                budget2_detail.seq = cNull(dt.Rows(row).Item("bud_seq"), "N")
                budget2_detail.plan_cost = cNull(dt.Rows(row).Item("bud_plan_cost"), "S")
                budget2_detail.plan_qty_people = cNull(dt.Rows(row).Item("bud_plan_qty_people"), "N")
                budget2_detail.plan_rate = cNull(dt.Rows(row).Item("bud_plan_rate"), "N")
                budget2_detail.plan_amt_money = cNull(dt.Rows(row).Item("bud_plan_amt_money"), "N")
                budget2_detail.actual_qty_people = cNull(dt.Rows(row).Item("bud_actual_qty_people"), "N")
                budget2_detail.actual_rate = cNull(dt.Rows(row).Item("bud_actual_rate"), "N")
                budget2_detail.actual_amt_money = cNull(dt.Rows(row).Item("bud_actual_amt_money"), "N")
                'budget2_detail.annual_master = New Cls_Annual_Budget(dt.Rows(row).Item("bud_annual_budget").ToString()).annual_master
                Col_Data.Add(budget2_detail)
            Next
        End If
        Return Col_Data
    End Function

End Class
