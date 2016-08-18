<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Position
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Select_Position))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbbStationName = New System.Windows.Forms.ComboBox()
        Me.lbl_position_name = New System.Windows.Forms.Label()
        Me.lbl_position_code = New System.Windows.Forms.Label()
        Me.lbl_hierarchical_organizations = New System.Windows.Forms.Label()
        Me.cbbStationCode = New System.Windows.Forms.ComboBox()
        Me.txtPositionName = New System.Windows.Forms.TextBox()
        Me.txtPositionCode = New System.Windows.Forms.TextBox()
        Me.btnPositionName = New System.Windows.Forms.Button()
        Me.lvPosition = New System.Windows.Forms.ListView()
        Me.col_Position_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_StationId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Position_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Position_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Position_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Station_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_list_position = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnEnter = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(968, 25)
        Me.ToolStrip1.TabIndex = 643
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 22)
        Me.btnClose.Text = "ปิดหน้าต่าง"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 128)
        Me.GroupBox1.TabIndex = 647
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาตำแหน่งงาน"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.06623!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.93377!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cbbStationName, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_position_name, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_position_code, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_hierarchical_organizations, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cbbStationCode, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPositionName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPositionCode, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPositionName, 2, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(653, 91)
        Me.TableLayoutPanel2.TabIndex = 114
        '
        'cbbStationName
        '
        Me.cbbStationName.FormattingEnabled = True
        Me.cbbStationName.Location = New System.Drawing.Point(314, 3)
        Me.cbbStationName.Name = "cbbStationName"
        Me.cbbStationName.Size = New System.Drawing.Size(193, 24)
        Me.cbbStationName.TabIndex = 648
        '
        'lbl_position_name
        '
        Me.lbl_position_name.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_position_name.AutoSize = True
        Me.lbl_position_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_position_name.Location = New System.Drawing.Point(41, 64)
        Me.lbl_position_name.Name = "lbl_position_name"
        Me.lbl_position_name.Size = New System.Drawing.Size(81, 16)
        Me.lbl_position_name.TabIndex = 110
        Me.lbl_position_name.Text = "ชื่อตำแหน่งงาน:"
        Me.lbl_position_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_position_code
        '
        Me.lbl_position_code.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_position_code.AutoSize = True
        Me.lbl_position_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_position_code.Location = New System.Drawing.Point(33, 36)
        Me.lbl_position_code.Name = "lbl_position_code"
        Me.lbl_position_code.Size = New System.Drawing.Size(89, 16)
        Me.lbl_position_code.TabIndex = 0
        Me.lbl_position_code.Text = "รหัสตำแหน่งงาน:"
        Me.lbl_position_code.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_hierarchical_organizations
        '
        Me.lbl_hierarchical_organizations.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_hierarchical_organizations.AutoSize = True
        Me.lbl_hierarchical_organizations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_hierarchical_organizations.Location = New System.Drawing.Point(27, 7)
        Me.lbl_hierarchical_organizations.Name = "lbl_hierarchical_organizations"
        Me.lbl_hierarchical_organizations.Size = New System.Drawing.Size(95, 16)
        Me.lbl_hierarchical_organizations.TabIndex = 646
        Me.lbl_hierarchical_organizations.Text = "ลำดับชั้นหน่วยงาน:"
        Me.lbl_hierarchical_organizations.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbbStationCode
        '
        Me.cbbStationCode.FormattingEnabled = True
        Me.cbbStationCode.Items.AddRange(New Object() {"ทั้งหมด"})
        Me.cbbStationCode.Location = New System.Drawing.Point(128, 3)
        Me.cbbStationCode.Name = "cbbStationCode"
        Me.cbbStationCode.Size = New System.Drawing.Size(180, 24)
        Me.cbbStationCode.TabIndex = 647
        Me.cbbStationCode.Text = "ทั้งหมด"
        '
        'txtPositionName
        '
        Me.txtPositionName.Location = New System.Drawing.Point(128, 61)
        Me.txtPositionName.Name = "txtPositionName"
        Me.txtPositionName.Size = New System.Drawing.Size(180, 22)
        Me.txtPositionName.TabIndex = 650
        '
        'txtPositionCode
        '
        Me.txtPositionCode.Location = New System.Drawing.Point(128, 33)
        Me.txtPositionCode.Name = "txtPositionCode"
        Me.txtPositionCode.Size = New System.Drawing.Size(180, 22)
        Me.txtPositionCode.TabIndex = 651
        '
        'btnPositionName
        '
        Me.btnPositionName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPositionName.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.btnPositionName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPositionName.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnPositionName.Location = New System.Drawing.Point(314, 61)
        Me.btnPositionName.Name = "btnPositionName"
        Me.btnPositionName.Size = New System.Drawing.Size(39, 22)
        Me.btnPositionName.TabIndex = 641
        Me.btnPositionName.UseVisualStyleBackColor = True
        '
        'lvPosition
        '
        Me.lvPosition.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Position_Id, Me.Col_StationId, Me.col_Position_Number, Me.col_Position_Code, Me.col_Position_Name, Me.col_Station_Name})
        Me.lvPosition.GridLines = True
        Me.lvPosition.Location = New System.Drawing.Point(3, 28)
        Me.lvPosition.Name = "lvPosition"
        Me.lvPosition.Size = New System.Drawing.Size(930, 335)
        Me.lvPosition.TabIndex = 637
        Me.lvPosition.UseCompatibleStateImageBehavior = False
        Me.lvPosition.View = System.Windows.Forms.View.Details
        '
        'col_Position_Id
        '
        Me.col_Position_Id.Width = 0
        '
        'Col_StationId
        '
        Me.Col_StationId.Width = 0
        '
        'col_Position_Number
        '
        Me.col_Position_Number.Text = "ลำดับ"
        Me.col_Position_Number.Width = 70
        '
        'col_Position_Code
        '
        Me.col_Position_Code.Text = "รหัสตำแหน่งงาน"
        Me.col_Position_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Position_Code.Width = 127
        '
        'col_Position_Name
        '
        Me.col_Position_Name.Text = "ชื่อตำแหน่งงาน"
        Me.col_Position_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Position_Name.Width = 346
        '
        'col_Station_Name
        '
        Me.col_Station_Name.Text = "สังกัดหน่วยงาน"
        Me.col_Station_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Station_Name.Width = 383
        '
        'lbl_list_position
        '
        Me.lbl_list_position.AutoSize = True
        Me.lbl_list_position.BackColor = System.Drawing.Color.Transparent
        Me.lbl_list_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_list_position.Location = New System.Drawing.Point(9, 170)
        Me.lbl_list_position.Name = "lbl_list_position"
        Me.lbl_list_position.Size = New System.Drawing.Size(110, 15)
        Me.lbl_list_position.TabIndex = 649
        Me.lbl_list_position.Text = "รายชื่อตำแหน่งงาน"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lvPosition)
        Me.Panel2.Controls.Add(Me.ToolStrip2)
        Me.Panel2.Location = New System.Drawing.Point(5, 194)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 370)
        Me.Panel2.TabIndex = 648
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEnter, Me.btnRefresh})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(954, 25)
        Me.ToolStrip2.TabIndex = 636
        Me.ToolStrip2.Text = "ToolStrip1"
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
        'Select_Position
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(968, 729)
        Me.Controls.Add(Me.lbl_list_position)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Select_Position"
        Me.Text = "รายการตำแหน่งงาน"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_position_code As System.Windows.Forms.Label
    Friend WithEvents lbl_position_name As System.Windows.Forms.Label
    Friend WithEvents lvPosition As System.Windows.Forms.ListView
    Friend WithEvents col_Position_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Position_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Position_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_list_position As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_Station_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_hierarchical_organizations As System.Windows.Forms.Label
    Friend WithEvents btnPositionName As System.Windows.Forms.Button
    Friend WithEvents cbbStationName As System.Windows.Forms.ComboBox
    Friend WithEvents cbbStationCode As System.Windows.Forms.ComboBox
    Friend WithEvents col_Position_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPositionName As System.Windows.Forms.TextBox
    Friend WithEvents txtPositionCode As System.Windows.Forms.TextBox
    Friend WithEvents Col_StationId As System.Windows.Forms.ColumnHeader
End Class
