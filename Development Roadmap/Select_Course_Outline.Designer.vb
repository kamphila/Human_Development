<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_course_outline
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Select_course_outline))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_list_development_course = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.lbl_code_development_course = New System.Windows.Forms.Label()
        Me.btnSearch_CourseName = New System.Windows.Forms.Button()
        Me.lbl_name_development_course = New System.Windows.Forms.Label()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lv_CourseMaster = New System.Windows.Forms.ListView()
        Me.col_Course_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.btnEnter = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 696)
        Me.Panel1.TabIndex = 633
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_list_development_course)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 686)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาหลักสูตรการพัฒนา"
        '
        'lbl_list_development_course
        '
        Me.lbl_list_development_course.AutoSize = True
        Me.lbl_list_development_course.BackColor = System.Drawing.Color.Transparent
        Me.lbl_list_development_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_list_development_course.Location = New System.Drawing.Point(8, 109)
        Me.lbl_list_development_course.Name = "lbl_list_development_course"
        Me.lbl_list_development_course.Size = New System.Drawing.Size(144, 15)
        Me.lbl_list_development_course.TabIndex = 639
        Me.lbl_list_development_course.Text = "รายชื่อหลักสูตรการพัฒนา"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.83051!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.16949!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtCourseCode, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_code_development_course, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSearch_CourseName, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_name_development_course, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCourseName, 1, 1)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(575, 79)
        Me.TableLayoutPanel2.TabIndex = 114
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Location = New System.Drawing.Point(138, 3)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(197, 22)
        Me.txtCourseCode.TabIndex = 115
        '
        'lbl_code_development_course
        '
        Me.lbl_code_development_course.AutoSize = True
        Me.lbl_code_development_course.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_code_development_course.Location = New System.Drawing.Point(13, 0)
        Me.lbl_code_development_course.Name = "lbl_code_development_course"
        Me.lbl_code_development_course.Size = New System.Drawing.Size(119, 28)
        Me.lbl_code_development_course.TabIndex = 0
        Me.lbl_code_development_course.Text = "รหัสหลักสูตรการพัฒนา:"
        Me.lbl_code_development_course.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch_CourseName
        '
        Me.btnSearch_CourseName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch_CourseName.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.btnSearch_CourseName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch_CourseName.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnSearch_CourseName.Location = New System.Drawing.Point(341, 31)
        Me.btnSearch_CourseName.Name = "btnSearch_CourseName"
        Me.btnSearch_CourseName.Size = New System.Drawing.Size(39, 22)
        Me.btnSearch_CourseName.TabIndex = 641
        Me.btnSearch_CourseName.UseVisualStyleBackColor = True
        '
        'lbl_name_development_course
        '
        Me.lbl_name_development_course.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_name_development_course.AutoSize = True
        Me.lbl_name_development_course.Location = New System.Drawing.Point(21, 34)
        Me.lbl_name_development_course.Name = "lbl_name_development_course"
        Me.lbl_name_development_course.Size = New System.Drawing.Size(111, 16)
        Me.lbl_name_development_course.TabIndex = 110
        Me.lbl_name_development_course.Text = "ชื่อหลักสูตรการพัฒนา:"
        Me.lbl_name_development_course.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCourseName
        '
        Me.txtCourseName.Location = New System.Drawing.Point(138, 31)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(197, 22)
        Me.txtCourseName.TabIndex = 125
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lv_CourseMaster)
        Me.Panel4.Controls.Add(Me.ToolStrip3)
        Me.Panel4.Location = New System.Drawing.Point(6, 130)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(577, 550)
        Me.Panel4.TabIndex = 638
        '
        'lv_CourseMaster
        '
        Me.lv_CourseMaster.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Course_Id, Me.col_Course_Number, Me.col_Course_Code, Me.col_Course_Name})
        Me.lv_CourseMaster.GridLines = True
        Me.lv_CourseMaster.Location = New System.Drawing.Point(3, 28)
        Me.lv_CourseMaster.Name = "lv_CourseMaster"
        Me.lv_CourseMaster.Size = New System.Drawing.Size(567, 505)
        Me.lv_CourseMaster.TabIndex = 637
        Me.lv_CourseMaster.UseCompatibleStateImageBehavior = False
        Me.lv_CourseMaster.View = System.Windows.Forms.View.Details
        '
        'col_Course_Id
        '
        Me.col_Course_Id.DisplayIndex = 3
        Me.col_Course_Id.Width = 0
        '
        'col_Course_Number
        '
        Me.col_Course_Number.DisplayIndex = 0
        Me.col_Course_Number.Text = "ลำดับ"
        Me.col_Course_Number.Width = 44
        '
        'col_Course_Code
        '
        Me.col_Course_Code.DisplayIndex = 1
        Me.col_Course_Code.Text = "รหัสหลักสูตร"
        Me.col_Course_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Code.Width = 101
        '
        'col_Course_Name
        '
        Me.col_Course_Name.DisplayIndex = 2
        Me.col_Course_Name.Text = "ชื่อหลักสูตร"
        Me.col_Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Name.Width = 420
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG3
        Me.ToolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEnter, Me.btnRefresh})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(573, 25)
        Me.ToolStrip3.TabIndex = 636
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnEnter
        '
        Me.btnEnter.Image = Global.Human_Development.My.Resources.Resources._8_26
        Me.btnEnter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(49, 22)
        Me.btnEnter.Text = "เลือก"
        Me.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 22)
        Me.btnRefresh.Text = "รีเฟรช"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(608, 25)
        Me.ToolStrip2.TabIndex = 635
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'Select_course_outline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 729)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Select_course_outline"
        Me.Text = "รายการหลักสูตรการพัฒนา"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_code_development_course As System.Windows.Forms.Label
    Friend WithEvents lbl_name_development_course As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_list_development_course As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lv_CourseMaster As System.Windows.Forms.ListView
    Friend WithEvents col_Course_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch_CourseName As System.Windows.Forms.Button
    Friend WithEvents col_Course_Id As System.Windows.Forms.ColumnHeader
End Class
