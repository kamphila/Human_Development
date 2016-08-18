Public Class Select_Competency

    Private Competency As New Cls_Competency()
    Public ret_id As String
    Public ret_code As String
    Public ret_name As String
    Public ret_group As String
    Private Sub Select_Competency_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.getSearch()
    End Sub

    Private Sub getSearch()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        dt = Competency.RetreiveForSearch(Me.txtCode.Text, Me.txtName.Text, Me.txtGroup.Text)
        lvData.Items.Clear()
        lvData.FullRowSelect = True
        lvData.ShowItemToolTips = True
        If dt.Rows.Count > 0 Then
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                lvData.Items.Add(dt.Rows(row).Item("id").ToString())
                lvData.Items(nindex).SubItems.Add(nindex + 1)
                lvData.Items(nindex).SubItems.Add(cNull(dt.Rows(row).Item("com_code").ToString(), "S"))
                lvData.Items(nindex).SubItems.Add(cNull(dt.Rows(row).Item("name_01").ToString(), "S"))
                lvData.Items(nindex).SubItems.Add(cNull(dt.Rows(row).Item("groupname").ToString(), "S"))
                nindex = nindex + 1
            Next
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Me.getSearch()
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Me.pmethResoutOK()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
        End Try

    End Sub

    Private Sub pmethResoutOK()
        ret_id = lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub lvData_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvData.DoubleClick
        Try
            Me.pmethResoutOK()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
        End Try
    End Sub
End Class