Public Class Show_of_Development_Competency
    Dim Course_Master As New Cls_Course_Master
    Public mode As String = String.Empty
    Public id As String = String.Empty

#Region "Load"
    Private Sub Show_of_Development_Competency_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        pmethBlankVar()
        pmethSetProp()
        binddata()
    End Sub
#End Region

#Region "Function"
    Private Sub pmethBlankVar()
        txtCompentency_Name.Text = String.Empty
        txtCompentency_Name.Enabled = False
    End Sub

    Private Sub pmethSetProp()

    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True

        Return bSucc
    End Function
    Public Sub binddata()
        Try
            Dim dt As New DataTable
            Course_Master.Clear()
            Course_Master.id = ""
            dt = Course_Master.Retreive()
            binddatatoListview(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Public Sub binddatatoListview(dt As DataTable)
        Try
            lvCourse_Competency.Items.Clear()
            If dt.Rows.Count > 0 Then
                lvCourse_Competency.FullRowSelect = True
                lvCourse_Competency.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    lvCourse_Competency.Items.Add(dt.Rows(row).Item("cms_id").ToString())
                    lvCourse_Competency.Items(nindex).SubItems.Add(nindex + 1)
                    lvCourse_Competency.Items(nindex).SubItems.Add(New Cls_HD_Course(dt.Rows(row).Item("cms_course").ToString()).code)
                    lvCourse_Competency.Items(nindex).SubItems.Add(New Cls_HD_Course(dt.Rows(row).Item("cms_course").ToString()).name)
                    lvCourse_Competency.Items(nindex).SubItems.Add(New Cls_Competency(dt.Rows(row).Item("cmd_competency").ToString()).name)
                    lvCourse_Competency.Items(nindex).SubItems.Add(New Cls_Competency(dt.Rows(row).Item("cmd_competency").ToString()).groupname)
                    nindex = nindex + 1
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub


#End Region

#Region "Event"
    Private Sub btnCompentency_Click(sender As System.Object, e As System.EventArgs) Handles btnCompentency.Click
        Dim FormObj As New Select_Competency()
        FormObj.ShowDialog()
        If FormObj.DialogResult = Windows.Forms.DialogResult.OK And FormObj.ret_id <> String.Empty Then
            Dim dt As New DataTable
            Me.Course_Master.competency = FormObj.ret_id
            txtCompentency_Name.Text = Me.Course_Master.expcompetency.name
            dt = Course_Master.RetreiveByCompentency()
            binddatatoListview(dt)
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        pmethBlankVar()
        binddata()
    End Sub
#End Region



End Class