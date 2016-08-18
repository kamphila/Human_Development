﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Cls_HD_Score
    Inherits Cls_Base
    Private var_code As String = String.Empty
    Private var_name As String = String.Empty
    Private var_name2 As String = String.Empty
    Private var_desc As String = String.Empty
    Private var_begscore As String = String.Empty
    Private var_endscore As String = String.Empty
    Public Sub New()
    End Sub
    Public Sub New(id As String)
        If String.Empty.Equals(id) = False Then
            Me.getById(id)
        End If
    End Sub


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

    Public Property begscore() As String
        Get
            Return var_begscore
        End Get
        Set(value As String)
            var_begscore = value
        End Set

    End Property

    Public Property endscore() As String
        Get
            Return var_endscore
        End Get
        Set(value As String)
            var_endscore = value
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

    Public Property desc() As String
        Get
            Return var_desc
        End Get
        Set(ByVal value As String)
            var_desc = value
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
        var_desc = String.Empty
        var_begscore = String.Empty
        var_endscore = String.Empty
        strfuncnm = String.Empty
        Return True
    End Function

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        var_corp_id = dt.Rows(0).Item("hds_corp_id").ToString()
        var_id = dt.Rows(0).Item("hds_id").ToString()
        var_code = dt.Rows(0).Item("hds_code").ToString()
        var_name = dt.Rows(0).Item("hds_name").ToString()
        var_name2 = dt.Rows(0).Item("hds_name2").ToString()
        var_desc = dt.Rows(0).Item("hds_desc").ToString()
        var_begscore = dt.Rows(0).Item("hds_begscore").ToString()
        var_endscore = dt.Rows(0).Item("hds_endscore").ToString()
        Return True
    End Function

    Function CheckDupCode() As Boolean
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim strcommand As String = ""
            Dim strwc As String = String.Empty
            strcommand = "select 1 from hd_score "
            If var_id.Length > 0 Then
                strwc = " and hds_id <> '" & var_id.ToString() & "'"
            End If
            strcommand = strcommand & vbCrLf & " where hds_corp_id = ? and hds_code = ? " + strwc
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_corp_id)
            cmd.Parameters.AddWithValue("@p2", var_code)
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
                strwc = " and hds_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_score where hds_corp_id = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by hds_code "
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
            strcommand = "insert into hd_score(hds_corp_id,hds_id"
            strcommand = strcommand & vbCrLf & ",hds_code,hds_name,hds_name2,hds_desc,hds_begscore,hds_endscore,hds_create_by,hds_create_date)"
            strcommand = strcommand & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            Dim strId As String = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", strId)
            cmd.Parameters.AddWithValue("@p3", var_code)
            cmd.Parameters.AddWithValue("@p4", var_name)
            cmd.Parameters.AddWithValue("@p5", var_name2)
            cmd.Parameters.AddWithValue("@p6", var_desc)
            cmd.Parameters.AddWithValue("@p7", var_begscore)
            cmd.Parameters.AddWithValue("@p8", var_endscore)
            cmd.Parameters.AddWithValue("@p9", GBUsername)
            cmd.Parameters.AddWithValue("@p10", DateTime.Now)
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
            strcommand = "update hd_score"
            strcommand = strcommand & vbCrLf & "set hds_code = ?"
            strcommand = strcommand & vbCrLf & ",hds_name = ?"
            strcommand = strcommand & vbCrLf & ",hds_name2 = ?"
            strcommand = strcommand & vbCrLf & ",hds_Desc = ?"
            strcommand = strcommand & vbCrLf & ",hds_begscore = ?"
            strcommand = strcommand & vbCrLf & ",hds_endscore = ?"
            strcommand = strcommand & vbCrLf & ",hds_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",hds_edit_date= ?"
            strcommand = strcommand & vbCrLf & "where hds_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_code)
            cmd.Parameters.AddWithValue("@p2", var_name)
            cmd.Parameters.AddWithValue("@p3", var_name2)
            cmd.Parameters.AddWithValue("@p4", var_desc)
            cmd.Parameters.AddWithValue("@p5", var_begscore)
            cmd.Parameters.AddWithValue("@p6", var_endscore)
            cmd.Parameters.AddWithValue("@p7", GBUsername)
            cmd.Parameters.AddWithValue("@p8", DateTime.Now)
            cmd.Parameters.AddWithValue("@p9", var_id)
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
            strcommand = "delete from hd_score "
            strcommand = strcommand & vbCrLf & "where hds_id = ? "
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
