Public Class Add_Edit_Development_Roadmap
    Public mode As String = String.Empty
    Public id As String = String.Empty
    Public FormBrow As Add_Edit_Roadmap_Browse
    Public Roadmap_Master As New Cls_HD_Roadmap_Master
    Private Roadmap_detail As New Cls_HD_Roadmap_Detail
    Private Col_RoadMapDetail As New Collection
    Private PoStrCourseId As String = String.Empty
    Private PoStrCourseCode As String = String.Empty
    Private PoStrCourseName As String = String.Empty
    Private PoStrCourseName02 As String = String.Empty
    Public BranchId As String
#Region "Load"
    Private Sub Add_Edit_Development_Roadmap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pmethDisableYear()
        pmethDisableMonth()
    End Sub
#End Region

#Region "Function"
    Public Sub pmethInit()
        pmethBindingData()
        pmethSetDataSource()
        pmethBlankVar()
        If mode = GBMod.Add Then
            Roadmap_Master.docCode = "AutoRun"
        ElseIf mode = GBMod.Edit Then
            pmethGetdata()
        End If
    End Sub

    Function datatableCreateMonth() As DataTable
        Dim dtMonth As New DataTable
        Dim column As DataColumn
        Dim row As DataRow
        Dim var_months = New String() {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}

        column = New DataColumn
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "monthId"
        dtMonth.Columns.Add(column)
        column = New DataColumn
        column.DataType = Type.GetType("System.String")
        column.ColumnName = "MonthName"
        dtMonth.Columns.Add(column)

        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 1 To 12
            row = dtMonth.NewRow
            row("monthId") = i
            row("monthName") = var_months(j)
            dtMonth.Rows.Add(row)
            j = j + 1
        Next i
        Return dtMonth
    End Function

    Private Sub pmethSetDataSource()
        Dim dtMonth As New DataTable
        Dim dtMonth2 As New DataTable
        dtMonth = datatableCreateMonth()
        dtMonth2 = datatableCreateMonth()
        Me.cbbBegin_Month.DisplayMember = "monthName"
        Me.cbbBegin_Month.ValueMember = "monthId"
        Me.cbbBegin_Month.DataSource = dtMonth
        Me.cbbEnd_Month.DisplayMember = "monthName"
        Me.cbbEnd_Month.ValueMember = "monthId"
        Me.cbbEnd_Month.DataSource = dtMonth2
    End Sub

    Private Sub pmethBindingData()
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoadMapBindingSource, "docCode", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpRoadmap.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RoadMapBindingSource, "docDate", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.RoadMapBindingSource.DataSource = Roadmap_Master
    End Sub

    Private Sub pmethBlankVar()
        If mode = GBMod.Add Then
            Roadmap_Master.id = ""
            Roadmap_Master.clear()
            txtCode.Text = String.Empty
            lvRoadmap_detail.Items.Clear()
            Col_RoadMapDetail.Clear()
        ElseIf mode = GBMod.Edit Then
            Roadmap_Master.clear(mode)
        End If
        txtPosition.Text = String.Empty
        rbtMonth.Checked = False
        rbtYear.Checked = False
        pmethDisableYear()
        pmethDisableMonth()
        txtCourseName.Text = String.Empty
    End Sub
    Private Sub pmethBlankVar(AfterInsert As String)
        rbtMonth.Checked = False
        rbtYear.Checked = False
        pmethDisableYear()
        pmethDisableMonth()
        txtCourseName.Text = String.Empty
    End Sub

    Private Sub pmethEnableYear()
        ckbYear1.Enabled = True
        ckbYear2.Enabled = True
        ckbYear3.Enabled = True
        ckbYear4.Enabled = True
        ckbYear5.Enabled = True
        ckbYear6.Enabled = True
        ckbYear7.Enabled = True
        ckbYear8.Enabled = True
        ckbYear9.Enabled = True
        ckbYear10.Enabled = True
    End Sub

    Private Sub pmethDisableYear()
        ckbYear1.Checked = False
        ckbYear2.Checked = False
        ckbYear3.Checked = False
        ckbYear4.Checked = False
        ckbYear5.Checked = False
        ckbYear6.Checked = False
        ckbYear7.Checked = False
        ckbYear8.Checked = False
        ckbYear9.Checked = False
        ckbYear10.Checked = False

        ckbYear1.Enabled = False
        ckbYear2.Enabled = False
        ckbYear3.Enabled = False
        ckbYear4.Enabled = False
        ckbYear5.Enabled = False
        ckbYear6.Enabled = False
        ckbYear7.Enabled = False
        ckbYear8.Enabled = False
        ckbYear9.Enabled = False
        ckbYear10.Enabled = False
    End Sub

    Private Sub pmethEnableMonth()

        cbbBegin_Month.Enabled = True
        cbbEnd_Month.Enabled = True
    End Sub

    Private Sub pmethDisableMonth()
        cbbBegin_Month.SelectedIndex = 0
        cbbEnd_Month.SelectedIndex = 0
        cbbBegin_Month.Enabled = False
        cbbEnd_Month.Enabled = False
    End Sub

    Private Sub pmethGetdata()
        Roadmap_Master.id = Me.id
        Roadmap_Master.getById(Me.id)
        Me.txtPosition.Text = Roadmap_Master.expHD_Position.name
        Me.pmethLoadItem()
    End Sub

    Private Sub pmethLoadItem()
        Col_RoadMapDetail = Roadmap_Master.Item_RoadMapDetail
        BindingRoadMapDetail()
    End Sub

