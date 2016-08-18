Public Class Add_Edit_Roadmap_Browse
    Private Roadmap_Master As New Cls_HD_Roadmap_Master
    Public BranchId As String
    Public BegDate As DateTime
    Public EndDate As DateTime

#Region "Load"
    Private Sub Add_Edit_Roadmap_Browse_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
        pmethSetProp()
    End Sub
#End Region

#Region "Function"

    Private Sub pmethBlankVar()
        Roadmap_Master.clear()
        txtPosition.Text = String.Empty
        txtAffiliatedAgencies.Text = String.Empty

    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        If ((String.IsNullOrEmpty(txtPosition.Text) = True) And (String.IsNullOrEmpty(txtAffiliatedAgencies.Text) = True)) Then
            MessageBox.Show("กรุณาระบบตำแหน่งงานหรือสังกัดหน่วยงานในการค้นหา")
            Return bSucc = False
            Exit Function
        End If
        Return bSucc
    End Function

    Private Sub pmethSetProp()

    End Sub

    Public Sub binddata()
        Try
            Dim dt As New DataTable
            Roadmap_Master.clear()
            dt = Roadmap_Master.Retreive(BegDate, EndDate)
            bindatatoListvies(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub bindatatoListvies(dt As DataTable)
        lvRoadmap_Master.Items.Clear()
        If dt.Rows.Count > 0 Then
            lvRoadmap_Master.FullRowSelect = True
            lvRoadmap_Master.ShowItemToolTips = True
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                lvRoadmap_Master.Items.Add(dt.Rows(row).Item("rdm_id").ToString())
                'lvRoadmap_Master.Items(nindex).SubItems.Add(nindex + 1)
                lvRoadmap_Master.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdm_code").ToString())
                lvRoadmap_Master.Items(nindex).SubItems.Add(Cls_SqlDB.DateToStringTH(dt.Rows(row).Item("rdm_date").ToString()))
                lvRoadmap_Master.Items(nindex).SubItems.Add(New Cls_Position(dt.Rows(row).Item("rdm_position").ToString()).name)
                lvRoadmap_Master.Items(nindex).SubItems.Add(New Cls_Station(dt.Rows(row).Item("rdm_station").ToString()).name)
                nindex = nindex + 1
            Next
        End If
    End Sub

#End Region


#Region "Event"
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim Form As New Add_Edit_Development_Roadmap
        Form.mode = GBMod.Add
        Form.pmethInit()
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim Form As New Add_Edit_Development_Roadmap
            Form.mode = GBMod.Edit
            Form.id = lvRoadmap_Master.SelectedItems.Item(0).SubItems(0).Text.ToString()
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
        Dim bSucc = True
        Try
            If lvRoadmap_Master.Items.Count <= 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Roadmap_Master.id = lvRoadmap_Master.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            SqlDB.BeginTrans()
            bSucc = pmethDelRoadmapDetail(SqlDB)
            If bSucc Then
                If Roadmap_Master.Delete(SqlDB) = False Then
                    bSucc = False
                    MessageBox.Show(Roadmap_Master.message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    SqlDB.CommitTrans()
                    MessageBox.Show(Roadmap_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        pmethBlankVar()
        binddata()
    End Sub

    Private Sub lvRoadmap_Master_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvRoadmap_Master.DoubleClick
        btnEdit_Click(sender, e)
    End Sub

#End Region

    Function pmethDelRoadmapDetail(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim Col_RoadmapDetail As Collection
        Col_RoadmapDetail = Roadmap_Master.Item_RoadMapDetail
        For Each cs As Object In Col_RoadmapDetail
            Dim ObjCs = CType(cs, Cls_HD_Roadmap_Detail)
            bSucc = bSucc And ObjCs.Delete(SqlDB)
        Next
        Return bSucc
    End Function


    Private Sub btnPopPosition_Click(sender As System.Object, e As System.EventArgs) Handles btnPopPosition.Click
        If ValidateData() = True Then
            GetSearch()
        End If
    End Sub


#Region "Search"

    Private Sub btnPopAffiliatedAgencies_Click(sender As System.Object, e As System.EventArgs) Handles btnPopAffiliatedAgencies.Click
        If ValidateData() = True Then
            GetSearch()
        End If
    End Sub

    Private Sub GetSearch()
        Dim dt As DataTable = Roadmap_Master.RetreiveByPositionRoadMapMaster(Me.txtPosition.Text, Me.txtAffiliatedAgencies.Text)
        bindatatoListvies(dt)
    End Sub

#End Region

#Region "Exam Position"
    Private Sub btn_position_Click(sender As System.Object, e As System.EventArgs) Handles btn_position.Click
        Dim Form As New Show_of_Development_Roadmap
        Form.mode = ""
        Form.id = ""
        Form.ShowDialog()
    End Sub

    Private Sub lbl_capacity_Click(sender As System.Object, e As System.EventArgs) Handles lbl_capacity.Click
        Dim Form As New Show_of_Development_Competency
        Form.mode = ""
        Form.id = ""
        Form.ShowDialog()
    End Sub
#End Region
End Class