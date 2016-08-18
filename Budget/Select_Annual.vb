Public Class Select_Annual
    Public return_annual_id As String
    Public return_annual_code As String
    Public return_annual_course_master As String
    Public return_annual_course_master_name As String

    Private Annual_Master As New Cls_Annual_Master
    Private mode As String


    Private Sub Select_Annual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
    End Sub

    Private Sub binddata()
        lvAnnual.Items.Clear()
        Dim dt As New DataTable
        Annual_Master.paystep = Config.Anm_Pay_Step_NonPay
        dt = Annual_Master.Retreive()
        If dt.Rows.Count > 0 Then
            lvAnnual.FullRowSelect = True
            lvAnnual.ShowItemToolTips = True
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                lvAnnual.Items.Add(dt.Rows(row).Item("anm_id").ToString())
                lvAnnual.Items(nindex).SubItems.Add(dt.Rows(row).Item("anm_course_master").ToString())
                lvAnnual.Items(nindex).SubItems.Add(dt.Rows(row).Item("anm_code").ToString())
                lvAnnual.Items(nindex).SubItems.Add(dt.Rows(row).Item("anm_date").ToString())
                lvAnnual.Items(nindex).SubItems.Add(New Cls_HD_Course(New Cls_Course_Master(dt.Rows(row).Item("anm_course_master").ToString()).course).name)
                lvAnnual.Items(nindex).SubItems.Add(dt.Rows(row).Item("anm_main_hour").ToString())
                lvAnnual.Items(nindex).SubItems.Add(dt.Rows(row).Item("anm_edition").ToString())
                'lvAnnual.Items(nindex).SubItems.Add(New Cls_Position(dt.Rows(row).Item("anm_position").ToString()).name)
                lvAnnual.Items(nindex).SubItems.Add(dt.Rows(row).Item("anm_year").ToString())
                nindex = nindex + 1
            Next
        End If
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            return_annual_id = lvAnnual.SelectedItems.Item(0).SubItems(0).Text.ToString()
            return_annual_course_master = lvAnnual.SelectedItems.Item(0).SubItems(1).Text.ToString()
            return_annual_code = lvAnnual.SelectedItems.Item(0).SubItems(2).Text.ToString()
            return_annual_course_master_name = lvAnnual.SelectedItems.Item(0).SubItems(4).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub lvAnnual_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvAnnual.DoubleClick
        btnEnter_Click(sender, e)
    End Sub
End Class