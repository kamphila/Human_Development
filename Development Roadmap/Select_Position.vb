Public Class Select_Position

    Public Retrun_id As String
    Public Retrun_Code As String
    Public Retrun_Name As String
    Public Retrun_Name2 As String
    Public Return_station As String
    Private Station As New Cls_Station
    Private Position As New Cls_Position
    Private mode As String

#Region "Load"
    Private Sub Select_Position_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.SetDataSource()
        Dim dt As New DataTable
        dt = Position.RetreivePositionByStation("All", Me.cbbStationCode.SelectedValue.ToString(), Me.txtPositionCode.Text, Me.txtPositionName.Text)
        binddata(dt)
    End Sub
#End Region

#Region "Event And Function"

    Private Sub SetDataSource()
        Dim dtStationType As DataTable
        dtStationType = Station.RetreiveStationType()
        Me.cbbStationCode.DisplayMember = "type_code"
        Me.cbbStationCode.ValueMember = "id"
        Me.cbbStationCode.DataSource = dtStationType
        Me.cbbStationName.DisplayMember = "name_01"
        Me.cbbStationName.ValueMember = "id"
        Me.cbbStationName.DataSource = dtStationType

    End Sub

    Private Sub cbbStationCode_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbStationCode.SelectedIndexChanged
        Me.cbbStationName.ValueMember = Me.cbbStationCode.ValueMember
    End Sub

    Private Sub cbbStationName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbStationName.SelectedIndexChanged
        Me.cbbStationCode.ValueMember = Me.cbbStationName.ValueMember
    End Sub

    Private Sub btnPositionName_Click(sender As System.Object, e As System.EventArgs) Handles btnPositionName.Click
        Dim dt As New DataTable
        dt = Position.RetreivePositionByStation("Condition", Me.cbbStationCode.SelectedValue.ToString(), Me.txtPositionCode.Text, Me.txtPositionName.Text)
        binddata(dt)
    End Sub
    Public Function RetreivePersonData(Return_id As String) As DataTable
        Dim dt As New DataTable
        dt = Position.RetreivePersonDataFromPosition(Return_id)
        Return dt
    End Function

    Private Sub binddata(dt As DataTable)
        Try
            lvPosition.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvPosition.FullRowSelect = True
                lvPosition.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvPosition.Items.Add(dt.Rows(row).Item("id").ToString())
                    lvPosition.Items(nindex).SubItems.Add(dt.Rows(row).Item("stationid").ToString())
                    lvPosition.Items(nindex).SubItems.Add(nindex + 1)
                    lvPosition.Items(nindex).SubItems.Add(dt.Rows(row).Item("position_code").ToString())
                    lvPosition.Items(nindex).SubItems.Add(dt.Rows(row).Item("p_name").ToString())
                    lvPosition.Items(nindex).SubItems.Add(dt.Rows(row).Item("st_name").ToString())
                    nindex = nindex + 1
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Me.txtPositionCode.Text = String.Empty
        Me.txtPositionName.Text = String.Empty
        Dim dt As New DataTable
        dt = Position.RetreivePositionByStation("All", Me.cbbStationCode.SelectedValue.ToString(), Me.txtPositionCode.Text, Me.txtPositionName.Text)
        binddata(dt)

    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Retrun_id = lvPosition.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Return_station = lvPosition.SelectedItems.Item(0).SubItems(1).Text.ToString()
            Retrun_Code = lvPosition.SelectedItems.Item(0).SubItems(3).Text.ToString()
            Retrun_Name = lvPosition.SelectedItems.Item(0).SubItems(4).Text.ToString()
            Retrun_Name2 = lvPosition.SelectedItems.Item(0).SubItems(5).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub lvPosition_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvPosition.DoubleClick
        btnEnter_Click(sender, e)
    End Sub

#End Region

End Class