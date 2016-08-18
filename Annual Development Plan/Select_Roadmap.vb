Public Class Select_Roadmap
    Public Get_Course_Master_Id As String
    Public Get_Position_Id As String
    Public Return_Roadmap_Id As String
    Public Return_Roapmap_DocCode As String
    Public Return_Roadmap_Course_Master As String
    Public Return_Roadmap_Position As String
    Public Return_Name As String
    Private Roadmap_Master As New Cls_HD_Roadmap_Master
    Private Position As New Cls_Position

#Region "Load"
    Private Sub Select_Roadmap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        Dim dt As New DataTable
        dt = Roadmap_Master.Retreive(Get_Course_Master_Id, Get_Position_Id)
        binddata(dt)
    End Sub
#End Region

#Region "Function RetirePersonData"
    Public Function RetreivePersonData(Return_id As String) As DataTable
        Dim dt As New DataTable
        dt = Position.RetreivePersonDataFromPosition(Return_id)
        Return dt
    End Function
#End Region

#Region "Binddata"
    Private Sub binddata(dt As DataTable)
        Try
            lvRoadmap.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvRoadmap.FullRowSelect = True
                lvRoadmap.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvRoadmap.Items.Add(dt.Rows(row).Item("rdm_id").ToString())
                    lvRoadmap.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdd_course_master").ToString())
                    lvRoadmap.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdm_position").ToString())
                    lvRoadmap.Items(nindex).SubItems.Add(nindex + 1)
                    lvRoadmap.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdm_code").ToString())
                    lvRoadmap.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdm_date").ToString())
                    lvRoadmap.Items(nindex).SubItems.Add(New Cls_HD_Course(New Cls_Course_Master(dt.Rows(row).Item("rdd_course_master").ToString()).course).code)
                    lvRoadmap.Items(nindex).SubItems.Add(New Cls_HD_Course(New Cls_Course_Master(dt.Rows(row).Item("rdd_course_master").ToString()).course).name)
                    lvRoadmap.Items(nindex).SubItems.Add(New Cls_Position(dt.Rows(row).Item("rdm_position")).name)
                    nindex = nindex + 1
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

#End Region

#Region "Function"
    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Return_Roadmap_Id = lvRoadmap.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Return_Roadmap_Course_Master = lvRoadmap.SelectedItems.Item(0).SubItems(1).Text.ToString()
            Return_Roadmap_Position = lvRoadmap.SelectedItems.Item(0).SubItems(2).Text.ToString()
            Return_Roapmap_DocCode = lvRoadmap.Items(0).SubItems(4).Text.ToString()
            Return_Name = lvRoadmap.SelectedItems.Item(0).SubItems(7).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub lvRoadmap_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvRoadmap.DoubleClick
        btnEnter_Click(sender, e)
    End Sub

#End Region

End Class