Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Cls_HD_Budget
    Inherits Cls_Base
    Private var_code As String = String.Empty
    Private var_name As String = String.Empty
    Private var_name2 As String = String.Empty
    Private var_amt As Double = 0
    Private var_year As String = String.Empty
    Private var_begdate As String = String.Empty
    Private var_enddate As String = String.Empty
    Private var_desc As String = String.Empty
    Private var_station As String = String.Empty

    Public Sub New()
    End Sub
    Public Sub New(id As String)
        If String.Empty.Equals(id) = False Then
            Me.getById(id)
        End If
    End Sub

    Public ReadOnly Property expStation As Cls_Station
        Get
            Return New Cls_Station(var_station)
        End Get
    End Property

#Region "Property"
    Public Property code() As String
        Get
            Return var_code
        End Get
        Set(ByVal value As String)
            var_code = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return var_name
        End Get
        Set(ByVal value As String)
            var_name = value
        End Set
    End Property


    Public Property name2() As String
        Get
            Return var_name2
        End Get
        Set(ByVal value As String)
            var_name2 = value
        End Set
    End Property

    Public Property amt() As Double
        Get
            Return var_amt
        End Get
        Set(value As Double)
            var_amt = value
        End Set
    End Property

    Public Property year() As String
        Get
            Return var_year
        End Get
        Set(value As String)
            var_year = value
        End Set
    End Property

    Public Property begdate() As String
        Get
            Return var_begdate
        End Get
        Set(value As String)
            var_begdate = value
        End Set
    End Property

    Public Property enddate() As String
        Get
            Return var_enddate
        End Get
        Set(value As String)
            var_enddate = value
        End Set
    End Property

    Public Property desc() As String
        Get
            Return var_desc
        End Get
        Set(ByVal value As String)
            var_desc = value
        End Set
    End Property

    Public Property station() As String
        Get
            Return var_station
        End Get
        Set(ByVal value As String)
            var_station = value
        End Set
    End Property

#End Region

