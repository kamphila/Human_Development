Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class Cls_HD_Guest
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Private var_inout As String = String.Empty
    Private var_code As String = String.Empty
    Private var_name As String = String.Empty
    Private var_name2 As String = String.Empty
    Private var_position As String = String.Empty
    Private var_corp_email As String = String.Empty
    Private var_email As String = String.Empty
    Private var_tel As String = String.Empty
    Private var_institution As String = String.Empty
    Private var_address As String = String.Empty
    Private var_belong As String = String.Empty
    Private var_wage As Decimal = Nothing
    Private var_skill As String = String.Empty
    Private var_desc As String = String.Empty

    Public Sub New()
    End Sub
    Public Sub New(id As String)
        If String.Empty.Equals(id) = False Then
            Me.getById(id)
        End If

    End Sub


#Region "Property"
    Public Property inout() As String
        Get
            Return var_inout
        End Get
        Set(value As String)
            var_inout = value
        End Set
    End Property


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

    Public Property position() As String
        Get
            Return var_position
        End Get
        Set(value As String)
            var_position = value
        End Set
    End Property


    Public Property corp_email() As String
        Get
            Return var_corp_email
        End Get
        Set(value As String)
            var_corp_email = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return var_email
        End Get
        Set(value As String)
            var_email = value
        End Set
    End Property

    Public Property tel() As String
        Get
            Return var_tel
        End Get
        Set(value As String)
            var_tel = value
        End Set
    End Property

    Public Property institution() As String
        Get
            Return var_institution
        End Get
        Set(value As String)
            var_institution = value
        End Set
    End Property

    Public Property address() As String
        Get
            Return var_address
        End Get
        Set(value As String)
            var_address = value
        End Set
    End Property

    Public Property belong() As String
        Get
            Return var_belong
        End Get
        Set(value As String)
            var_belong = value
        End Set
    End Property

    Public Property wage() As Decimal
        Get
            Return var_wage
        End Get
        Set(value As Decimal)
            var_wage = value
        End Set
    End Property


    Public Property skill() As String
        Get
            Return var_skill
        End Get
        Set(value As String)
            var_skill = value
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
        var_inout = String.Empty
        var_code = String.Empty
        var_name = String.Empty
        var_name2 = String.Empty
        var_position = String.Empty
        var_corp_email = String.Empty
        var_email = String.Empty
        var_tel = String.Empty
        var_institution = String.Empty
        var_address = String.Empty
        var_belong = String.Empty
        var_wage = Nothing
        var_skill = String.Empty
        var_desc = String.Empty
        strfuncnm = String.Empty
        Return True
    End Function

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        var_corp_id = dt.Rows(0).Item("gue_corp_id").ToString()
        var_id = dt.Rows(0).Item("gue_id").ToString()
        var_inout = dt.Rows(0).Item("gue_inout").ToString()
        var_code = dt.Rows(0).Item("gue_code").ToString()
        var_name = dt.Rows(0).Item("gue_name").ToString()
        var_name2 = dt.Rows(0).Item("gue_name2").ToString()
        var_position = dt.Rows(0).Item("gue_position").ToString()
        var_corp_email = dt.Rows(0).Item("gue_corp_email").ToString()
        var_email = dt.Rows(0).Item("gue_email").ToString()
        var_tel = dt.Rows(0).Item("gue_tel").ToString()
        var_institution = dt.Rows(0).Item("gue_institution").ToString()
        var_address = dt.Rows(0).Item("gue_address").ToString()
        var_belong = dt.Rows(0).Item("gue_belong").ToString()
        var_wage = cNull(dt.Rows(0).Item("gue_wage"), "N")
        var_skill = dt.Rows(0).Item("gue_skill").ToString()
        var_desc = dt.Rows(0).Item("gue_desc").ToString()
        Return True
    End Function

    Function CheckDupCode() As Boolean
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim strcommand As String = ""
            Dim strwc As String = String.Empty
            strcommand = "select 1 from hd_guest "
            If var_id.Length > 0 Then
                strwc = " and gue_id <> '" & var_id.ToString() & "'"
            End If
            strcommand = strcommand & vbCrLf & " where gue_corp_id = ? and gue_code = ? " + strwc
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
            If var_inout.Length > 0 Then
                strwc = " and gue_inout ='" & var_inout & "'"
            End If
            If var_id.Length > 0 Then
                strwc = strwc + " and gue_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_guest where gue_corp_id = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by gue_code "

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
            strcommand = "insert into hd_guest(gue_corp_id,gue_id,gue_inout"
            strcommand = strcommand & vbCrLf & ",gue_code,gue_name,gue_name2,gue_position,gue_corp_email,gue_email,"
            strcommand = strcommand & vbCrLf & "gue_tel,gue_institution,gue_address,gue_belong,gue_wage,gue_skill,"
            strcommand = strcommand & vbCrLf & "gue_desc,gue_create_by,gue_create_date)"
            strcommand = strcommand & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            Dim strId As String = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", strId)
            cmd.Parameters.AddWithValue("@p3", var_inout)
            cmd.Parameters.AddWithValue("@p4", var_code)
            cmd.Parameters.AddWithValue("@p5", var_name)
            cmd.Parameters.AddWithValue("@p6", var_name2)
            cmd.Parameters.AddWithValue("@p7", var_position)
            cmd.Parameters.AddWithValue("@p8", var_corp_email)
            cmd.Parameters.AddWithValue("@p9", var_email)
            cmd.Parameters.AddWithValue("@p10", var_tel)
            cmd.Parameters.AddWithValue("@p11", var_institution)
            cmd.Parameters.AddWithValue("@p12", var_address)
            cmd.Parameters.AddWithValue("@p13", var_belong)
            cmd.Parameters.AddWithValue("@p14", var_wage)
            cmd.Parameters.AddWithValue("@p15", var_skill)
            cmd.Parameters.AddWithValue("@p16", var_desc)
            cmd.Parameters.AddWithValue("@p17", GBUsername)
            cmd.Parameters.AddWithValue("@p18", DateTime.Now)
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
            strcommand = "update hd_guest set "
            strcommand = strcommand & vbCrLf & "gue_inout = ?"
            strcommand = strcommand & vbCrLf & ",gue_code = ?"
            strcommand = strcommand & vbCrLf & ",gue_name = ?"
            strcommand = strcommand & vbCrLf & ",gue_name2 = ?"
            strcommand = strcommand & vbCrLf & ",gue_position = ?"
            strcommand = strcommand & vbCrLf & ",gue_corp_email = ?"
            strcommand = strcommand & vbCrLf & ",gue_email= ?"
            strcommand = strcommand & vbCrLf & ",gue_tel = ?"
            strcommand = strcommand & vbCrLf & ",gue_institution = ?"
            strcommand = strcommand & vbCrLf & ",gue_address = ?"
            strcommand = strcommand & vbCrLf & ",gue_belong = ?"
            strcommand = strcommand & vbCrLf & ",gue_wage = ?"
            strcommand = strcommand & vbCrLf & ",gue_skill = ?"
            strcommand = strcommand & vbCrLf & ",gue_desc = ?"
            strcommand = strcommand & vbCrLf & ",gue_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",gue_edit_date= ?"
            strcommand = strcommand & vbCrLf & "where gue_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_inout)
            cmd.Parameters.AddWithValue("@p2", var_code)
            cmd.Parameters.AddWithValue("@p3", var_name)
            cmd.Parameters.AddWithValue("@p4", var_name2)
            cmd.Parameters.AddWithValue("@p5", var_position)
            cmd.Parameters.AddWithValue("@p6", var_corp_email)
            cmd.Parameters.AddWithValue("@p7", var_email)
            cmd.Parameters.AddWithValue("@p8", var_tel)
            cmd.Parameters.AddWithValue("@p9", var_institution)
            cmd.Parameters.AddWithValue("@p10", var_address)
            cmd.Parameters.AddWithValue("@p11", var_belong)
            cmd.Parameters.AddWithValue("@p12", var_wage)
            cmd.Parameters.AddWithValue("@p13", var_skill)
            cmd.Parameters.AddWithValue("@p14", var_desc)
            cmd.Parameters.AddWithValue("@p15", GBUsername)
            cmd.Parameters.AddWithValue("@p16", DateTime.Now)
            cmd.Parameters.AddWithValue("@p17", var_id)
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
            strcommand = "delete from hd_guest "
            strcommand = strcommand & vbCrLf & "where gue_id = ? "
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
