Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class Cls_HD_Exam_Master
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Public dt As New DataTable
    Private var_code As String = String.Empty
    Private var_name As String = String.Empty
    Private var_name2 As String = String.Empty
    Private var_qty As Integer = Nothing
    Private var_score As Integer = Nothing
    Private var_pass_exam As Integer = Nothing

    Private var_exm_id As String = String.Empty
    Private var_exd_no As String = String.Empty
    Private var_exd_status As String = String.Empty

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

    Public Property qty() As Integer
        Get
            Return var_qty
        End Get
        Set(value As Integer)
            var_qty = value
        End Set
    End Property

    Public Property score() As Integer
        Get
            Return var_score
        End Get
        Set(value As Integer)
            var_score = value
        End Set
    End Property

    Public Property pass_exam() As Integer
        Get
            Return var_pass_exam
        End Get
        Set(value As Integer)
            var_pass_exam = value
        End Set
    End Property

    Public Property exd_no() As String
        Get
            Return var_exd_no
        End Get
        Set(value As String)
            var_exd_no = value
        End Set
    End Property

    Public Property exd_status() As String
        Get
            Return var_exd_status
        End Get
        Set(value As String)
            var_exd_status = value
        End Set
    End Property

    Public Property exm_id() As String
        Get
            Return var_exm_id
        End Get
        Set(value As String)
            var_exm_id = value
        End Set
    End Property

#End Region

