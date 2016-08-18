Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Annual_Budget
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Private _annual_master As String = String.Empty
    Private _seq As Integer
    Private _cost As String = String.Empty
    Private _qty_people As Integer = 0
    Private _rate As Double
    Private _amt_money As Double

#Region "Constructor"

    Public Sub New()

    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub

#End Region

#Region "Property"
    Public Property annual_master() As String
        Get
            Return _annual_master
        End Get
        Set(value As String)
            _annual_master = value
        End Set
    End Property

    Public Property seq() As Integer
        Get
            Return _seq
        End Get
        Set(value As Integer)
            _seq = value
        End Set
    End Property

    Public Property cost() As String
        Get
            Return _cost
        End Get
        Set(value As String)
            _cost = value
        End Set
    End Property

    Public Property qty_people() As Integer
        Get
            Return _qty_people
        End Get
        Set(value As Integer)
            _qty_people = value
        End Set
    End Property

    Public Property rate() As Double
        Get
            Return _rate
        End Get
        Set(value As Double)
            _rate = value
        End Set
    End Property

    Public Property amt_money() As Double
        Get
            Return _amt_money
        End Get
        Set(value As Double)
            _amt_money = value
        End Set
    End Property

#End Region

#Region "EXP Property"
    Public ReadOnly Property expcost() As Cls_HD_Cost
        Get
            Return New Cls_HD_Cost(_cost)
        End Get
    End Property
#End Region

#Region "Clear"
    Public Sub clear()
        var_id = String.Empty
        _annual_master = String.Empty
        _seq = 0
        _cost = String.Empty
        _qty_people = 0
        _rate = 0
        _amt_money = 0
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
                strwc = " and anb_id ='" & var_id.ToString() & "'"
            End If
            If _annual_master.Length > 0 Then
                strwc = strwc & " and anb_annual_master ='" & _annual_master.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_annual_budget where corp ='" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by anb_seq "
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
            strcommand = "insert into hd_annual_budget("
            strcommand = strcommand & vbCrLf & "corp ,branch ,anb_id,anb_annual_master,anb_seq,anb_cost"
            strcommand = strcommand & vbCrLf & ",anb_qty_people,anb_rate,anb_amt_money,anb_create_by,anb_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _annual_master)
            cmd.Parameters.AddWithValue("@p5", _seq)
            cmd.Parameters.AddWithValue("@p6", _cost)
            cmd.Parameters.AddWithValue("@p7", _qty_people)
            cmd.Parameters.AddWithValue("@p8", _rate)
            cmd.Parameters.AddWithValue("@p9", _amt_money)
            cmd.Parameters.AddWithValue("@p10", GBUsername)
            cmd.Parameters.AddWithValue("@p11", DateTime.Now)
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
            strcommand = "update hd_annual_budget"
            strcommand = strcommand & vbCrLf & "set corp = ? "
            strcommand = strcommand & vbCrLf & ",branch = ? "
            strcommand = strcommand & vbCrLf & ",anb_annual_master = ? "
            strcommand = strcommand & vbCrLf & ",anb_seq = ? "
            strcommand = strcommand & vbCrLf & ",anb_cost = ? "
            strcommand = strcommand & vbCrLf & ",anb_qty_people = ? "
            strcommand = strcommand & vbCrLf & ",anb_rate = ? "
            strcommand = strcommand & vbCrLf & ",anb_amt_money = ? "
            strcommand = strcommand & vbCrLf & ",anb_edit_by = ? "
            strcommand = strcommand & vbCrLf & ",anb_edit_date = ? "
            strcommand = strcommand & vbCrLf & "where anb_id = ?"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _annual_master)
            cmd.Parameters.AddWithValue("@p4", _seq)
            cmd.Parameters.AddWithValue("@p5", _cost)
            cmd.Parameters.AddWithValue("@p6", _qty_people)
            cmd.Parameters.AddWithValue("@p7", _rate)
            cmd.Parameters.AddWithValue("@p8", _amt_money)
            cmd.Parameters.AddWithValue("@p9", GBUsername)
            cmd.Parameters.AddWithValue("@p10", DateTime.Now)
            cmd.Parameters.AddWithValue("@p11", var_id)
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
            strcommand = "delete from hd_annual_budget "
            strcommand = strcommand & vbCrLf & "where anb_id = ?"
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
                _annual_master = cNull(dt.Rows(row).Item("anb_annual_master"), "S")
                _seq = cNull(dt.Rows(row).Item("anb_seq"), "N")
                _cost = cNull(dt.Rows(row).Item("anb_cost"), "S")
                _qty_people = cNull(dt.Rows(row).Item("anb_qty_people"), "N")
                _rate = cNull(dt.Rows(row).Item("anb_rate"), "N")
                _amt_money = cNull(dt.Rows(row).Item("anb_amt_money"), "N")
            Next
        End If
    End Sub
#End Region

End Class
