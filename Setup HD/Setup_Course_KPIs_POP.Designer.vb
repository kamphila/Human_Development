<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup_Course_KPIs_POP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup_Course_KPIs_POP))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.lbl_kpi_course1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbl_kpi_course2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_note = New System.Windows.Forms.Label()
        Me.lbl_origin_kpi = New System.Windows.Forms.Label()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackgroundImage = CType(resources.GetObject("ToolStrip2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnClear, Me.btnClose})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(734, 25)
        Me.ToolStrip2.TabIndex = 100
        Me.ToolStrip2.Text = "ToolStrip2"
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
        'lbl_kpi_course1
        '
        Me.lbl_kpi_course1.AutoSize = True
        Me.lbl_kpi_course1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_kpi_course1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_kpi_course1.Location = New System.Drawing.Point(3, 26)
        Me.lbl_kpi_course1.Name = "lbl_kpi_course1"
        Me.lbl_kpi_course1.Size = New System.Drawing.Size(205, 26)
        Me.lbl_kpi_course1.TabIndex = 101
        Me.lbl_kpi_course1.Text = "ชื่อตัวชี้วัดหลักสูตร (ภาษา 1):"
        Me.lbl_kpi_course1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(214, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(344, 21)
        Me.txtName.TabIndex = 103
        '
        'lbl_kpi_course2
        '
        Me.lbl_kpi_course2.AutoSize = True
        Me.lbl_kpi_course2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_kpi_course2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_kpi_course2.Location = New System.Drawing.Point(3, 52)
        Me.lbl_kpi_course2.Name = "lbl_kpi_course2"
        Me.lbl_kpi_course2.Size = New System.Drawing.Size(205, 25)
        Me.lbl_kpi_course2.TabIndex = 104
        Me.lbl_kpi_course2.Text = "ชื่อตัวชี้วัดหลักสูตร (ภาษา 2):"
        Me.lbl_kpi_course2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCode
        '
        Me.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCode.Location = New System.Drawing.Point(214, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(150, 21)
        Me.txtCode.TabIndex = 102
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_code.Location = New System.Drawing.Point(3, 0)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(205, 26)
        Me.lbl_code.TabIndex = 105
        Me.lbl_code.Text = "รหัส :"
        Me.lbl_code.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 173)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.98876!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.01124!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_note, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_origin_kpi, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_code, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_kpi_course2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_kpi_course1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCode, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSource, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDesc, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.4902!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.4902!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5098!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5098!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(728, 170)
        Me.TableLayoutPanel1.TabIndex = 107
        '
        'lbl_note
        '
        Me.lbl_note.AutoSize = True
        Me.lbl_note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_note.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_note.Location = New System.Drawing.Point(3, 102)
        Me.lbl_note.Name = "lbl_note"
        Me.lbl_note.Size = New System.Drawing.Size(205, 68)
        Me.lbl_note.TabIndex = 144
        Me.lbl_note.Text = "คำอธิบาย:"
        Me.lbl_note.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_origin_kpi
        '
        Me.lbl_origin_kpi.AutoSize = True
        Me.lbl_origin_kpi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_origin_kpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_origin_kpi.Location = New System.Drawing.Point(3, 77)
        Me.lbl_origin_kpi.Name = "lbl_origin_kpi"
        Me.lbl_origin_kpi.Size = New System.Drawing.Size(205, 25)
        Me.lbl_origin_kpi.TabIndex = 143
        Me.lbl_origin_kpi.Text = "ที่มาตัวชี้วัด:"
        Me.lbl_origin_kpi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtName2
        '
        Me.txtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName2.Location = New System.Drawing.Point(214, 55)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(344, 21)
        Me.txtName2.TabIndex = 104
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(214, 80)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(344, 20)
        Me.txtSource.TabIndex = 105
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(214, 105)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(398, 61)
        Me.txtDesc.TabIndex = 106
        '
        'Setup_Course_KPIs_POP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 278)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setup_Course_KPIs_POP"
        Me.Text = "เพิ่ม/ แก้ไขตัวชี้วัดหลักสูตรการพัฒนา"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_kpi_course1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_kpi_course2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_code As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents lbl_note As System.Windows.Forms.Label
    Friend WithEvents lbl_origin_kpi As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
End Class
