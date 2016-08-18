<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HD_POP_Person
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HD_POP_Person))
        Me.btn_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbx_position_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbx_person_name = New System.Windows.Forms.TextBox()
        Me.tbx_person_code = New System.Windows.Forms.TextBox()
        Me.tbx_position_code = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Lst_person = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStationName = New System.Windows.Forms.TextBox()
        Me.btnReste = New System.Windows.Forms.Button()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.Image = Global.Human_Development.My.Resources.Resources._55_20
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(86, 20)
        Me.btn_close.Text = "ปิดหน้าต่าง"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_close})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip2.TabIndex = 12
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 599)
        Me.Panel1.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Lst_person)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(992, 599)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 120)
        Me.Panel2.TabIndex = 773
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.4677!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5323!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_position_name, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_person_name, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_person_code, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_position_code, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_search, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtStationName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReste, 4, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(976, 116)
        Me.TableLayoutPanel1.TabIndex = 772
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Location = New System.Drawing.Point(48, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 30)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "รหัสพนักงาน:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_position_name
        '
        Me.tbx_position_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_position_name.Location = New System.Drawing.Point(467, 33)
        Me.tbx_position_name.Name = "tbx_position_name"
        Me.tbx_position_name.Size = New System.Drawing.Size(227, 20)
        Me.tbx_position_name.TabIndex = 767
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(398, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 32)
        Me.Label7.TabIndex = 769
        Me.Label7.Text = "ชื่อตำแหน่ง:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_person_name
        '
        Me.tbx_person_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_person_name.Location = New System.Drawing.Point(467, 3)
        Me.tbx_person_name.Name = "tbx_person_name"
        Me.tbx_person_name.Size = New System.Drawing.Size(227, 20)
        Me.tbx_person_name.TabIndex = 771
        '
        'tbx_person_code
        '
        Me.tbx_person_code.Location = New System.Drawing.Point(124, 3)
        Me.tbx_person_code.Name = "tbx_person_code"
        Me.tbx_person_code.Size = New System.Drawing.Size(133, 20)
        Me.tbx_person_code.TabIndex = 770
        '
        'tbx_position_code
        '
        Me.tbx_position_code.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_position_code.Location = New System.Drawing.Point(124, 33)
        Me.tbx_position_code.Name = "tbx_position_code"
        Me.tbx_position_code.Size = New System.Drawing.Size(195, 20)
        Me.tbx_position_code.TabIndex = 766
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Location = New System.Drawing.Point(397, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 30)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "ชื่อพนักงาน:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(49, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 32)
        Me.Label22.TabIndex = 768
        Me.Label22.Text = "รหัสตำแหน่ง:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_search
        '
        Me.btn_search.BackgroundImage = Global.Human_Development.My.Resources.Resources.BG2
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Image = Global.Human_Development.My.Resources.Resources.search1
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_search.Location = New System.Drawing.Point(700, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(33, 24)
        Me.btn_search.TabIndex = 103
        Me.btn_search.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Lst_person
        '
        Me.Lst_person.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lst_person.CheckBoxes = True
        Me.Lst_person.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.Lst_person.FullRowSelect = True
        Me.Lst_person.GridLines = True
        Me.Lst_person.Location = New System.Drawing.Point(2, 130)
        Me.Lst_person.Name = "Lst_person"
        Me.Lst_person.Size = New System.Drawing.Size(982, 462)
        Me.Lst_person.TabIndex = 72
        Me.Lst_person.UseCompatibleStateImageBehavior = False
        Me.Lst_person.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "person_id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "รหัสพนักงาน"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ชื่อพนักงาน"
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "สาขา"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ชื่อหน่วยงาน"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "รหัสตำแหน่ง"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ชื่อตำแหน่ง"
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "station_id"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "position_id"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "branch_id"
        Me.ColumnHeader10.Width = 0
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ระดับพนักงาน"
        Me.ColumnHeader11.Width = 150
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "อายุงาน"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "position_level_id"
        Me.ColumnHeader13.Width = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 772
        Me.Label1.Text = "ชื่อหน่วยงาน:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStationName
        '
        Me.txtStationName.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.txtStationName.Location = New System.Drawing.Point(124, 65)
        Me.txtStationName.Name = "txtStationName"
        Me.txtStationName.Size = New System.Drawing.Size(195, 20)
        Me.txtStationName.TabIndex = 773
        '
        'btnReste
        '
        Me.btnReste.Image = Global.Human_Development.My.Resources.Resources._51_20
        Me.btnReste.Location = New System.Drawing.Point(700, 33)
        Me.btnReste.Name = "btnReste"
        Me.btnReste.Size = New System.Drawing.Size(36, 26)
        Me.btnReste.TabIndex = 774
        Me.btnReste.UseVisualStyleBackColor = True
        '
        'HD_POP_Person
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 623)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HD_POP_Person"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ค้นหาพนักงาน"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lst_person As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbx_position_name As System.Windows.Forms.TextBox
    Friend WithEvents tbx_position_code As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tbx_person_code As System.Windows.Forms.TextBox
    Friend WithEvents tbx_person_name As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStationName As System.Windows.Forms.TextBox
    Friend WithEvents btnReste As System.Windows.Forms.Button
End Class
