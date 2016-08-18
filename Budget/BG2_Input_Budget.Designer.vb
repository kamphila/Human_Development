<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BG2_Input_Budget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BG2_Input_Budget))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_document_code = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.btnPopAnnual = New System.Windows.Forms.Button()
        Me.lbl_search_course = New System.Windows.Forms.Label()
        Me.txtAnnual = New System.Windows.Forms.TextBox()
        Me.dtpBudget = New System.Windows.Forms.DateTimePicker()
        Me.txt_edit_cost = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lvBudget = New System.Windows.Forms.ListView()
        Me.col_Budget_Detail_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Annual_Budget = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Idx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Cost_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Cost_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Plan_Rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Plan_Qty_People = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Plan_Amt_Money = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Actual_Rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Actual_Qty_People = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Actual_Amt_Money = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPlan_avg = New System.Windows.Forms.TextBox()
        Me.lbl_budget_plan = New System.Windows.Forms.Button()
        Me.lbl_budget = New System.Windows.Forms.Button()
        Me.lbl_budget_actual = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtActual_avg = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnClear, Me.btnClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 100
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSave
        '
        Me.btnSave.Image = Global.Human_Development.My.Resources.Resources._9_26
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(55, 22)
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 22)
        Me.btnClear.Text = "ล้างข้อมูล"
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
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(4, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1001, 86)
        Me.Panel1.TabIndex = 101
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.75093!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.24907!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_date, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_document_code, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCode, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPopAnnual, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_search_course, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAnnual, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpBudget, 1, 1)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(988, 73)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(65, 36)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(31, 15)
        Me.lbl_date.TabIndex = 153
        Me.lbl_date.Text = "วันที่:"
        '
        'lbl_document_code
        '
        Me.lbl_document_code.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_document_code.AutoSize = True
        Me.lbl_document_code.Location = New System.Drawing.Point(26, 10)
        Me.lbl_document_code.Name = "lbl_document_code"
        Me.lbl_document_code.Size = New System.Drawing.Size(70, 15)
        Me.lbl_document_code.TabIndex = 151
        Me.lbl_document_code.Text = "เลขที่เอกสาร:"
        '
        'txtCode
        '
        Me.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCode.Location = New System.Drawing.Point(102, 7)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(127, 21)
        Me.txtCode.TabIndex = 152
        '
        'btnPopAnnual
        '
        Me.btnPopAnnual.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPopAnnual.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btnPopAnnual.Location = New System.Drawing.Point(595, 7)
        Me.btnPopAnnual.Name = "btnPopAnnual"
        Me.btnPopAnnual.Size = New System.Drawing.Size(103, 22)
        Me.btnPopAnnual.TabIndex = 150
        Me.btnPopAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPopAnnual.UseVisualStyleBackColor = True
        '
        'lbl_search_course
        '
        Me.lbl_search_course.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_search_course.AutoSize = True
        Me.lbl_search_course.Location = New System.Drawing.Point(513, 10)
        Me.lbl_search_course.Name = "lbl_search_course"
        Me.lbl_search_course.Size = New System.Drawing.Size(76, 15)
        Me.lbl_search_course.TabIndex = 115
        Me.lbl_search_course.Text = "ค้นหาหลักสูตร:"
        '
        'txtAnnual
        '
        Me.txtAnnual.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAnnual.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtAnnual.Location = New System.Drawing.Point(705, 7)
        Me.txtAnnual.Name = "txtAnnual"
        Me.txtAnnual.Size = New System.Drawing.Size(266, 21)
        Me.txtAnnual.TabIndex = 119
        '
        'dtpBudget
        '
        Me.dtpBudget.Location = New System.Drawing.Point(102, 39)
        Me.dtpBudget.Name = "dtpBudget"
        Me.dtpBudget.Size = New System.Drawing.Size(127, 21)
        Me.dtpBudget.TabIndex = 154
        '
        'txt_edit_cost
        '
        Me.txt_edit_cost.Location = New System.Drawing.Point(701, 45)
        Me.txt_edit_cost.Name = "txt_edit_cost"
        Me.txt_edit_cost.Size = New System.Drawing.Size(100, 20)
        Me.txt_edit_cost.TabIndex = 155
        Me.txt_edit_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_edit_cost.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txt_edit_cost)
        Me.Panel2.Controls.Add(Me.lvBudget)
        Me.Panel2.Location = New System.Drawing.Point(3, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1005, 495)
        Me.Panel2.TabIndex = 0
        '
        'lvBudget
        '
        Me.lvBudget.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Budget_Detail_Id, Me.col_Annual_Budget, Me.col_Idx, Me.col_Number, Me.col_Cost_Id, Me.col_Cost_Name, Me.col_Plan_Rate, Me.col_Plan_Qty_People, Me.col_Plan_Amt_Money, Me.col_Actual_Rate, Me.col_Actual_Qty_People, Me.col_Actual_Amt_Money})
        Me.lvBudget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lvBudget.FullRowSelect = True
        Me.lvBudget.GridLines = True
        Me.lvBudget.LabelEdit = True
        Me.lvBudget.Location = New System.Drawing.Point(0, 0)
        Me.lvBudget.Name = "lvBudget"
        Me.lvBudget.Size = New System.Drawing.Size(1001, 491)
        Me.lvBudget.TabIndex = 133
        Me.lvBudget.UseCompatibleStateImageBehavior = False
        Me.lvBudget.View = System.Windows.Forms.View.Details
        '
        'col_Budget_Detail_Id
        '
        Me.col_Budget_Detail_Id.Text = ""
        Me.col_Budget_Detail_Id.Width = 0
        '
        'col_Annual_Budget
        '
        Me.col_Annual_Budget.Width = 0
        '
        'col_Idx
        '
        Me.col_Idx.Width = 0
        '
        'col_Number
        '
        Me.col_Number.Text = ""
        Me.col_Number.Width = 0
        '
        'col_Cost_Id
        '
        Me.col_Cost_Id.Text = "รหัส"
        Me.col_Cost_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Cost_Id.Width = 83
        '
        'col_Cost_Name
        '
        Me.col_Cost_Name.Text = "ชื่อรายการค่าใช้จ่าย"
        Me.col_Cost_Name.Width = 291
        '
        'col_Plan_Rate
        '
        Me.col_Plan_Rate.Text = "อัตรา (บาท)"
        Me.col_Plan_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Plan_Rate.Width = 134
        '
        'col_Plan_Qty_People
        '
        Me.col_Plan_Qty_People.Text = "จำนวนคน"
        Me.col_Plan_Qty_People.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Plan_Qty_People.Width = 66
        '
        'col_Plan_Amt_Money
        '
        Me.col_Plan_Amt_Money.Text = "จำนวนเงิน"
        Me.col_Plan_Amt_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_Plan_Amt_Money.Width = 112
        '
        'col_Actual_Rate
        '
        Me.col_Actual_Rate.Text = "อัตรา(บาท)"
        Me.col_Actual_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Actual_Rate.Width = 125
        '
        'col_Actual_Qty_People
        '
        Me.col_Actual_Qty_People.Text = "จำนวนคน"
        Me.col_Actual_Qty_People.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Actual_Qty_People.Width = 72
        '
        'col_Actual_Amt_Money
        '
        Me.col_Actual_Amt_Money.Text = "จำนวนเงิน"
        Me.col_Actual_Amt_Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_Actual_Amt_Money.Width = 112
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "ค่าใช้จ่ายประมาณการเฉลี่ย/คน:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(837, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "บาท"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(269, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "บาท"
        '
        'txtPlan_avg
        '
        Me.txtPlan_avg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPlan_avg.Location = New System.Drawing.Point(193, 12)
        Me.txtPlan_avg.Name = "txtPlan_avg"
        Me.txtPlan_avg.Size = New System.Drawing.Size(74, 20)
        Me.txtPlan_avg.TabIndex = 128
        '
        'lbl_budget_plan
        '
        Me.lbl_budget_plan.BackColor = System.Drawing.Color.White
        Me.lbl_budget_plan.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.lbl_budget_plan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lbl_budget_plan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_budget_plan.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_budget_plan.Location = New System.Drawing.Point(380, 3)
        Me.lbl_budget_plan.Name = "lbl_budget_plan"
        Me.lbl_budget_plan.Size = New System.Drawing.Size(301, 33)
        Me.lbl_budget_plan.TabIndex = 2
        Me.lbl_budget_plan.Text = "ค่าใช้จ่ายประมาณการ"
        Me.lbl_budget_plan.UseVisualStyleBackColor = False
        '
        'lbl_budget
        '
        Me.lbl_budget.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbl_budget.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.lbl_budget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lbl_budget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_budget.Location = New System.Drawing.Point(3, 3)
        Me.lbl_budget.Name = "lbl_budget"
        Me.lbl_budget.Size = New System.Drawing.Size(371, 33)
        Me.lbl_budget.TabIndex = 104
        Me.lbl_budget.Text = "รายการค่าใช้จ่าย"
        Me.lbl_budget.UseVisualStyleBackColor = True
        '
        'lbl_budget_actual
        '
        Me.lbl_budget_actual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_budget_actual.BackColor = System.Drawing.Color.White
        Me.lbl_budget_actual.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.lbl_budget_actual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lbl_budget_actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_budget_actual.ForeColor = System.Drawing.Color.Red
        Me.lbl_budget_actual.Location = New System.Drawing.Point(687, 3)
        Me.lbl_budget_actual.Name = "lbl_budget_actual"
        Me.lbl_budget_actual.Size = New System.Drawing.Size(314, 33)
        Me.lbl_budget_actual.TabIndex = 105
        Me.lbl_budget_actual.Text = "ค่าใช้จ่ายจริง"
        Me.lbl_budget_actual.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtPlan_avg)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(392, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(305, 45)
        Me.Panel3.TabIndex = 135
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtActual_avg)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(703, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 45)
        Me.Panel4.TabIndex = 136
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "บาท"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(837, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "บาท"
        '
        'txtActual_avg
        '
        Me.txtActual_avg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtActual_avg.ForeColor = System.Drawing.Color.Red
        Me.txtActual_avg.Location = New System.Drawing.Point(171, 12)
        Me.txtActual_avg.Name = "txtActual_avg"
        Me.txtActual_avg.Size = New System.Drawing.Size(82, 20)
        Me.txtActual_avg.TabIndex = 131
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(35, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 13)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "ค่าใช้จ่ายจริงเฉลี่ย/คน:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.15759!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.84241!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_budget, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_budget_plan, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_budget_actual, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 120)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1004, 39)
        Me.TableLayoutPanel2.TabIndex = 137
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.57143!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.42857!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel4, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 666)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1002, 52)
        Me.TableLayoutPanel3.TabIndex = 138
        '
        'BG2_Input_Budget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "BG2_Input_Budget"
        Me.Text = "บันทึกค่าใช้จ่ายการพัฒนาบุคลากร"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_search_course As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPlan_avg As System.Windows.Forms.TextBox
    Friend WithEvents lbl_budget_plan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvBudget As System.Windows.Forms.ListView
    Friend WithEvents col_Budget_Detail_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Cost_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Cost_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Plan_Rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Plan_Qty_People As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Plan_Amt_Money As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Actual_Rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Actual_Qty_People As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Actual_Amt_Money As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_budget As System.Windows.Forms.Button
    Friend WithEvents lbl_budget_actual As System.Windows.Forms.Button
    Friend WithEvents txtAnnual As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtActual_avg As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_document_code As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnPopAnnual As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dtpBudget As System.Windows.Forms.DateTimePicker
    Friend WithEvents col_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Annual_Budget As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_edit_cost As System.Windows.Forms.TextBox
    Friend WithEvents col_Idx As System.Windows.Forms.ColumnHeader
End Class
