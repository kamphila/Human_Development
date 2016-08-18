Imports System.Text.RegularExpressions

Public Class Setup_Guest_POP
    Public mode As String = GBMod.View
    Public id As String = String.Empty
    Private var_inout As String = String.Empty
    Private Guest As New Cls_HD_Guest
    Public FormBrow As HD_System_Setup

    Private Sub Setup_Guest_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pmethBlankVar()
        If mode = GBMod.Edit Then
            pmethGetdata()
        End If
    End Sub

    Private Sub pmethBlankVar()
        Guest.empty(mode)
        rbtGuestenterprise.Checked = True
        rbtGuestoutsource.Checked = False
        txtCode.Text = String.Empty
        txtName.Text = String.Empty
        txtName2.Text = String.Empty
        txtPosition.Text = String.Empty
        txtCorp_email.Text = String.Empty
        txtEmail.Text = String.Empty
        txtTel.Text = String.Empty
        txtInstitution.Text = String.Empty
        txtAddress.Text = String.Empty
        txtBelong.Text = String.Empty
        txtWage.Text = String.Empty
        txtSkill.Text = String.Empty
        txtDesc.Text = String.Empty
        txtCode.Focus()

    End Sub

    Private Sub pmethGetdata()
        If String.IsNullOrEmpty(id) = False Then
            Guest.getById(id)
            If Guest.inout = "I" Then
                rbtGuestenterprise.Checked = True
            ElseIf Guest.inout = "O" Then
                rbtGuestoutsource.Checked = True
            Else
                rbtGuestenterprise.Checked = False
                rbtGuestoutsource.Checked = False
            End If
            txtCode.Text = Guest.code
            txtName.Text = Guest.name
            txtName2.Text = Guest.name2
            txtPosition.Text = Guest.position
            txtCorp_email.Text = Guest.corp_email
            txtEmail.Text = Guest.email
            txtTel.Text = Guest.tel
            txtInstitution.Text = Guest.institution
            txtAddress.Text = Guest.address
            txtBelong.Text = Guest.belong
            txtWage.Text = Guest.wage
            txtSkill.Text = Guest.skill
            txtDesc.Text = Guest.desc
        End If
    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If (rbtGuestenterprise.Checked = False) And (rbtGuestoutsource.Checked = False) Then
            strErrmsg = "กรุณาใส่ประเภทวิทยากร"
            bSucc = False
        ElseIf txtCode.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่รหัส"
            bSucc = False
        ElseIf txtName.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่ชื่อภาษา 1"
            bSucc = False
        ElseIf txtCorp_email.Text <> String.Empty And EmailValid(txtCorp_email.Text) = False Then
            strErrmsg = "Email บริษัทไม่ถูกต้อง"
            bSucc = False
        ElseIf txtEmail.Text <> String.Empty And EmailValid(txtEmail.Text) = False Then
            strErrmsg = "Email ไม่ถูกต้อง"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

