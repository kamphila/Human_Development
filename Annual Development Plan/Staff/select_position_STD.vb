Public Class select_position_STD
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
    Public Position_id, Name_Position As String
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
    Private Sub select_position_STD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim count As Integer = 1
        Dim position_name As String
        Dim dt As DataTable
        dt = clsTB_Position.dsListPosition_STD(Corp_id).Tables(0)
        If Lang_Index = 1 Then
            position_name = "name_01"
        Else
            position_name = "name_02"
        End If
        Dim xitem As ListViewItem
        With Me.position_level_lv
            .Items.Clear()
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    xitem = .Items.Add(count)
                    xitem.SubItems.Add(cNull(dt.Rows(i)("position_code"), "String"))
                    .Items(i).Tag = cNull(dt.Rows(i)("id"), "String")
                    xitem.SubItems.Add(cNull(dt.Rows(i)(position_name), "String"))
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
            If position_level_lv.CheckedIndices.Count > 0 Then

                For Each N As Integer In Me.position_level_lv.CheckedIndices
                    iPos = Me.position_level_lv.SelectedItems.Item(0).Index
                    Me.Name_Position = Me.Name_Position & "," & Trim(Me.position_level_lv.CheckedItems(i).SubItems(2).Text)
                    Position_id = Me.Position_id & "," & Trim(Me.position_level_lv.Items(N).Tag) & ""
                    i = i + 1
                Next
                Me.Flag_ActionOK = True
                Me.Close()
            Else
                MessageBox.Show("กรุณาระบุตำแหน่งมาตรฐาน", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("กรุณาระบุตำแหน่งมาตรฐาน", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class