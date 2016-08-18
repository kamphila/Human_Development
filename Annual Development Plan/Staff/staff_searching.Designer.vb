<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_searching
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.branch_lb = New System.Windows.Forms.Label()
        Me.Cbo_Branch = New MTGCComboBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.emp_grade_rbt = New System.Windows.Forms.RadioButton()
        Me.org_serach_rbt = New System.Windows.Forms.RadioButton()
        Me.station_type_lb = New System.Windows.Forms.Label()
        Me.station_name_lb = New System.Windows.Forms.Label()
        Me.position_level_rbt = New System.Windows.Forms.RadioButton()
        Me.position_level_tb = New System.Windows.Forms.TextBox()
        Me.position_level_bt = New System.Windows.Forms.Button()
        Me.position_rbt = New System.Windows.Forms.RadioButton()
        Me.position_tb = New System.Windows.Forms.TextBox()
        Me.position_bt = New System.Windows.Forms.Button()
        Me.to_workage_lb = New System.Windows.Forms.Label()
        Me.emp_grade_tb = New System.Windows.Forms.TextBox()
        Me.emp_grade_bt = New System.Windows.Forms.Button()
        Me.cbo_stationtype = New System.Windows.Forms.ComboBox()
        Me.cbo_station = New System.Windows.Forms.ComboBox()
        Me.emp_code_rbt = New System.Windows.Forms.RadioButton()
        Me.emp_code_tb = New System.Windows.Forms.TextBox()
        Me.emp_code_bt = New System.Windows.Forms.Button()
        Me.from_workage_lb = New System.Windows.Forms.Label()
        Me.STD_Position_rbt = New System.Windows.Forms.RadioButton()
        Me.to_workage_tb = New System.Windows.Forms.TextBox()
        Me.from_workage_tb = New System.Windows.Forms.TextBox()
        Me.STD_PositionTB = New System.Windows.Forms.TextBox()
        Me.STD_PositionBT = New System.Windows.Forms.Button()
        Me.select_target_lb = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(443, 24)
        Me.MenuStrip2.TabIndex = 38
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SelectToolStripMenuItem
        '
        Me.SelectToolStripMenuItem.Image = Global.Human_Development.My.Resources.Resources.select26
        Me.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem"
        Me.SelectToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SelectToolStripMenuItem.Text = "เลือก"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.Human_Development.My.Resources.Resources._55_20
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.CloseToolStripMenuItem.Text = "ปิดหน้าต่าง"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.select_target_lb, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(443, 340)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.13754!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.86246!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.branch_lb, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Cbo_Branch, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(437, 27)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'branch_lb
        '
        Me.branch_lb.AutoSize = True
        Me.branch_lb.Dock = System.Windows.Forms.DockStyle.Right
        Me.branch_lb.Location = New System.Drawing.Point(107, 0)
        Me.branch_lb.Name = "branch_lb"
        Me.branch_lb.Size = New System.Drawing.Size(39, 27)
        Me.branch_lb.TabIndex = 0
        Me.branch_lb.Text = "Label1"
        Me.branch_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cbo_Branch
        '
        Me.Cbo_Branch.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.Cbo_Branch.ArrowColor = System.Drawing.Color.Black
        Me.Cbo_Branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Cbo_Branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbo_Branch.BindedControl = Nothing
        Me.Cbo_Branch.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.Cbo_Branch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Cbo_Branch.ColumnNum = 3
        Me.Cbo_Branch.ColumnWidth = "200;0;0"
        Me.Cbo_Branch.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.Cbo_Branch.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.Cbo_Branch.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.Cbo_Branch.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.Cbo_Branch.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Cbo_Branch.DisplayMember = "Text"
        Me.Cbo_Branch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cbo_Branch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cbo_Branch.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Cbo_Branch.DropDownForeColor = System.Drawing.Color.Black
        Me.Cbo_Branch.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.Cbo_Branch.DropDownWidth = 170
        Me.Cbo_Branch.GridLineColor = System.Drawing.Color.LightGray
        Me.Cbo_Branch.GridLineHorizontal = True
        Me.Cbo_Branch.GridLineVertical = True
        Me.Cbo_Branch.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.Cbo_Branch.Location = New System.Drawing.Point(152, 3)
        Me.Cbo_Branch.ManagingFastMouseMoving = True
        Me.Cbo_Branch.ManagingFastMouseMovingInterval = 30
        Me.Cbo_Branch.Name = "Cbo_Branch"
        Me.Cbo_Branch.SelectedItem = Nothing
        Me.Cbo_Branch.SelectedValue = Nothing
        Me.Cbo_Branch.Size = New System.Drawing.Size(154, 21)
        Me.Cbo_Branch.TabIndex = 5
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.54369!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.45631!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.emp_grade_rbt, 0, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.org_serach_rbt, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.station_type_lb, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.station_name_lb, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.position_level_rbt, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.position_level_tb, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.position_level_bt, 2, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.position_rbt, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.position_tb, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.position_bt, 2, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.to_workage_lb, 0, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.emp_grade_tb, 1, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.emp_grade_bt, 2, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.cbo_stationtype, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cbo_station, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.emp_code_rbt, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.emp_code_tb, 1, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.emp_code_bt, 2, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.from_workage_lb, 0, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.STD_Position_rbt, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.to_workage_tb, 1, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.from_workage_tb, 1, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.STD_PositionTB, 1, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.STD_PositionBT, 2, 6)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 51)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 16
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(437, 277)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'emp_grade_rbt
        '
        Me.emp_grade_rbt.AutoSize = True
        Me.emp_grade_rbt.Location = New System.Drawing.Point(3, 248)
        Me.emp_grade_rbt.Name = "emp_grade_rbt"
        Me.emp_grade_rbt.Size = New System.Drawing.Size(90, 17)
        Me.emp_grade_rbt.TabIndex = 19
        Me.emp_grade_rbt.TabStop = True
        Me.emp_grade_rbt.Text = "RadioButton1"
        Me.emp_grade_rbt.UseVisualStyleBackColor = True
        Me.emp_grade_rbt.Visible = False
        '
        'org_serach_rbt
        '
        Me.org_serach_rbt.AutoSize = True
        Me.org_serach_rbt.Location = New System.Drawing.Point(3, 3)
        Me.org_serach_rbt.Name = "org_serach_rbt"
        Me.org_serach_rbt.Size = New System.Drawing.Size(90, 17)
        Me.org_serach_rbt.TabIndex = 0
        Me.org_serach_rbt.TabStop = True
        Me.org_serach_rbt.Text = "RadioButton1"
        Me.org_serach_rbt.UseVisualStyleBackColor = True
        '
        'station_type_lb
        '
        Me.station_type_lb.AutoSize = True
        Me.station_type_lb.Dock = System.Windows.Forms.DockStyle.Right
        Me.station_type_lb.Location = New System.Drawing.Point(108, 23)
        Me.station_type_lb.Name = "station_type_lb"
        Me.station_type_lb.Size = New System.Drawing.Size(39, 27)
        Me.station_type_lb.TabIndex = 1
        Me.station_type_lb.Text = "Label1"
        Me.station_type_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'station_name_lb
        '
        Me.station_name_lb.AutoSize = True
        Me.station_name_lb.Dock = System.Windows.Forms.DockStyle.Right
        Me.station_name_lb.Location = New System.Drawing.Point(108, 50)
        Me.station_name_lb.Name = "station_name_lb"
        Me.station_name_lb.Size = New System.Drawing.Size(39, 27)
        Me.station_name_lb.TabIndex = 4
        Me.station_name_lb.Text = "Label1"
        Me.station_name_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'position_level_rbt
        '
        Me.position_level_rbt.AutoSize = True
        Me.position_level_rbt.Location = New System.Drawing.Point(3, 80)
        Me.position_level_rbt.Name = "position_level_rbt"
        Me.position_level_rbt.Size = New System.Drawing.Size(90, 17)
        Me.position_level_rbt.TabIndex = 5
        Me.position_level_rbt.TabStop = True
        Me.position_level_rbt.Text = "RadioButton1"
        Me.position_level_rbt.UseVisualStyleBackColor = True
        '
        'position_level_tb
        '
        Me.position_level_tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.position_level_tb.Location = New System.Drawing.Point(153, 80)
        Me.position_level_tb.Name = "position_level_tb"
        Me.position_level_tb.ReadOnly = True
        Me.position_level_tb.Size = New System.Drawing.Size(152, 20)
        Me.position_level_tb.TabIndex = 6
        '
        'position_level_bt
        '
        Me.position_level_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.position_level_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.position_level_bt.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.position_level_bt.Location = New System.Drawing.Point(311, 80)
        Me.position_level_bt.Name = "position_level_bt"
        Me.position_level_bt.Size = New System.Drawing.Size(34, 23)
        Me.position_level_bt.TabIndex = 7
        Me.position_level_bt.UseVisualStyleBackColor = True
        '
        'position_rbt
        '
        Me.position_rbt.AutoSize = True
        Me.position_rbt.Location = New System.Drawing.Point(3, 109)
        Me.position_rbt.Name = "position_rbt"
        Me.position_rbt.Size = New System.Drawing.Size(90, 17)
        Me.position_rbt.TabIndex = 8
        Me.position_rbt.TabStop = True
        Me.position_rbt.Text = "RadioButton1"
        Me.position_rbt.UseVisualStyleBackColor = True
        '
        'position_tb
        '
        Me.position_tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.position_tb.Location = New System.Drawing.Point(153, 109)
        Me.position_tb.Name = "position_tb"
        Me.position_tb.ReadOnly = True
        Me.position_tb.Size = New System.Drawing.Size(152, 20)
        Me.position_tb.TabIndex = 9
        '
        'position_bt
        '
        Me.position_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.position_bt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.position_bt.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.position_bt.Location = New System.Drawing.Point(311, 109)
        Me.position_bt.Name = "position_bt"
        Me.position_bt.Size = New System.Drawing.Size(34, 23)
        Me.position_bt.TabIndex = 10
        Me.position_bt.UseVisualStyleBackColor = True
        '
        'to_workage_lb
        '
        Me.to_workage_lb.AutoSize = True
        Me.to_workage_lb.Dock = System.Windows.Forms.DockStyle.Right
        Me.to_workage_lb.Location = New System.Drawing.Point(108, 193)
        Me.to_workage_lb.Name = "to_workage_lb"
        Me.to_workage_lb.Size = New System.Drawing.Size(39, 26)
        Me.to_workage_lb.TabIndex = 14
        Me.to_workage_lb.Text = "Label1"
        Me.to_workage_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.to_workage_lb.Visible = False
        '
        'emp_grade_tb
        '
        Me.emp_grade_tb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emp_grade_tb.Location = New System.Drawing.Point(153, 248)
        Me.emp_grade_tb.Name = "emp_grade_tb"
        Me.emp_grade_tb.ReadOnly = True
        Me.emp_grade_tb.Size = New System.Drawing.Size(152, 20)
        Me.emp_grade_tb.TabIndex = 20
        Me.emp_grade_tb.Visible = False
        '
        'emp_grade_bt
        '
        Me.emp_grade_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.emp_grade_bt.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.emp_grade_bt.Location = New System.Drawing.Point(311, 248)
        Me.emp_grade_bt.Name = "emp_grade_bt"
        Me.emp_grade_bt.Size = New System.Drawing.Size(34, 23)
        Me.emp_grade_bt.TabIndex = 21
        Me.emp_grade_bt.UseVisualStyleBackColor = True
        Me.emp_grade_bt.Visible = False
        '
        'cbo_stationtype
        '
        Me.cbo_stationtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_stationtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_stationtype.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_stationtype.FormattingEnabled = True
        Me.cbo_stationtype.Location = New System.Drawing.Point(153, 26)
        Me.cbo_stationtype.Name = "cbo_stationtype"
        Me.cbo_stationtype.Size = New System.Drawing.Size(152, 21)
        Me.cbo_stationtype.TabIndex = 694
        '
        'cbo_station
        '
        Me.cbo_station.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_station.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_station.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbo_station.FormattingEnabled = True
        Me.cbo_station.Location = New System.Drawing.Point(153, 53)
        Me.cbo_station.Name = "cbo_station"
        Me.cbo_station.Size = New System.Drawing.Size(152, 21)
        Me.cbo_station.TabIndex = 695
        '
        'emp_code_rbt
        '
        Me.emp_code_rbt.AutoSize = True
        Me.emp_code_rbt.Location = New System.Drawing.Point(3, 138)
        Me.emp_code_rbt.Name = "emp_code_rbt"
        Me.emp_code_rbt.Size = New System.Drawing.Size(90, 17)
        Me.emp_code_rbt.TabIndex = 16
        Me.emp_code_rbt.TabStop = True
        Me.emp_code_rbt.Text = "RadioButton1"
        Me.emp_code_rbt.UseVisualStyleBackColor = True
        '
        'emp_code_tb
        '
        Me.emp_code_tb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.emp_code_tb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.emp_code_tb.Location = New System.Drawing.Point(153, 138)
        Me.emp_code_tb.Name = "emp_code_tb"
        Me.emp_code_tb.ReadOnly = True
        Me.emp_code_tb.Size = New System.Drawing.Size(152, 20)
        Me.emp_code_tb.TabIndex = 17
        '
        'emp_code_bt
        '
        Me.emp_code_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.emp_code_bt.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.emp_code_bt.Location = New System.Drawing.Point(311, 138)
        Me.emp_code_bt.Name = "emp_code_bt"
        Me.emp_code_bt.Size = New System.Drawing.Size(34, 23)
        Me.emp_code_bt.TabIndex = 18
        Me.emp_code_bt.UseVisualStyleBackColor = True
        '
        'from_workage_lb
        '
        Me.from_workage_lb.AutoSize = True
        Me.from_workage_lb.Dock = System.Windows.Forms.DockStyle.Right
        Me.from_workage_lb.Location = New System.Drawing.Point(108, 219)
        Me.from_workage_lb.Name = "from_workage_lb"
        Me.from_workage_lb.Size = New System.Drawing.Size(39, 26)
        Me.from_workage_lb.TabIndex = 12
        Me.from_workage_lb.Text = "Label1"
        Me.from_workage_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.from_workage_lb.Visible = False
        '
        'STD_Position_rbt
        '
        Me.STD_Position_rbt.AutoSize = True
        Me.STD_Position_rbt.Location = New System.Drawing.Point(3, 167)
        Me.STD_Position_rbt.Name = "STD_Position_rbt"
        Me.STD_Position_rbt.Size = New System.Drawing.Size(90, 17)
        Me.STD_Position_rbt.TabIndex = 11
        Me.STD_Position_rbt.TabStop = True
        Me.STD_Position_rbt.Text = "RadioButton1"
        Me.STD_Position_rbt.UseVisualStyleBackColor = True
        '
        'to_workage_tb
        '
        Me.to_workage_tb.Location = New System.Drawing.Point(153, 222)
        Me.to_workage_tb.Name = "to_workage_tb"
        Me.to_workage_tb.Size = New System.Drawing.Size(97, 20)
        Me.to_workage_tb.TabIndex = 15
        Me.to_workage_tb.Visible = False
        '
        'from_workage_tb
        '
        Me.from_workage_tb.Location = New System.Drawing.Point(153, 196)
        Me.from_workage_tb.Name = "from_workage_tb"
        Me.from_workage_tb.Size = New System.Drawing.Size(97, 20)
        Me.from_workage_tb.TabIndex = 13
        Me.from_workage_tb.Visible = False
        '
        'STD_PositionTB
        '
        Me.STD_PositionTB.Location = New System.Drawing.Point(153, 167)
        Me.STD_PositionTB.Name = "STD_PositionTB"
        Me.STD_PositionTB.ReadOnly = True
        Me.STD_PositionTB.Size = New System.Drawing.Size(152, 20)
        Me.STD_PositionTB.TabIndex = 696
        '
        'STD_PositionBT
        '
        Me.STD_PositionBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.STD_PositionBT.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.STD_PositionBT.Location = New System.Drawing.Point(311, 167)
        Me.STD_PositionBT.Name = "STD_PositionBT"
        Me.STD_PositionBT.Size = New System.Drawing.Size(34, 23)
        Me.STD_PositionBT.TabIndex = 697
        Me.STD_PositionBT.UseVisualStyleBackColor = True
        '
        'select_target_lb
        '
        Me.select_target_lb.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.select_target_lb.AutoSize = True
        Me.select_target_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.select_target_lb.Location = New System.Drawing.Point(3, 0)
        Me.select_target_lb.Name = "select_target_lb"
        Me.select_target_lb.Size = New System.Drawing.Size(51, 15)
        Me.select_target_lb.TabIndex = 1
        Me.select_target_lb.Text = "Label1"
        '
        'staff_searching
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(443, 364)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "staff_searching"
        Me.Text = "staff_searching"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents branch_lb As System.Windows.Forms.Label
    Friend WithEvents Cbo_Branch As MTGCComboBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents emp_grade_rbt As System.Windows.Forms.RadioButton
    Friend WithEvents org_serach_rbt As System.Windows.Forms.RadioButton
    Friend WithEvents station_type_lb As System.Windows.Forms.Label
    Friend WithEvents station_name_lb As System.Windows.Forms.Label
    Friend WithEvents position_level_rbt As System.Windows.Forms.RadioButton
    Friend WithEvents position_level_tb As System.Windows.Forms.TextBox
    Friend WithEvents position_level_bt As System.Windows.Forms.Button
    Friend WithEvents position_rbt As System.Windows.Forms.RadioButton
    Friend WithEvents position_tb As System.Windows.Forms.TextBox
    Friend WithEvents position_bt As System.Windows.Forms.Button
    Friend WithEvents to_workage_lb As System.Windows.Forms.Label
    Friend WithEvents emp_grade_tb As System.Windows.Forms.TextBox
    Friend WithEvents emp_grade_bt As System.Windows.Forms.Button
    Friend WithEvents cbo_stationtype As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_station As System.Windows.Forms.ComboBox
    Friend WithEvents emp_code_rbt As System.Windows.Forms.RadioButton
    Friend WithEvents emp_code_tb As System.Windows.Forms.TextBox
    Friend WithEvents emp_code_bt As System.Windows.Forms.Button
    Friend WithEvents from_workage_lb As System.Windows.Forms.Label
    Friend WithEvents STD_Position_rbt As System.Windows.Forms.RadioButton
    Friend WithEvents to_workage_tb As System.Windows.Forms.TextBox
    Friend WithEvents from_workage_tb As System.Windows.Forms.TextBox
    Friend WithEvents STD_PositionTB As System.Windows.Forms.TextBox
    Friend WithEvents STD_PositionBT As System.Windows.Forms.Button
    Friend WithEvents select_target_lb As System.Windows.Forms.Label
End Class
