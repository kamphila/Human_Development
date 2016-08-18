<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Competency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Select_Competency))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEnter = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.lbl_group = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lvData = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.group = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.txtGroup)
        Me.GroupBox1.Controls.Add(Me.lbl_group)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lbl_name)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.lbl_code)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEnter, Me.btnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(551, 28)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Image = Global.Human_Development.My.Resources.Resources._20_26
        Me.btnEnter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(61, 25)
        Me.btnEnter.Text = "เลือก"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Human_Development.My.Resources.Resources._19_26
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 25)
        Me.btnCancel.Text = "ยกเลิก"
        '
        'txtGroup
        '
        Me.txtGroup.Location = New System.Drawing.Point(126, 107)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(293, 20)
        Me.txtGroup.TabIndex = 6
        '
        'lbl_group
        '
        Me.lbl_group.AutoSize = True
        Me.lbl_group.Location = New System.Drawing.Point(87, 110)
        Me.lbl_group.Name = "lbl_group"
        Me.lbl_group.Size = New System.Drawing.Size(27, 13)
        Me.lbl_group.TabIndex = 5
        Me.lbl_group.Text = "กลุ่ม"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(126, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(293, 20)
        Me.txtName.TabIndex = 4
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(87, 82)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(20, 13)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "ชื่อ"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(126, 53)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(172, 20)
        Me.txtCode.TabIndex = 2
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Location = New System.Drawing.Point(81, 60)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(26, 13)
        Me.lbl_code.TabIndex = 1
        Me.lbl_code.Text = "รหัส"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(450, 107)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lvData
        '
        Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.no, Me.code, Me.name, Me.group})
        Me.lvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvData.GridLines = True
        Me.lvData.Location = New System.Drawing.Point(0, 137)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(557, 371)
        Me.lvData.TabIndex = 1
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Width = 0
        '
        'no
        '
        Me.no.Text = "ลำดับ"
        Me.no.Width = 68
        '
        'code
        '
        Me.code.Text = "รหัส"
        Me.code.Width = 110
        '
        'name
        '
        Me.name.Text = "ชื่อ"
        Me.name.Width = 171
        '
        'group
        '
        Me.group.Text = "กลุ่ม"
        Me.group.Width = 203
        '
        'Select_Competency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 508)
        Me.Controls.Add(Me.lvData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Text = "เลือกความสามารถ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_code As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents lbl_group As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lvData As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents no As System.Windows.Forms.ColumnHeader
    Friend WithEvents code As System.Windows.Forms.ColumnHeader
    Friend WithEvents name As System.Windows.Forms.ColumnHeader
    Friend WithEvents group As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
End Class
