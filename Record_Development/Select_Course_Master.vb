Public Class Select_Course_Master
    Public return_course_master_id As String
    Public return_doc_code As String
    Public return_course_code As String
    Public return_course_name As String
    Public return_course_type As String

    Private Course_Master As New Cls_Course_Master
    Private mode As String

    Private Sub Select_Course2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        binddata()
    End Sub

    Private Sub binddata()
        Try
            lvCourse.Items.Clear()
            Dim dt As New DataTable
            dt = Course_Master.Retreive()
            If dt.Rows.Count > 0 Then
                lvCourse.FullRowSelect = True
                lvCourse.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCourse.Items.Add(dt.Rows(row).Item("cms_id").ToString())
                    lvCourse.Items(nindex).SubItems.Add(nindex + 1)
                    lvCourse.Items(nindex).SubItems.Add(dt.Rows(row).Item("cms_code").ToString())
                    lvCourse.Items(nindex).SubItems.Add(New Cls_HD_Course(dt.Rows(row).Item("cms_course").ToString()).code)
                    lvCourse.Items(nindex).SubItems.Add(New Cls_HD_Course(dt.Rows(row).Item("cms_course").ToString()).name)
                    lvCourse.Items(nindex).SubItems.Add(New Cls_HD_Course_Type(dt.Rows(row).Item("cms_course_type").ToString()).name)
                    nindex = nindex + 1
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            return_course_master_id = lvCourse.SelectedItems.Item(0).SubItems(0).Text.ToString()
            return_doc_code = lvCourse.SelectedItems.Item(0).SubItems(2).Text.ToString()
            return_course_code = lvCourse.SelectedItems.Item(0).SubItems(3).Text.ToString()
            return_course_name = lvCourse.SelectedItems.Item(0).SubItems(4).Text.ToString()
            return_course_type = lvCourse.SelectedItems.Item(0).SubItems(5).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub lvCourse_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvCourse.DoubleClick
        btnEnter_Click(sender, e)
    End Sub

End Class