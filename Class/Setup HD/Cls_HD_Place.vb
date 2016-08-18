Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Cls_HD_Place
    Inherits Cls_Base
    Private var_code As String = String.Empty
    Private var_name As String = String.Empty
    Private var_name2 As String = String.Empty
    Private var_place As String = String.Empty
    Private var_contact As String = String.Empty
    Private var_email As String = String.Empty
    Private var_desc As String = String.Empty
    Private var_address As String = String.Empty
    Private var_tel As String = String.Empty
    Private var_website As String = String.Empty
    Private var_rent As Decimal = Nothing
    Private var_valence As Integer = Nothing
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


    Public Property name2() As String
        Get
            Return var_name2
        End Get
        Set(ByVal value As String)
            var_name2 = value
        End Set
    End Property

    Public Property place() As String
        Get
            Return var_place
        End Get
        Set(value As String)
            var_place = value
        End Set
    End Property

    Public Property contact() As String
        Get
            Return var_contact
        End Get
        Set(value As String)
            var_contact = value
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

    Public Property desc() As String
        Get
            Return var_desc
        End Get
        Set(ByVal value As String)
            var_desc = value
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

    Public Property tel() As String
        Get
            Return var_tel
        End Get
        Set(value As String)
            var_tel = value
        End Set
    End Property

    Public Property website() As String
        Get
            Return var_website
        End Get
        Set(value As String)
            var_website = value
        End Set
    End Property

    Public Property rent() As Decimal
        Get
            Return var_rent
        End Get
        Set(value As Decimal)
            var_rent = value
        End Set
    End Property

    Public Property valence() As Integer
        Get
            Return var_valence
        End Get
        Set(value As Integer)
            var_valence = value
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
        var_place = String.Empty
        var_contact = String.Empty
        var_email = String.Empty
        var_desc = String.Empty
        var_address = String.Empty
        var_tel = String.Empty
        var_website = String.Empty
        var_rent = Nothing
        var_valence = Nothing
        strfuncnm = String.Empty
        Return True
    End Function

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        var_corp_id = dt.Rows(0).Item("pac_corp_id").ToString()
        var_id = dt.Rows(0).Item("pac_id").ToString()
        var_code = dt.Rows(0).Item("pac_code").ToString()
        var_name = dt.Rows(0).Item("pac_name").ToString()
        var_name2 = dt.Rows(0).Item("pac_name2").ToString()
        var_place = dt.Rows(0).Item("pac_place").ToString()
        var_contact = dt.Rows(0).Item("pac_contact").ToString()
        var_email = dt.Rows(0).Item("pac_email").ToString()
        var_desc = dt.Rows(0).Item("pac_desc").ToString()
        var_address = dt.Rows(0).Item("pac_address").ToString()
        var_tel = dt.Rows(0).Item("pac_tel").ToString()
        var_website = dt.Rows(0).Item("pac_website").ToString()
        var_rent = dt.Rows(0).Item("pac_rent").ToString()
        var_valence = dt.Rows(0).Item("pac_valence").ToString()

        Return True
    End Function

    Function CheckDupCode() As Boolean
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim strcommand As String = ""
            Dim strwc As String = String.Empty
            strcommand = "select 1 from hd_place "
            If var_id.Length > 0 Then
                strwc = " and pac_id <> '" & var_id.ToString() & "'"
            End If
            strcommand = strcommand & vbCrLf & " where pac_corp_id = ? and pac_code = ? " + strwc
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
                strwc = " and pac_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_place where pac_corp_id = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by pac_code "

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
            strcommand = "insert into hd_place(pac_corp_id,pac_id"
            strcommand = strcommand & vbCrLf & ",pac_code,pac_name,pac_name2,pac_place,pac_contact,pac_email,pac_desc,pac_address,pac_tel,pac_website,pac_rent,pac_valence,pac_create_by,pac_create_date)"
            strcommand = strcommand & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            Dim strId As String = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", strId)
            cmd.Parameters.AddWithValue("@p3", var_code)
            cmd.Parameters.AddWithValue("@p4", var_name)
            cmd.Parameters.AddWithValue("@p5", var_name2)
            cmd.Parameters.AddWithValue("@p6", var_place)
            cmd.Parameters.AddWithValue("@p7", var_contact)
            cmd.Parameters.AddWithValue("@p8", var_email)
            cmd.Parameters.AddWithValue("@p9", var_desc)
            cmd.Parameters.AddWithValue("@p10", var_address)
            cmd.Parameters.AddWithValue("@p11", var_tel)
            cmd.Parameters.AddWithValue("@p12", var_website)
            cmd.Parameters.AddWithValue("@p13", var_rent)
            cmd.Parameters.AddWithValue("@p14", var_valence)
            cmd.Parameters.AddWithValue("@p15", GBUsername)
            cmd.Parameters.AddWithValue("@p16", DateTime.Now)
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
            strcommand = "update hd_place"
            strcommand = strcommand & vbCrLf & "set pac_code = ?"
            strcommand = strcommand & vbCrLf & ",pac_name = ?"
            strcommand = strcommand & vbCrLf & ",pac_name2 = ?"
            strcommand = strcommand & vbCrLf & ",pac_place = ?"
            strcommand = strcommand & vbCrLf & ",pac_contact = ?"
            strcommand = strcommand & vbCrLf & ",pac_email = ?"
            strcommand = strcommand & vbCrLf & ",pac_desc = ?"
            strcommand = strcommand & vbCrLf & ",pac_address = ?"
            strcommand = strcommand & vbCrLf & ",pac_tel = ?"
            strcommand = strcommand & vbCrLf & ",pac_website = ?"
            strcommand = strcommand & vbCrLf & ",pac_rent = ?"
            strcommand = strcommand & vbCrLf & ",pac_valence = ?"
            strcommand = strcommand & vbCrLf & ",pac_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",pac_edit_date= ?"
            strcommand = strcommand & vbCrLf & "where pac_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_code)
            cmd.Parameters.AddWithValue("@p2", var_name)
            cmd.Parameters.AddWithValue("@p3", var_name2)
            cmd.Parameters.AddWithValue("@p4", var_place)
            cmd.Parameters.AddWithValue("@p5", var_contact)
            cmd.Parameters.AddWithValue("@p6", var_email)
            cmd.Parameters.AddWithValue("@p7", var_desc)
            cmd.Parameters.AddWithValue("@p8", var_address)
            cmd.Parameters.AddWithValue("@p9", var_tel)
            cmd.Parameters.AddWithValue("@p10", var_website)
            cmd.Parameters.AddWithValue("@p11", var_rent)
            cmd.Parameters.AddWithValue("@p12", var_valence)
            cmd.Parameters.AddWithValue("@p13", GBUsername)
            cmd.Parameters.AddWithValue("@p14", DateTime.Now)
            cmd.Parameters.AddWithValue("@p15", var_id)
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
            strcommand = "delete from hd_place "
            strcommand = strcommand & vbCrLf & "where pac_id = ? "
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
