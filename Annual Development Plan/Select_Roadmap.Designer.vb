<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Roadmap
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
        Me.lvRoadmap = New System.Windows.Forms.ListView()
        Me.col_RoadMap_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Master = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_DocCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmpa_Course = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_CourseName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Position_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.btnEnter.Size = New System.Drawing.Size(51, 22)
        Me.btnEnter.Text = "เลือก"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Human_Development.My.Resources.Resources._65_26
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(78, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'lvRoadmap
        '
        Me.lvRoadmap.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_RoadMap_Id, Me.col_Course_Master, Me.col_Roadmap_Position, Me.col_Roadmap_Number, Me.col_Roadmap_DocCode, Me.col_Roadmap_Date, Me.col_Roadmpa_Course, Me.col_Roadmap_CourseName, Me.col_Roadmap_Position_Name})
        Me.lvRoadmap.GridLines = True
        Me.lvRoadmap.Location = New System.Drawing.Point(12, 21)
        Me.lvRoadmap.Name = "lvRoadmap"
        Me.lvRoadmap.Size = New System.Drawing.Size(984, 686)
        Me.lvRoadmap.TabIndex = 12
        Me.lvRoadmap.UseCompatibleStateImageBehavior = False
        Me.lvRoadmap.View = System.Windows.Forms.View.Details
        '
        'col_RoadMap_Id
        '
        Me.col_RoadMap_Id.Width = 0
        '
        'col_Course_Master
        '
        Me.col_Course_Master.Width = 0
        '
        'col_Roadmap_Position
        '
        Me.col_Roadmap_Position.Width = 0
        '
        'col_Roadmap_Number
        '
        Me.col_Roadmap_Number.Text = "เลือก"
        Me.col_Roadmap_Number.Width = 69
        '
        'col_Roadmap_DocCode
        '
        Me.col_Roadmap_DocCode.Text = "เลขที่เอกสาร"
        Me.col_Roadmap_DocCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_DocCode.Width = 113
        '
        'col_Roadmap_Date
        '
        Me.col_Roadmap_Date.Text = "วันที่สร้าง"
        Me.col_Roadmap_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Date.Width = 88
        '
        'col_Roadmpa_Course
        '
        Me.col_Roadmpa_Course.Text = "รหัสหลักสูตร"
        Me.col_Roadmpa_Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmpa_Course.Width = 113
        '
        'col_Roadmap_CourseName
        '
        Me.col_Roadmap_CourseName.Text = "หลักสูตร"
        Me.col_Roadmap_CourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_CourseName.Width = 300
        '
        'col_Roadmap_Position_Name
        '
        Me.col_Roadmap_Position_Name.Text = "ตำแหน่ง"
        Me.col_Roadmap_Position_Name.Width = 141
        '
        'Select_Roadmap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lvRoadmap)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "Select_Roadmap"
        Me.Text = "เลือกแผนพัฒนารายตำแหน่ง"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvRoadmap As System.Windows.Forms.ListView
    Friend WithEvents col_RoadMap_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_DocCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmpa_Course As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_CourseName As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Position_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Master As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Position As System.Windows.Forms.ColumnHeader
End Class
