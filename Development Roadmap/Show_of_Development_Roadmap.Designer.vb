<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_of_Development_Roadmap
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "G-002", "ความรู้เกี่ยวกับบริษัทและวัฒนธรรมองค์กร", "ฝึกอบรมภายใน", "@"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "G-003", "การทำงานเป็นทีม", "OJT", "", "@"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "G-004", "การติดต่อประสานงาน", "ฝึกอบรมภายใน", "", "", "@"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "G-005", "ภาษาอังกฤษเพื่อการพูด", "ฝึกอบรมภายนอก", "", "", "", "@"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "G-006", "ภาษาอังกฤษเพื่อการเขียน", "ฝึกอบรมภายนอก", "", "", "", "", "@"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "M-008", "การแก้ไขปัญหาและการตัดสินใจ", "ฝึกอบรมภายใน", "", "", "", "", "@"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "G-010", "จิตสำนึกในการให้บริการ", "ฝึกอบรมภายใน", "", "@"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"", "", "G-011", "ทักษะการเสนอขาย", "Coaching", "", "", "@"}, -1)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPositionName = New System.Windows.Forms.Button()
        Me.txtPositionName = New System.Windows.Forms.TextBox()
        Me.cbbStationName = New System.Windows.Forms.ComboBox()
        Me.lbl_search_position = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lvRoadmapPosition = New System.Windows.Forms.ListView()
        Me.col_Roadmap_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_CourseId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_CourseName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Training = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Year10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_month = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_path_of_progress = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnPositionName)
        Me.Panel1.Controls.Add(Me.txtPositionName)
        Me.Panel1.Controls.Add(Me.cbbStationName)
        Me.Panel1.Controls.Add(Me.lbl_search_position)
        Me.Panel1.Location = New System.Drawing.Point(9, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 58)
        Me.Panel1.TabIndex = 0
        '
        'btnPositionName
        '
        Me.btnPositionName.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.btnPositionName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPositionName.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnPositionName.Location = New System.Drawing.Point(485, 18)
        Me.btnPositionName.Name = "btnPositionName"
        Me.btnPositionName.Size = New System.Drawing.Size(39, 24)
        Me.btnPositionName.TabIndex = 653
        Me.btnPositionName.UseVisualStyleBackColor = True
        '
        'txtPositionName
        '
        Me.txtPositionName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPositionName.Location = New System.Drawing.Point(304, 19)
        Me.txtPositionName.Name = "txtPositionName"
        Me.txtPositionName.Size = New System.Drawing.Size(180, 22)
        Me.txtPositionName.TabIndex = 652
        '
        'cbbStationName
        '
        Me.cbbStationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbbStationName.FormattingEnabled = True
        Me.cbbStationName.Items.AddRange(New Object() {"รหัสตำแหน่งมาตรฐาน", "ชื่อตำแหน่งมาตรฐาน"})
        Me.cbbStationName.Location = New System.Drawing.Point(138, 19)
        Me.cbbStationName.Name = "cbbStationName"
        Me.cbbStationName.Size = New System.Drawing.Size(160, 24)
        Me.cbbStationName.TabIndex = 651
        '
        'lbl_search_position
        '
        Me.lbl_search_position.AutoSize = True
        Me.lbl_search_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_search_position.Location = New System.Drawing.Point(38, 23)
        Me.lbl_search_position.Name = "lbl_search_position"
        Me.lbl_search_position.Size = New System.Drawing.Size(98, 16)
        Me.lbl_search_position.TabIndex = 650
        Me.lbl_search_position.Text = "ค้นหาตำแหน่งงาน :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lvRoadmapPosition)
        Me.Panel2.Location = New System.Drawing.Point(9, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(987, 574)
        Me.Panel2.TabIndex = 1
        '
        'lvRoadmapPosition
        '
        Me.lvRoadmapPosition.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lvRoadmapPosition.AllowColumnReorder = True
        Me.lvRoadmapPosition.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvRoadmapPosition.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Roadmap_Id, Me.col_Roadmap_Number, Me.col_Roadmap_CourseId, Me.col_Roadmap_CourseName, Me.col_Roadmap_Training, Me.col_Roadmap_Year1, Me.col_Roadmap_Year2, Me.col_Roadmap_Year3, Me.col_Roadmap_Year4, Me.col_Roadmap_Year5, Me.col_Roadmap_Year6, Me.col_Roadmap_Year7, Me.col_Roadmap_Year8, Me.col_Roadmap_Year9, Me.col_Roadmap_Year10, Me.col_Roadmap_month})
        Me.lvRoadmapPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lvRoadmapPosition.GridLines = True
        Me.lvRoadmapPosition.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.lvRoadmapPosition.Location = New System.Drawing.Point(2, 3)
        Me.lvRoadmapPosition.Name = "lvRoadmapPosition"
        Me.lvRoadmapPosition.Size = New System.Drawing.Size(978, 564)
        Me.lvRoadmapPosition.TabIndex = 647
        Me.lvRoadmapPosition.UseCompatibleStateImageBehavior = False
        Me.lvRoadmapPosition.View = System.Windows.Forms.View.Details
        '
        'col_Roadmap_Id
        '
        Me.col_Roadmap_Id.Width = 0
        '
        'col_Roadmap_Number
        '
        Me.col_Roadmap_Number.Text = "ลำดับ"
        Me.col_Roadmap_Number.Width = 40
        '
        'col_Roadmap_CourseId
        '
        Me.col_Roadmap_CourseId.Text = "รหัสหลักสูตร"
        Me.col_Roadmap_CourseId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_CourseId.Width = 74
        '
        'col_Roadmap_CourseName
        '
        Me.col_Roadmap_CourseName.Text = "ชื่อหลักสูตร"
        Me.col_Roadmap_CourseName.Width = 235
        '
        'col_Roadmap_Training
        '
        Me.col_Roadmap_Training.Text = "วิธีดำเนินการ"
        Me.col_Roadmap_Training.Width = 122
        '
        'col_Roadmap_Year1
        '
        Me.col_Roadmap_Year1.Text = "ปีที่ 1"
        Me.col_Roadmap_Year1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year1.Width = 44
        '
        'col_Roadmap_Year2
        '
        Me.col_Roadmap_Year2.Text = "ปีที่ 2"
        Me.col_Roadmap_Year2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year2.Width = 43
        '
        'col_Roadmap_Year3
        '
        Me.col_Roadmap_Year3.Text = "ปีที่ 3"
        Me.col_Roadmap_Year3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year3.Width = 40
        '
        'col_Roadmap_Year4
        '
        Me.col_Roadmap_Year4.Text = "ปีที่ 4"
        Me.col_Roadmap_Year4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year4.Width = 47
        '
        'col_Roadmap_Year5
        '
        Me.col_Roadmap_Year5.Text = "ปีที่ 5"
        Me.col_Roadmap_Year5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year5.Width = 54
        '
        'col_Roadmap_Year6
        '
        Me.col_Roadmap_Year6.Text = "ปีที่ 6"
        Me.col_Roadmap_Year6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year6.Width = 45
        '
        'col_Roadmap_Year7
        '
        Me.col_Roadmap_Year7.Text = "ปีที่ 7"
        Me.col_Roadmap_Year7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year7.Width = 40
        '
        'col_Roadmap_Year8
        '
        Me.col_Roadmap_Year8.Text = "ปีที่ 8"
        Me.col_Roadmap_Year8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year8.Width = 45
        '
        'col_Roadmap_Year9
        '
        Me.col_Roadmap_Year9.Text = "ปีที่ 9"
        Me.col_Roadmap_Year9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year9.Width = 42
        '
        'col_Roadmap_Year10
        '
        Me.col_Roadmap_Year10.Text = "ปีที่ 10"
        Me.col_Roadmap_Year10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Year10.Width = 45
        '
        'col_Roadmap_month
        '
        Me.col_Roadmap_month.Text = "เดือน"
        '
        'lbl_path_of_progress
        '
        Me.lbl_path_of_progress.AutoSize = True
        Me.lbl_path_of_progress.BackColor = System.Drawing.Color.Transparent
        Me.lbl_path_of_progress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_path_of_progress.ForeColor = System.Drawing.Color.White
        Me.lbl_path_of_progress.Location = New System.Drawing.Point(12, 92)
        Me.lbl_path_of_progress.Name = "lbl_path_of_progress"
        Me.lbl_path_of_progress.Size = New System.Drawing.Size(182, 16)
        Me.lbl_path_of_progress.TabIndex = 649
        Me.lbl_path_of_progress.Text = "รายละเอียดเส้นทางความก้าวหน้า"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.ToolStrip2)
        Me.Panel3.Location = New System.Drawing.Point(9, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(987, 31)
        Me.Panel3.TabIndex = 650
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(983, 27)
        Me.ToolStrip2.TabIndex = 115
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 24)
        Me.btnRefresh.Text = "รีเฟรช"
        '
        'Show_of_Development_Roadmap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lbl_path_of_progress)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Show_of_Development_Roadmap"
        Me.Text = "แสดงเส้นทางการพัฒนาบุคลากรตามตำแหน่งงาน"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_path_of_progress As System.Windows.Forms.Label
    Friend WithEvents lvRoadmapPosition As System.Windows.Forms.ListView
    Friend WithEvents col_Roadmap_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_CourseId As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_CourseName As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Training As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPositionName As System.Windows.Forms.Button
    Friend WithEvents cbbStationName As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_search_position As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_Roadmap_Year6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Year10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPositionName As System.Windows.Forms.TextBox
    Friend WithEvents col_Roadmap_month As System.Windows.Forms.ColumnHeader
End Class
