﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_DEV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_DEV))
        Me.ToScriptMain = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.col_Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDocNo = New System.Windows.Forms.Label()
        Me.txtAnnual_code = New System.Windows.Forms.TextBox()
        Me.col_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Station = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvRegister = New System.Windows.Forms.ListView()
        Me.Col_Checkbox = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Register_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Idx = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Join_Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.timeRegister = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel22 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btnCourse_Master = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cbbEdition = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpRegister = New System.Windows.Forms.DateTimePicker()
        Me.cbbCourse_master = New System.Windows.Forms.ComboBox()
        Me.cbbAnnual = New System.Windows.Forms.ComboBox()
        Me.PanelHead = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.ToScriptMain.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel22.SuspendLayout()
        Me.PanelHead.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToScriptMain
        '
        Me.ToScriptMain.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.ToScriptMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToScriptMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnClear, Me.btnClose})
        Me.ToScriptMain.Location = New System.Drawing.Point(0, 0)
        Me.ToScriptMain.Name = "ToScriptMain"
        Me.ToScriptMain.Size = New System.Drawing.Size(1008, 25)
        Me.ToScriptMain.TabIndex = 650
        Me.ToScriptMain.Text = "ToolStrip2"
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
        'col_Number
        '
        Me.col_Number.Text = "ลำดับ"
        Me.col_Number.Width = 64
        '
        'lblDocNo
        '
        Me.lblDocNo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDocNo.AutoSize = True
        Me.lblDocNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDocNo.Location = New System.Drawing.Point(49, 7)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(68, 16)
        Me.lblDocNo.TabIndex = 1
        Me.lblDocNo.Text = "เลขที่เอกสาร:"
        '
        'txtAnnual_code
        '
        Me.txtAnnual_code.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAnnual_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAnnual_code.Location = New System.Drawing.Point(123, 4)
        Me.txtAnnual_code.Name = "txtAnnual_code"
        Me.txtAnnual_code.Size = New System.Drawing.Size(172, 22)
        Me.txtAnnual_code.TabIndex = 3
        '
        'col_Code
        '
        Me.col_Code.Text = "รหัสพนักงาน"
        Me.col_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Code.Width = 104
        '
        'col_Name
        '
        Me.col_Name.Text = "ชื่อ - สกุล"
        Me.col_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Name.Width = 277
        '
        'col_Station
        '
        Me.col_Station.Text = "หน่วยงาน"
        Me.col_Station.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Station.Width = 171
        '
        'col_Position
        '
        Me.col_Position.Text = "ตำแหน่ง"
        Me.col_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Position.Width = 244
        '
        'lvRegister
        '
        Me.lvRegister.CheckBoxes = True
        Me.lvRegister.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col_Checkbox, Me.col_Id, Me.col_Register_Id, Me.col_Idx, Me.col_Number, Me.col_Code, Me.col_Name, Me.col_Position, Me.col_Station, Me.col_Join_Time})
        Me.lvRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lvRegister.FullRowSelect = True
        Me.lvRegister.GridLines = True
        Me.lvRegister.LabelEdit = True
        Me.lvRegister.Location = New System.Drawing.Point(10, 104)
        Me.lvRegister.Name = "lvRegister"
        Me.lvRegister.Size = New System.Drawing.Size(998, 580)
        Me.lvRegister.TabIndex = 1
        Me.lvRegister.UseCompatibleStateImageBehavior = False
        Me.lvRegister.View = System.Windows.Forms.View.Details
        '
        'Col_Checkbox
        '
        Me.Col_Checkbox.Text = ""
        Me.Col_Checkbox.Width = 0
        '
        'col_Id
        '
        Me.col_Id.Width = 0
        '
        'col_Register_Id
        '
        Me.col_Register_Id.Width = 0
        '
        'col_Idx
        '
        Me.col_Idx.Width = 0
        '
        'col_Join_Time
        '
        Me.col_Join_Time.Text = "ลงเวลา"
        Me.col_Join_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.col_Join_Time.Width = 90
        '
        'PanelMain
        '
        Me.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelMain.Controls.Add(Me.timeRegister)
        Me.PanelMain.Controls.Add(Me.Panel3)
        Me.PanelMain.Controls.Add(Me.PanelHead)
        Me.PanelMain.Controls.Add(Me.lvRegister)
        Me.PanelMain.Location = New System.Drawing.Point(0, 26)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1008, 691)
        Me.PanelMain.TabIndex = 651
        '
        'timeRegister
        '
        Me.timeRegister.CustomFormat = "HH:mm:ss"
        Me.timeRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeRegister.Location = New System.Drawing.Point(348, 259)
        Me.timeRegister.Name = "timeRegister"
        Me.timeRegister.ShowUpDown = True
        Me.timeRegister.Size = New System.Drawing.Size(87, 20)
        Me.timeRegister.TabIndex = 16
        Me.timeRegister.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.TableLayoutPanel22)
        Me.Panel3.Location = New System.Drawing.Point(3, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(997, 45)
        Me.Panel3.TabIndex = 15
        '
        'TableLayoutPanel22
        '
        Me.TableLayoutPanel22.ColumnCount = 10
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.48443!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.51557!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel22.Controls.Add(Me.lbl_date, 8, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.btnCourse_Master, 0, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.Button6, 2, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.cbbYear, 3, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.Button5, 4, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.cbbEdition, 5, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.Button1, 6, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.dtpRegister, 9, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.cbbCourse_master, 1, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.cbbAnnual, 7, 0)
        Me.TableLayoutPanel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel22.Location = New System.Drawing.Point(2, 6)
        Me.TableLayoutPanel22.Name = "TableLayoutPanel22"
        Me.TableLayoutPanel22.RowCount = 1
        Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel22.Size = New System.Drawing.Size(988, 30)
        Me.TableLayoutPanel22.TabIndex = 14
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(794, 7)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(31, 15)
        Me.lbl_date.TabIndex = 0
        Me.lbl_date.Text = "วันที่:"
        '
        'btnCourse_Master
        '
        Me.btnCourse_Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCourse_Master.Location = New System.Drawing.Point(3, 3)
        Me.btnCourse_Master.Name = "btnCourse_Master"
        Me.btnCourse_Master.Size = New System.Drawing.Size(106, 24)
        Me.btnCourse_Master.TabIndex = 9
        Me.btnCourse_Master.Text = "หลักสูตรการพัฒนา"
        Me.btnCourse_Master.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(279, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(48, 23)
        Me.Button6.TabIndex = 144
        Me.Button6.Text = "เลือกปี"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'cbbYear
        '
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Location = New System.Drawing.Point(333, 3)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(52, 23)
        Me.cbbYear.TabIndex = 145
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(391, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 24)
        Me.Button5.TabIndex = 143
        Me.Button5.Text = "รุ่นที่"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cbbEdition
        '
        Me.cbbEdition.FormattingEnabled = True
        Me.cbbEdition.Location = New System.Drawing.Point(435, 3)
        Me.cbbEdition.Name = "cbbEdition"
        Me.cbbEdition.Size = New System.Drawing.Size(56, 23)
        Me.cbbEdition.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(497, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 146
        Me.Button1.Text = "แผนพัฒนาประจำปี"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpRegister
        '
        Me.dtpRegister.Location = New System.Drawing.Point(831, 3)
        Me.dtpRegister.Name = "dtpRegister"
        Me.dtpRegister.Size = New System.Drawing.Size(131, 21)
        Me.dtpRegister.TabIndex = 147
        '
        'cbbCourse_master
        '
        Me.cbbCourse_master.FormattingEnabled = True
        Me.cbbCourse_master.Location = New System.Drawing.Point(115, 3)
        Me.cbbCourse_master.Name = "cbbCourse_master"
        Me.cbbCourse_master.Size = New System.Drawing.Size(158, 23)
        Me.cbbCourse_master.TabIndex = 149
        '
        'cbbAnnual
        '
        Me.cbbAnnual.FormattingEnabled = True
        Me.cbbAnnual.Location = New System.Drawing.Point(614, 3)
        Me.cbbAnnual.Name = "cbbAnnual"
        Me.cbbAnnual.Size = New System.Drawing.Size(173, 23)
        Me.cbbAnnual.TabIndex = 150
        '
        'PanelHead
        '
        Me.PanelHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelHead.Controls.Add(Me.TableLayoutPanel11)
        Me.PanelHead.Location = New System.Drawing.Point(4, 3)
        Me.PanelHead.Name = "PanelHead"
        Me.PanelHead.Size = New System.Drawing.Size(997, 45)
        Me.PanelHead.TabIndex = 2
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.14575!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.85425!))
        Me.TableLayoutPanel11.Controls.Add(Me.lblDocNo, 0, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.txtAnnual_code, 1, 0)
        Me.TableLayoutPanel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(2, 6)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(988, 30)
        Me.TableLayoutPanel11.TabIndex = 14
        '
        'Register_DEV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.ToScriptMain)
        Me.Controls.Add(Me.PanelMain)
        Me.Name = "Register_DEV"
        Me.Text = "ลงทะเบียนเข้าร่วมการพัฒนา"
        Me.ToScriptMain.ResumeLayout(False)
        Me.ToScriptMain.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel22.ResumeLayout(False)
        Me.TableLayoutPanel22.PerformLayout()
        Me.PanelHead.ResumeLayout(False)
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents col_Number As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtAnnual_code As System.Windows.Forms.TextBox
    Friend WithEvents col_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Station As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Position As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvRegister As System.Windows.Forms.ListView
    Friend WithEvents col_Join_Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel22 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnCourse_Master As System.Windows.Forms.Button
    Friend WithEvents lblDocNo As System.Windows.Forms.Label
    Friend WithEvents PanelMain As System.Windows.Forms.Panel
    Friend WithEvents PanelHead As System.Windows.Forms.Panel

    Friend WithEvents cbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cbbEdition As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpRegister As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbbCourse_master As System.Windows.Forms.ComboBox
    Friend WithEvents cbbAnnual As System.Windows.Forms.ComboBox
    Friend WithEvents col_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToScriptMain As System.Windows.Forms.ToolStrip
    Friend WithEvents TableLayoutPanel11 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents col_Idx As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Register_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col_Checkbox As System.Windows.Forms.ColumnHeader
    Friend WithEvents timeRegister As System.Windows.Forms.DateTimePicker
End Class
