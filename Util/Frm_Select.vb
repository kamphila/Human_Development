Public Class Frm_Select
    Public Retrun_id = String.Empty
    Public Retrun_Code = String.Empty
    Public Retrun_Name = String.Empty
    Public Retrun_Name2 = String.Empty

    Private Sub Frm_Select_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Public Sub pmethLoad(ClassName As String, Prifix As String)
        Try
            'Dim myObj = Activator.CreateInstance(Type.[GetType](ClassName))
            'myObj()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        Try
            Retrun_id = lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Sub CreateColumns(StrCol As String)
        If String.IsNullOrEmpty(StrCol) = False Then
            Dim words As String() = StrCol.Split(New Char() {","c})
            For Each col In words
                lvData.Columns.Add(col, 100, HorizontalAlignment.Left)
            Next
        End If
    End Sub

    Public Shared Sub autoResizeColumns(lv As ListView)
        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Dim cc As ListView.ColumnHeaderCollection = lv.Columns
        For i As Integer = 0 To cc.Count - 1
            Dim colWidth As Integer = TextRenderer.MeasureText(cc(i).Text, lv.Font).Width + 50
            If cc(i).Text = "id" Then
                cc(i).Width = 0
            ElseIf cc(i).Text = "name" Then
                cc(i).Width = 200
            ElseIf colWidth > cc(i).Width Then
                cc(i).Width = colWidth
            End If
        Next
    End Sub

    Private Sub lvData_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lvData.KeyPress

        If Asc(e.KeyChar) = Keys.Enter Or Asc(e.KeyChar) = Keys.Tab Then
            Try
                Retrun_id = lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
                DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub lvData_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvData.DoubleClick
        Try
            Retrun_id = lvData.SelectedItems.Item(0).SubItems(0).Text.ToString()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("กรุณาเลือกรายการที่ต้องการ", "System Error :", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Class