Public Class ADD_Edit_Annual_Position_Browse
    Private Annual_Master As New Cls_Annual_Master
    Public BranchId As String
    Public BegDate As DateTime
    Public EndDate As DateTime

#Region "Load"
    Private Sub ADP_Annual_Development_Course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
    End Sub

#End Region

#Region "Binddata"
    Public Sub binddata()
        Try
            Dim dt As New DataTable
            Annual_Master.Clear()
            Annual_Master.id = ""
            dt = Annual_Master.Retreive(BegDate, EndDate)
            lvAnnual_Master.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvAnnual_Master.FullRowSelect = True
                lvAnnual_Master.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    Dim anm As New Cls_Annual_Master
                    anm.getById(dt.Rows(row).Item("anm_id").ToString())
                    lvAnnual_Master.Items.Add(anm.id)
                    lvAnnual_Master.Items(nindex).SubItems.Add(nindex + 1)
                    lvAnnual_Master.Items(nindex).SubItems.Add(anm.doc_code)
                    lvAnnual_Master.Items(nindex).SubItems.Add(anm.doc_date.Date)
                    lvAnnual_Master.Items(nindex).SubItems.Add(anm.expcourse_Master.expCourse.name)
                    lvAnnual_Master.Items(nindex).SubItems.Add(anm.main_hour)
                    lvAnnual_Master.Items(nindex).SubItems.Add(anm.edition)
                    lvAnnual_Master.Items(nindex).SubItems.Add(anm.expposition.name)
                    lvAnnual_Master.Items(nindex).SubItems.Add(anm.year)
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

#End Region

#Region "Function"

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim Form As New ADD_Edit_Annual_Position
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.branch_id = Me.BranchId
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
            Dim Form As New ADD_Edit_Annual_Position
            Form.mode = GBMod.Edit
            Form.branch_id = Me.BranchId
            Form.id = lvAnnual_Master.SelectedItems.Item(0).SubItems(0).Text.ToString()
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
        Dim bSucc1 As Boolean = True
        Dim bSucc2 As Boolean = True
        Try
            If lvAnnual_Master.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Annual_Master.id = lvAnnual_Master.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            SqlDB.BeginTrans()
            bSucc1 = pmethDelAnnual_Detail(SqlDB)
            bSucc2 = pmethDelAnnual_Budget(SqlDB)
            If (bSucc1 = True And bSucc2 = True) Then
                If Annual_Master.Delete(SqlDB) = False Then
                    MessageBox.Show(Annual_Master.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    SqlDB.CommitTrans()
                    MessageBox.Show(Annual_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    binddata()
                End If
            End If
            If (bSucc1 = False Or bSucc2 = False) Then
                SqlDB.RollbackTrans()
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

#End Region

#Region "Delete Function"

    Function pmethDelAnnual_Detail(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim Col_AnnualDetail As Collection
        Col_AnnualDetail = Annual_Master.Item_AnnualDetail
        For Each cs As Object In Col_AnnualDetail
            Dim ObjCs = CType(cs, Cls_Annual_Detail)
            bSucc = bSucc And ObjCs.Delete(SqlDB)
        Next
        Return bSucc
    End Function


    Function pmethDelAnnual_Budget(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim Col_AnnualBudget As Collection
        Col_AnnualBudget = Annual_Master.Item_AnnualBudget
        For Each cs As Object In Col_AnnualBudget
            Dim ObjCs = CType(cs, Cls_Annual_Budget)
            bSucc = bSucc And ObjCs.Delete(SqlDB)
        Next
        Return bSucc
    End Function

#End Region

    Private Sub lvAnnual_Master_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvAnnual_Master.DoubleClick
        Me.btnEdit_Click(sender, e)
    End Sub
End Class