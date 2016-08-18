﻿Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_HD_Course_Struct
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Private _course_master As String = String.Empty
    Private _seq As Integer = 0
    Private _course_item As String = String.Empty
    Private _course_content1 As String = String.Empty
    Private _course_content2 As String = String.Empty
    Private _course_content3 As String = String.Empty
    Private _course_content4 As String = String.Empty
    Private _course_content5 As String = String.Empty
    Private _course_content6 As String = String.Empty
    Private _course_content7 As String = String.Empty
    Private _course_content8 As String = String.Empty
    Private _main_hour As Double
    Private _create_by As String = String.Empty
    Private _create_date As String = String.Empty
    Private _edit_by As String = String.Empty
    Private _sum_main_hour As Double

#Region "Constructor"
    Public Sub New()
    End Sub

Public Sub New(id As String)
        Dim dt As DataTable
        dt = Retreive()
        SetProperty(dt)
    End Sub

    Public Sub New(id As String, course_master As String)
        If String.IsNullOrEmpty(id) = True Then
            _course_master = course_master
        ElseIf String.IsNullOrEmpty(course_master) = True Then
            var_id = id
        Else
            var_id = id
            _course_master = course_master
        End If
        Dim dt As DataTable
        dt = Retreive()
        SetProperty(dt)
    End Sub
#End Region

#Region "Property"
    Public Property course_master() As String
        Get
            Return _course_master
        End Get
        Set(ByVal value As String)
            _course_master = value
        End Set
    End Property

    Public Property seq() As Integer
        Get
            Return _seq
        End Get
        Set(ByVal value As Integer)
            _seq = value
        End Set
    End Property

    Public Property course_item() As String
        Get
            Return _course_item
        End Get
        Set(ByVal value As String)
            _course_item = value
        End Set
    End Property

    Public Property course_content1() As String
        Get
            Return _course_content1
        End Get
        Set(ByVal value As String)
            _course_content1 = value
        End Set
    End Property

    Public Property course_content2() As String
        Get
            Return _course_content2
        End Get
        Set(ByVal value As String)
            _course_content2 = value
        End Set
    End Property

    Public Property course_content3() As String
        Get
            Return _course_content3
        End Get
        Set(ByVal value As String)
            _course_content3 = value
        End Set
    End Property

    Public Property course_content4() As String
        Get
            Return _course_content4
        End Get
        Set(ByVal value As String)
            _course_content4 = value
        End Set
    End Property

    Public Property course_content5() As String
        Get
            Return _course_content5
        End Get
        Set(ByVal value As String)
            _course_content5 = value
        End Set
    End Property

    Public Property course_content6() As String
        Get
            Return _course_content6
        End Get
        Set(ByVal value As String)
            _course_content6 = value
        End Set
    End Property

    Public Property course_content7() As String
        Get
            Return _course_content7
        End Get
        Set(ByVal value As String)
            _course_content7 = value
        End Set
    End Property

    Public Property course_content8() As String
        Get
            Return _course_content8
        End Get
        Set(ByVal value As String)
            _course_content8 = value
        End Set
    End Property

    Public Property main_hour() As Double
        Get
            Return _main_hour
        End Get
        Set(ByVal value As Double)
            _main_hour = value
        End Set
    End Property

    Public Property create_by() As String
        Get
            Return _create_by
        End Get
        Set(ByVal value As String)
            _create_by = value
        End Set
    End Property

    Public Property create_date() As String
        Get
            Return _create_date
        End Get
        Set(ByVal value As String)
            _create_date = value
        End Set
    End Property

    Public Property edit_by() As String
        Get
            Return _edit_by
        End Get
        Set(ByVal value As String)
            _edit_by = value
        End Set
    End Property

    Public ReadOnly Property sum_main_hour() As Double
        Get
            Return _sum_main_hour
        End Get
    End Property

#End Region

#Region "Exp Property"

    Public ReadOnly Property expHD_Course_Item() As Cls_HD_Course_Item
        Get
            Return New Cls_HD_Course_Item(_course_item)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content1() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content1)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content2() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content2)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content3() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content3)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content4() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content4)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content5() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content5)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content6() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content6)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content7() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content7)
        End Get
    End Property

    Public ReadOnly Property expHD_Course_Content8() As Cls_HD_Course_Content
        Get
            Return New Cls_HD_Course_Content(_course_content8)
        End Get
    End Property

