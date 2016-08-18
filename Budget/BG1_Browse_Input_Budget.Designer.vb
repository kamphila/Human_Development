<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BG1_Browse_Input_Budget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BG1_Browse_Input_Budget))
        Me.lvBudget = New System.Windows.Forms.ListView()
        Me.col_Budget_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Budget_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Budget_Datetime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Budget_Course_Master = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Budget_Qty_People = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbbSearch = New System.Windows.Forms.ToolStripComboBox()
        Me.col_Annual_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvBudget
        '
        Me.lvBudget.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Budget_Id, Me.col_Annual_id, Me.col_Budget_Code, Me.col_Budget_Datetime, Me.col_Budget_Course_Master, Me.col_Budget_Qty_People})
        Me.lvBudget.GridLines = True
        Me.lvBudget.Location = New System.Drawing.Point(3, 30)
        Me.lvBudget.Name = "lvBudget"
        Me.lvBudget.Size = New System.Drawing.Size(996, 690)
        Me.lvBudget.TabIndex = 636
        Me.lvBudget.UseCompatibleStateImageBehavior = False
        Me.lvBudget.View = System.Windows.Forms.View.Details
        '
        'col_Budget_Id
        '
        Me.col_Budget_Id.Text = "รหัสค่าใช้จ่าย"
        Me.col_Budget_Id.Width = 0
        '
        'col_Budget_Code
        '
        Me.col_Budget_Code.Text = "เลขที่เอกสาร"
        Me.col_Budget_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Budget_Code.Width = 119
        '
        'col_Budget_Datetime
        '
        Me.col_Budget_Datetime.Text = "วันที่"
        Me.col_Budget_Datetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Budget_Datetime.Width = 111
        '
        'col_Budget_Course_Master
        '
        Me.col_Budget_Course_Master.Text = "หลักสูตร"
        Me.col_Budget_Course_Master.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Budget_Course_Master.Width = 520
        '
        'col_Budget_Qty_People
        '
        Me.col_Budget_Qty_People.Text = "จำนวนผู้อบรม"
        Me.col_Budget_Qty_People.Width = 243
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnRefresh, Me.btnEdit, Me.ToolStripButton6, Me.ToolStripSeparator1, Me.btnDelete, Me.btnClose, Me.ToolStripLabel1, Me.cbbSearch})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 637
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.Human_Development.My.Resources.Resources.add26
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(45, 22)
        Me.btnAdd.Text = "เพิ่ม"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 22)
        Me.btnRefresh.Text = "รีเฟรช"
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
        'ToolStripButton6
        '
        Me.ToolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.Human_Development.My.Resources.Resources._1_26
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(40, 22)
        Me.btnDelete.Text = "ลบ"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.Human_Development.My.Resources.Resources._40_26
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel1.Text = "ค้นหา"
        '
        'cbbSearch
        '
        Me.cbbSearch.Name = "cbbSearch"
        Me.cbbSearch.Size = New System.Drawing.Size(121, 25)
        '
        'col_Annual_id
        '
        Me.col_Annual_id.Width = 0
        '
        'BG1_Browse_Input_Budget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lvBudget)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "BG1_Browse_Input_Budget"
        Me.Text = "เพิ่ม/ แก้ไขค่าใช้จ่ายการพัฒนา"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvBudget As System.Windows.Forms.ListView
    Friend WithEvents col_Budget_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Budget_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Budget_Datetime As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Budget_Course_Master As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cbbSearch As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents col_Budget_Qty_People As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_Annual_id As System.Windows.Forms.ColumnHeader
End Class
