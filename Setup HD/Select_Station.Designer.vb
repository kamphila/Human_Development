<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Station
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Select_Station))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEnter = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.cbo_stationType = New System.Windows.Forms.ComboBox()
        Me.lbl_select_department = New System.Windows.Forms.Label()
        Me.lv_Data = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Name2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip1)
        Me.GroupBox1.Controls.Add(Me.cbo_stationType)
        Me.GroupBox1.Controls.Add(Me.lbl_select_department)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEnter, Me.btnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(517, 28)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Image = Global.Human_Development.My.Resources.Resources._20_26
        Me.btnEnter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(60, 25)
        Me.btnEnter.Text = "เลือก"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Human_Development.My.Resources.Resources._19_26
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 25)
        Me.btnCancel.Text = "ยกเลิก"
        '
        'cbo_stationType
        '
        Me.cbo_stationType.FormattingEnabled = True
        Me.cbo_stationType.Location = New System.Drawing.Point(156, 62)
        Me.cbo_stationType.Name = "cbo_stationType"
        Me.cbo_stationType.Size = New System.Drawing.Size(303, 21)
        Me.cbo_stationType.TabIndex = 1
        '
        'lbl_select_department
        '
        Me.lbl_select_department.AutoSize = True
        Me.lbl_select_department.Location = New System.Drawing.Point(35, 62)
        Me.lbl_select_department.Name = "lbl_select_department"
        Me.lbl_select_department.Size = New System.Drawing.Size(102, 13)
        Me.lbl_select_department.TabIndex = 0
        Me.lbl_select_department.Text = "เลือกระดับหน่วยงาน"
        '
        'lv_Data
        '
        Me.lv_Data.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.No, Me.Code, Me.Name, Me.Name2})
        Me.lv_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Data.GridLines = True
        Me.lv_Data.Location = New System.Drawing.Point(3, 16)
        Me.lv_Data.Name = "lv_Data"
        Me.lv_Data.Size = New System.Drawing.Size(517, 341)
        Me.lv_Data.TabIndex = 1
        Me.lv_Data.UseCompatibleStateImageBehavior = False
        Me.lv_Data.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Width = 0
        '
        'No
        '
        Me.No.Text = "ลำดับ"
        '
        'Code
        '
        Me.Code.Text = "รหัสหน่วยงาน"
        Me.Code.Width = 109
        '
        'Name
        '
        Me.Name.Text = "Select_Station"
        Me.Name.Width = 340
        '
        'Name2
        '
        Me.Name2.Text = "ชื่อ 2"
        Me.Name2.Width = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lv_Data)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 360)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Select_Station
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 458)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_stationType As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_select_department As System.Windows.Forms.Label
    Friend WithEvents lv_Data As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Name2 As System.Windows.Forms.ColumnHeader
End Class
