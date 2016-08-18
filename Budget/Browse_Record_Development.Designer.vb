<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Browse_Record_Development
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Browse_Record_Development))
        Me.lvResult_Training = New System.Windows.Forms.ListView()
        Me.col_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Datetime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Qty_People = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvResult_Training
        '
        Me.lvResult_Training.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Id, Me.col_Code, Me.col_Datetime, Me.col_Annual, Me.col_Qty_People})
        Me.lvResult_Training.GridLines = True
        Me.lvResult_Training.Location = New System.Drawing.Point(3, 21)
        Me.lvResult_Training.Name = "lvResult_Training"
        Me.lvResult_Training.Size = New System.Drawing.Size(996, 690)
        Me.lvResult_Training.TabIndex = 634
        Me.lvResult_Training.UseCompatibleStateImageBehavior = False
        Me.lvResult_Training.View = System.Windows.Forms.View.Details
        '
        'col_Id
        '
        Me.col_Id.DisplayIndex = 4
        Me.col_Id.Width = 0
        '
        'col_Code
        '
        Me.col_Code.DisplayIndex = 0
        Me.col_Code.Text = "เลขที่เอกสาร"
        Me.col_Code.Width = 99
        '
        'col_Datetime
        '
        Me.col_Datetime.DisplayIndex = 1
        Me.col_Datetime.Text = "วันที่"
        Me.col_Datetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Datetime.Width = 120
        '
        'col_Annual
        '
        Me.col_Annual.DisplayIndex = 2
        Me.col_Annual.Text = "หลักสูตร"
        Me.col_Annual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Annual.Width = 363
        '
        'col_Qty_People
        '
        Me.col_Qty_People.DisplayIndex = 3
        Me.col_Qty_People.Text = "จำนวนผู้อบรม"
        Me.col_Qty_People.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Qty_People.Width = 413
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
        Me.ToolStrip2.TabIndex = 635
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
        'Browse_Record_Development
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lvResult_Training)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "Browse_Record_Development"
        Me.Text = "เพิ่ม/ แก้ไขบันทึกผลการฝึกอบรม"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvResult_Training As System.Windows.Forms.ListView
    Friend WithEvents col_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Datetime As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Qty_People As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cbbSearch As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents col_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
End Class