#Region "Function"

    Function empty(GedMod As String) As Boolean
        If GedMod <> GBMod.Edit Then
            var_id = String.Empty
        End If
        var_corp_id = String.Empty
        var_code = String.Empty
        var_name = String.Empty
        var_name2 = String.Empty
        var_amt = 0
        var_year = String.Empty
        var_begdate = String.Empty
        var_enddate = String.Empty
        var_desc = String.Empty
        strfuncnm = String.Empty
        Return True
    End Function

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        var_corp_id = dt.Rows(0).Item("bgt_corp_id").ToString()
        var_id = dt.Rows(0).Item("bgt_id").ToString()
        'aaa
        'var_code = dt.Rows(0).Item("bgt_code").ToString()
        'var_name = dt.Rows(0).Item("bgt_name").ToString()
        'var_name2 = dt.Rows(0).Item("bgt_name2").ToString()
        var_station = dt.Rows(0).Item("bgt_station").ToString()
        var_amt = dt.Rows(0).Item("bgt_amt")
        var_year = dt.Rows(0).Item("bgt_year").ToString()
        var_begdate = dt.Rows(0).Item("bgt_begdate").ToString()
        var_enddate = dt.Rows(0).Item("bgt_enddate").ToString()
        var_desc = dt.Rows(0).Item("bgt_desc").ToString()
        Return True
    End Function

    Function CheckDupCode() As Boolean
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim strwc As String = String.Empty
            Dim strcommand As String = ""
            strcommand = "select 1 from hd_budget "
            If var_id.Length > 0 Then
                strwc = " and bgt_id <> '" & var_id.ToString() & "'"
            End If
            'strcommand = strcommand & vbCrLf & " where bgt_corp_id = ? and bgt_code = ? " + strwc
            strcommand = strcommand & vbCrLf & " where bgt_corp_id = ? " + strwc

            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_corp_id)
            'cmd.Parameters.AddWithValue("@p2", var_code)
            dt = SqlDB.GetDataTable(cmd)
            If dt.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
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
                strwc = " and bgt_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_budget where bgt_corp_id = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by bgt_begdate "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt

            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Add() As Boolean
        Dim SqlDB As New Cls_SqlDB
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = ""
        Try
            SqlDB.BeginTrans()
            'aaa
            'strcommand = "insert into hd_budget(bgt_corp_id,bgt_id"
            'strcommand = strcommand & vbCrLf & ",bgt_code,bgt_name,bgt_name2,bgt_amt,bgt_begdate,bgt_enddate,bgt_desc,bgt_create_by,bgt_create_date)"
            'strcommand = strcommand & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?,?)"
            strcommand = "insert into hd_budget(bgt_corp_id,bgt_id"
            strcommand = strcommand & vbCrLf & ",bgt_station,bgt_amt,bgt_begdate,bgt_enddate,bgt_desc,bgt_create_by,bgt_create_date)"
            strcommand = strcommand & vbCrLf & "values(?,?,?,?,?,?,?,?,?)"

            cmd = SqlDB.CreateCommand(strcommand)
            Dim strId As String = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", strId)
            cmd.Parameters.AddWithValue("@p3", var_station)
            'cmd.Parameters.AddWithValue("@p4", var_name)
            'cmd.Parameters.AddWithValue("@p5", var_name2)
            cmd.Parameters.AddWithValue("@p4", var_amt)
            cmd.Parameters.AddWithValue("@p5", Convert.ToDateTime(var_begdate))
            cmd.Parameters.AddWithValue("@p6", Convert.ToDateTime(var_enddate))
            cmd.Parameters.AddWithValue("@p7", var_desc)
            cmd.Parameters.AddWithValue("@p8", GBUsername)
            cmd.Parameters.AddWithValue("@p9", DateTime.Now)
            SqlDB.Exec(cmd)
            SqlDB.CommitTrans()
            message = "บันทึกข้อมูลเรียบร้อยแล้ว"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            SqlDB.RollbackTrans()

            Return False
        End Try
    End Function

    Function Update() As Boolean
        Dim SqlDB As New Cls_SqlDB
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Try
            SqlDB.BeginTrans()
            strcommand = "update hd_budget"
            strcommand = strcommand & vbCrLf & "set bgt_station = ?"
            'strcommand = strcommand & vbCrLf & ",bgt_name = ?"
            'strcommand = strcommand & vbCrLf & ",bgt_name2 = ?"
            strcommand = strcommand & vbCrLf & ",bgt_amt = ?"
            strcommand = strcommand & vbCrLf & ",bgt_begdate = ?"
            strcommand = strcommand & vbCrLf & ",bgt_enddate = ?"
            strcommand = strcommand & vbCrLf & ",bgt_Desc = ?"
            strcommand = strcommand & vbCrLf & ",bgt_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",bgt_edit_date= ?"
            strcommand = strcommand & vbCrLf & "where bgt_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_station)
            'cmd.Parameters.AddWithValue("@p2", var_name)
            'cmd.Parameters.AddWithValue("@p3", var_name2)
            cmd.Parameters.AddWithValue("@p2", var_amt)
            cmd.Parameters.AddWithValue("@p3", Convert.ToDateTime(var_begdate))
            cmd.Parameters.AddWithValue("@p4", Convert.ToDateTime(var_enddate))
            cmd.Parameters.AddWithValue("@p5", var_desc)
            cmd.Parameters.AddWithValue("@p6", GBUsername)
            cmd.Parameters.AddWithValue("@p7", DateTime.Now)
            cmd.Parameters.AddWithValue("@p8", var_id)
            SqlDB.Exec(cmd)
            SqlDB.CommitTrans()
            message = "แก้ไขข้อมูลเรียบร้อยแล้ว"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            SqlDB.RollbackTrans()
            Return False
        End Try
    End Function

    Function Delete() As Boolean
        Dim SqlDB As New Cls_SqlDB
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Try
            SqlDB.BeginTrans()
            strcommand = "delete from hd_budget "
            strcommand = strcommand & vbCrLf & "where bgt_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd)
            SqlDB.CommitTrans()
            empty(GBMod.View)
            message = "ลบข้อมูลเรียบร้อยแล้ว"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            SqlDB.RollbackTrans()
            Return False
        End Try
    End Function
#End Region

End Class
