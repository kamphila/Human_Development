Public Class rpt_view
    Dim mreport As Object
    Public Property Report() As Object
        Get
            Return mreport
        End Get
        Set(ByVal Value As Object)
            mreport = Value
            With Me.CrystalReportViewer1
                .ReportSource = Nothing
                .ReportSource = mreport
            End With

        End Set
    End Property
    Private Sub rpt_view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class