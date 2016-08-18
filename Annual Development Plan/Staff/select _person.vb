Public Class select_person
    Dim ConfigValue As SortedList
    Dim App_Name As String = ""
    Dim App_Path As String = ""
    Dim User_Session As String = ""
    Dim UserID As String = ""
    Dim Corp_id As String
    Dim Login_Session As String = ""
    Dim Lang_Index As Integer
    Dim culture As String
    Dim loginnm, CorpName1, CorpName2 As String
    Dim MsgBoxDB As New messageboxsystem.MsgBox.cls_msg
    Dim Station As New Cls_Station
    Public clsTB_Position As New Database.Table.select_data
    Public iPos As Integer = 0
    Public branch_id As String
    Public Person_id, person_name As String
    Public Flag_ActionOK As Boolean
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
    Private Sub sselect_person_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim count As Integer = 1
        Dim position_name, station_name, person_name As String
        Dim dt As DataTable
        dt = clsTB_Position.dsListPerson_Branch(Corp_id, branch_id).Tables(0)
        If Lang_Index = 1 Then
            person_name = "Name_person"
            position_name = "position_name01"
            station_name = "station_name01"
        Else
            person_name = "Name_person_2"
            position_name = "position_name02"
            station_name = "station_name02"
        End If
        Dim xitem As ListViewItem
        With Me.person_data_lv
            .Items.Clear()
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    xitem = .Items.Add(count)
                    xitem.SubItems.Add(cNull(dt.Rows(i)("em_code"), "String"))
                    .Items(i).Tag = cNull(dt.Rows(i)("id"), "String")
                    xitem.SubItems.Add(cNull(dt.Rows(i)(person_name), "String"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)(position_name), "String"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)(station_name), "String"))
                    count = count + 1
                Next
                .Items(iPos).Selected = True
                .Select()
            End If
        End With
    End Sub
    Private Sub SelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectToolStripMenuItem.Click
        Dim i As Integer = 0
        Try
            If person_data_lv.CheckedIndices.Count > 0 Then

                For Each N As Integer In Me.person_data_lv.CheckedIndices
                    iPos = Me.person_data_lv.SelectedItems.Item(0).Index
                    Me.person_name = Me.person_name & "," & Trim(Me.person_data_lv.CheckedItems(i).SubItems(1).Text)
                    Person_id = Me.Person_id & "," & Trim(Me.person_data_lv.Items(N).Tag) & ""
                    i = i + 1
                Next
                Me.Flag_ActionOK = True
                Me.Close()
            Else
                MessageBox.Show("กรุณาระบุรหัสพนักงาน", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("กรุณาระบุรหัสพนักงาน", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class