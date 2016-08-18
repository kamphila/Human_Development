Public Class BG1_Browse_Input_Budget

    Private Budget_Master As New Cls_Budget_Master
    Private Annual_Master As New Cls_Annual_Master
    Public BranchId As String
    Public BegDate As DateTime
    Public EndDate As DateTime

    Private Sub BG1_Browse_Input_Budget_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
    End Sub

    Public Sub binddata()
        Try
            Dim dt As New DataTable
            Budget_Master.Clear()
            Budget_Master.id = ""
            dt = Budget_Master.Retreive(BegDate, EndDate)
            lvBudget.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvBudget.FullRowSelect = True
                lvBudget.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    Dim anm As New Cls_Annual_Master
                    anm.getById(dt.Rows(row).Item("bum_annual_master").ToString())
                    lvBudget.Items.Add(dt.Rows(row).Item("bum_id").ToString())
                    lvBudget.Items(nindex).SubItems.Add(anm.id.ToString())
                    lvBudget.Items(nindex).SubItems.Add(dt.Rows(row).Item("bum_code").ToString())
                    lvBudget.Items(nindex).SubItems.Add(Cls_SqlDB.DateToStringTH(dt.Rows(row).Item("bum_date").ToString()))
                    lvBudget.Items(nindex).SubItems.Add(anm.doc_code & "-" & anm.expcourse_Master.expCourse.name)
                    lvBudget.Items(nindex).SubItems.Add(anm.qty.ToString())
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
        Dim Form As New BG2_Input_Budget
        Form.mode = GBMod.Add
        Form.BranchId = Me.BranchId
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.pmethInit()
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim Form As New BG2_Input_Budget
            Form.mode = GBMod.Edit
            Form.BranchId = Me.BranchId
            Form.id = lvBudget.SelectedItems.Item(0).SubItems(0).Text.ToString()
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
        Try

            If lvBudget.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Budget_Master.id = lvBudget.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            SqlDB.BeginTrans()
            bSucc = pmethDelBudget_Detail(SqlDB)

            If bSucc Then
                Annual_Master = New Cls_Annual_Master
                Annual_Master.id = lvBudget.SelectedItems.Item(0).SubItems(1).Text.ToString()

                Annual_Master.paystep = Config.Anm_Pay_Step_NonPay

                If Annual_Master.UpdateFrom_Budget(SqlDB) = False Then
                    bSucc = False
                    MessageBox.Show(Annual_Master.message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If bSucc Then
                If Budget_Master.Delete(SqlDB) = False Then
                    bSucc = False
                    MessageBox.Show(Budget_Master.message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    SqlDB.CommitTrans()
                    MessageBox.Show(Budget_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    binddata()
                End If
            End If

            If bSucc = False Then
                SqlDB.RollbackTrans()
            End If
        Catch ex As Exception
            SqlDB.RollbackTrans()
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Function pmethDelBudget_Detail(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim Col_BudgetDetail As Collection
        Col_BudgetDetail = Budget_Master.Item_BudgetDetail
        For Each cs As Object In Col_BudgetDetail
            Dim ObjCs = CType(cs, Cls_Budget_Detail)
            bSucc = bSucc And ObjCs.Delete(SqlDB)
        Next
        Return bSucc
    End Function

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lvBudget_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lvBudget.MouseDoubleClick
        Me.btnEdit_Click(sender, e)
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        binddata()
    End Sub
End Class