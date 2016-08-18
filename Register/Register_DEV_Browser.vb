Public Class Register_DEV_Browser
    Private Register_Master As New Cls_Register_Master
    Private Annaul_Master As New Cls_Annual_Master
    Public BranchId As String
    Public BegDate As DateTime
    Public EndDate As DateTime

    Private Sub Register_DEV_Browser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
    End Sub

    Public Sub binddata()
        Try
            Dim dt As New DataTable
            Register_Master.Clear()
            Register_Master.id = String.Empty
            dt = Register_Master.Retreive(BegDate, EndDate)
            lvRegister.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvRegister.FullRowSelect = True
                lvRegister.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvRegister.Items.Add(dt.Rows(row).Item("reg_id").ToString())
                    lvRegister.Items(nindex).SubItems.Add(dt.Rows(row).Item("reg_ann_master").ToString())
                    lvRegister.Items(nindex).SubItems.Add(dt.Rows(row).Item("reg_code").ToString())
                    lvRegister.Items(nindex).SubItems.Add(dt.Rows(row).Item("reg_date").ToString())
                    lvRegister.Items(nindex).SubItems.Add(New Cls_HD_Course(New Cls_Course_Master(dt.Rows(row).Item("reg_course_master").ToString()).course).name)
                    lvRegister.Items(nindex).SubItems.Add(dt.Rows(row).Item("reg_ann_qty_people").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim Form As New Register_DEV
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.BranchId = Me.BranchId
        Form.FormBrow = Me
        Form.pmethInit()
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        binddata()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim Form As New Register_DEV
            Form.mode = GBMod.Edit
            Form.BranchId = Me.BranchId
            Form.id = lvRegister.SelectedItems(0).SubItems(0).Text.ToString()
            Form.pmethInit()
            Form.ShowDialog()
            binddata()
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการแก้ไข", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim SqlDB As New Cls_SqlDB
        Dim bSucc As Boolean = True
        Dim bSuccAnnual As Boolean = True
        Dim strErrmsg As String = String.Empty

        Try
            If lvRegister.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Register_Master.id = lvRegister.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            SqlDB.BeginTrans()

            bSucc = pmethDelRegister_Detail(SqlDB)

            If bSucc Then
                If Register_Master.Delete(SqlDB) = False Then
                    bSucc = False
                    MessageBox.Show(Register_Master.message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    SqlDB.CommitTrans()
                    'MessageBox.Show(Register_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'binddata()
                End If
            End If
            If bSucc = False Then
                SqlDB.RollbackTrans()
            End If

            If bSucc Then
                Dim dtChkDup As New DataTable
                Register_Master.ann_master = lvRegister.SelectedItems.Item(0).SubItems(1).Text.ToString()
                SqlDB.BeginTrans()
                dtChkDup = Register_Master.ChkDuplicate()
                If dtChkDup.Rows.Count <= 0 Then
                    Annaul_Master.id = Register_Master.ann_master
                    Annaul_Master.getstep = Config.Anm_Step_Create
                    If Annaul_Master.UpdateFrom_Register(SqlDB) = False Then
                        strErrmsg = Annaul_Master.message
                        bSuccAnnual = False
                    End If
                    If bSuccAnnual Then
                        SqlDB.CommitTrans()
                    Else
                        SqlDB.RollbackTrans()
                    End If
                    MessageBox.Show(Register_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    binddata()
                Else
                    MessageBox.Show(Register_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    binddata()
                End If
            End If
        Catch ex As Exception
            SqlDB.RollbackTrans()
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvRegister_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvRegister.DoubleClick
        btnEdit_Click(sender, e)
    End Sub

    Private Function pmethDelRegister_Detail(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim Col_RegisterDetail As Collection
        Col_RegisterDetail = Register_Master.Item_RegisterDetail
        For Each cs As Object In Col_RegisterDetail
            Dim ObjCs = CType(cs, Cls_Register_Detail)
            bSucc = bSucc And ObjCs.Delete(SqlDB)
        Next
        Return bSucc
    End Function

End Class