#End Region

#Region "Event"

    Private Sub btnPopPositionName_Click(sender As System.Object, e As System.EventArgs) Handles btnPopPositionName.Click
        Dim FrmVfield As New Select_Position
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
            Me.txtPosition.Text = FrmVfield.Retrun_Name
            Me.txtPosition.Tag = FrmVfield.Retrun_id
            Me.Roadmap_Master.position = FrmVfield.Retrun_id
            Me.Roadmap_Master.station = FrmVfield.Return_station
        End If


    End Sub

    Private Sub btnPopCourseName_Click(sender As System.Object, e As System.EventArgs) Handles btnPopCourseName.Click
        Dim FrmVfield As New Select_course_outline
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
            Me.txtCourseName.Text = FrmVfield.Retrun_Name
            Me.PoStrCourseId = FrmVfield.Retrun_id
            Me.PoStrCourseCode = FrmVfield.Retrun_Code
            Me.PoStrCourseName = FrmVfield.Retrun_Name
            Me.PoStrCourseName02 = FrmVfield.Retrun_Name2
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        Dim strErrmsg As String = String.Empty
        If Roadmap_Master.position = String.Empty Then
            strErrmsg = "กรุณาเลือกตำแหน่งงาน"
        ElseIf Me.PoStrCourseId = String.Empty Then
            strErrmsg = "กรุณาเลือกหลักสูตรการพัฒนา"
        ElseIf ((rbtYear.Checked = False) And (rbtMonth.Checked = False)) Then
            strErrmsg = "กรุณาเลือกช่วงเวลา"
        ElseIf ((rbtYear.Checked = True) And _
               (ckbYear1.Checked = False And ckbYear2.Checked = False And ckbYear3.Checked = False And ckbYear4.Checked = False And ckbYear5.Checked = False And ckbYear6.Checked = False And ckbYear7.Checked = False And ckbYear8.Checked = False And ckbYear9.Checked = False And ckbYear10.Checked = False)) Then
            strErrmsg = "กรุณาเลือกปีพัฒนา"
        ElseIf ((rbtMonth.Checked = True) And _
               (cbbBegin_Month.SelectedValue > cbbEnd_Month.SelectedValue)) Then
            strErrmsg = "ระบุช่วงเดือนไม่ถูกต้อง"
        Else
            If (pmethChkdpRoadMapDetail(Me.PoStrCourseId, strErrmsg) = True) Then
                Dim RdDt As New Cls_HD_Roadmap_Detail
                RdDt.course_master = Me.PoStrCourseId
                RdDt.roadmap_master = Roadmap_Master.id
                If rbtMonth.Checked = True Then
                    RdDt.yearMonthFlag = "M"
                    RdDt.begmonth = cbbBegin_Month.SelectedValue
                    RdDt.endmonth = cbbEnd_Month.SelectedValue
                ElseIf rbtYear.Checked = True Then
                    RdDt.yearMonthFlag = "Y"
                    RdDt.begmonth = 0
                    RdDt.endmonth = 0
                End If
                RdDt.year1 = IIf(Me.ckbYear1.Checked = True, "Y", "N")
                RdDt.year2 = IIf(Me.ckbYear2.Checked = True, "Y", "N")
                RdDt.year3 = IIf(Me.ckbYear3.Checked = True, "Y", "N")
                RdDt.year4 = IIf(Me.ckbYear4.Checked = True, "Y", "N")
                RdDt.year5 = IIf(Me.ckbYear5.Checked = True, "Y", "N")
                RdDt.year6 = IIf(Me.ckbYear6.Checked = True, "Y", "N")
                RdDt.year7 = IIf(Me.ckbYear7.Checked = True, "Y", "N")
                RdDt.year8 = IIf(Me.ckbYear8.Checked = True, "Y", "N")
                RdDt.year9 = IIf(Me.ckbYear9.Checked = True, "Y", "N")
                RdDt.year10 = IIf(Me.ckbYear10.Checked = True, "Y", "N")
                Col_RoadMapDetail.Add(RdDt)
                Me.BindingRoadMapDetail()
                pmethBlankVar("AfterInsert")
            End If
        End If
        If strErrmsg <> String.Empty Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BindingRoadMapDetail()
        Dim i As Integer = 0
        Dim j As Integer = 0
        lvRoadmap_detail.Items.Clear()
        lvRoadmap_detail.FullRowSelect = True
        lvRoadmap_detail.ShowItemToolTips = True
        For Each cs As Object In Col_RoadMapDetail
            i = i + 1
            Dim ObjCs = CType(cs, Cls_HD_Roadmap_Detail)
            If ObjCs.course_master <> String.Empty Then
                j = j + 1
                Dim Itemm As New ListViewItem(ObjCs.id)
                Itemm.SubItems.Add(i)
                Itemm.SubItems.Add(j.ToString)
                Itemm.SubItems.Add(ObjCs.expHD_Course_Master.expCourse.code)
                Itemm.SubItems.Add(ObjCs.expHD_Course_Master.expCourse.name)
                Itemm.SubItems.Add(New Cls_HD_Course_Struct(Nothing, ObjCs.course_master).sum_main_hour.ToString())
                Itemm.SubItems.Add(New Cls_Course_Master(ObjCs.course_master).expHdTool.name.ToString())
                Itemm.SubItems.Add(IIf(ObjCs.year1.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year2.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year3.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year4.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year5.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year6.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year7.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year8.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year9.ToString() = "Y", "@", ""))
                Itemm.SubItems.Add(IIf(ObjCs.year10.ToString() = "Y", "@", ""))
                If ObjCs.begmonth > 0 Then
                    Itemm.SubItems.Add(ObjCs.begmonth.ToString() & "-" & ObjCs.endmonth.ToString())
                Else
                    Itemm.SubItems.Add("")
                End If
                lvRoadmap_detail.Items.Add(Itemm)
            End If
        Next
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim Obj As Object = Col_RoadMapDetail(Convert.ToInt16(lvRoadmap_detail.SelectedItems.Item(0).SubItems(1).Text))
            Dim ObjCs = CType(Obj, Cls_HD_Roadmap_Detail)
            ObjCs.course_master = ""
            Me.BindingRoadMapDetail()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SqlDB As New Cls_SqlDB
        Dim bSucc = True
        Dim StrErrmsg As String = String.Empty
        Dim Errmsg As String = String.Empty
        Try
            If ValidateData() = True Then
                SqlDB.BeginTrans()
                If mode = GBMod.Add Then
                    Roadmap_Master.docCode = FunctionClass.GetDocumentNo("Roadmap_Master", {}, "", GBCorp, _
                    GBAppName, GBApp_Path, Errmsg)
                    If Roadmap_Master.Add(SqlDB) = False Then
                        StrErrmsg = Roadmap_Master.message
                        bSucc = False
                    End If
                ElseIf mode = GBMod.Edit Then
                    If Roadmap_Master.Update(SqlDB) = False Then
                        StrErrmsg = Roadmap_Master.message
                        bSucc = False
                    End If
                End If
                If bSucc Then
                    bSucc = Me.pmethSaveRoadMapDetail(SqlDB, StrErrmsg)
                End If
                If bSucc = True Then
                    SqlDB.CommitTrans()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    pmethBlankVar()
                    If mode = GBMod.Edit Then
                        lvRoadmap_detail.Items.Clear()
                        Col_RoadMapDetail.Clear()
                        Close()
                    Else
                        Me.FormBrow.binddata()
                    End If
                Else
                    MessageBox.Show(StrErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SqlDB.RollbackTrans()
                End If
            End If
        Catch ex As Exception
            SqlDB.RollbackTrans()
        End Try
    End Sub

    Private Function pmethSaveRoadMapDetail(SqlDB As Cls_SqlDB, ByRef ErrorMas As String) As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer
        For Each cs As Object In Col_RoadMapDetail
            Dim ObjCs = CType(cs, Cls_HD_Roadmap_Detail)
            If ObjCs.course_master <> String.Empty Then
                i = i + 1
                ObjCs.Corp_id = GBCorp
                ObjCs.roadmap_master = Roadmap_Master.id
                ObjCs.seq = i
                If ObjCs.id <> String.Empty Then
                    bSucc = ObjCs.Update(SqlDB)
                Else
                    bSucc = ObjCs.Save(SqlDB)
                End If
                If bSucc = False Then
                    ErrorMas = ObjCs.message
                    Return bSucc
                End If
            Else
                If ObjCs.id <> String.Empty Then
                    ObjCs.Delete(SqlDB)
                End If
            End If
        Next
        Return bSucc
    End Function

    Private Function ValidateData() As Boolean
        Dim bSucc = True
        Dim i As Integer
        Dim strErrmsg As String = String.Empty
        If Col_RoadMapDetail.Count = 0 Then
            bSucc = False
            strErrmsg = "กรุณาเลือกหลักสูตรพัฒนา"
        ElseIf Me.pmethItemOK() = False Then
            bSucc = False
            strErrmsg = "กรุณาเลือกหลักสูตรพัฒนา"
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return bSucc
    End Function

    Private Function pmethItemOK() As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer = 0
        For Each cs As Object In Col_RoadMapDetail
            Dim ObjCs = CType(cs, Cls_HD_Roadmap_Detail)
            If ObjCs.course_master <> String.Empty Then
                i = i + 1
            End If
        Next
        If i = 0 Then
            bSucc = False
        End If
        Return bSucc
    End Function

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        pmethBlankVar()
    End Sub

    Private Function pmethChkdpRoadMapDetail(courseMaster As String, ByRef strErrmsg As String) As Boolean
        Dim bSucc As Boolean = True
        For Each cs As Object In Col_RoadMapDetail
            Dim ObjCs = CType(cs, Cls_HD_Roadmap_Detail)
            If ObjCs.course_master = courseMaster Then
                strErrmsg = "ข้อมูลหลักสูตรซ้ำ!"
                bSucc = False
                Exit For
            End If
        Next
        Return bSucc
    End Function

    Private Sub rbtMonth_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtMonth.CheckedChanged
        pmethEnableMonth()
        pmethDisableYear()
    End Sub

    Private Sub rbtYear_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtYear.CheckedChanged
        pmethEnableYear()
        pmethDisableMonth()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click

    End Sub
#End Region



End Class