<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Edit_Roadmap_Browse
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
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Edit_Roadmap_Browse))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvRoadmap_Master = New System.Windows.Forms.ListView()
        Me.col_Roadmap_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Date = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Roadmap_Affiliated_Agencies = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_search_position = New System.Windows.Forms.Label()
        Me.lbl_search_station = New System.Windows.Forms.Label()
        Me.txtAffiliatedAgencies = New System.Windows.Forms.TextBox()
        Me.btnPopAffiliatedAgencies = New System.Windows.Forms.Button()
        Me.btn_position = New System.Windows.Forms.Button()
        Me.lbl_capacity = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.btnPopPosition = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(2, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1337, 658)
        Me.Panel3.TabIndex = 645
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lvRoadmap_Master)
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1327, 648)
        Me.Panel1.TabIndex = 638
        '
        'lvRoadmap_Master
        '
        Me.lvRoadmap_Master.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Roadmap_Id, Me.col_Roadmap_Code, Me.col_Roadmap_Date, Me.col_Roadmap_Position, Me.col_Roadmap_Affiliated_Agencies})
        Me.lvRoadmap_Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lvRoadmap_Master.GridLines = True
        Me.lvRoadmap_Master.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22})
        Me.lvRoadmap_Master.Location = New System.Drawing.Point(3, 26)
        Me.lvRoadmap_Master.Name = "lvRoadmap_Master"
        Me.lvRoadmap_Master.Size = New System.Drawing.Size(1317, 614)
        Me.lvRoadmap_Master.TabIndex = 0
        Me.lvRoadmap_Master.UseCompatibleStateImageBehavior = False
        Me.lvRoadmap_Master.View = System.Windows.Forms.View.Details
        '
        'col_Roadmap_Id
        '
        Me.col_Roadmap_Id.Text = "Id"
        Me.col_Roadmap_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Id.Width = 0
        '
        'col_Roadmap_Code
        '
        Me.col_Roadmap_Code.Text = "เลขที่เอกสาร"
        Me.col_Roadmap_Code.Width = 86
        '
        'col_Roadmap_Date
        '
        Me.col_Roadmap_Date.Text = "วันที่"
        Me.col_Roadmap_Date.Width = 102
        '
        'col_Roadmap_Position
        '
        Me.col_Roadmap_Position.Text = "ตำแหน่งงาน"
        Me.col_Roadmap_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Position.Width = 342
        '
        'col_Roadmap_Affiliated_Agencies
        '
        Me.col_Roadmap_Affiliated_Agencies.Text = "สังกัดหน่วยงาน"
        Me.col_Roadmap_Affiliated_Agencies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Roadmap_Affiliated_Agencies.Width = 423
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.ToolStripButton6, Me.btnRefresh, Me.ToolStripSeparator1, Me.btnDelete, Me.btnClose})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1323, 25)
        Me.ToolStrip2.TabIndex = 632
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
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 22)
        Me.btnRefresh.Text = "รีเฟรช"
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1336, 75)
        Me.Panel2.TabIndex = 643
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.3718!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.6282!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_search_position, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_search_station, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAffiliatedAgencies, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPopAffiliatedAgencies, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_position, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_capacity, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPosition, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(974, 32)
        Me.TableLayoutPanel1.TabIndex = 640
        '
        'lbl_search_position
        '
        Me.lbl_search_position.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_search_position.AutoSize = True
        Me.lbl_search_position.Location = New System.Drawing.Point(10, 8)
        Me.lbl_search_position.Name = "lbl_search_position"
        Me.lbl_search_position.Size = New System.Drawing.Size(95, 16)
        Me.lbl_search_position.TabIndex = 633
        Me.lbl_search_position.Text = "ค้นหาตำแหน่งงาน:"
        '
        'lbl_search_station
        '
        Me.lbl_search_station.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_search_station.AutoSize = True
        Me.lbl_search_station.Location = New System.Drawing.Point(364, 8)
        Me.lbl_search_station.Name = "lbl_search_station"
        Me.lbl_search_station.Size = New System.Drawing.Size(109, 16)
        Me.lbl_search_station.TabIndex = 639
        Me.lbl_search_station.Text = "ค้นหาสังกัดหน่วยงาน:"
        '
        'txtAffiliatedAgencies
        '
        Me.txtAffiliatedAgencies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAffiliatedAgencies.Location = New System.Drawing.Point(482, 5)
        Me.txtAffiliatedAgencies.Name = "txtAffiliatedAgencies"
        Me.txtAffiliatedAgencies.Size = New System.Drawing.Size(192, 22)
        Me.txtAffiliatedAgencies.TabIndex = 637
        '
        'btnPopAffiliatedAgencies
        '
        Me.btnPopAffiliatedAgencies.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPopAffiliatedAgencies.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.btnPopAffiliatedAgencies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPopAffiliatedAgencies.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnPopAffiliatedAgencies.Location = New System.Drawing.Point(690, 5)
        Me.btnPopAffiliatedAgencies.Name = "btnPopAffiliatedAgencies"
        Me.btnPopAffiliatedAgencies.Size = New System.Drawing.Size(38, 22)
        Me.btnPopAffiliatedAgencies.TabIndex = 638
        Me.btnPopAffiliatedAgencies.UseVisualStyleBackColor = True
        '
        'btn_position
        '
        Me.btn_position.Location = New System.Drawing.Point(742, 3)
        Me.btn_position.Name = "btn_position"
        Me.btn_position.Size = New System.Drawing.Size(75, 23)
        Me.btn_position.TabIndex = 642
        Me.btn_position.Text = "ตำแหน่งงาน"
        Me.btn_position.UseVisualStyleBackColor = True
        '
        'lbl_capacity
        '
        Me.lbl_capacity.Location = New System.Drawing.Point(833, 3)
        Me.lbl_capacity.Name = "lbl_capacity"
        Me.lbl_capacity.Size = New System.Drawing.Size(108, 23)
        Me.lbl_capacity.TabIndex = 643
        Me.lbl_capacity.Text = "ขีดความสามารถ"
        Me.lbl_capacity.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPosition.Location = New System.Drawing.Point(111, 5)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(220, 22)
        Me.txtPosition.TabIndex = 640
        '
        'btnPopPosition
        '
        Me.btnPopPosition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPopPosition.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.btnPopPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPopPosition.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnPopPosition.Location = New System.Drawing.Point(301, 5)
        Me.btnPopPosition.Name = "btnPopPosition"
        Me.btnPopPosition.Size = New System.Drawing.Size(38, 22)
        Me.btnPopPosition.TabIndex = 641
        Me.btnPopPosition.UseVisualStyleBackColor = True
        '
        'Add_Edit_Roadmap_Browse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 741)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Add_Edit_Roadmap_Browse"
        Me.Text = "เพิ่ม/ แก้ไขเส้นทางการพัฒรายตำแหน่งงาน"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvRoadmap_Master As System.Windows.Forms.ListView
    Friend WithEvents col_Roadmap_Date As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Position As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Roadmap_Affiliated_Agencies As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_search_position As System.Windows.Forms.Label
    Friend WithEvents btnPopAffiliatedAgencies As System.Windows.Forms.Button
    Friend WithEvents txtAffiliatedAgencies As System.Windows.Forms.TextBox
    Friend WithEvents col_Roadmap_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPopPosition As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents lbl_search_station As System.Windows.Forms.Label
    Friend WithEvents col_Roadmap_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_position As System.Windows.Forms.Button
    Friend WithEvents lbl_capacity As System.Windows.Forms.Button
End Class
