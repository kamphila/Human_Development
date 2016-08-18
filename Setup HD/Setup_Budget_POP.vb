Imports System.Globalization
Imports Human_Development.Cls_SqlDB

Public Class Setup_Budget_POP
    Public mode As String = GBMod.View
    Public id As String = String.Empty
    Private Budget As New Cls_HD_Budget
    Public FormBrow As HD_System_Setup

    Private Sub Setup_Budget_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.txtCode.Enabled = False
        Me.txtName.Enabled = False
        Me.txtName2.Enabled = False

        pmethBlankVar()
        If mode = GBMod.Edit Then
            pmethGetdata()
        End If
    End Sub

    Private Sub pmethBlankVar()
        Budget.empty(mode)

        txtCode.Text = String.Empty
        txtName.Text = String.Empty
        txtName2.Text = String.Empty
        txtAmt.Text = 0
        'txtYear.Text = String.Empty
        txtBegdate.Text = String.Empty
        txtEnddate.Text = String.Empty
        lblBegDate.Text = String.Empty
        lblEndDate.Text = String.Empty
        txtDesc.Text = String.Empty
        txtCode.Focus()
    End Sub

    Private Sub pmethGetdata()
        If String.IsNullOrEmpty(id) = False Then
            Budget.getById(id)
            'aaa
            'txtCode.Text = Budget.code
            'txtName.Text = Budget.name
            'txtName2.Text = Budget.name2
            txtCode.Text = Budget.expStation.code
            txtName.Text = Budget.expStation.name
            txtName2.Text = Budget.expStation.name2

            txtAmt.Text = Budget.amt.ToString("N")
            If ((String.IsNullOrEmpty(Budget.begdate)) And (String.IsNullOrEmpty(Budget.enddate))) = False Then
                lblBegDate.Text = DateToStringTH(Budget.begdate)
                lblEndDate.Text = DateToStringTH(Budget.enddate)
            Else
                lblBegDate.Text = String.Empty
                lblEndDate.Text = String.Empty
            End If
            'txtYear.Text = Budget.year
            txtDesc.Text = Budget.desc
        End If
    End Sub
    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        'If txtCode.Text.ToString() = String.Empty Then
        '    strErrmsg = "กรุณาใส่รหัส"
        '    bSucc = False
        'ElseIf txtName.Text.ToString() = String.Empty Then
        '    strErrmsg = "กรุณาใส่ชื่อภาษา 1"
        '    bSucc = False
        If Budget.station = String.Empty Then
            strErrmsg = "กรุณาเลือกหน่วยงาน"
            bSucc = False

        ElseIf txtAmt.Text = 0 Then
            strErrmsg = "กรุณาใส่จำนวนงบประมาณ"
            bSucc = False
            'ElseIf txtYear.Text.ToString() = String.Empty Then
            '    strErrmsg = "กรุณาใส่ปีงบประมาณ"
        ElseIf lblBegDate.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่วันที่เริ่มต้น"
            bSucc = False
        ElseIf lblEndDate.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่วันที่สุดท้าย"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function


#Region "Event"
    Private Sub txtBegdate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBegdate.ValueChanged
        lblBegDate.Text = txtBegdate.Value.ToShortDateString()
    End Sub

    Private Sub txtEnddate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles txtEnddate.ValueChanged
        lblEndDate.Text = txtEnddate.Value.ToShortDateString()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If ValidateData() = True Then
            Dim resultDatetime As Int64 = DateTime.Compare(Convert.ToDateTime(lblEndDate.Text), Convert.ToDateTime(lblBegDate.Text))
            If resultDatetime < 0 Then
                MessageBox.Show("กรุณาใส่ช่วงวันที่ให้ถูกต้อง", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Budget.Corp_id = GBCorp
            'Budget.code = txtCode.Text
            'Budget.name = txtName.Text
            'Budget.name2 = txtName2.Text
            Budget.amt = gmDoubleParse(txtAmt.Text, 0)
            'Budget.year = txtYear.Text
            'If mode = GBMod.Edit Then
            Budget.begdate = Convert.ToDateTime(lblBegDate.Text)
            Budget.enddate = Convert.ToDateTime(lblEndDate.Text)
            'Else
            '    Budget.begdate = txtBegdate.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))
            '    Budget.enddate = txtEnddate.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))
            'End If
            Budget.desc = txtDesc.Text
            'Check Dupcate Code
            'If Budget.CheckDupCode = False Then
            '    MessageBox.Show("พบรหัส :" & Budget.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            If mode = GBMod.Add Then
                If Budget.Add = False Then
                    MessageBox.Show(Budget.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            ElseIf mode = GBMod.Edit Then
                If Budget.Update() = False Then
                    MessageBox.Show(Budget.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            MessageBox.Show(Budget.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnSearSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearSearch.Click
        Dim ObjForm As New Select_Station()
        If ObjForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.txtCode.Text = ObjForm.Retrun_Code
            Me.txtName.Text = ObjForm.Retrun_Name
            Me.txtName2.Text = ObjForm.Retrun_Name2
            Budget.station = ObjForm.Retrun_id
        End If

    End Sub


    Private Sub txtAmt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmt.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtAmt.Text
            Dim selectionStart = Me.txtAmt.SelectionStart
            Dim selectionLength = Me.txtAmt.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 12 Then
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

    Private Sub txtAmt_LostFocus(sender As Object, e As System.EventArgs) Handles txtAmt.LostFocus
        Dim num As Double = Convert.ToDouble(txtAmt.Text)
        txtAmt.Text = num.ToString("N")
    End Sub
End Class