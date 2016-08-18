Imports System.Data.OleDb

Public Class Cls_HD_Exam
    Inherits Cls_Base
    Private var_code As String = String.Empty
    Private var_Question As String = String.Empty
    Private var_Question2 As String = String.Empty
    Private var_Question_Type As String = String.Empty
    Private var_Answer1 As String = String.Empty
    Private var_Answer2 As String = String.Empty
    Private var_Answer3 As String = String.Empty
    Private var_Answer4 As String = String.Empty
    Private var_Answer_Obj As String = String.Empty
    Private var_Answer_Sub As String = String.Empty
    Private var_1score As Double = 1
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

    Public Property Question() As String
        Get
            Return var_Question
        End Get
        Set(ByVal value As String)
            var_Question = value
        End Set
    End Property


    Public Property Question2() As String
        Get
            Return var_Question2
        End Get
        Set(ByVal value As String)
            var_Question2 = value
        End Set
    End Property


    Public Property Question_Type() As String
        Get
            Return var_Question_Type
        End Get
        Set(ByVal value As String)
            var_Question_Type = value
        End Set
    End Property

    Public Property Answer1() As String
        Get
            Return var_Answer1
        End Get
        Set(ByVal value As String)
            var_Answer1 = value
        End Set
    End Property

    Public Property Answer2() As String
        Get
            Return var_Answer2
        End Get
        Set(ByVal value As String)
            var_Answer2 = value
        End Set
    End Property

    Public Property Answer3() As String
        Get
            Return var_Answer3
        End Get
        Set(ByVal value As String)
            var_Answer3 = value
        End Set
    End Property

    Public Property Answer4() As String
        Get
            Return var_Answer4
        End Get
        Set(ByVal value As String)
            var_Answer4 = value
        End Set
    End Property


    Public Property Answer_Obj() As String
        Get
            Return var_Answer_Obj
        End Get
        Set(ByVal value As String)
            var_Answer_Obj = value
        End Set
    End Property

    Public Property Answer_sub() As String
        Get
            Return var_Answer_Sub
        End Get
        Set(ByVal value As String)
            var_Answer_Sub = value
        End Set
    End Property

    Public Property score() As Double
        Get
            Return var_1score
        End Get
        Set(ByVal value As Double)
            var_1score = value
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
        var_Question = String.Empty
        var_Question2 = String.Empty
        var_Question_Type = String.Empty
        var_Answer1 = String.Empty
        var_Answer2 = String.Empty
        var_Answer3 = String.Empty
        var_Answer4 = String.Empty
        var_Answer_Obj = String.Empty
        var_Answer_Sub = String.Empty
        Return True
    End Function

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        var_corp_id = dt.Rows(0).Item("hde_corp_id").ToString()
        var_id = dt.Rows(0).Item("hde_id").ToString()
        var_code = dt.Rows(0).Item("hde_code").ToString()
        var_Question = dt.Rows(0).Item("hde_question").ToString()
        var_Question2 = dt.Rows(0).Item("hde_question2").ToString()
        var_Question_Type = dt.Rows(0).Item("hde_question_type").ToString()
        var_Answer1 = dt.Rows(0).Item("hde_answer1").ToString()
        var_Answer2 = dt.Rows(0).Item("hde_answer2").ToString()
        var_Answer3 = dt.Rows(0).Item("hde_answer3").ToString()
        var_Answer4 = dt.Rows(0).Item("hde_answer4").ToString()
        var_Answer_Obj = dt.Rows(0).Item("hde_answer_obj").ToString()
        var_Answer_Sub = dt.Rows(0).Item("hde_answer_sub").ToString()
        var_1score = dt.Rows(0).Item("hde_score")
        Return True
    End Function

    Function CheckDupCode() As Boolean
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim strcommand As String = ""
            Dim strwc As String = String.Empty
            strcommand = "select 1 from hd_exam "
            If var_id.Length > 0 Then
                strwc = " and hde_id <> '" & var_id.ToString() & "'"
            End If
            strcommand = strcommand & vbCrLf & " where hde_corp_id = ? and hde_code = ? " + strwc
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
                strwc = " and hde_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_exam where hde_corp_id = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by bgt_code "
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

            strcommand = "insert into hd_exam(hde_corp_id,hde_id"
            strcommand = strcommand & vbCrLf & ",hde_code,hde_question,hde_question2,hde_question_type,hde_answer1,hde_answer2,hde_answer3,hde_answer4 "
            strcommand = strcommand & vbCrLf & ",hde_answer_obj ,hde_answer_sub,hde_create_by,hde_create_date)"
            strcommand = strcommand & vbCrLf & "values(?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            Dim strId As String = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", strId)
            cmd.Parameters.AddWithValue("@p3", var_code)
            cmd.Parameters.AddWithValue("@p4", var_Question)
            cmd.Parameters.AddWithValue("@p5", var_Question2)
            cmd.Parameters.AddWithValue("@p6", var_Question_Type)
            cmd.Parameters.AddWithValue("@p7", var_Answer1)
            cmd.Parameters.AddWithValue("@p8", var_Answer2)
            cmd.Parameters.AddWithValue("@p9", var_Answer3)
            cmd.Parameters.AddWithValue("@p10", var_Answer4)
            cmd.Parameters.AddWithValue("@p11", var_Answer_Sub)
            cmd.Parameters.AddWithValue("@p12", var_Answer_Obj)
            'cmd.Parameters.AddWithValue("@p13", var_1score)
            cmd.Parameters.AddWithValue("@p13", GBUsername)
            cmd.Parameters.AddWithValue("@p14", DateTime.Now)
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
            strcommand = "update hd_exam"
            strcommand = strcommand & vbCrLf & "set hde_code = ?"
            strcommand = strcommand & vbCrLf & ",hde_question = ?"
            strcommand = strcommand & vbCrLf & ",hde_question2 = ?"
            strcommand = strcommand & vbCrLf & ",hde_question_type = ?"
            strcommand = strcommand & vbCrLf & ",hde_answer1 = ?"
            strcommand = strcommand & vbCrLf & ",hde_answer2 = ?"
            strcommand = strcommand & vbCrLf & ",hde_answer3 = ?"
            strcommand = strcommand & vbCrLf & ",hde_answer4 = ?"
            strcommand = strcommand & vbCrLf & ",hde_answer_obj = ?"
            strcommand = strcommand & vbCrLf & ",hde_answer_sub = ?"
            strcommand = strcommand & vbCrLf & ",hde_score = ?"
            strcommand = strcommand & vbCrLf & ",bgt_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",bgt_edit_date= ?"
            strcommand = strcommand & vbCrLf & "where bgt_id = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_code)
            cmd.Parameters.AddWithValue("@p2", var_Question)
            cmd.Parameters.AddWithValue("@p3", var_Question2)
            cmd.Parameters.AddWithValue("@p4", var_Question_Type)
            cmd.Parameters.AddWithValue("@p5", var_Answer1)
            cmd.Parameters.AddWithValue("@p6", var_Answer2)
            cmd.Parameters.AddWithValue("@p7", var_Answer3)
            cmd.Parameters.AddWithValue("@p8", var_Answer4)
            cmd.Parameters.AddWithValue("@p9", var_Answer_Obj)
            cmd.Parameters.AddWithValue("@p10", var_Answer_Sub)
            cmd.Parameters.AddWithValue("@p11", var_1score)
            cmd.Parameters.AddWithValue("@p12", GBUsername)
            cmd.Parameters.AddWithValue("@p13", DateTime.Now)
            cmd.Parameters.AddWithValue("@p14", var_id)
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
            strcommand = "delete from hd_exam "
            strcommand = strcommand & vbCrLf & "where hde_id = ? "
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
