Public Class Select_Station

    Private Station As New Cls_Station()
    Public Retrun_id As String
    Public Retrun_Code As String
    Public Retrun_Name As String
    Public Retrun_Name2 As String
    Private Sub Select_Station_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SetDataSource()
    End Sub

    Private Sub SetDataSource()
        Dim dtStationType As DataTable
        dtStationType = Station.RetreiveStationType()
        Me.cbo_stationType.DisplayMember = "name_01"
        Me.cbo_stationType.ValueMember = "id"
        Me.cbo_stationType.DataSource = dtStationType
    End Sub

    Private Sub GetSerchData()
        Dim Dt As New DataTable()
        Dt = Station.RetiveStation(Me.cbo_stationType.SelectedValue)
        lv_Data.Items.Clear()
        If Dt.Rows.Count > 0 Then
            lv_Data.FullRowSelect = True
            lv_Data.ShowItemToolTips = True
            Dim nindex As Integer = 0
            For row As Integer = 0 To Dt.Rows.Count - 1
                lv_Data.Items.Add(Dt.Rows(row).Item("id").ToString())
                lv_Data.Items(nindex).SubItems.Add(nindex + 1)
                lv_Data.Items(nindex).SubItems.Add(Dt.Rows(row).Item("st_code").ToString())
                lv_Data.Items(nindex).SubItems.Add(Dt.Rows(row).Item("name_01").ToString())
                lv_Data.Items(nindex).SubItems.Add(Dt.Rows(row).Item("name_02").ToString())
                nindex = nindex + 1
            Next
        End If

    End Sub

    Private Sub cbo_stationType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_stationType.SelectedIndexChanged
        Me.GetSerchData()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Retrun_id = lv_Data.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Retrun_Code = lv_Data.SelectedItems.Item(0).SubItems(2).Text.ToString()
            Retrun_Name = lv_Data.SelectedItems.Item(0).SubItems(3).Text.ToString()
            Retrun_Name2 = lv_Data.SelectedItems.Item(0).SubItems(4).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub lv_Data_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lv_Data.DoubleClick
        Try
            Retrun_id = lv_Data.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Retrun_Code = lv_Data.SelectedItems.Item(0).SubItems(2).Text.ToString()
            Retrun_Name = lv_Data.SelectedItems.Item(0).SubItems(3).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Class