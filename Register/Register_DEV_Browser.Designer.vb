<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_DEV_Browser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_DEV_Browser))
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.lvRegister = New System.Windows.Forms.ListView()
        Me.col_Register_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Register_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Register_Datetime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Course_Master = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Qty_People = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        '
        'lvRegister
        '
        Me.lvRegister.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Register_Id, Me.col_Annual_id, Me.col_Register_Code, Me.col_Register_Datetime, Me.col_Course_Master, Me.col_Annual_Qty_People})
        Me.lvRegister.FullRowSelect = True
        Me.lvRegister.GridLines = True
        Me.lvRegister.Location = New System.Drawing.Point(3, 28)
        Me.lvRegister.Name = "lvRegister"
        Me.lvRegister.Size = New System.Drawing.Size(996, 696)
        Me.lvRegister.TabIndex = 638
        Me.lvRegister.UseCompatibleStateImageBehavior = False
        Me.lvRegister.View = System.Windows.Forms.View.Details
        '
        'col_Register_Id
        '
        Me.col_Register_Id.Text = "รหัสค่าใช้จ่าย"
        Me.col_Register_Id.Width = 0
        '
        'col_Annual_id
        '
        Me.col_Annual_id.Width = 0
        '
        'col_Register_Code
        '
        Me.col_Register_Code.Text = "เลขที่เอกสาร"
        Me.col_Register_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Register_Code.Width = 119
        '
        'col_Register_Datetime
        '
        Me.col_Register_Datetime.Text = "วันที่"
        Me.col_Register_Datetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Register_Datetime.Width = 111
        '
        'col_Course_Master
        '
        Me.col_Course_Master.Text = "หลักสูตร"
        Me.col_Course_Master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Course_Master.Width = 520
        '
        'col_Annual_Qty_People
        '
        Me.col_Annual_Qty_People.Text = "จำนวนผู้อบรม"
        Me.col_Annual_Qty_People.Width = 243
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnEdit
        '
        Me.btnEdit.Image = Global.Human_Development.My.Resources.Resources._32_26
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(52, 22)
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.ToolTipText = "แก้ไข"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Human_Development.My.Resources.Resources._1_26
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(40, 22)
        Me.btnDelete.Text = "ลบ"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 22)
        Me.btnRefresh.Text = "รีเฟรช"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Human_Development.My.Resources.Resources._40_26
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Human_Development.My.Resources.Resources.add26
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(45, 22)
        Me.btnAdd.Text = "เพิ่ม"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnRefresh, Me.btnEdit, Me.ToolStripButton6, Me.ToolStripSeparator1, Me.btnDelete, Me.btnClose})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 639
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Register_DEV_Browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lvRegister)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "Register_DEV_Browser"
        Me.Text = "เพิ่ม/ แก้ไข การลงทะเบียนเข้าร่วมการพัฒนา"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvRegister As System.Windows.Forms.ListView
    Friend WithEvents col_Register_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Register_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Register_Datetime As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Course_Master As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Qty_People As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
End Class
