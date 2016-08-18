<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_Place
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEnter = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.lvPlace = New System.Windows.Forms.ListView()
        Me.col_Pac_Id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Pac_No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col_Pac_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Pac_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Pac_Name2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEnter, Me.btnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(523, 28)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Image = Global.Human_Development.My.Resources.Resources._20_26
        Me.btnEnter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(60, 25)
        Me.btnEnter.Text = "เลือก"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.Human_Development.My.Resources.Resources._19_26
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 25)
        Me.btnCancel.Text = "ยกเลิก"
        '
        'lvPlace
        '
        Me.lvPlace.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_Pac_Id, Me.col_Pac_No, Me.Col_Pac_Code, Me.col_Pac_Name, Me.col_Pac_Name2})
        Me.lvPlace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPlace.GridLines = True
        Me.lvPlace.Location = New System.Drawing.Point(0, 28)
        Me.lvPlace.Name = "lvPlace"
        Me.lvPlace.Size = New System.Drawing.Size(523, 430)
        Me.lvPlace.TabIndex = 4
        Me.lvPlace.UseCompatibleStateImageBehavior = False
        Me.lvPlace.View = System.Windows.Forms.View.Details
        '
        'col_Pac_Id
        '
        Me.col_Pac_Id.Width = 0
        '
        'col_Pac_No
        '
        Me.col_Pac_No.Text = "ลำดับ"
        Me.col_Pac_No.Width = 58
        '
        'Col_Pac_Code
        '
        Me.Col_Pac_Code.Text = "รหัสสถาบัน"
        Me.Col_Pac_Code.Width = 75
        '
        'col_Pac_Name
        '
        Me.col_Pac_Name.Text = "ชื่อสถาบัน"
        Me.col_Pac_Name.Width = 386
        '
        'col_Pac_Name2
        '
        Me.col_Pac_Name2.Width = 131
        '
        'Select_Place
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 458)
        Me.Controls.Add(Me.lvPlace)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Select_Place"
        Me.Text = "Select_Place"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnEnter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents lvPlace As System.Windows.Forms.ListView
    Friend WithEvents col_Pac_Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Pac_No As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col_Pac_Code As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Pac_Name As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Pac_Name2 As System.Windows.Forms.ColumnHeader
End Class
