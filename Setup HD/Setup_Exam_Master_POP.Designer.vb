<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup_Exam_Master_POP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup_Exam_Master_POP))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnHdExam_detailEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnHdExam_detailRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnHdExam_detailDelete = New System.Windows.Forms.ToolStripButton()
        Me.lvExam_detail = New System.Windows.Forms.ListView()
        Me.col_Exam_Detail_No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Exam_Detail_Question_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Exam_Detail_Question = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Exam_Detail_Answer_obj = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Exam_Detail_Answer_sub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Exam_Detail_Score = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip13 = New System.Windows.Forms.ToolStrip()
        Me.btnHdExam_detailAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnHdExam_detailSave = New System.Windows.Forms.ToolStripButton()
        Me.btnHdExam_detailClear = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_score = New System.Windows.Forms.Button()
        Me.txtExdscore = New System.Windows.Forms.TextBox()
        Me.txtExd_answer_sub4 = New System.Windows.Forms.TextBox()
        Me.txtExd_answer_sub3 = New System.Windows.Forms.TextBox()
        Me.txtExd_answer_sub2 = New System.Windows.Forms.TextBox()
        Me.txtExdquestion = New System.Windows.Forms.TextBox()
        Me.lbl_question1 = New System.Windows.Forms.Label()
        Me.txtExdno = New System.Windows.Forms.TextBox()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.txtExd_answer_obj4 = New System.Windows.Forms.TextBox()
        Me.txtExd_answer_obj3 = New System.Windows.Forms.TextBox()
        Me.txtExd_answer_obj2 = New System.Windows.Forms.TextBox()
        Me.txtExd_answer_obj1 = New System.Windows.Forms.TextBox()
        Me.txtExdquestion2 = New System.Windows.Forms.TextBox()
        Me.lbl_question2 = New System.Windows.Forms.Label()
        Me.rbtExdquestion_type1 = New System.Windows.Forms.RadioButton()
        Me.rbtExdquestion_type2 = New System.Windows.Forms.RadioButton()
        Me.txtExd_answer_sub1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtExdanswer_obj4 = New System.Windows.Forms.RadioButton()
        Me.rbtExdanswer_obj1 = New System.Windows.Forms.RadioButton()
        Me.rbtExdanswer_obj2 = New System.Windows.Forms.RadioButton()
        Me.rbtExdanswer_obj3 = New System.Windows.Forms.RadioButton()
        Me.txtExd_id = New System.Windows.Forms.TextBox()
        Me.txtExd_status = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_code_test = New System.Windows.Forms.Label()
        Me.lbl_amount_test = New System.Windows.Forms.Label()
        Me.lbl_article = New System.Windows.Forms.Label()
        Me.lbl_score2 = New System.Windows.Forms.Label()
        Me.txtExmcode = New System.Windows.Forms.TextBox()
        Me.txtExmName = New System.Windows.Forms.TextBox()
        Me.lbl_name_test1 = New System.Windows.Forms.Label()
        Me.lbl_name_test2 = New System.Windows.Forms.Label()
        Me.txtExmname2 = New System.Windows.Forms.TextBox()
        Me.lbl_score1 = New System.Windows.Forms.Label()
        Me.lbl_full_score = New System.Windows.Forms.Label()
        Me.txtExmscore = New System.Windows.Forms.TextBox()
        Me.txtExmpass_exam = New System.Windows.Forms.TextBox()
        Me.lbl_score_recommand = New System.Windows.Forms.Label()
        Me.txtExmqty = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnHdExam_masterSave = New System.Windows.Forms.ToolStripButton()
        Me.btnHdExam_masterClear = New System.Windows.Forms.ToolStripButton()
        Me.btnHdExam_masterClose = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip13.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 703)
        Me.GroupBox1.TabIndex = 644
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ToolStrip2)
        Me.GroupBox4.Controls.Add(Me.lvExam_detail)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 422)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(975, 275)
        Me.GroupBox4.TabIndex = 639
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "จำนวนข้อสอบ"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHdExam_detailEdit, Me.btnHdExam_detailRefresh, Me.btnHdExam_detailDelete})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(969, 25)
        Me.ToolStrip2.TabIndex = 132
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnHdExam_detailEdit
        '
        Me.btnHdExam_detailEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHdExam_detailEdit.Image = Global.Human_Development.My.Resources.Resources._32_26
        Me.btnHdExam_detailEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_detailEdit.Name = "btnHdExam_detailEdit"
        Me.btnHdExam_detailEdit.Size = New System.Drawing.Size(23, 22)
        Me.btnHdExam_detailEdit.Text = "แก้ไข"
        '
        'btnHdExam_detailRefresh
        '
        Me.btnHdExam_detailRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHdExam_detailRefresh.Image = Global.Human_Development.My.Resources.Resources._5_26
        Me.btnHdExam_detailRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_detailRefresh.Name = "btnHdExam_detailRefresh"
        Me.btnHdExam_detailRefresh.Size = New System.Drawing.Size(23, 22)
        Me.btnHdExam_detailRefresh.Text = "รีเฟรช"
        '
        'btnHdExam_detailDelete
        '
        Me.btnHdExam_detailDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHdExam_detailDelete.Image = Global.Human_Development.My.Resources.Resources.deleate26
        Me.btnHdExam_detailDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_detailDelete.Name = "btnHdExam_detailDelete"
        Me.btnHdExam_detailDelete.Size = New System.Drawing.Size(23, 22)
        Me.btnHdExam_detailDelete.Text = "ลบ"
        '
        'lvExam_detail
        '
        Me.lvExam_detail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Exam_Detail_No, Me.col_Exam_Detail_Question_type, Me.col_Exam_Detail_Question, Me.col_Exam_Detail_Answer_obj, Me.col_Exam_Detail_Answer_sub, Me.col_Exam_Detail_Score})
        Me.lvExam_detail.GridLines = True
        Me.lvExam_detail.Location = New System.Drawing.Point(2, 46)
        Me.lvExam_detail.Name = "lvExam_detail"
        Me.lvExam_detail.Size = New System.Drawing.Size(970, 224)
        Me.lvExam_detail.TabIndex = 0
        Me.lvExam_detail.UseCompatibleStateImageBehavior = False
        Me.lvExam_detail.View = System.Windows.Forms.View.Details
        '
        'col_Exam_Detail_No
        '
        Me.col_Exam_Detail_No.Text = "ข้อที่"
        Me.col_Exam_Detail_No.Width = 39
        '
        'col_Exam_Detail_Question_type
        '
        Me.col_Exam_Detail_Question_type.Text = "ประเภทข้อสอบ"
        Me.col_Exam_Detail_Question_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Exam_Detail_Question_type.Width = 96
        '
        'col_Exam_Detail_Question
        '
        Me.col_Exam_Detail_Question.Text = "คำถาม"
        Me.col_Exam_Detail_Question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Exam_Detail_Question.Width = 281
        '
        'col_Exam_Detail_Answer_obj
        '
        Me.col_Exam_Detail_Answer_obj.Text = "คำตอบปรนัย"
        Me.col_Exam_Detail_Answer_obj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Exam_Detail_Answer_obj.Width = 91
        '
        'col_Exam_Detail_Answer_sub
        '
        Me.col_Exam_Detail_Answer_sub.Text = "คำตอบอัตนัย"
        Me.col_Exam_Detail_Answer_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Exam_Detail_Answer_sub.Width = 406
        '
        'col_Exam_Detail_Score
        '
        Me.col_Exam_Detail_Score.Text = "คะแนน"
        Me.col_Exam_Detail_Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Exam_Detail_Score.Width = 53
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStrip13)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(975, 291)
        Me.GroupBox3.TabIndex = 638
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ข้อสอบ"
        '
        'ToolStrip13
        '
        Me.ToolStrip13.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip13.BackgroundImage = Global.Human_Development.My.Resources.Resources.head3
        Me.ToolStrip13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHdExam_detailAdd, Me.btnHdExam_detailSave, Me.btnHdExam_detailClear})
        Me.ToolStrip13.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip13.Name = "ToolStrip13"
        Me.ToolStrip13.Size = New System.Drawing.Size(969, 25)
        Me.ToolStrip13.TabIndex = 131
        Me.ToolStrip13.Text = "ToolStrip13"
        '
        'btnHdExam_detailAdd
        '
        Me.btnHdExam_detailAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHdExam_detailAdd.Image = Global.Human_Development.My.Resources.Resources.add26
        Me.btnHdExam_detailAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_detailAdd.Name = "btnHdExam_detailAdd"
        Me.btnHdExam_detailAdd.Size = New System.Drawing.Size(23, 22)
        Me.btnHdExam_detailAdd.Text = "เพิ่ม"
        Me.btnHdExam_detailAdd.ToolTipText = "เพิ่ม"
        '
        'btnHdExam_detailSave
        '
        Me.btnHdExam_detailSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHdExam_detailSave.Image = Global.Human_Development.My.Resources.Resources._9_26
        Me.btnHdExam_detailSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_detailSave.Name = "btnHdExam_detailSave"
        Me.btnHdExam_detailSave.Size = New System.Drawing.Size(23, 22)
        Me.btnHdExam_detailSave.Text = "บันทึก"
        '
        'btnHdExam_detailClear
        '
        Me.btnHdExam_detailClear.Image = CType(resources.GetObject("btnHdExam_detailClear.Image"), System.Drawing.Image)
        Me.btnHdExam_detailClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_detailClear.Name = "btnHdExam_detailClear"
        Me.btnHdExam_detailClear.Size = New System.Drawing.Size(23, 22)
        Me.btnHdExam_detailClear.ToolTipText = "ล้างข้อมูล"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.73603!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.26397!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_score, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExdscore, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_sub4, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_sub3, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_sub2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExdquestion, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_question1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExdno, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_no, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_obj4, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_obj3, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_obj2, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_obj1, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExdquestion2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_question2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.rbtExdquestion_type1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.rbtExdquestion_type2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_answer_sub1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_id, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtExd_status, 4, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 47)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(963, 238)
        Me.TableLayoutPanel1.TabIndex = 130
        '
        'btn_score
        '
        Me.btn_score.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_score.Location = New System.Drawing.Point(465, 179)
        Me.btn_score.Name = "btn_score"
        Me.btn_score.Size = New System.Drawing.Size(53, 21)
        Me.btn_score.TabIndex = 151
        Me.btn_score.Text = "คะแนน"
        Me.btn_score.UseVisualStyleBackColor = True
        '
        'txtExdscore
        '
        Me.txtExdscore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExdscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExdscore.Location = New System.Drawing.Point(525, 179)
        Me.txtExdscore.Name = "txtExdscore"
        Me.txtExdscore.Size = New System.Drawing.Size(44, 21)
        Me.txtExdscore.TabIndex = 20
        Me.txtExdscore.Text = "0"
        Me.txtExdscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtExd_answer_sub4
        '
        Me.txtExd_answer_sub4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_sub4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_sub4.Location = New System.Drawing.Point(108, 210)
        Me.txtExd_answer_sub4.Name = "txtExd_answer_sub4"
        Me.txtExd_answer_sub4.Size = New System.Drawing.Size(350, 21)
        Me.txtExd_answer_sub4.TabIndex = 13
        '
        'txtExd_answer_sub3
        '
        Me.txtExd_answer_sub3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_sub3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_sub3.Location = New System.Drawing.Point(108, 179)
        Me.txtExd_answer_sub3.Name = "txtExd_answer_sub3"
        Me.txtExd_answer_sub3.Size = New System.Drawing.Size(350, 21)
        Me.txtExd_answer_sub3.TabIndex = 12
        '
        'txtExd_answer_sub2
        '
        Me.txtExd_answer_sub2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_sub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_sub2.Location = New System.Drawing.Point(108, 147)
        Me.txtExd_answer_sub2.Name = "txtExd_answer_sub2"
        Me.txtExd_answer_sub2.Size = New System.Drawing.Size(350, 21)
        Me.txtExd_answer_sub2.TabIndex = 11
        '
        'txtExdquestion
        '
        Me.txtExdquestion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExdquestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExdquestion.Location = New System.Drawing.Point(108, 42)
        Me.txtExdquestion.Name = "txtExdquestion"
        Me.txtExdquestion.Size = New System.Drawing.Size(350, 21)
        Me.txtExdquestion.TabIndex = 8
        '
        'lbl_question1
        '
        Me.lbl_question1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_question1.AutoSize = True
        Me.lbl_question1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_question1.Location = New System.Drawing.Point(15, 45)
        Me.lbl_question1.Name = "lbl_question1"
        Me.lbl_question1.Size = New System.Drawing.Size(87, 15)
        Me.lbl_question1.TabIndex = 123
        Me.lbl_question1.Text = "คำถาม (ภาษา 1):"
        Me.lbl_question1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExdno
        '
        Me.txtExdno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExdno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExdno.Location = New System.Drawing.Point(108, 7)
        Me.txtExdno.Name = "txtExdno"
        Me.txtExdno.Size = New System.Drawing.Size(63, 21)
        Me.txtExdno.TabIndex = 7
        '
        'lbl_no
        '
        Me.lbl_no.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(72, 10)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(30, 15)
        Me.lbl_no.TabIndex = 121
        Me.lbl_no.Text = "ข้อที่:"
        Me.lbl_no.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExd_answer_obj4
        '
        Me.txtExd_answer_obj4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_obj4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_obj4.Location = New System.Drawing.Point(575, 147)
        Me.txtExd_answer_obj4.Name = "txtExd_answer_obj4"
        Me.txtExd_answer_obj4.Size = New System.Drawing.Size(357, 21)
        Me.txtExd_answer_obj4.TabIndex = 18
        '
        'txtExd_answer_obj3
        '
        Me.txtExd_answer_obj3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_obj3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_obj3.Location = New System.Drawing.Point(575, 112)
        Me.txtExd_answer_obj3.Name = "txtExd_answer_obj3"
        Me.txtExd_answer_obj3.Size = New System.Drawing.Size(357, 21)
        Me.txtExd_answer_obj3.TabIndex = 17
        '
        'txtExd_answer_obj2
        '
        Me.txtExd_answer_obj2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_obj2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_obj2.Location = New System.Drawing.Point(575, 77)
        Me.txtExd_answer_obj2.Name = "txtExd_answer_obj2"
        Me.txtExd_answer_obj2.Size = New System.Drawing.Size(357, 21)
        Me.txtExd_answer_obj2.TabIndex = 16
        '
        'txtExd_answer_obj1
        '
        Me.txtExd_answer_obj1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_obj1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_obj1.Location = New System.Drawing.Point(575, 42)
        Me.txtExd_answer_obj1.Name = "txtExd_answer_obj1"
        Me.txtExd_answer_obj1.Size = New System.Drawing.Size(357, 21)
        Me.txtExd_answer_obj1.TabIndex = 15
        '
        'txtExdquestion2
        '
        Me.txtExdquestion2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExdquestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExdquestion2.Location = New System.Drawing.Point(108, 77)
        Me.txtExdquestion2.Name = "txtExdquestion2"
        Me.txtExdquestion2.Size = New System.Drawing.Size(350, 21)
        Me.txtExdquestion2.TabIndex = 9
        '
        'lbl_question2
        '
        Me.lbl_question2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_question2.AutoSize = True
        Me.lbl_question2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_question2.Location = New System.Drawing.Point(15, 80)
        Me.lbl_question2.Name = "lbl_question2"
        Me.lbl_question2.Size = New System.Drawing.Size(87, 15)
        Me.lbl_question2.TabIndex = 125
        Me.lbl_question2.Text = "คำถาม (ภาษา 2):"
        Me.lbl_question2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbtExdquestion_type1
        '
        Me.rbtExdquestion_type1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.rbtExdquestion_type1.AutoSize = True
        Me.rbtExdquestion_type1.Location = New System.Drawing.Point(49, 114)
        Me.rbtExdquestion_type1.Name = "rbtExdquestion_type1"
        Me.rbtExdquestion_type1.Size = New System.Drawing.Size(53, 17)
        Me.rbtExdquestion_type1.TabIndex = 161
        Me.rbtExdquestion_type1.TabStop = True
        Me.rbtExdquestion_type1.Text = "อัตนัย"
        Me.rbtExdquestion_type1.UseVisualStyleBackColor = True
        '
        'rbtExdquestion_type2
        '
        Me.rbtExdquestion_type2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.rbtExdquestion_type2.AutoSize = True
        Me.rbtExdquestion_type2.Location = New System.Drawing.Point(466, 9)
        Me.rbtExdquestion_type2.Name = "rbtExdquestion_type2"
        Me.rbtExdquestion_type2.Size = New System.Drawing.Size(53, 17)
        Me.rbtExdquestion_type2.TabIndex = 162
        Me.rbtExdquestion_type2.TabStop = True
        Me.rbtExdquestion_type2.Text = "ปรนัย"
        Me.rbtExdquestion_type2.UseVisualStyleBackColor = True
        '
        'txtExd_answer_sub1
        '
        Me.txtExd_answer_sub1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_answer_sub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExd_answer_sub1.Location = New System.Drawing.Point(108, 112)
        Me.txtExd_answer_sub1.Name = "txtExd_answer_sub1"
        Me.txtExd_answer_sub1.Size = New System.Drawing.Size(350, 21)
        Me.txtExd_answer_sub1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtExdanswer_obj4)
        Me.Panel1.Controls.Add(Me.rbtExdanswer_obj1)
        Me.Panel1.Controls.Add(Me.rbtExdanswer_obj2)
        Me.Panel1.Controls.Add(Me.rbtExdanswer_obj3)
        Me.Panel1.Location = New System.Drawing.Point(525, 38)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel1, 4)
        Me.Panel1.Size = New System.Drawing.Size(44, 133)
        Me.Panel1.TabIndex = 163
        '
        'rbtExdanswer_obj4
        '
        Me.rbtExdanswer_obj4.AutoSize = True
        Me.rbtExdanswer_obj4.Location = New System.Drawing.Point(6, 109)
        Me.rbtExdanswer_obj4.Name = "rbtExdanswer_obj4"
        Me.rbtExdanswer_obj4.Size = New System.Drawing.Size(33, 17)
        Me.rbtExdanswer_obj4.TabIndex = 3
        Me.rbtExdanswer_obj4.TabStop = True
        Me.rbtExdanswer_obj4.Text = "ง."
        Me.rbtExdanswer_obj4.UseVisualStyleBackColor = True
        '
        'rbtExdanswer_obj1
        '
        Me.rbtExdanswer_obj1.AutoSize = True
        Me.rbtExdanswer_obj1.Location = New System.Drawing.Point(6, 7)
        Me.rbtExdanswer_obj1.Name = "rbtExdanswer_obj1"
        Me.rbtExdanswer_obj1.Size = New System.Drawing.Size(35, 17)
        Me.rbtExdanswer_obj1.TabIndex = 0
        Me.rbtExdanswer_obj1.TabStop = True
        Me.rbtExdanswer_obj1.Text = "ก."
        Me.rbtExdanswer_obj1.UseVisualStyleBackColor = True
        '
        'rbtExdanswer_obj2
        '
        Me.rbtExdanswer_obj2.AutoSize = True
        Me.rbtExdanswer_obj2.Location = New System.Drawing.Point(6, 43)
        Me.rbtExdanswer_obj2.Name = "rbtExdanswer_obj2"
        Me.rbtExdanswer_obj2.Size = New System.Drawing.Size(34, 17)
        Me.rbtExdanswer_obj2.TabIndex = 1
        Me.rbtExdanswer_obj2.TabStop = True
        Me.rbtExdanswer_obj2.Text = "ข."
        Me.rbtExdanswer_obj2.UseVisualStyleBackColor = True
        '
        'rbtExdanswer_obj3
        '
        Me.rbtExdanswer_obj3.AutoSize = True
        Me.rbtExdanswer_obj3.Location = New System.Drawing.Point(6, 76)
        Me.rbtExdanswer_obj3.Name = "rbtExdanswer_obj3"
        Me.rbtExdanswer_obj3.Size = New System.Drawing.Size(35, 17)
        Me.rbtExdanswer_obj3.TabIndex = 2
        Me.rbtExdanswer_obj3.TabStop = True
        Me.rbtExdanswer_obj3.Text = "ค."
        Me.rbtExdanswer_obj3.UseVisualStyleBackColor = True
        '
        'txtExd_id
        '
        Me.txtExd_id.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtExd_id.Location = New System.Drawing.Point(575, 7)
        Me.txtExd_id.Name = "txtExd_id"
        Me.txtExd_id.Size = New System.Drawing.Size(357, 20)
        Me.txtExd_id.TabIndex = 14
        Me.txtExd_id.Visible = False
        '
        'txtExd_status
        '
        Me.txtExd_status.Enabled = False
        Me.txtExd_status.Location = New System.Drawing.Point(575, 178)
        Me.txtExd_status.Name = "txtExd_status"
        Me.txtExd_status.Size = New System.Drawing.Size(357, 20)
        Me.txtExd_status.TabIndex = 19
        Me.txtExd_status.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(975, 108)
        Me.GroupBox2.TabIndex = 637
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ชุดแบบทดสอบ"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.64608!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09739!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.35155!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.026129!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.87886!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_code_test, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_amount_test, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_article, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_score2, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtExmcode, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtExmName, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_name_test1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_name_test2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtExmname2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_score1, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_full_score, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtExmscore, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtExmpass_exam, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_score_recommand, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtExmqty, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(969, 84)
        Me.TableLayoutPanel2.TabIndex = 115
        '
        'lbl_code_test
        '
        Me.lbl_code_test.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_code_test.AutoSize = True
        Me.lbl_code_test.Location = New System.Drawing.Point(79, 6)
        Me.lbl_code_test.Name = "lbl_code_test"
        Me.lbl_code_test.Size = New System.Drawing.Size(98, 15)
        Me.lbl_code_test.TabIndex = 115
        Me.lbl_code_test.Text = "รหัสชุดแบบทดสอบ:"
        Me.lbl_code_test.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_amount_test
        '
        Me.lbl_amount_test.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_amount_test.AutoSize = True
        Me.lbl_amount_test.Location = New System.Drawing.Point(502, 6)
        Me.lbl_amount_test.Name = "lbl_amount_test"
        Me.lbl_amount_test.Size = New System.Drawing.Size(75, 15)
        Me.lbl_amount_test.TabIndex = 138
        Me.lbl_amount_test.Text = "จำนวนข้อสอบ:"
        Me.lbl_amount_test.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_article
        '
        Me.lbl_article.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_article.AutoSize = True
        Me.lbl_article.Location = New System.Drawing.Point(670, 6)
        Me.lbl_article.Name = "lbl_article"
        Me.lbl_article.Size = New System.Drawing.Size(20, 15)
        Me.lbl_article.TabIndex = 148
        Me.lbl_article.Text = "ข้อ"
        Me.lbl_article.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_score2
        '
        Me.lbl_score2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_score2.AutoSize = True
        Me.lbl_score2.Location = New System.Drawing.Point(670, 61)
        Me.lbl_score2.Name = "lbl_score2"
        Me.lbl_score2.Size = New System.Drawing.Size(43, 15)
        Me.lbl_score2.TabIndex = 149
        Me.lbl_score2.Text = "คะแนน"
        Me.lbl_score2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExmcode
        '
        Me.txtExmcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExmcode.Location = New System.Drawing.Point(217, 3)
        Me.txtExmcode.Name = "txtExmcode"
        Me.txtExmcode.Size = New System.Drawing.Size(206, 21)
        Me.txtExmcode.TabIndex = 1
        '
        'txtExmName
        '
        Me.txtExmName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExmName.Location = New System.Drawing.Point(217, 30)
        Me.txtExmName.Name = "txtExmName"
        Me.txtExmName.Size = New System.Drawing.Size(206, 21)
        Me.txtExmName.TabIndex = 2
        '
        'lbl_name_test1
        '
        Me.lbl_name_test1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_name_test1.AutoSize = True
        Me.lbl_name_test1.Location = New System.Drawing.Point(36, 33)
        Me.lbl_name_test1.Name = "lbl_name_test1"
        Me.lbl_name_test1.Size = New System.Drawing.Size(141, 15)
        Me.lbl_name_test1.TabIndex = 117
        Me.lbl_name_test1.Text = "ชื่อชุดแบบทดสอบ (ภาษา 1) :"
        Me.lbl_name_test1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_name_test2
        '
        Me.lbl_name_test2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_name_test2.AutoSize = True
        Me.lbl_name_test2.Location = New System.Drawing.Point(36, 61)
        Me.lbl_name_test2.Name = "lbl_name_test2"
        Me.lbl_name_test2.Size = New System.Drawing.Size(141, 15)
        Me.lbl_name_test2.TabIndex = 143
        Me.lbl_name_test2.Text = "ชื่อชุดแบบทดสอบ (ภาษา 2) :"
        Me.lbl_name_test2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExmname2
        '
        Me.txtExmname2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExmname2.Location = New System.Drawing.Point(217, 58)
        Me.txtExmname2.Name = "txtExmname2"
        Me.txtExmname2.Size = New System.Drawing.Size(206, 21)
        Me.txtExmname2.TabIndex = 3
        '
        'lbl_score1
        '
        Me.lbl_score1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbl_score1.AutoSize = True
        Me.lbl_score1.Location = New System.Drawing.Point(670, 33)
        Me.lbl_score1.Name = "lbl_score1"
        Me.lbl_score1.Size = New System.Drawing.Size(43, 15)
        Me.lbl_score1.TabIndex = 150
        Me.lbl_score1.Text = "คะแนน"
        Me.lbl_score1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_full_score
        '
        Me.lbl_full_score.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_full_score.AutoSize = True
        Me.lbl_full_score.Location = New System.Drawing.Point(512, 33)
        Me.lbl_full_score.Name = "lbl_full_score"
        Me.lbl_full_score.Size = New System.Drawing.Size(65, 15)
        Me.lbl_full_score.TabIndex = 123
        Me.lbl_full_score.Text = "คะแนนเต็ม:"
        Me.lbl_full_score.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExmscore
        '
        Me.txtExmscore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExmscore.Location = New System.Drawing.Point(593, 30)
        Me.txtExmscore.Name = "txtExmscore"
        Me.txtExmscore.Size = New System.Drawing.Size(61, 21)
        Me.txtExmscore.TabIndex = 5
        Me.txtExmscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExmpass_exam
        '
        Me.txtExmpass_exam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExmpass_exam.Location = New System.Drawing.Point(593, 58)
        Me.txtExmpass_exam.Name = "txtExmpass_exam"
        Me.txtExmpass_exam.Size = New System.Drawing.Size(61, 21)
        Me.txtExmpass_exam.TabIndex = 6
        Me.txtExmpass_exam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_score_recommand
        '
        Me.lbl_score_recommand.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_score_recommand.AutoSize = True
        Me.lbl_score_recommand.Location = New System.Drawing.Point(482, 61)
        Me.lbl_score_recommand.Name = "lbl_score_recommand"
        Me.lbl_score_recommand.Size = New System.Drawing.Size(95, 15)
        Me.lbl_score_recommand.TabIndex = 145
        Me.lbl_score_recommand.Text = "คะแนนผ่านเกณฑ์:"
        Me.lbl_score_recommand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtExmqty
        '
        Me.txtExmqty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtExmqty.Location = New System.Drawing.Point(592, 3)
        Me.txtExmqty.Name = "txtExmqty"
        Me.txtExmqty.Size = New System.Drawing.Size(63, 21)
        Me.txtExmqty.TabIndex = 4
        Me.txtExmqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHdExam_masterSave, Me.btnHdExam_masterClear, Me.btnHdExam_masterClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip1.TabIndex = 643
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnHdExam_masterSave
        '
        Me.btnHdExam_masterSave.Image = Global.Human_Development.My.Resources.Resources._9_26
        Me.btnHdExam_masterSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_masterSave.Name = "btnHdExam_masterSave"
        Me.btnHdExam_masterSave.Size = New System.Drawing.Size(55, 22)
        Me.btnHdExam_masterSave.Text = "บันทึก"
        Me.btnHdExam_masterSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHdExam_masterClear
        '
        Me.btnHdExam_masterClear.Image = CType(resources.GetObject("btnHdExam_masterClear.Image"), System.Drawing.Image)
        Me.btnHdExam_masterClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_masterClear.Name = "btnHdExam_masterClear"
        Me.btnHdExam_masterClear.Size = New System.Drawing.Size(69, 22)
        Me.btnHdExam_masterClear.Text = "ล้างข้อมูล"
        '
        'btnHdExam_masterClose
        '
        Me.btnHdExam_masterClose.Image = CType(resources.GetObject("btnHdExam_masterClose.Image"), System.Drawing.Image)
        Me.btnHdExam_masterClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHdExam_masterClose.Name = "btnHdExam_masterClose"
        Me.btnHdExam_masterClose.Size = New System.Drawing.Size(77, 22)
        Me.btnHdExam_masterClose.Text = "ปิดหน้าต่าง"
        '
        'Setup_Exam_Master_POP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setup_Exam_Master_POP"
        Me.Text = "เพิ่ม/ แก้ไขข้อสอบ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip13.ResumeLayout(False)
        Me.ToolStrip13.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_question2 As System.Windows.Forms.Label
    Friend WithEvents lbl_no As System.Windows.Forms.Label
    Friend WithEvents txtExdno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_question1 As System.Windows.Forms.Label
    Friend WithEvents txtExdquestion As System.Windows.Forms.TextBox
    Friend WithEvents txtExdquestion2 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHdExam_masterSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHdExam_masterClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHdExam_masterClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtExd_answer_sub1 As System.Windows.Forms.TextBox
    Friend WithEvents txtExd_answer_sub2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_score As System.Windows.Forms.Button
    Friend WithEvents txtExdscore As System.Windows.Forms.TextBox
    Friend WithEvents txtExd_answer_sub3 As System.Windows.Forms.TextBox
    Friend WithEvents txtExd_answer_sub4 As System.Windows.Forms.TextBox
    Friend WithEvents txtExd_answer_obj1 As System.Windows.Forms.TextBox
    Friend WithEvents txtExd_answer_obj2 As System.Windows.Forms.TextBox
    Friend WithEvents txtExd_answer_obj3 As System.Windows.Forms.TextBox
    Friend WithEvents txtExd_answer_obj4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lvExam_detail As System.Windows.Forms.ListView
    Friend WithEvents col_Exam_Detail_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Exam_Detail_Question_type As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Exam_Detail_Answer_obj As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Exam_Detail_Answer_sub As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Exam_Detail_Score As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHdExam_detailEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHdExam_detailRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHdExam_detailDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip13 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHdExam_detailSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnHdExam_detailClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents rbtExdquestion_type1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExdquestion_type2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExdanswer_obj4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExdanswer_obj3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExdanswer_obj2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtExdanswer_obj1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnHdExam_detailAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtExd_id As System.Windows.Forms.TextBox
    Friend WithEvents col_Exam_Detail_Question As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtExd_status As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_code_test As System.Windows.Forms.Label
    Friend WithEvents lbl_amount_test As System.Windows.Forms.Label
    Friend WithEvents lbl_article As System.Windows.Forms.Label
    Friend WithEvents lbl_score2 As System.Windows.Forms.Label
    Friend WithEvents txtExmcode As System.Windows.Forms.TextBox
    Friend WithEvents txtExmName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_name_test1 As System.Windows.Forms.Label
    Friend WithEvents lbl_name_test2 As System.Windows.Forms.Label
    Friend WithEvents txtExmname2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_score1 As System.Windows.Forms.Label
    Friend WithEvents lbl_full_score As System.Windows.Forms.Label
    Friend WithEvents txtExmscore As System.Windows.Forms.TextBox
    Friend WithEvents txtExmpass_exam As System.Windows.Forms.TextBox
    Friend WithEvents lbl_score_recommand As System.Windows.Forms.Label
    Friend WithEvents txtExmqty As System.Windows.Forms.TextBox
End Class
