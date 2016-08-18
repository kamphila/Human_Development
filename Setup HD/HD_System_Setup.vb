Public Class HD_System_Setup
    Public mode As String = String.Empty
    Private ClassData As Object
    Dim Course As New Cls_HD_Course
    Dim Course_Type As New Cls_HD_Course_Type
    Dim Course_Item As New Cls_HD_Course_Item
    Dim Course_Content As New Cls_HD_Course_Content
    Dim Tool As New Cls_HD_Tool
    Dim Method As New Cls_HD_Method
    Dim Score As New Cls_HD_Score
    Dim Assessment_Level As New Cls_HD_Assessment_Level
    Dim Course_Kpis As New Cls_HD_Course_Kpis
    Dim Criteria_Kpis As New Cls_HD_Criteria_Kpis
    Dim Cost As New Cls_HD_Cost
    Dim Budget As New Cls_HD_Budget
    Dim Exam_Master As New Cls_HD_Exam_Master
    Dim Place As New Cls_HD_Place
    Dim Guest As New Cls_HD_Guest

#Region "Load"
    Private Sub HD_System_Setup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
        pmethSetProp()
    End Sub

    Private Sub pmethSetProp()

    End Sub

    Public Sub binddata()
        Select Case TabPageSetup.SelectedIndex
            Case 0
                pmethbindHdCourse()
            Case 1
                pmethBindHDCourseType()
            Case 2
                pmethBindHDCourseItem()
            Case 3
                pmethBindHDCourseContent()
            Case 4
                pmethBindHDTool()
            Case 5
                pmethBindHDMethod()
            Case 6
                pmethBindHDScore()
            Case 7
                pmethBindHDAssessmentLevel()
            Case 8
                pmethBindHDCourseKpis()
            Case 9
                pmethBindHdCriteriaKpis()
            Case 10
                pmethBindHdCost()
            Case 11
                pmethBindHdBudget()
            Case 12
                pmethBindHdExamMaster()
            Case 13
                pmethBindHdPlace()
            Case 14
                pmethBindHdGuest()
        End Select
    End Sub

    Private Sub pmethbindHdCourse()
        Try
            Dim dt As New DataTable
            Course.code = ""
            dt = Course.Retreive()
            lvCourse.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCourse.FullRowSelect = True
                lvCourse.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCourse.Items.Add(dt.Rows(row).Item("cos_id").ToString())
                    lvCourse.Items(nindex).SubItems.Add(nindex + 1)
                    lvCourse.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_code").ToString())
                    lvCourse.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_name").ToString())
                    lvCourse.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_name2").ToString())
                    lvCourse.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHDCourseType()
        Try
            Dim dt As New DataTable
            Course_Type.code = ""
            dt = Course_Type.Retreive()
            lvCourse_type.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCourse_type.FullRowSelect = True
                lvCourse_type.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCourse_type.Items.Add(dt.Rows(row).Item("cot_id").ToString())
                    lvCourse_type.Items(nindex).SubItems.Add(nindex + 1)
                    lvCourse_type.Items(nindex).SubItems.Add(dt.Rows(row).Item("cot_code").ToString())
                    lvCourse_type.Items(nindex).SubItems.Add(dt.Rows(row).Item("cot_name").ToString())
                    lvCourse_type.Items(nindex).SubItems.Add(dt.Rows(row).Item("cot_name2").ToString())
                    lvCourse_type.Items(nindex).SubItems.Add(dt.Rows(row).Item("cot_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHDCourseItem()
        Try
            Dim dt As New DataTable
            Course_Item.code = ""
            dt = Course_Item.Retreive()
            lvCourse_item.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCourse_item.FullRowSelect = True
                lvCourse_item.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCourse_item.Items.Add(dt.Rows(row).Item("coi_id").ToString())
                    lvCourse_item.Items(nindex).SubItems.Add(nindex + 1)
                    lvCourse_item.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_code").ToString())
                    lvCourse_item.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_name").ToString())
                    lvCourse_item.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_name2").ToString())
                    lvCourse_item.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHDCourseContent()
        Try
            Dim dt As New DataTable
            Course_Content.code = ""
            dt = Course_Content.Retreive()
            lvCourse_content.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCourse_content.FullRowSelect = True
                lvCourse_content.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCourse_content.Items.Add(dt.Rows(row).Item("coc_id").ToString())
                    lvCourse_content.Items(nindex).SubItems.Add(nindex + 1)
                    lvCourse_content.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_code").ToString())
                    lvCourse_content.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_name").ToString())
                    lvCourse_content.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_name2").ToString())
                    lvCourse_content.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub pmethBindHDTool()
        Try
            Dim dt As New DataTable
            Tool.code = ""
            dt = Tool.Retreive()
            lvTool.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvTool.FullRowSelect = True
                lvTool.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvTool.Items.Add(dt.Rows(row).Item("hdt_id").ToString())
                    lvTool.Items(nindex).SubItems.Add(nindex + 1)
                    lvTool.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdt_code").ToString())
                    lvTool.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdt_name").ToString())
                    lvTool.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdt_name2").ToString())
                    lvTool.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdt_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHDMethod()
        Try
            Dim dt As New DataTable
            Method.code = ""
            dt = Method.Retreive()
            lvMethod.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvMethod.FullRowSelect = True
                lvMethod.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvMethod.Items.Add(dt.Rows(row).Item("hdm_id").ToString())
                    lvMethod.Items(nindex).SubItems.Add(nindex + 1)
                    lvMethod.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdm_code").ToString())
                    lvMethod.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdm_name").ToString())
                    lvMethod.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdm_name2").ToString())
                    lvMethod.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdm_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHDScore()
        Try
            Dim dt As New DataTable
            Score.code = ""
            dt = Score.Retreive()
            lvScore.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvScore.FullRowSelect = True
                lvScore.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvScore.Items.Add(dt.Rows(row).Item("hds_id").ToString())
                    lvScore.Items(nindex).SubItems.Add(nindex + 1)
                    lvScore.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_code").ToString())
                    lvScore.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_name").ToString())
                    lvScore.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_name2").ToString())
                    lvScore.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_begscore").ToString())
                    lvScore.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_endscore").ToString())
                    lvScore.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHDAssessmentLevel()
        Try
            Dim dt As New DataTable
            Assessment_Level.code = ""
            dt = Assessment_Level.Retreive()
            lvAssessment_level.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvAssessment_level.FullRowSelect = True
                lvAssessment_level.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvAssessment_level.Items.Add(dt.Rows(row).Item("asl_id").ToString())
                    lvAssessment_level.Items(nindex).SubItems.Add(nindex + 1)
                    lvAssessment_level.Items(nindex).SubItems.Add(dt.Rows(row).Item("asl_code").ToString())
                    lvAssessment_level.Items(nindex).SubItems.Add(dt.Rows(row).Item("asl_name").ToString())
                    lvAssessment_level.Items(nindex).SubItems.Add(dt.Rows(row).Item("asl_name2").ToString())
                    lvAssessment_level.Items(nindex).SubItems.Add(dt.Rows(row).Item("asl_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHDCourseKpis()
        Try
            Dim dt As New DataTable
            Course_Kpis.code = ""
            dt = Course_Kpis.Retreive()
            lvCourse_kpis.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCourse_kpis.FullRowSelect = True
                lvCourse_kpis.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCourse_kpis.Items.Add(dt.Rows(row).Item("ckp_id").ToString())
                    lvCourse_kpis.Items(nindex).SubItems.Add(nindex + 1)
                    lvCourse_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_code").ToString())
                    lvCourse_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_name").ToString())
                    lvCourse_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_name2").ToString())
                    lvCourse_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_source").ToString())
                    lvCourse_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHdCriteriaKpis()
        Try
            Dim dt As New DataTable
            Criteria_Kpis.code = ""
            dt = Criteria_Kpis.Retreive()
            lvCriteria_kpis.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCriteria_kpis.FullRowSelect = True
                lvCriteria_kpis.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCriteria_kpis.Items.Add(dt.Rows(row).Item("crkp_id").ToString())
                    lvCriteria_kpis.Items(nindex).SubItems.Add(nindex + 1)
                    lvCriteria_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("crkp_code").ToString())
                    lvCriteria_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("crkp_name").ToString())
                    lvCriteria_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("crkp_name2").ToString())
                    lvCriteria_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("crkp_desc").ToString())
                    lvCriteria_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("crkp_begscore").ToString())
                    lvCriteria_kpis.Items(nindex).SubItems.Add(dt.Rows(row).Item("crkp_endscore").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHdCost()
        Try
            Dim dt As DataTable
            Cost.code = ""
            dt = Cost.Retreive()
            lvCost.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCost.FullRowSelect = True
                lvCost.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCost.Items.Add(dt.Rows(row).Item("hdc_id").ToString())
                    lvCost.Items(nindex).SubItems.Add(nindex + 1)
                    lvCost.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdc_code").ToString())
                    lvCost.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdc_name").ToString())
                    lvCost.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdc_name2").ToString())
                    lvCost.Items(nindex).SubItems.Add(dt.Rows(row).Item("hdc_desc").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHdBudget()
        Try
            Dim dt As New DataTable
            Dim var_sumBudget As Int64 = 0
            Budget.code = ""
            dt = Budget.Retreive()
            GroupBox12.ResetText()
            lvBudget.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvBudget.FullRowSelect = True
                lvBudget.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    Dim station As New Cls_Station(dt.Rows(row).Item("bgt_station").ToString())
                    lvBudget.Items.Add(dt.Rows(row).Item("bgt_id").ToString())
                    lvBudget.Items(nindex).SubItems.Add(nindex + 1)
                    'lvBudget.Items(nindex).SubItems.Add(dt.Rows(row).Item("bgt_code").ToString())
                    'lvBudget.Items(nindex).SubItems.Add(dt.Rows(row).Item("bgt_name").ToString())
                    'lvBudget.Items(nindex).SubItems.Add(dt.Rows(row).Item("bgt_name2").ToString())
                    lvBudget.Items(nindex).SubItems.Add(station.code)
                    lvBudget.Items(nindex).SubItems.Add(station.name)
                    lvBudget.Items(nindex).SubItems.Add(station.name2)
                    lvBudget.Items(nindex).SubItems.Add(Convert.ToDecimal(dt.Rows(row).Item("bgt_amt").ToString()).ToString("N2"))
                    'lvBudget.Items(nindex).SubItems.Add(dt.Rows(row).Item("bgt_year").ToString())
                    lvBudget.Items(nindex).SubItems.Add(Cls_SqlDB.DateToStringTH(dt.Rows(row).Item("bgt_begdate").ToString()))
                    lvBudget.Items(nindex).SubItems.Add(Cls_SqlDB.DateToStringTH(dt.Rows(row).Item("bgt_enddate").ToString()))
                    lvBudget.Items(nindex).SubItems.Add(dt.Rows(row).Item("bgt_desc").ToString())
                    nindex = nindex + 1
                    var_sumBudget = var_sumBudget + dt.Rows(row).Item("bgt_amt")

                Next
                GroupBox12.Text = "งบประมาณประจำปี  ทั้งหมด " & var_sumBudget & " บาท"
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHdExamMaster()
        Try
            Dim dt As New DataTable
            Exam_Master.code = ""
            dt = Exam_Master.Retreive()
            lvExam_master.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvExam_master.FullRowSelect = True
                lvExam_master.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvExam_master.Items.Add(dt.Rows(row).Item("exm_id").ToString())
                    lvExam_master.Items(nindex).SubItems.Add(nindex + 1)
                    lvExam_master.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_code").ToString())
                    lvExam_master.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_name").ToString())
                    lvExam_master.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_name2").ToString())
                    lvExam_master.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_qty").ToString())
                    lvExam_master.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_score").ToString())
                    lvExam_master.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_pass_exam").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindHdPlace()
        Try
            Dim dt As New DataTable
            Place.code = ""
            dt = Place.Retreive()
            lvPlace.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvPlace.FullRowSelect = True
                lvPlace.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvPlace.Items.Add(dt.Rows(row).Item("pac_id").ToString())
                    lvPlace.Items(nindex).SubItems.Add(nindex + 1)
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_code").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_name").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_name2").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_place").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_address").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_contact").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_tel").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub pmethBindHdGuest()
        Try
            Dim dt As New DataTable
            Guest.code = ""
            dt = Guest.Retreive()
            lvGuest.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvGuest.FullRowSelect = True
                lvGuest.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvGuest.Items.Add(dt.Rows(row).Item("gue_id").ToString())
                    lvGuest.Items(nindex).SubItems.Add(nindex + 1)
                    lvGuest.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_code").ToString())
                    lvGuest.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_name").ToString())
                    lvGuest.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_name2").ToString())
                    If dt.Rows(row).Item("gue_inout").ToString = "I" Then
                        lvGuest.Items(nindex).SubItems.Add("ภายในองค์กร").ToString()
                    ElseIf dt.Rows(row).Item("gue_inout").ToString = "O" Then
                        lvGuest.Items(nindex).SubItems.Add("ภายนอกองค์กร").ToString()
                    Else
                        lvGuest.Items(nindex).SubItems.Add(String.Empty).ToString()
                    End If
                    lvGuest.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_wage").ToString())
                    lvGuest.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_tel").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

