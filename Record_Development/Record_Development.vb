Public Class Record_Development
    Public mode As String = String.Empty
    Public id As String = String.Empty
    Public FormBrow As Browse_Record_Development
    Private RecordDevBindingSource As New BindingSource
    Private RecordDevMaster As New Record_Development_Master
    Private RecordDevDetail As New Record_Development_Detail
    Private Annual_Master As New Cls_Annual_Master
    Private Annual_Detail As New Cls_Annual_Detail
    Private Col_RecordDevDetail As New Collection
    Private Course_Master As New Cls_Course_Master
    Private Course_Master_Struct As New Cls_HD_Course_Struct

    Dim bCancelEdit As Boolean
    Dim CurrentSB As ListViewItem.ListViewSubItem
    Dim CurrentItem As ListViewItem


    Private Sub Record_Development_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
    End Sub

    Public Sub pmethInit()
        pmethBindingData()
        pmethSetDataSource()
        pmethBlankVar()
    End Sub

    Private Sub pmethBindingData()
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", RecordDevBindingSource, "doc_code", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpResultTraining.DataBindings.Add(New System.Windows.Forms.Binding("Value", RecordDevBindingSource, "doc_date", True, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub pmethSetDataSource()
        cbb_pass.ValueMember = "Value"
        cbb_pass.DisplayMember = "Text"
        Dim dtPass As New DataTable
        dtPass.Columns.Add("Text", GetType(String))
        dtPass.Columns.Add("Value", GetType(String))
        dtPass.Rows.Add("ไม่ระบุ", "ไม่ระบุ")
        dtPass.Rows.Add("ไม่ผ่าน", "ไม่ผ่าน")
        dtPass.Rows.Add("ผ่าน", "ผ่าน")
        cbb_pass.DataSource = dtPass
    End Sub

    Private Sub pmethBlankVar()
        RecordDevMaster.Clear()
        RecordDevDetail.Clear()
        Annual_Master.Clear()
        Annual_Detail.clear()
        Course_Master.Clear()
        Course_Master_Struct = New Cls_HD_Course_Struct
        Col_RecordDevDetail = New Collection
        lvResult_Training.Items.Clear()
        RecordDevBindingSource.DataSource = RecordDevMaster
        dtpResultTraining.Text = DateTime.Now
        txtCourseMaster.Text = String.Empty
        txtCourseMaster.Tag = String.Empty
        txtAnnual.Text = String.Empty
        txtEdition.Text = String.Empty
        txtMain_hour.Text = String.Empty
        txtCourse_content.Text = String.Empty
        txtInstitution.Text = String.Empty
        dtpBegdate.Value = DateTime.Now.Date
        dtpEnddate.Value = DateTime.Now.Date
        txtGuest_Name1.Text = String.Empty
        txtGuest_Post1.Text = String.Empty
        txtGuest_Name2.Text = String.Empty
        txtGuest_Post2.Text = String.Empty
        txtQty.Text = String.Empty
        txtPlace.Text = String.Empty
        If mode = GBMod.Add Then
            RecordDevMaster.doc_code = "Autorun"
        ElseIf mode = GBMod.Edit Then
            pmethGetdata()
        End If
        pmethSetprop()
    End Sub

    Private Sub pmethBlankVarClear()
        RecordDevMaster.Clear()
        RecordDevDetail.Clear()
        Annual_Master.Clear()
        Annual_Detail.clear()
        Course_Master.Clear()
        Course_Master_Struct = New Cls_HD_Course_Struct
        Col_RecordDevDetail = New Collection
        lvResult_Training.Items.Clear()
        dtpResultTraining.Value = DateTime.Now.Date
        txtCourseMaster.Text = String.Empty
        txtCourseMaster.Tag = String.Empty
        txtAnnual.Text = String.Empty
        txtEdition.Text = String.Empty
        txtMain_hour.Text = String.Empty
        txtCourse_content.Text = String.Empty
        txtInstitution.Text = String.Empty
        dtpBegdate.Value = DateTime.Now.Date
        dtpEnddate.Value = DateTime.Now.Date
        txtGuest_Name1.Text = String.Empty
        txtGuest_Post1.Text = String.Empty
        txtGuest_Name2.Text = String.Empty
        txtGuest_Post2.Text = String.Empty
        txtQty.Text = String.Empty
        txtPlace.Text = String.Empty
        RecordDevMaster.doc_code = "Autorun"
    End Sub

    Private Sub pmethBlankVarClearBtnCourse()
        Me.txtAnnual.Text = String.Empty
        Me.txtEdition.Text = String.Empty
        Me.txtMain_hour.Text = String.Empty
        Me.txtCourse_content.Text = String.Empty
        Me.txtInstitution.Text = String.Empty
        dtpBegdate.Value = DateTime.Now.Date
        dtpEnddate.Value = DateTime.Now.Date
        Me.txtGuest_Name1.Text = String.Empty
        Me.txtGuest_Post1.Text = String.Empty
        Me.txtGuest_Name2.Text = String.Empty
        Me.txtGuest_Post2.Text = String.Empty
        Me.txtQty.Text = String.Empty
        Me.txtPlace.Text = String.Empty
        lvResult_Training.Items.Clear()
        Course_Master.Clear()
        Annual_Master.Clear()
        Course_Master_Struct = New Cls_HD_Course_Struct
    End Sub

    Private Sub pmethGetdata()
        RecordDevMaster.id = Me.id
        RecordDevMaster.getById(Me.id)

        txtCourseMaster.Text = New Cls_Course_Master(RecordDevMaster.course_master).code & " - " & New Cls_HD_Course(New Cls_Course_Master(RecordDevMaster.course_master).course).name
        txtAnnual.Text = New Cls_Annual_Master(RecordDevMaster.ann_master).doc_code & " - " & New Cls_HD_Course(New Cls_Course_Master(RecordDevMaster.course_master).course).name

        Annual_Master.getById(RecordDevMaster.ann_master)
        Course_Master.getById(RecordDevMaster.course_master)
        Course_Master_Struct.course_master = RecordDevMaster.course_master

        pmethShowCourseMaster(Course_Master)
        pmethShowAnnualMaster(Annual_Master)
        pmethShowCourseMasterStruc(Course_Master_Struct)

        Me.pmethLoadItem()
    End Sub

    Private Sub pmethSetprop()
        txtCode.Enabled = False
        txtCourseMaster.Enabled = False
        txtAnnual.Enabled = False
        txtEdition.Enabled = False
        txtMain_hour.Enabled = False
        txtCourse_content.Enabled = False
        txtInstitution.Enabled = False
        txtGuest_Name1.Enabled = False
        txtGuest_Post1.Enabled = False
        txtGuest_Name2.Enabled = False
        txtGuest_Post2.Enabled = False
        txtQty.Enabled = False
        txtPlace.Enabled = False
        dtpBegdate.Enabled = False
        dtpEnddate.Enabled = False
        If mode = GBMod.Edit Then
            btnClear.Enabled = False
            btnPopCourseMaster.Enabled = False
            btnPopAnnual.Enabled = False
        End If
    End Sub

    Private Sub pmethLoadItem()
        Col_RecordDevDetail = RecordDevMaster.Item_RecordDevDetail
        binddata()
    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If mode = GBMod.Add Then
            If String.IsNullOrEmpty(txtAnnual.Text) Then
                strErrmsg = "กรุณาระบุแผนพัฒนาประจำปี"
                bSucc = False
            End If
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SqlDB As New Cls_SqlDB
        Dim bSucc = True
        Dim strErrmsg As String = String.Empty
        Dim Errmsg As String = String.Empty
        Try
            If ValidateData() = True Then
                SqlDB.BeginTrans()
                If mode = GBMod.Add Then
                    RecordDevMaster.doc_code = FunctionClass.GetDocumentNo("Record_Development", {}, "", GBCorp, GBAppName, GBApp_Path, Errmsg)
                    If RecordDevMaster.Add(SqlDB) = False Then
                        strErrmsg = RecordDevMaster.message
                        bSucc = False
                    End If
                ElseIf mode = GBMod.Edit Then
                    If RecordDevMaster.Update(SqlDB) = False Then
                        strErrmsg = RecordDevMaster.message
                        bSucc = False
                    End If
                End If

                If bSucc Then
                    Me.pmethSaveRecordDevDetail(SqlDB, strErrmsg)
                End If

                If bSucc = True Then
                    SqlDB.CommitTrans()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    pmethBlankVar()
                    If mode = GBMod.Edit Then
                        Close()
                    Else
                        RecordDevMaster.doc_code = "Autorun"
                        Me.FormBrow.binddata()
                    End If
                Else
                    MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SqlDB.RollbackTrans()
                End If
            End If
        Catch ex As Exception
            SqlDB.RollbackTrans()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        If mode = GBMod.Add Then
            pmethBlankVarClear()
        End If
    End Sub

    Private Function pmethSaveRecordDevDetail(SqlDB As Cls_SqlDB, ByRef strErrmsg As String) As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer
        For Each ObjCs As Record_Development_Detail In Col_RecordDevDetail
            If ObjCs.person_data <> String.Empty Then
                i = i + 1
                ObjCs.Corp_id = GBCorp
                ObjCs.resultdev_master = RecordDevMaster.id
                ObjCs.seq = i

                If ObjCs.id <> String.Empty Then
                    bSucc = ObjCs.Update(SqlDB)
                Else
                    bSucc = ObjCs.Save(SqlDB)
                End If

                If bSucc = False Then
                    strErrmsg = ObjCs.message
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

    Private Sub btnPopCourseMaster_Click(sender As System.Object, e As System.EventArgs) Handles btnPopCourseMaster.Click
        Dim FrmVfield As New Select_Course_Master
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.return_course_master_id) = False Then
            Me.txtCourseMaster.Text = FrmVfield.return_course_code & "-" & FrmVfield.return_course_name
            Me.txtCourseMaster.Tag = FrmVfield.return_course_master_id
            pmethBlankVarClearBtnCourse()
        End If
    End Sub

    Private Sub btnPopAnnual_Click(sender As System.Object, e As System.EventArgs) Handles btnPopAnnual.Click
        Dim FrmVfield As New Select_Annual_Master
        If txtCourseMaster.Tag <> String.Empty Then
            FrmVfield.Get_Course_Master_Id = txtCourseMaster.Tag.ToString()
        Else
            FrmVfield.Get_Course_Master_Id = String.Empty
        End If
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.return_annual_id) = False Then
            Course_Master.Clear()
            Annual_Master.Clear()
            Course_Master_Struct = New Cls_HD_Course_Struct
            Me.txtAnnual.Text = FrmVfield.return_annual_code & "-" & FrmVfield.return_annual_course_master_name
            Me.txtAnnual.Tag = FrmVfield.return_annual_id

            Course_Master.getById(FrmVfield.return_annual_course_master)
            pmethShowCourseMaster(Course_Master)

            Annual_Master.getById(FrmVfield.return_annual_id)
            pmethShowAnnualMaster(Annual_Master)

            Course_Master_Struct.course_master = FrmVfield.return_annual_course_master
            pmethShowCourseMasterStruc(Course_Master_Struct)

            RecordDevMaster.ann_master = FrmVfield.return_annual_id
            RecordDevMaster.course_master = FrmVfield.return_annual_course_master
            RecordDevMaster.main_hour = Annual_Master.main_hour
            RecordDevMaster.year = Annual_Master.year
            RecordDevMaster.edition = Annual_Master.edition
            RecordDevMaster.qty_people = Annual_Master.qty

            If Col_RecordDevDetail.Count > 0 Then
                For Each cs As Object In Col_RecordDevDetail
                    Dim ObjCs2 = CType(cs, Record_Development_Detail)
                    ObjCs2.person_data = ""
                Next
            End If
            Dim dtAnnualDetail As New DataTable
            Annual_Detail.annual_master = FrmVfield.return_annual_id
            dtAnnualDetail = Annual_Detail.Retreive()
            Dim nindex As Integer = 0
            For row As Integer = 0 To dtAnnualDetail.Rows.Count - 1
                Dim position As New Cls_Position
                Dim dtPosition As New DataTable
                nindex = nindex + 1
                RecordDevDetail = New Record_Development_Detail
                RecordDevDetail.annual_detail = dtAnnualDetail.Rows(row).Item("and_id").ToString()
                RecordDevDetail.seq = nindex
                RecordDevDetail.person_data = dtAnnualDetail.Rows(row).Item("and_person_data").ToString()
                RecordDevDetail.position = dtAnnualDetail.Rows(row).Item("and_position").ToString()
                dtPosition = position.RetreivePersonDataFromPosition(dtAnnualDetail.Rows(row).Item("and_position").ToString(), dtAnnualDetail.Rows(row).Item("and_person_data").ToString())
                RecordDevDetail.station = dtPosition.Rows(0)("s_id")
                RecordDevDetail.join = String.Empty
                RecordDevDetail.passed = String.Empty
                RecordDevDetail.score = 0
                Col_RecordDevDetail.Add(RecordDevDetail)
            Next
            binddata()
        End If
    End Sub

    Private Sub binddata()
        Dim i As Integer = 0
        Dim j As Integer = 0
        lvResult_Training.Items.Clear()
        Try
            If Col_RecordDevDetail.Count > 0 Then
                Dim position As New Cls_Position
                Dim dtPosition As New DataTable
                lvResult_Training.FullRowSelect = True
                lvResult_Training.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For Each cs As Object In Col_RecordDevDetail
                    i = i + 1
                    Dim ObjCs = CType(cs, Record_Development_Detail)
                    If ObjCs.person_data <> String.Empty Then
                        j = j + 1
                        Dim Item As New ListViewItem()
                        If ObjCs.join = "Y" Then
                            Item.Checked = True
                        ElseIf ObjCs.join = "N" Then
                            Item.Checked = False
                        End If
                        Item.SubItems.Add(ObjCs.id)
                        Item.SubItems.Add(i)
                        Item.SubItems.Add(j)
                        dtPosition = position.RetreivePersonDataFromPosition(ObjCs.position, ObjCs.person_data)
                        Item.SubItems.Add(dtPosition.Rows(0)("em_code"))
                        Item.SubItems.Add(dtPosition.Rows(0)("name_01") & " " & dtPosition.Rows(0)("sname_01"))
                        Item.SubItems.Add(dtPosition.Rows(0)("pname"))
                        Item.SubItems.Add(dtPosition.Rows(0)("sname"))
                        'Item.SubItems.Add(ObjCs.join)
                        If ObjCs.passed = "T" Then
                            Item.SubItems.Add("ผ่าน")
                        ElseIf ObjCs.passed = "F" Then
                            Item.SubItems.Add("ไม่ผ่าน")
                        Else
                            Item.SubItems.Add(String.Empty)
                        End If
                        Item.SubItems.Add(ObjCs.score)
                        lvResult_Training.Items.Add(Item)
                        lvResult_Training.Columns(0).DisplayIndex = 7
                        lvResult_Training.Columns(0).Width = 50
                        nindex = nindex + 1
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub


    Private Sub pmethShowCourseMaster(Course_Master As Cls_Course_Master)
        Dim varCount_Guest As Integer = 0

        If String.IsNullOrEmpty(Course_Master.guest_in_id1) = False Then
            varCount_Guest = varCount_Guest + 1
            pmethCheckGuest(varCount_Guest, New Cls_HD_Guest(Course_Master.guest_in_id1).name.ToString(), New Cls_HD_Guest(Course_Master.guest_in_id1).position.ToString(), New Cls_HD_Guest(Course_Master.guest_in_id1).institution.ToString())
        End If

        If String.IsNullOrEmpty(Course_Master.guest_in_id2) = False Then
            varCount_Guest = varCount_Guest + 1
            pmethCheckGuest(varCount_Guest, New Cls_HD_Guest(Course_Master.guest_in_id2).name.ToString(), New Cls_HD_Guest(Course_Master.guest_in_id2).position.ToString(), New Cls_HD_Guest(Course_Master.guest_in_id2).institution.ToString())
        End If

        If String.IsNullOrEmpty(Course_Master.guest_ext_id1) = False Then
            varCount_Guest = varCount_Guest + 1
            pmethCheckGuest(varCount_Guest, New Cls_HD_Guest(Course_Master.guest_ext_id1).name.ToString(), New Cls_HD_Guest(Course_Master.guest_ext_id1).position.ToString(), New Cls_HD_Guest(Course_Master.guest_ext_id1).institution.ToString())
        End If

        If String.IsNullOrEmpty(Course_Master.guest_ext_id2) = False Then
            varCount_Guest = varCount_Guest + 1
            pmethCheckGuest(varCount_Guest, New Cls_HD_Guest(Course_Master.guest_ext_id2).name.ToString(), New Cls_HD_Guest(Course_Master.guest_ext_id2).position.ToString(), New Cls_HD_Guest(Course_Master.guest_ext_id2).institution.ToString())
        End If

        If varCount_Guest = 0 Then
            txtGuest_Name1.Text = String.Empty
            txtGuest_Post1.Text = String.Empty
            txtGuest_Name2.Text = String.Empty
            txtGuest_Post2.Text = String.Empty
            txtInstitution.Text = String.Empty
        ElseIf varCount_Guest = 1 Then
            txtGuest_Name2.Text = String.Empty
            txtGuest_Post2.Text = String.Empty
        End If

    End Sub

    Private Sub pmethShowAnnualMaster(Annual_Master As Cls_Annual_Master)
        txtEdition.Text = Annual_Master.edition
        txtMain_hour.Text = Annual_Master.main_hour
        dtpBegdate.Value = Annual_Master.begdate
        dtpEnddate.Value = Annual_Master.enddate
        txtQty.Text = Annual_Master.qty
        txtPlace.Text = New Cls_HD_Place(Annual_Master.place).name.ToString()
    End Sub

    Private Sub pmethShowCourseMasterStruc(Course_Master_Struct As Cls_HD_Course_Struct)
        Dim dtCourseMasterStuct As New DataTable
        dtCourseMasterStuct = Course_Master_Struct.Retreive()
        If dtCourseMasterStuct.Rows.Count > 0 Then
            txtCourse_content.Text = New Cls_HD_Course_Content(dtCourseMasterStuct.Rows(0).Item("cst_course_content1").ToString()).name.ToString()
        Else
            txtCourse_content.Text = String.Empty
        End If
    End Sub

    Private Sub pmethCheckGuest(varAmount As Int16, getGuest As String, getGuestPosition As String, getInstitution As String)
        Dim Count As Integer = 0
        If varAmount = 1 Then
            txtGuest_Name1.Text = getGuest
            txtGuest_Post1.Text = getGuestPosition
            txtInstitution.Text = getInstitution
        ElseIf varAmount = 2 Then
            txtGuest_Name2.Text = getGuest
            txtGuest_Post2.Text = getGuestPosition
        End If
    End Sub

    Private Sub btnDetail_Course_Click(sender As System.Object, e As System.EventArgs) Handles btnDetail_Course.Click
        If String.IsNullOrEmpty(txtAnnual.Text) Then
            MessageBox.Show("ไม่พบข้อมูล", "รายละเอียดหลักสูตร", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub



    Private Sub txtScore_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtScore.KeyPress
        Select Case e.KeyChar

            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                txtScore.Hide()

            Case Microsoft.VisualBasic.ChrW(Keys.Escape)    ' Escape key is pressed
                bCancelEdit = True  ' editing was cancelled
                e.Handled = True
                txtScore.Hide()

        End Select
    End Sub

    Private Sub cbb_pass_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbb_pass.KeyPress
        Select Case e.KeyChar

            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                cbb_pass.Hide()

            Case Microsoft.VisualBasic.ChrW(Keys.Escape)    ' Escape key is pressed
                bCancelEdit = True  ' editing was cancelled
                e.Handled = True
                cbb_pass.Hide()

        End Select
    End Sub


    Private Sub lvResult_Training_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lvResult_Training.MouseClick
        CurrentItem = lvResult_Training.GetItemAt(e.X, e.Y)     ' which listviewitem was clicked
        If CurrentItem Is Nothing Then Exit Sub
        CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y)  ' which subitem was clicked
        Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
        Select Case iSubIndex
            Case 8, 9
                ' These two columns are allowed to be edited. So continue the code
            Case 0
                If CurrentItem.Checked = True Then
                    CurrentItem.Selected = True
                    Dim Obj2 As Object = Col_RecordDevDetail(Convert.ToInt16(lvResult_Training.SelectedItems.Item(0).SubItems(2).Text))
                    Dim ObjCs2 = CType(Obj2, Record_Development_Detail)
                    ObjCs2.join = "N"
                Else
                    CurrentItem.Selected = True
                    Dim Obj2 As Object = Col_RecordDevDetail(Convert.ToInt16(lvResult_Training.SelectedItems.Item(0).SubItems(2).Text))
                    Dim ObjCs2 = CType(Obj2, Record_Development_Detail)
                    ObjCs2.join = "Y"
                End If
                CurrentItem.Selected = False
                Exit Sub
            Case Else
                ' In my example I have defined that only "Runs" and "Wickets" columns can be edited by user
                Exit Sub
        End Select
        If iSubIndex = 0 Then
            ' There's a slight coding difficulty here. If the first item is to be edited
            ' then when you get the Bounds of the first subitem, it returns the Bounds of
            ' the entire ListViewItem. Hence the Textbox looks very wierd. In order to allow
            ' editing on the first column, we use the built-in editing method.

            CurrentItem.BeginEdit()     ' make sure the LabelEdit is set to True
            Exit Sub
        End If

        Select Case iSubIndex
            Case 8
                Dim lLeft = CurrentSB.Bounds.Left + 2
                Dim lWidth As Integer = CurrentSB.Bounds.Width
                With cbb_pass
                    .SetBounds(lLeft + lvResult_Training.Left, CurrentSB.Bounds.Top + lvResult_Training.Top, lWidth, CurrentSB.Bounds.Height)
                    .SelectedValue = CurrentSB.Text
                    .Show()
                    .Focus()
                End With
            Case 9
                Dim lLeft = CurrentSB.Bounds.Left + 2
                Dim lWidth As Integer = CurrentSB.Bounds.Width
                With txtScore
                    .SetBounds(lLeft + lvResult_Training.Left, CurrentSB.Bounds.Top + lvResult_Training.Top, lWidth, CurrentSB.Bounds.Height)
                    .Text = CurrentSB.Text
                    .Show()
                    .Focus()
                End With
            Case Else
                ' In my example I have defined that only "Runs" and "Wickets" columns can be edited by user
                Exit Sub
        End Select
    End Sub

    Private Sub lvResult_Training_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles lvResult_Training.KeyDown
        If lvResult_Training.SelectedItems.Count = 0 Then Exit Sub

        Select Case e.KeyCode
            Case Keys.F2    ' F2 key is pressed. Initiate editing
                e.Handled = True
                BeginEditListItem(lvResult_Training.SelectedItems(0), 8)

        End Select
    End Sub

    Private Sub txtScore_LostFocus(sender As Object, e As System.EventArgs) Handles txtScore.LostFocus
        txtScore.Hide()
        If bCancelEdit = False Then
            If txtScore.Text.Trim <> "" Then
                If IsNumeric(txtScore.Text) = False Then
                    MsgBox("กรุณาระบบข้อมูลเป็นตัวเลข", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                CurrentSB.Text = CInt(txtScore.Text).ToString("#,###0.00")
            End If
            Dim Obj2 As Object = Col_RecordDevDetail(Convert.ToInt16(lvResult_Training.SelectedItems.Item(0).SubItems(2).Text))
            Dim ObjCs2 = CType(Obj2, Record_Development_Detail)
            If CurrentItem.Checked = True Then
                ObjCs2.join = "Y"
            Else
                ObjCs2.join = "N"
            End If
            ObjCs2.score = CurrentSB.Text
        Else
            bCancelEdit = False
        End If
        lvResult_Training.Focus()
    End Sub

    Private Sub cbb_pass_LostFocus(sender As Object, e As System.EventArgs) Handles cbb_pass.LostFocus
        Try
            cbb_pass.Hide()
            If bCancelEdit = False Then
                CurrentSB.Text = cbb_pass.SelectedValue.ToString()

                Dim Obj2 As Object = Col_RecordDevDetail(Convert.ToInt16(lvResult_Training.SelectedItems.Item(0).SubItems(2).Text))
                Dim ObjCs2 = CType(Obj2, Record_Development_Detail)
                If CurrentItem.Checked = True Then
                    ObjCs2.join = "Y"
                Else
                    ObjCs2.join = "N"
                End If
                If CurrentSB.Text = String.Empty Then
                    ObjCs2.passed = String.Empty
                ElseIf CurrentSB.Text = "ไม่ผ่าน" Then
                    ObjCs2.passed = "F"
                ElseIf CurrentSB.Text = "ผ่าน" Then
                    ObjCs2.passed = "T"
                ElseIf CurrentSB.Text = "ไม่ระบุ" Then
                    ObjCs2.passed = String.Empty
                End If
            Else
                bCancelEdit = False
            End If
            lvResult_Training.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BeginEditListItem(iTm As ListViewItem, SubItemIndex As Integer)

        Dim pt As Point = iTm.SubItems(SubItemIndex).Bounds.Location
        Dim ee As New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, pt.X, pt.Y, 0)
        Call lvResult_Training_MouseClick(lvResult_Training, ee)
    End Sub

    Private Sub lvResult_Training_ItemCheck(sender As System.Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles lvResult_Training.ItemCheck

    End Sub
End Class