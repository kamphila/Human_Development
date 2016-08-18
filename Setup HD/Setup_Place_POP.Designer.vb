<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup_Place_POP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup_Place_POP))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_institution2 = New System.Windows.Forms.Label()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lbl_institution1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lbl_place = New System.Windows.Forms.Label()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.lbl_website = New System.Windows.Forms.Label()
        Me.lbl_rent_place = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.txtRent = New System.Windows.Forms.TextBox()
        Me.lbl_capacity = New System.Windows.Forms.Label()
        Me.txtValence = New System.Windows.Forms.TextBox()
        Me.lbl_note = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = CType(resources.GetObject("ToolStrip1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnClear, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 644
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(55, 22)
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 22)
        Me.btnClear.Text = "ล้างข้อมูล"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 262)
        Me.GroupBox1.TabIndex = 645
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.48815!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.51185!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_institution2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_code, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCode, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_institution1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPlace, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtContact, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDesc, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_place, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_contact, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_email, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_address, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_phone, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_website, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_rent_place, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAddress, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTel, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtWebsite, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRent, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_capacity, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtValence, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_note, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 9)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(996, 246)
        Me.TableLayoutPanel1.TabIndex = 130
        '
        'lbl_institution2
        '
        Me.lbl_institution2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_institution2.AutoSize = True
        Me.lbl_institution2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_institution2.Location = New System.Drawing.Point(42, 57)
        Me.lbl_institution2.Name = "lbl_institution2"
        Me.lbl_institution2.Size = New System.Drawing.Size(89, 15)
        Me.lbl_institution2.TabIndex = 125
        Me.lbl_institution2.Text = "สถาบัน (ภาษา 2):"
        Me.lbl_institution2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_code.Location = New System.Drawing.Point(99, 0)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(32, 26)
        Me.lbl_code.TabIndex = 121
        Me.lbl_code.Text = "รหัส :"
        Me.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Location = New System.Drawing.Point(137, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(99, 21)
        Me.txtCode.TabIndex = 122
        '
        'lbl_institution1
        '
        Me.lbl_institution1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_institution1.AutoSize = True
        Me.lbl_institution1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_institution1.Location = New System.Drawing.Point(29, 31)
        Me.lbl_institution1.Name = "lbl_institution1"
        Me.lbl_institution1.Size = New System.Drawing.Size(102, 15)
        Me.lbl_institution1.TabIndex = 123
        Me.lbl_institution1.Text = "ชื่อสถาบัน (ภาษา 1):"
        Me.lbl_institution1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(137, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(298, 21)
        Me.txtName.TabIndex = 124
        '
        'txtName2
        '
        Me.txtName2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName2.Location = New System.Drawing.Point(137, 55)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(298, 21)
        Me.txtName2.TabIndex = 126
        '
        'txtPlace
        '
        Me.txtPlace.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPlace.Location = New System.Drawing.Point(137, 81)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(298, 21)
        Me.txtPlace.TabIndex = 147
        '
        'txtContact
        '
        Me.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtContact.Location = New System.Drawing.Point(137, 106)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(298, 21)
        Me.txtContact.TabIndex = 148
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(137, 131)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(298, 21)
        Me.txtEmail.TabIndex = 154
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(137, 159)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(298, 83)
        Me.txtDesc.TabIndex = 155
        '
        'lbl_place
        '
        Me.lbl_place.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_place.AutoSize = True
        Me.lbl_place.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_place.Location = New System.Drawing.Point(88, 83)
        Me.lbl_place.Name = "lbl_place"
        Me.lbl_place.Size = New System.Drawing.Size(43, 15)
        Me.lbl_place.TabIndex = 156
        Me.lbl_place.Text = "สถานที่:"
        Me.lbl_place.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_contact
        '
        Me.lbl_contact.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_contact.Location = New System.Drawing.Point(67, 108)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(64, 15)
        Me.lbl_contact.TabIndex = 157
        Me.lbl_contact.Text = "บุคคลติดต่อ:"
        Me.lbl_contact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_email
        '
        Me.lbl_email.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(97, 133)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(34, 15)
        Me.lbl_email.TabIndex = 158
        Me.lbl_email.Text = "อีเมล์:"
        Me.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_address
        '
        Me.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(548, 31)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(30, 15)
        Me.lbl_address.TabIndex = 160
        Me.lbl_address.Text = "ที่อยู่:"
        Me.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_phone
        '
        Me.lbl_phone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_phone.Location = New System.Drawing.Point(501, 57)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(77, 15)
        Me.lbl_phone.TabIndex = 161
        Me.lbl_phone.Text = "โทรศัพท์ติอต่อ:"
        Me.lbl_phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_website
        '
        Me.lbl_website.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_website.AutoSize = True
        Me.lbl_website.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_website.Location = New System.Drawing.Point(530, 83)
        Me.lbl_website.Name = "lbl_website"
        Me.lbl_website.Size = New System.Drawing.Size(48, 15)
        Me.lbl_website.TabIndex = 162
        Me.lbl_website.Text = "เว็บไซด์:"
        Me.lbl_website.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_rent_place
        '
        Me.lbl_rent_place.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_rent_place.AutoSize = True
        Me.lbl_rent_place.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_rent_place.Location = New System.Drawing.Point(506, 108)
        Me.lbl_rent_place.Name = "lbl_rent_place"
        Me.lbl_rent_place.Size = New System.Drawing.Size(72, 15)
        Me.lbl_rent_place.TabIndex = 163
        Me.lbl_rent_place.Text = "ค่าเช่าสถานที่:"
        Me.lbl_rent_place.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(584, 29)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(298, 21)
        Me.txtAddress.TabIndex = 168
        '
        'txtTel
        '
        Me.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(584, 55)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(298, 21)
        Me.txtTel.TabIndex = 169
        '
        'txtWebsite
        '
        Me.txtWebsite.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtWebsite.Location = New System.Drawing.Point(584, 81)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(298, 21)
        Me.txtWebsite.TabIndex = 170
        '
        'txtRent
        '
        Me.txtRent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRent.Location = New System.Drawing.Point(584, 106)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(298, 21)
        Me.txtRent.TabIndex = 171
        '
        'lbl_capacity
        '
        Me.lbl_capacity.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_capacity.AutoSize = True
        Me.lbl_capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_capacity.Location = New System.Drawing.Point(511, 133)
        Me.lbl_capacity.Name = "lbl_capacity"
        Me.lbl_capacity.Size = New System.Drawing.Size(67, 15)
        Me.lbl_capacity.TabIndex = 176
        Me.lbl_capacity.Text = "ความจุ (คน):"
        Me.lbl_capacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValence
        '
        Me.txtValence.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtValence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtValence.Location = New System.Drawing.Point(584, 131)
        Me.txtValence.Name = "txtValence"
        Me.txtValence.Size = New System.Drawing.Size(298, 21)
        Me.txtValence.TabIndex = 178
        '
        'lbl_note
        '
        Me.lbl_note.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_note.AutoSize = True
        Me.lbl_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_note.Location = New System.Drawing.Point(76, 193)
        Me.lbl_note.Name = "lbl_note"
        Me.lbl_note.Size = New System.Drawing.Size(55, 15)
        Me.lbl_note.TabIndex = 177
        Me.lbl_note.Text = "หมายเหตุ:"
        Me.lbl_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Setup_Place_POP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 289)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setup_Place_POP"
        Me.Text = "สถาบันฝึกอบรม"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_institution2 As System.Windows.Forms.Label
    Friend WithEvents lbl_code As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_institution1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_place As System.Windows.Forms.Label
    Friend WithEvents lbl_contact As System.Windows.Forms.Label
    Friend WithEvents lbl_email As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_phone As System.Windows.Forms.Label
    Friend WithEvents lbl_website As System.Windows.Forms.Label
    Friend WithEvents lbl_rent_place As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents txtRent As System.Windows.Forms.TextBox
    Friend WithEvents lbl_capacity As System.Windows.Forms.Label
    Friend WithEvents txtValence As System.Windows.Forms.TextBox
    Friend WithEvents lbl_note As System.Windows.Forms.Label
End Class
