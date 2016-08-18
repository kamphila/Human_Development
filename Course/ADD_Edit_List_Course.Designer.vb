<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_Edit_List_Course
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_Edit_List_Course))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lv_course_master = New System.Windows.Forms.ListView()
        Me.col_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_RefNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Owner = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Dev_Skill = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = CType(resources.GetObject("ToolStrip2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnDelete, Me.btnClose})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(993, 25)
        Me.ToolStrip2.TabIndex = 9
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(45, 22)
        Me.btnAdd.Text = "เพิ่ม"
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Human_Development.My.Resources.Resources._32_20
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(52, 22)
        Me.btnEdit.Text = "แก้ไข"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(40, 22)
        Me.btnDelete.Text = "ลบ"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lv_course_master)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 704)
        Me.Panel1.TabIndex = 10
        '
        'lv_course_master
        '
        Me.lv_course_master.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_id, Me.col_No, Me.col_RefNo, Me.col_Code, Me.col_Course_Code, Me.col_Course_Name, Me.col_Owner, Me.col_Dev_Skill})
        Me.lv_course_master.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_course_master.GridLines = True
        Me.lv_course_master.Location = New System.Drawing.Point(0, 0)
        Me.lv_course_master.Name = "lv_course_master"
        Me.lv_course_master.Size = New System.Drawing.Size(989, 700)
        Me.lv_course_master.TabIndex = 0
        Me.lv_course_master.UseCompatibleStateImageBehavior = False
        Me.lv_course_master.View = System.Windows.Forms.View.Details
        '
        'col_id
        '
        Me.col_id.Width = 0
        '
        'col_No
        '
        Me.col_No.Text = "ลำดับ"
        Me.col_No.Width = 38
        '
        'col_RefNo
        '
        Me.col_RefNo.Text = "เลขที่เอกสาร"
        Me.col_RefNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_RefNo.Width = 98
        '
        'col_Code
        '
        Me.col_Code.Text = "รหัสหลักสูตร"
        Me.col_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Code.Width = 196
        '
        'col_Course_Code
        '
        Me.col_Course_Code.Text = "หลักสูตร"
        Me.col_Course_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Code.Width = 183
        '
        'col_Course_Name
        '
        Me.col_Course_Name.Text = "ประเภทหลักสูตร"
        Me.col_Course_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Name.Width = 187
        '
        'col_Owner
        '
        Me.col_Owner.Text = "หน่วยงานรับผิดชอบ"
        Me.col_Owner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Owner.Width = 154
        '
        'col_Dev_Skill
        '
        Me.col_Dev_Skill.Text = "พัฒนาความสามารถ"
        Me.col_Dev_Skill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Dev_Skill.Width = 143
        '
        'ADD_Edit_List_Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ADD_Edit_List_Course"
        Me.Text = "เพิ่ม/ แก้ไขหลักสูตรการพัฒนาบุคลากร"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lv_course_master As System.Windows.Forms.ListView
    Friend WithEvents col_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_RefNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Owner As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Dev_Skill As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_id As System.Windows.Forms.ColumnHeader
End Class
