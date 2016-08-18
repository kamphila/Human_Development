Public Class frm_select_branch_2
    Dim Errmsg As String
    Dim MsgDB As New messageboxsystem.MsgBox.cls_msg
    Dim permission_corp As New cls_sc_permission_corp
    Public frmnm As String = String.Empty
    Public frm_name As String = ""
    Dim encript As New LionEncript.LionEncript
    Dim SqlDb As New Cls_SqlDB
    Dim username As String = ""
    Dim cls_myfunc As New cls_myfunc
    Public BranchId As String = String.Empty
    Public Property Config() As SortedList
        Get
            Return ConfigValue
        End Get
        Set(ByVal value As SortedList)
            ConfigValue = value
            GBApp_Path = ConfigValue.Item("Application Path")
            GBAppName = ConfigValue.Item("Application Name")
            GBLangIndex = CInt(ConfigValue.Item("Language Index"))
            username = ConfigValue("Username")

            If username = "HROD" Then
                gb_empcd = "HROD"
                GBUsername = "HROD"
            Else
                gb_empcd = SqlDb.GetDataTable("SELECT person_id from user_login where username='" & username & "'").Rows(0)(0).ToString
                GBUsername = SqlDb.GetDataTable("SELECT id from user_login where username='" & username & "'").Rows(0)(0).ToString
            End If
            GBCorp = ConfigValue("Corporate ID")
            gb_date = SqlDb.GetDateTime_String.ToString()
            gb_Login_Session = ConfigValue.Item("Login Session")
            gb_User_Session = ConfigValue.Item("User Session")
            gb_Culture = ConfigValue.Item("Corporate Culture")

        End Set
    End Property
    Private Sub frm_select_branch_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindbranchByPermission()
        Me.tbx_date_from.Text = cls_myfunc.Convert_Culture(DateTime.Now.ToString("dd/MM/yyyy"), gb_Culture)
        Me.tbx_date_to.Text = cls_myfunc.Convert_Culture(DateTime.Now.ToString("dd/MM/yyyy"), gb_Culture)
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
            'If frm_name = "WF_Request_Group_V2" Or frm_name = "WF_Request_Group_AP_V2" Then
            'ลบสาขาทั้งหมออก
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("branch_id").ToString = "All" Then
                        dt.Rows(i).Delete()
                        Exit For
                    End If
                Next
            End If
            'End If
            cbo_branch.Items.Clear()
            cbo_branch.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
            cbo_branch.SourceDataString = New String() {Name, "branch_id"}
            cbo_branch.SourceDataTable = dt
            If dt.Rows.Count > 0 Then
                cbo_branch.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgDB.showmsg("", GBLangIndex, "", "", "", "", ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdexit.Click
        BranchId = String.Empty
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            GBBranch = Me.cbo_branch.SelectedItem.Col2
            BranchId = Me.cbo_branch.SelectedItem.Col2
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgDB.showmsg("", GBLangIndex, "", "", "", "", ex.Message)
            Exit Sub
        End Try

    End Sub
End Class