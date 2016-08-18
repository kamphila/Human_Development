Public Class frm_Opt_HD_Rpt001
    Dim username As String = ""
    Dim SqlDb As New Cls_SqlDB
    Dim MsgDB As New messageboxsystem.MsgBox.cls_msg
    Dim CoruseMaster As New Cls_Course_Master
    Dim dtCourseMaster As New DataTable

    Public Property Config() As SortedList
        Get
            Return ConfigValue
        End Get
        Set(ByVal value As SortedList)
            ConfigValue = value
            GBApp_Path = ConfigValue.Item("Application Path")
            GBAppName = ConfigValue.Item("Application Name")
            GBService_Type = CInt(ConfigValue.Item("Service Type"))
            GBPageLimit = ConfigValue.Item("Page Limit")
            GBLangIndex = CInt(ConfigValue.Item("Language Index"))
            GBUsername = ConfigValue("Username")

            If username = "HROD" Then
                gb_empcd = "HROD"
                GBUserloginid = "HROD"
            Else
                gb_empcd = SqlDb.GetDataTable("SELECT person_id from user_login where username='" & username & "'").Rows(0)(0).ToString
                GBUserloginid = SqlDb.GetDataTable("SELECT id from user_login where username='" & username & "'").Rows(0)(0).ToString
            End If
            GBCorp = ConfigValue("Corporate ID")
            gb_date = SqlDb.GetDateTime_String.ToString()
            gb_Login_Session = ConfigValue.Item("Login Session")
            gb_User_Session = ConfigValue.Item("User Session")
            GBLangIndex = CInt(ConfigValue.Item("Language Index"))
            gb_Culture = ConfigValue.Item("Corporate Culture")
        End Set
    End Property

    Private Sub frm_Opt_HD_Rpt001_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BindbranchByPermission()

        dtCourseMaster = CoruseMaster.Retreive()
        cbo_CourseMaster.Items.Clear()
        cbo_CourseMaster.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        cbo_branch.SourceDataString = New String() {Name, "cms_id"}
        cbo_branch.SourceDataTable = dtCourseMaster

    End Sub

    Private Sub BindbranchByPermission()
        Try
            If GBLangIndex = 1 Then
                Name = "branch_name_01"
            Else
                Name = "branch_name_02"
            End If
            Dim dt As New DataTable
            dt = SecurityClass.GetBranchByUserID(ConfigValue.Item("User ID"), GBAppName, GBApp_Path, GBCorp, GBLangIndex, "")

            cbo_branch.Items.Clear()
            cbo_branch.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
            cbo_branch.SourceDataString = New String() {Name, "branch_id"}
            cbo_branch.SourceDataTable = dt
            If dt.Rows.Count > 0 Then
                cbo_branch.SelectedIndex = 0
                GBBranch = Me.cbo_branch.SelectedItem.Col2
            End If
        Catch ex As Exception
            MsgDB.showmsg("", GBLangIndex, "", "", "", "", ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub CancleBT_Click(sender As System.Object, e As System.EventArgs) Handles CancleBT.Click
        Me.Close()
    End Sub

    Private Sub PrintBT_Click(sender As System.Object, e As System.EventArgs) Handles PrintBT.Click
        Dim rpt As New Rpt_Hd_001()

    End Sub
End Class