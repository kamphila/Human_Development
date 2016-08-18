<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_of_Development_Competency
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvCourse_Competency = New System.Windows.Forms.ListView()
        Me.col_Course_Master_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Master_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Master_Competency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCompentency = New System.Windows.Forms.Button()
        Me.txtCompentency_Name = New System.Windows.Forms.TextBox()
        Me.lbl_search_capacity = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lvCourse_Competency)
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Location = New System.Drawing.Point(16, 71)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 494)
        Me.Panel1.TabIndex = 0
        '
        'lvCourse_Competency
        '
        Me.lvCourse_Competency.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Course_Master_Id, Me.col_Course_Master_Number, Me.col_Course_Id, Me.col_Course_Name, Me.col_Course_Master_Competency, Me.ColumnHeader5})
        Me.lvCourse_Competency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvCourse_Competency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lvCourse_Competency.GridLines = True
        Me.lvCourse_Competency.Location = New System.Drawing.Point(0, 25)
        Me.lvCourse_Competency.Margin = New System.Windows.Forms.Padding(4)
        Me.lvCourse_Competency.Name = "lvCourse_Competency"
        Me.lvCourse_Competency.Size = New System.Drawing.Size(1107, 465)
        Me.lvCourse_Competency.TabIndex = 632
        Me.lvCourse_Competency.UseCompatibleStateImageBehavior = False
        Me.lvCourse_Competency.View = System.Windows.Forms.View.Details
        '
        'col_Course_Master_Id
        '
        Me.col_Course_Master_Id.Width = 0
        '
        'col_Course_Master_Number
        '
        Me.col_Course_Master_Number.Text = "ลำดับ"
        Me.col_Course_Master_Number.Width = 38
        '
        'col_Course_Id
        '
        Me.col_Course_Id.Text = "รหัสหลักสูตรการพัฒนา"
        Me.col_Course_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Id.Width = 122
        '
        'col_Course_Name
        '
        Me.col_Course_Name.Text = "ชื่อหลักสูตรการพัฒนา"
        Me.col_Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Name.Width = 215
        '
        'col_Course_Master_Competency
        '
        Me.col_Course_Master_Competency.Text = "ชื่อขีดความสามารถ"
        Me.col_Course_Master_Competency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Master_Competency.Width = 288
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "กลุ่มขีดความสามารถ"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 143
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnRefresh})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1107, 25)
        Me.ToolStrip2.TabIndex = 631
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnCompentency)
        Me.Panel2.Controls.Add(Me.txtCompentency_Name)
        Me.Panel2.Controls.Add(Me.lbl_search_capacity)
        Me.Panel2.Location = New System.Drawing.Point(18, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(987, 58)
        Me.Panel2.TabIndex = 1
        '
        'btnCompentency
        '
        Me.btnCompentency.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.btnCompentency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCompentency.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnCompentency.Location = New System.Drawing.Point(330, 19)
        Me.btnCompentency.Name = "btnCompentency"
        Me.btnCompentency.Size = New System.Drawing.Size(39, 24)
        Me.btnCompentency.TabIndex = 653
        Me.btnCompentency.UseVisualStyleBackColor = True
        '
        'txtCompentency_Name
        '
        Me.txtCompentency_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompentency_Name.Location = New System.Drawing.Point(149, 20)
        Me.txtCompentency_Name.Name = "txtCompentency_Name"
        Me.txtCompentency_Name.Size = New System.Drawing.Size(180, 22)
        Me.txtCompentency_Name.TabIndex = 652
        '
        'lbl_search_capacity
        '
        Me.lbl_search_capacity.AutoSize = True
        Me.lbl_search_capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_search_capacity.Location = New System.Drawing.Point(12, 23)
        Me.lbl_search_capacity.Name = "lbl_search_capacity"
        Me.lbl_search_capacity.Size = New System.Drawing.Size(135, 16)
        Me.lbl_search_capacity.TabIndex = 650
        Me.lbl_search_capacity.Text = "ค้นหาตามขีดความสามารถ :"
        '
        'Show_of_Development_Competency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1144, 576)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Show_of_Development_Competency"
        Me.Text = "แสดงรายการหลักสูตรพัฒนาตามขีดความสามารถ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lvCourse_Competency As System.Windows.Forms.ListView
    Friend WithEvents col_Course_Master_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Master_Competency As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCompentency As System.Windows.Forms.Button
    Friend WithEvents txtCompentency_Name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_search_capacity As System.Windows.Forms.Label
    Friend WithEvents col_Course_Master_Id As System.Windows.Forms.ColumnHeader
End Class
