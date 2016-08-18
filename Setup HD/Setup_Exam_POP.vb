Public Class Setup_Exam_POP
    Public mode As String = GBMod.View
    Public id As String = String.Empty
    Private Exam As New Cls_HD_Exam
    Public FormBrow As HD_System_Setup

    Private Sub Rad_Objective_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rad_Objective.CheckedChanged
        Me.pmethValidQnswer()
    End Sub

    Private Sub Rad_Subjective_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rad_Subjective.CheckedChanged
        Me.pmethValidQnswer()

    End Sub

    Private Sub Setup_Exam_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pmethBlankVar()
        If mode = GBMod.Edit Then
            pmethGetdata()
        End If
    End Sub

    Private Sub pmethGetdata()
        If String.IsNullOrEmpty(id) = False Then
            Exam.getById(id)
            txtCode.Text = Exam.code
            txtQuestion1.Text = Exam.Question
            txtQuestion2.Text = Exam.Question2
            If Exam.Question_Type = "O" Then
                Rad_Objective.Checked = True
                Rad_Subjective.Checked = False
                txtAnswer1.Text = Exam.Answer1
                txtAnswer2.Text = Exam.Answer2
                txtAnswer3.Text = Exam.Answer3
                txtAnswer4.Text = Exam.Answer4
                txtAnswer_Sub.Text = String.Empty
            Else
                Rad_Objective.Checked = False
                Rad_Subjective.Checked = True
                txtAnswer_Sub.Text = Exam.Answer_sub
                txtAnswer1.Text = String.Empty
                txtAnswer2.Text = String.Empty
                txtAnswer3.Text = String.Empty
                txtAnswer4.Text = String.Empty
            End If
            If Exam.Answer_Obj = "1" Then
                Rad_Choice1.Checked = True
            ElseIf Exam.Answer_Obj = "2" Then
                Rad_Choice2.Checked = True
            ElseIf Exam.Answer_Obj = "3" Then
                Rad_Choice3.Checked = True
            Else
                Rad_Choice4.Checked = True
            End If
            txtScore.Text = Exam.score

            Me.pmethValidQnswer()
        End If
    End Sub

    Private Sub pmethBlankVar()
        Exam.empty(mode)
        txtCode.Text = String.Empty
        txtQuestion1.Text = String.Empty
        txtQuestion2.Text = String.Empty
        txtAnswer1.Text = String.Empty
        txtAnswer2.Text = String.Empty
        txtAnswer3.Text = String.Empty
        txtAnswer4.Text = String.Empty
        txtAnswer_Sub.Text = String.Empty
        Rad_Objective.Checked = True
        Rad_Choice1.Checked = False
        Rad_Choice2.Checked = False
        Rad_Choice3.Checked = False
        Rad_Choice4.Checked = False
        txtScore.Text = 0
        txtCode.Focus()
        Me.pmethValidQnswer()
    End Sub

    Private Sub pmethValidQnswer()
        If Rad_Objective.Checked = True Then
            Me.txtAnswer1.Enabled = True
            Me.txtAnswer2.Enabled = True
            Me.txtAnswer3.Enabled = True
            Me.txtAnswer4.Enabled = True
            Me.Rad_Choice1.Enabled = True
            Me.Rad_Choice2.Enabled = True
            Me.Rad_Choice3.Enabled = True
            Me.Rad_Choice4.Enabled = True
            Me.txtAnswer_Sub.Enabled = False
        Else
            Me.txtAnswer1.Enabled = False
            Me.txtAnswer2.Enabled = False
            Me.txtAnswer3.Enabled = False
            Me.txtAnswer4.Enabled = False
            Me.Rad_Choice1.Enabled = False
            Me.Rad_Choice2.Enabled = False
            Me.Rad_Choice3.Enabled = False
            Me.Rad_Choice4.Enabled = False
            Me.txtAnswer_Sub.Enabled = True
        End If
    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If txtCode.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่รหัส"
            bSucc = False
        ElseIf txtQuestion1.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่คำถาม "
            bSucc = False
        ElseIf Rad_Objective.Checked = True And (txtAnswer1.Text.ToString() = String.Empty) Then
            strErrmsg = "กรุณาใส่คำตอบข้อ 1"
            bSucc = False
            txtAnswer1.Focus()
        ElseIf Rad_Objective.Checked = True And (txtAnswer2.Text.ToString() = String.Empty) Then
            strErrmsg = "กรุณาใส่คำตอบข้อ 2"
            bSucc = False
            txtAnswer2.Focus()
        ElseIf Rad_Objective.Checked = True And (txtAnswer3.Text.ToString() = String.Empty) Then
            strErrmsg = "กรุณาใส่คำตอบข้อ 3"
            bSucc = False
            txtAnswer3.Focus()
        ElseIf Rad_Objective.Checked = True And (txtAnswer4.Text.ToString() = String.Empty) Then
            strErrmsg = "กรุณาใส่คำตอบข้อ 4"
            bSucc = False
            txtAnswer4.Focus()
        ElseIf Rad_Subjective.Checked = True And (txtAnswer_Sub.Text.ToString() = String.Empty) Then
            strErrmsg = "กรุณาใส่คำตอบอัตนัย"
            bSucc = False
            txtAnswer_Sub.Focus()
        ElseIf txtScore.Text = 0 Then
            strErrmsg = "กรุณาใส่คะแนน"
            bSucc = False
            txtScore.Focus()
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

#Region "Event"
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If ValidateData() = True Then
            Exam.Corp_id = GBCorp
            Exam.code = txtCode.Text
            Exam.Question = txtQuestion1.Text.ToString()
            Exam.Question2 = txtQuestion2.Text.ToString()
            If Rad_Objective.Checked = True Then
                Exam.Question_Type = "O"
                If Rad_Choice1.Checked = True Then
                    Exam.Answer_Obj = "1"
                ElseIf Rad_Choice2.Checked = True Then
                    Exam.Answer_Obj = "2"
                ElseIf Rad_Choice3.Checked = True Then
                    Exam.Answer_Obj = "3"
                Else
                    Exam.Answer_Obj = "4"
                End If
                Exam.Answer_sub = String.Empty
                Exam.Answer1 = txtAnswer1.Text.ToString()
                Exam.Answer2 = txtAnswer2.Text.ToString()
                Exam.Answer3 = txtAnswer3.Text.ToString()
                Exam.Answer4 = txtAnswer3.Text.ToString()
            Else
                Exam.Question_Type = "S"
                Exam.Answer_Obj = String.Empty
                Exam.Answer_sub = txtAnswer_Sub.Text.ToString()
                Exam.Answer1 = String.Empty
                Exam.Answer2 = String.Empty
                Exam.Answer3 = String.Empty
                Exam.Answer4 = String.Empty
            End If
            Exam.score = Convert.ToDouble(txtScore.Text)

            If mode = GBMod.Add Then
                'Check Dupcate Code
                If Exam.CheckDupCode = False Then
                    MessageBox.Show("พบรหัส :" & Exam.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                If Exam.Add = False Then
                    MessageBox.Show(Exam.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            ElseIf mode = GBMod.Edit Then
                If Exam.Update() = False Then
                    MessageBox.Show(Exam.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            MessageBox.Show(Exam.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If mode = GBMod.Edit Then
                Close()
            Else
                FormBrow.binddata()
            End If
            pmethBlankVar()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        pmethBlankVar()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtCode_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtQuestion1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuestion1.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub txtQuestion2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuestion2.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub txtAnswer1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer1.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub txtAnswer2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer2.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub txtAnswer3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer3.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

    End Sub

    Private Sub txtAnswer4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnswer4.KeyPress
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




End Class