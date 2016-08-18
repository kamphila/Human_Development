Public Class Setup_Exam_Master_POP
    Public exmMode As String = GBMod.View
    Public exdMode As String = GBMod.View
    Public exmId As String = String.Empty
    Private var_question_type As String = String.Empty
    Private var_obj As String = String.Empty
    Private var_exd_no_value As Integer
    Private dt_exd As New DataTable
    Private Exam_Master As New Cls_HD_Exam_Master
    Public FormBrow As HD_System_Setup
    Private pnVarTotScoure As Integer = 0

    Private Sub Setup_Exam_Master_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dt_exd.Columns.AddRange(New DataColumn() {New DataColumn With {.ColumnName = "exd_corp_id", .Caption = "corp_id", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_id", .Caption = "exd_id", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exm_id", .Caption = "exm_id", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_no", .Caption = "exd_no", .DataType = GetType(Int32), .Unique = True} _
           , New DataColumn With {.ColumnName = "exd_question", .Caption = "exd_question", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_question2", .Caption = "exd_question2", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_question_type", .Caption = "exd_question_type", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_obj1", .Caption = "exd_answer_obj1", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_obj2", .Caption = "exd_answer_obj2", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_obj3", .Caption = "exd_answer_obj3", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_obj4", .Caption = "exd_answer_obj4", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_obj", .Caption = "exd_answer_obj", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_sub1", .Caption = "exd_answer_sub1", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_sub2", .Caption = "exd_answer_sub2", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_sub3", .Caption = "exd_answer_sub3", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_answer_sub4", .Caption = "exd_answer_sub4", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_score", .Caption = "exd_score", .DataType = GetType(Int32)} _
           , New DataColumn With {.ColumnName = "exd_status", .Caption = "exd_status", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_create_by", .Caption = "exd_create_by", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_create_date", .Caption = "exd_create_date", .DataType = GetType(DateTime)} _
           , New DataColumn With {.ColumnName = "exd_edit_by", .Caption = "exd_edit_by", .DataType = GetType(String)} _
           , New DataColumn With {.ColumnName = "exd_edit_date", .Caption = "exd_edit_date", .DataType = GetType(DateTime)} _
           , New DataColumn With {.ColumnName = "exd_datetime", .Caption = "exd_datetime", .DataType = GetType(DateTime)}})
        dt_exd.PrimaryKey = New DataColumn() {dt_exd.Columns("exd_no")}
        pmethBlankVarExam_Master()
        pmethBlankVarExam_Detail()
        If exmMode = GBMod.Edit Then
            pmethGetdataExam_Master()
            pmethGetdataExam_Detail()
        End If
    End Sub

    Private Sub pmethBlankVarExam_Master()
        Exam_Master.empty(exmMode)
        txtExmcode.Text = String.Empty
        txtExmname.Text = String.Empty
        txtExmname2.Text = String.Empty
        txtExmqty.Text = String.Empty
        txtExmscore.Text = "0"
        txtExmpass_exam.Text = "0"
        txtExdscore.Text = "0"
        txtExmqty.Text = "0"
        Me.pnVarTotScoure = 0
        txtExmcode.Focus()
    End Sub

    Private Sub pmethBlankVarExam_Detail()
        Exam_Master.empty()
        txtExdno.Text = String.Empty
        txtExdquestion.Text = String.Empty
        txtExdquestion2.Text = String.Empty
        rbtExdquestion_type1.Checked = False
        txtExd_answer_sub1.Text = String.Empty
        txtExd_answer_sub2.Text = String.Empty
        txtExd_answer_sub3.Text = String.Empty
        txtExd_answer_sub4.Text = String.Empty
        rbtExdquestion_type2.Checked = True
        rbtExdanswer_obj1.Checked = False
        rbtExdanswer_obj2.Checked = False
        rbtExdanswer_obj3.Checked = False
        rbtExdanswer_obj4.Checked = False
        txtExd_answer_obj1.Text = String.Empty
        txtExd_answer_obj2.Text = String.Empty
        txtExd_answer_obj3.Text = String.Empty
        txtExd_answer_obj4.Text = String.Empty
        txtExdscore.Text = "0"
        var_question_type = String.Empty
        var_obj = String.Empty
    End Sub

    Private Sub pmethGetdataExam_Master()
        If String.IsNullOrEmpty(exmId) = False Then
            Exam_Master.getById(exmId)
            txtExmcode.Text = Exam_Master.code
            txtExmname.Text = Exam_Master.name
            txtExmname2.Text = Exam_Master.name2
            txtExmqty.Text = Exam_Master.qty
            txtExmscore.Text = Exam_Master.score
            txtExmpass_exam.Text = Exam_Master.pass_exam
        End If
    End Sub

    Private Sub pmethGetdataExam_Detail()
        dt_exd = Exam_Master.CheckExamDetailData(exmId)
        pmethBindHdExamDetail()
    End Sub


    Private Function ValidateDataExam_Master() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If txtExmcode.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่รหัส"
            bSucc = False
        ElseIf txtExmname.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่ชื่อภาษา 1"
            bSucc = False
        ElseIf txtExmqty.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่จำนวนข้อสอบ"
            bSucc = False
        ElseIf txtExmscore.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่คะแนนเต็ม"
        ElseIf txtExmpass_exam.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่คะแนนผ่านเกณฑ์"
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Function ValidateDataExam_Detail() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If txtExdno.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่ข้อที่"
            bSucc = False
        ElseIf txtExdquestion.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่คำถามภาษา 1"
            bSucc = False
        ElseIf (rbtExdquestion_type1.Checked = False) And (rbtExdquestion_type2.Checked) = False Then
            strErrmsg = "กรุณาใส่ประเภทคำถาม"
            bSucc = False 
        ElseIf (Me.pnVarTotScoure + Convert.ToInt32(Me.txtExdscore.Text) > Convert.ToInt32(Me.txtExmscore.Text)) Then
            strErrmsg = "คะแนนรวมมากกว่าคะแนนทั้งหมดไม่ได้"
            bSucc = False
        ElseIf ((rbtExdquestion_type1.Checked = True) And (txtExd_answer_sub1.Text.ToString() = String.Empty)) Then
            strErrmsg = "กรุณาใส่คำตอบอัตนัย"
            bSucc = False
        ElseIf ((rbtExdquestion_type2.Checked = True) And _
               (((txtExd_answer_obj1.Text.ToString() = String.Empty) Or _
                (txtExd_answer_obj2.Text.ToString() = String.Empty) Or _
                (txtExd_answer_obj3.Text.ToString() = String.Empty) Or _
                (txtExd_answer_obj4.Text.ToString() = String.Empty)) Or _
               ((rbtExdanswer_obj1.Checked = False) And (rbtExdanswer_obj2.Checked = False) And _
                (rbtExdanswer_obj3.Checked = False) And (rbtExdanswer_obj4.Checked = False)))) Then
            strErrmsg = "กรุณาใส่ตัวเลือกอัตนัย ข้อ ก-ง และคำตอบอัตนัย ให้ครบ."
            bSucc = False
        ElseIf IsNumeric(txtExdscore.Text) = False Then
            strErrmsg = "กรุณาใส่คะแนนให้ถูกต้อง"
            bSucc = False
        ElseIf ((IsNumeric(txtExdscore.Text) = True) And (Convert.ToInt32(txtExdscore.Text) <= 0)) Then
            strErrmsg = "คะแนนที่ใส่มีค่าเท่ากับ 0"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Sub InsertDataRowDTExam_Detail(ByVal Exdid As String, ByVal Exdno As Integer, ByVal Exdquestion As String, ByVal Exdquestion2 As String, ByVal question_type As String, _
                                           ByVal Exd_answer_obj1 As String, ByVal Exd_answer_obj2 As String, ByVal Exd_answer_obj3 As String, _
                                           ByVal Exd_answer_obj4 As String, ByVal var_obj As String, ByVal Exd_answer_sub1 As String, _
                                           ByVal Exd_answer_sub2 As String, ByVal Exd_answer_sub3 As String, ByVal Exd_answer_sub4 As String, _
                                           ByVal Exdscore As Integer, ByVal Exd_status As String)
        If String.IsNullOrEmpty(Exdid) = True Then
            Exdid = Exam_Master.GetKey()
        End If
        If String.IsNullOrEmpty(Exd_status) = True Then
            Exd_status = "pendding"
        End If
        dt_exd.Rows.Add({Config.GBCorp, Exdid, exmId, Exdno, Exdquestion, Exdquestion2, question_type, Exd_answer_obj1, Exd_answer_obj2, Exd_answer_obj3, Exd_answer_obj4, _
                         var_obj, Exd_answer_sub1, Exd_answer_sub2, Exd_answer_sub3, Exd_answer_sub4, Exdscore, Exd_status})
        pmethBindHdExamDetail()

        If exdMode = GBMod.Edit Then
            MessageBox.Show("แก้ไขข้อสอบสำเร็จ!")
        Else
            MessageBox.Show("เพิ่มข้อสอบสำเร็จ")
        End If

        pmethBlankVarExam_Detail()
        txtExdno.Focus()
    End Sub

#Region "Event Exam Master"
    Private Sub btnHdExam_masterSave_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_masterSave.Click
        If ValidateDataExam_Master() = True Then
            Exam_Master.Corp_id = GBCorp
            Exam_Master.code = txtExmcode.Text
            Exam_Master.name = txtExmName.Text
            Exam_Master.name2 = txtExmname2.Text
            Exam_Master.qty = Convert.ToInt32(txtExmqty.Text)
            Exam_Master.score = Convert.ToInt32(txtExmscore.Text)
            Exam_Master.pass_exam = Convert.ToInt32(txtExmpass_exam.Text)
            'Check Dupcate Code
            If Exam_Master.CheckDupCode = False Then
                MessageBox.Show("พบรหัส :" & Exam_Master.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If exmMode = GBMod.Add Then
                Exam_Master.dt = dt_exd.Copy()
                dt_exd.Clear()
                Exam_Master.PrepareDataTable(exmMode)
                If Exam_Master.Add() = False Then
                    MessageBox.Show(Exam_Master.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                lvExam_detail.Items.Clear()
            ElseIf exmMode = GBMod.Edit Then
                Exam_Master.dt = dt_exd.Copy()
                dt_exd.Clear()
                Exam_Master.PrepareDataTable(exmMode)
                If Exam_Master.Update() = False Then
                    MessageBox.Show(Exam_Master.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            MessageBox.Show(Exam_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If exmMode = GBMod.Edit Then
                Close()
                Exam_Master.dt.Dispose()
                dt_exd.Dispose()
            Else
                FormBrow.binddata()
            End If
            pmethBlankVarExam_Master()
            pmethBlankVarExam_Detail()
        End If
    End Sub

    Private Sub btnHdExam_masterClear_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_masterClear.Click
        pmethBlankVarExam_Master()
    End Sub

    Private Sub btnHdExam_masterClose_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_masterClose.Click
        dt_exd.Clear()
        dt_exd.Dispose()
        Exam_Master.dt.Dispose()
        Close()
    End Sub

    Private Sub txtExmcode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExmcode.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExmname_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExmname2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExmname2.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub
#End Region


#Region "Event Exam Detail"



    Private Sub rbtExdquestion_type1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExdquestion_type1.CheckedChanged
        txtExd_answer_sub1.Enabled = True
        txtExd_answer_sub2.Enabled = True
        txtExd_answer_sub3.Enabled = True
        txtExd_answer_sub4.Enabled = True

        rbtExdanswer_obj1.Checked = False
        rbtExdanswer_obj1.Enabled = False
        rbtExdanswer_obj2.Checked = False
        rbtExdanswer_obj2.Enabled = False
        rbtExdanswer_obj3.Checked = False
        rbtExdanswer_obj3.Enabled = False
        rbtExdanswer_obj4.Checked = False
        rbtExdanswer_obj4.Enabled = False
        txtExd_answer_obj1.Text = String.Empty
        txtExd_answer_obj2.Text = String.Empty
        txtExd_answer_obj3.Text = String.Empty
        txtExd_answer_obj4.Text = String.Empty
        txtExd_answer_obj1.Enabled = False
        txtExd_answer_obj2.Enabled = False
        txtExd_answer_obj3.Enabled = False
        txtExd_answer_obj4.Enabled = False
        var_question_type = "S"
    End Sub

    Private Sub rbtExdquestion_type2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExdquestion_type2.CheckedChanged
        rbtExdanswer_obj1.Enabled = True
        rbtExdanswer_obj2.Enabled = True
        rbtExdanswer_obj3.Enabled = True
        rbtExdanswer_obj4.Enabled = True
        txtExd_answer_obj1.Enabled = True
        txtExd_answer_obj2.Enabled = True
        txtExd_answer_obj3.Enabled = True
        txtExd_answer_obj4.Enabled = True

        txtExd_answer_sub1.Text = String.Empty
        txtExd_answer_sub2.Text = String.Empty
        txtExd_answer_sub3.Text = String.Empty
        txtExd_answer_sub4.Text = String.Empty
        txtExd_answer_sub1.Enabled = False
        txtExd_answer_sub2.Enabled = False
        txtExd_answer_sub3.Enabled = False
        txtExd_answer_sub4.Enabled = False
        var_question_type = "O"
    End Sub

    Private Sub rbtExdanswer_obj1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExdanswer_obj1.CheckedChanged
        var_obj = "ก"
    End Sub

    Private Sub rbtExdanswer_obj2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExdanswer_obj2.CheckedChanged
        var_obj = "ข"
    End Sub

    Private Sub rbtExdanswer_obj3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExdanswer_obj3.CheckedChanged
        var_obj = "ค"
    End Sub

    Private Sub rbtExdanswer_obj4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtExdanswer_obj4.CheckedChanged
        var_obj = "ง"
    End Sub

    Private Sub btnHdExam_detailAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_detailAdd.Click
        exdMode = GBMod.Add
        pmethBlankVarExam_Detail()

    End Sub

    Private Sub btnHdExam_detailSave_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_detailSave.Click
        Dim var_exd_no As String = String.Empty
        Dim var_found_row As DataRow = Nothing
        Dim var_found_row_new As DataRow = Nothing
        If ValidateDataExam_Detail() = True Then
            If exdMode = GBMod.Edit Then
                var_exd_no = Exam_Master.exd_no
                var_found_row = dt_exd.Rows.Find(var_exd_no)
                If var_exd_no <> txtExdno.Text Then
                    var_found_row_new = dt_exd.Rows.Find(txtExdno.Text)
                    If var_found_row_new IsNot Nothing Then
                        MessageBox.Show("ข้อที่ " & var_found_row_new.Item("exd_no").ToString() & " ซ้ำ!")
                        txtExdno.Focus()
                    Else
                        dt_exd.Rows.Remove(var_found_row)
                        InsertDataRowDTExam_Detail(txtExd_id.Text, Convert.ToInt32(txtExdno.Text), txtExdquestion.Text, txtExdquestion2.Text, var_question_type, txtExd_answer_obj1.Text, txtExd_answer_obj2.Text, txtExd_answer_obj3.Text, txtExd_answer_obj4.Text, var_obj, txtExd_answer_sub1.Text, txtExd_answer_sub2.Text, txtExd_answer_sub3.Text, txtExd_answer_sub4.Text, Convert.ToInt32(txtExdscore.Text), txtExd_status.Text)
                        exdMode = GBMod.Add
                    End If
                Else
                    dt_exd.Rows.Remove(var_found_row)
                    InsertDataRowDTExam_Detail(txtExd_id.Text, Convert.ToInt32(txtExdno.Text), txtExdquestion.Text, txtExdquestion2.Text, var_question_type, txtExd_answer_obj1.Text, txtExd_answer_obj2.Text, txtExd_answer_obj3.Text, txtExd_answer_obj4.Text, var_obj, txtExd_answer_sub1.Text, txtExd_answer_sub2.Text, txtExd_answer_sub3.Text, txtExd_answer_sub4.Text, Convert.ToInt32(txtExdscore.Text), txtExd_status.Text)
                    exdMode = GBMod.Add
                End If
            Else
                var_exd_no = txtExdno.Text
                var_found_row = dt_exd.Rows.Find(var_exd_no)
                If var_found_row IsNot Nothing Then
                    MessageBox.Show("ข้อที่ " & var_found_row.Item("exd_no").ToString() & " ซ้ำ!")
                    txtExdno.Focus()
                Else
                    InsertDataRowDTExam_Detail(txtExd_id.Text, Convert.ToInt32(txtExdno.Text), txtExdquestion.Text, txtExdquestion2.Text, var_question_type, txtExd_answer_obj1.Text, txtExd_answer_obj2.Text, txtExd_answer_obj3.Text, txtExd_answer_obj4.Text, var_obj, txtExd_answer_sub1.Text, txtExd_answer_sub2.Text, txtExd_answer_sub3.Text, txtExd_answer_sub4.Text, Convert.ToInt32(txtExdscore.Text), txtExd_status.Text)
                End If
            End If
        End If
        var_exd_no = String.Empty
        var_found_row = Nothing
    End Sub

    Private Sub pmethBindHdExamDetail()

        Try
            Me.pnVarTotScoure = 0
            lvExam_detail.Items.Clear()
            If dt_exd.Rows.Count > 0 Then
                lvExam_detail.FullRowSelect = True
                lvExam_detail.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt_exd.Rows.Count - 1
                    lvExam_detail.Items.Add(dt_exd.Rows(row).Item("exd_no").ToString())
                    If dt_exd.Rows(row).Item("exd_question_type").ToString = "O" Then
                        lvExam_detail.Items(nindex).SubItems.Add("ปรนัย").ToString()
                    ElseIf dt_exd.Rows(row).Item("exd_question_type").ToString = "S" Then
                        lvExam_detail.Items(nindex).SubItems.Add("อัตนัย").ToString()
                    Else
                        lvExam_detail.Items(nindex).SubItems.Add(String.Empty).ToString()
                    End If
                    lvExam_detail.Items(nindex).SubItems.Add(dt_exd.Rows(row).Item("exd_question").ToString())
                    lvExam_detail.Items(nindex).SubItems.Add(dt_exd.Rows(row).Item("exd_answer_obj").ToString())
                    lvExam_detail.Items(nindex).SubItems.Add(dt_exd.Rows(row).Item("exd_answer_sub1").ToString())
                    lvExam_detail.Items(nindex).SubItems.Add(dt_exd.Rows(row).Item("exd_score").ToString())
                    Me.pnVarTotScoure = Me.pnVarTotScoure + cNull(dt_exd.Rows(row).Item("exd_score"), "N")

                    nindex = nindex + 1
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdExam_detailClear_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_detailClear.Click
        pmethBlankVarExam_Detail()
    End Sub

    Private Sub btnHdExam_detailRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_detailRefresh.Click
        Dim dataview As New DataView(dt_exd)
        dataview.Sort = "exd_no ASC"
        dt_exd = dataview.ToTable()
        dt_exd.PrimaryKey = New DataColumn() {dt_exd.Columns("exd_no")}
        dt_exd.Columns("exd_no").Unique = True
        dataview.Dispose()
        pmethBindHdExamDetail()
    End Sub

    Private Sub btnHdExam_detailDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_detailDelete.Click
        Try
            Dim var_exd_no As String = String.Empty
            Dim var_found_row As DataRow = Nothing
            If lvExam_detail.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                var_exd_no = lvExam_detail.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            var_found_row = dt_exd.Rows.Find(var_exd_no)
            If var_found_row IsNot Nothing Then
                If MessageBox.Show("ต้องการลบข้อสอบข้อที่ " & var_found_row.Item("exd_no").ToString() & " ใช่หรือไม่ ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbOK Then
                    dt_exd.Rows.Remove(var_found_row)
                    pmethBindHdExamDetail()
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnHdExam_detailEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnHdExam_detailEdit.Click
        Try
            exdMode = GBMod.Edit
            Dim var_exd_no As String = String.Empty
            Dim var_found_row As DataRow = Nothing
            If lvExam_detail.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                var_exd_no = lvExam_detail.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            var_found_row = dt_exd.Rows.Find(var_exd_no)
            If var_found_row IsNot Nothing Then
                pmethBlankVarExam_Detail()
                txtExdno.Text = var_found_row.Item("exd_no").ToString()
                txtExdquestion.Text = var_found_row.Item("exd_question").ToString()
                txtExdquestion2.Text = var_found_row.Item("exd_question2").ToString()
                If (var_found_row.Item("exd_question_type").ToString() = "S") Then
                    rbtExdquestion_type1.Checked = True
                ElseIf (var_found_row.Item("exd_question_type").ToString() = "O") Then
                    rbtExdquestion_type2.Checked = True
                End If
                txtExd_answer_sub1.Text = var_found_row.Item("exd_answer_sub1").ToString()
                txtExd_answer_sub2.Text = var_found_row.Item("exd_answer_sub2").ToString()
                txtExd_answer_sub3.Text = var_found_row.Item("exd_answer_sub3").ToString()
                txtExd_answer_sub4.Text = var_found_row.Item("exd_answer_sub4").ToString()
                If (var_found_row.Item("exd_answer_obj").ToString() = "ก") Then
                    rbtExdanswer_obj1.Checked = True
                ElseIf (var_found_row.Item("exd_answer_obj").ToString() = "ข") Then
                    rbtExdanswer_obj2.Checked = True
                ElseIf (var_found_row.Item("exd_answer_obj").ToString() = "ค") Then
                    rbtExdanswer_obj3.Checked = True
                ElseIf (var_found_row.Item("exd_answer_obj").ToString() = "ง") Then
                    rbtExdanswer_obj4.Checked = True
                End If
                txtExd_answer_obj1.Text = var_found_row.Item("exd_answer_obj1").ToString()
                txtExd_answer_obj2.Text = var_found_row.Item("exd_answer_obj2").ToString()
                txtExd_answer_obj3.Text = var_found_row.Item("exd_answer_obj3").ToString()
                txtExd_answer_obj4.Text = var_found_row.Item("exd_answer_obj4").ToString()
                txtExdscore.Text = var_found_row.Item("exd_score").ToString()
                txtExd_status.Text = var_found_row.Item("exd_status").ToString()
                Exam_Master.exd_no = var_exd_no
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
#End Region


    Private Sub txtExdscore_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExdscore.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtExdscore.Text
            Dim selectionStart = Me.txtExdscore.SelectionStart
            Dim selectionLength = Me.txtExdscore.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                'Reject an integer that is longer than 5 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 1) Then
                'Reject a real number 
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txtExmName_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExmName.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExmqty_GotFocus(sender As Object, e As System.EventArgs)
        txtExmqty.SelectAll()
    End Sub

    Private Sub txtExmscore_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExmscore.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
            Dim keyChar = e.KeyChar
            If Char.IsControl(keyChar) Then
                'Allow all control characters.
            ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text = Me.txtExmscore.Text
                Dim selectionStart = Me.txtExmscore.SelectionStart
                Dim selectionLength = Me.txtExmscore.SelectionLength

                text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

                If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                    'Reject an integer that is longer than 5 digits.
                    e.Handled = True
                ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 1) Then
                    'Reject a real number 
                    e.Handled = True
                End If
            Else
                'Reject all other characters.
                e.Handled = True
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExmpass_exam_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExmpass_exam.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
            Dim keyChar = e.KeyChar
            If Char.IsControl(keyChar) Then
                'Allow all control characters.
            ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text = Me.txtExmpass_exam.Text
                Dim selectionStart = Me.txtExmpass_exam.SelectionStart
                Dim selectionLength = Me.txtExmpass_exam.SelectionLength

                text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

                If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                    'Reject an integer that is longer than 5 digits.
                    e.Handled = True
                ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 1) Then
                    'Reject a real number 
                    e.Handled = True
                End If
            Else
                'Reject all other characters.
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExdno_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExdno.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
            Dim keyChar = e.KeyChar
            If Char.IsControl(keyChar) Then
                'Allow all control characters.
            ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text = Me.txtExdno.Text
                Dim selectionStart = Me.txtExdno.SelectionStart
                Dim selectionLength = Me.txtExdno.SelectionLength

                text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

                If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                    'Reject an integer that is longer than 5 digits.
                    e.Handled = True
                ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 1) Then
                    'Reject a real number 
                    e.Handled = True
                End If
            Else
                'Reject all other characters.
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub txtExdquestion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExdquestion.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExdquestion2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExdquestion2.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_sub1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_sub1.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_sub2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_sub2.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_sub3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_sub3.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_sub4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_sub4.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_id_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_id.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_obj1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_obj1.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_obj2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_obj2.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_obj3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_obj3.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_answer_obj4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_answer_obj4.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExd_status_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExd_status.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtExmqty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtExmqty.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
            Dim keyChar = e.KeyChar
            If Char.IsControl(keyChar) Then
                'Allow all control characters.
            ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text = Me.txtExmscore.Text
                Dim selectionStart = Me.txtExmscore.SelectionStart
                Dim selectionLength = Me.txtExmscore.SelectionLength

                text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

                If Integer.TryParse(text, New Integer) AndAlso text.Length > 5 Then
                    'Reject an integer that is longer than 5 digits.
                    e.Handled = True
                ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 1) Then
                    'Reject a real number 
                    e.Handled = True
                End If
            Else
                'Reject all other characters.
                e.Handled = True
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub
End Class