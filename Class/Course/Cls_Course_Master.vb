Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Course_Master
    Inherits Cls_Base
    Implements INotifyPropertyChanged

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

#Region "Property"

    Private _code As String = String.Empty
    Private _course As String = String.Empty
    Private _course_type As String = String.Empty
    Private _status As String = String.Empty
    Private _Doc_date As DateTime = DateTime.Now.Date
    Private _guest_internal As String = "N"
    Private _guest_external As String = "N"
    Private _guest_in_id1 As String = String.Empty
    Private _guest_in_id2 As String = String.Empty
    Private _guest_ext_id1 As String = String.Empty
    Private _guest_ext_id2 As String = String.Empty
    'Private _institution As String = String.Empty
    Private _owner_hr_flag As String = "N"
    Private _owner_other_flag As String = "N"
    Private _owner_hr_empl As String = String.Empty
    Private _owner_other As String = String.Empty
    Private _need_hd1 As String = String.Empty
    Private _need_hd2 As String = String.Empty
    Private _need_hd3 As String = String.Empty
    Private _need_hd4 As String = String.Empty
    Private _need_hd5 As String = String.Empty
    Private _need_hd6 As String = String.Empty
    Private _need_hd7 As String = String.Empty
    Private _need_hd8 As String = String.Empty
    Private _need_hd9 As String = String.Empty
    Private _need_hd10 As String = String.Empty
    Private _Purpose_1 As String = String.Empty
    Private _Purpose_2 As String = String.Empty
    Private _Purpose_3 As String = String.Empty
    Private _Purpose_4 As String = String.Empty
    Private _Purpose_5 As String = String.Empty
    Private _Purpose_6 As String = String.Empty
    Private _Purpose_7 As String = String.Empty
    Private _Purpose_8 As String = String.Empty
    Private _Purpose_9 As String = String.Empty
    Private _Purpose_10 As String = String.Empty
    Private _tool As String = String.Empty
    Private _method As String = String.Empty
    Private _assessment_level As String = String.Empty
    Private _course_kpis1 As String = String.Empty
    Private _course_kpis2 As String = String.Empty
    Private _course_kpis3 As String = String.Empty
    Private _course_kpis4 As String = String.Empty
    Private _course_kpis5 As String = String.Empty
    Private _score1 As String = String.Empty
    Private _score2 As String = String.Empty
    Private _score3 As String = String.Empty
    Private _score4 As String = String.Empty
    Private _score5 As String = String.Empty
    Private _before_hd_score As Decimal = 0
    Private _before_hd_weight As Decimal = 0
    Private _after_hd_score As Decimal = 0
    Private _after_hd_weight As Decimal = 0
    Private _competency As String = String.Empty
#Region "Exp Property"
#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub
#End Region

    Public ReadOnly Property exp_Guest_In() As Boolean
        Get
            Return IIf(_guest_internal = "Y", True, False)
        End Get
    End Property

    Public ReadOnly Property exp_Guest_external() As Boolean
        Get
            Return IIf(_guest_external = "Y", True, False)
        End Get
    End Property


    Public ReadOnly Property exp_owner_hr_flag() As Boolean
        Get
            Return IIf(_owner_hr_flag = "Y", True, False)
        End Get
    End Property

    Public ReadOnly Property exp_owner_other_flag() As Boolean
        Get
            Return IIf(_owner_other_flag = "Y", True, False)
        End Get
    End Property


    Public ReadOnly Property Item_Course_Struct() As Collection
        Get
            Return pmethGetStructCollaction()
        End Get
    End Property

    Public ReadOnly Property Item_Course_Exam() As Collection
        Get
            Return pmethGetExamCollaction()
        End Get
    End Property

    Public ReadOnly Property expcompetency As Cls_Competency
        Get
            Return New Cls_Competency(_competency)
        End Get
    End Property

    Public ReadOnly Property expowner_hr_empl As cls_person
        Get
            Return New cls_person(_owner_hr_empl)
        End Get
    End Property

    Public ReadOnly Property expowner_Oth As cls_person
        Get
            Return New cls_person(_owner_other)
        End Get
    End Property

    Public ReadOnly Property expCourse() As Cls_HD_Course
        Get
            Return New Cls_HD_Course(_course)
        End Get
    End Property

    Public ReadOnly Property expcourse_type() As Cls_HD_Course_Type
        Get
            Return New Cls_HD_Course_Type(_course_type)
        End Get
    End Property

    Public ReadOnly Property expHdTool() As Cls_HD_Tool
        Get
            Return New Cls_HD_Tool(_tool)
        End Get
    End Property

    Public ReadOnly Property expmethod() As Cls_HD_Method
        Get
            Return New Cls_HD_Method(_method)
        End Get
    End Property

    Public ReadOnly Property expassessment_level() As Cls_HD_Assessment_Level
        Get
            Return New Cls_HD_Assessment_Level(_assessment_level)
        End Get
    End Property

    Public ReadOnly Property expcourse_kpis1() As Cls_HD_Course_Kpis
        Get
            Return New Cls_HD_Course_Kpis(_course_kpis1)
        End Get
    End Property


    Public ReadOnly Property expcourse_kpis2() As Cls_HD_Course_Kpis
        Get
            Return New Cls_HD_Course_Kpis(_course_kpis2)
        End Get
    End Property

    Public ReadOnly Property expcourse_kpis3() As Cls_HD_Course_Kpis
        Get
            Return New Cls_HD_Course_Kpis(_course_kpis3)
        End Get
    End Property

    Public ReadOnly Property expcourse_kpis4() As Cls_HD_Course_Kpis
        Get
            Return New Cls_HD_Course_Kpis(_course_kpis4)
        End Get
    End Property

    Public ReadOnly Property expcourse_kpis5() As Cls_HD_Course_Kpis
        Get
            Return New Cls_HD_Course_Kpis(_course_kpis5)
        End Get
    End Property

    Public ReadOnly Property expscore1() As Cls_HD_Score
        Get
            Return New Cls_HD_Score(_score1)
        End Get
    End Property

    Public ReadOnly Property expscore2() As Cls_HD_Score
        Get
            Return New Cls_HD_Score(_score2)
        End Get
    End Property

    Public ReadOnly Property expscore3() As Cls_HD_Score
        Get
            Return New Cls_HD_Score(_score3)
        End Get
    End Property

    Public ReadOnly Property expscore4() As Cls_HD_Score
        Get
            Return New Cls_HD_Score(_score4)
        End Get
    End Property

    Public ReadOnly Property expscore5() As Cls_HD_Score
        Get
            Return New Cls_HD_Score(_score5)
        End Get
    End Property

    Public ReadOnly Property expguest_in_id1() As Cls_HD_Guest
        Get
            Return New Cls_HD_Guest(_guest_in_id1)
        End Get
    End Property

    Public ReadOnly Property expguest_in_id2() As Cls_HD_Guest
        Get
            Return New Cls_HD_Guest(_guest_in_id2)
        End Get
    End Property

    Public ReadOnly Property expguest_ext_id1() As Cls_HD_Guest
        Get
            Return New Cls_HD_Guest(_guest_ext_id1)
        End Get
    End Property

    Public ReadOnly Property expguest_ext_id2() As Cls_HD_Guest
        Get
            Return New Cls_HD_Guest(_guest_ext_id2)
        End Get
    End Property