#Region "Function"

    Function empty() As Boolean
        var_exd_no = String.Empty
        var_exd_status = String.Empty
        Return True
    End Function

    Function empty(GedMod As String) As Boolean
        If GedMod <> GBMod.Edit Then
            var_id = String.Empty
        End If
        var_corp_id = String.Empty
        var_code = String.Empty
        var_name = String.Empty
        var_name2 = String.Empty
        var_qty = Nothing
        var_score = Nothing
        var_pass_exam = Nothing

        strfuncnm = String.Empty
        Return True
    End Function

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        var_corp_id = dt.Rows(0).Item("exm_corp_id").ToString()
        var_id = dt.Rows(0).Item("exm_id").ToString()
        var_code = dt.Rows(0).Item("exm_code").ToString()
        var_name = dt.Rows(0).Item("exm_name").ToString()
        var_name2 = dt.Rows(0).Item("exm_name2").ToString()
        var_qty = dt.Rows(0).Item("exm_qty").ToString()
        var_score = dt.Rows(0).Item("exm_score").ToString()
        var_pass_exam = dt.Rows(0).Item("exm_pass_exam").ToString()
        Return True
    End Function

    Function CheckDupCode() As Boolean
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim strcommand As String = ""
            Dim strwc As String = String.Empty
            strcommand = "select 1 from hd_exam_master "
            If var_id.Length > 0 Then
                strwc = " and exm_id <> '" & var_id.ToString() & "'"
            End If
            strcommand = strcommand & vbCrLf & " where exm_corp_id = ? and exm_code = ? " + strwc
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


    Function CheckExamDetailData(ByVal id As String) As DataTable
        Try
            var_exm_id = id
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and exm_id ='" & var_exm_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_exam_detail where exd_corp_id = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by exd_no"

            dt = SqlDB.GetDataTable(strcommand)
            dt.PrimaryKey = New DataColumn() {dt.Columns("exd_no")}
            dt.Columns("exd_no").Unique = True
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function GetKey() As String
        Dim SqlDB As New Cls_SqlDB
        Return SqlDB.GenKeyValue()
    End Function



    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and exm_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_exam_master where exm_corp_id = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by exm_code "

            dt = SqlDB.GetDataTable(strcommand)
            Return dt

            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function


    Function PrepareDataTable(ByVal exmMode As String) As DataTable
        If exmMode = GBMod.Edit Then
            Dim row() As DataRow = dt.Select()
            Dim i As Integer
            For i = 0 To row.GetUpperBound(0)
                If (row(i)("exd_status")) = "successful" Then
                    row(i)("exd_status") = "pendding"
                    row(i)("exd_edit_by") = GBUsername
                    row(i)("exd_edit_date") = DateTime.Now
                ElseIf (row(i)("exd_status")) = "pendding" Then
                    row(i)("exd_create_by") = GBUsername
                    row(i)("exd_create_date") = DateTime.Now
                End If
            Next i
        Else
            Dim row() As DataRow = dt.Select()
            Dim i As Integer
            For i = 0 To row.GetUpperBound(0)
                row(i)("exd_status") = "successful"
                row(i)("exd_create_by") = GBUsername
                row(i)("exd_create_date") = DateTime.Now
            Next i
        End If
        Return dt
    End Function


    Function Add() As Boolean
        Dim SqlDB As New Cls_SqlDB
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = ""

        Dim cmd_exd As New OleDbCommand
        Dim strcommand_exd As String = String.Empty
        Dim row() As DataRow = dt.Select()
        If row.Count <= 0 Then
            message = "ไม่สามารถบันทึกชุดแบบทดสอบได้เนื่องจากไม่มีข้อสอบ"
            Return False
            Exit Function
        End If
        Dim i As Integer
        Try
            SqlDB.BeginTrans()
            strcommand = "insert into hd_exam_master(exm_corp_id,exm_id"
            strcommand = strcommand & vbCrLf & ",exm_code,exm_name,exm_name2,exm_qty,exm_score,exm_pass_exam,exm_create_by,exm_create_date)"
            strcommand = strcommand & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            Dim strId As String = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", strId)
            cmd.Parameters.AddWithValue("@p3", var_code)
            cmd.Parameters.AddWithValue("@p4", var_name)
            cmd.Parameters.AddWithValue("@p5", var_name2)
            cmd.Parameters.AddWithValue("@p6", var_qty)
            cmd.Parameters.AddWithValue("@p7", var_score)
            cmd.Parameters.AddWithValue("@p8", var_pass_exam)
            cmd.Parameters.AddWithValue("@p9", GBUsername)
            cmd.Parameters.AddWithValue("@p10", DateTime.Now)
            SqlDB.Exec(cmd)

            If row.Count > 0 Then
                For i = 0 To row.GetUpperBound(0)
                    strcommand_exd = "insert into hd_exam_detail(exd_corp_id,exd_id"
                    strcommand_exd = strcommand_exd & vbCrLf & ",exm_id,exd_no,exd_question,exd_question2,exd_question_type,exd_answer_obj1"
                    strcommand_exd = strcommand_exd & vbCrLf & ",exd_answer_obj2,exd_answer_obj3,exd_answer_obj4,exd_answer_obj,exd_answer_sub1"
                    strcommand_exd = strcommand_exd & vbCrLf & ",exd_answer_sub2,exd_answer_sub3,exd_answer_sub4,exd_score,exd_status,exd_create_by,exd_create_date)"
                    strcommand_exd = strcommand_exd & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                    cmd_exd = SqlDB.CreateCommand(strcommand_exd)
                    cmd_exd.Parameters.AddWithValue("@p1", Config.GBCorp)
                    cmd_exd.Parameters.AddWithValue("@p2", row(i)("exd_id").ToString())
                    cmd_exd.Parameters.AddWithValue("@p3", strId)
                    cmd_exd.Parameters.AddWithValue("@p4", row(i)("exd_no").ToString())
                    cmd_exd.Parameters.AddWithValue("@p5", row(i)("exd_question").ToString())
                    cmd_exd.Parameters.AddWithValue("@p6", row(i)("exd_question2").ToString())
                    cmd_exd.Parameters.AddWithValue("@p7", row(i)("exd_question_type").ToString())
                    cmd_exd.Parameters.AddWithValue("@p8", row(i)("exd_answer_obj1").ToString())
                    cmd_exd.Parameters.AddWithValue("@p9", row(i)("exd_answer_obj2").ToString())
                    cmd_exd.Parameters.AddWithValue("@p10", row(i)("exd_answer_obj3").ToString())
                    cmd_exd.Parameters.AddWithValue("@p11", row(i)("exd_answer_obj4").ToString())
                    cmd_exd.Parameters.AddWithValue("@p12", row(i)("exd_answer_obj").ToString())
                    cmd_exd.Parameters.AddWithValue("@p13", row(i)("exd_answer_sub1").ToString())
                    cmd_exd.Parameters.AddWithValue("@p14", row(i)("exd_answer_sub2").ToString())
                    cmd_exd.Parameters.AddWithValue("@p15", row(i)("exd_answer_sub3").ToString())
                    cmd_exd.Parameters.AddWithValue("@p16", row(i)("exd_answer_sub4").ToString())
                    cmd_exd.Parameters.AddWithValue("@p17", row(i)("exd_score").ToString())
                    cmd_exd.Parameters.AddWithValue("@p18", row(i)("exd_status").ToString())
                    cmd_exd.Parameters.AddWithValue("@p19", row(i)("exd_create_by").ToString())
                    cmd_exd.Parameters.AddWithValue("@p20", row(i)("exd_create_date"))
                    SqlDB.Exec(cmd_exd)
                Next i
            End If
            SqlDB.CommitTrans()
            dt.Clear()
            message = "บันทึกชุดแบบทดสอบและข้อสอบเรียบร้อย"
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
        Dim strwc_updatte As String = String.Empty

        Dim cmd_exd_insert As New OleDbCommand
        Dim strcommand_exd_insert As String = String.Empty
        Dim row() As DataRow = dt.Select()
        If row.Count <= 0 Then
            message = "! ไม่สามารถบันทึกชุดแบบทดสอบได้เนื่องจาก ไม่มีข้อสอบ " & vbCrLf &
                      "! ในกรณีที่ต้องการลบชุดแบบทดสอบ ให้กลับไปที่หน้าแบบทดสอบ"
            Return False
            Exit Function
        End If

        Dim i As Integer

        Dim cmd_exd_delete As New OleDbCommand
        Dim strcommand_exd_delete As String = String.Empty

        Dim cmd_exd_update As New OleDbCommand
        Dim strcommand_exd_update As String = String.Empty

        Try
            SqlDB.BeginTrans()
            strcommand = "update hd_exam_master"
            strcommand = strcommand & vbCrLf & "set exm_code = ?"
            strcommand = strcommand & vbCrLf & ",exm_name = ?"
            strcommand = strcommand & vbCrLf & ",exm_name2 = ?"
            strcommand = strcommand & vbCrLf & ",exm_qty = ?"
            strcommand = strcommand & vbCrLf & ",exm_score = ?"
            strcommand = strcommand & vbCrLf & ",exm_pass_exam = ?"
            strcommand = strcommand & vbCrLf & ",exm_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",exm_edit_date= ?"
            strcommand = strcommand & vbCrLf & "where exm_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_code)
            cmd.Parameters.AddWithValue("@p2", var_name)
            cmd.Parameters.AddWithValue("@p3", var_name2)
            cmd.Parameters.AddWithValue("@p4", var_qty)
            cmd.Parameters.AddWithValue("@p5", var_score)
            cmd.Parameters.AddWithValue("@p6", var_pass_exam)
            cmd.Parameters.AddWithValue("@p7", GBUsername)
            cmd.Parameters.AddWithValue("@p8", DateTime.Now)
            cmd.Parameters.AddWithValue("@p9", var_id)
            SqlDB.Exec(cmd)

            If row.Count > 0 Then
                For i = 0 To row.GetUpperBound(0)
                    strcommand_exd_insert = "insert into hd_exam_detail(exd_corp_id,exd_id"
                    strcommand_exd_insert = strcommand_exd_insert & vbCrLf & ",exm_id,exd_no,exd_question,exd_question2,exd_question_type,exd_answer_obj1"
                    strcommand_exd_insert = strcommand_exd_insert & vbCrLf & ",exd_answer_obj2,exd_answer_obj3,exd_answer_obj4,exd_answer_obj,exd_answer_sub1"
                    strcommand_exd_insert = strcommand_exd_insert & vbCrLf & ",exd_answer_sub2,exd_answer_sub3,exd_answer_sub4,exd_score,exd_status,exd_create_by,exd_create_date,exd_edit_by,exd_edit_date)"
                    strcommand_exd_insert = strcommand_exd_insert & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                    cmd_exd_insert = SqlDB.CreateCommand(strcommand_exd_insert)
                    cmd_exd_insert.Parameters.AddWithValue("@p1", Config.GBCorp)
                    cmd_exd_insert.Parameters.AddWithValue("@p2", row(i)("exd_id").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p3", row(i)("exm_id").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p4", row(i)("exd_no").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p5", row(i)("exd_question").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p6", row(i)("exd_question2").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p7", row(i)("exd_question_type").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p8", row(i)("exd_answer_obj1").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p9", row(i)("exd_answer_obj2").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p10", row(i)("exd_answer_obj3").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p11", row(i)("exd_answer_obj4").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p12", row(i)("exd_answer_obj").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p13", row(i)("exd_answer_sub1").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p14", row(i)("exd_answer_sub2").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p15", row(i)("exd_answer_sub3").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p16", row(i)("exd_answer_sub4").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p17", row(i)("exd_score").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p18", row(i)("exd_status").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p19", row(i)("exd_create_by").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p20", row(i)("exd_create_date"))
                    cmd_exd_insert.Parameters.AddWithValue("@p21", row(i)("exd_edit_by").ToString())
                    cmd_exd_insert.Parameters.AddWithValue("@p22", row(i)("exd_edit_date"))
                    SqlDB.Exec(cmd_exd_insert)
                Next i

                var_exd_status = "successful"
                strwc = " and exd_status ='" & var_exd_status.ToString() & "'"
                strcommand_exd_delete = "delete from hd_exam_detail "
                strcommand_exd_delete = strcommand_exd_delete & vbCrLf & "where exm_id = ? " & strwc
                cmd_exd_delete = SqlDB.CreateCommand(strcommand_exd_delete)
                cmd_exd_delete.Parameters.AddWithValue("@p1", var_id)
                SqlDB.Exec(cmd_exd_delete)

                strcommand_exd_update = "update hd_exam_detail"
                strcommand_exd_update = strcommand_exd_update & vbCrLf & "set exd_status = ?"
                strcommand_exd_update = strcommand_exd_update & vbCrLf & "where exm_id = ? "
                cmd_exd_update = SqlDB.CreateCommand(strcommand_exd_update)
                cmd_exd_update.Parameters.AddWithValue("@p1", var_exd_status)
                cmd_exd_update.Parameters.AddWithValue("@p2", var_id)
                SqlDB.Exec(cmd_exd_update)
            Else
                var_exd_status = "successful"
                strwc = " and exd_status ='" & var_exd_status.ToString() & "'"
                strcommand_exd_delete = "delete from hd_exam_detail "
                strcommand_exd_delete = strcommand_exd_delete & vbCrLf & "where exm_id = ? " & strwc
                cmd_exd_delete = SqlDB.CreateCommand(strcommand_exd_delete)
                cmd_exd_delete.Parameters.AddWithValue("@p1", var_id)
                SqlDB.Exec(cmd_exd_delete)
            End If
            SqlDB.CommitTrans()
            dt.Clear()
            message = "แก้ไขข้อมูลชุดแบบทดสอบและข้อสอบเรียบร้อยแล้ว"
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

        Dim cmd_exd As New OleDbCommand
        Dim strcommand_exd As String = String.Empty

        Try
            SqlDB.BeginTrans()
            strcommand = "delete from hd_exam_master "
            strcommand = strcommand & vbCrLf & "where exm_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd)

            strcommand_exd = "delete from hd_exam_detail "
            strcommand_exd = strcommand_exd & vbCrLf & "where exm_id =? "
            cmd_exd = SqlDB.CreateCommand(strcommand_exd)
            cmd_exd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd_exd)

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
