Public Class Show_of_Development_Roadmap

    Private Roadmap_Detail As New Cls_HD_Roadmap_Detail
    Private Position As New Cls_Position
    Private Station As New Cls_Station
    Public mode As String = String.Empty
    Public id As String = String.Empty

#Region "Load"
    Private Sub Show_of_Development_Roadmap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
        pmethBlankVar()
        binddata()
    End Sub
#End Region

#Region "Event And Function"

    Private Sub pmethBlankVar()
        Me.SetDataSource()
        cbbStationName.SelectedIndex = 0
        txtPositionName.Text = String.Empty
        Roadmap_Detail.clear()

    End Sub

    Private Sub SetDataSource()
        Dim dtStationType As DataTable
        dtStationType = Station.RetreiveStationType()
        Me.cbbStationName.DisplayMember = "name_01"
        Me.cbbStationName.ValueMember = "id"
        Me.cbbStationName.DataSource = dtStationType
    End Sub

    Public Sub binddata()
        Try
            Dim dt As New DataTable
            Roadmap_Detail.clear()
            dt = Roadmap_Detail.Retreive()
            binddatatoListView(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub binddatatoListView(dt As DataTable)
        lvRoadmapPosition.Items.Clear()
        If dt.Rows.Count > 0 Then
            lvRoadmapPosition.FullRowSelect = True
            lvRoadmapPosition.ShowItemToolTips = True
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                lvRoadmapPosition.Items.Add(dt.Rows(row).Item("rdd_id").ToString())
                lvRoadmapPosition.Items(nindex).SubItems.Add(nindex + 1)
                lvRoadmapPosition.Items(nindex).SubItems.Add(New Cls_Course_Master(dt.Rows(row).Item("rdd_course_master").ToString()).expCourse.code)
                lvRoadmapPosition.Items(nindex).SubItems.Add(New Cls_Course_Master(dt.Rows(row).Item("rdd_course_master").ToString()).expCourse.name)
                lvRoadmapPosition.Items(nindex).SubItems.Add("")
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year1").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year2").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year3").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year4").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year5").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year6").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year7").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year8").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year9").ToString() = "Y", "@", ""))
                lvRoadmapPosition.Items(nindex).SubItems.Add(IIf(dt.Rows(row).Item("rdd_year10").ToString() = "Y", "@", ""))
                If cNull(dt.Rows(row).Item("rdd_begmonth"), "N") > 0 Then
                    lvRoadmapPosition.Items(nindex).SubItems.Add(dt.Rows(row).Item("rdd_begmonth").ToString() & "-" & dt.Rows(row).Item("rdd_endmonth").ToString())
                Else
                    lvRoadmapPosition.Items(nindex).SubItems.Add("")
                End If
                nindex = nindex + 1
            Next
        End If
    End Sub

    Private Sub btnPositionName_Click(sender As System.Object, e As System.EventArgs) Handles btnPositionName.Click
        GetSearch()
    End Sub

    Private Sub GetSearch()
        Dim dt As DataTable = Roadmap_Detail.RetreiveByPositionRoadMapDetail(cbbStationName.SelectedValue.ToString(), txtPositionName.Text)
        binddatatoListView(dt)
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        pmethBlankVar()
        Roadmap_Detail.clear()
        binddata()
    End Sub

#End Region


End Class