#End Region

    'Public Property refno() As String
    '    Get
    '        Return _refno
    '    End Get
    '    Set(ByVal value As String)
    '        _refno = value
    '        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("refno"))
    '    End Set
    'End Property

    Public Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("code"))
        End Set
    End Property
    Public Property course() As String
        Get
            Return _course
        End Get
        Set(ByVal value As String)
            _course = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course"))
        End Set
    End Property
    Public Property course_type() As String
        Get
            Return _course_type
        End Get
        Set(ByVal value As String)
            _course_type = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course_type"))
        End Set
    End Property
    Public Property status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("status"))
        End Set
    End Property
    Public Property Doc_date() As DateTime
        Get
            Return _Doc_date
        End Get
        Set(ByVal value As DateTime)
            _Doc_date = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Doc_date"))
        End Set
    End Property
    Public Property guest_internal() As String
        Get
            Return _guest_internal
        End Get
        Set(ByVal value As String)
            _guest_internal = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("guest_internal"))
        End Set
    End Property
    Public Property guest_external() As String
        Get
            Return _guest_external
        End Get
        Set(ByVal value As String)
            _guest_external = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("guest_external"))
        End Set
    End Property
    Public Property guest_in_id1() As String
        Get
            Return _guest_in_id1
        End Get
        Set(ByVal value As String)
            _guest_in_id1 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("guest_in_id1"))
        End Set
    End Property
    Public Property guest_in_id2() As String
        Get
            Return _guest_in_id2
        End Get
        Set(ByVal value As String)
            _guest_in_id2 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("guest_in_id2"))
        End Set
    End Property
    Public Property guest_ext_id1() As String
        Get
            Return _guest_ext_id1
        End Get
        Set(ByVal value As String)
            _guest_ext_id1 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("guest_ext_id1"))
        End Set
    End Property
    Public Property guest_ext_id2() As String
        Get
            Return _guest_ext_id2
        End Get
        Set(ByVal value As String)
            _guest_ext_id2 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("guest_ext_id2"))
        End Set
    End Property
    'Public Property institution() As String
    '    Get
    '        Return _institution
    '    End Get
    '    Set(ByVal value As String)
    '        _institution = value
    '        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("institution"))
    '    End Set
    'End Property
    Public Property owner_hr_flag() As String
        Get
            Return _owner_hr_flag
        End Get
        Set(ByVal value As String)
            _owner_hr_flag = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("owner_hr_flag"))
        End Set
    End Property
    Public Property owner_other_flag() As String
        Get
            Return _owner_other_flag
        End Get
        Set(ByVal value As String)
            _owner_other_flag = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("owner_other_flag"))
        End Set
    End Property
    Public Property owner_hr_empl() As String
        Get
            Return _owner_hr_empl
        End Get
        Set(ByVal value As String)
            _owner_hr_empl = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("_owner_hr_empl"))
        End Set
    End Property
    Public Property owner_other() As String
        Get
            Return _owner_other
        End Get
        Set(ByVal value As String)
            _owner_other = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("owner_other"))
        End Set
    End Property
    Public Property need_hd1() As String
        Get
            Return _need_hd1
        End Get
        Set(ByVal value As String)
            _need_hd1 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd1"))
        End Set
    End Property
    Public Property need_hd2() As String
        Get
            Return _need_hd2
        End Get
        Set(ByVal value As String)
            _need_hd2 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd2"))
        End Set
    End Property
    Public Property need_hd3() As String
        Get
            Return _need_hd3
        End Get
        Set(ByVal value As String)
            _need_hd3 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd3"))
        End Set
    End Property
    Public Property need_hd4() As String
        Get
            Return _need_hd4
        End Get
        Set(ByVal value As String)
            _need_hd4 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd4"))
        End Set
    End Property
    Public Property need_hd5() As String
        Get
            Return _need_hd5
        End Get
        Set(ByVal value As String)
            _need_hd5 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd5"))
        End Set
    End Property
    Public Property need_hd6() As String
        Get
            Return _need_hd6
        End Get
        Set(ByVal value As String)
            _need_hd6 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd6"))
        End Set
    End Property
    Public Property need_hd7() As String
        Get
            Return _need_hd7
        End Get
        Set(ByVal value As String)
            _need_hd7 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd7"))
        End Set
    End Property
    Public Property need_hd8() As String
        Get
            Return _need_hd8
        End Get
        Set(ByVal value As String)
            _need_hd8 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd8"))
        End Set
    End Property
    Public Property need_hd9() As String
        Get
            Return _need_hd9
        End Get
        Set(ByVal value As String)
            _need_hd9 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd9"))
        End Set
    End Property
    Public Property need_hd10() As String
        Get
            Return _need_hd10
        End Get
        Set(ByVal value As String)
            _need_hd10 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("need_hd10"))
        End Set
    End Property
    Public Property Purpose_1() As String
        Get
            Return _Purpose_1
        End Get
        Set(ByVal value As String)
            _Purpose_1 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_1"))
        End Set
    End Property
    Public Property Purpose_2() As String
        Get
            Return _Purpose_2
        End Get
        Set(ByVal value As String)
            _Purpose_2 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_2"))
        End Set
    End Property
    Public Property Purpose_3() As String
        Get
            Return _Purpose_3
        End Get
        Set(ByVal value As String)
            _Purpose_3 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_3"))
        End Set
    End Property
    Public Property Purpose_4() As String
        Get
            Return _Purpose_4
        End Get
        Set(ByVal value As String)
            _Purpose_4 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_4"))
        End Set
    End Property
    Public Property Purpose_5() As String
        Get
            Return _Purpose_5
        End Get
        Set(ByVal value As String)
            _Purpose_5 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_5"))
        End Set
    End Property
    Public Property Purpose_6() As String
        Get
            Return _Purpose_6
        End Get
        Set(ByVal value As String)
            _Purpose_6 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_6"))
        End Set
    End Property
    Public Property Purpose_7() As String
        Get
            Return _Purpose_7
        End Get
        Set(ByVal value As String)
            _Purpose_7 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_7"))
        End Set
    End Property
    Public Property Purpose_8() As String
        Get
            Return _Purpose_8
        End Get
        Set(ByVal value As String)
            _Purpose_8 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_8"))
        End Set
    End Property
    Public Property Purpose_9() As String
        Get
            Return _Purpose_9
        End Get
        Set(ByVal value As String)
            _Purpose_9 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_9"))
        End Set
    End Property
    Public Property Purpose_10() As String
        Get
            Return _Purpose_10
        End Get
        Set(ByVal value As String)
            _Purpose_10 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Purpose_10"))
        End Set
    End Property
    Public Property tool() As String
        Get
            Return _tool
        End Get
        Set(ByVal value As String)
            _tool = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("tool"))
        End Set
    End Property
    Public Property method() As String
        Get
            Return _method
        End Get
        Set(ByVal value As String)
            _method = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("method"))
        End Set
    End Property
    Public Property assessment_level() As String
        Get
            Return _assessment_level
        End Get
        Set(ByVal value As String)
            _assessment_level = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("assessment_level"))
        End Set
    End Property
    Public Property course_kpis1() As String
        Get
            Return _course_kpis1
        End Get
        Set(ByVal value As String)
            _course_kpis1 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course_kpis1"))
        End Set
    End Property
    Public Property course_kpis2() As String
        Get
            Return _course_kpis2
        End Get
        Set(ByVal value As String)
            _course_kpis2 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course_kpis2"))
        End Set
    End Property
    Public Property course_kpis3() As String
        Get
            Return _course_kpis3
        End Get
        Set(ByVal value As String)
            _course_kpis3 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course_kpis3"))
        End Set
    End Property
    Public Property course_kpis4() As String
        Get
            Return _course_kpis4
        End Get
        Set(ByVal value As String)
            _course_kpis4 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course_kpis4"))
        End Set
    End Property
    Public Property course_kpis5() As String
        Get
            Return _course_kpis5
        End Get
        Set(ByVal value As String)
            _course_kpis5 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("course_kpis5"))
        End Set
    End Property
    Public Property score1() As String
        Get
            Return _score1
        End Get
        Set(ByVal value As String)
            _score1 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("score1"))
        End Set
    End Property
    Public Property score2() As String
        Get
            Return _score2
        End Get
        Set(ByVal value As String)
            _score2 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("score2"))
        End Set
    End Property
    Public Property score3() As String
        Get
            Return _score3
        End Get
        Set(ByVal value As String)
            _score3 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("score3"))
        End Set
    End Property
    Public Property score4() As String
        Get
            Return _score4
        End Get
        Set(ByVal value As String)
            _score4 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("score4"))
        End Set
    End Property
    Public Property score5() As String
        Get
            Return _score5
        End Get
        Set(ByVal value As String)
            _score5 = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("score5"))
        End Set
    End Property
    Public Property before_hd_score() As Decimal
        Get
            Return _before_hd_score
        End Get
        Set(ByVal value As Decimal)
            _before_hd_score = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("before_hd_score"))
        End Set
    End Property
    Public Property before_hd_weight() As Decimal
        Get
            Return _before_hd_weight
        End Get
        Set(ByVal value As Decimal)
            _before_hd_weight = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("before_hd_weight"))
        End Set
    End Property
    Public Property after_hd_score() As Decimal
        Get
            Return _after_hd_score
        End Get
        Set(ByVal value As Decimal)
            _after_hd_score = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("after_hd_score"))
        End Set
    End Property
    Public Property after_hd_weight() As Decimal
        Get
            Return _after_hd_weight
        End Get
        Set(ByVal value As Decimal)
            _after_hd_weight = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("after_hd_weight"))
        End Set
    End Property

    Public Property competency() As String
        Get
            Return _competency
        End Get
        Set(ByVal value As String)
            _competency = value
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("competency"))
        End Set
    End Property


