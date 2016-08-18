Public Class ADD_Edit_Course

    Dim poCourseForEdit As New Cls_Course_Master
    Public mode As String = String.Empty
    Public id As String = String.Empty
    Private Course_Struct As New Cls_HD_Course_Struct
    Private Coll_Course_Struct As New Collection
    Private Coll_Course_Exam As New Collection
    Public FormBrow As ADD_Edit_List_Course
    Public BranchId As String

#Region "Load"
    Public Sub ADD_Edit_Course_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub


    Public Sub pmethInit()
        pmethBindingData()
        pmethSetDataSource()
        pmethBlankVar()
        If mode = GBMod.Edit Then
            pmethGetdata()
        End If
        pmethsetprop()
    End Sub

    Private Sub pmethSetDataSource()
        Dim dtCoruseType As DataTable
        Dim CorustType As New Cls_HD_Course_Type
        dtCoruseType = CorustType.Retreive()
        Me.cbo_CourseType.DisplayMember = "cot_name"
        Me.cbo_CourseType.ValueMember = "cot_id"
        Me.cbo_CourseType.DataSource = dtCoruseType

        Dim dthd_Tool As DataTable
        Dim hd_Tool As New Cls_HD_Tool
        dthd_Tool = hd_Tool.Retreive()
        Me.cbo_hd_Tool.DisplayMember = "hdt_name"
        Me.cbo_hd_Tool.ValueMember = "hdt_id"
        Me.cbo_hd_Tool.DataSource = dthd_Tool

        Dim dtmethod As DataTable
        Dim hdmethod As New Cls_HD_Method
        dtmethod = hdmethod.Retreive()
        Me.cbo_method.DisplayMember = "hdm_name"
        Me.cbo_method.ValueMember = "hdm_id"
        Me.cbo_method.DataSource = dtmethod

        Dim dtasl As DataTable
        Dim hdasl As New Cls_HD_Method
        dtasl = hdasl.Retreive()
        Me.cbo_assessment_level.DisplayMember = "hdm_name"
        Me.cbo_assessment_level.ValueMember = "hdm_id"
        Me.cbo_assessment_level.DataSource = dtasl


        Dim StatusItem = New List(Of Course_Status)
        StatusItem.Add(New Course_Status("A", "อนุมัติ"))
        StatusItem.Add(New Course_Status("U", "ไม่อนุมัติ"))
        StatusItem.Add(New Course_Status("C", "ยกเลิก"))
        Me.cbo_Status.DisplayMember = "name"
        Me.cbo_Status.ValueMember = "id"
        Me.cbo_Status.DataSource = StatusItem

    End Sub

    Private Sub pmethBindingData()
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "code", True,DataSourceUpdateMode.OnPropertyChanged))
        Me.cbo_Status.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClsCourseMasterBindingSource, "status", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cbo_CourseType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClsCourseMasterBindingSource, "course_type", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_in_guest.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ClsCourseMasterBindingSource, "exp_Guest_In", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_out_guest.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ClsCourseMasterBindingSource, "exp_Guest_external", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd1", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd2", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd3", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd4", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd5", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd6", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd7", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd8", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd9", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtNeed_Hd10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "need_hd10", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_1", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_2", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_3", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_4", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_5", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_6", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_7", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_8", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_9", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Purpose10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "Purpose_10", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cbo_hd_Tool.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClsCourseMasterBindingSource, "tool", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cbo_method.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClsCourseMasterBindingSource, "method", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cbo_assessment_level.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClsCourseMasterBindingSource, "assessment_level", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_Before_Score.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "before_hd_score", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_before_hd_weight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "before_hd_weight", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_After_Score.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "after_hd_score", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txt_After_hd_weight.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "after_hd_weight", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_Owner_Hr_flag.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ClsCourseMasterBindingSource, "exp_owner_hr_flag", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.cb_Owner_Other_flag.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ClsCourseMasterBindingSource, "exp_owner_other_flag", True, DataSourceUpdateMode.OnPropertyChanged))
        'Me.txtInstitution1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsCourseMasterBindingSource, "institution", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.ClsCourseMasterBindingSource.DataSource = poCourseForEdit
    End Sub

    Private Sub pmethBlankVar()
        poCourseForEdit.id = ""
        poCourseForEdit.Clear()
        poCourseForEdit.code = "AutoRun"
        Me.txtCourseCode.Text = String.Empty
        Me.txtCourseName.Text = String.Empty
        poCourseForEdit.guest_external = "N"
        poCourseForEdit.guest_internal = "N"
        Me.txtNeed_Hd1.Text = String.Empty
        Me.txtNeed_Hd2.Text = String.Empty
        Me.txtNeed_Hd3.Text = String.Empty
        Me.txtNeed_Hd4.Text = String.Empty
        Me.txtNeed_Hd5.Text = String.Empty
        Me.txtNeed_Hd6.Text = String.Empty
        Me.txtNeed_Hd7.Text = String.Empty
        Me.txtNeed_Hd8.Text = String.Empty
        Me.txtNeed_Hd9.Text = String.Empty
        Me.txtNeed_Hd10.Text = String.Empty
        Me.txt_Purpose1.Text = String.Empty
        Me.txt_Purpose2.Text = String.Empty
        Me.txt_Purpose3.Text = String.Empty
        Me.txt_Purpose4.Text = String.Empty
        Me.txt_Purpose5.Text = String.Empty
        Me.txt_Purpose6.Text = String.Empty
        Me.txt_Purpose7.Text = String.Empty
        Me.txt_Purpose8.Text = String.Empty
        Me.txt_Purpose9.Text = String.Empty
        Me.txt_Purpose10.Text = String.Empty

        Me.Coll_Course_Struct.Clear()
        Me.lv_Course_struct.Items.Clear()
        Me.Coll_Course_Exam.Clear()
        Me.lv_Course_Exam.Items.Clear()
        Me.Coll_Course_Exam.Clear()

        txtCode.Focus()
    End Sub

    Private Sub pmethsetprop()
        txtCourseCode.Enabled = False
        txtCourseName.Enabled = False
        txt_In_Guest_Post1.Enabled = False
        txt_In_Guest_Post2.Enabled = False
        txt_In_Guest_Name1.Enabled = False
        txt_In_Guest_Name2.Enabled = False
        txt_Out_Guest_Post1.Enabled = False
        txt_Out_Guest_Post2.Enabled = False
        txt_Out_Guest_Name1.Enabled = False
        txt_Out_Guest_Name2.Enabled = False
        txtInstitution1.Enabled = False
        txtInstitution2.Enabled = False
    End Sub

    Private Sub pmethGetdata()
        poCourseForEdit.id = Me.id
        poCourseForEdit.getById(Me.id)
        Me.pmethSuccproc("COURSE")
        Me.pmethSuccproc("GUESTIN1")
        Me.pmethSuccproc("GUESTIN2")
        Me.pmethSuccproc("GUESTOUT1")
        Me.pmethSuccproc("GUESTOUT2")
        Me.pmethSuccproc("COURSE_KPIS1")
        Me.pmethSuccproc("COURSE_KPIS2")
        Me.pmethSuccproc("COURSE_KPIS3")
        Me.pmethSuccproc("COURSE_KPIS4")
        Me.pmethSuccproc("COURSE_KPIS5")
        Me.pmethSuccproc("SCORE1")
        Me.pmethSuccproc("SCORE2")
        Me.pmethSuccproc("SCORE3")
        Me.pmethSuccproc("SCORE4")
        Me.pmethSuccproc("SCORE5")
        Me.txt_hr_person_name.Text = poCourseForEdit.expowner_hr_empl.prefix_01 + " " + poCourseForEdit.expowner_hr_empl.name_01 + " " + poCourseForEdit.expowner_hr_empl.sname_01
        Me.txt_hr_person_code.Text = poCourseForEdit.expowner_hr_empl.empcd
        Me.txt_person_name.Text = poCourseForEdit.expowner_Oth.prefix_01 + " " + poCourseForEdit.expowner_Oth.name_01 + " " + poCourseForEdit.expowner_Oth.sname_01
        Me.txt_person_code.Text = poCourseForEdit.expowner_Oth.empcd
        Me.txtCompetencyCode.Text = Me.poCourseForEdit.expcompetency.code
        Me.txtCompetencyName.Text = Me.poCourseForEdit.expcompetency.name
        Me.txtCompetencyGroup.Text = Me.poCourseForEdit.expcompetency.groupname
        Me.CalAfter()
        Me.CalBefore()
        Me.pmethloadItem()
    End Sub

    Private Sub pmethloadItem()
        Coll_Course_Struct = poCourseForEdit.Item_Course_Struct
        bindingCourst_Struct()
        Coll_Course_Exam = poCourseForEdit.Item_Course_Exam
        bindingCourst_Exam()
    End Sub

