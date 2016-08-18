Public Class HD_POP_Person
    Dim sqlDb As New Cls_SqlDB
    Dim sqlCommand As String = ""
    Dim dt As New DataTable
    Dim where As String = ""
    Public where_con As String = ""
    Dim cls_person As New cls_person
    Public chk As String = ""
    Public form_name As String = ""
    Public branch As String = ""
    Public position_level As String = ""
    Public position As String = ""
    Public position_code As String = ""
    Public position_name As String = ""
    Public person_start As String = ""
    Public person_end As String = ""
    Public Fname As String = ""
    Public Sname As String = ""
    Public age_start As String = ""
    Public age_end As String = ""
    Public sex As String = ""

    Public rtn_branch_id As String = ""
    Public rtn_branch_name As String = ""
    Public rtn_depart_name As String = ""

    Public rtn_position_code As String = ""
    Public rtn_position_name As String = ""
    Public rtn_position_level As String = ""
    Public rtn_person_id As String = ""
    Public rtn_person_code As String = ""
    Public rtn_personname As String = ""
    Public rtn_station_id As String = ""
    Public rtn_position_id As String = ""
    Public rtn_year_work As String = ""
    Public rtn_position_level_id As String = ""

    Private Sub WF_POP_Person_V2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.tbx_person_code.Text = person_start
        Me.tbx_person_name.Text = Fname
        Me.tbx_position_code.Text = position_code
        Me.tbx_position_name.Text = position_name
        'If form_name = "ReqEquipment" Then
        If branch <> "" And branch <> "All" Then
            where = " and branch.id='" & branch & "'"
        End If

        If chk = "3" Then
        ElseIf chk = "4" Then
        ElseIf chk = "5" Then
        ElseIf chk = "6" Then
        ElseIf chk = "7" Then

        End If
        get_search()
    End Sub
    Private Sub get_search()
        where = ""
        If branch <> "All" Then
            where &= " and branch.id='" & branch & "'"
        End If
        If sex <> "" Then
            If sex = "ชาย" Then
                where &= " and person_data.prefix_01 in ('นาย')"
            ElseIf sex = "หญิง" Then
                where &= " and person_data.prefix_01 in ('นาง','นางสาว')"
            End If
        End If

        If GBLangIndex = 1 Then
            If Me.tbx_person_name.Text <> "" Then
                where &= " and ( person_data.name_01 like'%" & Me.tbx_person_name.Text & "%' or person_data.sname_01 like'%" & Me.tbx_person_name.Text & "%' )"
            End If
            If Me.tbx_position_name.Text <> "" Then
                where &= " and position.name_01 like'%" & Me.tbx_position_name.Text & "%'"
            End If
            'aaa
            If Me.txtStationName.Text <> "" Then
                where &= " and station.name_01 like '%" & Me.txtStationName.Text & "%' "
            End If
        Else
            If Me.tbx_person_name.Text <> "" Then
                where &= " and ( person_data.name_02 like'%" & Me.tbx_person_name.Text & "%' or person_data.sname_02 like'%" & Me.tbx_person_name.Text & "%' ) "
            End If
            If Me.tbx_position_name.Text <> "" Then
                where &= " and position.name_02 like'%" & Me.tbx_position_name.Text & "%'"
            End If
            'aaa
            If Me.txtStationName.Text <> "" Then
                where &= " and station.name_02 like '%" & Me.txtStationName.Text & "%' "
            End If
        End If
        If Me.tbx_person_code.Text <> "" Then
            where &= " and person_data.em_code like '%" & Me.tbx_person_code.Text & "%' "
        End If
        If Me.tbx_position_code.Text <> "" Then
            where &= " and position.position_code like '%" & Me.tbx_position_code.Text & "%' "
        End If


        If where_con <> "" Then
            where &= where_con
        End If
        dt = cls_person.Get_Person_Req(where)
        bind_data1(dt)
    End Sub



    Public Sub bind_data1(ByVal dt As DataTable)
        Dim xitem As New ListViewItem
        With Me.Lst_person
            .Items.Clear()
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    xitem = .Items.Add(cNull(dt.Rows(i)("person_id"), "S"))
                    .Items(i).Tag = cNull(dt.Rows(i)("person_id"), "S")
                    xitem.SubItems.Add(cNull(dt.Rows(i)("person_code"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("person_name"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("branch_name"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("station_name"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("position_code"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("position_name"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("station_id"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("position_id"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("branch_id"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("position_level_name"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("yesr_work"), "S"))
                    xitem.SubItems.Add(cNull(dt.Rows(i)("position_level_id"), "S"))
                Next
            End If
        End With
        Me.Lst_person.Columns(0).Width = 0
        Me.Lst_person.Columns(7).Width = 0
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Lst_person_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lst_person.DoubleClick
        Try
            If Lst_person.SelectedIndices.Count <> 0 Then
                'If form_name = "ReqEquipment" Then
                For Each N As Integer In Me.Lst_person.SelectedIndices
                    rtn_branch_id = Trim(Me.Lst_person.Items(N).SubItems(9).Text)
                    rtn_branch_name = Trim(Me.Lst_person.Items(N).SubItems(3).Text)
                    rtn_depart_name = Trim(Me.Lst_person.Items(N).SubItems(4).Text)
                    rtn_position_code = Trim(Me.Lst_person.Items(N).SubItems(5).Text)
                    rtn_position_name = Trim(Me.Lst_person.Items(N).SubItems(6).Text)
                    rtn_position_level = Trim(Me.Lst_person.Items(N).SubItems(10).Text)

                    rtn_person_id = Trim(Me.Lst_person.Items(N).Tag)
                    rtn_person_code = Trim(Me.Lst_person.Items(N).SubItems(1).Text)
                    rtn_personname = Trim(Me.Lst_person.Items(N).SubItems(2).Text)
                    rtn_station_id = Trim(Me.Lst_person.Items(N).SubItems(7).Text)
                    rtn_position_id = Trim(Me.Lst_person.Items(N).SubItems(8).Text)

                    rtn_position_level_id = Trim(Me.Lst_person.Items(N).SubItems(12).Text)
                    rtn_year_work = Trim(Me.Lst_person.Items(N).SubItems(11).Text)
                Next
                DialogResult = Windows.Forms.DialogResult.OK
                'End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        get_search()
    End Sub

    Private Sub btnReste_Click(sender As System.Object, e As System.EventArgs) Handles btnReste.Click
        tbx_person_code.Text = ""
        tbx_person_name.Text = ""
        tbx_position_code.Text = ""
        tbx_position_name.Text = ""
        txtStationName.Text = ""
        get_search()
    End Sub
End Class