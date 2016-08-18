Public Class Select_Place
    Public return_id As String
    Public return_code As String
    Public return_name As String
    Public return_name2 As String
    Private Place As New Cls_HD_Place
    Private mode As String

#Region "Load"
    Private Sub Select_Place_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
    End Sub
#End Region

#Region "Binddata"
    Private Sub binddata()
        Try
            lvPlace.Items.Clear()
            Dim dt As New DataTable
            dt = Place.Retreive()
            If dt.Rows.Count > 0 Then
                lvPlace.FullRowSelect = True
                lvPlace.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvPlace.Items.Add(dt.Rows(row).Item("pac_id").ToString())
                    lvPlace.Items(nindex).SubItems.Add(nindex + 1)
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_code").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_name").ToString())
                    lvPlace.Items(nindex).SubItems.Add(dt.Rows(row).Item("pac_name2").ToString())
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
            return_id = lvPlace.SelectedItems.Item(0).SubItems(0).Text.ToString()
            return_code = lvPlace.SelectedItems.Item(0).SubItems(2).Text.ToString()
            return_name = lvPlace.SelectedItems.Item(0).SubItems(3).Text.ToString()
            return_name2 = lvPlace.SelectedItems.Item(0).SubItems(4).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub lvPlace_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvPlace.DoubleClick
        btnEnter_Click(sender, e)
    End Sub

#End Region

End Class