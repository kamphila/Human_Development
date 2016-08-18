Public Class Mainpage

    Private Sub การประเมนToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub เพมแกไขงบประมาณประจำปToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub เพมแกไขรายละเอยดหลกสตรToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrbjToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ตงคาระบบToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ตงคาระบบToolStripMenuItem.Click
        Dim frmnm As New Human_Development.HD_System_Setup
        frmnm.Show()
    End Sub

    Private Sub Mainpage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
#If DEBUG Then
        GBAppName = "numano"
        GBApp_Path = "D:\tgs\Human_Development\Human_Development\bin\Debug\"
#End If

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As New Human_Development.ADD_Edit_List_Course
        frm.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripLabel1.Click
    End Sub
End Class
