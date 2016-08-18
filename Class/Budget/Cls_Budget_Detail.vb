Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Budget_Detail
    Inherits Cls_Base
    Implements INotifyPropertyChanged

    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Public Sub New()
    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub

    Private _budget_master As String = String.Empty
    Public Property budget_master() As String
        Get
            Return _budget_master
        End Get
        Set(value As String)
            _budget_master = value
        End Set
    End Property

    Private _annual_budget As String = String.Empty
    Public Property annual_budget() As String
        Get
            Return _annual_budget
        End Get
        Set(value As String)
            _annual_budget = value
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

    Private _plan_cost As String = String.Empty
    Public Property plan_cost() As String
        Get
            Return _plan_cost
        End Get
        Set(value As String)
            _plan_cost = value
        End Set
    End Property


    Private _plan_qty_people As Integer
    Public Property plan_qty_people() As Integer
        Get
            Return _plan_qty_people
        End Get
        Set(value As Integer)
            _plan_qty_people = value
        End Set
    End Property

    Private _plan_rate As Decimal
    Public Property plan_rate() As Decimal
        Get
            Return _plan_rate
        End Get
        Set(value As Decimal)
            _plan_rate = value
        End Set
    End Property

    Private _plan_amt_money As Decimal
    Public Property plan_amt_money() As Decimal
        Get
            Return _plan_amt_money
        End Get
        Set(value As Decimal)
            _plan_amt_money = value
        End Set
    End Property

    Private _actual_qty_people As Integer
    Public Property actual_qty_people() As Integer
        Get
            Return _actual_qty_people
        End Get
        Set(value As Integer)
            _actual_qty_people = value
        End Set
    End Property

    Private _actual_rate As Decimal
    Public Property actual_rate() As Decimal
        Get
            Return _actual_rate
        End Get
        Set(value As Decimal)
            _actual_rate = value
        End Set
    End Property

    Private _actual_amt_money As Decimal
    Public Property actual_amt_money() As Decimal
        Get
            Return _actual_amt_money
        End Get
        Set(value As Decimal)
            _actual_amt_money = value
        End Set
    End Property

    Public ReadOnly Property expannual_budget() As Cls_Annual_Budget
        Get
            Return New Cls_Annual_Budget(_annual_budget)
        End Get
    End Property

    Public ReadOnly Property exphd_cost() As Cls_HD_Cost
        Get
            Return New Cls_HD_Cost(_plan_cost)
        End Get
    End Property

    'Private _annual_master As String = String.Empty
    'Public Property annual_master() As String
    '    Get
    '        Return _annual_master
    '    End Get
    '    Set(value As String)
    '        _annual_master = value
    '    End Set
    'End Property


    Public Sub clear()
        var_id = String.Empty
        _budget_master = String.Empty
        _annual_budget = String.Empty
        _seq = 0
        _plan_cost = String.Empty
        _plan_qty_people = 0
        _plan_rate = 0
        _plan_amt_money = 0
        _actual_qty_people = 0
        _actual_rate = 0
        _actual_amt_money = 0
        '_annual_master = String.Empty

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
                strwc = " and bud_id ='" & var_id.ToString() & "'"
            End If
            If _budget_master.Length > 0 Then
                strwc = strwc & " and bud_budget_master ='" & _budget_master.ToString() & "'"
            End If
            strcommand = "select * from hd_budget_detail "
            strcommand = strcommand & vbCrLf & " where corp='" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & " order by bud_seq "
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
        Dim strErrmsg As String = String.Empty
        Try
            strcommand = "insert into hd_budget_detail ("
            strcommand = strcommand & vbCrLf & "corp,branch,bud_id,bud_budget_master,bud_annual_budget,bud_seq"
            strcommand = strcommand & vbCrLf & ",bud_plan_cost,bud_plan_qty_people,bud_plan_rate"
            strcommand = strcommand & vbCrLf & ",bud_plan_amt_money,bud_actual_qty_people,bud_actual_rate"
            strcommand = strcommand & vbCrLf & ",bud_actual_amt_money,bud_create_by,bud_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _budget_master)
            cmd.Parameters.AddWithValue("@p5", _annual_budget)
            cmd.Parameters.AddWithValue("@p6", _seq)
            cmd.Parameters.AddWithValue("@p7", _plan_cost)
            cmd.Parameters.AddWithValue("@p8", _plan_qty_people)
            cmd.Parameters.AddWithValue("@p9", _plan_rate)
            cmd.Parameters.AddWithValue("@p10", _plan_amt_money)
            cmd.Parameters.AddWithValue("@p11", _actual_qty_people)
            cmd.Parameters.AddWithValue("@p12", _actual_rate)
            cmd.Parameters.AddWithValue("@p13", _actual_amt_money)
            cmd.Parameters.AddWithValue("@p14", GBUsername)
            cmd.Parameters.AddWithValue("@p15", DateTime.Now)
            SqlDB.Exec(cmd)
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Update(SqlDb As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = String.Empty
        Try
            strcommand = "update hd_budget_detail "
            strcommand = strcommand & vbCrLf & "set corp = ? "
            strcommand = strcommand & vbCrLf & ",branch = ? "
            strcommand = strcommand & vbCrLf & ",bud_budget_master = ? "
            strcommand = strcommand & vbCrLf & ",bud_annual_budget = ? "
            strcommand = strcommand & vbCrLf & ",bud_seq = ? "
            strcommand = strcommand & vbCrLf & ",bud_plan_cost = ? "
            strcommand = strcommand & vbCrLf & ",bud_plan_qty_people= ? "
            strcommand = strcommand & vbCrLf & ",bud_plan_rate = ? "
            strcommand = strcommand & vbCrLf & ",bud_plan_amt_money = ? "
            strcommand = strcommand & vbCrLf & ",bud_actual_qty_people = ? "
            strcommand = strcommand & vbCrLf & ",bud_actual_rate = ? "
            strcommand = strcommand & vbCrLf & ",bud_actual_amt_money = ? "
            strcommand = strcommand & vbCrLf & ",bud_edit_by = ? "
            strcommand = strcommand & vbCrLf & ",bud_edit_date = ? "
            strcommand = strcommand & vbCrLf & "where bud_id = ?"
            cmd = SqlDb.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _budget_master)
            cmd.Parameters.AddWithValue("@p4", _annual_budget)
            cmd.Parameters.AddWithValue("@p5", _seq)
            cmd.Parameters.AddWithValue("@p6", _plan_cost)
            cmd.Parameters.AddWithValue("@p7", _plan_qty_people)
            cmd.Parameters.AddWithValue("@p8", _plan_rate)
            cmd.Parameters.AddWithValue("@p9", _plan_amt_money)
            cmd.Parameters.AddWithValue("@p10", _actual_qty_people)
            cmd.Parameters.AddWithValue("@p11", _actual_rate)
            cmd.Parameters.AddWithValue("@p12", _actual_amt_money)
            cmd.Parameters.AddWithValue("@p13", GBUsername)
            cmd.Parameters.AddWithValue("@p14", DateTime.Now)
            cmd.Parameters.AddWithValue("@p15", var_id)
            SqlDb.Exec(cmd)
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
            strcommand = "delete from hd_budget_detail "
            strcommand = strcommand & vbCrLf & "where bud_id =? "
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

    Public Sub SetProperty(dt As DataTable)
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                _budget_master = cNull(dt.Rows(row).Item("bud_budget_master"), "S")
                _annual_budget = cNull(dt.Rows(row).Item("bud_annual_budget"), "S")
                _seq = cNull(dt.Rows(row).Item("bud_seq"), "N")
                _plan_cost = cNull(dt.Rows(row).Item("bud_plan_cost"), "S")
                _plan_qty_people = cNull(dt.Rows(row).Item("bud_plan_qty_people"), "N")
                _plan_rate = cNull(dt.Rows(row).Item("bud_plan_rate"), "N")
                _plan_amt_money = cNull(dt.Rows(row).Item("bud_plan_amt_money"), "N")
                _actual_qty_people = cNull(dt.Rows(row).Item("bud_actual_qty_people"), "N")
                _actual_rate = cNull(dt.Rows(row).Item("bud_actual_rate"), "N")
                _actual_amt_money = cNull(dt.Rows(row).Item("bud_actual_amt_money"), "N")
            Next
        End If
    End Sub
End Class