#Region "Event"
    Private Sub rbtGuestenterprise_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtGuestenterprise.CheckedChanged
        btnGuestbrowse.Enabled = True
        var_inout = "I"
        txtName.Enabled = False
        'txtCode.Text = String.Empty
        'txtName.Text = String.Empty
        'txtName2.Text = String.Empty
        'txtPosition.Text = String.Empty
        'txtCorp_email.Text = String.Empty
        'txtEmail.Text = String.Empty
        'txtTel.Text = String.Empty
        'txtInstitution.Text = String.Empty
        'txtAddress.Text = String.Empty
        'txtBelong.Text = String.Empty
        'txtWage.Text = String.Empty
        'txtSkill.Text = String.Empty
        'txtDesc.Text = String.Empty
    End Sub

    Private Sub rbtGuestoutsource_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtGuestoutsource.CheckedChanged
        btnGuestbrowse.Enabled = False
        var_inout = "O"
        txtName.Enabled = True
        'txtCode.Text = String.Empty
        'txtName.Text = String.Empty
        'txtName2.Text = String.Empty
        'txtPosition.Text = String.Empty
        'txtCorp_email.Text = String.Empty
        'txtEmail.Text = String.Empty
        'txtTel.Text = String.Empty
        'txtInstitution.Text = String.Empty
        'txtAddress.Text = String.Empty
        'txtBelong.Text = String.Empty
        'txtWage.Text = String.Empty
        'txtSkill.Text = String.Empty
        'txtDesc.Text = String.Empty
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If ValidateData() = True Then
            Guest.Corp_id = GBCorp
            Guest.inout = var_inout
            Guest.code = txtCode.Text
            Guest.name = txtName.Text
            Guest.name2 = txtName2.Text
            Guest.position = txtPosition.Text
            Guest.corp_email = txtCorp_email.Text
            Guest.email = txtEmail.Text
            Guest.tel = txtTel.Text
            Guest.institution = txtInstitution.Text
            Guest.address = txtAddress.Text
            Guest.belong = txtBelong.Text
            If (String.IsNullOrEmpty(txtWage.Text) = False) Then
                Guest.wage = Convert.ToDecimal(txtWage.Text)
            Else
                Guest.wage = Nothing
            End If
            Guest.skill = txtSkill.Text
            Guest.desc = txtDesc.Text
            'Check Dupcate Code
            If Guest.CheckDupCode = False Then
                MessageBox.Show("พบรหัส :" & Guest.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If mode = GBMod.Add Then
                If Guest.Add = False Then
                    MessageBox.Show(Guest.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            ElseIf mode = GBMod.Edit Then
                If Guest.Update() = False Then
                    MessageBox.Show(Guest.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            MessageBox.Show(Guest.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
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

    Private Sub txtName_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtName2_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtName2.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtWage_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtWage.KeyPress
        Dim keyChar = e.KeyChar
        If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
            SendKeys.Send(vbTab)
        ElseIf Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtWage.Text
            Dim selectionStart = Me.txtWage.SelectionStart
            Dim selectionLength = Me.txtWage.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3) Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub btnGuestbrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnGuestbrowse.Click
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
            txtCode.Text = frm.rtn_person_code
            txtName.Text = frm.rtn_personname
            txtName2.Text = ""
            txtPosition.Text = frm.rtn_position_name
            txtCorp_email.Text = ""
            txtEmail.Text = ""
            txtTel.Text = ""
            txtInstitution.Text = ""
            txtAddress.Text = ""
            txtBelong.Text = ""
            txtWage.Text = ""
            txtSkill.Text = ""
            txtDesc.Text = ""
        End If

    End Sub

    Private Sub txtPosition_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPosition.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtCorp_email_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorp_email.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtEmail_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtTel_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTel.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtInstitution_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtInstitution.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtAddress_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddress.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtBelong_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBelong.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtSkill_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSkill.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Public Function EmailValid(ByVal strEmail As String) As Boolean
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
              ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
              RegexOptions.IgnoreCase _
              Or RegexOptions.CultureInvariant _
              Or RegexOptions.IgnorePatternWhitespace _
              Or RegexOptions.Compiled _
              )
        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(strEmail)
        If blnPossibleMatch Then
            If Not txtEmail.Text.Equals(reEmail.Match(txtEmail.Text).ToString) Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If

    End Function



    Private Sub txtCorp_email_Validated(sender As Object, e As System.EventArgs) Handles txtCorp_email.Validated
        If txtCorp_email.Text <> "" Then
            If EmailValid(txtCorp_email.Text) = False Then
                MessageBox.Show("Email ไม่ถูกต้อง")
                Me.txtCorp_email.Focus()
            End If
        End If
    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As System.EventArgs) Handles txtEmail.Validated
        If txtEmail.Text <> "" Then
            If EmailValid(txtEmail.Text) = False Then
                MessageBox.Show("Email ไม่ถูกต้อง")
                Me.txtEmail.Focus()
            End If
        End If
    End Sub
End Class