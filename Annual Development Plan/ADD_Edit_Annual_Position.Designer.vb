<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_Edit_Annual_Position
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_Edit_Annual_Position))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_explanation = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_person = New System.Windows.Forms.Label()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lbl_edition = New System.Windows.Forms.Label()
        Me.txtEdition = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSelected_course = New System.Windows.Forms.TextBox()
        Me.lbl_development_timelines = New System.Windows.Forms.Label()
        Me.txtSelected_idp = New System.Windows.Forms.TextBox()
        Me.btnSelected_roadmap = New System.Windows.Forms.Button()
        Me.txtSelected_roadmap = New System.Windows.Forms.TextBox()
        Me.btnSelected_Position = New System.Windows.Forms.Button()
        Me.txtSelected_position = New System.Windows.Forms.TextBox()
        Me.txtMain_hour = New System.Windows.Forms.TextBox()
        Me.btnSelected_course = New System.Windows.Forms.Button()
        Me.btnSelected_idp = New System.Windows.Forms.Button()
        Me.lbl_hour = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnRefresh_Target = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete_Target = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.lvTarget = New System.Windows.Forms.ListView()
        Me.col_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Idx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Station = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtpEnddate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.txtBegtime = New System.Windows.Forms.TextBox()
        Me.txtEndtime = New System.Windows.Forms.TextBox()
        Me.lbl_time_to = New System.Windows.Forms.Label()
        Me.lbl_place = New System.Windows.Forms.Label()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.dtpBegdate = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.btnEdit_budget = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete_budget = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh_budget = New System.Windows.Forms.ToolStripButton()
        Me.lvBudget = New System.Windows.Forms.ListView()
        Me.col_Anb_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_AnbIdx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Number_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Cost_code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Cost_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Qty_people = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Amount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnBudget_year = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_money = New System.Windows.Forms.Label()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.btnCancel_budget = New System.Windows.Forms.Button()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.cbbBudget = New System.Windows.Forms.ComboBox()
        Me.lbl_expenses = New System.Windows.Forms.Label()
        Me.txtQty_people = New System.Windows.Forms.TextBox()
        Me.lbl_rate = New System.Windows.Forms.Label()
        Me.txtAmt_money = New System.Windows.Forms.TextBox()
        Me.btnAdd_budget = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_document_number = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.dtpAnnual = New System.Windows.Forms.DateTimePicker()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnSave_Ann = New System.Windows.Forms.ToolStripButton()
        Me.btnClear_Ann = New System.Windows.Forms.ToolStripButton()
        Me.btnClose_Ann = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG3
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 608)
        Me.GroupBox1.TabIndex = 631
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกกลุ่มเป้าหมาย"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_explanation)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(980, 121)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'lbl_explanation
        '
        Me.lbl_explanation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_explanation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_explanation.Location = New System.Drawing.Point(6, 92)
        Me.lbl_explanation.Name = "lbl_explanation"
        Me.lbl_explanation.Size = New System.Drawing.Size(645, 21)
        Me.lbl_explanation.TabIndex = 16
        Me.lbl_explanation.Text = "IDP เป็นคนที่ต้องดึงมาจากระบบประเมินผลงาน/ ตำแหน่งทั่่วไป ไปเลือกมาโดยไม่ได้ผ่าน " & _
    "RD/ คนที่จัด AN ต้องเก็บปี เพื่อจะเก็บประวัติออกรายงาน "
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.lbl_person)
        Me.GroupBox7.Controls.Add(Me.lbl_year)
        Me.GroupBox7.Controls.Add(Me.txtYear)
        Me.GroupBox7.Controls.Add(Me.lbl_edition)
        Me.GroupBox7.Controls.Add(Me.txtEdition)
        Me.GroupBox7.Controls.Add(Me.txtQty)
        Me.GroupBox7.Controls.Add(Me.lbl_amount)
        Me.GroupBox7.Location = New System.Drawing.Point(657, 86)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(287, 34)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'lbl_person
        '
        Me.lbl_person.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_person.AutoSize = True
        Me.lbl_person.Location = New System.Drawing.Point(246, 15)
        Me.lbl_person.Name = "lbl_person"
        Me.lbl_person.Size = New System.Drawing.Size(22, 13)
        Me.lbl_person.TabIndex = 11
        Me.lbl_person.Text = "คน"
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_year.Location = New System.Drawing.Point(20, 14)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(24, 15)
        Me.lbl_year.TabIndex = 5
        Me.lbl_year.Text = "ปีที่:"
        '
        'txtYear
        '
        Me.txtYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtYear.Location = New System.Drawing.Point(44, 11)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(40, 21)
        Me.txtYear.TabIndex = 7
        '
        'lbl_edition
        '
        Me.lbl_edition.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_edition.AutoSize = True
        Me.lbl_edition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_edition.Location = New System.Drawing.Point(84, 14)
        Me.lbl_edition.Name = "lbl_edition"
        Me.lbl_edition.Size = New System.Drawing.Size(31, 15)
        Me.lbl_edition.TabIndex = 6
        Me.lbl_edition.Text = "รุ่นที่:"
        '
        'txtEdition
        '
        Me.txtEdition.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEdition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtEdition.Location = New System.Drawing.Point(119, 11)
        Me.txtEdition.Name = "txtEdition"
        Me.txtEdition.Size = New System.Drawing.Size(40, 21)
        Me.txtEdition.TabIndex = 8
        '
        'txtQty
        '
        Me.txtQty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQty.Location = New System.Drawing.Point(205, 11)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(41, 20)
        Me.txtQty.TabIndex = 10
        '
        'lbl_amount
        '
        Me.lbl_amount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Location = New System.Drawing.Point(159, 15)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(43, 13)
        Me.lbl_amount.TabIndex = 9
        Me.lbl_amount.Text = "จำนวน:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.78534!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.21466!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtSelected_course, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_development_timelines, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSelected_idp, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSelected_roadmap, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSelected_roadmap, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSelected_Position, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSelected_position, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMain_hour, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSelected_course, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSelected_idp, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_hour, 5, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 10)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(972, 73)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtSelected_course
        '
        Me.txtSelected_course.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSelected_course.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSelected_course.Location = New System.Drawing.Point(3, 44)
        Me.txtSelected_course.Name = "txtSelected_course"
        Me.txtSelected_course.Size = New System.Drawing.Size(161, 21)
        Me.txtSelected_course.TabIndex = 15
        '
        'lbl_development_timelines
        '
        Me.lbl_development_timelines.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_development_timelines.AutoSize = True
        Me.lbl_development_timelines.Location = New System.Drawing.Point(791, 12)
        Me.lbl_development_timelines.Name = "lbl_development_timelines"
        Me.lbl_development_timelines.Size = New System.Drawing.Size(83, 13)
        Me.lbl_development_timelines.TabIndex = 12
        Me.lbl_development_timelines.Text = "ระยะเวลาพัฒนา"
        '
        'txtSelected_idp
        '
        Me.txtSelected_idp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSelected_idp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSelected_idp.Location = New System.Drawing.Point(583, 44)
        Me.txtSelected_idp.Name = "txtSelected_idp"
        Me.txtSelected_idp.Size = New System.Drawing.Size(201, 21)
        Me.txtSelected_idp.TabIndex = 11
        '
        'btnSelected_roadmap
        '
        Me.btnSelected_roadmap.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelected_roadmap.Location = New System.Drawing.Point(331, 7)
        Me.btnSelected_roadmap.Name = "btnSelected_roadmap"
        Me.btnSelected_roadmap.Size = New System.Drawing.Size(246, 23)
        Me.btnSelected_roadmap.TabIndex = 3
        Me.btnSelected_roadmap.Text = "ค้นหาตามเส้นทางการพัฒนารายตำแหน่ง"
        Me.btnSelected_roadmap.UseVisualStyleBackColor = True
        '
        'txtSelected_roadmap
        '
        Me.txtSelected_roadmap.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSelected_roadmap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSelected_roadmap.Location = New System.Drawing.Point(331, 44)
        Me.txtSelected_roadmap.Name = "txtSelected_roadmap"
        Me.txtSelected_roadmap.Size = New System.Drawing.Size(246, 21)
        Me.txtSelected_roadmap.TabIndex = 10
        '
        'btnSelected_Position
        '
        Me.btnSelected_Position.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelected_Position.Location = New System.Drawing.Point(170, 7)
        Me.btnSelected_Position.Name = "btnSelected_Position"
        Me.btnSelected_Position.Size = New System.Drawing.Size(155, 23)
        Me.btnSelected_Position.TabIndex = 2
        Me.btnSelected_Position.Text = "ค้นหาตำแหน่งทั่วไป"
        Me.btnSelected_Position.UseVisualStyleBackColor = True
        '
        'txtSelected_position
        '
        Me.txtSelected_position.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSelected_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSelected_position.Location = New System.Drawing.Point(170, 44)
        Me.txtSelected_position.Name = "txtSelected_position"
        Me.txtSelected_position.Size = New System.Drawing.Size(155, 21)
        Me.txtSelected_position.TabIndex = 13
        '
        'txtMain_hour
        '
        Me.txtMain_hour.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMain_hour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtMain_hour.Location = New System.Drawing.Point(807, 44)
        Me.txtMain_hour.Name = "txtMain_hour"
        Me.txtMain_hour.Size = New System.Drawing.Size(51, 21)
        Me.txtMain_hour.TabIndex = 9
        '
        'btnSelected_course
        '
        Me.btnSelected_course.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelected_course.Location = New System.Drawing.Point(3, 7)
        Me.btnSelected_course.Name = "btnSelected_course"
        Me.btnSelected_course.Size = New System.Drawing.Size(161, 23)
        Me.btnSelected_course.TabIndex = 4
        Me.btnSelected_course.Text = "เลือกหลักสูตร"
        Me.btnSelected_course.UseVisualStyleBackColor = True
        '
        'btnSelected_idp
        '
        Me.btnSelected_idp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSelected_idp.Location = New System.Drawing.Point(595, 7)
        Me.btnSelected_idp.Name = "btnSelected_idp"
        Me.btnSelected_idp.Size = New System.Drawing.Size(176, 23)
        Me.btnSelected_idp.TabIndex = 14
        Me.btnSelected_idp.Text = "ค้นหาฝึกอบรมรายบุคคล [IDP]"
        Me.btnSelected_idp.UseVisualStyleBackColor = True
        '
        'lbl_hour
        '
        Me.lbl_hour.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_hour.AutoSize = True
        Me.lbl_hour.Location = New System.Drawing.Point(913, 48)
        Me.lbl_hour.Name = "lbl_hour"
        Me.lbl_hour.Size = New System.Drawing.Size(24, 13)
        Me.lbl_hour.TabIndex = 16
        Me.lbl_hour.Text = "ชม."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 138)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(982, 460)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(974, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "กลุ่มเป้าหมาย"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ToolStrip1)
        Me.GroupBox4.Controls.Add(Me.lvTarget)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(950, 424)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "รายชื่อกลุ่มเป้าหมาย"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh_Target, Me.btnDelete_Target, Me.ToolStripButton16})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 17)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(944, 25)
        Me.ToolStrip1.TabIndex = 647
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnRefresh_Target
        '
        Me.btnRefresh_Target.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh_Target.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh_Target.Name = "btnRefresh_Target"
        Me.btnRefresh_Target.Size = New System.Drawing.Size(55, 22)
        Me.btnRefresh_Target.Text = "รีเฟรช"
        '
        'btnDelete_Target
        '
        Me.btnDelete_Target.Image = Global.Human_Development.My.Resources.Resources._1_26
        Me.btnDelete_Target.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete_Target.Name = "btnDelete_Target"
        Me.btnDelete_Target.Size = New System.Drawing.Size(40, 22)
        Me.btnDelete_Target.Text = "ลบ"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "ToolStripButton16"
        '
        'lvTarget
        '
        Me.lvTarget.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvTarget.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Id, Me.col_Idx, Me.col_Number, Me.col_Code, Me.col_Name, Me.col_Position, Me.col_Station})
        Me.lvTarget.GridLines = True
        Me.lvTarget.Location = New System.Drawing.Point(6, 44)
        Me.lvTarget.Name = "lvTarget"
        Me.lvTarget.Size = New System.Drawing.Size(938, 374)
        Me.lvTarget.TabIndex = 1
        Me.lvTarget.UseCompatibleStateImageBehavior = False
        Me.lvTarget.View = System.Windows.Forms.View.Details
        '
        'col_Id
        '
        Me.col_Id.Width = 0
        '
        'col_Idx
        '
        Me.col_Idx.DisplayIndex = 6
        Me.col_Idx.Width = 0
        '
        'col_Number
        '
        Me.col_Number.DisplayIndex = 1
        Me.col_Number.Text = "ลำดับ"
        Me.col_Number.Width = 39
        '
        'col_Code
        '
        Me.col_Code.DisplayIndex = 2
        Me.col_Code.Text = "รหัสพนักงาน"
        Me.col_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Code.Width = 172
        '
        'col_Name
        '
        Me.col_Name.DisplayIndex = 3
        Me.col_Name.Text = "ชื่อ - สกุล"
        Me.col_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Name.Width = 203
        '
        'col_Position
        '
        Me.col_Position.DisplayIndex = 4
        Me.col_Position.Text = "ตำแหน่ง"
        Me.col_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Position.Width = 197
        '
        'col_Station
        '
        Me.col_Station.DisplayIndex = 5
        Me.col_Station.Text = "สังกัดหน่วยงาน"
        Me.col_Station.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Station.Width = 211
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.ToolStrip3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(974, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "กำหนดการ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 31)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(962, 130)
        Me.GroupBox9.TabIndex = 648
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "รายละเอีดยกำหนดการ"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.69565!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.30434!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dtpEnddate, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_from, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_to, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_time, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtBegtime, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtEndtime, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_time_to, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_place, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnPlace, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtPlace, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dtpBegdate, 1, 0)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 20)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(843, 82)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'dtpEnddate
        '
        Me.dtpEnddate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpEnddate.Location = New System.Drawing.Point(246, 10)
        Me.dtpEnddate.Name = "dtpEnddate"
        Me.dtpEnddate.Size = New System.Drawing.Size(131, 21)
        Me.dtpEnddate.TabIndex = 146
        '
        'lbl_from
        '
        Me.lbl_from.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_from.AutoSize = True
        Me.lbl_from.Location = New System.Drawing.Point(7, 5)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(48, 30)
        Me.lbl_from.TabIndex = 1
        Me.lbl_from.Text = "ตั้งแต่วันที่:"
        '
        'lbl_to
        '
        Me.lbl_to.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_to.AutoSize = True
        Me.lbl_to.Location = New System.Drawing.Point(214, 13)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(19, 15)
        Me.lbl_to.TabIndex = 5
        Me.lbl_to.Text = "ถึง"
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(23, 54)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(32, 15)
        Me.lbl_time.TabIndex = 6
        Me.lbl_time.Text = "เวลา:"
        '
        'txtBegtime
        '
        Me.txtBegtime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBegtime.Location = New System.Drawing.Point(62, 51)
        Me.txtBegtime.Name = "txtBegtime"
        Me.txtBegtime.Size = New System.Drawing.Size(135, 21)
        Me.txtBegtime.TabIndex = 8
        '
        'txtEndtime
        '
        Me.txtEndtime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEndtime.Location = New System.Drawing.Point(247, 51)
        Me.txtEndtime.Name = "txtEndtime"
        Me.txtEndtime.Size = New System.Drawing.Size(130, 21)
        Me.txtEndtime.TabIndex = 9
        '
        'lbl_time_to
        '
        Me.lbl_time_to.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_time_to.AutoSize = True
        Me.lbl_time_to.Location = New System.Drawing.Point(214, 54)
        Me.lbl_time_to.Name = "lbl_time_to"
        Me.lbl_time_to.Size = New System.Drawing.Size(19, 15)
        Me.lbl_time_to.TabIndex = 10
        Me.lbl_time_to.Text = "ถึง"
        '
        'lbl_place
        '
        Me.lbl_place.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_place.AutoSize = True
        Me.lbl_place.Location = New System.Drawing.Point(399, 13)
        Me.lbl_place.Name = "lbl_place"
        Me.lbl_place.Size = New System.Drawing.Size(43, 15)
        Me.lbl_place.TabIndex = 11
        Me.lbl_place.Text = "สถานที่:"
        '
        'btnPlace
        '
        Me.btnPlace.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPlace.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnPlace.Location = New System.Drawing.Point(448, 9)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(51, 23)
        Me.btnPlace.TabIndex = 143
        Me.btnPlace.UseVisualStyleBackColor = True
        '
        'txtPlace
        '
        Me.txtPlace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPlace.Location = New System.Drawing.Point(539, 10)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(266, 21)
        Me.txtPlace.TabIndex = 144
        '
        'dtpBegdate
        '
        Me.dtpBegdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpBegdate.Location = New System.Drawing.Point(63, 10)
        Me.dtpBegdate.Name = "dtpBegdate"
        Me.dtpBegdate.Size = New System.Drawing.Size(133, 21)
        Me.dtpBegdate.TabIndex = 145
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(968, 25)
        Me.ToolStrip3.TabIndex = 647
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(974, 432)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "งบประมาณ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ToolStrip4)
        Me.GroupBox6.Controls.Add(Me.lvBudget)
        Me.GroupBox6.Location = New System.Drawing.Point(2, 114)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(967, 281)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEdit_budget, Me.btnDelete_budget, Me.btnRefresh_budget})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 17)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(961, 25)
        Me.ToolStrip4.TabIndex = 647
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'btnEdit_budget
        '
        Me.btnEdit_budget.Image = Global.Human_Development.My.Resources.Resources._32_26
        Me.btnEdit_budget.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit_budget.Name = "btnEdit_budget"
        Me.btnEdit_budget.Size = New System.Drawing.Size(52, 22)
        Me.btnEdit_budget.Text = "แก้ไข"
        '
        'btnDelete_budget
        '
        Me.btnDelete_budget.Image = Global.Human_Development.My.Resources.Resources._1_26
        Me.btnDelete_budget.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete_budget.Name = "btnDelete_budget"
        Me.btnDelete_budget.Size = New System.Drawing.Size(40, 22)
        Me.btnDelete_budget.Text = "ลบ"
        '
        'btnRefresh_budget
        '
        Me.btnRefresh_budget.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnRefresh_budget.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh_budget.Name = "btnRefresh_budget"
        Me.btnRefresh_budget.Size = New System.Drawing.Size(55, 22)
        Me.btnRefresh_budget.Text = "รีเฟรช"
        '
        'lvBudget
        '
        Me.lvBudget.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvBudget.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Anb_id, Me.col_AnbIdx, Me.col_Number_id, Me.col_Cost_code, Me.col_Cost_name, Me.col_Qty_people, Me.col_Rate, Me.col_Amount})
        Me.lvBudget.GridLines = True
        Me.lvBudget.Location = New System.Drawing.Point(3, 43)
        Me.lvBudget.Name = "lvBudget"
        Me.lvBudget.Size = New System.Drawing.Size(958, 232)
        Me.lvBudget.TabIndex = 2
        Me.lvBudget.UseCompatibleStateImageBehavior = False
        Me.lvBudget.View = System.Windows.Forms.View.Details
        '
        'col_Anb_id
        '
        Me.col_Anb_id.Width = 0
        '
        'col_AnbIdx
        '
        Me.col_AnbIdx.Width = 0
        '
        'col_Number_id
        '
        Me.col_Number_id.Text = "ลำดับ"
        Me.col_Number_id.Width = 39
        '
        'col_Cost_code
        '
        Me.col_Cost_code.Text = "รหัส"
        Me.col_Cost_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Cost_code.Width = 172
        '
        'col_Cost_name
        '
        Me.col_Cost_name.Text = "ค่าใช้จ่าย"
        Me.col_Cost_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Cost_name.Width = 203
        '
        'col_Qty_people
        '
        Me.col_Qty_people.Text = "จำนวน"
        Me.col_Qty_people.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Qty_people.Width = 197
        '
        'col_Rate
        '
        Me.col_Rate.Text = "อ้ตรา"
        Me.col_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Rate.Width = 202
        '
        'col_Amount
        '
        Me.col_Amount.Text = "จำนวนเงิน"
        Me.col_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Amount.Width = 99
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox5.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(967, 109)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "รายการค่าใช้จ่าย"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnBudget_year)
        Me.GroupBox8.Location = New System.Drawing.Point(565, 9)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(396, 94)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "งบประมาณประจำปี"
        '
        'btnBudget_year
        '
        Me.btnBudget_year.Location = New System.Drawing.Point(59, 36)
        Me.btnBudget_year.Name = "btnBudget_year"
        Me.btnBudget_year.Size = New System.Drawing.Size(278, 23)
        Me.btnBudget_year.TabIndex = 1
        Me.btnBudget_year.Text = "แสดงงบประมาณพัฒนาบุคลากรประจำปี"
        Me.btnBudget_year.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.96591!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.03409!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_money, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_qty, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnCancel_budget, 5, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtRate, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.cbbBudget, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_expenses, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtQty_people, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_rate, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtAmt_money, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btnAdd_budget, 4, 1)
        Me.TableLayoutPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(9, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.40678!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.59322!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(550, 82)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'lbl_money
        '
        Me.lbl_money.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_money.AutoSize = True
        Me.lbl_money.Location = New System.Drawing.Point(352, 18)
        Me.lbl_money.Name = "lbl_money"
        Me.lbl_money.Size = New System.Drawing.Size(58, 15)
        Me.lbl_money.TabIndex = 17
        Me.lbl_money.Text = "จำนวนเงิน"
        '
        'lbl_qty
        '
        Me.lbl_qty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Location = New System.Drawing.Point(236, 18)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(40, 15)
        Me.lbl_qty.TabIndex = 6
        Me.lbl_qty.Text = "จำนวน"
        '
        'btnCancel_budget
        '
        Me.btnCancel_budget.Location = New System.Drawing.Point(475, 55)
        Me.btnCancel_budget.Name = "btnCancel_budget"
        Me.btnCancel_budget.Size = New System.Drawing.Size(52, 23)
        Me.btnCancel_budget.TabIndex = 19
        Me.btnCancel_budget.Text = "ยกเลิก"
        Me.btnCancel_budget.UseVisualStyleBackColor = True
        '
        'txtRate
        '
        Me.txtRate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRate.Location = New System.Drawing.Point(286, 56)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(60, 21)
        Me.txtRate.TabIndex = 13
        '
        'cbbBudget
        '
        Me.cbbBudget.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbbBudget.FormattingEnabled = True
        Me.cbbBudget.Location = New System.Drawing.Point(3, 55)
        Me.cbbBudget.Name = "cbbBudget"
        Me.cbbBudget.Size = New System.Drawing.Size(223, 23)
        Me.cbbBudget.TabIndex = 15
        Me.cbbBudget.Text = "เลือกข้อมูล"
        '
        'lbl_expenses
        '
        Me.lbl_expenses.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_expenses.AutoSize = True
        Me.lbl_expenses.Location = New System.Drawing.Point(89, 18)
        Me.lbl_expenses.Name = "lbl_expenses"
        Me.lbl_expenses.Size = New System.Drawing.Size(50, 15)
        Me.lbl_expenses.TabIndex = 12
        Me.lbl_expenses.Text = "ค่าใช้จ่าย"
        '
        'txtQty_people
        '
        Me.txtQty_people.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQty_people.Location = New System.Drawing.Point(232, 56)
        Me.txtQty_people.Name = "txtQty_people"
        Me.txtQty_people.Size = New System.Drawing.Size(48, 21)
        Me.txtQty_people.TabIndex = 8
        '
        'lbl_rate
        '
        Me.lbl_rate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_rate.AutoSize = True
        Me.lbl_rate.Location = New System.Drawing.Point(300, 18)
        Me.lbl_rate.Name = "lbl_rate"
        Me.lbl_rate.Size = New System.Drawing.Size(31, 15)
        Me.lbl_rate.TabIndex = 11
        Me.lbl_rate.Text = "อัตรา"
        '
        'txtAmt_money
        '
        Me.txtAmt_money.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAmt_money.Enabled = False
        Me.txtAmt_money.Location = New System.Drawing.Point(352, 56)
        Me.txtAmt_money.Name = "txtAmt_money"
        Me.txtAmt_money.Size = New System.Drawing.Size(58, 21)
        Me.txtAmt_money.TabIndex = 18
        '
        'btnAdd_budget
        '
        Me.btnAdd_budget.Location = New System.Drawing.Point(416, 55)
        Me.btnAdd_budget.Name = "btnAdd_budget"
        Me.btnAdd_budget.Size = New System.Drawing.Size(53, 23)
        Me.btnAdd_budget.TabIndex = 16
        Me.btnAdd_budget.Text = "เพิ่ม"
        Me.btnAdd_budget.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(992, 60)
        Me.GroupBox2.TabIndex = 632
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายการเอกสาร"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 8
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.42268!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.57732!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 444.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_document_number, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_date, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCode, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpAnnual, 7, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(974, 30)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_document_number
        '
        Me.lbl_document_number.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_document_number.AutoSize = True
        Me.lbl_document_number.Location = New System.Drawing.Point(24, 7)
        Me.lbl_document_number.Name = "lbl_document_number"
        Me.lbl_document_number.Size = New System.Drawing.Size(70, 15)
        Me.lbl_document_number.TabIndex = 1
        Me.lbl_document_number.Text = "เลขที่เอกสาร:"
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(762, 7)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(31, 15)
        Me.lbl_date.TabIndex = 0
        Me.lbl_date.Text = "วันที่:"
        '
        'txtCode
        '
        Me.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCode.Location = New System.Drawing.Point(100, 4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(102, 21)
        Me.txtCode.TabIndex = 3
        '
        'dtpAnnual
        '
        Me.dtpAnnual.Location = New System.Drawing.Point(799, 3)
        Me.dtpAnnual.Name = "dtpAnnual"
        Me.dtpAnnual.Size = New System.Drawing.Size(130, 21)
        Me.dtpAnnual.TabIndex = 4
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox11.Location = New System.Drawing.Point(395, 42)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(256, 20)
        Me.TextBox11.TabIndex = 11
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave_Ann, Me.btnClear_Ann, Me.btnClose_Ann})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 646
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnSave_Ann
        '
        Me.btnSave_Ann.Image = Global.Human_Development.My.Resources.Resources._9_26
        Me.btnSave_Ann.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave_Ann.Name = "btnSave_Ann"
        Me.btnSave_Ann.Size = New System.Drawing.Size(55, 22)
        Me.btnSave_Ann.Text = "บันทึก"
        Me.btnSave_Ann.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear_Ann
        '
        Me.btnClear_Ann.Image = CType(resources.GetObject("btnClear_Ann.Image"), System.Drawing.Image)
        Me.btnClear_Ann.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear_Ann.Name = "btnClear_Ann"
        Me.btnClear_Ann.Size = New System.Drawing.Size(69, 22)
        Me.btnClear_Ann.Text = "ล้างข้อมูล"
        '
        'btnClose_Ann
        '
        Me.btnClose_Ann.Image = CType(resources.GetObject("btnClose_Ann.Image"), System.Drawing.Image)
        Me.btnClose_Ann.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose_Ann.Name = "btnClose_Ann"
        Me.btnClose_Ann.Size = New System.Drawing.Size(77, 22)
        Me.btnClose_Ann.Text = "ปิดหน้าต่าง"
        '
        'ADD_Edit_Annual_Position
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 693)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ADD_Edit_Annual_Position"
        Me.Text = "เพิ่ม/ แก้ไขแผนพัฒนารายตำแหน่ง"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_document_number As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnSelected_Position As System.Windows.Forms.Button
    Friend WithEvents btnSelected_roadmap As System.Windows.Forms.Button
    Friend WithEvents lvTarget As System.Windows.Forms.ListView
    Friend WithEvents col_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Position As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtEdition As System.Windows.Forms.TextBox
    Friend WithEvents lbl_edition As System.Windows.Forms.Label
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents btnSelected_course As System.Windows.Forms.Button
    Friend WithEvents txtMain_hour As System.Windows.Forms.TextBox
    Friend WithEvents txtSelected_position As System.Windows.Forms.TextBox
    Friend WithEvents txtSelected_roadmap As System.Windows.Forms.TextBox
    Friend WithEvents txtSelected_idp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_development_timelines As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_from As System.Windows.Forms.Label
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents txtBegtime As System.Windows.Forms.TextBox
    Friend WithEvents txtEndtime As System.Windows.Forms.TextBox
    Friend WithEvents lbl_time_to As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_qty As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents cbbBudget As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_expenses As System.Windows.Forms.Label
    Friend WithEvents txtQty_people As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rate As System.Windows.Forms.Label
    Friend WithEvents btnAdd_budget As System.Windows.Forms.Button
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents lvBudget As System.Windows.Forms.ListView
    Friend WithEvents col_Number_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Cost_code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Cost_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Qty_people As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Amount As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_amount As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lbl_money As System.Windows.Forms.Label
    Friend WithEvents txtAmt_money As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave_Ann As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear_Ann As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose_Ann As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSelected_course As System.Windows.Forms.TextBox
    Friend WithEvents btnSelected_idp As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBudget_year As System.Windows.Forms.Button
    Friend WithEvents lbl_explanation As System.Windows.Forms.TextBox
    Friend WithEvents lbl_person As System.Windows.Forms.Label
    Friend WithEvents lbl_hour As System.Windows.Forms.Label
    Friend WithEvents col_Station As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_place As System.Windows.Forms.Label
    Friend WithEvents btnPlace As System.Windows.Forms.Button
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox
    Friend WithEvents dtpAnnual As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpBegdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents col_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEdit_budget As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete_budget As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh_budget As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_Anb_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel_budget As System.Windows.Forms.Button
    Friend WithEvents col_Idx As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_AnbIdx As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnRefresh_Target As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete_Target As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
End Class
