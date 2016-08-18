Public Class ADD_Edit_Annual_Position
    Dim ConfigValue As SortedList
    Dim App_Name As String = ""
    Dim App_Path As String = ""
    Dim User_Session As String = ""
    Dim UserID As String = ""
    Public Corp_id, branch_id, strAction, log_id As String
    Dim Login_Session As String = ""
    Dim Lang_Index As Integer
    Dim culture As String
    Dim loginnm, CorpName1, CorpName2 As String
    Public BranchId As String

    Dim MsgBoxDB As New messageboxsystem.MsgBox.cls_msg
    Dim staff_condition, adjust_rate As String
    Public stryear, str_branch_id As String
    Public clsTB_Position As New Database.Table.select_data
    Dim dt_person As DataTable
    Public Flag_ActionOK As Boolean
    Dim Encode As New LionEncript.LionEncript




    Public mode As String = String.Empty
    Public budgetMod As String = GBMod.Add
    Public id As String = String.Empty
    Public FormBrow As ADD_Edit_Annual_Position_Browse
    Dim stateCourse As Boolean = False
    Dim statePosition As Boolean = False
    Dim stateRoadmap As Boolean = False
    Private Annual_Master As New Cls_Annual_Master
    Private Annual_Detail As New Cls_Annual_Detail
    Private Annual_Budget As New Cls_Annual_Budget
    Private Col_AnnualDetail As New Collection
    Private Col_AnnualBudget As New Collection
    Private AnnualBindingSource As New BindingSource


#Region "Set Confic"
    Public Property Config As SortedList
        Get
            Return ConfigValue
        End Get
        Set(ByVal value As SortedList)
            ConfigValue = value
            App_Path = ConfigValue.Item("Application Path")
            App_Name = ConfigValue.Item("Application Name")
            User_Session = ConfigValue.Item("User Session")
            Lang_Index = CInt(ConfigValue.Item("Language Index"))
            loginnm = ConfigValue("Username")
            CorpName1 = ConfigValue.Item("Corporate Name 1")
            CorpName2 = ConfigValue.Item("Corporate Name 2")
            UserID = ConfigValue.Item("User ID")
            Login_Session = ConfigValue.Item("Login Session")
            culture = ConfigValue.Item("Corporate Culture")
            Corp_id = ConfigValue("Corporate ID")
        End Set
    End Property
#End Region


#Region "Load"
    Private Sub ADD_Edit_Annual_Position_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & "(" & Me.Name.ToString() & ")"
    End Sub

#End Region

#Region "Initial Data"

    Public Sub pmethInit()
        pmethBindingData()
        pmethSetDataSource()
        pmethBlankVar()

        If mode = GBMod.Add Then
            Annual_Master.doc_code = "Autorun"
        ElseIf mode = GBMod.Edit Then
            pmethGetdata()
        End If
        pmethSetprop()
    End Sub

#End Region

