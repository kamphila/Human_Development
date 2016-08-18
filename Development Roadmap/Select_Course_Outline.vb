Public Class Select_course_outline

#Region "var"
    Private Course_Master As New Cls_Course_Master()
    Public Retrun_id As String
    Public Retrun_Code As String
    Public Retrun_Name As String
    Public Retrun_Name2 As String
#End Region

#Region "Load"
    Private Sub Select_course_outline_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnSearch_CourseName_Click(sender, e)
    End Sub
#End Region

#Region "Function And Event"

    Private Sub btnSearch_CourseName_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch_CourseName.Click
        Dim dt As New DataTable
        dt = Course_Master.RetreiveByCourseName(Me.txtCourseCode.Text, Me.txtCourseName.Text)
        Me.bindingData(dt)
    End Sub

    Private Sub bindingData(dt As DataTable)
        Try
            lv_CourseMaster.Items.Clear()
            If dt.Rows.Count > 0 Then
                lv_CourseMaster.FullRowSelect = True
                lv_CourseMaster.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lv_CourseMaster.Items.Add(dt.Rows(row).Item("cms_id").ToString())
                    lv_CourseMaster.Items(nindex).SubItems.Add(nindex + 1)
                    lv_CourseMaster.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_code").ToString())
                    lv_CourseMaster.Items(nindex).SubItems.Add(dt.Rows(row).Item("cos_name").ToString())
                    nindex = nindex + 1
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Retrun_id = lv_CourseMaster.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Retrun_Code = lv_CourseMaster.SelectedItems.Item(0).SubItems(2).Text.ToString()
            Retrun_Name = lv_CourseMaster.SelectedItems.Item(0).SubItems(3).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub lv_CourseMaster_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lv_CourseMaster.DoubleClick
        btnEnter_Click(sender, e)
    End Sub

    Private Sub lv_CourseMaster_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lv_CourseMaster.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btnEnter_Click(sender, e)
        End If
    End Sub

#End Region

End Class