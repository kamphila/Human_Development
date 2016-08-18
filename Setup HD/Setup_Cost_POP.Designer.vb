<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup_Cost_POP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup_Cost_POP))
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_note = New System.Windows.Forms.Label()
        Me.lbl_expenses2 = New System.Windows.Forms.Label()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lbl_expenses1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripButton3.Text = "บันทึก"
        Me.ToolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton7.Text = "ล้างข้อมูล"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripButton8.Text = "ปิดหน้าต่าง"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 173)
        Me.GroupBox1.TabIndex = 640
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.79585!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.20415!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_note, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_expenses2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_code, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCode, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_expenses1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDesc, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.55814!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.73494!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.73494!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(728, 157)
        Me.TableLayoutPanel1.TabIndex = 130
        '
        'lbl_note
        '
        Me.lbl_note.AutoSize = True
        Me.lbl_note.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_note.Location = New System.Drawing.Point(169, 83)
        Me.lbl_note.Name = "lbl_note"
        Me.lbl_note.Size = New System.Drawing.Size(52, 74)
        Me.lbl_note.TabIndex = 127
        Me.lbl_note.Text = "หมายเหตุ"
        Me.lbl_note.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_expenses2
        '
        Me.lbl_expenses2.AutoSize = True
        Me.lbl_expenses2.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_expenses2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_expenses2.Location = New System.Drawing.Point(109, 55)
        Me.lbl_expenses2.Name = "lbl_expenses2"
        Me.lbl_expenses2.Size = New System.Drawing.Size(112, 28)
        Me.lbl_expenses2.TabIndex = 125
        Me.lbl_expenses2.Text = "ชื่อค่าใช้จ่าย (ภาษา 2):"
        Me.lbl_expenses2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_code.Location = New System.Drawing.Point(189, 0)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(32, 27)
        Me.lbl_code.TabIndex = 121
        Me.lbl_code.Text = "รหัส :"
        Me.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Location = New System.Drawing.Point(227, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(150, 21)
        Me.txtCode.TabIndex = 122
        '
        'lbl_expenses1
        '
        Me.lbl_expenses1.AutoSize = True
        Me.lbl_expenses1.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_expenses1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_expenses1.Location = New System.Drawing.Point(109, 27)
        Me.lbl_expenses1.Name = "lbl_expenses1"
        Me.lbl_expenses1.Size = New System.Drawing.Size(112, 28)
        Me.lbl_expenses1.TabIndex = 123
        Me.lbl_expenses1.Text = "ชื่อค่าใช้จ่าย (ภาษา 1):"
        Me.lbl_expenses1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(227, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(344, 21)
        Me.txtName.TabIndex = 124
        '
        'txtName2
        '
        Me.txtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName2.Location = New System.Drawing.Point(227, 58)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(344, 21)
        Me.txtName2.TabIndex = 126
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(227, 86)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(398, 68)
        Me.txtDesc.TabIndex = 128
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnClear, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(734, 25)
        Me.ToolStrip1.TabIndex = 644
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Human_Development.My.Resources.Resources._9_26
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
        'Setup_Cost_POP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 210)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setup_Cost_POP"
        Me.Text = "เพิ่ม/ แก้ไขค่าใช้จ่ายการพัฒนา"
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_code As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_expenses1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_expenses2 As System.Windows.Forms.Label
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_note As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
End Class
