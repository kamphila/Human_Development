Imports System.Data
Imports System.Windows.Forms
Imports Human_Development.Cls_SqlDB
Public Module Config
    Public GBModule As Global.System.String = String.Empty
    Dim encript As New LionEncript.LionEncript
    Dim SqlDB As New Cls_SqlDB
    'Public GBCorp As Global.System.String = String.Empty
    'Public GBUsername As Global.System.String = String.Empty
    Public GBCorp As Global.System.String = "O6K122E00000001"
    Public GBUsername As Global.System.String = "HROD"
    Public GBloginnm As Global.System.String = String.Empty
    Public GBUserloginid As Global.System.String = String.Empty
    Public GBStationid As Global.System.String = String.Empty
    Public GBStationnm As Global.System.String = String.Empty
    Public GBBranch As Global.System.String = String.Empty
    Public GBParent_id As Global.System.String = String.Empty
    Public GBChild_id As Global.System.String = String.Empty
    Public GBApp_Path As Global.System.String = String.Empty
    Public GBAppName As Global.System.String = String.Empty
    Public GBSt_Type As Global.System.String = String.Empty
    Public GBSt_link As Global.System.String = String.Empty
    Public GBid As Global.System.String = String.Empty
    Public GBname As Global.System.String = String.Empty
    Public ConfigValue As SortedList
    Public GBReportnm As Global.System.String = String.Empty
    Public GBReportfilenm As Global.System.String = String.Empty
    Public GBLangIndex As Integer = 1
    Public GBService_Type = String.Empty
    Public GBPageLimit = String.Empty
    Public gb_empcd As String = String.Empty
    Public gb_date As String = String.Empty
    Public gb_Login_Session As Global.System.String = ""
    Public gb_User_Session As Global.System.String = ""
    Public gb_Culture As Global.System.String = ""

    Public Const Anm_Step_Create As String = "1"
    Public Const Anm_Step_Register As String = "2"
    Public Const Anm_Step_Complete As String = "3"

    Public Const Anm_Pay_Step_NonPay As String = "1"
    Public Const Anm_Pay_Step_Pay As String = "2"


    Public Enum GBMod1
        Add
        Edit
        View
    End Enum

    Public Structure GBMod
        Public Const Add As String = "Add"
        Public Const Edit As String = "Edit"
        Public Const View As String = "View"
        Public Const empty As String = ""
    End Structure

    'End Property
    Public Sub InsertRowEmpty(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow
            dr = dt.NewRow
            dr.Item(0) = "<-- Select -->"
            dt.Rows.InsertAt(dr, 0)
        End If
    End Sub
    Public Sub InsertRowEmpty1(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow
            dr = dt.NewRow
            dr.Item(1) = "<-- Select -->"
            dt.Rows.InsertAt(dr, 0)
        End If
    End Sub

    Public Sub InsertRowEmpty1EN(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow
            dr = dt.NewRow
            dr.Item(2) = "<-- Select -->"
            dt.Rows.InsertAt(dr, 0)
        End If
    End Sub

    Public Sub InsertRowEmpty2(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow
            dr = dt.NewRow
            dr.Item(2) = "<-- Select -->"
            dt.Rows.InsertAt(dr, 0)
        End If
    End Sub
    Public Sub InsertRowAll(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow
            dr = dt.NewRow
            dr.Item(0) = "ALL"
            dt.Rows.InsertAt(dr, 0)
        End If
    End Sub

    Public Sub Hightlight_textbox(ByVal txtnm As TextBox)
        Try
            txtnm.Focus()
            txtnm.SelectionStart = 0
            txtnm.SelectionLength = txtnm.Text.Length

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Public Sub Hightlight_combo(ByVal comboxnm As ComboBox)
        Try
            comboxnm.Focus()
            comboxnm.SelectionStart = 0
            comboxnm.SelectionLength = comboxnm.Text.Length

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Function calculate_work(ByVal workstart As Date) As String
        Dim d1, d2 As Date
        Dim days, months, years As Long
        Dim str As String = String.Empty

        d1 = workstart
        d2 = SqlDB.GetDateTime

        years = Year(d1)
        months = Month(d1)
        days = d1.Day

        years = Year(d2) - years
        months = Month(d2) - months
        days = d2.Day - days

        If Math.Sign(days) = -1 Then
            days = 30 - Math.Abs(days)
            months = months - 1
        End If

        If Math.Sign(months) = -1 Then
            months = 12 - Math.Abs(months)
            years = years - 1
        End If

        'TextBox1.Text = years.ToString
        'TextBox2.Text = months.ToString
        'TextBox3.Text = days.ToString

        If years > 0 Then
            str = years & " ปี "
        End If
        If months > 0 Then
            str &= months & " เดือน "
        End If
        If days > 0 Then
            str &= days & " วัน"
        End If

        Return str
    End Function

    Public Function gmDoubleParse(ByVal strNum As String, ValDefaule As Double) As Double
        Dim vRet As Double = ValDefaule
        Try
            vRet = Double.Parse(strNum)
        Catch ex As Exception
            vRet = ValDefaule
        End Try
        Return vRet
    End Function

    Public Function ChkDBNull(ByVal strText As String)
        If IsDBNull(strText) And _
            Len(Trim(strText)) > 0 And _
            strText.Trim & "" = "" Then
            Return String.Empty
        Else
            Return strText.Trim & ""
        End If
    End Function
    'AAA
    'Public Function cNull(ByVal objData As Object, _
    '            ByVal objType As String) As Object
    '    If objData Is Nothing Then
    '        Select Case objType
    '            Case "Boolean"
    '                Return False
    '            Case "DateTime"
    '                Return Date.Today
    '            Case "Decimal", "Double", "Integer", "Long", "Short", "Single"
    '                Return 0
    '            Case "String"
    '                Return "Nothing"
    '        End Select
    '    ElseIf IsDBNull(objData) Then
    '        Select Case objType
    '            Case "Boolean"
    '                Return False
    '            Case "DateTime"
    '                Return Date.Today
    '            Case "Decimal", "Double", "Integer", "Long", "Short", "Single"
    '                Return 0
    '            Case "String"
    '                Return String.Empty
    '        End Select
    '    ElseIf Trim(objData) = "" Then
    '        Select Case objType
    '            Case "Boolean"
    '                Return False
    '            Case "DateTime"
    '                Return Date.Today
    '            Case "Decimal", "Double", "Integer", "Long", "Short", "Single"
    '                Return 0
    '            Case "String"
    '                Return String.Empty
    '        End Select

    '    Else
    '        Return objData
    '    End If

    'End Function

    Public Function cNull(ByVal objData As Object, _
                   ByVal objType As String) As Object
        If objData Is Nothing Then
            Select Case objType
                Case "B"
                    Return False
                Case "D"
                    Return Date.Today
                Case "N"
                    Return 0
                Case "S"
                    Return "Nothing"
            End Select
        ElseIf IsDBNull(objData) Then
            Select Case objType
                Case "B"
                    Return False
                Case "D"
                    Return Date.Today
                Case "N"
                    Return 0
                Case "S"
                    Return String.Empty
            End Select
        ElseIf Trim(objData) = "" Then
            Select Case objType
                Case "B"
                    Return False
                Case "D"
                    Return Date.Today
                Case "N"
                    Return 0
                Case "S"
                    Return String.Empty
            End Select

        Else
            Return objData
        End If

    End Function

    Public Function Convert_Empty(ByVal objData As String) As Object
        Select Case Trim(objData)
            Case "0"
                Return String.Empty
            Case IsDBNull(objData)
                Return String.Empty
            Case objData Is Nothing
                Return String.Empty
        End Select

        Return objData
    End Function

    Public Function CheckDBNUll(ByVal objData1 As Object, _
                                ByVal objData2 As Object) As Object

        If IsDBNull(objData1) Then
            Return objData2
        Else
            Return objData1
        End If
    End Function

End Module