#End Region

#Region "Item Property"
#End Region

#Region "Function"

    Function empty(GedMod As String) As Boolean
        If GedMod <> GBMod.Edit Then
            var_id = String.Empty
        End If
        var_id = String.Empty
        _code = String.Empty
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
            If var_Branch_id <> String.Empty And var_Branch_id <> "ALL" Then
                strwc = " and branch ='" & var_Branch_id.ToString() & "'"
            End If
            If var_id.Length > 0 Then
                strwc = strwc + " and cms_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_course_master where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & " and cms_date between ? and ? "
            strcommand = strcommand & vbCrLf & "order by cms_code "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", BegDate)
            cmd.Parameters.AddWithValue("@p2", EndDate)
            dt = SqlDB.GetDataTable(cmd)
            Return dt
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_Branch_id <> String.Empty And var_Branch_id <> "ALL" Then
                strwc = " and branch ='" & var_Branch_id.ToString() & "'"
            End If

            If var_id.Length > 0 Then
                strwc = strwc + " and cms_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_course_master where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "order by cms_code "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt

            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function CheckDupCode() As Boolean
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim dt As New DataTable
            Dim strcommand As String = ""
            strcommand = "select cms_code from hd_course_master "
            strcommand = strcommand & vbCrLf & " where corp = ? and cms_code = ? "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_corp_id)
            cmd.Parameters.AddWithValue("@p2", _code)
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

    Function Update(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = ""
        Try
            strcommand = "update hd_course_master set "
            strcommand = strcommand & vbCrLf & "corp = ? "
            strcommand = strcommand & vbCrLf & " ,branch = ? "
            strcommand = strcommand & vbCrLf & " ,cms_code = ? "
            strcommand = strcommand & vbCrLf & ",cms_course = ? "
            strcommand = strcommand & vbCrLf & ",cms_course_type = ? "
            strcommand = strcommand & vbCrLf & ",cms_status = ? "
            strcommand = strcommand & vbCrLf & ",cms_date = ? "
            strcommand = strcommand & vbCrLf & ",cms_guest_internal = ? "
            strcommand = strcommand & vbCrLf & ",cms_guest_external = ? "
            strcommand = strcommand & vbCrLf & ",cms_guest_in_id1 = ? "
            strcommand = strcommand & vbCrLf & ",cms_guest_in_id2 = ? "
            strcommand = strcommand & vbCrLf & ",cms_guest_ext_id1 = ? "
            strcommand = strcommand & vbCrLf & ",cms_guest_ext_id2 = ? "
            'strcommand = strcommand & vbCrLf & ",cms_institution = ? "
            strcommand = strcommand & vbCrLf & ",cms_owner_hr_flag = ? "
            strcommand = strcommand & vbCrLf & ",cms_owner_other_flag = ? "
            strcommand = strcommand & vbCrLf & ",cms_owner_hr_empl = ? "
            strcommand = strcommand & vbCrLf & ",cms_owner_other = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd1 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd2 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd3 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd4 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd5 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd6 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd7 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd8 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd9 = ? "
            strcommand = strcommand & vbCrLf & ",cms_need_hd10 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_1 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_2 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_3 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_4 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_5 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_6 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_7 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_8 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_9 = ? "
            strcommand = strcommand & vbCrLf & ",cms_Purpose_10 = ? "
            strcommand = strcommand & vbCrLf & ",cms_tool = ? "
            strcommand = strcommand & vbCrLf & ",cms_method = ? "
            strcommand = strcommand & vbCrLf & ",cms_assessment_level = ? "
            strcommand = strcommand & vbCrLf & ",cms_course_kpis1 = ? "
            strcommand = strcommand & vbCrLf & ",cms_course_kpis2 = ? "
            strcommand = strcommand & vbCrLf & ",cms_course_kpis3 = ? "
            strcommand = strcommand & vbCrLf & ",cms_course_kpis4 = ? "
            strcommand = strcommand & vbCrLf & ",cms_course_kpis5 = ? "
            strcommand = strcommand & vbCrLf & ",cms_score1 = ? "
            strcommand = strcommand & vbCrLf & ",cms_score2 = ? "
            strcommand = strcommand & vbCrLf & ",cms_score3 = ? "
            strcommand = strcommand & vbCrLf & ",cms_score4 = ? "
            strcommand = strcommand & vbCrLf & ",cms_score5 = ? "
            strcommand = strcommand & vbCrLf & ",cms_before_hd_score = ? "
            strcommand = strcommand & vbCrLf & ",cms_before_hd_weight = ? "
            strcommand = strcommand & vbCrLf & ",cms_after_hd_score = ? "
            strcommand = strcommand & vbCrLf & ",cms_after_hd_weight = ? "
            strcommand = strcommand & vbCrLf & ",cmd_competency = ? "
            strcommand = strcommand & vbCrLf & ",cms_edit_by = ? "
            strcommand = strcommand & vbCrLf & ",cms_edit_date = ? "
            strcommand = strcommand & vbCrLf & " where cms_id = ?"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _code)
            cmd.Parameters.AddWithValue("@p4", _course)
            cmd.Parameters.AddWithValue("@p5", _course_type)
            cmd.Parameters.AddWithValue("@p6", _status)
            cmd.Parameters.AddWithValue("@p7", _Doc_date)
            cmd.Parameters.AddWithValue("@p8", _guest_internal)
            cmd.Parameters.AddWithValue("@p9", _guest_external)
            cmd.Parameters.AddWithValue("@p10", _guest_in_id1)

            cmd.Parameters.AddWithValue("@p11", _guest_in_id2)
            cmd.Parameters.AddWithValue("@p12", _guest_ext_id1)
            cmd.Parameters.AddWithValue("@p13", _guest_ext_id2)
            'cmd.Parameters.AddWithValue("@p14", _institution)
            cmd.Parameters.AddWithValue("@p14", _owner_hr_flag)
            cmd.Parameters.AddWithValue("@p15", _owner_other_flag)
            cmd.Parameters.AddWithValue("@p16", _owner_hr_empl)
            cmd.Parameters.AddWithValue("@p17", _owner_other)
            cmd.Parameters.AddWithValue("@p18", _need_hd1)
            cmd.Parameters.AddWithValue("@p19", _need_hd2)

            cmd.Parameters.AddWithValue("@p20", _need_hd3)
            cmd.Parameters.AddWithValue("@p21", _need_hd4)
            cmd.Parameters.AddWithValue("@p22", _need_hd5)
            cmd.Parameters.AddWithValue("@p23", _need_hd6)
            cmd.Parameters.AddWithValue("@p24", _need_hd7)
            cmd.Parameters.AddWithValue("@p25", _need_hd8)
            cmd.Parameters.AddWithValue("@p26", _need_hd9)
            cmd.Parameters.AddWithValue("@p27", _need_hd10)
            cmd.Parameters.AddWithValue("@p28", _Purpose_1)
            cmd.Parameters.AddWithValue("@p29", _Purpose_2)

            cmd.Parameters.AddWithValue("@p30", _Purpose_3)
            cmd.Parameters.AddWithValue("@p31", _Purpose_4)
            cmd.Parameters.AddWithValue("@p32", _Purpose_5)
            cmd.Parameters.AddWithValue("@p33", _Purpose_6)
            cmd.Parameters.AddWithValue("@p34", _Purpose_7)
            cmd.Parameters.AddWithValue("@p35", _Purpose_8)
            cmd.Parameters.AddWithValue("@p36", _Purpose_9)
            cmd.Parameters.AddWithValue("@p37", _Purpose_10)
            cmd.Parameters.AddWithValue("@p38", _tool)
            cmd.Parameters.AddWithValue("@p39", _method)

            cmd.Parameters.AddWithValue("@p40", _assessment_level)
            cmd.Parameters.AddWithValue("@p41", _course_kpis1)
            cmd.Parameters.AddWithValue("@p42", _course_kpis2)
            cmd.Parameters.AddWithValue("@p43", _course_kpis3)
            cmd.Parameters.AddWithValue("@p44", _course_kpis4)
            cmd.Parameters.AddWithValue("@p45", _course_kpis5)
            cmd.Parameters.AddWithValue("@p46", _score1)
            cmd.Parameters.AddWithValue("@p47", _score2)
            cmd.Parameters.AddWithValue("@p48", _score3)
            cmd.Parameters.AddWithValue("@p49", _score4)
            cmd.Parameters.AddWithValue("@p50", _score5)

            cmd.Parameters.AddWithValue("@p51", _before_hd_score)
            cmd.Parameters.AddWithValue("@p52", _before_hd_weight)
            cmd.Parameters.AddWithValue("@p53", _after_hd_score)
            cmd.Parameters.AddWithValue("@p54", _after_hd_weight)
            cmd.Parameters.AddWithValue("@p55", _competency)
            cmd.Parameters.AddWithValue("@p56", GBUsername)
            cmd.Parameters.AddWithValue("@p57", DateTime.Now)
            cmd.Parameters.AddWithValue("@p58", var_id)

            SqlDB.Exec(cmd)
            message = "บันทึกข้อมูลเรียบร้อยแล้ว"
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try

        Return True
    End Function

    Function RetreiveByCourseName(strCode As String, strName As String) As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            Dim cmd As New OleDbCommand
            If var_id.Length > 0 Then
                strwc = " and cms_id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from hd_course_master m "
            strcommand = strcommand & vbCrLf & " inner join hd_course c on c.cos_id = m.cms_course "
            strcommand = strcommand & vbCrLf & " where corp = '" & GBCorp & "' " & strwc
            If strCode <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and c.cos_code = ? "
            End If
            If strName <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and c.cos_name like ? "
            End If
            strcommand = strcommand & vbCrLf & " Order by c.cos_code,c.cos_name "
            cmd = SqlDB.CreateCommand(strcommand)
            If strCode <> String.Empty Then
                cmd.Parameters.AddWithValue("@p1", strCode)
            End If
            If strName <> String.Empty Then
                cmd.Parameters.AddWithValue("@p2", "%" & strName & "%")
            End If
            dt = SqlDB.GetDataTable(cmd)
            Return dt

            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function RetreiveByCompentency() As DataTable
        Try
            Dim dt As New DataTable
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim strcommand As String = String.Empty
            strcommand = "select * from hd_course_master where cmd_competency ='" & _competency.ToString() & "'"
            strcommand = strcommand & vbCrLf & "order by cms_code"
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Add(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = ""
        Try
            strcommand = "insert into hd_course_master("
            strcommand = strcommand & vbCrLf & "corp,branch,cms_id,cms_code,cms_course"
            strcommand = strcommand & vbCrLf & ",cms_course_type,cms_status,cms_date,cms_guest_internal,cms_guest_external"
            strcommand = strcommand & vbCrLf & ",cms_guest_in_id1,cms_guest_in_id2,cms_guest_ext_id1,cms_guest_ext_id2"
            strcommand = strcommand & vbCrLf & ",cms_owner_hr_flag,cms_owner_other_flag,cms_owner_hr_empl,cms_owner_other,cms_need_hd1"
            strcommand = strcommand & vbCrLf & ",cms_need_hd2,cms_need_hd3,cms_need_hd4,cms_need_hd5,cms_need_hd6,cms_need_hd7,cms_need_hd8"
            strcommand = strcommand & vbCrLf & ",cms_need_hd9,cms_need_hd10,cms_Purpose_1,cms_Purpose_2,cms_Purpose_3,cms_Purpose_4,cms_Purpose_5"
            strcommand = strcommand & vbCrLf & ",cms_Purpose_6,cms_Purpose_7,cms_Purpose_8,cms_Purpose_9,cms_Purpose_10,cms_tool,cms_method"
            strcommand = strcommand & vbCrLf & ",cms_assessment_level,cms_course_kpis1,cms_course_kpis2,cms_course_kpis3,cms_course_kpis4,cms_course_kpis5"
            strcommand = strcommand & vbCrLf & ",cms_score1,cms_score2,cms_score3,cms_score4,cms_score5"
            strcommand = strcommand & vbCrLf & ",cms_before_hd_score,cms_before_hd_weight,cms_after_hd_score,cms_after_hd_weight,cmd_competency"
            strcommand = strcommand & vbCrLf & ",cms_create_by,cms_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()

            cmd.Parameters.AddWithValue("@p1", Config.GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _code)
            cmd.Parameters.AddWithValue("@p5", _course)
            cmd.Parameters.AddWithValue("@p6", _course_type)
            cmd.Parameters.AddWithValue("@p7", _status)
            cmd.Parameters.AddWithValue("@p8", _Doc_date)
            cmd.Parameters.AddWithValue("@p9", _guest_internal)
            cmd.Parameters.AddWithValue("@p10", _guest_external)

            cmd.Parameters.AddWithValue("@p11", _guest_in_id1)
            cmd.Parameters.AddWithValue("@p12", _guest_in_id2)
            cmd.Parameters.AddWithValue("@p13", _guest_ext_id1)
            cmd.Parameters.AddWithValue("@p14", _guest_ext_id2)
            'cmd.Parameters.AddWithValue("@p15", _institution)
            cmd.Parameters.AddWithValue("@p15", _owner_hr_flag)
            cmd.Parameters.AddWithValue("@p16", _owner_other_flag)
            cmd.Parameters.AddWithValue("@p17", _owner_hr_empl)
            cmd.Parameters.AddWithValue("@p18", _owner_other)
            cmd.Parameters.AddWithValue("@p19", _need_hd1)


            cmd.Parameters.AddWithValue("@p20", _need_hd2)
            cmd.Parameters.AddWithValue("@p21", _need_hd3)
            cmd.Parameters.AddWithValue("@p22", _need_hd4)
            cmd.Parameters.AddWithValue("@p23", _need_hd5)
            cmd.Parameters.AddWithValue("@p24", _need_hd6)
            cmd.Parameters.AddWithValue("@p25", _need_hd7)
            cmd.Parameters.AddWithValue("@p26", _need_hd8)
            cmd.Parameters.AddWithValue("@p27", _need_hd9)
            cmd.Parameters.AddWithValue("@p28", _need_hd10)
            cmd.Parameters.AddWithValue("@p29", _Purpose_1)

            cmd.Parameters.AddWithValue("@p30", _Purpose_2)
            cmd.Parameters.AddWithValue("@p31", _Purpose_3)
            cmd.Parameters.AddWithValue("@p32", _Purpose_4)
            cmd.Parameters.AddWithValue("@p33", _Purpose_5)
            cmd.Parameters.AddWithValue("@p34", _Purpose_6)
            cmd.Parameters.AddWithValue("@p35", _Purpose_7)
            cmd.Parameters.AddWithValue("@p36", _Purpose_8)
            cmd.Parameters.AddWithValue("@p37", _Purpose_9)
            cmd.Parameters.AddWithValue("@p38", _Purpose_10)
            cmd.Parameters.AddWithValue("@p39", _tool)

            cmd.Parameters.AddWithValue("@p40", _method)
            cmd.Parameters.AddWithValue("@p41", _assessment_level)
            cmd.Parameters.AddWithValue("@p42", _course_kpis1)
            cmd.Parameters.AddWithValue("@p43", _course_kpis2)
            cmd.Parameters.AddWithValue("@p44", _course_kpis3)
            cmd.Parameters.AddWithValue("@p45", _course_kpis4)
            cmd.Parameters.AddWithValue("@p46", _course_kpis5)
            cmd.Parameters.AddWithValue("@p47", _score1)
            cmd.Parameters.AddWithValue("@p48", _score2)
            cmd.Parameters.AddWithValue("@p49", _score3)

            cmd.Parameters.AddWithValue("@p50", _score4)
            cmd.Parameters.AddWithValue("@p51", _score5)
            cmd.Parameters.AddWithValue("@p52", _before_hd_score)
            cmd.Parameters.AddWithValue("@p53", _before_hd_weight)
            cmd.Parameters.AddWithValue("@p54", _after_hd_score)
            cmd.Parameters.AddWithValue("@p55", _after_hd_weight)
            cmd.Parameters.AddWithValue("@p56", _competency)
            cmd.Parameters.AddWithValue("@p57", GBUsername)
            cmd.Parameters.AddWithValue("@p58", DateTime.Now)

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
        Dim strwc As String = String.Empty
        Dim bSucc As Boolean = True
        Try
            strcommand = "delete from hd_course_master "
            strcommand = strcommand & vbCrLf & "where cms_id = ? "
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

#End Region


    Private Function pmethGetStructCollaction() As Collection
        Dim Col_Data As New Collection
        Dim Course_Struct As New Cls_HD_Course_Struct()
        Course_Struct.course_master = var_id
        Dim dt As DataTable = Course_Struct.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim Item_Course_Struce As New Cls_HD_Course_Struct
                Item_Course_Struce.id = cNull(dt.Rows(row).Item("cst_id"), "S")
                Item_Course_Struce.course_master = cNull(dt.Rows(row).Item("cst_course_master"), "S")
                Item_Course_Struce.seq = cNull(dt.Rows(row).Item("cst_seq"), "N")
                Item_Course_Struce.course_item = cNull(dt.Rows(row).Item("cst_course_item"), "S")
                Item_Course_Struce.course_content1 = cNull(dt.Rows(row).Item("cst_course_content1"), "S")
                Item_Course_Struce.course_content2 = cNull(dt.Rows(row).Item("cst_course_content2"), "S")
                Item_Course_Struce.course_content3 = cNull(dt.Rows(row).Item("cst_course_content3"), "S")
                Item_Course_Struce.course_content4 = cNull(dt.Rows(row).Item("cst_course_content4"), "S")
                Item_Course_Struce.course_content5 = cNull(dt.Rows(row).Item("cst_course_content5"), "S")
                Item_Course_Struce.course_content6 = cNull(dt.Rows(row).Item("cst_course_content6"), "S")
                Item_Course_Struce.course_content7 = cNull(dt.Rows(row).Item("cst_course_content7"), "S")
                Item_Course_Struce.course_content8 = cNull(dt.Rows(row).Item("cst_course_content8"), "S")
                Item_Course_Struce.main_hour = cNull(dt.Rows(row).Item("cst_main_hour"), "S")
                Item_Course_Struce.create_by = cNull(dt.Rows(row).Item("cst_create_by"), "S")
                Item_Course_Struce.create_date = cNull(dt.Rows(row).Item("cst_create_date"), "D")
                Item_Course_Struce.edit_by = cNull(dt.Rows(row).Item("cst_edit_by"), "S")
                Col_Data.Add(Item_Course_Struce)
            Next
        End If
        Return Col_Data
    End Function

    Private Function pmethGetExamCollaction() As Collection
        Dim Col_Data As New Collection
        Dim Course_Struct As New Cls_HD_Course_Exam()
        Course_Struct.course_master = var_id
        Dim dt As DataTable = Course_Struct.Retreive()
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim Item_Course_Struce As New Cls_HD_Course_Exam
                Item_Course_Struce.id = cNull(dt.Rows(row).Item("cex_id"), "S")
                Item_Course_Struce.course_master = cNull(dt.Rows(row).Item("cex_course_master"), "S")
                Item_Course_Struce.exam_master = cNull(dt.Rows(row).Item("cex_exam_master"), "S")
                Item_Course_Struce.seq = cNull(dt.Rows(row).Item("cex_seq"), "N")
                Col_Data.Add(Item_Course_Struce)
            Next
        End If
        Return Col_Data
    End Function

    Public Sub Clear()
        _code = String.Empty
        _course = String.Empty
        _course_type = String.Empty
        _status = String.Empty
        _Doc_date = DateTime.Now.Date
        _guest_internal = "N"
        _guest_external = "N"
        _guest_in_id1 = String.Empty
        _guest_in_id2 = String.Empty
        _guest_ext_id1 = String.Empty
        _guest_ext_id2 = String.Empty
        '_institution = String.Empty
        _owner_hr_flag = "N"
        _owner_other_flag = "N"
        _owner_hr_empl = String.Empty
        _owner_other = String.Empty
        _need_hd1 = String.Empty
        _need_hd2 = String.Empty
        _need_hd3 = String.Empty
        _need_hd4 = String.Empty
        _need_hd5 = String.Empty
        _need_hd6 = String.Empty
        _need_hd7 = String.Empty
        _need_hd8 = String.Empty
        _need_hd9 = String.Empty
        _need_hd10 = String.Empty
        _Purpose_1 = String.Empty
        _Purpose_2 = String.Empty
        _Purpose_3 = String.Empty
        _Purpose_4 = String.Empty
        _Purpose_5 = String.Empty
        _Purpose_6 = String.Empty
        _Purpose_7 = String.Empty
        _Purpose_8 = String.Empty
        _Purpose_9 = String.Empty
        _Purpose_10 = String.Empty
        _tool = String.Empty
        _method = String.Empty
        _assessment_level = String.Empty
        _course_kpis1 = String.Empty
        _course_kpis2 = String.Empty
        _course_kpis3 = String.Empty
        _course_kpis4 = String.Empty
        _course_kpis5 = String.Empty
        _score1 = String.Empty
        _score2 = String.Empty
        _score3 = String.Empty
        _score4 = String.Empty
        _score5 = String.Empty
        _before_hd_score = 0
        _before_hd_weight = 0
        _after_hd_score = 0
        _after_hd_weight = 0
        _competency = String.Empty
    End Sub

    Private Sub pmethSetproperty(dt As DataTable)
        var_Branch_id = cNull(dt.Rows(0).Item("branch"), "S")
        _code = cNull(dt.Rows(0).Item("cms_code"), "S")
        _course = cNull(dt.Rows(0).Item("cms_course"), "S")
        _course_type = cNull(dt.Rows(0).Item("cms_course_type"), "S")
        _status = cNull(dt.Rows(0).Item("cms_status"), "S")
        _Doc_date = cNull(dt.Rows(0).Item("cms_date"), "D")
        _guest_internal = cNull(dt.Rows(0).Item("cms_guest_internal"), "S")
        _guest_external = cNull(dt.Rows(0).Item("cms_guest_external"), "S")
        _guest_in_id1 = cNull(dt.Rows(0).Item("cms_guest_in_id1"), "S")
        _guest_in_id2 = cNull(dt.Rows(0).Item("cms_guest_in_id2"), "S")
        _guest_ext_id1 = cNull(dt.Rows(0).Item("cms_guest_ext_id1"), "S")
        _guest_ext_id2 = cNull(dt.Rows(0).Item("cms_guest_ext_id2"), "S")
        '_institution = cNull(dt.Rows(0).Item("cms_institution"), "S")
        _owner_hr_flag = cNull(dt.Rows(0).Item("cms_owner_hr_flag"), "S")
        _owner_other_flag = cNull(dt.Rows(0).Item("cms_owner_other_flag"), "S")
        _owner_hr_empl = cNull(dt.Rows(0).Item("cms_owner_hr_empl"), "S")
        _owner_other = cNull(dt.Rows(0).Item("cms_owner_other"), "S")
        _need_hd1 = cNull(dt.Rows(0).Item("cms_need_hd1"), "S")
        _need_hd2 = cNull(dt.Rows(0).Item("cms_need_hd2"), "S")
        _need_hd3 = cNull(dt.Rows(0).Item("cms_need_hd3"), "S")
        _need_hd4 = cNull(dt.Rows(0).Item("cms_need_hd4"), "S")
        _need_hd5 = cNull(dt.Rows(0).Item("cms_need_hd5"), "S")
        _need_hd6 = cNull(dt.Rows(0).Item("cms_need_hd6"), "S")
        _need_hd7 = cNull(dt.Rows(0).Item("cms_need_hd7"), "S")
        _need_hd8 = cNull(dt.Rows(0).Item("cms_need_hd8"), "S")
        _need_hd9 = cNull(dt.Rows(0).Item("cms_need_hd9"), "S")
        _need_hd10 = cNull(dt.Rows(0).Item("cms_need_hd10"), "S")
        _Purpose_1 = cNull(dt.Rows(0).Item("cms_Purpose_1"), "S")
        _Purpose_2 = cNull(dt.Rows(0).Item("cms_Purpose_2"), "S")
        _Purpose_3 = cNull(dt.Rows(0).Item("cms_Purpose_3"), "S")
        _Purpose_4 = cNull(dt.Rows(0).Item("cms_Purpose_4"), "S")
        _Purpose_5 = cNull(dt.Rows(0).Item("cms_Purpose_5"), "S")
        _Purpose_6 = cNull(dt.Rows(0).Item("cms_Purpose_6"), "S")
        _Purpose_7 = cNull(dt.Rows(0).Item("cms_Purpose_7"), "S")
        _Purpose_8 = cNull(dt.Rows(0).Item("cms_Purpose_8"), "S")
        _Purpose_9 = cNull(dt.Rows(0).Item("cms_Purpose_9"), "S")
        _Purpose_10 = cNull(dt.Rows(0).Item("cms_Purpose_10"), "S")
        _tool = cNull(dt.Rows(0).Item("cms_tool"), "S")
        _method = cNull(dt.Rows(0).Item("cms_method"), "S")
        _assessment_level = cNull(dt.Rows(0).Item("cms_assessment_level"), "S")
        _course_kpis1 = cNull(dt.Rows(0).Item("cms_course_kpis1"), "S")
        _course_kpis2 = cNull(dt.Rows(0).Item("cms_course_kpis2"), "S")
        _course_kpis3 = cNull(dt.Rows(0).Item("cms_course_kpis3"), "S")
        _course_kpis4 = cNull(dt.Rows(0).Item("cms_course_kpis4"), "S")
        _course_kpis5 = cNull(dt.Rows(0).Item("cms_course_kpis5"), "S")
        _score1 = cNull(dt.Rows(0).Item("cms_score1"), "S")
        _score2 = cNull(dt.Rows(0).Item("cms_score2"), "S")
        _score3 = cNull(dt.Rows(0).Item("cms_score3"), "S")
        _score4 = cNull(dt.Rows(0).Item("cms_score4"), "S")
        _score5 = cNull(dt.Rows(0).Item("cms_score5"), "S")
        _before_hd_score = cNull(dt.Rows(0).Item("cms_before_hd_score"), "N")
        _before_hd_weight = cNull(dt.Rows(0).Item("cms_before_hd_weight"), "N")
        _after_hd_score = cNull(dt.Rows(0).Item("cms_after_hd_score"), "N")
        _after_hd_weight = cNull(dt.Rows(0).Item("cms_after_hd_weight"), "N")
        _competency = cNull(dt.Rows(0).Item("cmd_competency"), "S")
    End Sub









End Class