#End Region

#Region "Event"
    Private Sub TabPageSetup_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabPageSetup.SelectedIndexChanged
        binddata()
    End Sub
#Region "HD_Course"
    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourseRefresh.Click
        binddata()
    End Sub

    Private Sub lvCourse_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCourse.DoubleClick
        btnHdCourseEdit_Click(sender, e)
    End Sub

    Private Sub btnHdCourseEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourseEdit.Click
        Try
            Dim Form As New Setup_Course_POP
            Form.mode = GBMod.Edit
            Form.id = lvCourse.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdCourseAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourseAdd.Click
        Dim Form As New Setup_Course_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub btnHdCourseDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourseDelete.Click
        Try
            If lvCourse.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Course.id = lvCourse.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If

            If Course.Delete = False Then
                MessageBox.Show(Course.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Course.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Course_Type"
    Private Sub btnCourst_typeAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_typeAdd.Click
        Dim Form As New Setup_Course_Type_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvCourse_type_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCourse_type.DoubleClick
        btnCourst_typeEdit_Click(sender, e)
    End Sub


    Private Sub btnCourst_typeEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_typeEdit.Click
        Try
            Dim Form As New Setup_Course_Type_POP
            Form.mode = GBMod.Edit
            Form.id = lvCourse_type.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCourst_typeRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_typeRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnCourst_typeDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_typeDelete.Click
        Try
            If lvCourse_type.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Course_Type.id = lvCourse_type.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Course_Type.Delete = False Then
                MessageBox.Show(Course_Type.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Course_Type.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Course_Item"
    Private Sub btnCourst_itemAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_itemAdd.Click
        Dim Form As New Setup_Course_Item_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvCourse_item_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCourse_item.DoubleClick
        btnCourst_itemEdit_Click(sender, e)
    End Sub

    Private Sub btnCourst_itemEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_itemEdit.Click
        Try
            Dim Form As New Setup_Course_Item_POP
            Form.mode = GBMod.Edit
            Form.id = lvCourse_item.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCourst_itemRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_itemRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnCourst_itemDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_itemDelete.Click
        Try
            If lvCourse_item.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Course_Item.id = lvCourse_item.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Course_Item.Delete = False Then
                MessageBox.Show(Course_Item.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Course_Item.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Course_Content"
    Private Sub btnCourst_contentAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_contentAdd.Click
        Dim Form As New Setup_Course_Content_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()

    End Sub

    Private Sub lvCourse_content_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCourse_content.DoubleClick
        btnCourst_contentEdit_Click(sender, e)
    End Sub

    Private Sub btnCourst_contentEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_contentEdit.Click
        Try
            Dim Form As New Setup_Course_Content_POP
            Form.mode = GBMod.Edit
            Form.id = lvCourse_content.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCourst_contentRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_contentRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnCourst_contentDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnCourst_contentDelete.Click
        Try
            If lvCourse_content.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Course_Content.id = lvCourse_content.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Course_Content.Delete = False Then
                MessageBox.Show(Course_Content.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Course_Content.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Tool"
    Private Sub btnHdToolAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdToolAdd.Click
        Dim Form As New Setup_Tools_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvTool_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvTool.DoubleClick
        btnHdToolEdit_Click(sender, e)
    End Sub

    Private Sub btnHdToolEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdToolEdit.Click
        Try
            Dim Form As New Setup_Tools_POP
            Form.mode = GBMod.Edit
            Form.id = lvTool.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdToolRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdToolRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdToolDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdToolDelete.Click
        Try
            If lvTool.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Tool.id = lvTool.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Tool.Delete = False Then
                MessageBox.Show(Tool.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Tool.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Method"
    Private Sub btnHdMethodAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdMethodAdd.Click
        Dim Form As New Setup_Method_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvMethod_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvMethod.DoubleClick
        btnHdMethodEdit_Click(sender, e)
    End Sub

    Private Sub btnHdMethodEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdMethodEdit.Click
        Try
            Dim Form As New Setup_Method_POP
            Form.mode = GBMod.Edit
            Form.id = lvMethod.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdMethodRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdMethodRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdMethodDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdMethodDelete.Click
        Try
            If lvMethod.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Method.id = lvMethod.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Method.Delete = False Then
                MessageBox.Show(Method.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Method.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Score"
    Private Sub btnHdScoreAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdScoreAdd.Click
        Dim Form As New Setup_Score_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvScore_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvScore.DoubleClick
        btnHdScoreEdit_Click(sender, e)
    End Sub

    Private Sub btnHdScoreEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdScoreEdit.Click
        Try
            Dim Form As New Setup_Score_POP
            Form.mode = GBMod.Edit
            Form.id = lvScore.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdScoreRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdScoreRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdScoreDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdScoreDelete.Click
        Try
            If lvScore.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Score.id = lvScore.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Score.Delete = False Then
                MessageBox.Show(Score.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Score.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Assessment_Level"
    Private Sub btnHdAssessment_leveAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdAssessment_leveAdd.Click
        Dim Form As New Setup_Assessment_Level_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvAssessment_level_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvAssessment_level.DoubleClick
        btnHdAssessment_leveEdit_Click(sender, e)
    End Sub

    Private Sub btnHdAssessment_leveEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdAssessment_leveEdit.Click
        Try
            Dim Form As New Setup_Assessment_Level_POP
            Form.mode = GBMod.Edit
            Form.id = lvAssessment_level.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub btnHdAssessment_leveRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdAssessment_leveRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdAssessment_leveDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdAssessment_leveDelete.Click
        Try
            If lvAssessment_level.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Assessment_Level.id = lvAssessment_level.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Assessment_Level.Delete = False Then
                MessageBox.Show(Assessment_Level.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Assessment_Level.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Course_Kpis"
    Private Sub btnHdCourse_kpisAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourse_kpisAdd.Click
        Dim Form As New Setup_Course_KPIs_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvCourse_kpis_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCourse_kpis.DoubleClick
        btnHdCourse_kpisEdit_Click(sender, e)
    End Sub

    Private Sub btnHdCourse_kpisEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourse_kpisEdit.Click
        Try
            Dim Form As New Setup_Course_KPIs_POP
            Form.mode = GBMod.Edit
            Form.id = lvCourse_kpis.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdCourse_kpisRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourse_kpisRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdCourse_kpisDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCourse_kpisDelete.Click
        Try
            If lvCourse_kpis.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Course_Kpis.id = lvCourse_kpis.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Course_Kpis.Delete = False Then
                MessageBox.Show(Course_Kpis.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Course_Kpis.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Criteria_Kpis"

    Private Sub btnHdCriteria_kpisAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCriteria_kpisAdd.Click
        Dim Form As New Setup_Criteria_KPIs_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()

    End Sub

    Private Sub lvCriteria_kpis_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCriteria_kpis.DoubleClick
        btnHdCriteria_kpisEdit_Click(sender, e)
    End Sub

    Private Sub btnHdCriteria_kpisEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCriteria_kpisEdit.Click
        Try
            Dim Form As New Setup_Criteria_KPIs_POP
            Form.mode = GBMod.Edit
            Form.id = lvCriteria_kpis.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdCriteria_kpisRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCriteria_kpisRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdCriteria_kpisDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCriteria_kpisDelete.Click
        Try
            If lvCriteria_kpis.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Criteria_Kpis.id = lvCriteria_kpis.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Criteria_Kpis.Delete = False Then
                MessageBox.Show(Criteria_Kpis.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Criteria_Kpis.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Cost"
    Private Sub btnHdCostAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCostAdd.Click
        Dim Form As New Setup_Cost_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()

    End Sub

    Private Sub lvCost_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCost.DoubleClick
        btnHdCostEdit_Click(sender, e)
    End Sub

    Private Sub btnHdCostEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCostEdit.Click
        Try
            Dim Form As New Setup_Cost_POP
            Form.mode = GBMod.Edit
            Form.id = lvCost.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdCostRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCostRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdCostDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdCostDelete.Click
        Try
            If lvCost.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Cost.id = lvCost.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Cost.Delete = False Then
                MessageBox.Show(Cost.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Cost.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Budget"

    Private Sub btnHdBudgetAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdBudgetAdd.Click
        Dim Form As New Setup_Budget_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvBudget_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvBudget.DoubleClick
        btnHdBudgetEdit_Click(sender, e)
    End Sub

    Private Sub btnHdBudgetEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdBudgetEdit.Click
        Try
            Dim Form As New Setup_Budget_POP
            Form.mode = GBMod.Edit
            Form.id = lvBudget.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdBudgetRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdBudgetRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdBudgetDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdBudgetDelete.Click
        Try
            If lvBudget.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Budget.id = lvBudget.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Budget.Delete = False Then
                MessageBox.Show(Budget.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Budget.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Exam_Master"
    Private Sub btnHdExam_masterAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_masterAdd.Click
        Dim Form As New Setup_Exam_Master_POP
        Form.exmMode = GBMod.Add
        Form.exmId = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvExam_master_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvExam_master.DoubleClick
        btnHdExam_masterEdit_Click(sender, e)
    End Sub

    Private Sub btnHdExam_masterEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_masterEdit.Click
        Try
            Dim Form As New Setup_Exam_Master_POP
            Form.exmMode = GBMod.Edit
            Form.exmId = lvExam_master.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdExam_masterRefreash_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_masterRefreash.Click
        Me.binddata()
    End Sub

    Private Sub btnHdExam_masterDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_masterDelete.Click
        Try
            If lvExam_master.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Exam_Master.id = lvExam_master.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Exam_Master.Delete = False Then
                MessageBox.Show(Exam_Master.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Exam_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Place"
    Private Sub btnHdPlaceAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdPlaceAdd.Click
        Dim Form As New Setup_Place_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvPlace_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvPlace.DoubleClick
        btnHdPlaceEdit_Click(sender, e)
    End Sub

    Private Sub btnHdPlaceEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdPlaceEdit.Click
        Try
            Dim Form As New Setup_Place_POP
            Form.mode = GBMod.Edit
            Form.id = lvPlace.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdPlaceRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdPlaceRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdPlaceDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdPlaceDelete.Click
        Try
            If lvPlace.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Place.id = lvPlace.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Place.Delete = False Then
                MessageBox.Show(Place.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Place.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "HD_Guest"
    Private Sub btnHdGuestAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdGuestAdd.Click
        Dim Form As New Setup_Guest_POP
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub lvGuest_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvGuest.DoubleClick
        btnHdGuestEdit_Click(sender, e)
    End Sub

    Private Sub btnHdGuestEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdGuestEdit.Click
        Try
            Dim Form As New Setup_Guest_POP
            Form.mode = GBMod.Edit
            Form.id = lvGuest.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdGuestRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdGuestRefresh.Click
        Me.binddata()
    End Sub

    Private Sub btnHdGuestDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdGuestDelete.Click
        Try
            If lvGuest.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Guest.id = lvGuest.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            If Guest.Delete = False Then
                MessageBox.Show(Guest.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            MessageBox.Show(Guest.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region

#End Region


End Class