#End Region

#Region "Event"
    Private Sub btnPopCourseName_Click(sender As System.Object, e As System.EventArgs) Handles btnPopCourseName.Click
        Dim ObjBrow As New Cls_HD_Course()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        FrmVfield.Text = "เลือกหลักสูตร"
        ObjBrow.code = ""
        dt = ObjBrow.Retreive()
        FrmVfield.lvData.Items.Clear()
        If dt.Rows.Count > 0 Then
            FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อ,ชื่อ 2,รายละเอียด")
            Frm_Select.autoResizeColumns(FrmVfield.lvData)
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                FrmVfield.lvData.Items.Add(dt.Rows(row).Item("cos_id").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_code").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_name").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_name2").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_desc").ToString())
                nindex = nindex + 1
            Next
            FrmVfield.ShowDialog()
            If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
                Me.poCourseForEdit.course = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                Me.pmethSuccproc("COURSE")
            End If
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPopInGuest1_Click(sender As System.Object, e As System.EventArgs) Handles btnPopInGuest1.Click
        pmethGetGuest("I", "GUESTIN1")
    End Sub

    Private Sub btnPopInGuest2_Click(sender As System.Object, e As System.EventArgs) Handles btnPopInGuest2.Click
        pmethGetGuest("I", "GUESTIN2")
    End Sub

    Private Sub btnPopOutGuest1_Click(sender As System.Object, e As System.EventArgs) Handles btnPopOutGuest1.Click
        pmethGetGuest("O", "GUESTOUT1")
    End Sub

    Private Sub btnPopOutGuest2_Click(sender As System.Object, e As System.EventArgs) Handles btnPopOutGuest2.Click
        pmethGetGuest("O", "GUESTOUT2")
    End Sub

    Private Sub pmethGetGuest(strInOut As String, strGuestNum As String)
        Dim ObjBrow As New Cls_HD_Guest()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        ObjBrow.code = ""
        FrmVfield.Text = "เลือกวิทยากร"
        ObjBrow.InOut = strInOut
        dt = ObjBrow.Retreive()
        FrmVfield.lvData.Items.Clear()
        If dt.Rows.Count > 0 Then
            FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อวิทยากร,ชื่อวิทยากร 2,ตำแหน่ง,สถาบัน")
            Frm_Select.autoResizeColumns(FrmVfield.lvData)
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                FrmVfield.lvData.Items.Add(dt.Rows(row).Item("gue_id").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_code").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_name").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_name2").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_position").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("gue_institution").ToString())
                nindex = nindex + 1
            Next
            FrmVfield.ShowDialog()
            If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
                Dim strMsg As String = String.Empty
                Select Case strGuestNum
                    Case "GUESTIN1"
                        If FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString() = Me.poCourseForEdit.guest_in_id2 Then
                            strMsg = "เลือกวิทยากรซ้ำ"
                        Else
                            Me.poCourseForEdit.guest_in_id1 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()

                        End If

                    Case "GUESTIN2"
                        If FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString() = Me.poCourseForEdit.guest_in_id1 Then
                            strMsg = "เลือกวิทยากรซ้ำ"
                        Else
                            Me.poCourseForEdit.guest_in_id2 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        End If

                    Case "GUESTOUT1"
                        If FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString() = Me.poCourseForEdit.guest_ext_id2 Then
                            strMsg = "เลือกวิทยากรซ้ำ"
                        Else
                            Me.poCourseForEdit.guest_ext_id1 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        End If
                    Case "GUESTOUT2"
                        If FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString() = Me.poCourseForEdit.guest_ext_id1 Then
                            strMsg = "เลือกวิทยากรซ้ำ"
                        Else
                            Me.poCourseForEdit.guest_ext_id2 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        End If
                End Select
                If strMsg <> String.Empty Then
                    MessageBox.Show(strMsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
                Me.pmethSuccproc(strGuestNum)
            End If
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cb_in_guest_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb_in_guest.CheckedChanged
        If cb_in_guest.Checked = True Then
            poCourseForEdit.guest_internal = "Y"
            Me.btnPopInGuest1.Enabled = True
            Me.btnPopInGuest2.Enabled = True
        Else
            poCourseForEdit.guest_internal = "N"
            Me.btnPopInGuest1.Enabled = False
            Me.btnPopInGuest2.Enabled = False
            txt_In_Guest_Post1.Text = ""
            txt_In_Guest_Post2.Text = ""
            txt_In_Guest_Name1.Text = ""
            txt_In_Guest_Name2.Text = ""
            Me.poCourseForEdit.guest_in_id1 = ""
            Me.poCourseForEdit.guest_in_id2 = ""
        End If
    End Sub

    Private Sub cb_out_guest_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb_out_guest.CheckedChanged
        If cb_out_guest.Checked = True Then
            poCourseForEdit.guest_external = "Y"
            Me.btnPopOutGuest1.Enabled = True
            Me.btnPopOutGuest2.Enabled = True
        Else
            poCourseForEdit.guest_external = "N"
            Me.btnPopOutGuest1.Enabled = False
            Me.btnPopOutGuest2.Enabled = False
            txt_Out_Guest_Post1.Text = ""
            txt_Out_Guest_Post2.Text = ""
            txt_Out_Guest_Name1.Text = ""
            txt_Out_Guest_Name2.Text = ""
            txtInstitution1.Text = ""
            txtInstitution2.Text = ""
            Me.poCourseForEdit.guest_ext_id1 = ""
            Me.poCourseForEdit.guest_ext_id2 = ""
        End If
    End Sub


    Private Sub btn_Pop_Course_Kpis1_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Course_Kpis1.Click
        pmethGetKpi("COURSE_KPIS1")
    End Sub

    Private Sub btn_Pop_Course_Kpis2_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Course_Kpis2.Click
        pmethGetKpi("COURSE_KPIS2")
    End Sub

    Private Sub btn_Pop_Course_Kpis3_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Course_Kpis3.Click
        pmethGetKpi("COURSE_KPIS3")
    End Sub

    Private Sub btn_Pop_Course_Kpis4_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Course_Kpis4.Click
        pmethGetKpi("COURSE_KPIS4")
    End Sub

    Private Sub btn_Pop_Course_Kpis5_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Course_Kpis5.Click
        pmethGetKpi("COURSE_KPIS5")
    End Sub

    Private Sub pmethGetKpi(kpiSet As String)
        Dim ObjBrow As New Cls_HD_Course_Kpis()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        FrmVfield.Text = "เลือกตัวชี้วัดความสำเร็จหลักสูตร"
        ObjBrow.code = ""
        dt = ObjBrow.Retreive()
        FrmVfield.lvData.Items.Clear()
        If dt.Rows.Count > 0 Then
            FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อ,ชื่อ 2,รายละเอียด")
            Frm_Select.autoResizeColumns(FrmVfield.lvData)
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                FrmVfield.lvData.Items.Add(dt.Rows(row).Item("ckp_id").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_code").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_name").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_name2").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("ckp_desc").ToString())
                nindex = nindex + 1
            Next
            FrmVfield.ShowDialog()
            If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
                Select Case kpiSet
                    Case "COURSE_KPIS1"
                        Me.poCourseForEdit.course_kpis1 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "COURSE_KPIS2"
                        Me.poCourseForEdit.course_kpis2 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "COURSE_KPIS3"
                        Me.poCourseForEdit.course_kpis3 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "COURSE_KPIS4"
                        Me.poCourseForEdit.course_kpis4 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "COURSE_KPIS5"
                        Me.poCourseForEdit.course_kpis5 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                End Select
                Me.pmethSuccproc(kpiSet)
            End If
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_Pop_Score1_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Score1.Click
        pmethGetScore("SCORE1")
    End Sub

    Private Sub btn_Pop_Score3_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Score3.Click
        pmethGetScore("SCORE2")
    End Sub

    Private Sub btn_Pop_Score4_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Score4.Click
        pmethGetScore("SCORE3")
    End Sub

    Private Sub btn_Pop_Score5_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Score5.Click
        pmethGetScore("SCORE4")
    End Sub

    Private Sub btn_Pop_Score6_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_Score6.Click
        pmethGetScore("SCORE5")
    End Sub


    Private Sub pmethGetScore(StrScoreSet As String)
        Dim ObjBrow As New Cls_HD_Score()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        FrmVfield.Text = "เลือกเกณฑ์ประเมิน"
        ObjBrow.code = ""
        dt = ObjBrow.Retreive()
        FrmVfield.lvData.Items.Clear()
        If dt.Rows.Count > 0 Then
            FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อ,ชื่อ 2,รายละเอียด")
            Frm_Select.autoResizeColumns(FrmVfield.lvData)
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                FrmVfield.lvData.Items.Add(dt.Rows(row).Item("hds_id").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_code").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_name").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_name2").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("hds_desc").ToString())
                nindex = nindex + 1
            Next
            FrmVfield.ShowDialog()
            If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
                Select Case StrScoreSet
                    Case "SCORE1"
                        Me.poCourseForEdit.score1 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "SCORE2"
                        Me.poCourseForEdit.score2 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "SCORE3"
                        Me.poCourseForEdit.score3 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "SCORE4"
                        Me.poCourseForEdit.score4 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                    Case "SCORE5"
                        Me.poCourseForEdit.score5 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                End Select
                Me.pmethSuccproc(StrScoreSet)
            End If
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPopExam_Click(sender As System.Object, e As System.EventArgs) Handles btnPopExam.Click
        Dim ObjBrow As New Cls_HD_Exam_Master()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        FrmVfield.Text = "เลือกแบบทดสอบ"
        ObjBrow.code = ""
        dt = ObjBrow.Retreive()
        FrmVfield.lvData.Items.Clear()
        If dt.Rows.Count > 0 Then
            FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อ,ชื่อ 2,จำนวน")
            Frm_Select.autoResizeColumns(FrmVfield.lvData)
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                FrmVfield.lvData.Items.Add(dt.Rows(row).Item("exm_id").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_code").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_name").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("exm_name2").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(cNull(dt.Rows(row).Item("exm_qty"), "N"))
                nindex = nindex + 1
            Next
            FrmVfield.ShowDialog()
            If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
                Dim Obj As New Cls_HD_Course_Exam()
                Obj.exam_master = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                Coll_Course_Exam.Add(Obj)
                bindingCourst_Exam()

            End If
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub bindingCourst_Exam()
        Dim i As Integer = 0
        Dim j As Integer = 0
        lv_Course_Exam.Items.Clear()
        lv_Course_Exam.FullRowSelect = True
        lv_Course_Exam.ShowItemToolTips = True
        For Each cs As Object In Coll_Course_Exam
            i = i + 1
            Dim ObjCs = CType(cs, Cls_HD_Course_Exam)
            If ObjCs.exam_master <> String.Empty Then
                j = j + 1
                Dim Itemm As New ListViewItem(ObjCs.id)
                Itemm.SubItems.Add(i)
                Itemm.SubItems.Add(j.ToString)
                Itemm.SubItems.Add(ObjCs.expHD_Course_Item.code)
                Itemm.SubItems.Add(ObjCs.expHD_Course_Item.name)
                Itemm.SubItems.Add(ObjCs.expHD_Course_Item.qty)
                lv_Course_Exam.Items.Add(Itemm)
            End If
        Next
    End Sub

#End Region

    Private Sub pmethSuccproc(StrSucc As String)
        Select Case StrSucc
            Case "COURSE"
                Me.txtCourseCode.Text = Me.poCourseForEdit.expCourse.code
                Me.txtCourseName.Text = Me.poCourseForEdit.expCourse.name
            Case "GUESTIN1"
                txt_In_Guest_Name1.Text = Me.poCourseForEdit.expguest_in_id1.name
                txt_In_Guest_Post1.Text = Me.poCourseForEdit.expguest_in_id1.position
            Case "GUESTIN2"
                txt_In_Guest_Name2.Text = Me.poCourseForEdit.expguest_in_id2.name
                txt_In_Guest_Post2.Text = Me.poCourseForEdit.expguest_in_id2.position
            Case "GUESTOUT1"
                txt_Out_Guest_Name1.Text = Me.poCourseForEdit.expguest_ext_id1.name
                txt_Out_Guest_Post1.Text = Me.poCourseForEdit.expguest_ext_id1.position
                txtInstitution1.Text = Me.poCourseForEdit.expguest_ext_id1.institution
            Case "GUESTOUT2"
                txt_Out_Guest_Name2.Text = Me.poCourseForEdit.expguest_ext_id2.name
                txt_Out_Guest_Post2.Text = Me.poCourseForEdit.expguest_ext_id2.position
                txtInstitution2.Text = Me.poCourseForEdit.expguest_ext_id2.institution
            Case "COURSE_KPIS1"
                Me.txt_Course_Kpis1.Text = Me.poCourseForEdit.expcourse_kpis1.name
            Case "COURSE_KPIS2"
                Me.txt_Course_Kpis2.Text = Me.poCourseForEdit.expcourse_kpis2.name
            Case "COURSE_KPIS3"
                Me.txt_Course_Kpis3.Text = Me.poCourseForEdit.expcourse_kpis3.name
            Case "COURSE_KPIS4"
                Me.txt_Course_Kpis4.Text = Me.poCourseForEdit.expcourse_kpis4.name
            Case "COURSE_KPIS5"
                Me.txt_Course_Kpis5.Text = Me.poCourseForEdit.expcourse_kpis5.name
            Case "SCORE1"
                Me.txt_Score1.Text = Me.poCourseForEdit.expscore1.name
            Case "SCORE2"
                Me.txt_Score2.Text = Me.poCourseForEdit.expscore2.name
            Case "SCORE3"
                Me.txt_Score3.Text = Me.poCourseForEdit.expscore3.name
            Case "SCORE4"
                Me.txt_Score4.Text = Me.poCourseForEdit.expscore4.name
            Case "SCORE5"
                Me.txt_Score5.Text = Me.poCourseForEdit.expscore5.name
            Case Else
        End Select
    End Sub

    Private Sub btnCourse_Str_Add_Click(sender As System.Object, e As System.EventArgs) Handles btnCourse_Str_Add.Click
        Dim FrmCourse_ContentPop As New Course_Content_POP()
        FrmCourse_ContentPop.ContentDevMod = GBMod.Add
        If FrmCourse_ContentPop.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FrmCourse_ContentPop.PropCourse_Struce.Corp_id = GBCorp
            Coll_Course_Struct.Add(FrmCourse_ContentPop.PropCourse_Struce)
            bindingCourst_Struct()
        End If
    End Sub

    Private Sub btnCoureStructDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnCoureStructDelete.Click
        Try
            If lv_Course_struct.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim Obj As Object = Coll_Course_Struct(Convert.ToInt16(lv_Course_struct.SelectedItems.Item(0).SubItems(1).Text))
            Dim ObjCs = CType(Obj, Cls_HD_Course_Struct)
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            ObjCs.course_item = ""
        Catch ex As Exception
            MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.bindingCourst_Struct()
    End Sub


    Private Sub btnCoureStructEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnCoureStructEdit.Click
        Try
            If lv_Course_struct.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim FrmCourse_ContentPop As New Course_Content_POP()
            FrmCourse_ContentPop.ContentDevMod = GBMod.Edit

            Dim Obj As Object = Coll_Course_Struct(Convert.ToInt16(lv_Course_struct.SelectedItems.Item(0).SubItems(1).Text))
            FrmCourse_ContentPop.PropCourse_Struce = CType(Obj, Cls_HD_Course_Struct)

            FrmCourse_ContentPop.txt_course_item_code.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Item.code.ToString()
            FrmCourse_ContentPop.txt_course_item_name.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Item.name.ToString()
            FrmCourse_ContentPop.txt_course_content1.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content1.name.ToString()
            FrmCourse_ContentPop.txt_course_content2.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content2.name.ToString()
            FrmCourse_ContentPop.txt_course_content3.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content3.name.ToString()
            FrmCourse_ContentPop.txt_course_content4.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content4.name.ToString()
            FrmCourse_ContentPop.txt_course_content5.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content5.name.ToString()
            FrmCourse_ContentPop.txt_course_content6.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content6.name.ToString()
            FrmCourse_ContentPop.txt_course_content7.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content7.name.ToString()
            FrmCourse_ContentPop.txt_course_content8.Text = FrmCourse_ContentPop.PropCourse_Struce.expHD_Course_Content8.name.ToString()
            FrmCourse_ContentPop.txt_cst_main_hour.Text = FrmCourse_ContentPop.PropCourse_Struce.main_hour.ToString()

            If FrmCourse_ContentPop.ShowDialog() = Windows.Forms.DialogResult.OK Then
                bindingCourst_Struct()
            End If

        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        
    End Sub

    Private Sub lv_Course_struct_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lv_Course_struct.DoubleClick
        Call btnCoureStructEdit_Click(sender, e)
    End Sub

    Private Sub bindingCourst_Struct()
        Dim i As Integer = 0
        Dim j As Integer = 0
        lv_Course_struct.Items.Clear()
        lv_Course_struct.FullRowSelect = True
        lv_Course_struct.ShowItemToolTips = True
        For Each cs As Object In Coll_Course_Struct
            i = i + 1
            Dim ObjCs = CType(cs, Cls_HD_Course_Struct)
            If String.Empty <> cs.course_item Then
                j = j + 1
                Dim Itemm As New ListViewItem(ObjCs.id)
                Itemm.SubItems.Add(i)
                Itemm.SubItems.Add(j.ToString)
                Itemm.SubItems.Add(ObjCs.expHD_Course_Item.code)
                Itemm.SubItems.Add(ObjCs.expHD_Course_Item.name)
                Itemm.SubItems.Add(ObjCs.main_hour)
                lv_Course_struct.Items.Add(Itemm)
            End If

        Next
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClearData_Click(sender As System.Object, e As System.EventArgs) Handles btnClearData.Click
        Me.pmethBlankVar()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SqlDB As New Cls_SqlDB
        Dim bSucc = True
        Dim StrErrmsg As String = String.Empty
        Dim Errmsg As String = String.Empty
        Try
            If ValidateData() = True Then
                poCourseForEdit.Corp_id = Config.GBCorp
                poCourseForEdit.Branch_id = BranchId
                SqlDB.BeginTrans()
                'If poCourseForEdit.code <> String.Empty And poCourseForEdit.CheckDupCode = False Then
                '    MessageBox.Show("พบรหัส :" & poCourseForEdit.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    Exit Sub
                'End If
                If mode = GBMod.Add Then
                    poCourseForEdit.code = FunctionClass.GetDocumentNo("transaction_Course", {}, "", GBCorp, _
                                             GBAppName, GBApp_Path, Errmsg)

                    If poCourseForEdit.Add(SqlDB) = False Then
                        StrErrmsg = poCourseForEdit.message
                    End If
                ElseIf mode = GBMod.Edit Then
                    bSucc = Me.poCourseForEdit.Update(SqlDB)
                End If

                If bSucc Then
                    bSucc = Me.pmethUpdateItemCourseStruct(SqlDB, StrErrmsg)
                End If

                If bSucc Then
                    bSucc = Me.pmethUpdateItemCourseExam(SqlDB, StrErrmsg)
                End If

                If bSucc = True Then
                    SqlDB.CommitTrans()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'pmethBlankVar()
                    'If mode = GBMod.Edit Then
                    '    Close()
                    'Else
                    '    Me.FormBrow.binddata()
                    'End If
                    If poCourseForEdit.id <> "" Then
                        Me.mode = GBMod.Edit
                        Me.id = poCourseForEdit.id
                        pmethGetdata()
                        pmethsetprop()
                        Me.ClsCourseMasterBindingSource.DataSource = poCourseForEdit
                    End If

                Else
                    MessageBox.Show(StrErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SqlDB.RollbackTrans()
                End If
            End If

        Catch ex As Exception
            SqlDB.RollbackTrans()
        End Try

    End Sub

    Private Function pmethUpdateItemCourseStruct(SqlDB As Cls_SqlDB, ByRef ErrorMas As String) As Boolean
        Dim bSucc As Boolean
        bSucc = True
        Dim i As Integer
        For Each cs As Object In Coll_Course_Struct
            i = i + 1
            Dim ObjCs = CType(cs, Cls_HD_Course_Struct)
            If ObjCs.course_item <> String.Empty Then
                ObjCs.Corp_id = GBCorp
                ObjCs.course_master = poCourseForEdit.id
                ObjCs.Branch_id = Me.BranchId
                ObjCs.seq = i
                If ObjCs.id <> String.Empty Then
                    bSucc = ObjCs.Save(SqlDB)
                Else
                    bSucc = ObjCs.Save(SqlDB)
                End If
                If bSucc = False Then
                    ErrorMas = ObjCs.message
                    Return bSucc
                End If
            Else
                If ObjCs.id <> String.Empty Then
                    ObjCs.Delete(SqlDB)
                End If
            End If
        Next
        Return bSucc
    End Function

    Private Function pmethUpdateItemCourseExam(SqlDB As Cls_SqlDB, ByRef ErrorMas As String) As Boolean
        Dim bSucc As Boolean
        bSucc = True
        Try
            Dim i As Integer
            For Each cs As Object In Coll_Course_Exam
                i = i + 1
                Dim ObjCs = CType(cs, Cls_HD_Course_Exam)
                If ObjCs.exam_master <> String.Empty Then
                    ObjCs.Corp_id = GBCorp
                    ObjCs.course_master = poCourseForEdit.id
                    ObjCs.Branch_id = Me.BranchId
                    ObjCs.seq = i
                    bSucc = ObjCs.Save(SqlDB)
                    If bSucc = False Then
                        ErrorMas = ObjCs.message
                        Return bSucc
                    End If
                Else
                    If ObjCs.id <> String.Empty Then
                        ObjCs.Delete(SqlDB)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
        Return bSucc
    End Function

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If poCourseForEdit.course = String.Empty Then
            strErrmsg = "กรุณาระบุหลักสูตร"
            bSucc = False
        ElseIf poCourseForEdit.course_type = String.Empty Then
            strErrmsg = "กรุณาระบุประเภทหลักสูตร"
            bSucc = False
        ElseIf poCourseForEdit.status = String.Empty Then
            strErrmsg = "กรุณาระบุสถานะ"
            bSucc = False
        ElseIf (poCourseForEdit.guest_in_id1 = String.Empty) And (poCourseForEdit.guest_in_id2 = String.Empty) And (poCourseForEdit.guest_ext_id1 = String.Empty) And (poCourseForEdit.guest_ext_id2 = String.Empty) Then
            strErrmsg = "กรุณาระบุวิทยากร"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return bSucc
    End Function




    Private Sub btnDeleteExam_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteExam.Click
        Dim Obj As Object = Coll_Course_Exam(Convert.ToInt16(lv_Course_Exam.SelectedItems.Item(0).SubItems(1).Text))
        Dim ObjCs = CType(Obj, Cls_HD_Course_Exam)
        ObjCs.exam_master = ""
        Me.bindingCourst_Exam()

    End Sub


    Private Sub btn_Pop_owner_hr_empl_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_owner_hr_empl.Click
        Dim frm As New HD_POP_Person
        'frm.action = "add"
        frm.Name = "WF_POP_Person_V2"
        frm.branch = "All"
        frm.person_start = ""
        frm.Fname = ""
        frm.Sname = ""
        frm.position_code = ""
        frm.position_name = ""
        frm.where_con = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            poCourseForEdit.owner_hr_empl = frm.rtn_person_id
            Me.txt_hr_person_code.Text = frm.rtn_person_code
            Me.txt_hr_person_name.Text = frm.rtn_personname
        End If
    End Sub

    Private Sub btn_Pop_owner_Click(sender As System.Object, e As System.EventArgs) Handles btn_Pop_owner.Click
        Dim frm As New HD_POP_Person
        'frm.action = "add"
        frm.Name = "WF_POP_Person_V2"
        frm.branch = "All"
        frm.person_start = ""
        frm.Fname = ""
        frm.Sname = ""
        frm.position_code = ""
        frm.position_name = ""
        frm.where_con = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            poCourseForEdit.owner_other = frm.rtn_person_id
            Me.txt_person_code.Text = frm.rtn_person_code
            Me.txt_person_name.Text = frm.rtn_personname
        End If
    End Sub

    Private Sub cb_Owner_Hr_flag_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb_Owner_Hr_flag.CheckedChanged
        If cb_Owner_Hr_flag.Checked = True Then
            poCourseForEdit.owner_hr_flag = "Y"
            btn_Pop_owner_hr_empl.Enabled = True
            'Me.txt_hr_person_code.Text = ""
            'Me.txt_hr_person_name.Text = ""
            'Me.poCourseForEdit.owner_hr_empl = ""
        Else
            poCourseForEdit.owner_hr_flag = "N"
            btn_Pop_owner_hr_empl.Enabled = False
            Me.txt_hr_person_code.Text = ""
            Me.txt_hr_person_name.Text = ""
            Me.poCourseForEdit.owner_hr_empl = ""
        End If
    End Sub

    Private Sub cb_Owner_Other_flag_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cb_Owner_Other_flag.CheckedChanged
        If cb_Owner_Other_flag.Checked = True Then
            poCourseForEdit.owner_other_flag = "Y"
            btn_Pop_owner.Enabled = True
            'Me.txt_person_code.Text = ""
            'Me.txt_person_name.Text = ""
            'Me.poCourseForEdit.owner_other = ""
        Else
            poCourseForEdit.owner_other_flag = "N"
            btn_Pop_owner.Enabled = False
            Me.txt_person_code.Text = ""
            Me.txt_person_name.Text = ""
            Me.poCourseForEdit.owner_other = ""
        End If
    End Sub

    Private Sub btnPopCompetency_Click(sender As System.Object, e As System.EventArgs) Handles btnPopCompetency.Click
        'Dim ObjBrow As New Cls_Competency()
        'Dim dt As DataTable
        'Dim FrmVfield As New Frm_Select
        'ObjBrow.code = ""
        'dt = ObjBrow.Retreive()
        'FrmVfield.lvData.Items.Clear()
        'If dt.Rows.Count > 0 Then
        '    FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อ,กลุ่ม")
        '    Dim nindex As Integer = 0
        '    For row As Integer = 0 To dt.Rows.Count - 1
        '        FrmVfield.lvData.Items.Add(dt.Rows(row).Item("id").ToString())
        '        FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
        '        FrmVfield.lvData.Items(nindex).SubItems.Add(cNull(dt.Rows(row).Item("com_code").ToString(), "S"))
        '        FrmVfield.lvData.Items(nindex).SubItems.Add(cNull(dt.Rows(row).Item("name_01").ToString(), "S"))
        '        FrmVfield.lvData.Items(nindex).SubItems.Add(cNull(dt.Rows(row).Item("groupname").ToString(), "S"))
        '        nindex = nindex + 1
        '    Next
        '    Frm_Select.autoResizeColumns(FrmVfield.lvData)
        '    FrmVfield.ShowDialog()
        '    If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
        '        Me.poCourseForEdit.competency = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
        '        Me.txtCompetencyCode.Text = Me.poCourseForEdit.expcompetency.code
        '        Me.txtCompetencyName.Text = Me.poCourseForEdit.expcompetency.name
        '        Me.txtCompetencyGroup.Text = Me.poCourseForEdit.expcompetency.groupname
        '    End If
        'Else
        '    MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        Dim FormObj As New Select_Competency()
        FormObj.ShowDialog()
        If FormObj.DialogResult = Windows.Forms.DialogResult.OK And FormObj.ret_id <> String.Empty Then
            Me.poCourseForEdit.competency = FormObj.ret_id
            Me.txtCompetencyCode.Text = Me.poCourseForEdit.expcompetency.code
            Me.txtCompetencyName.Text = Me.poCourseForEdit.expcompetency.name
            Me.txtCompetencyGroup.Text = Me.poCourseForEdit.expcompetency.groupname
        End If
    End Sub

    Private Sub txt_Before_Score_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Before_Score.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txt_Before_Score.Text
            Dim selectionStart = Me.txt_Before_Score.SelectionStart
            Dim selectionLength = Me.txt_Before_Score.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                'Reject an integer that is longer than 5 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3) Then
                'Reject a real number 
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txt_before_hd_weight_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_before_hd_weight.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txt_before_hd_weight.Text
            Dim selectionStart = Me.txt_before_hd_weight.SelectionStart
            Dim selectionLength = Me.txt_before_hd_weight.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                'Reject an integer that is longer than 5 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3) Then
                'Reject a real number 
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True

        End If
    End Sub

    Private Sub txt_After_Score_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_After_Score.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txt_After_Score.Text
            Dim selectionStart = Me.txt_After_Score.SelectionStart
            Dim selectionLength = Me.txt_After_Score.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                'Reject an integer that is longer than 5 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3) Then
                'Reject a real number 
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txt_After_hd_weight_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_After_hd_weight.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txt_After_hd_weight.Text
            Dim selectionStart = Me.txt_After_hd_weight.SelectionStart
            Dim selectionLength = Me.txt_After_hd_weight.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                'Reject an integer that is longer than 5 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3) Then
                'Reject a real number 
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Before_Score_LostFocus(sender As Object, e As System.EventArgs) Handles txt_Before_Score.LostFocus
        Me.CalBefore()
    End Sub

    Private Sub txt_before_hd_weight_LostFocus(sender As Object, e As System.EventArgs) Handles txt_before_hd_weight.LostFocus
        Me.CalBefore()
    End Sub

    Private Sub txt_After_Score_LostFocus(sender As Object, e As System.EventArgs) Handles txt_After_Score.LostFocus
        Me.CalAfter()
    End Sub

    Private Sub txt_After_hd_weight_LostFocus(sender As Object, e As System.EventArgs) Handles txt_After_hd_weight.LostFocus
        Me.CalAfter()
    End Sub

    Private Sub CalBefore()
        Try
            txt_Sum_Befor.Text = (poCourseForEdit.before_hd_score * poCourseForEdit.before_hd_weight).ToString("N")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CalAfter()
        Try
            txt_Sum_After.Text = (poCourseForEdit.after_hd_score * poCourseForEdit.after_hd_weight).ToString("N")
        Catch ex As Exception
        End Try
    End Sub

End Class

Public Class Course_Status

    Public Sub New(ByVal vId As String, ByVal vname As String)
        _id = vId
        _name = vname
    End Sub

    Private _id As String
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property



End Class