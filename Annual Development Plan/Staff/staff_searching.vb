Public Class staff_searching
    Dim ConfigValue As SortedList
    Dim App_Name As String = ""
    Dim App_Path As String = ""
    Dim User_Session As String = ""
    Dim UserID As String = ""
    Dim Corp_id, Posi_id, position_level_id, person_id As String
    Dim Login_Session As String = ""
    Dim Lang_Index As Integer
    Dim culture, strCondition As String
    Dim loginnm, CorpName1, CorpName2 As String
    Dim MsgBoxDB As New messageboxsystem.MsgBox.cls_msg
    Dim Station As New ClsStation
    Public Flag_ActionOK As Boolean
    Public st_branch As String
    Public clsTB_Select As New ClsSelect
    Public str_condition, str_sent_branch As String
    Public strName As String

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

    Private Sub staff_searching_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        org_serach_rbt.Checked = False
        position_level_rbt.Checked = False
        position_rbt.Checked = False
        STD_Position_rbt.Checked = False
        emp_code_rbt.Checked = False

        GBCorp = Corp_id
        BindbranchByPermission()
        Me.Flag_ActionOK = False

        Dim dt_emp As DataTable = clsTB_Select.dsEmpList_check_level(Corp_id, "and T5.st_link like '" & st_branch & "%'", "").Tables(0)
        Dim Per_ID_source, Per_name_source As New AutoCompleteStringCollection
        For i = 0 To dt_emp.Rows.Count - 1
            Per_ID_source.Add(dt_emp.Rows(i)("em_code").ToString)
        Next
        emp_code_tb.AutoCompleteCustomSource = Per_ID_source

    End Sub

    Private Sub BindbranchByPermission()
        Try
            If Lang_Index = 1 Then
                Name = "branch_name_01"
            Else
                Name = "branch_name_02"
            End If
            Dim dt As New DataTable

            If st_branch = "" Then
                dt = SecurityClass.GetBranchByUserID(UserID, App_Name, App_Path, Corp_id, Lang_Index, "")
            Else
                dt = clsTB_Select.ds_GetBranch(Corp_id, st_branch).Tables(0)
            End If
            Cbo_Branch.Items.Clear()
            Cbo_Branch.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
            Cbo_Branch.SourceDataString = New String() {Name, "branch_id", "branch_st_link"}
            Cbo_Branch.SourceDataTable = dt
            If dt.Rows.Count > 0 Then
                Cbo_Branch.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBoxDB.showmsg("", Lang_Index, "", "", "", "", ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Cbo_Branch_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles Cbo_Branch.SelectedValueChanged
        Try
            If Not Cbo_Branch.SelectedValue Is Nothing AndAlso Cbo_Branch.Text <> "" Then
                Bindstationtype()
                If org_serach_rbt.Checked = True Then

                    If Cbo_Branch.SelectedIndex = 0 Or Cbo_Branch.SelectedItem.Col2 = "All" Then
                        cbo_stationtype.Enabled = False
                        cbo_station.Enabled = False
                        station_type_lb.Enabled = False
                        station_name_lb.Enabled = False
                        MsgBoxDB.showmsg("W0062", Lang_Index)
                        Exit Sub
                    Else
                        cbo_stationtype.Enabled = True
                        cbo_station.Enabled = True
                        station_type_lb.Enabled = True
                        station_name_lb.Enabled = True

                        If cbo_stationtype.SelectedIndex > -1 And cbo_station.SelectedIndex > -1 Then
                            cbo_stationtype.SelectedIndex = 0
                            cbo_station.SelectedIndex = 0
                        End If
                    End If

                Else
                    cbo_stationtype.Enabled = False
                    cbo_station.Enabled = False
                    station_type_lb.Enabled = False
                    station_name_lb.Enabled = False
                End If
                If position_rbt.Checked = True Then
                    position_tb.Enabled = True
                    position_bt.Enabled = True
                Else
                    position_tb.Enabled = False
                    position_bt.Enabled = False
                End If
                If position_level_rbt.Checked = True Then
                    position_level_tb.Enabled = True
                    position_level_bt.Enabled = True
                Else
                    position_level_tb.Enabled = False
                    position_level_bt.Enabled = False
                End If
                If STD_Position_rbt.Checked = True Then
                    from_workage_lb.Enabled = True
                    from_workage_tb.Enabled = True
                    to_workage_lb.Enabled = True
                    to_workage_tb.Enabled = True
                    STD_PositionTB.Enabled = True
                    STD_PositionBT.Enabled = True
                Else
                    from_workage_lb.Enabled = False
                    from_workage_tb.Enabled = False
                    to_workage_lb.Enabled = False
                    to_workage_tb.Enabled = False
                    STD_PositionTB.Enabled = False
                    STD_PositionBT.Enabled = False
                End If
                If emp_code_rbt.Checked = True Then
                    emp_code_tb.Enabled = True
                    emp_code_bt.Enabled = True
                Else
                    emp_code_tb.Enabled = False
                    emp_code_bt.Enabled = False
                End If
            Else
                If org_serach_rbt.Checked = True Then
                    cbo_stationtype.Enabled = False
                    cbo_station.Enabled = False
                    station_type_lb.Enabled = False
                    station_name_lb.Enabled = False
                    MsgBoxDB.showmsg("W0061", Lang_Index)
                    org_serach_rbt.Checked = False
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub Bindstationtype()
        Try
            Dim dt As New DataTable
            Station.st_link = Cbo_Branch.SelectedItem.Col3.ToString()
            dt = Station.Retrive_StationType
            If dt.Rows.Count < 1 Then
                MsgBoxDB.showmsg("W0064", Lang_Index)
                org_serach_rbt.Checked = False
                Exit Sub
            End If

            cbo_stationtype.ValueMember = "id"

            If Lang_Index = 1 Then
                cbo_stationtype.DisplayMember = "name_01"
                Human_Development.Config.InsertRowEmpty1(dt)

            Else
                cbo_stationtype.DisplayMember = "name_02"
                Human_Development.Config.InsertRowEmpty1EN(dt)
            End If

            cbo_stationtype.DataSource = dt
            cbo_stationtype.SelectedIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo_stationtype_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_stationtype.SelectedIndexChanged
        Try
            If Not cbo_stationtype.SelectedValue Is Nothing AndAlso cbo_stationtype.SelectedValue.ToString <> "" Then
                Bindstation()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bindstation()
        Try
            If Not cbo_stationtype.SelectedValue Is Nothing AndAlso cbo_stationtype.SelectedValue.ToString <> "" Then
                Dim dt As New DataTable
                Station.st_type = cbo_stationtype.SelectedValue.ToString()
                Station.st_link = Cbo_Branch.SelectedItem.Col3.ToString()
                Station.id = ""
                dt = Station.Retrive_Station
                cbo_station.ValueMember = "st_link"
                If Lang_Index = 1 Then
                    cbo_station.DisplayMember = "name_01"
                    Human_Development.Config.InsertRowEmpty1(dt)
                Else
                    cbo_station.DisplayMember = "name_02"
                    Human_Development.Config.InsertRowEmpty1EN(dt)
                End If
                cbo_station.DataSource = dt
                'cbo_station.SelectedIndex = 0
                If dt.Rows.Count > 0 Then
                    cbo_station.SelectedIndex = 0
                Else
                    MsgBoxDB.showmsg("W0064", Lang_Index)
                    cbo_station.Text = ""
                    cbo_station.Enabled = False
                    station_name_lb.Enabled = False
                    Exit Sub
                End If
            Else
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Function ValidateData() As Boolean
        Dim bSucc As Boolean = True
        Dim strErrmsg As String = String.Empty
        If org_serach_rbt.Checked = False And position_level_rbt.Checked = False And position_rbt.Checked = False And STD_Position_rbt.Checked = False And emp_code_rbt.Checked = False Then
            strErrmsg = "กรุณาระบเงื่อนไขการค้นหา"
            bSucc = False
        ElseIf org_serach_rbt.Checked = True And ((cbo_stationtype.SelectedIndex <= 0) Or (cbo_station.SelectedIndex <= 0)) Then
            strErrmsg = "กรุณาระบุลำดับชั้นหน่วยงาน"
            bSucc = False
        ElseIf position_level_rbt.Checked = True And (String.IsNullOrEmpty(position_level_tb.Text) = True) Then
            strErrmsg = "กรุณาระบุระดับการบังคับบัญชา"
            bSucc = False
        ElseIf position_rbt.Checked = True And (String.IsNullOrEmpty(position_tb.Text) = True) Then
            strErrmsg = "กรุณาระบุตำแหน่ง"
            bSucc = False
        ElseIf STD_Position_rbt.Checked = True And (String.IsNullOrEmpty(STD_PositionTB.Text) = True) Then
            strErrmsg = "กรุณาระบุตำแหน่งมาตรฐาน"
            bSucc = False
        ElseIf emp_code_rbt.Checked = True And (String.IsNullOrEmpty(emp_code_tb.Text) = True) Then
            strErrmsg = "กรุณาระบุรหัสพนักงาน"
            bSucc = False
        End If
        If bSucc = False Then
            MessageBox.Show(strErrmsg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return bSucc
    End Function

    Private Sub SelectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectToolStripMenuItem.Click

        If ValidateData() = True Then
            Call Build_Condition()
            str_sent_branch = Cbo_Branch.SelectedItem.Col3
            str_condition = strCondition
            Me.Flag_ActionOK = True
            Me.Close()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Build_Condition()
        Dim strDumy As String
            If org_serach_rbt.Checked = True Then
                'โครงสร้างองค์กร
                If Trim(Me.cbo_station.SelectedValue) <> "" Then
                    strDumy = strDumy & " salary_P.st_link Like  '" & Utility.ReAllSQL.gReAll(Me.cbo_station.SelectedValue) & "%' "
                End If
                strName = Me.cbo_station.SelectedText
            ElseIf position_level_rbt.Checked = True Then 'ระดับการบริหาร
                Dim aASI() As String
                aASI = Split("," & position_level_id & "", ",")
                For N As Long = 1 To UBound(aASI)
                    If strDumy = "" Then
                        strDumy = " ( position_level ='" & aASI(N) & "' "
                    Else
                        strDumy = strDumy & " or position_level ='" & aASI(N) & "' "
                    End If
                Next
                strDumy = strDumy & ")"
                strName = position_level_tb.Text
            ElseIf position_rbt.Checked = True Then 'ตำแหน่ง
                Dim aASI() As String
                aASI = Split("," & Posi_id & "", ",")
                For N As Long = 1 To UBound(aASI)
                    If strDumy = "" Then
                        strDumy = " ( position_id ='" & aASI(N) & "' "
                    Else
                        strDumy = strDumy & " or position_id ='" & aASI(N) & "' "
                    End If
                Next
                strDumy = strDumy & ")"
                strName = position_tb.Text
            ElseIf STD_Position_rbt.Checked = True Then 'ตำแหน่งมาตราฐาน
                Dim aASI() As String
                aASI = Split("," & Posi_id & "", ",")
                For N As Long = 1 To UBound(aASI)
                    If strDumy = "" Then
                        strDumy = " ( position_list_id ='" & aASI(N) & "' "
                    Else
                        strDumy = strDumy & " or position_list_id ='" & aASI(N) & "' "
                    End If
                Next
                strDumy = strDumy & ")"
                strName = STD_PositionTB.Text
            ElseIf emp_code_rbt.Checked = True Then 'รหัสพนักงาน
                Dim aASI() As String
                aASI = Split("," & person_id & "", ",")
                For N As Long = 1 To UBound(aASI)
                    If strDumy = "" Then
                        strDumy = " ( person_id ='" & aASI(N) & "' "
                    Else
                        strDumy = strDumy & " or person_id ='" & aASI(N) & "' "
                    End If
                Next
                strDumy = strDumy & ")"
                'Else
                '    strDumy = strDumy & "order by T1.em_code Desc"
                strName = emp_code_tb.Text
            End If
            strCondition = strDumy

    End Sub

    Private Sub org_serach_rbt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles org_serach_rbt.CheckedChanged
        Try

            If org_serach_rbt.Checked = True Then
                If cbo_stationtype.Items.Count > 0 Then
                    cbo_stationtype.Enabled = True
                    cbo_station.Enabled = True
                    station_type_lb.Enabled = True
                    station_name_lb.Enabled = True
                    Bindstation()
                    If cbo_stationtype.SelectedIndex > -1 And cbo_station.SelectedIndex > -1 Then
                        cbo_stationtype.SelectedIndex = 0
                        cbo_station.SelectedIndex = 0
                    End If
                Else
                    cbo_stationtype.Enabled = False
                    cbo_station.Enabled = False
                    station_type_lb.Enabled = False
                    station_name_lb.Enabled = False
                End If
            ElseIf org_serach_rbt.Checked = False Then
                cbo_stationtype.Enabled = False
                cbo_station.Enabled = False
                station_type_lb.Enabled = False
                station_name_lb.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub position_rbt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles position_rbt.CheckedChanged
        Try
            If position_rbt.Checked = True Then
                position_tb.Enabled = True
                position_bt.Enabled = True
            ElseIf position_rbt.Checked = False Then
                position_tb.Enabled = False
                position_bt.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub position_level_rbt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles position_level_rbt.CheckedChanged
        Try
            If position_level_rbt.Checked = True Then
                position_level_tb.Enabled = True
                position_level_bt.Enabled = True
            ElseIf position_level_rbt.Checked = False Then
                position_level_tb.Enabled = False
                position_level_bt.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub STD_Position_rbt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles STD_Position_rbt.CheckedChanged
        Try
            If STD_Position_rbt.Checked = True Then
                STD_PositionTB.Enabled = True
                STD_PositionBT.Enabled = True
            ElseIf STD_Position_rbt.Checked = False Then
                STD_PositionTB.Enabled = False
                STD_PositionBT.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub emp_code_rbt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles emp_code_rbt.CheckedChanged
        Try
            If emp_code_rbt.Checked = True Then
                emp_code_tb.Enabled = True
                emp_code_bt.Enabled = True
            ElseIf emp_code_rbt.Checked = False Then
                emp_code_tb.Enabled = False
                emp_code_bt.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub position_bt_Click(sender As System.Object, e As System.EventArgs) Handles position_bt.Click
        Dim frm As New SelectPosition
        With frm
            .Config = Config
            .branch_id = Cbo_Branch.SelectedItem.Col3
            frm.Name = "sSelectPosition"
            Dim Fclass As New FormActionClass.FormClass
            Fclass.LoadFormLang(frm, frm.Name, ConfigValue, "")
            .ShowDialog(Me)
            If .Flag_ActionOK = True Then
                Me.position_tb.Text = .Name_Position.Substring(1, Len(.Name_Position) - 1)
                Me.Posi_id = .Position_id.Substring(1, Len(.Position_id) - 1)
            End If
        End With
    End Sub

    Private Sub position_level_bt_Click(sender As System.Object, e As System.EventArgs) Handles position_level_bt.Click
        Dim frm As New select_position_level
        With frm
            .Config = Config
            frm.Name = "sselect_position_level"
            Dim Fclass As New FormActionClass.FormClass
            Fclass.LoadFormLang(frm, frm.Name, ConfigValue, "")
            .ShowDialog(Me)
            If .Flag_ActionOK = True Then
                Me.position_level_tb.Text = .Name_Positionlevel.Substring(1, Len(.Name_Positionlevel) - 1)
                Me.position_level_id = .Positionlevel_id.Substring(1, Len(.Positionlevel_id) - 1)
            End If
        End With
    End Sub

    Private Sub emp_code_bt_Click(sender As System.Object, e As System.EventArgs) Handles emp_code_bt.Click
        Dim frm As New select_person
        With frm
            .Config = Config
            .branch_id = Cbo_Branch.SelectedItem.Col3
            frm.Name = "sselect_person"
            Dim Fclass As New FormActionClass.FormClass
            Fclass.LoadFormLang(frm, frm.Name, ConfigValue, "")
            .ShowDialog(Me)
            If .Flag_ActionOK = True Then
                Me.emp_code_tb.Text = .person_name.Substring(1, Len(.person_name) - 1)
                Me.person_id = .Person_id.Substring(1, Len(.Person_id) - 1)
            End If
        End With
    End Sub

    Private Sub STD_PositionBT_Click(sender As System.Object, e As System.EventArgs) Handles STD_PositionBT.Click
        Dim frm As New select_position_STD
        With frm
            .Config = Config
            .branch_id = Cbo_Branch.SelectedItem.Col3
            frm.Name = "sselect_position"
            Dim Fclass As New FormActionClass.FormClass
            Fclass.LoadFormLang(frm, frm.Name, ConfigValue, "")
            .ShowDialog(Me)
            If .Flag_ActionOK = True Then
                Me.STD_PositionTB.Text = .Name_Position.Substring(1, Len(.Name_Position) - 1)
                Me.Posi_id = .Position_id.Substring(1, Len(.Position_id) - 1)
            End If
        End With
    End Sub
End Class