Public Class Setup_Method_POP
    Public mode As String = GBMod.View
    Public id As String = String.Empty
    Private Method As New Cls_HD_Method
    Public FormBrow As HD_System_Setup

    Private Sub Setup_Method_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pmethBlankVar()
        If mode = GBMod.Edit Then
            pmethGetdata()
        End If
    End Sub

    Private Sub pmethBlankVar()
        Method.empty(mode)
        txtCode.Text = String.Empty
        txtName.Text = String.Empty
        txtName2.Text = String.Empty
        txtDesc.Text = String.Empty
        txtCode.Focus()
    End Sub

    Private Sub pmethGetdata()
        If String.IsNullOrEmpty(id) = False Then
            Method.getById(id)
            txtCode.Text = Method.code
            txtName.Text = Method.name
            txtName2.Text = Method.name2
            txtDesc.Text = Method.desc
        End If
    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If txtCode.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่รหัส"
            bSucc = False
        ElseIf txtName.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่ชื่อภาษา 1"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

#Region "Event"
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If ValidateData() = True Then
            Method.Corp_id = GBCorp
            Method.code = txtCode.Text
            Method.name = txtName.Text
            Method.name2 = txtName2.Text
            Method.desc = txtDesc.Text
            'Check Dupcate Code
            If Method.CheckDupCode = False Then
                MessageBox.Show("พบรหัส :" & Method.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If mode = GBMod.Add Then
                If Method.Add = False Then
                    MessageBox.Show(Method.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            ElseIf mode = GBMod.Edit Then
                If Method.Update() = False Then
                    MessageBox.Show(Method.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            MessageBox.Show(Method.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
#End Region



End Class