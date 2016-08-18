Public Class ADD_Edit_List_Course

    Private Course_Master As New Cls_Course_Master
    Public BranchId As String
    Public BegDate As DateTime
    Public EndDate As DateTime

#Region "Load"
    Private Sub ADD_Edit_List_Course_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        'Course_Master.course = "whhzuK6KYimE6zwIVo84"

        binddata()
        pmethSetProp()

    End Sub

    Private Sub pmethSetProp()

    End Sub

    Public Sub binddata()
        Try
            Dim dt As DataTable
            Course_Master.Clear()
            Course_Master.id = ""
            Course_Master.Branch_id = Me.BranchId
            dt = Course_Master.Retreive(BegDate, EndDate)
            lv_course_master.Items.Clear()
            If dt.Rows.Count > 0 Then
                lv_course_master.FullRowSelect = True
                lv_course_master.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    Dim strOwner As String = IIf(dt.Rows(row).Item("cms_owner_hr_flag").ToString() = "Y", "ฝ่ายทรัพยากร", "อื่น ๆ")
                    lv_course_master.Items.Add(dt.Rows(row).Item("cms_id").ToString())
                    lv_course_master.Items(nindex).SubItems.Add(nindex + 1)
                    lv_course_master.Items(nindex).SubItems.Add(dt.Rows(row).Item("cms_code").ToString())
                    lv_course_master.Items(nindex).SubItems.Add(New Cls_HD_Course(dt.Rows(row).Item("cms_course").ToString()).code)
                    lv_course_master.Items(nindex).SubItems.Add(New Cls_HD_Course(dt.Rows(row).Item("cms_course").ToString()).name)
                    lv_course_master.Items(nindex).SubItems.Add(New Cls_HD_Course_Type(dt.Rows(row).Item("cms_course_type").ToString()).name)
                    lv_course_master.Items(nindex).SubItems.Add(strOwner)
                    lv_course_master.Items(nindex).SubItems.Add(New Cls_Competency(dt.Rows(row).Item("cmd_competency").ToString()).name)
                    nindex = nindex + 1
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub
#End Region

#Region "Event"
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim Form As New ADD_Edit_Course
        Form.BranchId = Me.BranchId
        Form.pmethInit()
        Form.mode = GBMod.Add
        Form.id = String.Empty
        Form.FormBrow = Me
        Form.ShowDialog()
        binddata()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            Dim Form As New ADD_Edit_Course
            Form.BranchId = Me.BranchId
            Form.mode = GBMod.Edit
            Form.id = lv_course_master.SelectedItems.Item(0).SubItems(0).Text.ToString()
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
        Try
            If lv_course_master.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Try
                Course_Master.id = lv_course_master.SelectedItems.Item(0).SubItems(0).Text.ToString()
            Catch ex As Exception
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If MessageBox.Show("คุณต้องการลบข้อมูลใช่หรือไม่ ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbCancel Then
                Exit Sub
            End If
            SqlDB.BeginTrans()
            pmethDelCorustStruct(SqlDB)
            pmethDelCoruseExam(SqlDB)
            If Course_Master.Delete(SqlDB) = False Then
                MessageBox.Show(Course_Master.message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            SqlDB.CommitTrans()
            MessageBox.Show(Course_Master.message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            binddata()
        Catch ex As Exception
            SqlDB.RollbackTrans()
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try


    End Sub

    Private Sub lv_course_master_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lv_course_master.DoubleClick
        btnEdit_Click(sender, e)
    End Sub
#End Region

    Private Sub pmethDelCorustStruct(SqlDB As Cls_SqlDB)
        Dim col_CoruseSturce As New Collection
        col_CoruseSturce = Course_Master.Item_Course_Struct
        For Each cs As Object In col_CoruseSturce
            Dim ObjCs = CType(cs, Cls_HD_Course_Struct)
            ObjCs.Delete(SqlDB)
        Next
    End Sub

    Private Sub pmethDelCoruseExam(SqlDB As Cls_SqlDB)
        Dim col_Coruseexam As New Collection
        col_Coruseexam = Course_Master.Item_Course_Exam
        For Each cs As Object In col_Coruseexam
            Dim ObjCs = CType(cs, Cls_HD_Course_Exam)
            ObjCs.Delete(SqlDB)
        Next
    End Sub


End Class