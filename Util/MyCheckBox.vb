Public Class MyCheckBox
    Inherits CheckBox

    Public Overloads Property Checked() As String
        Get
            Return BooleanToString(MyBase.Checked)
        End Get
        Set(ByVal value As String)
            MyBase.Checked = StringToBoolean(value)
        End Set
    End Property

    Private Function BooleanToString(ByVal b As Boolean) As String
        Return IIf(b, "Y", "N")
    End Function

    Private Function StringToBoolean(ByVal s As String) As Boolean
        Return IIf("Y", True, False)
    End Function

End Class
