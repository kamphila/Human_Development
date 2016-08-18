<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Opt_HD_Rpt001
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Opt_HD_Rpt001))
        Me.cbo_branch = New MTGCComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancleBT = New System.Windows.Forms.Button()
        Me.PrintBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_CourseMaster = New MTGCComboBox()
        Me.SuspendLayout()
        '
        'cbo_branch
        '
        Me.cbo_branch.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_branch.ArrowColor = System.Drawing.Color.Black
        Me.cbo_branch.BindedControl = CType(resources.GetObject("cbo_branch.BindedControl"), MTGCComboBox.ControlloAssociato)
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
        Me.cbo_branch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_branch.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbo_branch.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_branch.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_branch.DropDownWidth = 170
        Me.cbo_branch.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_branch.GridLineHorizontal = True
        Me.cbo_branch.GridLineVertical = True
        Me.cbo_branch.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_branch.Location = New System.Drawing.Point(80, 27)
        Me.cbo_branch.ManagingFastMouseMoving = True
        Me.cbo_branch.ManagingFastMouseMovingInterval = 30
        Me.cbo_branch.Name = "cbo_branch"
        Me.cbo_branch.SelectedItem = Nothing
        Me.cbo_branch.SelectedValue = Nothing
        Me.cbo_branch.Size = New System.Drawing.Size(238, 21)
        Me.cbo_branch.TabIndex = 727
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 726
        Me.Label1.Text = "สาขา :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CancleBT
        '
        Me.CancleBT.BackgroundImage = Global.Human_Development.My.Resources.Resources.clear_20
        Me.CancleBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancleBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancleBT.Location = New System.Drawing.Point(195, 102)
        Me.CancleBT.Name = "CancleBT"
        Me.CancleBT.Size = New System.Drawing.Size(63, 28)
        Me.CancleBT.TabIndex = 729
        Me.CancleBT.Text = "ยกเลิก"
        Me.CancleBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancleBT.UseVisualStyleBackColor = True
        '
        'PrintBT
        '
        Me.PrintBT.BackgroundImage = Global.Human_Development.My.Resources.Resources._31_20
        Me.PrintBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PrintBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBT.Location = New System.Drawing.Point(125, 102)
        Me.PrintBT.Name = "PrintBT"
        Me.PrintBT.Size = New System.Drawing.Size(63, 28)
        Me.PrintBT.TabIndex = 728
        Me.PrintBT.Text = "พิมพ์"
        Me.PrintBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 730
        Me.Label2.Text = "หลักสูตร :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbo_CourseMaster
        '
        Me.cbo_CourseMaster.ArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_CourseMaster.ArrowColor = System.Drawing.Color.Black
        Me.cbo_CourseMaster.BindedControl = CType(resources.GetObject("cbo_CourseMaster.BindedControl"), MTGCComboBox.ControlloAssociato)
        Me.cbo_CourseMaster.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        Me.cbo_CourseMaster.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cbo_CourseMaster.ColumnNum = 2
        Me.cbo_CourseMaster.ColumnWidth = "150;0"
        Me.cbo_CourseMaster.DisabledArrowBoxColor = System.Drawing.SystemColors.Control
        Me.cbo_CourseMaster.DisabledArrowColor = System.Drawing.Color.LightGray
        Me.cbo_CourseMaster.DisabledBackColor = System.Drawing.SystemColors.Control
        Me.cbo_CourseMaster.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.cbo_CourseMaster.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.cbo_CourseMaster.DisplayMember = "Text"
        Me.cbo_CourseMaster.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_CourseMaster.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.cbo_CourseMaster.DropDownForeColor = System.Drawing.Color.Black
        Me.cbo_CourseMaster.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.cbo_CourseMaster.DropDownWidth = 170
        Me.cbo_CourseMaster.GridLineColor = System.Drawing.Color.LightGray
        Me.cbo_CourseMaster.GridLineHorizontal = True
        Me.cbo_CourseMaster.GridLineVertical = True
        Me.cbo_CourseMaster.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.cbo_CourseMaster.Location = New System.Drawing.Point(80, 58)
        Me.cbo_CourseMaster.ManagingFastMouseMoving = True
        Me.cbo_CourseMaster.ManagingFastMouseMovingInterval = 30
        Me.cbo_CourseMaster.Name = "cbo_CourseMaster"
        Me.cbo_CourseMaster.SelectedItem = Nothing
        Me.cbo_CourseMaster.SelectedValue = Nothing
        Me.cbo_CourseMaster.Size = New System.Drawing.Size(328, 21)
        Me.cbo_CourseMaster.TabIndex = 731
        '
        'frm_Opt_HD_Rpt001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(450, 167)
        Me.Controls.Add(Me.cbo_CourseMaster)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancleBT)
        Me.Controls.Add(Me.PrintBT)
        Me.Controls.Add(Me.cbo_branch)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Opt_HD_Rpt001"
        Me.Text = "frm_Opt_HD_Rpt001"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_branch As MTGCComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CancleBT As System.Windows.Forms.Button
    Friend WithEvents PrintBT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbo_CourseMaster As MTGCComboBox
End Class
