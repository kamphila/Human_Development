Imports System.Text.RegularExpressions

Public Class Setup_Place_POP
    Public mode As String = GBMod.View
    Public id As String = String.Empty
    Private Place As New Cls_HD_Place
    Private EmailValid As Boolean 'Is Email Valid?e
    Private PhoneValid As Boolean
    Public FormBrow As HD_System_Setup

    Private Sub Setup_Place_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pmethBlankVar()
        If mode = GBMod.Edit Then
            pmethGetdata()
        End If
    End Sub

    Private Sub pmethBlankVar()
        Place.empty(mode)
        txtCode.Text = String.Empty
        txtName.Text = String.Empty
        txtName2.Text = String.Empty
        txtPlace.Text = String.Empty
        txtContact.Text = String.Empty
        txtEmail.Text = String.Empty
        txtDesc.Text = String.Empty
        txtAddress.Text = String.Empty
        txtTel.Text = String.Empty
        txtWebsite.Text = String.Empty
        txtRent.Text = String.Empty
        txtValence.Text = String.Empty
        txtCode.Focus()
    End Sub

    Private Sub pmethGetdata()
        If String.IsNullOrEmpty(id) = False Then
            Place.getById(id)
            txtCode.Text = Place.code
            txtName.Text = Place.name
            txtName2.Text = Place.name2
            txtPlace.Text = Place.place
            txtContact.Text = Place.contact
            txtEmail.Text = Place.email
            txtDesc.Text = Place.desc
            txtAddress.Text = Place.address
            txtTel.Text = Place.tel
            txtWebsite.Text = Place.website
            txtRent.Text = Place.rent
            txtValence.Text = Place.valence
        End If
    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        Me.ValidateEmail()
        If txtCode.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่รหัส"
            bSucc = False
        ElseIf txtName.Text.ToString() = String.Empty Then
            strErrmsg = "กรุณาใส่ชื่อภาษา 1"
            bSucc = False
        ElseIf Me.txtEmail.Text <> String.Empty And Me.EmailValid = False Then
            strErrmsg = "Email ไม่ถูกต้อง"
            bSucc = False
            txtEmail.Focus()

        ElseIf Me.txtWebsite.Text <> String.Empty And ValidURL(txtWebsite.Text) = False Then
            strErrmsg = "WebSite ไม่ถูกต้อง"
            bSucc = False
            txtWebsite.Focus()
        End If
        If bSucc = False And strErrmsg <> String.Empty Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

#Region "Event"
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If ValidateData() = True Then
            Place.Corp_id = GBCorp
            Place.code = txtCode.Text
            Place.name = txtName.Text
            Place.name2 = txtName2.Text
            Place.place = txtPlace.Text
            Place.contact = txtContact.Text
            Place.email = txtEmail.Text
            Place.desc = txtDesc.Text
            Place.address = txtAddress.Text
            Place.tel = txtTel.Text
            Place.website = txtWebsite.Text
            If (String.IsNullOrEmpty(txtRent.Text) = False) Then
                Place.rent = Convert.ToDecimal(txtRent.Text)
            Else
                Place.rent = Nothing
            End If
            If (String.IsNullOrEmpty(txtValence.Text) = False) Then
                Place.valence = Convert.ToInt32(txtValence.Text)
            Else
                Place.valence = Nothing
            End If
            'Check Dupcate Code
            If Place.CheckDupCode = False Then
                MessageBox.Show("พบรหัส :" & Place.code & " ในระบบแล้ว,กรุณาป้อนรหัสใหม่อีกครั้ง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If mode = GBMod.Add Then
                If Place.Add = False Then
                    MessageBox.Show(Place.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            ElseIf mode = GBMod.Edit Then
                If Place.Update() = False Then
                    MessageBox.Show(Place.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            MessageBox.Show(Place.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub txtRent_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtRent.KeyPress
        Dim keyChar = e.KeyChar
        If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
            SendKeys.Send(vbTab)
        ElseIf Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtRent.Text
            Dim selectionStart = Me.txtRent.SelectionStart
            Dim selectionLength = Me.txtRent.SelectionLength

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

    Private Sub txtValence_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtValence.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtValence.Text
            Dim selectionStart = Me.txtValence.SelectionStart
            Dim selectionLength = Me.txtValence.SelectionLength

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


#End Region

    Private Sub txtPlace_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlace.KeyPress
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



    Private Sub txtContact_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub txtDesc_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
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

    Private Sub txtWebsite_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtWebsite.KeyPress
        Try
            If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
                SendKeys.Send(vbTab)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub


    Private Sub ValidateEmail()
        If txtEmail.Text <> "" Then
            Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." + _
            ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})", _
            RegexOptions.IgnoreCase _
            Or RegexOptions.CultureInvariant _
            Or RegexOptions.IgnorePatternWhitespace _
            Or RegexOptions.Compiled _
            )
            Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtEmail.Text)
            If blnPossibleMatch Then
                If Not txtEmail.Text.Equals(reEmail.Match(txtEmail.Text).ToString) Then
                    EmailValid = False
                Else
                    EmailValid = True
                End If
            Else
                EmailValid = False
            End If
        Else
            EmailValid = True
        End If

    End Sub


    'Private Sub txtEmail_LostFocus(sender As Object, e As System.EventArgs) Handles txtEmail.LostFocus
    '    'เพิ่มเรื่อง Handel
    '    ValidateEmail() 'Check Email Validity
    '    If EmailValid = False Then
    '        MessageBox.Show("Invalid Email Address!") 'Inform User
    '        txtEmail.Focus()

    '    End If
    'End Sub

    Private Sub txtEmail_Validated(sender As System.Object, e As System.EventArgs) Handles txtEmail.Validated
        ValidateEmail()
        If EmailValid = False Then
            MessageBox.Show("Email ไม่ถูกต้อง!")
            txtEmail.Focus()
        End If
    End Sub

    Public Function ValidURL(ByVal strUrl As String) As Boolean
        If Not Regex.IsMatch(strUrl, _
               "^((ht|f)tp(s?)\:\/\/|~/|/)?([\w]+:\w+@)?([a-zA-Z]{1}([\w\-]+\.)+([\w]{2,5}))(:[\d]{1,5})?((/?\w+/)+|/?)(\w+\.[\w]{3,4})?((\?\w+=\w+)?(&\w+=\w+)*)?") Then
            Return False
        Else
            Return True
        End If
    End Function

    'Private Sub txtWebsite_LostFocus(sender As Object, e As System.EventArgs) Handles txtWebsite.LostFocus
    '    If txtWebsite.Text <> "" Then
    '        If ValidURL(txtWebsite.Text) = False Then
    '            MessageBox.Show("URL ไม่ถูกต้อง")
    '            Me.txtWebsite.Focus()
    '        End If
    '    End If
    'End Sub


    Private Sub txtWebsite_Validated(sender As Object, e As System.EventArgs) Handles txtWebsite.Validated
        If txtWebsite.Text <> "" Then
            If ValidURL(txtWebsite.Text) = False Then
                MessageBox.Show("URL ไม่ถูกต้อง")
                Me.txtWebsite.Focus()
            End If
        End If
    End Sub
End Class