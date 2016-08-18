<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Annual
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
        Me.lvAnnual = New System.Windows.Forms.ListView()
        Me.col_Annual_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Course = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Course_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Main_Hour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Edition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.ToolStrip2.Size = New System.Drawing.Size(813, 25)
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
        'lvAnnual
        '
        Me.lvAnnual.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Annual_Id, Me.col_Annual_Course, Me.col_Annual_Code, Me.col_Annual_Date, Me.col_Annual_Course_Name, Me.col_Annual_Main_Hour, Me.col_Annual_Edition, Me.col_Annual_Year})
        Me.lvAnnual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvAnnual.GridLines = True
        Me.lvAnnual.Location = New System.Drawing.Point(0, 25)
        Me.lvAnnual.Name = "lvAnnual"
        Me.lvAnnual.Size = New System.Drawing.Size(813, 421)
        Me.lvAnnual.TabIndex = 12
        Me.lvAnnual.UseCompatibleStateImageBehavior = False
        Me.lvAnnual.View = System.Windows.Forms.View.Details
        '
        'col_Annual_Id
        '
        Me.col_Annual_Id.Width = 0
        '
        'col_Annual_Course
        '
        Me.col_Annual_Course.Width = 0
        '
        'col_Annual_Code
        '
        Me.col_Annual_Code.Text = "เลขที่เอกสาร"
        Me.col_Annual_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Code.Width = 94
        '
        'col_Annual_Date
        '
        Me.col_Annual_Date.Text = "วันที่เอกสาร"
        Me.col_Annual_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Date.Width = 115
        '
        'col_Annual_Course_Name
        '
        Me.col_Annual_Course_Name.Text = "หลักสูตรการพัฒนา"
        Me.col_Annual_Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Course_Name.Width = 300
        '
        'col_Annual_Main_Hour
        '
        Me.col_Annual_Main_Hour.Text = "ระยะเวลาในการพัฒนา/ชม."
        Me.col_Annual_Main_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Main_Hour.Width = 151
        '
        'col_Annual_Edition
        '
        Me.col_Annual_Edition.Text = "รุ่นที่"
        Me.col_Annual_Edition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Edition.Width = 77
        '
        'col_Annual_Year
        '
        Me.col_Annual_Year.Text = "ปีที่"
        Me.col_Annual_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Year.Width = 88
        '
        'Select_Annual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 446)
        Me.Controls.Add(Me.lvAnnual)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "Select_Annual"
        Me.Text = "เลือกแผนพัฒนาประจำปี"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvAnnual As System.Windows.Forms.ListView
    Friend WithEvents col_Annual_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Course_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Main_Hour As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Edition As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Year As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Course As System.Windows.Forms.ColumnHeader
End Class