#Region "BinddingData"
    Private Sub pmethBindingData()
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", AnnualBindingSource, "doc_code", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpAnnual.DataBindings.Add(New System.Windows.Forms.Binding("Value", AnnualBindingSource, "doc_date", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtMain_hour.DataBindings.Add(New System.Windows.Forms.Binding("Text", AnnualBindingSource, "main_hour", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtYear.DataBindings.Add(New System.Windows.Forms.Binding("Text", AnnualBindingSource, "year", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtEdition.DataBindings.Add(New System.Windows.Forms.Binding("Text", AnnualBindingSource, "edition", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", AnnualBindingSource, "qty", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpBegdate.DataBindings.Add(New System.Windows.Forms.Binding("Value", AnnualBindingSource, "begdate", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.dtpEnddate.DataBindings.Add(New System.Windows.Forms.Binding("Value", AnnualBindingSource, "enddate", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtBegtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", AnnualBindingSource, "begtime", True, DataSourceUpdateMode.OnPropertyChanged))
        Me.txtEndtime.DataBindings.Add(New System.Windows.Forms.Binding("Text", AnnualBindingSource, "endtime", True, DataSourceUpdateMode.OnPropertyChanged))
    End Sub

#End Region

#Region "EditData Mode & Collection"
    Private Sub pmethGetdata()
        Annual_Master.id = Me.id
        Annual_Master.getById(Me.id)
        If String.IsNullOrEmpty(Annual_Master.course_master) = False Then
            Me.txtSelected_course.Text = Annual_Master.expcourse.code.ToString() & "-" & Annual_Master.expcourse.name.ToString()
        End If
        If String.IsNullOrEmpty(Annual_Master.position) = False Then
            Me.txtSelected_position.Text = Annual_Master.expposition.code.ToString() & "-" & Annual_Master.expposition.name.ToString()
        End If
        If String.IsNullOrEmpty(Annual_Master.roadmap) = False Then
            Me.txtSelected_roadmap.Text = Annual_Master.exproammap.docCode.ToString() & "-" & Annual_Master.expcourse.name.ToString()
        End If
        If String.IsNullOrEmpty(Annual_Master.place) = False Then
            Me.txtPlace.Text = Annual_Master.expplace.name
        End If

        Me.pmethLoadItem()

    End Sub

    Private Sub pmethLoadItem()
        Col_AnnualDetail = Annual_Master.Item_AnnualDetail
        binddataTarget()
        Col_AnnualBudget = Annual_Master.Item_AnnualBudget
        pmethBindingDataBudget()
    End Sub

#End Region

#Region "Set Property & DataSource"
    Private Sub pmethSetDataSource()
        Dim dtCost As DataTable
        Dim Cost As New Cls_HD_Cost
        dtCost = Cost.Retreive()
        Me.cbbBudget.DisplayMember = "hdc_name"
        Me.cbbBudget.ValueMember = "hdc_id"
        Me.cbbBudget.DataSource = dtCost
    End Sub

    Private Sub pmethSetprop()
        txtCode.Enabled = False
        txtSelected_course.Enabled = False
        txtSelected_position.Enabled = False
        txtSelected_roadmap.Enabled = False
        txtPlace.Enabled = False
    End Sub

#End Region

#Region "BlankVar"
    Private Sub pmethBlankVar()
        Annual_Master.Clear()
        Annual_Detail.clear()
        Annual_Budget.clear()
        Col_AnnualDetail = New Collection
        Col_AnnualBudget = New Collection
        lvTarget.Items.Clear()
        lvBudget.Items.Clear()
        AnnualBindingSource.DataSource = Annual_Master
        txtCode.Text = String.Empty
        dtpAnnual.Text = DateTime.Now.Date
        txtSelected_course.Text = String.Empty
        txtSelected_position.Text = String.Empty
        txtSelected_roadmap.Text = String.Empty
        txtSelected_idp.Text = String.Empty
        txtMain_hour.Text = String.Empty
        txtYear.Text = String.Empty
        txtEdition.Text = String.Empty
        txtQty.Text = String.Empty
        dtpBegdate.Text = DateTime.Now.Date
        dtpEnddate.Text = DateTime.Now.Date
        txtPlace.Text = String.Empty
        txtBegtime.Text = String.Empty
        txtEndtime.Text = String.Empty
        pmethBlankVarBudget()
    End Sub

    Private Sub pmethBlankVarBudget()
        txtQty_people.Text = String.Empty
        txtRate.Text = String.Empty
        txtAmt_money.Text = String.Empty
    End Sub

    Private Sub pmethBlankVarCourse()
        txtSelected_course.Text = String.Empty
        stateCourse = False
    End Sub

    Private Sub pmethBlankVarPosition()
        txtSelected_position.Text = String.Empty
        statePosition = False
    End Sub

    Private Sub pmethBlankVarRoadmap()
        txtSelected_roadmap.Text = String.Empty
        stateRoadmap = False
    End Sub

#End Region

#Region "Validate Data"
    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If String.IsNullOrEmpty(txtMain_hour.Text) = True Then
            strErrmsg = "กรุณาระบุระยะเวลาพัฒนา"
            bSucc = False
            txtMain_hour.Focus()
        ElseIf IsNumeric(txtMain_hour.Text) = False Then
            strErrmsg = "กรุณาระบุระยะเวลาพัฒนาเป็นตัวเลข"
            bSucc = False
            txtMain_hour.Focus()
        ElseIf Convert.ToDecimal(txtMain_hour.Text) <= 0 Then
            strErrmsg = "กรุณาระบุระยะเวลาพัฒนามีค่ามากกว่า 0"
            bSucc = False
            txtMain_hour.Focus()
        ElseIf String.IsNullOrEmpty(txtYear.Text) = True Then
            strErrmsg = "กรุณาระบุปีที่"
            bSucc = False
            txtYear.Focus()
        ElseIf String.IsNullOrEmpty(txtEdition.Text) = True Then
            strErrmsg = "กรุณาระบุรุ่นที่"
            bSucc = False
            txtEdition.Focus()
        ElseIf IsNumeric(txtEdition.Text) = False Then
            strErrmsg = "กรุณาระบุรุ่นที่เป็นตัวเลข"
            bSucc = False
            txtEdition.Focus()
        ElseIf Convert.ToInt32(txtEdition.Text) <= 0 Then
            strErrmsg = "กรุณาระบุรุ่นที่มีค่ามากกว่า 0"
            bSucc = False
            txtEdition.Focus()
        ElseIf String.IsNullOrEmpty(txtQty.Text) = True Then
            strErrmsg = "กรุณาระบุจำนวนคน"
            bSucc = False
            txtQty.Focus()
        ElseIf IsNumeric(txtQty.Text) = False Then
            strErrmsg = "กรุณาระบุจำนวนคนเป็นตัวเลข"
            bSucc = False
            txtQty.Focus()
        ElseIf Convert.ToInt32(txtQty.Text) <= 0 Then
            strErrmsg = "กรุณาระบุจำนวนคนมีค่ามากกว่า 0"
            bSucc = False
            txtQty.Focus()
        ElseIf String.IsNullOrEmpty(txtPlace.Text) = True Then
            strErrmsg = "กรุณาระบุสถานที่"
            bSucc = False
            txtPlace.Focus()
            'ElseIf String.IsNullOrEmpty(txtBegtime.Text) = True Then
            '    strErrmsg = "กรุณาระบุเวลาเริ่มต้น"
            '    bSucc = False
            '    txtBegtime.Focus()
            'ElseIf IsNumeric(txtBegtime.Text) = False Then
            '    strErrmsg = "กรุณาระบุเวลาเริ่มต้นเป็นตัวเลข"
            '    bSucc = False
            '    txtBegtime.Focus()
            'ElseIf Convert.ToDecimal(txtBegtime.Text) <= 0 Then
            '    strErrmsg = "กรุณาระบุเวลาเริ่มต้นเป็นตัวเลขมีค่ามากกว่า 0"
            '    bSucc = False
            '    txtBegtime.Focus()
            'ElseIf String.IsNullOrEmpty(txtEndtime.Text) = True Then
            '    strErrmsg = "กรุณาระบุเวลาสิ้นสุด"
            '    bSucc = False
            '    txtEndtime.Focus()
            'ElseIf IsNumeric(txtEndtime.Text) = False Then
            '    strErrmsg = "กรุณาระบุเวลาสิ้นสุดเป็นตัวเลข"
            '    bSucc = False
            '    txtEndtime.Focus()
            'ElseIf Convert.ToDecimal(txtEndtime.Text) <= 0 Then
            '    strErrmsg = "กรุณาระบุเวลาสิ้นสุดมากกว่า 0"
            '    bSucc = False
            '    txtEndtime.Focus()
        ElseIf lvTarget.Items.Count <= 0 Then
            strErrmsg = "กรุณาระบุกลุ่มเป้าหมาย"
            bSucc = False
        ElseIf lvBudget.Items.Count <= 0 Then
            strErrmsg = "กรุณาระบุงบประมาณ"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Function ValidateDataBudget() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If cbbBudget.ValueMember = String.Empty Then
            strErrmsg = "กรุณาระบุค่าใช้จ่าย"
            bSucc = False
            cbbBudget.Focus()
        ElseIf String.IsNullOrEmpty(txtQty_people.Text) = True Then
            strErrmsg = "กรุณาระบุจำนวนคน"
            bSucc = False
            txtQty_people.Focus()
        ElseIf IsNumeric(txtQty_people.Text) = False Then
            strErrmsg = "กรุณาระบุจำนวนคนเป็นตัวเลข"
            bSucc = False
            txtQty_people.Focus()
        ElseIf Convert.ToInt32(txtQty_people.Text) <= 0 Then
            strErrmsg = "กรุณาระบุจำนวนคนมากกว่า 0"
            bSucc = False
            txtQty_people.Focus()
        ElseIf String.IsNullOrEmpty(txtRate.Text) = True Then
            strErrmsg = "กรุณาระบุอัตรา"
            bSucc = False
            txtRate.Focus()
        ElseIf IsNumeric(txtRate.Text) = False Then
            strErrmsg = "กรุณาระบุอัตราเป็นตัวเลข"
            bSucc = False
            txtRate.Focus()
        ElseIf Convert.ToDouble(txtRate.Text) <= 0 Then
            strErrmsg = "กรุณาระบุอัตรามากกว่า 0"
            bSucc = False
            txtRate.Focus()
        ElseIf String.IsNullOrEmpty(txtAmt_money.Text) = True Then
            strErrmsg = "กรุณาระบุจำนวนเงิน"
            bSucc = False
            txtAmt_money.Focus()
        ElseIf IsNumeric(txtAmt_money.Text) = False Then
            strErrmsg = "กรุณาระบุจำนวนเงินเป็นตัวเลข"
            bSucc = False
            txtAmt_money.Focus()
        ElseIf Convert.ToDouble(txtAmt_money.Text) <= 0 Then
            strErrmsg = "กรุณาระบุจำนวนเงินมากกว่า 0"
            bSucc = False
            txtAmt_money.Focus()
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

#End Region

#Region "Function"

#Region "Main Function"
    Private Sub btnClear_Ann_Click(sender As System.Object, e As System.EventArgs) Handles btnClear_Ann.Click

    End Sub

    Private Sub btnClose_Ann_Click(sender As System.Object, e As System.EventArgs) Handles btnClose_Ann.Click
        Me.Close()
    End Sub
#End Region

#Region "Save Function"
    Private Sub btnSave_Ann_Click(sender As System.Object, e As System.EventArgs) Handles btnSave_Ann.Click
        Dim SqlDB As New Cls_SqlDB
        Dim bSucc = True
        Dim strErrmsg As String = String.Empty
        Dim Errmsg As String = String.Empty
        Try
            If ValidateData() = True Then
                SqlDB.BeginTrans()
                If mode = GBMod.Add Then
                    Annual_Master.doc_code = FunctionClass.GetDocumentNo("annual_master", {}, "", GBCorp, GBAppName, GBApp_Path, Errmsg)
                    Annual_Master.getstep = Human_Development.Config.Anm_Step_Create
                    Annual_Master.paystep = Human_Development.Config.Anm_Pay_Step_NonPay
                    Annual_Master.Branch_id = Me.branch_id
                    If Annual_Master.Add(SqlDB) = False Then
                        strErrmsg = Annual_Master.message
                        bSucc = False
                    End If
                ElseIf mode = GBMod.Edit Then
                    If Annual_Master.Update(SqlDB) = False Then
                        strErrmsg = Annual_Master.message
                        bSucc = False
                    End If
                End If
                If bSucc Then
                    bSucc = Me.pmethSaveAnualDetail(SqlDB, strErrmsg)
                End If
                If bSucc Then
                    bSucc = Me.pmethSaveAnualBudget(SqlDB, strErrmsg)
                End If
                If bSucc = True Then
                    SqlDB.CommitTrans()
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    pmethBlankVar()
                    If mode = GBMod.Edit Then
                        Close()
                    Else
                        Annual_Master.doc_code = "Autorun"
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

    Private Function pmethSaveAnualDetail(SqlDB As Cls_SqlDB, strErrmsg As String) As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer
        For Each ObjCs As Cls_Annual_Detail In Col_AnnualDetail
            If ObjCs.person_data <> String.Empty Then
                i = i + 1
                ObjCs.Corp_id = GBCorp
                ObjCs.annual_master = Annual_Master.id
                ObjCs.Branch_id = Me.branch_id
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

    Private Function pmethSaveAnualBudget(SqlDB As Cls_SqlDB, strErrmsg As String) As Boolean
        Dim bSucc As Boolean = True
        Dim i As Integer
        For Each ObjCs As Cls_Annual_Budget In Col_AnnualBudget
            If ObjCs.cost <> String.Empty Then
                i = i + 1
                ObjCs.Corp_id = GBCorp
                ObjCs.annual_master = Annual_Master.id
                ObjCs.Branch_id = Me.branch_id
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

#End Region

#Region "Browser Course Position Roadmap"
    Private Sub btnSelected_course_Click(sender As System.Object, e As System.EventArgs) Handles btnSelected_course.Click
        Dim FrmVfield As New Select_Course
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.return_course_master_id) = False Then
            pmethBlankVarPosition()
            pmethBlankVarRoadmap()
            Me.txtSelected_course.Text = FrmVfield.return_course_code & "-" & FrmVfield.return_course_name
            Me.txtSelected_course.Tag = FrmVfield.return_course_master_id
            Me.Annual_Master.course_master = FrmVfield.return_course_master_id
            stateCourse = True
        End If
    End Sub

    Private Sub btnSelected_Position_Click(sender As System.Object, e As System.EventArgs) Handles btnSelected_Position.Click
        'Dim dt As New DataTable
        'Dim FrmVfield As New Select_Position
        'FrmVfield.ShowDialog()
        'If FrmVfield.DialogResult = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
        '    pmethBlankVarRoadmap()
        '    If String.IsNullOrEmpty(txtSelected_course.Text) = True Then
        '        MessageBox.Show("กรุณาระบุหลักสูตร", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If
        '    Me.txtSelected_position.Text = FrmVfield.Retrun_Code & "-" & FrmVfield.Retrun_Name
        '    Me.Annual_Master.position = FrmVfield.Retrun_id
        '    dt = FrmVfield.RetreivePersonData(FrmVfield.Retrun_id)
        '    If dt.Rows.Count > 0 Then
        '        Dim nindex As Integer = 0
        '        For row As Integer = 0 To dt.Rows.Count - 1
        '            If pmethCheckNotHavePerson(dt.Rows(row).Item("pd_id").ToString()) Then
        '                Dim ObjAnd As New Cls_Annual_Detail
        '                ObjAnd.Corp_id = GBCorp
        '                ObjAnd.person_data = dt.Rows(row).Item("pd_id").ToString()
        '                ObjAnd.position = FrmVfield.Retrun_id
        '                Col_AnnualDetail.Add(ObjAnd)
        '            End If
        '        Next
        '        binddataTarget()
        '    Else
        '        MessageBox.Show("ไม่พบบุคลากรในตำแหน่งนี้", "Information :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If

        'End If

        Dim dt As New DataTable
        Dim Str_date As String = Utility.Convert_Culture(Date.Today.ToString("dd/MM/yyyy"), "en-US")
        Dim frm As New staff_searching
        With frm
            .Config = Human_Development.ConfigValue
            frm.Name = "staff_searching"
            Dim Fclass As New FormActionClass.FormClass
            Fclass.LoadFormLang(frm, frm.Name, Human_Development.ConfigValue, "")
            .ShowDialog(Me)
            If .Flag_ActionOK = True Then
                staff_condition = .str_condition
                str_branch_id = .str_sent_branch
                dt = clsTB_Position.dsListPerson_salary(GBCorp, frm.str_sent_branch, staff_condition, Str_date, "").Tables(0)
                pmethBlankVarRoadmap()
                If String.IsNullOrEmpty(txtSelected_course.Text) = True Then
                    MessageBox.Show("กรุณาระบุหลักสูตร", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Me.txtSelected_position.Text = frm.strName
                If dt.Rows.Count > 0 Then
                    Dim nindex As Integer = 0
                    For row As Integer = 0 To dt.Rows.Count - 1
                        If pmethCheckNotHavePerson(dt.Rows(row).Item("person_id").ToString()) Then
                            Dim ObjAnd As New Cls_Annual_Detail
                            ObjAnd.Corp_id = GBCorp
                            ObjAnd.person_data = dt.Rows(row).Item("person_id").ToString()
                            ObjAnd.position = dt.Rows(row).Item("position_id").ToString()
                            Col_AnnualDetail.Add(ObjAnd)
                        End If
                    Next
                    binddataTarget()
                Else
                    MessageBox.Show("ไม่พบบุคลากรในตำแหน่งนี้", "Information :", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End With

        'If FrmVfield.DialogResult = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Retrun_id) = False Then
        '    pmethBlankVarRoadmap()
        '    If String.IsNullOrEmpty(txtSelected_course.Text) = True Then
        '        MessageBox.Show("กรุณาระบุหลักสูตร", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If
        '    Me.txtSelected_position.Text = FrmVfield.Retrun_Code & "-" & FrmVfield.Retrun_Name
        '    Me.Annual_Master.position = FrmVfield.Retrun_id
        '    dt = FrmVfield.RetreivePersonData(FrmVfield.Retrun_id)
        '    If dt.Rows.Count > 0 Then
        '        Dim nindex As Integer = 0
        '        For row As Integer = 0 To dt.Rows.Count - 1
        '            If pmethCheckNotHavePerson(dt.Rows(row).Item("pd_id").ToString()) Then
        '                Dim ObjAnd As New Cls_Annual_Detail
        '                ObjAnd.Corp_id = GBCorp
        '                ObjAnd.person_data = dt.Rows(row).Item("pd_id").ToString()
        '                ObjAnd.position = FrmVfield.Retrun_id
        '                Col_AnnualDetail.Add(ObjAnd)
        '            End If
        '        Next
        '        binddataTarget()
        '    Else
        '        MessageBox.Show("ไม่พบบุคลากรในตำแหน่งนี้", "Information :", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If

        'End If

    End Sub

    Private Sub btnSelected_roadmap_Click(sender As System.Object, e As System.EventArgs) Handles btnSelected_roadmap.Click
        Dim dt As New DataTable
        Dim FrmVfield As New Select_Roadmap
        FrmVfield.Get_Course_Master_Id = Me.Annual_Master.course_master
        FrmVfield.Get_Position_Id = Me.Annual_Master.position
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.Return_Roadmap_Id) = False Then
            Me.txtSelected_roadmap.Text = FrmVfield.Return_Roapmap_DocCode & "-" & FrmVfield.Return_Name
            Me.txtSelected_roadmap.Tag = FrmVfield.Return_Roadmap_Id
            Me.Annual_Master.course_master = FrmVfield.Return_Roadmap_Course_Master
            Me.Annual_Master.position = FrmVfield.Return_Roadmap_Position
            Me.Annual_Master.roadmap = FrmVfield.Return_Roadmap_Id
            dt = FrmVfield.RetreivePersonData(FrmVfield.Return_Roadmap_Position)
            If dt.Rows.Count > 0 Then
                Dim nindex As Integer = 0
                For row As Integer = 0 To dt.Rows.Count - 1
                    If pmethCheckNotHavePerson(dt.Rows(row).Item("pd_id").ToString()) Then
                        Dim ObjAnd As New Cls_Annual_Detail
                        ObjAnd.Corp_id = GBCorp
                        ObjAnd.person_data = dt.Rows(row).Item("pd_id").ToString()
                        ObjAnd.position = FrmVfield.Return_Roadmap_Position
                        ObjAnd.RoadMap = FrmVfield.Return_Roadmap_Id
                        Col_AnnualDetail.Add(ObjAnd)
                    End If
                Next
                binddataTarget()
            Else
                MessageBox.Show("ไม่พบบุคลากรในตำแหน่งนี้", "Information :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Function pmethCheckNotHavePerson(strPersonId As String) As Boolean
        Dim bHaveData As Boolean
        bHaveData = True
        For Each cs As Object In Col_AnnualDetail
            Dim ObjCs = CType(cs, Cls_Annual_Detail)
            If ObjCs.person_data = strPersonId Then
                bHaveData = False
                Exit For
            End If
        Next
        Return bHaveData
    End Function

#End Region

#Region "Target Function"
    Private Sub btnRefresh_Target_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh_Target.Click
        binddataTarget()
    End Sub

    Private Sub btnDelete_Target_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete_Target.Click
        Try
            Dim Obj As Object = Col_AnnualDetail(Convert.ToInt16(lvTarget.SelectedItems.Item(0).SubItems(1).Text))
            Dim ObjCs = CType(Obj, Cls_Annual_Detail)
            ObjCs.person_data = ""
            Me.binddataTarget()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Inform Function"

    Private Sub btnPlace_Click(sender As System.Object, e As System.EventArgs) Handles btnPlace.Click
        Dim FrmVfield As New Select_Place
        FrmVfield.ShowDialog()
        If FrmVfield.DialogResult() = Windows.Forms.DialogResult.OK And String.IsNullOrEmpty(FrmVfield.return_id) = False Then
            Me.txtPlace.Text = FrmVfield.return_name
            Me.txtPlace.Tag = FrmVfield.return_id
            Me.Annual_Master.place = FrmVfield.return_id
        End If
    End Sub

#End Region

#Region "Budget Function"
    Private Sub btnAdd_budget_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd_budget.Click
        If ValidateDataBudget() = True Then
            If budgetMod = GBMod.Edit And Annual_Budget.cost <> String.Empty Then
            Else
                Annual_Budget = New Cls_Annual_Budget
            End If
            Annual_Budget.Corp_id = GBCorp
            Annual_Budget.qty_people = gmDoubleParse(Me.txtQty_people.Text, 0)
            Annual_Budget.rate = gmDoubleParse(Me.txtRate.Text, 0)
            Annual_Budget.amt_money = gmDoubleParse(Me.txtAmt_money.Text, 0)
            Annual_Budget.cost = cbbBudget.SelectedValue.ToString()
            If budgetMod = GBMod.Add Then
                Col_AnnualBudget.Add(Annual_Budget)
            End If

            Me.pmethBlankVarBudget()
            pmethBindingDataBudget()
            budgetMod = GBMod.Add

        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnEdit_budget_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit_budget.Click
        Try
            budgetMod = GBMod.Edit
            If lvBudget.Items.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim Obj As Object = Col_AnnualBudget(Convert.ToInt16(lvBudget.SelectedItems.Item(0).SubItems(1).Text))
            Annual_Budget = CType(Obj, Cls_Annual_Budget)
            txtQty_people.Text = Annual_Budget.qty_people
            txtRate.Text = Annual_Budget.rate
            txtAmt_money.Text = Annual_Budget.amt_money
            cbbBudget.SelectedValue = Annual_Budget.cost

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnDelete_budget_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete_budget.Click
        Try
            Dim Obj As Object = Col_AnnualBudget(Convert.ToInt16(lvBudget.SelectedItems.Item(0).SubItems(1).Text))
            Dim ObjCs = CType(Obj, Cls_Annual_Budget)
            ObjCs.cost = ""
            Me.pmethBindingDataBudget()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_budget_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel_budget.Click
        budgetMod = GBMod.Add
        Annual_Budget = New Cls_Annual_Budget
        pmethBlankVarBudget()

    End Sub

    Private Sub btnRefresh_budget_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh_budget.Click
        pmethBindingDataBudget()
    End Sub
#End Region

#Region "Binddata"
    Private Sub binddataTarget()
        lvTarget.Items.Clear()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            If Col_AnnualDetail.Count > 0 Then
                lvTarget.FullRowSelect = True
                lvTarget.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For Each cs As Object In Col_AnnualDetail
                    i = i + 1
                    Dim ObjCs = CType(cs, Cls_Annual_Detail)
                    If ObjCs.person_data <> String.Empty Then
                        j = j + 1
                        Dim Itemm As New ListViewItem(ObjCs.id)
                        Itemm.SubItems.Add(i)
                        Itemm.SubItems.Add(j.ToString)
                        Itemm.SubItems.Add(ObjCs.expperson_data.empcd)
                        Itemm.SubItems.Add(ObjCs.expperson_data.prefix_01 + " " + ObjCs.expperson_data.name_01 + " " + ObjCs.expperson_data.sname_01)
                        Itemm.SubItems.Add(cNull(ObjCs.expposition.name, "S"))
                        Itemm.SubItems.Add(cNull(ObjCs.expposition.expStation.name, "S"))
                        lvTarget.Items.Add(Itemm)
                        nindex = nindex + 1
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub pmethBindingDataBudget()
        Try
            Dim i As Integer = 0
            Dim j As Integer = 0
            lvBudget.Items.Clear()
            If Col_AnnualBudget.Count > 0 Then
                lvBudget.FullRowSelect = True
                lvBudget.ShowItemToolTips = True
                Dim nindex As Integer = 0
                For Each cs As Object In Col_AnnualBudget
                    i = i + 1
                    Dim ObjCs = CType(cs, Cls_Annual_Budget)
                    If ObjCs.cost <> String.Empty Then
                        j = j + 1
                        Dim Itemm As New ListViewItem(ObjCs.id)
                        Itemm.SubItems.Add(i)
                        Itemm.SubItems.Add(j.ToString)
                        Itemm.SubItems.Add(ObjCs.expcost.code)
                        Itemm.SubItems.Add(ObjCs.expcost.name)
                        Itemm.SubItems.Add(ObjCs.qty_people.ToString())
                        Itemm.SubItems.Add(ObjCs.rate.ToString())
                        Itemm.SubItems.Add(ObjCs.amt_money.ToString())
                        lvBudget.Items.Add(Itemm)
                        nindex = nindex + 1
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub
#End Region


    Private Sub txtQty_people_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty_people.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtQty_people.Text
            Dim selectionStart = Me.txtQty_people.SelectionStart
            Dim selectionLength = Me.txtQty_people.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 12 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double)) Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txtQty_people_Leave(sender As Object, e As System.EventArgs) Handles txtQty_people.Leave
        If gmDoubleParse(Me.txtQty_people.Text, 0) > 0 And gmDoubleParse(Me.txtRate.Text, 0) > 0 Then
            Me.txtAmt_money.Text = gmDoubleParse(Me.txtQty_people.Text, 0) * gmDoubleParse(Me.txtRate.Text, 0)
        End If
    End Sub

    Private Sub txtRate_Leave(sender As Object, e As System.EventArgs) Handles txtRate.Leave
        If gmDoubleParse(Me.txtQty_people.Text, 0) > 0 And gmDoubleParse(Me.txtRate.Text, 0) > 0 Then
            Me.txtAmt_money.Text = gmDoubleParse(Me.txtQty_people.Text, 0) * gmDoubleParse(Me.txtRate.Text, 0)
        End If
    End Sub

    Private Sub txtQty_people_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtQty_people.KeyUp
        If gmDoubleParse(Me.txtQty_people.Text, 0) > 0 And gmDoubleParse(Me.txtRate.Text, 0) > 0 Then
            Me.txtAmt_money.Text = gmDoubleParse(Me.txtQty_people.Text, 0) * gmDoubleParse(Me.txtRate.Text, 0)
        End If
    End Sub

    Private Sub txtRate_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRate.KeyUp
        If gmDoubleParse(Me.txtQty_people.Text, 0) > 0 And gmDoubleParse(Me.txtRate.Text, 0) > 0 Then
            Me.txtAmt_money.Text = gmDoubleParse(Me.txtQty_people.Text, 0) * gmDoubleParse(Me.txtRate.Text, 0)
        End If
    End Sub

    Private Sub txtEdition_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdition.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtEdition.Text
            Dim selectionStart = Me.txtEdition.SelectionStart
            Dim selectionLength = Me.txtEdition.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 12 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double)) Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtQty.Text
            Dim selectionStart = Me.txtQty.SelectionStart
            Dim selectionLength = Me.txtQty.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 12 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf text.IndexOf("."c) > 0 And (Double.TryParse(text, New Double)) Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

#End Region



    
End Class