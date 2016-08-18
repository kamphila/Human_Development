Public Class rpt_HD_IN_list
    Public PermissionCode As String
    Dim msgbox As New messageboxsystem.MsgBox.cls_msg
    Dim permission_corp As New cls_sc_permission_corp
    Dim Errmsg As String
    Dim SqlDb As New Cls_SqlDB
    Dim username As String = ""

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

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Select Case LCase(e.Node.Name)
            Case "rptHD1_1"
                'Dim frm1 As New rpt_form_search_rpt_1
                'frm1.Config = Config
                'frm1.Name = "rpt_form_search_rpt_1"
                'Dim Frmclass As New FormActionClass.FormClass
                'Dim Errmsg As String = ""
                'Frmclass.LoadFormLang(frm1, frm1.Name, Config, Errmsg)
                'With frm1
                '    .rpt_name = "rpt1_1"
                '    .ShowDialog()
                'End With
            Case "rpt1_2"
                'Dim frm1 As New rpt_form_search_rpt_2
                'frm1.Config = Config
                'frm1.Name = "rpt_form_search_rpt_2"
                'Dim Frmclass As New FormActionClass.FormClass
                'Dim Errmsg As String = ""
                'Frmclass.LoadFormLang(frm1, frm1.Name, Config, Errmsg)
                'With frm1
                '    .rpt_name = "rpt1_2"
                '    .ShowDialog()
                'End With
            Case "rpt1_3"
                'Dim frm1 As New rpt_form_search_rpt_3
                'frm1.Config = Config
                'frm1.Name = "rpt_form_search_rpt_3"
                'Dim Frmclass As New FormActionClass.FormClass
                'Dim Errmsg As String = ""
                'Frmclass.LoadFormLang(frm1, frm1.Name, Config, Errmsg)
                'With frm1
                '    .rpt_name = "rpt1_3"
                '    .ShowDialog()
                'End With
            Case "rpt1_4"
                'Dim frm1 As New rpt_form_search_rpt_4
                'frm1.Config = Config
                'frm1.Name = "rpt_form_search_rpt_4"
                'Dim Frmclass As New FormActionClass.FormClass
                'Dim Errmsg As String = ""
                'Frmclass.LoadFormLang(frm1, frm1.Name, Config, Errmsg)
                'With frm1
                '    .rpt_name = "rpt1_4"
                '    .ShowDialog()
                'End With
            Case "rpt1_5"
                'Dim frm1 As New rpt_form_search_rpt_5
                'frm1.Config = Config
                'frm1.Name = "rpt_form_search_rpt_5"
                'Dim Frmclass As New FormActionClass.FormClass
                'Dim Errmsg As String = ""
                'Frmclass.LoadFormLang(frm1, frm1.Name, Config, Errmsg)
                'With frm1
                '    .rpt_name = "rpt1_5"
                '    .ShowDialog()
                'End With
        End Select
    End Sub


End Class