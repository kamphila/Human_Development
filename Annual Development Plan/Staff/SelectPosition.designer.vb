<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPosition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectPosition))
        Me.position_level_lv = New System.Windows.Forms.ListView()
        Me.record_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.position_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.station_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Branch_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'position_level_lv
        '
        Me.position_level_lv.CheckBoxes = True
        Me.position_level_lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.record_no, Me.position_name, Me.station_name, Me.Branch_name})
        Me.position_level_lv.FullRowSelect = True
        Me.position_level_lv.GridLines = True
        Me.position_level_lv.Location = New System.Drawing.Point(0, 25)
        Me.position_level_lv.Name = "position_level_lv"
        Me.position_level_lv.Size = New System.Drawing.Size(649, 394)
        Me.position_level_lv.TabIndex = 2
        Me.position_level_lv.UseCompatibleStateImageBehavior = False
        Me.position_level_lv.View = System.Windows.Forms.View.Details
        '
        'record_no
        '
        Me.record_no.Text = "ลำดับที่"
        Me.record_no.Width = 50
        '
        'position_name
        '
        Me.position_name.Text = "ตำแหน่ง"
        Me.position_name.Width = 200
        '
        'station_name
        '
        Me.station_name.Text = "หน่วยงาน"
        Me.station_name.Width = 200
        '
        'Branch_name
        '
        Me.Branch_name.Text = "สาขา"
        Me.Branch_name.Width = 200
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(649, 24)
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
        'SelectPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 419)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.position_level_lv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SelectPosition"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents position_level_lv As System.Windows.Forms.ListView
    Friend WithEvents record_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents position_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents station_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents Branch_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents SelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