#End Region

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and cst_id ='" & var_id.ToString() & "'"
            End If
            If _course_master.Length > 0 Then
                strwc = strwc + " and cst_course_master ='" & _course_master.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_course_struct where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by cst_seq "
            dt = SqlDB.GetDataTable(strcommand)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    _sum_main_hour = _sum_main_hour + dt.Rows(i).Item("cst_main_hour")
                Next
            Else
                _sum_main_hour = 0
            End If
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Public Sub SetProperty(dt As DataTable)
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                _course_master = cNull(dt.Rows(row).Item("cst_course_master"), "S")
                _seq = cNull(dt.Rows(row).Item("cst_seq"), "N")
                _course_item = cNull(dt.Rows(row).Item("cst_course_item"), "S")
                _course_content1 = cNull(dt.Rows(row).Item("cst_course_content1"), "S")
                _course_content2 = cNull(dt.Rows(row).Item("cst_course_content2"), "S")
                _course_content3 = cNull(dt.Rows(row).Item("cst_course_content3"), "S")
                _course_content4 = cNull(dt.Rows(row).Item("cst_course_content4"), "S")
                _course_content5 = cNull(dt.Rows(row).Item("cst_course_content5"), "S")
                _course_content6 = cNull(dt.Rows(row).Item("cst_course_content6"), "S")
                _course_content7 = cNull(dt.Rows(row).Item("cst_course_content7"), "S")
                _course_content8 = cNull(dt.Rows(row).Item("cst_course_content8"), "S")
                _main_hour = cNull(dt.Rows(row).Item("cst_main_hour"), "S")
                _create_by = cNull(dt.Rows(row).Item("cst_create_by"), "S")
                _create_date = cNull(dt.Rows(row).Item("cst_create_date"), "D")
                _edit_by = cNull(dt.Rows(row).Item("cst_edit_by"), "S")
            Next
        End If
    End Sub

    Function Save(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = ""
        bSucc = True
        Try
            If var_id = String.Empty Then
                'Insert
                strcommand = "insert into hd_course_struct(corp,branch,cst_id,cst_course_master,cst_course_item,cst_seq"
                strcommand = strcommand & vbCrLf & ",cst_course_content1,cst_course_content2,cst_course_content3,cst_course_content4,cst_course_content5"
                strcommand = strcommand & vbCrLf & ",cst_course_content6,cst_course_content7,cst_course_content8"
                strcommand = strcommand & vbCrLf & ",cst_main_hour,cst_create_by,cst_create_date"
                strcommand = strcommand & vbCrLf & " ) values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                cmd = SqlDB.CreateCommand(strcommand)
                Dim strId As String = SqlDB.GenKeyValue()
                cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
                cmd.Parameters.AddWithValue("@p2", Branch_id)
                cmd.Parameters.AddWithValue("@p3", strId)
                cmd.Parameters.AddWithValue("@p4", _course_master)
                cmd.Parameters.AddWithValue("@p5", _course_item)
                cmd.Parameters.AddWithValue("@p6", _seq)
                cmd.Parameters.AddWithValue("@p7", _course_content1)
                cmd.Parameters.AddWithValue("@p8", _course_content2)
                cmd.Parameters.AddWithValue("@p9", _course_content3)
                cmd.Parameters.AddWithValue("@p10", _course_content4)
                cmd.Parameters.AddWithValue("@p11", _course_content5)
                cmd.Parameters.AddWithValue("@p12", _course_content6)
                cmd.Parameters.AddWithValue("@p13", _course_content7)
                cmd.Parameters.AddWithValue("@p14", _course_content8)
                cmd.Parameters.AddWithValue("@p15", _main_hour)
                cmd.Parameters.AddWithValue("@p16", GBUsername)
                cmd.Parameters.AddWithValue("@p17", DateTime.Now)
                SqlDB.Exec(cmd)
            Else
                'Update
                strcommand = "update hd_course_struct "
                strcommand = strcommand & vbCrLf & "set cst_course_master = ? "
                strcommand = strcommand & vbCrLf & ",cst_seq = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_item = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content1 = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content2 = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content3 = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content4 = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content5 = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content6 = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content7 = ? "
                strcommand = strcommand & vbCrLf & ",cst_course_content8 = ? "
                strcommand = strcommand & vbCrLf & ",cst_main_hour = ? "
                strcommand = strcommand & vbCrLf & ",cst_edit_by= ? "
                strcommand = strcommand & vbCrLf & ",cst_edit_date= ? "
                strcommand = strcommand & vbCrLf & "where cst_id = ? "
                cmd = SqlDB.CreateCommand(strcommand)
                cmd.Parameters.AddWithValue("@p1", _course_master)
                cmd.Parameters.AddWithValue("@p2", _seq)
                cmd.Parameters.AddWithValue("@p3", _course_item)
                cmd.Parameters.AddWithValue("@p4", _course_content1)
                cmd.Parameters.AddWithValue("@p5", _course_content2)
                cmd.Parameters.AddWithValue("@p6", _course_content3)
                cmd.Parameters.AddWithValue("@p7", _course_content4)
                cmd.Parameters.AddWithValue("@p8", _course_content5)
                cmd.Parameters.AddWithValue("@p9", _course_content6)
                cmd.Parameters.AddWithValue("@p10", _course_content7)
                cmd.Parameters.AddWithValue("@p11", _course_content8)
                cmd.Parameters.AddWithValue("@p12", _main_hour)
                cmd.Parameters.AddWithValue("@p13", GBUsername)
                cmd.Parameters.AddWithValue("@p14", DateTime.Now)
                cmd.Parameters.AddWithValue("@p15", var_id)
                SqlDB.Exec(cmd)
            End If
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            bSucc = False
        End Try
        Return bSucc
    End Function

    Sub Delete(SqlDB As Cls_SqlDB)
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Try
            If var_id <> String.Empty Then
                strcommand = "delete from hd_course_struct "
                strcommand = strcommand & vbCrLf & "where cst_id = ? "
                cmd = SqlDB.CreateCommand(strcommand)
                cmd.Parameters.AddWithValue("@p1", var_id)
                SqlDB.Exec(cmd)
            End If
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
        End Try
    End Sub



End Class
