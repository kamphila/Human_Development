Public Class Register_DEV
    Public mode As String = String.Empty
    Public id As String = String.Empty
    Public FormBrow As Register_DEV_Browser
    Private RegisterBindingSource As New BindingSource
    Private Register_Master As New Cls_Register_Master
    Private Register_Detail As New Cls_Register_Detail
    Private Annaul_Master As New Cls_Annual_Master
    Private Col_RegisterDetail As New Collection
    Private Course_Master As New Cls_Course_Master
    Public BranchId As String


    Dim bCancelEdit As Boolean
    Dim CurrentSB As ListViewItem.ListViewSubItem
    Dim CurrentItem As ListViewItem

    Private Sub Register_DEV_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
    End Sub

    Sub pmethInit()
        pmethBindingData()
        pmethSetDataSource()
        pmethBlankVar()
    End Sub

    Private Sub pmethSetDataSource()
        Dim dtCourseMaster As DataTable
        dtCourseMaster = Course_Master.RetreiveByCourseName(String.Empty, String.Empty)
        Me.cbbCourse_master.DisplayMember = "cos_name"
        Me.cbbCourse_master.ValueMember = "cms_id"
        If dtCourseMaster.Rows.Count > 0 Then
            Dim dr As DataRow
            dr = dtCourseMaster.NewRow
            dr.Item("cos_name") = "<-- ระบุหลักสูตร -->"
            dr.Item("cms_id") = String.Empty
            dtCourseMaster.Rows.InsertAt(dr, 0)
        End If
        Me.cbbCourse_master.DataSource = dtCourseMaster
        Me.cbbCourse_master.SelectedIndex = 0


        Dim dtYear As New DataTable
        Dim year_column As DataColumn
        Dim year_row As DataRow
        Dim var_year = New String() {"ไม่ระบุ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"}

        year_column = New DataColumn
        year_column.DataType = System.Type.GetType("System.String")
        year_column.ColumnName = "yearId"
        dtYear.Columns.Add(year_column)
        year_column = New DataColumn
        year_column.DataType = Type.GetType("System.String")
        year_column.ColumnName = "yearName"
        dtYear.Columns.Add(year_column)
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To 10
            year_row = dtYear.NewRow
            If i = 0 Then
                year_row("yearId") = String.Empty
            Else
                year_row("yearId") = i
            End If
            year_row("yearName") = var_year(j)
            dtYear.Rows.Add(year_row)
            j = j + 1
        Next i

        Dim dtEdition As New DataTable
        Dim edition_column As DataColumn
        Dim edition_row As DataRow
        Dim var_edition = New String() {"ไม่ระบุ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"}

        edition_column = New DataColumn
        edition_column.DataType = System.Type.GetType("System.Int32")
        edition_column.ColumnName = "editionId"
        dtEdition.Columns.Add(edition_column)
        edition_column = New DataColumn
        edition_column.DataType = Type.GetType("System.String")
        edition_column.ColumnName = "editionName"
        dtEdition.Columns.Add(edition_column)
        Dim k As Integer = 0
        Dim l As Integer = 0
        For k = 0 To 10
            edition_row = dtEdition.NewRow
            edition_row("editionId") = k
            edition_row("editionName") = var_edition(l)
            dtEdition.Rows.Add(edition_row)
            l = l + 1
        Next k

        Me.cbbYear.DisplayMember = "yearName"
        Me.cbbYear.ValueMember = "yearId"
        Me.cbbEdition.DisplayMember = "editionName"
        Me.cbbEdition.ValueMember = "editionId"

        Me.cbbYear.DataSource = dtYear
        Me.cbbEdition.DataSource = dtEdition

        Me.cbbYear.SelectedIndex = 0
        Me.cbbEdition.SelectedIndex = 0

    End Sub

    Private Sub pmethBindingData()
        Me.txtAnnual_code.DataBindings.Add(New System.Windows.Forms.Binding("Text", RegisterBindingSource, "doc_code", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpRegister.DataBindings.Add(New System.Windows.Forms.Binding("Value", RegisterBindingSource, "doc_date", True, DataSourceUpdateMode.OnPropertyChanged))
        'Me.cbbCourse_master.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", RegisterBindingSource, "course_master", True, DataSourceUpdateMode.OnPropertyChanged))
        'Me.cbbEdition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", RegisterBindingSource, "edition", True, DataSourceUpdateMode.OnPropertyChanged))
        'Me.cbbYear.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", RegisterBindingSource, "year", True, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub pmethBlankVar()
        Register_Master.Clear()
        Register_Detail.Clear()
        Col_RegisterDetail = New Collection
        lvRegister.Items.Clear()
        RegisterBindingSource.DataSource = Register_Master
        txtAnnual_code.Text = String.Empty
        dtpRegister.Text = DateTime.Now.Date
        cbbCourse_master.Refresh()
        cbbCourse_master.SelectedIndex = 0
        cbbYear.Refresh()
        cbbYear.SelectedIndex = 0
        cbbEdition.Refresh()
        cbbEdition.SelectedIndex = 0
        cbbAnnual.DataSource = Nothing
        cbbAnnual.Items.Clear()
        If mode = GBMod.Add Then
            Register_Master.doc_code = "Autorun"
        ElseIf mode = GBMod.Edit Then
            pmethGetdata()
        End If
        pmethSetprop()

    End Sub

    Private Sub pmethBlankVarClear()
        If mode = GBMod.Add Then
            Register_Master.Clear()
            Register_Detail.Clear()
            Register_Master.doc_code = "Autorun"
            Col_RegisterDetail = New Collection
            lvRegister.Items.Clear()
        End If
    End Sub

    Private Sub pmethGetdata()

        Register_Master.id = Me.id
        Register_Master.getById(Me.id)

        Dim cbba As New Cls_Annual_Master
        cbba.id = Register_Master.ann_master
        pmethListcbb(cbba)

        Me.pmethLoadItem()
    End Sub


    Private Sub pmethSetprop()
        txtAnnual_code.Enabled = False
        If mode = GBMod.Edit Then
            cbbCourse_master.Enabled = False
            cbbYear.Enabled = False
            cbbEdition.Enabled = False
            cbbAnnual.Enabled = False
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub pmethLoadItem()
        Col_RegisterDetail = Register_Master.Item_RegisterDetail
        binddata()
    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If mode = GBMod.Add Then
            If String.IsNullOrEmpty(cbbAnnual.SelectedValue) Or cbbAnnual.SelectedValue = "0" Then
                strErrmsg = "กรุณาระบุหลักสูตรในการค้นหา"
                bSucc = False
            End If
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SqlDB As New Cls_SqlDB
        Dim bSucc = True
        Dim strErrmsg As String = String.Empty
        Dim Errmsg As String = String.Empty
        Dim dtChkdDup As DataTable

        Try
            If ValidateData() = True Then
                Register_Master.Branch_id = Me.BranchId
                Register_Master.ann_master = cbbAnnual.SelectedValue
                Register_Master.course_master = New Cls_Annual_Master(cbbAnnual.SelectedValue).course_master
                Register_Master.year = New Cls_Annual_Master(cbbAnnual.SelectedValue).year
                Register_Master.edition = New Cls_Annual_Master(cbbAnnual.SelectedValue).edition
                Register_Master.main_hour = New Cls_Annual_Master(cbbAnnual.SelectedValue).main_hour
                Register_Master.qty_people = New Cls_Annual_Master(cbbAnnual.SelectedValue).qty
                SqlDB.BeginTrans()
                If mode = GBMod.Add Then
                    Register_Master.doc_code = FunctionClass.GetDocumentNo("Register_Dev", {}, "", GBCorp, GBAppName, GBApp_Path, Errmsg)
                    dtChkdDup = Register_Master.ChkDuplicate()
                    If dtChkdDup.Rows.Count <= 0 Then
                        Annaul_Master = New Cls_Annual_Master
                        Annaul_Master.id = Register_Master.ann_master
                        Annaul_Master.getstep = Config.Anm_Step_Register

                        If Annaul_Master.UpdateFrom_Register(SqlDB) = False Then
                            strErrmsg = Annaul_Master.message
                            bSucc = False
                        End If
                    End If

                    If Register_Master.Add(SqlDB) = False Then
                        strErrmsg = Register_Master.message
                        bSucc = False
                    End If

                ElseIf mode = GBMod.Edit Then
                    If Register_Master.Update(SqlDB) = False Then
                        strErrmsg = Register_Master.message
                        bSucc = False
                    End If
                End If

                If bSucc Then
                    Me.pmethSaveRegisterDetail(SqlDB, strErrmsg)
                End If

                If bSucc = True Then
                    SqlDB.CommitTrans()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    pmethBlankVar()
                    If mode = GBMod.Edit Then
                        Close()
                    Else
                        Register_Master.doc_code = "Autorun"
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

    Private Function pmethSaveRegisterDetail(SqlDB As Cls_SqlDB, strErrmsg As String) As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer
       Dim var_shortdate As String
        Dim var_time As String
        For Each ObjCs As Cls_Register_Detail In Col_RegisterDetail
            var_shortdate = Register_Master.doc_date.ToShortDateString()
            var_time = ObjCs.reg_datetime.ToString("HH:mm:ss")
            ObjCs.reg_datetime = Convert.ToDateTime(var_shortdate & " " & var_time)
            If ObjCs.person_data <> String.Empty Then
                i = i + 1
                ObjCs.Corp_id = GBCorp
                ObjCs.register = Register_Master.id
                ObjCs.Branch_id = Me.BranchId
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
            var_shortdate = String.Empty
            var_time = String.Empty
        Next
        Return bSucc
    End Function

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        If mode = GBMod.Add Then
            pmethBlankVarClear()
        End If

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cbbAnnual_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbbAnnual.SelectedValueChanged
        If cbbAnnual.SelectedIndex > 0 Then
            Dim dt As New DataTable
            Dim Annual_Detail As New Cls_Annual_Detail
            Annual_Detail.annual_master = cbbAnnual.SelectedValue
            dt = Annual_Detail.Retreive()
            If Col_RegisterDetail.Count > 0 Then
                For Each cs As Object In Col_RegisterDetail
                    Dim ObjCs = CType(cs, Cls_Register_Detail)
                    ObjCs.person_data = ""
                Next
            End If
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                Dim position As New Cls_Position
                Dim dtPosition As New DataTable
                nindex = nindex + 1
                Register_Detail = New Cls_Register_Detail
                'Budget_Detail.annual_master = FrmVfield.return_annual_id
                Register_Detail.annual_detail = dt.Rows(row).Item("and_id").ToString()
                Register_Detail.seq = nindex
                Register_Detail.person_data = dt.Rows(row).Item("and_person_data").ToString()
                Register_Detail.position = dt.Rows(row).Item("and_position").ToString()
                dtPosition = position.RetreivePersonDataFromPosition(dt.Rows(row).Item("and_position").ToString(), dt.Rows(row).Item("and_person_data").ToString())
                Register_Detail.station = dtPosition.Rows(0)("s_id")
                Register_Detail.join = "N"
                Register_Detail.reg_datetime = Nothing
                Col_RegisterDetail.Add(Register_Detail)
            Next
            binddata()
        End If
    End Sub


    Private Sub binddata()
        Dim i As Integer = 0
        Dim j As Integer = 0
        lvRegister.Items.Clear()
        Try
            If Col_RegisterDetail.Count > 0 Then
                Dim position As New Cls_Position
                Dim dtPosition As New DataTable
                lvRegister.FullRowSelect = True
                lvRegister.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For Each cs As Object In Col_RegisterDetail
                    i = i + 1
                    Dim ObjCs = CType(cs, Cls_Register_Detail)
                    If ObjCs.person_data <> String.Empty Then
                        j = j + 1
                        Dim Item As New ListViewItem()
                        If ObjCs.join = "Y" Then
                            Item.Checked = True
                        ElseIf ObjCs.join = "N" Then
                            Item.Checked = False
                        End If
                        Item.SubItems.Add(ObjCs.id)
                        Item.SubItems.Add(ObjCs.register)
                        Item.SubItems.Add(i)
                        Item.SubItems.Add(j)
                        dtPosition = position.RetreivePersonDataFromPosition(ObjCs.position, ObjCs.person_data)
                        Item.SubItems.Add(dtPosition.Rows(0)("em_code"))
                        Item.SubItems.Add(dtPosition.Rows(0)("name_01") & " " & dtPosition.Rows(0)("sname_01"))
                        Item.SubItems.Add(dtPosition.Rows(0)("pname"))
                        Item.SubItems.Add(dtPosition.Rows(0)("sname"))
                        Item.SubItems.Add(ObjCs.reg_datetime.ToString("HH:mm:ss"))
                        lvRegister.Items.Add(Item)
                        lvRegister.Columns(0).DisplayIndex = 8
                        lvRegister.Columns(0).Width = 20
                        nindex = nindex + 1
                    End If

                Next

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub


    Private Sub cbbAnnual_Click(sender As System.Object, e As System.EventArgs) Handles cbbAnnual.Click
        If cbbCourse_master.SelectedValue = "0" Or String.IsNullOrEmpty(cbbCourse_master.SelectedValue) = True Then
            MessageBox.Show("ไม่พบหลักสูตรในการค้นหา", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub cbbCourse_master_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbbCourse_master.SelectedValueChanged
        Dim cbbcourse As New Cls_Annual_Master
        pmethGetcbb(cbbcourse)
    End Sub

    Private Sub cbbYear_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbbYear.SelectedValueChanged
        Dim cbbyear As New Cls_Annual_Master
        pmethGetcbb(cbbyear)
    End Sub

    Private Sub cbbEdition_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbbEdition.SelectedValueChanged
        Dim cbbedition As New Cls_Annual_Master
        pmethGetcbb(cbbedition)
    End Sub

    Private Sub pmethGetcbb(cbb As Cls_Annual_Master)
        If cbbCourse_master.SelectedValue = "0" Or String.IsNullOrEmpty(cbbCourse_master.SelectedValue) Then
            Exit Sub
        End If
        cbb.course_master = cbbCourse_master.SelectedValue
        If String.IsNullOrEmpty(cbbYear.SelectedValue) = False Then
            cbb.year = cbbYear.SelectedValue
        End If
        If cbbEdition.SelectedValue > 0 Then
            cbb.edition = cbbEdition.SelectedValue
        End If
        pmethListcbb(cbb)
    End Sub

    Private Sub pmethListcbb(cbb As Cls_Annual_Master)
        cbbAnnual.DataSource = Nothing
        cbbAnnual.Items.Clear()
        lvRegister.Items.Clear()
        Dim dt As New DataTable
        dt = cbb.RetreiveByCourseName()
        If dt.Rows.Count > 0 Then
            Me.cbbAnnual.DisplayMember = "anm_name"
            Me.cbbAnnual.ValueMember = "anm_id"
            If mode = GBMod.Add Then
                Dim dr As DataRow
                dr = dt.NewRow
                dr.Item("anm_name") = "<-- ระบุหลักสูตร -->"
                dr.Item("anm_id") = String.Empty
                dt.Rows.InsertAt(dr, 0)
            End If
            Me.cbbAnnual.DataSource = dt
            Me.cbbAnnual.SelectedIndex = 0
        Else
            MessageBox.Show("ไม่พบหลักสูตรในการค้นหา", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If mode = GBMod.Add Then
                lvRegister.Items.Clear()
            End If
            Exit Sub
        End If
    End Sub



    Private Sub lvRegister_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lvRegister.MouseClick
        ' This subroutine checks where the double-clicking was performed and
        ' initiates in-line editing if user double-clicked on the right subitem

        ' check where clicked
        CurrentItem = lvRegister.GetItemAt(e.X, e.Y)     ' which listviewitem was clicked
        If CurrentItem Is Nothing Then Exit Sub
        CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y)  ' which subitem was clicked
        ' See which column has been clicked

        ' NOTE: This portion is important. Here you can define your own
        '       rules as to which column can be edited and which cannot.
        Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
        Select Case iSubIndex
            Case 9
   
            Case 0
                If CurrentItem.Checked = True Then
                    CurrentItem.Selected = True
                    Dim Obj3 As Object = Col_RegisterDetail(Convert.ToInt16(lvRegister.SelectedItems.Item(0).SubItems(3).Text))
                    Dim ObjCs3 = CType(Obj3, Cls_Register_Detail)
                    ObjCs3.join = "N"
                    ObjCs3.reg_datetime = dtpRegister.Value
                    lvRegister.SelectedItems(0).SubItems(9).Text = ObjCs3.reg_datetime.TimeOfDay.ToString()
                Else
                    CurrentItem.Selected = True
                    Dim Obj3 As Object = Col_RegisterDetail(Convert.ToInt16(lvRegister.SelectedItems.Item(0).SubItems(3).Text))
                    Dim ObjCs3 = CType(Obj3, Cls_Register_Detail)
                    ObjCs3.join = "Y"
                    ObjCs3.reg_datetime = Convert.ToDateTime(dtpRegister.Value & " " & TimeOfDay.ToString("HH:mm:ss"))
                    lvRegister.SelectedItems(0).SubItems(9).Text = ObjCs3.reg_datetime.TimeOfDay.ToString()
                End If
                CurrentItem.Selected = False
                Exit Sub
            Case Else
                Exit Sub
        End Select

        ' Check if the first subitem is being edited
        If iSubIndex = 0 Then
            ' There's a slight coding difficulty here. If the first item is to be edited
            ' then when you get the Bounds of the first subitem, it returns the Bounds of
            ' the entire ListViewItem. Hence the Textbox looks very wierd. In order to allow
            ' editing on the first column, we use the built-in editing method.

            CurrentItem.BeginEdit()     ' make sure the LabelEdit is set to True
            Exit Sub
        End If

        Select iSubIndex
            Case 9
                CurrentItem.BeginEdit()
        Dim lLeft = CurrentSB.Bounds.Left + 2
        Dim lWidth As Integer = CurrentSB.Bounds.Width
        With timeRegister
            .SetBounds(lLeft + lvRegister.Left, CurrentSB.Bounds.Top + lvRegister.Top, lWidth, CurrentSB.Bounds.Height)
            .Text = CurrentSB.Text
            .Show()
            .Focus()
        End With
            Case Else
        End Select

    End Sub

    Private Sub timeRegister_LostFocus(sender As Object, e As System.EventArgs) Handles timeRegister.LostFocus
        Dim iSubIndex As Integer
        timeRegister.Hide()

        If bCancelEdit = False Then
            If CurrentItem.Checked = True Then
                If ((CurrentSB.Text <> "00:00:00") And (String.IsNullOrEmpty(CurrentSB.ToString()) = False)) And _
                   ((timeRegister.Text <> "00:00:00") And (String.IsNullOrEmpty(timeRegister.Text) = False)) Then
                    CurrentSB.Text = timeRegister.Text

                ElseIf ((CurrentSB.Text <> "00:00:00") And (String.IsNullOrEmpty(CurrentSB.ToString()) = False)) And _
                        ((timeRegister.Text = "00:00:00") Or (String.IsNullOrEmpty(timeRegister.Text) = True)) Then
                    'Nothing 
                ElseIf ((CurrentSB.Text = "00:00:00") Or (String.IsNullOrEmpty(CurrentSB.ToString()) = True)) And _
                    ((timeRegister.Text = "00:00:00") Or (String.IsNullOrEmpty(timeRegister.Text) = True)) Then
                    CurrentSB.Text = "00:00:00"
                End If

                iSubIndex = CurrentItem.SubItems.IndexOf(CurrentSB)
                Dim Obj2 As Object = Col_RegisterDetail(Convert.ToInt16(lvRegister.SelectedItems.Item(0).SubItems(3).Text))
                Dim ObjCs2 = CType(Obj2, Cls_Register_Detail)
                ObjCs2.join = "Y"
                If iSubIndex = "9" Then
                    If CurrentSB.Text = "00:00:00" Then
                        ObjCs2.reg_datetime = Convert.ToDateTime(dtpRegister.Value & " " & TimeOfDay.ToString("HH:mm:ss"))
                    Else
                        ObjCs2.reg_datetime = Convert.ToDateTime(dtpRegister.Value & " " & CurrentSB.Text)
                    End If

                End If

            ElseIf CurrentItem.Checked = False Then
                CurrentSB.Text = "00:00:00"
                iSubIndex = CurrentItem.SubItems.IndexOf(CurrentSB)
                Dim Obj3 As Object = Col_RegisterDetail(Convert.ToInt16(lvRegister.SelectedItems.Item(0).SubItems(3).Text))
                Dim ObjCs3 = CType(Obj3, Cls_Register_Detail)
                ObjCs3.join = "N"
                If iSubIndex = "9" Then
                    ObjCs3.reg_datetime = dtpRegister.Value
                End If
            End If
        Else
            bCancelEdit = False
        End If
        lvRegister.Focus()
    End Sub

    Private Sub BeginEditListItem(iTm As ListViewItem, SubItemIndex As Integer)
        ' This subroutine is for manually initiating editing instead of mouse double-clicks

        Dim pt As Point = iTm.SubItems(SubItemIndex).Bounds.Location
        Dim ee As New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, pt.X, pt.Y, 0)
        Call lvRegister_MouseClick(lvRegister, ee)
    End Sub


    Private Sub timeRegister_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles timeRegister.KeyDown
        ' This subroutine is for starting editing when keyboard shortcut is pressed (e.g. F2 key)

        If lvRegister.SelectedItems.Count = 0 Then Exit Sub

        Select Case e.KeyCode
            Case Keys.F2    ' F2 key is pressed. Initiate editing
                e.Handled = True
                BeginEditListItem(lvRegister.SelectedItems(0), 9)

        End Select
    End Sub

    Private Sub timeRegister_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles timeRegister.KeyPress
        Select Case e.KeyChar

            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                timeRegister.Hide()

            Case Microsoft.VisualBasic.ChrW(Keys.Escape)    ' Escape key is pressed
                bCancelEdit = True  ' editing was cancelled
                e.Handled = True
                timeRegister.Hide()

        End Select
    End Sub

    Private Sub lvRegister_ItemCheck(sender As System.Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles lvRegister.ItemCheck

    End Sub
End Class