Public Class Browse_Record_Development
    Private RecordDevMaster As New Record_Development_Master
    Private Annaul_Master As New Cls_Annual_Master

    Private Sub Browse_Record_Development_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
    End Sub

    Public Sub binddata()
        Try
            Dim dt As New DataTable
            RecordDevMaster.Clear()
            RecordDevMaster.id = String.Empty
            dt = RecordDevMaster.Retreive()
            lvResult_Training.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvResult_Training.FullRowSelect = True
                lvResult_Training.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    Dim anm As New Cls_Annual_Master
                    anm.getById(dt.Rows(row).Item("rdm_annual_master").ToString())
                    lvResult_Training.Items.Add(dt.Rows(row).Item("rdm_id").ToString())
                    lvResult_Training.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdm_code").ToString())
                    lvResult_Training.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdm_date").ToString())
                    lvResult_Training.Items(nindex).SubItems.Add(anm.doc_code.ToString() & " - " & anm.expcourse_Master.expCourse.name.ToString())
                    lvResult_Training.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdm_ann_qty_people").ToString())
                    nindex = nindex + 1
                Next
            End If
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim Form As New Record_Development
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.pmethInit()
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim Form As New Record_Development
            Form.mode = GBMod.Edit
            Form.id = lvResult_Training.SelectedItems(0).SubItems(0).Text.ToString()
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
            If lvResult_Training.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                RecordDevMaster.id = lvResult_Training.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            SqlDB.BeginTrans()
            bSucc = pmethDelRecordDev_Detail(SqlDB)
            If bSucc Then
                If RecordDevMaster.Delete(SqlDB) = False Then
                    bSucc = False
                    MessageBox.Show(RecordDevMaster.message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    SqlDB.CommitTrans()
                    MessageBox.Show(RecordDevMaster.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        binddata()
    End Sub

    Private Sub lvResult_Training_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvResult_Training.DoubleClick
        btnEdit_Click(sender, e)
    End Sub

    Private Function pmethDelRecordDev_Detail(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim Col_RecordDevDetail As Collection
        Col_RecordDevDetail = RecordDevMaster.Item_RecordDevDetail
        For Each cs As Object In Col_RecordDevDetail
            Dim ObjCs = CType(cs, Record_Development_Detail)
            bSucc = bSucc And ObjCs.Delete(SqlDB)
        Next
        Return bSucc
    End Function

End Class