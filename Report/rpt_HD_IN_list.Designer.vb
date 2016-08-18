<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_HD_IN_list
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานหลักสูตรพัฒนาบุคลากร")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานเส้นทางการฝึกอบรมรายตำแหน่งแยกปี")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานปฏิทินฝึกอบรม")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานประวัติการฝึกอบรมรายบุคคล รายหลักสูตร")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" รายงานพัฒนาบุคลากรรายบุคคล")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานงบประมาณพัฒนาบุคลากรประจำปี ")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานภายในองค์กร", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_HD_IN_list))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(4, 7)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(4)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "rptHD1_1"
        TreeNode1.Text = "รายงานหลักสูตรพัฒนาบุคลากร"
        TreeNode2.Name = "rptHD1_2"
        TreeNode2.Text = "รายงานเส้นทางการฝึกอบรมรายตำแหน่งแยกปี"
        TreeNode3.Name = "rptHD1_3"
        TreeNode3.Text = "รายงานปฏิทินฝึกอบรม"
        TreeNode4.Name = "rptHD1_4"
        TreeNode4.Text = "รายงานประวัติการฝึกอบรมรายบุคคล รายหลักสูตร"
        TreeNode5.Name = "rptHD1_5"
        TreeNode5.Text = " รายงานพัฒนาบุคลากรรายบุคคล"
        TreeNode6.Name = "rptHD1_6"
        TreeNode6.Text = "รายงานงบประมาณพัฒนาบุคลากรประจำปี "
        TreeNode7.Name = "rpt1"
        TreeNode7.Text = "รายงานภายในองค์กร"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.TreeView1.Size = New System.Drawing.Size(620, 485)
        Me.TreeView1.TabIndex = 656
        '
        'rpt_HD_IN_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Human_Development.My.Resources.Resources.bg4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(629, 498)
        Me.Controls.Add(Me.TreeView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "rpt_HD_IN_list"
        Me.Text = "รายงานสวัสดิการและสิทธิประโยชน์"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
End Class
