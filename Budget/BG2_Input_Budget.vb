Public Class BG2_Input_Budget
    Public mode As String = String.Empty
    Public id As String = String.Empty
    Public FormBrow As BG1_Browse_Input_Budget
    Private BudgetBindingSource As New BindingSource
    Private Budget_Master As New Cls_Budget_Master
    Private Budget_Detail As New Cls_Budget_Detail
    Private Annaul_Master As New Cls_Annual_Master
    Private Annual_Budget As New Cls_Annual_Budget
    Private Col_BudgetDetail As New Collection
    Public BranchId As String


    Dim bCancelEdit As Boolean
    Dim CurrentSB As ListViewItem.ListViewSubItem
    Dim CurrentItem As ListViewItem




    Private Sub BG2_Input_Budget_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
    End Sub

    Public Sub pmethInit()
        pmethBindingData()
        pmethSetDataSource()
        pmethBlankVar()

    End Sub

    Private Sub pmethBindingData()
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", BudgetBindingSource, "doc_code", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpBudget.DataBindings.Add(New System.Windows.Forms.Binding("Value", BudgetBindingSource, "doc_date", True, DataSourceUpdateMode.OnPropertyChanged))
    End Sub
    Private Sub pmethSetDataSource()

    End Sub

    Private Sub pmethBlankVar()
        Budget_Master.Clear()
        Budget_Detail.clear()
        Col_BudgetDetail = New Collection
        lvBudget.Items.Clear()
        BudgetBindingSource.DataSource = Budget_Master
        txtCode.Text = String.Empty
        dtpBudget.Text = DateTime.Now.Date
        txtAnnual.Text = String.Empty
        txtPlan_avg.Text = String.Empty
        txtActual_avg.Text = String.Empty
        If mode = GBMod.Add Then
            Budget_Master.doc_code = "Autorun"
        ElseIf mode = GBMod.Edit Then
            pmethGetdata()
        End If
        pmethSetprop()
    End Sub

    Private Sub pmethBlankVarClear()
        If mode = GBMod.Add Then
            'txtCode.Text = String.Empty
            txtAnnual.Text = String.Empty
            txtPlan_avg.Text = String.Empty
            txtActual_avg.Text = String.Empty
            Budget_Master.Clear()
            Budget_Detail.clear()
            Budget_Master.doc_code = "Autorun"
            Col_BudgetDetail = New Collection
            lvBudget.Items.Clear()
        ElseIf mode = GBMod.Edit Then
            'Budget_Master.Clear()
            txtAnnual.Text = String.Empty
            txtPlan_avg.Text = String.Empty
            txtActual_avg.Text = String.Empty
            Budget_Master.annual_master = String.Empty
            Budget_Detail.clear()
            'Col_BudgetDetail = New Collection
            lvBudget.Items.Clear()
        End If
    End Sub

    Private Sub pmethSetprop()
        txtAnnual.Enabled = False
        txtPlan_avg.Enabled = False
        txtActual_avg.Enabled = False
        txtCode.Enabled = False
        If mode = GBMod.Edit Then
            btnClear.Enabled = False
            btnPopAnnual.Enabled = False
        End If
    End Sub

    Private Sub pmethGetdata()
        Budget_Master.id = Me.id
        Budget_Master.getById(Me.id)
        If String.IsNullOrEmpty(Budget_Master.annual_master) = False Then
            Me.txtAnnual.Text = New Cls_Annual_Master(Budget_Master.annual_master.ToString()).doc_code & "-" & _
                New Cls_HD_Course(New Cls_Course_Master(New Cls_Annual_Master(Budget_Master.annual_master.ToString()).course_master).course).name
        End If
        Me.pmethLoadItem()

    End Sub

    Private Sub pmethLoadItem()
        Col_BudgetDetail = Budget_Master.Item_BudgetDetail
        binddata()
    End Sub

    Private Sub binddata()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim l As Integer = 0
        lvBudget.Items.Clear()
        Try
            If Col_BudgetDetail.Count > 0 Then
                lvBudget.FullRowSelect = True
                lvBudget.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For Each cs As Object In Col_BudgetDetail
                    i = i + 1
                    Dim ObjCs = CType(cs, Cls_Budget_Detail)
                    If ObjCs.plan_cost <> String.Empty Then
                        j = j + 1
                        Dim Item As New ListViewItem(ObjCs.id)
                        Item.SubItems.Add(ObjCs.annual_budget)
                        Item.SubItems.Add(i)
                        Item.SubItems.Add(j)
                        Item.SubItems.Add(New Cls_HD_Cost(ObjCs.plan_cost).code.ToString())
                        Item.SubItems.Add(New Cls_HD_Cost(ObjCs.plan_cost).name.ToString())
                        Item.SubItems.Add(ObjCs.plan_rate)
                        Item.SubItems.Add(ObjCs.plan_qty_people)
                        Item.SubItems.Add(ObjCs.plan_amt_money)
                        Item.SubItems.Add(ObjCs.actual_rate)
                        Item.SubItems.Add(ObjCs.actual_qty_people)
                        'If ((ObjCs.actual_rate <> 0) And (ObjCs.actual_qty_people <> 0)) Then
                        ObjCs.actual_amt_money = ObjCs.actual_rate * ObjCs.actual_qty_people
                        Item.SubItems.Add(ObjCs.actual_amt_money)
                        'Else
                        '    Item.SubItems.Add(ObjCs.actual_amt_money)
                        'End If
                        lvBudget.Items.Add(Item)
                        k = k + ObjCs.plan_amt_money
                        l = l + ObjCs.actual_amt_money
                        nindex = nindex + 1
                    End If
                    txtPlan_avg.Text = Convert.ToString(k / New Cls_Annual_Master(Budget_Master.annual_master).qty)
                    txtActual_avg.Text = Convert.ToString(l / New Cls_Annual_Master(Budget_Master.annual_master).qty)
                Next
            Else
                txtPlan_avg.Text = "0"
                txtActual_avg.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub
    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If String.IsNullOrEmpty(txtAnnual.Text) = True Then
            strErrmsg = "กรุณาระบุแผนพัฒนาประจำปี"
            bSucc = False
        ElseIf lvBudget.Items.Count = 0 Then
            strErrmsg = "กรุณาระบุแผนพัฒนาประจำปี"
            bSucc = False
        ElseIf Col_BudgetDetail.Count = 0 Then
            strErrmsg = "กรุณาระบุแผนพัฒนาประจำปี"
            bSucc = False
        ElseIf Me.pmethItemOK() = False Then
            strErrmsg = "ไม่พบรายการค่าใช้จ่าย"
            bSucc = False
            'ElseIf Me.pmethActual_RateOK() = False Then
            '    strErrmsg = "กรุณาบันทึกค่าใช้จ่ายจริงให้ถูกต้อง"
            '    bSucc = False
            'ElseIf Me.pmethActual_Qty_People() = False Then
            '    strErrmsg = "กรุณาบันทึกค่าใช้จ่ายจริงให้ถูกต้อง"
            '    bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        pmethBlankVarClear()
    End Sub

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
                    Budget_Master.doc_code = FunctionClass.GetDocumentNo("Input_Budget", {}, "", GBCorp, GBAppName, GBApp_Path, Errmsg)
                    Budget_Master.Branch_id = Me.BranchId
                    Annaul_Master = New Cls_Annual_Master
                    Annaul_Master.id = Budget_Master.annual_master
                    Annaul_Master.paystep = Config.Anm_Pay_Step_Pay
                    If Budget_Master.Add(SqlDB) = False Then
                        strErrmsg = Budget_Master.message
                        bSucc = False
                    End If
                    If Annaul_Master.UpdateFrom_Budget(SqlDB) = False Then
                        strErrmsg = Annaul_Master.message
                        bSucc = False
                    End If
                ElseIf mode = GBMod.Edit Then
                    If Budget_Master.Update(SqlDB) = False Then
                        strErrmsg = Budget_Master.message
                        bSucc = False
                    End If
                End If
                If bSucc Then
                    Me.pmethSaveBudgetDetail(SqlDB, strErrmsg)
                End If

                If bSucc = True Then
                    SqlDB.CommitTrans()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    pmethBlankVar()
                    If mode = GBMod.Edit Then
                        Close()
                    Else
                        Budget_Master.doc_code = "Autorun"
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

    Private Function pmethSaveBudgetDetail(SqlDB As Cls_SqlDB, strErrmsg As String) As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer
        For Each ObjCs As Cls_Budget_Detail In Col_BudgetDetail
            If ObjCs.plan_cost <> String.Empty Then
                i = i + 1
                ObjCs.Corp_id = GBCorp
                ObjCs.budget_master = Budget_Master.id
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
        Next
        Return bSucc
    End Function

    Private Function pmethItemOK() As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer = 0
        Dim j As Integer = 0
        For Each cs As Object In Col_BudgetDetail
            Dim ObjCs = CType(cs, Cls_Budget_Detail)
            If ObjCs.plan_cost <> String.Empty Then
                i = i + 1
            End If
        Next
        If i = 0 Then
            bSucc = False
        End If
        Return bSucc
    End Function


    Private Function pmethActual_RateOK() As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer = 0
        Dim j As Integer = 0
        For Each cs As Object In Col_BudgetDetail
            Dim ObjCs = CType(cs, Cls_Budget_Detail)
            If ObjCs.plan_cost <> String.Empty Then
                If ObjCs.actual_rate <= 0 Then
                    bSucc = False
                    Exit For
                End If
            End If
        Next
        Return bSucc
    End Function


    Private Function pmethActual_Qty_People() As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer = 0
        Dim j As Integer = 0
        For Each cs As Object In Col_BudgetDetail
            Dim ObjCs = CType(cs, Cls_Budget_Detail)
            If ObjCs.plan_cost <> String.Empty Then
                If ObjCs.actual_qty_people <= 0 Then
                    bSucc = False
                    Exit For
                End If
            End If
        Next
        Return bSucc
    End Function

    Private Sub btnPopAnnual_Click(sender As System.Object, e As System.EventArgs) Handles btnPopAnnual.Click
        Dim FrmVfield As New Select_Annual
        Dim strErrmsg As String = String.Empty
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.return_annual_id) = False Then
            Me.txtAnnual.Text = FrmVfield.return_annual_code & "-" & FrmVfield.return_annual_course_master_name
            Me.txtAnnual.Tag = FrmVfield.return_annual_id
            'If Budget_Master.annual_master = FrmVfield.return_annual_id Then
            '    For Each obj As Object In Col_BudgetDetail
            '        Dim ObjCs1 = CType(obj, Cls_Budget_Detail)
            '        If FrmVfield.return_annual_id = ObjCs1.annual_master And String.IsNullOrEmpty(ObjCs1.plan_cost) = True Then
            '            ObjCs1.plan_cost = New Cls_Annual_Budget(ObjCs1.annual_budget.ToString()).cost
            '        End If
            '    Next
            '    binddata()
            '    Exit Sub
            'End If
            If Col_BudgetDetail.Count > 0 Then
                For Each cs As Object In Col_BudgetDetail
                    Dim ObjCs2 = CType(cs, Cls_Budget_Detail)
                    ObjCs2.plan_cost = ""
                Next
            End If
            Budget_Master.annual_master = FrmVfield.return_annual_id
            Dim dt As New DataTable
            Annual_Budget = New Cls_Annual_Budget
            Annual_Budget.annual_master = FrmVfield.return_annual_id
            dt = Annual_Budget.Retreive()
            Dim nindex As Integer = 0
            For row As Integer = 0 To dt.Rows.Count - 1
                nindex = nindex + 1
                Budget_Detail = New Cls_Budget_Detail
                'Budget_Detail.annual_master = FrmVfield.return_annual_id
                Budget_Detail.annual_budget = dt.Rows(row).Item("anb_id").ToString()
                Budget_Detail.seq = nindex
                Budget_Detail.plan_cost = dt.Rows(row).Item("anb_cost").ToString()
                Budget_Detail.plan_qty_people = dt.Rows(row).Item("anb_qty_people")
                Budget_Detail.plan_rate = dt.Rows(row).Item("anb_rate")
                Budget_Detail.plan_amt_money = dt.Rows(row).Item("anb_amt_money")
                Budget_Detail.actual_qty_people = dt.Rows(row).Item("anb_qty_people")
                Budget_Detail.actual_rate = dt.Rows(row).Item("anb_rate")
                Budget_Detail.actual_amt_money = dt.Rows(row).Item("anb_qty_people") * dt.Rows(row).Item("anb_rate")
                Col_BudgetDetail.Add(Budget_Detail)
            Next
            binddata()
        End If
    End Sub

    
    Private Sub CalculateAverage()
        Dim i As Integer
        For Each iTm As ListViewItem In lvBudget.Items

            Dim Actual_Rate As Integer = iTm.SubItems(9).Text
            Dim Actual_Qty_People As Integer = iTm.SubItems(10).Text
            Dim Average As Decimal = Actual_Rate * Actual_Qty_People

            iTm.SubItems(11).Text = Average.ToString("#,###0.00")
            i = i + Average
        Next
        txtActual_avg.Text = Convert.ToString(i / New Cls_Annual_Master(Budget_Master.annual_master).qty)
    End Sub
    


    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_edit_cost.KeyPress
        ' This subroutine closes the text box

        Select Case e.KeyChar

            Case Microsoft.VisualBasic.ChrW(Keys.Return)    ' Enter key is pressed
                bCancelEdit = False ' editing completed
                e.Handled = True
                txt_edit_cost.Hide()

            Case Microsoft.VisualBasic.ChrW(Keys.Escape)    ' Escape key is pressed
                bCancelEdit = True  ' editing was cancelled
                e.Handled = True
                txt_edit_cost.Hide()

        End Select
    End Sub

    Private Sub lvBudget_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lvBudget.MouseClick
        ' This subroutine checks where the double-clicking was performed and
        ' initiates in-line editing if user double-clicked on the right subitem

        ' check where clicked
        CurrentItem = lvBudget.GetItemAt(e.X, e.Y)     ' which listviewitem was clicked
        If CurrentItem Is Nothing Then Exit Sub
        CurrentSB = CurrentItem.GetSubItemAt(e.X, e.Y)  ' which subitem was clicked

        ' See which column has been clicked

        ' NOTE: This portion is important. Here you can define your own
        '       rules as to which column can be edited and which cannot.
        Dim iSubIndex As Integer = CurrentItem.SubItems.IndexOf(CurrentSB)
        Select Case iSubIndex
            Case 9, 10
                ' These two columns are allowed to be edited. So continue the code
            Case Else
                ' In my example I have defined that only "Runs" and "Wickets" columns can be edited by user
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

        Dim lLeft = CurrentSB.Bounds.Left + 2
        Dim lWidth As Integer = CurrentSB.Bounds.Width
        With txt_edit_cost
            .SetBounds(lLeft + lvBudget.Left, CurrentSB.Bounds.Top + lvBudget.Top, lWidth, CurrentSB.Bounds.Height)
            .Text = CurrentSB.Text
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub lvBudget_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles lvBudget.KeyDown
        ' This subroutine is for starting editing when keyboard shortcut is pressed (e.g. F2 key)

        If lvBudget.SelectedItems.Count = 0 Then Exit Sub

        Select Case e.KeyCode
            Case Keys.F2    ' F2 key is pressed. Initiate editing
                e.Handled = True
                BeginEditListItem(lvBudget.SelectedItems(0), 9)

        End Select
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles txt_edit_cost.LostFocus
        Dim iSubIndex As Integer
        txt_edit_cost.Hide()

        If bCancelEdit = False Then

            If txt_edit_cost.Text.Trim <> "" Then

                ' NOTE: You can define your validation rules here. In my example I've
                '       set that only numbers can be entered in "Runs" and "Wickets" column

                ' Validate
                If IsNumeric(txt_edit_cost.Text) = False Then
                    MsgBox("กรุณาระบบข้อมูลเป็นตัวเลข", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                ' update listviewitem


                CurrentSB.Text = CInt(txt_edit_cost.Text).ToString("#,###0.00")

                ' save changes so that next time you load this XML document the changes are there.
                iSubIndex = CurrentItem.SubItems.IndexOf(CurrentSB)
                'Dim szPropertyName As String
                'If iSubIndex = 2 Then
                '    szPropertyName = "Runs"
                'Else
                '    szPropertyName = "Wickets"
                'End If
                'SaveXMLChanges(CurrentItem.Text, szPropertyName, CurrentSB.Text)

                ' Recalculate last column
                Dim Obj As Object = Col_BudgetDetail(Convert.ToInt16(lvBudget.SelectedItems.Item(0).SubItems(2).Text))
                Dim ObjCs = CType(Obj, Cls_Budget_Detail)
                If iSubIndex = "9" Then
                    ObjCs.actual_rate = CurrentSB.Text
                ElseIf iSubIndex = "10" Then
                    ObjCs.actual_qty_people = CurrentSB.Text
                End If
                'If ((ObjCs.actual_rate <> 0) And (ObjCs.actual_qty_people <> 0)) Then
                    ObjCs.actual_amt_money = ObjCs.actual_rate * ObjCs.actual_qty_people
                'End If

                CalculateAverage()
            End If

        Else

            ' Editing was cancelled by user
            bCancelEdit = False

        End If
        'binddata()
        lvBudget.Focus()
    End Sub

    Private Sub BeginEditListItem(iTm As ListViewItem, SubItemIndex As Integer)
        ' This subroutine is for manually initiating editing instead of mouse double-clicks

        Dim pt As Point = iTm.SubItems(SubItemIndex).Bounds.Location
        Dim ee As New System.Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, pt.X, pt.Y, 0)
        Call lvBudget_MouseClick(lvBudget, ee)
    End Sub
End Class