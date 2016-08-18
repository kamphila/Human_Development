<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_Edit_Annual_Position_Browse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_Edit_Annual_Position_Browse))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.lvAnnual_Master = New System.Windows.Forms.ListView()
        Me.col_Annual_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Course = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Main_Hour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Edition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Year = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.lvAnnual_Master)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 666)
        Me.GroupBox2.TabIndex = 629
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "หลักสูตรการพัฒนาบุคลากรประจำปี"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnRefresh, Me.btnEdit, Me.btnDelete, Me.ToolStripButton7, Me.ToolStripSeparator1, Me.btnClose})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1002, 25)
        Me.ToolStrip2.TabIndex = 629
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.Image = Global.Human_Development.My.Resources.Resources.add26
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(23, 22)
        Me.btnAdd.Text = "เพิ่ม"
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnRefresh.Text = "รีเฟรช"
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = Global.Human_Development.My.Resources.Resources._32_26
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(23, 22)
        Me.btnEdit.Text = "แก้ไข"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = Global.Human_Development.My.Resources.Resources.deleate26
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnDelete.Text = "ลบ"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'lvAnnual_Master
        '
        Me.lvAnnual_Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvAnnual_Master.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Annual_Id, Me.col_Annual_Number, Me.col_Annual_Code, Me.col_Annual_Date, Me.col_Annual_Course, Me.col_Annual_Main_Hour, Me.col_Annual_Edition, Me.col_Annual_Position, Me.col_Annual_Year})
        Me.lvAnnual_Master.GridLines = True
        Me.lvAnnual_Master.Location = New System.Drawing.Point(6, 47)
        Me.lvAnnual_Master.Name = "lvAnnual_Master"
        Me.lvAnnual_Master.Size = New System.Drawing.Size(996, 581)
        Me.lvAnnual_Master.TabIndex = 0
        Me.lvAnnual_Master.UseCompatibleStateImageBehavior = False
        Me.lvAnnual_Master.View = System.Windows.Forms.View.Details
        '
        'col_Annual_Id
        '
        Me.col_Annual_Id.Width = 0
        '
        'col_Annual_Number
        '
        Me.col_Annual_Number.Text = "ลำดับ"
        Me.col_Annual_Number.Width = 57
        '
        'col_Annual_Code
        '
        Me.col_Annual_Code.Text = "เลขที่เอกสาร"
        Me.col_Annual_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Code.Width = 98
        '
        'col_Annual_Date
        '
        Me.col_Annual_Date.Text = "วันที่เอกสาร"
        Me.col_Annual_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Date.Width = 77
        '
        'col_Annual_Course
        '
        Me.col_Annual_Course.Text = "หลักสูตรการพัฒนา"
        Me.col_Annual_Course.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Course.Width = 160
        '
        'col_Annual_Main_Hour
        '
        Me.col_Annual_Main_Hour.Text = "ระยะเวลาในการพัฒนา/ชม."
        Me.col_Annual_Main_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Main_Hour.Width = 165
        '
        'col_Annual_Edition
        '
        Me.col_Annual_Edition.Text = "รุ่นที่"
        Me.col_Annual_Edition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Edition.Width = 64
        '
        'col_Annual_Position
        '
        Me.col_Annual_Position.Text = "ตำแหน่ง"
        Me.col_Annual_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Position.Width = 135
        '
        'col_Annual_Year
        '
        Me.col_Annual_Year.Text = "ปีที่"
        Me.col_Annual_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual_Year.Width = 56
        '
        'ADD_Edit_Annual_Position_Browse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ADD_Edit_Annual_Position_Browse"
        Me.Text = "แผนการพัฒนาประจำปี"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lvAnnual_Master As System.Windows.Forms.ListView
    Friend WithEvents col_Annual_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Course As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Main_Hour As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Edition As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Position As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_Annual_Year As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
End Class
