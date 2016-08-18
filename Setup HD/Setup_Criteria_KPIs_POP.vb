Public Class Setup_Criteria_KPIs_POP
    Public mode As String = GBMod.View
    Public id As String = String.Empty
    Private Criteria_Kpis As New Cls_HD_Criteria_Kpis
    Public FormBrow As HD_System_Setup

    Private Sub Setup_Criteria_KPIs_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pmethBlankVar()
        If mode = GBMod.Edit Then
            pmethGetdata()
        End If

    End Sub

    Private Sub pmethBlankVar()
        Criteria_Kpis.empty(mode)
        txtCode.Text = String.Empty
        txtName.Text = String.Empty
        txtName2.Text = String.Empty
        txtDesc.Text = String.Empty
        txtBegscore.Text = String.Empty
        txtEndscore.Text = String.Empty
        txtCode.Focus()
    End Sub

    Private Sub pmethGetdata()
        If String.IsNullOrEmpty(id) = False Then
            Criteria_Kpis.getById(id)
            txtCode.Text = Criteria_Kpis.code
            txtName.Text = Criteria_Kpis.name
            txtName2.Text = Criteria_Kpis.name2
            txtDesc.Text = Criteria_Kpis.desc
            txtBegscore.Text = Criteria_Kpis.begscore
            txtEndscore.Text = Criteria_Kpis.endscore

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
        ElseIf txtBegscore.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่คะแนนเริ่มต้น"
            bSucc = False
        ElseIf txtEndscore.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่คะแนนสิ้นสุด"
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
            Criteria_Kpis.Corp_id = GBCorp
            Criteria_Kpis.code = txtCode.Text
            Criteria_Kpis.name = txtName.Text
            Criteria_Kpis.name2 = txtName2.Text
            Criteria_Kpis.desc = txtDesc.Text
            Criteria_Kpis.begscore = txtBegscore.Text
            Criteria_Kpis.endscore = txtEndscore.Text
            If Criteria_Kpis.CheckDupCode = False Then
                MessageBox.Show("พบรหัส :" & Criteria_Kpis.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If mode = GBMod.Add Then
                If Criteria_Kpis.Add = False Then
                    MessageBox.Show(Criteria_Kpis.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            ElseIf mode = GBMod.Edit Then
                If Criteria_Kpis.Update() = False Then
                    MessageBox.Show(Criteria_Kpis.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            MessageBox.Show(Criteria_Kpis.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub txtBegscore_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtEndscore_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtBegscore_GotFocus(sender As Object, e As System.EventArgs) Handles txtBegscore.GotFocus
        Me.txtBegscore.SelectAll()
    End Sub


    Private Sub txtEndscore_GotFocus(sender As Object, e As System.EventArgs) Handles txtEndscore.GotFocus
        Me.txtEndscore.SelectAll()
    End Sub
End Class