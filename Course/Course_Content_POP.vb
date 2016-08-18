Public Class Course_Content_POP
    Public ContentDevMod As String = String.Empty
    Public PropCourse_Struce As New Cls_HD_Course_Struct

    Private Sub Course_Content_POP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If ContentDevMod = GBMod.Add Then
            txt_cst_main_hour.Text = 0
        End If
    End Sub

    Private Function ValidateDataCourseContent() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If String.IsNullOrEmpty(txt_course_item_code.Text) = True Or String.IsNullOrEmpty(txt_course_item_name.Text) = True Then
            strErrmsg = "กรุณาระบุหัวข้อการพัฒนา"
            bSucc = False
        ElseIf String.IsNullOrEmpty(txt_course_content1.Text) = True Then
            strErrmsg = "กรุณาระบุเนื้อหาการพัฒนา"
            bSucc = False
        ElseIf IsNumeric(txt_cst_main_hour.Text) = False Then
            strErrmsg = "กรุณาระบุระยะเวลาการพัฒนาเป็นตัวเลข"
            bSucc = False
        ElseIf gmDoubleParse(txt_cst_main_hour.Text, 0) <= 0 Then
            strErrmsg = "กรุณาระบุระยะเวลาการพัฒนามากกว่า 0"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Sub btnGetCourse_Item_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCourse_Item.Click
        Dim ObjBrow As New Cls_HD_Course_Item()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        ObjBrow.code = ""
        dt = ObjBrow.Retreive()
        FrmVfield.lvData.Items.Clear()
        If dt.Rows.Count > 0 Then
            FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อ,ชื่อ 2,รายละเอียด")
            Frm_Select.autoResizeColumns(FrmVfield.lvData)
            Dim nindex As Integer = 0.0
            For row As Integer = 0 To dt.Rows.Count - 1
                FrmVfield.lvData.Items.Add(dt.Rows(row).Item("coi_id").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_code").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_name").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_name2").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coi_desc").ToString())
                nindex = nindex + 1
            Next
            FrmVfield.ShowDialog()
            If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
                Me.PropCourse_Struce.course_item = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                Me.txt_course_item_code.Text = Me.PropCourse_Struce.expHD_Course_Item.code
                Me.txt_course_item_name.Text = Me.PropCourse_Struce.expHD_Course_Item.name
            End If
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnGetCoruse_Content1_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content1.Click
        pmethCoruse_Content("CORUSE_CONTENT1")
    End Sub

    Private Sub btnGetCoruse_Content2_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content2.Click
        pmethCoruse_Content("CORUSE_CONTENT2")
    End Sub

    Private Sub btnGetCoruse_Content3_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content3.Click
        pmethCoruse_Content("CORUSE_CONTENT3")
    End Sub

    Private Sub btnGetCoruse_Content4_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content4.Click
        pmethCoruse_Content("CORUSE_CONTENT4")
    End Sub

    Private Sub btnGetCoruse_Content5_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content5.Click
        pmethCoruse_Content("CORUSE_CONTENT5")
    End Sub

    Private Sub btnGetCoruse_Content6_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content6.Click
        pmethCoruse_Content("CORUSE_CONTENT6")
    End Sub

    Private Sub btnGetCoruse_Content7_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content7.Click
        pmethCoruse_Content("CORUSE_CONTENT7")
    End Sub

    Private Sub btnGetCoruse_Content8_Click(sender As System.Object, e As System.EventArgs) Handles btnGetCoruse_Content8.Click
        pmethCoruse_Content("CORUSE_CONTENT8")
    End Sub

    Private Sub pmethCoruse_Content(StrCourSet As String)
        Dim ObjBrow As New Cls_HD_Course_Content()
        Dim dt As DataTable
        Dim FrmVfield As New Frm_Select
        ObjBrow.code = ""
        dt = ObjBrow.Retreive()
        FrmVfield.lvData.Items.Clear()
        If dt.Rows.Count > 0 Then
            FrmVfield.CreateColumns("id,ลำดับ,รหัส,ชื่อ,ชื่อ 2,รายละเอียด")
            Frm_Select.autoResizeColumns(FrmVfield.lvData)
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                FrmVfield.lvData.Items.Add(dt.Rows(row).Item("coc_id").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(nindex + 1)
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_code").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_name").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_name2").ToString())
                FrmVfield.lvData.Items(nindex).SubItems.Add(dt.Rows(row).Item("coc_desc").ToString())
                nindex = nindex + 1
            Next
            FrmVfield.ShowDialog()
            If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
                Select Case StrCourSet
                    Case "CORUSE_CONTENT1"
                        Me.PropCourse_Struce.course_content1 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content1.Text = Me.PropCourse_Struce.expHD_Course_Content1.name
                    Case "CORUSE_CONTENT2"
                        Me.PropCourse_Struce.course_content2 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content2.Text = Me.PropCourse_Struce.expHD_Course_Content2.name
                    Case "CORUSE_CONTENT3"
                        Me.PropCourse_Struce.course_content3 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content3.Text = Me.PropCourse_Struce.expHD_Course_Content3.name
                    Case "CORUSE_CONTENT4"
                        Me.PropCourse_Struce.course_content4 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content4.Text = Me.PropCourse_Struce.expHD_Course_Content4.name
                    Case "CORUSE_CONTENT5"
                        Me.PropCourse_Struce.course_content5 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content5.Text = Me.PropCourse_Struce.expHD_Course_Content5.name
                    Case "CORUSE_CONTENT6"
                        Me.PropCourse_Struce.course_content6 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content6.Text = Me.PropCourse_Struce.expHD_Course_Content6.name
                    Case "CORUSE_CONTENT7"
                        Me.PropCourse_Struce.course_content7 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content7.Text = Me.PropCourse_Struce.expHD_Course_Content7.name
                    Case "CORUSE_CONTENT8"
                        Me.PropCourse_Struce.course_content8 = FrmVfield.lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                        Me.txt_course_content8.Text = Me.PropCourse_Struce.expHD_Course_Content8.name
                End Select
            End If
        Else
            MessageBox.Show("Not Found Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If ValidateDataCourseContent() = True Then
            PropCourse_Struce.main_hour = gmDoubleParse(txt_cst_main_hour.Text, 0)
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txt_cst_main_hour_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cst_main_hour.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txt_cst_main_hour.Text
            Dim selectionStart = Me.txt_cst_main_hour.SelectionStart
            Dim selectionLength = Me.txt_cst_main_hour.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 2 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3) Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub
End Class