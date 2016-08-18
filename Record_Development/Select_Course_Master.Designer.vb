<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Course_Master
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
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnEnter = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.lvCourse = New System.Windows.Forms.ListView()
        Me.col_Course_Master_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Master_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Master_DocCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEnter, Me.btnClose})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 11
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnEnter
        '
        Me.btnEnter.Image = Global.Human_Development.My.Resources.Resources._8_26
        Me.btnEnter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(49, 22)
        Me.btnEnter.Text = "เลือก"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Human_Development.My.Resources.Resources._65_26
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'lvCourse
        '
        Me.lvCourse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Course_Master_Id, Me.col_Course_Master_Number, Me.col_Course_Master_DocCode, Me.col_Course_Code, Me.col_Course_Name, Me.col_Course_Type})
        Me.lvCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCourse.GridLines = True
        Me.lvCourse.Location = New System.Drawing.Point(0, 25)
        Me.lvCourse.Name = "lvCourse"
        Me.lvCourse.Size = New System.Drawing.Size(1008, 704)
        Me.lvCourse.TabIndex = 12
        Me.lvCourse.UseCompatibleStateImageBehavior = False
        Me.lvCourse.View = System.Windows.Forms.View.Details
        '
        'col_Course_Master_Id
        '
        Me.col_Course_Master_Id.Width = 0
        '
        'col_Course_Master_Number
        '
        Me.col_Course_Master_Number.Text = "เลือก"
        Me.col_Course_Master_Number.Width = 80
        '
        'col_Course_Master_DocCode
        '
        Me.col_Course_Master_DocCode.Text = "เลขที่เอกสาร"
        Me.col_Course_Master_DocCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Master_DocCode.Width = 145
        '
        'col_Course_Code
        '
        Me.col_Course_Code.Text = "รหัสหลักสูตร"
        Me.col_Course_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Code.Width = 131
        '
        'col_Course_Name
        '
        Me.col_Course_Name.Text = "หลักสูตร"
        Me.col_Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Name.Width = 310
        '
        'col_Course_Type
        '
        Me.col_Course_Type.Text = "ประเภทหลักสูตร"
        Me.col_Course_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Type.Width = 333
        '
        'Select_Course2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lvCourse)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "Select_Course2"
        Me.Text = "เลือกหลักสูตร"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvCourse As System.Windows.Forms.ListView
    Friend WithEvents col_Course_Master_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Master_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Master_DocCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Type As System.Windows.Forms.ColumnHeader
End Class
