<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_branch_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_select_branch_1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_branch = New MTGCComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cmdexit = New System.Windows.Forms.Button()
        Me.CmdPrint = New System.Windows.Forms.Button()
        Me.tbx_date_to = New System.Windows.Forms.MaskedTextBox()
        Me.tbx_date_from = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 81)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.55621!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.44379!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbo_branch, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(369, 77)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "สาขา :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbo_branch
        '
        Me.cbo_branch.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_branch.ArrowColor = System.Drawing.Color.Black
        'Me.cbo_branch.BindedControl = CType(resources.GetObject("cbo_branch.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_branch.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cbo_branch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_branch.ColumnNum = 2
        Me.cbo_branch.ColumnWidth = "150;0"
        Me.cbo_branch.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_branch.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_branch.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_branch.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_branch.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_branch.DisplayMember = "Text"
        Me.cbo_branch.Dock = System.Windows.Forms.DockStyle.Right
        Me.cbo_branch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_branch.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbo_branch.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_branch.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_branch.DropDownWidth = 170
        Me.cbo_branch.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_branch.GridLineHorizontal = True
        Me.cbo_branch.GridLineVertical = True
        Me.cbo_branch.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_branch.Location = New System.Drawing.Point(86, 8)
        Me.cbo_branch.ManagingFastMouseMoving = True
        Me.cbo_branch.ManagingFastMouseMovingInterval = 30
        Me.cbo_branch.Name = "cbo_branch"
        Me.cbo_branch.SelectedItem = Nothing
        Me.cbo_branch.SelectedValue = Nothing
        Me.cbo_branch.Size = New System.Drawing.Size(249, 21)
        Me.cbo_branch.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(49, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 31)
        Me.Label10.TabIndex = 755
        Me.Label10.Text = "วันที่:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.31148!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.68852!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_date_to, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_date_from, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(86, 35)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(249, 25)
        Me.TableLayoutPanel2.TabIndex = 756
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(110, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 26)
        Me.Label11.TabIndex = 756
        Me.Label11.Text = "ถึง"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmdexit
        '
        Me.Cmdexit.BackgroundImage = CType(resources.GetObject("Cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.Cmdexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cmdexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmdexit.Image = My.Resources.Resources.clear_20
        Me.Cmdexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmdexit.Location = New System.Drawing.Point(190, 99)
        Me.Cmdexit.Name = "Cmdexit"
        Me.Cmdexit.Size = New System.Drawing.Size(79, 34)
        Me.Cmdexit.TabIndex = 5
        Me.Cmdexit.Text = "   ยกเลิก"
        Me.Cmdexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmdexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmdexit.UseVisualStyleBackColor = True
        '
        'CmdPrint
        '
        Me.CmdPrint.BackgroundImage = CType(resources.GetObject("CmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.CmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdPrint.Image = My.Resources.Resources.select20
        Me.CmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPrint.Location = New System.Drawing.Point(105, 99)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(79, 34)
        Me.CmdPrint.TabIndex = 4
        Me.CmdPrint.Text = "ตกลง"
        Me.CmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdPrint.UseVisualStyleBackColor = True
        '
        'tbx_date_to
        '
        Me.tbx_date_to.Location = New System.Drawing.Point(153, 3)
        Me.tbx_date_to.Mask = "00/00/0000"
        Me.tbx_date_to.Name = "tbx_date_to"
        Me.tbx_date_to.Size = New System.Drawing.Size(93, 20)
        Me.tbx_date_to.TabIndex = 757
        Me.tbx_date_to.ValidatingType = GetType(Date)
        '
        'tbx_date_from
        '
        Me.tbx_date_from.Location = New System.Drawing.Point(3, 3)
        Me.tbx_date_from.Mask = "00/00/0000"
        Me.tbx_date_from.Name = "tbx_date_from"
        Me.tbx_date_from.Size = New System.Drawing.Size(101, 20)
        Me.tbx_date_from.TabIndex = 758
        Me.tbx_date_from.ValidatingType = GetType(Date)
        '
        'frm_select_branch_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(397, 147)
        Me.Controls.Add(Me.Cmdexit)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_select_branch_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch "
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_branch As MTGCComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbx_date_to As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbx_date_from As System.Windows.Forms.MaskedTextBox
End Class
