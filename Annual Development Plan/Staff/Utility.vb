Imports System.Text.RegularExpressions 'User Class ReplaceRegex
Imports System.Math 'User Class Dollar
Imports System.IO

Public Class Utility

#Region "Validate Value & Controls"
    Public Shared Function CheckKeyPressDateField(ByRef e As KeyPressEventArgs) As Boolean
        Select Case Asc(e.KeyChar)
            Case 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8, 127
            Case Else
                e.Handled = True
        End Select
    End Function

    Public Shared Function CheckKeyPressDateTimeField(ByRef e As KeyPressEventArgs) As Boolean
        Select Case Asc(e.KeyChar)
            Case 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8
            Case 127 'del
            Case 32 'Space
            Case 58 ':
            Case Else
                e.Handled = True
        End Select
    End Function

    Public Shared Function CheckKeyPressNumericField(ByVal Sender As Object, ByRef e As KeyPressEventArgs) As Boolean
        Select Case Asc(e.KeyChar)
            Case 46
                If Sender.text.indexof(".") > -1 Then
                    e.Handled = True
                End If
            Case 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8, 127
            Case Else
                e.Handled = True
        End Select
    End Function

    '������Ѻ��������� �������ö�������Ţ ��Шش����ҹ��
    Public Shared Function CheckKeyPressDoubleField(ByVal Sender As Object, ByRef e As KeyPressEventArgs) As Boolean
        Select Case Asc(e.KeyChar)
            Case 46
                If Sender.text.indexof(".") > -1 Then
                    e.Handled = True
                End If
            Case 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8, 127
            Case Else
                e.Handled = True
        End Select
    End Function

    Public Shared Function CheckKeyPressTimeField(ByRef e As KeyPressEventArgs) As Boolean 'Allow Number and ":"
        Select Case Asc(e.KeyChar)
            Case 58, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8, 127
            Case Else
                e.Handled = True
        End Select
    End Function

    '������Ѻ��������� �������ö�����������Ţ��ҹ��
    Public Shared Function CheckKeyPressLongField(ByRef e As KeyPressEventArgs) As Boolean
        Select Case Asc(e.KeyChar)
            Case 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8, 127
            Case Else
                e.Handled = True
        End Select
    End Function

    Public Shared Function CheckNumeric(ByRef ctrlText As TextBox, _
                                        Optional ByVal strPrompt As String = "") As Boolean
        CheckNumeric = False

        If Len(Trim(ctrlText.Text)) <= 0 Then
            ctrlText.Text = 0
        End If

        If Not IsNumeric(ctrlText.Text) Then
            If Len(strPrompt) = 0 Then
                FunctionClass.HumanoMsgBox("Numeric field", MsgBoxStyle.Information)
            Else
                FunctionClass.HumanoMsgBox(strPrompt & " is numeric field", MsgBoxStyle.Information)
            End If
            ctrlText.Text = ""
            ctrlText.Focus()
            Exit Function
        End If
        CheckNumeric = True
    End Function

    Public Shared Function CheckNumeric(ByRef strText As String, _
    Optional ByVal strName As String = "") As Boolean
        CheckNumeric = False

        If Len(Trim(strText)) <= 0 Then
            strText = 0
        End If

        If Not IsNumeric(strText) Then
            If Len(strName) = 0 Then
                FunctionClass.HumanoMsgBox("Numeric field", MsgBoxStyle.Information)
            Else
                FunctionClass.HumanoMsgBox(strName & " is numeric field", MsgBoxStyle.Information)
            End If
            strText = ""
            Exit Function
        End If
        CheckNumeric = True
    End Function

    Public Shared Function CheckNotNull(ByRef strText As String, _
                                        Optional ByVal strPrompt As String = "", _
                                        Optional ByVal strLanguage As String = "") As Boolean

        CheckNotNull = False

        Select Case strLanguage
            Case "th" '������
                If Len(Trim(strText)) <= 0 Then
                    FunctionClass.HumanoMsgBox(strPrompt & " �������ö�繤����ҧ�� !!!", MsgBoxStyle.Information)
                    strText = ""
                    Exit Function
                End If

            Case "en" '�����ѧ���
                If Len(Trim(strText)) <= 0 Then
                    FunctionClass.HumanoMsgBox(strPrompt & " Null Value Detected !!!", MsgBoxStyle.Information)
                    strText = ""
                    Exit Function
                End If
            Case Else
        End Select

        CheckNotNull = True
    End Function

    Public Shared Function CheckNotNull(ByRef ctl As Control, _
                                        Optional ByVal strPrompt As String = "", _
                                        Optional ByVal strLanguage As String = "") As Boolean

        CheckNotNull = False

        If TypeOf ctl Is ComboBox Then
            Select Case strLanguage
                Case "th" '������
                    If CType(ctl, ComboBox).SelectedValue = "" Then
                        FunctionClass.HumanoMsgBox(strPrompt & " �������ö�繤����ҧ�� !!!", MsgBoxStyle.Information)
                        CType(ctl, ComboBox).SelectedValue = ""
                        Exit Function
                    End If

                Case "en" '�����ѧ���
                    If CType(ctl, ComboBox).Text = "" Then
                        FunctionClass.HumanoMsgBox(strPrompt & " Null value detected !!!", MsgBoxStyle.Information)
                        CType(ctl, ComboBox).SelectedValue = ""
                        Exit Function
                    End If
                Case Else
            End Select
        End If

        If TypeOf ctl Is TextBox Then
            Select Case strLanguage
                Case "th" '������
                    If Len(Trim(CType(ctl, TextBox).Text)) <= 0 Then
                        FunctionClass.HumanoMsgBox(strPrompt & " �������ö�繤����ҧ�� !!!", MsgBoxStyle.Information)
                        CType(ctl, TextBox).Text = ""
                        Exit Function
                    End If

                Case "en" '�����ѧ���
                    If Len(Trim(CType(ctl, TextBox).Text)) <= 0 Then
                        FunctionClass.HumanoMsgBox(strPrompt & " Null value detected !!!", MsgBoxStyle.Information)
                        CType(ctl, TextBox).Text = ""
                        Exit Function
                    End If
                Case Else
            End Select
        End If



        CheckNotNull = True
    End Function
#End Region

#Region "Date & Time"
    Public Shared Function Readini() As String()
        Dim aStr(20) As String
        Dim i As Integer = 0
        Dim reader As StreamReader = _
       New StreamReader(Application.StartupPath & "\TA_CONFIG.ini")
        Try
            Do
                aStr(i) = reader.ReadLine
                i = i + 1
            Loop Until reader.Peek = -1
        Catch
        Finally
            reader.Close()
        End Try
        Readini = aStr
    End Function
    '������Ѻ�礤�� �ѹ��� dd/MM/yyyy
    Public Shared Function CheckDateInput(ByRef strText As String, _
                                          Optional ByVal blAlertError As Boolean = True, _
                                          Optional ByVal blAllowNull As Boolean = True, _
                                          Optional ByVal strPrompt As String = "", _
                                          Optional ByVal strLanguage As String = "") As Boolean
        CheckDateInput = False

        Select Case strLanguage
            Case "1" '������
                If Len(Trim(strText)) <= 0 Then
                    If Not blAllowNull Then
                        If blAlertError Then
                            FunctionClass.HumanoMsgBox(strPrompt & " �������ö�繤����ҧ�� !!!", MsgBoxStyle.Information)
                            strText = Utility.ConvertDateThai(Today)
                        End If
                    Else
                        CheckDateInput = True
                    End If
                    Exit Function
                End If

                If Len(Trim(strText)) <> 10 And Len(Trim(strText)) <> 8 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox(strPrompt & " ��ͧ������ٻẺ����˹� (dd/mm/yyyy)", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Len(Trim(strText)) = 8 Then
                    strText = strText.Substring(0, 2) & "/" & strText.Substring(2, 2) & "/" & strText.Substring(4)
                End If

                Dim arr As String() = strText.Split("/")
                If arr.Length <> 3 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox(strPrompt & " ��ͧ������ٻẺ����˹� (dd/mm/yyyy)", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Not (Len(Trim(arr(0))) = 2 And Len(Trim(arr(1))) = 2 And Len(Trim(arr(2))) = 4) Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox(strPrompt & " ��ͧ������ٻẺ����˹� (dd/mm/yyyy)", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Trim(arr(0)) > 31 Or Trim(arr(0)) < 1 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox("����ѹ���ͧ " & strPrompt & " ��ͧ�դ�����������ҧ 1 �֧  31 ", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Trim(arr(1)) > 12 Or Trim(arr(1)) < 1 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox("�����͹�ͧ " & strPrompt & " ��ͧ�դ�����������ҧ 1 �֧  12 ", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Trim(arr(2)) < 1900 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox("��һբͧ " & strPrompt & " ��ͧ�դ���ҡ���һ� ��.1900", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If
                '����� 28 OR 29
                Dim year As Integer = CInt(Trim(arr(2)))
                If CInt(Trim(arr(2))) > 2500 Then year = CInt(Trim(arr(2))) - 543
                Select Case Trim(arr(1))
                    Case "02"
                        If Date.IsLeapYear(year) = True Then
                            If Trim(arr(0)) > 29 Then
                                If blAlertError Then
                                    FunctionClass.HumanoMsgBox("����ѹ����ͧ�դ�����������ҧ 1 �֧ 29")
                                    Exit Function
                                End If
                            End If
                        Else
                            If Trim(arr(0)) > 28 Then
                                If blAlertError Then
                                    FunctionClass.HumanoMsgBox("����ѹ����ͧ�դ�����������ҧ 1 �֧ 28")
                                    Exit Function
                                End If
                            End If
                        End If

                    Case "04", "06", "09", "11"
                        If Trim(arr(0)) > 30 Then
                            FunctionClass.HumanoMsgBox("����ѹ����ͧ�դ�����������ҧ 1 �֧ 30")
                            Exit Function
                        End If

                End Select
            Case "2" '�����ѧ���
                If Len(Trim(strText)) <= 0 Then
                    If Not blAllowNull Then
                        If blAlertError Then
                            FunctionClass.HumanoMsgBox("Null value detected  !!!", MsgBoxStyle.Information)
                            strText = Utility.ConvertDateThai(Today)
                        End If
                    Else
                        CheckDateInput = True
                    End If
                    Exit Function
                End If

                If Len(Trim(strText)) <> 10 And Len(Trim(strText)) <> 8 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox(strPrompt & " Invalid Date format (dd/mm/yyyy)", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Len(Trim(strText)) = 8 Then
                    strText = strText.Substring(0, 2) & "/" & strText.Substring(2, 2) & "/" & strText.Substring(4)
                End If

                Dim arr As String() = strText.Split("/")
                If arr.Length <> 3 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox(strPrompt & " Invalid Date format (dd/mm/yyyy)", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Not (Len(Trim(arr(0))) = 2 And Len(Trim(arr(1))) = 2 And Len(Trim(arr(2))) = 4) Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox(strPrompt & " Invalid Date format (dd/mm/yyyy)", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Trim(arr(0)) > 31 Or Trim(arr(0)) < 1 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox("Day value " & strPrompt & "  is between 1 to  31 ", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Trim(arr(1)) > 12 Or Trim(arr(1)) < 1 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox("Month value " & strPrompt & " is between 1 to 12 ", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If

                If Trim(arr(2)) < 1900 Then
                    If blAlertError Then
                        FunctionClass.HumanoMsgBox("Year value " & strPrompt & " is more than Christian 1900", MsgBoxStyle.Information)
                    End If
                    Exit Function
                End If
                '����� 28 OR 29
                Dim year As Integer = CInt(Trim(arr(2)))
                If CInt(Trim(arr(2))) > 2500 Then year = CInt(Trim(arr(2))) - 543

                Select Case Trim(arr(1))
                    Case "02"
                        If Date.IsLeapYear(year) = True Then
                            If Trim(arr(0)) > 29 Then
                                If blAlertError Then
                                    FunctionClass.HumanoMsgBox("Day value is between 1 to 29")
                                    Exit Function
                                End If
                            End If
                        Else
                            If Trim(arr(0)) > 28 Then
                                If blAlertError Then
                                    FunctionClass.HumanoMsgBox("Day value is between 1 to 28")
                                    Exit Function
                                End If
                            End If
                        End If

                    Case "04", "06", "09", "11"
                        If Trim(arr(0)) > 30 Then
                            FunctionClass.HumanoMsgBox("Day value is between 1 to 30")
                            Exit Function
                        End If
                End Select
            Case Else
        End Select

        CheckDateInput = True
    End Function

    Public Shared Function CheckTimeInput(ByRef strSntDate As String, Optional ByVal blAlertError As Boolean = True, _
    Optional ByVal blAllowNull As Boolean = True, Optional ByVal strFieldName As String = "") As Boolean
        CheckTimeInput = False

        Dim msgErrFormat = "Invalid Time format (HH:MM:SS)"

        If Len(Trim(strSntDate)) <= 0 Then
            If Not blAllowNull Then
                If blAlertError Then
                    FunctionClass.HumanoMsgBox("Null value detected", MsgBoxStyle.Information)
                End If
            Else
                CheckTimeInput = True
            End If
            Exit Function
        End If

        If Len(Trim(strSntDate)) <> 8 And Len(Trim(strSntDate)) <> 6 Then
            If blAlertError Then
                FunctionClass.HumanoMsgBox(msgErrFormat, MsgBoxStyle.Information)
            End If
            Exit Function
        End If

        strSntDate = Trim(strSntDate)

        If Len(strSntDate) = 6 Then
            strSntDate = strSntDate.Substring(0, 2) & ":" & strSntDate.Substring(2, 2) & ":" & strSntDate.Substring(4)
        End If

        Dim arr As String() = strSntDate.Split(":")
        If arr.Length <> 3 Then
            If blAlertError Then
                FunctionClass.HumanoMsgBox(msgErrFormat, MsgBoxStyle.Information)
            End If
            Exit Function
        End If

        If Not (Len(Trim(arr(0))) = 2 And Len(Trim(arr(1))) = 2 And Len(Trim(arr(2))) = 2) Then
            If blAlertError Then
                FunctionClass.HumanoMsgBox(msgErrFormat, MsgBoxStyle.Information)
            End If
            Exit Function
        End If

        If Trim(arr(0)) > 23 Or Trim(arr(0)) < 0 Then
            If blAlertError Then
                FunctionClass.HumanoMsgBox("'Invalid time format (Hour value between 0-23)", MsgBoxStyle.Information)
            End If
            Exit Function
        End If

        If Trim(arr(1)) > 59 Or Trim(arr(1)) < 0 Then
            If blAlertError Then
                FunctionClass.HumanoMsgBox("'Invalid time format (Minute value between 0-59)", MsgBoxStyle.Information)
            End If
            Exit Function
        End If

        If Trim(arr(2)) > 59 Or Trim(arr(2)) < 0 Then
            If blAlertError Then
                FunctionClass.HumanoMsgBox("'Invalid Date format (Second value between 0-59)", MsgBoxStyle.Information)
            End If
            Exit Function
        End If

        CheckTimeInput = True
    End Function

    Public Shared Function DateToDBMysql(ByVal sntDate As DateTime) As String
        Return Format(sntDate, "yyyy-MM-dd")
    End Function

    Public Shared Function CheckTimeInput(ByRef ctrlTime As TextBox, Optional ByVal blAlertError As Boolean = True, _
    Optional ByVal blAllowNull As Boolean = True, Optional ByVal strFieldName As String = "") As Boolean
        CheckTimeInput = False
        If Not CheckTimeInput(ctrlTime.Text, blAlertError, blAllowNull) Then
            ctrlTime.Text = ""
            ctrlTime.Focus()
            Exit Function
        End If

        CheckTimeInput = True
    End Function

    '������Ѻ Convert �ѹ���������� dd/MM/yyyy
    Public Shared Function ConvertDateThai(ByVal strDate1 As String)
        Dim strDate As Date = CDate(strDate1)
        Dim dd, mm, yy As String
        Try
            dd = Format(strDate.Day, "00")
            mm = Format(Month(strDate), "00")
            yy = strDate.Year + 543

            Return dd & "/" & mm & "/" & yy
        Catch ex As Exception
            Return "00/00/0000"
        End Try
    End Function

    'Year 2003 - �Ѩ�غѹ
    Public Shared Function dtYearNow() As DataSet
        Dim i As Integer
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add("Year")

        If Now.Year > 2500 Then
            '----------------------
            dr = dt.NewRow
            dr.Item("Year") = "- ���͡ �� �.�. -"
            dr.Item("Year") = ""
            dt.Rows.Add(dr)
            '----------------------
            For i = Year(Now) - 10 To Year(Now) + 10
                dr = dt.NewRow
                dr.Item("Year") = Format(i, "0000")
                dt.Rows.Add(dr)
            Next
            ds.Tables.Add(dt)
        Else
            '----------------------
            dr = dt.NewRow
            dr.Item("Year") = "- ���͡ �� �.�. -"
            dr.Item("Year") = ""
            dt.Rows.Add(dr)
            '----------------------
            For i = (Now.Year + 543) - 10 To (Now.Year + 543) + 10
                dr = dt.NewRow
                dr.Item("Year") = Format(i, "0000")
                dt.Rows.Add(dr)
            Next
            ds.Tables.Add(dt)
        End If

        Return ds
    End Function

    '������Ѻ Convert ��͹
    Public Shared Function convertMonth(ByVal strMonth As String) As String
        Dim tmpDay As String = ""
        If Trim(strMonth) <> "" And Trim(strMonth) <> "---" Then
            Select Case strMonth
                Case "01"
                    tmpDay = "���Ҥ�"
                Case "02"
                    tmpDay = "����Ҿѹ��"
                Case "03"
                    tmpDay = "�չҤ�"
                Case "04"
                    tmpDay = "����¹"
                Case "05"
                    tmpDay = "����Ҥ�"
                Case "06"
                    tmpDay = "�Զع�¹"
                Case "07"
                    tmpDay = "�á�Ҥ�"
                Case "08"
                    tmpDay = "�ԧ�Ҥ�"
                Case "09"
                    tmpDay = "�ѹ��¹"
                Case "10"
                    tmpDay = "���Ҥ�"
                Case "11"
                    tmpDay = "��Ȩԡ�¹"
                Case "12"
                    tmpDay = "�ѹ�Ҥ�"
            End Select
        Else
            tmpDay = "������"
        End If
        Return tmpDay
    End Function

    '������Ѻ�͹ Insert, Update
    Public Shared Function CheckDateNull(ByRef strDateNull As String) As String
        If Trim(strDateNull) <> "" Then
            If Right(strDateNull, 4) < 2400 Then
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4)
                    strDateNull = strYear1 & "-" & strDay1 & "-" & strMonth1
                End If
            Else
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4) - 543
                    strDateNull = strYear1 & "-" & strDay1 & "-" & strMonth1
                End If
            End If
        End If

        If strDateNull = "" Then
            strDateNull = "NULL"
        Else
            strDateNull = "'" & strDateNull & "'"
        End If
        Return strDateNull
    End Function

    '������Ѻ�͹ Search �ѹ���
    Public Shared Function CheckDateSearch(ByRef strDate As String) As String
        Dim obj As Object
        Dim aStr() As String
        aStr = Utility.Readini()

        If Trim(strDate) <> "" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4) - 543
                'strDate = strDay & "-" & strMonth & "-" & strYear
                'strDate = strYear & "-" & strMonth & "-" & strDay
                If aStr(0).ToUpper = "YEAR" And aStr(2).ToUpper = "DAY" And aStr(4).ToUpper = "MONTH" Then
                    strDate = strYear & aStr(1) & strDay & aStr(3) & strMonth
                ElseIf aStr(0).ToUpper = "YEAR" And aStr(2).ToUpper = "MONTH" And aStr(4).ToUpper = "DAY" Then
                    strDate = strYear & aStr(1) & strMonth & aStr(3) & strDay
                End If
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4)
                'strDate = strDay & "-" & strMonth & "-" & strYear
                'strDate = strYear & "-" & strMonth & "-" & strDay
                If aStr(0).ToUpper = "YEAR" And aStr(2).ToUpper = "DAY" And aStr(4).ToUpper = "MONTH" Then
                    strDate = strYear & aStr(1) & strDay & aStr(3) & strMonth
                ElseIf aStr(0).ToUpper = "YEAR" And aStr(2).ToUpper = "MONTH" And aStr(4).ToUpper = "DAY" Then
                    strDate = strYear & aStr(1) & strMonth & aStr(3) & strDay
                End If
            End If
            Return strDate
        End If
    End Function
    '������Ѻ�͹ Search �ѹ���
    Public Shared Function CheckDateSearch_SSO(ByRef strDate As String) As String
        If Trim(strDate) <> "" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4) - 543
                'strDate = strDay & "-" & strMonth & "-" & strYear
                strDate = strYear & "-" & strMonth & "-" & strDay
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4)
                'strDate = strDay & "-" & strMonth & "-" & strYear
                strDate = strYear & "-" & strMonth & "-" & strDay
            End If
            Return strDate
        End If
    End Function
    '������Ѻ Convert �ѹ��� �ѧ���
    Public Shared Function ConvertDateEng(ByVal strDate As String)
        Dim dd, mm, yy As String
        Try
            'yy = Microsoft.VisualBasic.Left(strDate, 4)
            'mm = Microsoft.VisualBasic.Mid(strDate, 6, 2)
            'dd = Microsoft.VisualBasic.Right(strDate, 2)
            yy = Microsoft.VisualBasic.Right(strDate, 4)
            mm = Microsoft.VisualBasic.Mid(strDate, 4, 1)
            dd = Microsoft.VisualBasic.Left(strDate, 2)

            Return dd & "/" & mm & "/" & yy
        Catch ex As Exception
            Return "00/00/0000"
        End Try
    End Function

    Public Shared Function Convert_Culture(ByVal strDate As String, _
                                          ByVal Culture As String)
        If Culture = "en-US" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4) - 543
                'strDate = strDay & "-" & strMonth & "-" & strYear
                strDate = strDay & "/" & strMonth & "/" & strYear
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4)
                strDate = strDay & "/" & strMonth & "/" & strYear
            End If

        ElseIf Culture = "th-TH" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4)
                'strDate = strDay & "-" & strMonth & "-" & strYear
                strDate = strDay & "/" & strMonth & "/" & strYear
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4) + 543
                strDate = strDay & "/" & strMonth & "/" & strYear
            End If
        End If
        Return strDate
    End Function
    Public Shared Function Convert_Culture_Year(ByVal strDate As String, _
                                       ByVal Culture As String)
        Dim strYear As String
        If Culture = "en-US" Then
            If Right(strDate, 4) > 2400 Then
                strYear = Right(strDate, 4) - 543
                strDate = strYear
            Else
                strYear = Right(strDate, 4)
                strDate = strYear
            End If
        ElseIf Culture = "th-TH" Then
            If Right(strDate, 4) > 2400 Then
                strYear = Right(strDate, 4)
                strDate = strYear
            Else
                strYear = Right(strDate, 4) + 543
                strDate = strYear
            End If
        End If
        Return strDate
    End Function
    Public Shared Function Convert_Culture_Month_Year(ByVal strDate As String, _
                                      ByVal Culture As String)
        Dim strYear, strMonth As String
        If Culture = "en-US" Then
            If Right(strDate, 4) > 2400 Then
                strYear = Right(strDate, 4) - 543
                strMonth = Mid(strDate, 4, 2)
                strDate = strMonth & "/" & strYear
            Else
                strYear = Right(strDate, 4)
                strMonth = Mid(strDate, 4, 2)
                strDate = strMonth & "/" & strYear
            End If
        ElseIf Culture = "th-TH" Then
            If Right(strDate, 4) > 2400 Then
                strYear = Right(strDate, 4)
                strMonth = Mid(strDate, 4, 2)
                strDate = strMonth & "/" & strYear
            Else
                strYear = Right(strDate, 4) + 543
                strMonth = Mid(strDate, 4, 2)
                strDate = strMonth & "/" & strYear
            End If
        End If
        Return strDate
    End Function

    Public Shared Function convertMonth_EN(ByVal strMonth As String) As String
        Dim tmpDay As String = ""
        If Trim(strMonth) <> "" And Trim(strMonth) <> "---" Then
            Select Case strMonth
                Case "01"
                    tmpDay = "January"
                Case "02"
                    tmpDay = "February"
                Case "03"
                    tmpDay = "March"
                Case "04"
                    tmpDay = "April"
                Case "05"
                    tmpDay = "May"
                Case "06"
                    tmpDay = "June"
                Case "07"
                    tmpDay = "July"
                Case "08"
                    tmpDay = "August"
                Case "09"
                    tmpDay = "September"
                Case "10"
                    tmpDay = "October"
                Case "11"
                    tmpDay = "November"
                Case "12"
                    tmpDay = "December"
            End Select
        Else
            tmpDay = "������"
        End If
        Return tmpDay
    End Function
    Public Shared Function Convert_FullDate(ByVal strDate As String, ByVal Lang_Index As String, _
                                            ByVal Culture As String)
        If CInt(Lang_Index) = 1 Then
            If Culture = "en-US" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) - 543
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " " & strMonth & " " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    strDate = strDay & " " & strMonth & " " & strYear
                End If

            ElseIf Culture = "th-TH" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " " & strMonth & " " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) + 543
                    strDate = strDay & " " & strMonth & " " & strYear
                End If

            End If
        Else
            If Culture = "en-US" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) - 543
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " " & strMonth & " " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    strDate = strDay & " " & strMonth & " " & strYear
                End If

            ElseIf Culture = "th-TH" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " " & strMonth & " " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) + 543
                    strDate = strDay & " " & strMonth & " " & strYear
                End If

            End If
        End If

        Return strDate
    End Function
    Public Shared Function Convert_FullyDate(ByVal strDate As String, ByVal Lang_Index As String, _
                                           ByVal Culture As String)
        'ex '01 ���Ҥ� �.� 2555'
        If CInt(Lang_Index) = 1 Then
            If Culture = "en-US" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) - 543
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " " & strMonth & "  " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    strDate = strDay & " " & strMonth & " " & strYear
                End If

            ElseIf Culture = "th-TH" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " ��͹ " & strMonth & " �.� " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) + 543
                    strDate = strDay & " ��͹ " & strMonth & " �.� " & strYear
                End If

            End If
        Else
            If Culture = "en-US" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) - 543
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " " & strMonth & " " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    strDate = strDay & " " & strMonth & " " & strYear
                End If

            ElseIf Culture = "th-TH" Then
                If Right(strDate, 4) > 2400 Then
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4)
                    'strDate = strDay & "-" & strMonth & "-" & strYear
                    strDate = strDay & " " & strMonth & " " & strYear
                Else
                    Dim strDay, strMonth, strYear As String
                    strDay = Left(strDate, 2)
                    strMonth = convertMonth_EN(Mid(strDate, 4, 2))
                    strYear = Right(strDate, 4) + 543
                    strDate = strDay & " " & strMonth & " " & strYear
                End If

            End If
        End If

        Return strDate
    End Function
    Public Shared Function GetLastDayOfMonth(ByVal CurrentDate As DateTime) As DateTime
        With CurrentDate
            Return (New DateTime(.Year, .Month, Date.DaysInMonth(.Year, .Month)))
        End With
    End Function
    Public Shared Function Convert_DC(ByVal strDate As String)

        If Right(strDate, 4) > 2400 Then
            Dim strDay, strMonth, strYear As String
            strDay = Left(strDate, 2)
            strMonth = Mid(strDate, 4, 2)
            strYear = Right(strDate, 4) - 543
            'strDate = strDay & "-" & strMonth & "-" & strYear
            strDate = strDay & "/" & strMonth & "/" & strYear
        Else
            Dim strDay, strMonth, strYear As String
            strDay = Left(strDate, 2)
            strMonth = Mid(strDate, 4, 2)
            strYear = Right(strDate, 4)
            strDate = strDay & "/" & strMonth & "/" & strYear
        End If

        Return strDate
    End Function
#End Region

#Region "Misc"
    Public Shared Function SetNumberFrontZero(ByVal IntNumber As Integer, ByVal NumberOfZero As Integer) As String
        Dim i As Integer
        Dim strZero As String
        If Len(NumberOfZero) <= 0 Then
            Exit Function
        Else
            For i = Len(CStr(IntNumber)) To NumberOfZero - 1
                strZero = "0" & strZero
            Next
            Return strZero & CStr(IntNumber)
        End If
    End Function

    Public Shared Function GetUserName() As String
        Return "Lspice"
    End Function

    Public Shared Function ConvertStrToInt(ByVal strNum As String) As Integer
        If IsNothing(strNum) Or Trim(strNum) = "" Then
            Return 0
        Else
            Return CInt(strNum)
        End If
    End Function

    Public Shared Function ChangeNullToDB(ByVal StrVal As String) As String
        If Trim(StrVal) = "" Then
            ChangeNullToDB = "NULL"
        Else
            ChangeNullToDB = StrVal
        End If
    End Function

    Public Shared Function gReAll(ByVal strData As String) As String
        If Len(Trim(strData)) > 0 Then
            strData = strData.Trim
            Return strData.Replace("'", "''").Replace("\", "\\")
        Else
            Return strData
        End If
    End Function

    Public Shared Sub DoubleKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 46, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8, 127
            Case Else
                e.Handled = True
        End Select
    End Sub

    Public Class DateSQLServer
        Inherits SQLServerconnection
        Private Shared DateSQLServer As New Utility.DateSQLServer
        Public Function GetDateNowDB() As DataSet
            Dim strsql As String
            strSQL = "SELECT CONVERT (varchar,GETDATE(),23) AS DateNowDB, " & _
                     "Convert (varchar, Getdate(),20) as dateTimeNowDB"
            Return SQL_Dataset(strSQL)
        End Function

        Public Shared Function GetDateToday() As String
            Dim dtDate As DataTable
            dtDate = DateSQLServer.GetDateNowDB.Tables(0)
            If Trim(dtDate.Rows.Count) & "" > 0 Then
                GetDateToday = Trim(dtDate.Rows(0)("DateNowDB")) & ""
            End If
        End Function
    End Class

    '������Ѻ Get �ѹ���Ѩ�غѹ����
    Public Shared Function GetDateToday() As String
        GetDateToday = Format(Today.Year, "0000") & "-" & Format(Today.Month, "00") & "-" & Format(Today.Day, "00")
    End Function

    '������Ѻ Get �ѹ��� ������һѨ�غѹ����
    Public Shared Function GetDateTimeToday() As String
        GetDateTimeToday = Today.Year & "-" & Today.Month & "-" & Today.Day & " " & TimeOfDay
    End Function

    Public Shared Function ChangeDateFromBase(ByVal strDate As Date) As String
        If Len(Trim(strDate)) > 0 Then
            If Len(Trim(strDate.Day)) = 1 Then
                ChangeDateFromBase = ChangeDateFromBase & "0" & strDate.Day & "/"
            Else
                ChangeDateFromBase = ChangeDateFromBase & strDate.Day & "/"
            End If

            If Len(Trim(strDate.Month)) = 1 Then
                ChangeDateFromBase = ChangeDateFromBase & "0" & strDate.Month & "/" & strDate.Year
            Else
                ChangeDateFromBase = ChangeDateFromBase & strDate.Month & "/" & strDate.Year
            End If
        Else
            ChangeDateFromBase = ""
        End If
    End Function

    Public Shared Function ChangeDateFromYear(ByVal strDate As String) As String
        Dim strDayMonth, strYear As String
        If Len(Trim(strDate)) > 0 And IsDate(strDate) Then
            If CInt(strDate.Substring(6, 4)) < 2100 Then
                strDayMonth = strDate.Substring(0, 6)
                strYear = CInt(strDate.Substring(6, 4)) + 543
                ChangeDateFromYear = strDayMonth & strYear
            Else
                ChangeDateFromYear = strDate
            End If
        Else
            ChangeDateFromYear = ""
        End If
    End Function

    Public Shared Function ChangeDateFromYear(ByVal strDate As String, ByVal Update20050422 As String) As Date
        Dim c As New Globalization.CultureInfo("en-US")
        c.DateTimeFormat.LongDatePattern = "yyyyMMdd"
        Dim curci As New Globalization.CultureInfo("th-TH")
        Dim dtf As Globalization.DateTimeFormatInfo = curci.DateTimeFormat
        Dim SpecialDate As Date

        SpecialDate = Date.ParseExact(strDate, "d", c.DateTimeFormat, dtf.ShortDatePattern)
    End Function

    'change date from format yyyy-m-d to yyyy-mm-dd
    Public Shared Function ChangeDate(ByVal strDate1 As String) As String
        Dim strDate As Date = CDate(strDate1)

        If Len(Trim(strDate)) > 0 Then
            ChangeDate = strDate1.Substring(0, 4) & "-"

            If Len(Trim(strDate.Month)) = 1 Then
                ChangeDate = ChangeDate & "0" & strDate.Month & "-"
            Else
                ChangeDate = ChangeDate & strDate.Month & "-"
            End If

            If Len(Trim(strDate.Day)) = 1 Then
                ChangeDate = ChangeDate & "0" & strDate.Day
            Else
                ChangeDate = ChangeDate & strDate.Day
            End If
        Else
            ChangeDate = ""
        End If

    End Function

    'change date from format yyyy-m-d to yyyy-mm-dd
    Public Shared Function ChangeDatetoMysql(ByVal strDate1 As String) As String
        Try
            Dim strDate As Date = CDate(strDate1)
            If Len(Trim(strDate)) > 0 Then
                ChangeDatetoMysql = strDate.Year & "/"

                If Len(Trim(strDate.Month)) = 1 Then
                    ChangeDatetoMysql = ChangeDatetoMysql & "0" & strDate.Month & "/"
                Else
                    ChangeDatetoMysql = ChangeDatetoMysql & strDate.Month & "/"
                End If

                If Len(Trim(strDate.Day)) = 1 Then
                    ChangeDatetoMysql = ChangeDatetoMysql & "0" & strDate.Day
                Else
                    ChangeDatetoMysql = ChangeDatetoMysql & strDate.Day
                End If
            Else
                ChangeDatetoMysql = ""
            End If

        Catch ex As Exception
            Return "0000-00-00"
        End Try
    End Function

    Public Shared Function ConvertDateThaiSQL_Server(ByVal strDate1 As String)
        Dim strDate As Date = CDate(strDate1)
        Dim dd, mm, yy As String
        Try
            dd = Format(strDate.Day, "00")
            mm = Format(Month(strDate), "00")
            yy = strDate.Year - 543

            Return dd & "/" & mm & "/" & yy
        Catch ex As Exception
            Return "00/00/0000"
        End Try
    End Function

    Public Shared Function GetDateFromText(ByVal strTextDate As String, ByVal strDateFormat As String) As Date
        Try
            Dim c As New Globalization.CultureInfo("en-US")
            c.DateTimeFormat.LongDatePattern = strDateFormat
            GetDateFromText = Date.ParseExact(strTextDate, "D", c)
        Catch ex As Exception
        End Try
    End Function

    '������Ѻ Convert �ѹ����µ͹ Show Data
    Public Shared Function ConvertDateToShow(ByVal DateTime As DateTime) As String
        Dim RetDateTime As String
        RetDateTime = DateTime.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("th").DateTimeFormat)
        Return RetDateTime
    End Function

    '������Ѻ Convert �ѹ��� ��� ���� �µ͹ Show Data
    Public Shared Function ConvertTimeToShow(ByVal DateTime As DateTime) As String
        Dim RetDateTime As String
        RetDateTime = DateTime.ToString("hh:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("th").DateTimeFormat)
        Return RetDateTime
    End Function
    Public Shared Function sqlDateTimeFormat_SQLServer(Optional ByVal strDateTime As String = "") As String
        Try
            strDateTime = CDate(strDateTime)
            Return IIf(CInt(Year(strDateTime)) > 2400, CInt(Year(strDateTime)) - 543, CInt(Year(strDateTime))) & "-" & Microsoft.VisualBasic.Month(strDateTime) & "-" & Microsoft.VisualBasic.Day(strDateTime)
        Catch ex As Exception
            Return "00-00-0000"
        End Try
    End Function
#End Region


    Public Class ThaiBaht
        '���¡�� �� TextBox1.Text = Utility.ThaiBaht.Convert(Convert.ToDecimal(net))
        Public Shared Function Convert(ByVal net As Decimal) As String
            Dim amt_num, amt_chr As String
            Dim aTable As String() = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}

            Dim Field As String = ""

            amt_num = Math.Abs(net).ToString("###0.00").ToCharArray
            amt_chr = LTrim(amt_num)
            amt_chr.Substring(0)
            Dim cnt As Integer = 1
            Do While cnt <= 15
                If amt_chr.Substring(cnt - 1, 1) = "." Or amt_chr.Substring(cnt - 1, 1) = "" Then
                    Exit Do
                End If
                If amt_chr.Substring(cnt - 1, 1) = "1" Then
                    Field = "˹��"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "2" Then
                    Field = "�ͧ"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "3" Then
                    Field = "���"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "4" Then
                    Field = "���"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "5" Then
                    Field = "���"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "6" Then
                    Field = "ˡ"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "7" Then
                    Field = "��"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "8" Then
                    Field = "Ỵ"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "9" Then
                    Field = "���"
                End If
                If amt_chr.Substring(cnt - 1, 1) = "0" Then
                    Field = ""
                End If
                aTable.SetValue(Field, cnt - 1)
                cnt = cnt + 1
            Loop

            Dim netchr As String = ""
            Dim perd_col As Integer = cnt

            amt_num = String.Concat(aTable)
            Do While cnt <> 0
                cnt = cnt - 1
                Field = aTable(cnt)
                Dim col = perd_col - cnt - 1

                If (col = 1) And aTable(cnt) <> "" Then
                    If aTable(cnt) = "˹��" Then
                        If cnt = 0 Then
                            netchr = aTable(cnt)
                        Else
                            If aTable(cnt - 1) = "" Then
                                netchr = "˹��"
                            Else
                                netchr = "���"
                            End If
                        End If
                    Else
                        netchr = Trim(aTable(cnt))
                    End If
                End If
                If (col = 2 Or col = 8) And aTable(cnt) <> "" Then
                    If aTable(cnt) = "˹��" Then
                        netchr = "�Ժ" + Trim(netchr)
                    Else
                        If aTable(cnt) = "�ͧ" Then
                            netchr = "����Ժ" + Trim(netchr)
                        Else
                            netchr = Trim(aTable(cnt)) + "�Ժ" + Trim(netchr)
                        End If
                    End If
                End If
                If (col = 3 Or col = 9) And aTable(cnt) <> "" Then
                    netchr = Trim(aTable(cnt)) + "����" + Trim(netchr)
                End If
                If (col = 4 Or col = 10) And aTable(cnt) <> "" Then
                    netchr = Trim(aTable(cnt)) + "�ѹ" + Trim(netchr)
                End If
                If (col = 5 Or col = 11) And aTable(cnt) <> "" Then
                    netchr = Trim(aTable(cnt)) + "����" + Trim(netchr)
                End If
                If (col = 6 Or col = 12) And aTable(cnt) <> "" Then
                    netchr = Trim(aTable(cnt)) + "�ʹ" + Trim(netchr)
                End If
                If (col = 7 Or col = 13) Then
                    If aTable(cnt) = "˹��" Then
                        If cnt = 0 Then
                            netchr = Trim(aTable(cnt)) + "��ҹ" + Trim(netchr)
                        Else
                            netchr = "�����ҹ" + Trim(netchr)
                        End If
                    Else
                        netchr = Trim(aTable(cnt)) + "��ҹ" + Trim(netchr)
                    End If
                End If
            Loop
            amt_chr.Substring(perd_col)
            If amt_chr.Substring(perd_col - 1, 1) = "." Then
                If amt_chr.Substring(perd_col, 2) <> "00" Then
                    netchr = Trim(netchr) + "�ҷ"
                    If perd_col = 2 And amt_chr.Substring(perd_col + 1, 1) = "0" Then
                        netchr = ""
                    End If
                    If amt_chr.Substring(perd_col, 1) = "1" Then
                        netchr = Trim(netchr) + "�Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "2" Then
                        netchr = Trim(netchr) + "����Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "3" Then
                        netchr = Trim(netchr) + "����Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "4" Then
                        netchr = Trim(netchr) + "����Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "5" Then
                        netchr = Trim(netchr) + "����Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "6" Then
                        netchr = Trim(netchr) + "ˡ�Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "7" Then
                        netchr = Trim(netchr) + "���Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "8" Then
                        netchr = Trim(netchr) + "Ỵ�Ժ"
                    End If
                    If amt_chr.Substring(perd_col, 1) = "9" Then
                        netchr = Trim(netchr) + "����Ժ"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "1" And amt_chr.Substring(perd_col, 1) = "0" Then
                        netchr = Trim(netchr) + "˹��"
                    Else
                        If amt_chr.Substring(perd_col + 1, 1) = "1" And amt_chr.Substring(perd_col, 1) <> "0" Then
                            netchr = Trim(netchr) + "���"
                        End If
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "2" Then
                        netchr = Trim(netchr) + "�ͧ"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "3" Then
                        netchr = Trim(netchr) + "���"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "4" Then
                        netchr = Trim(netchr) + "���"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "5" Then
                        netchr = Trim(netchr) + "���"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "6" Then
                        netchr = Trim(netchr) + "ˡ"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "7" Then
                        netchr = Trim(netchr) + "��"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "8" Then
                        netchr = Trim(netchr) + "Ỵ"
                    End If
                    If amt_chr.Substring(perd_col + 1, 1) = "9" Then
                        netchr = Trim(netchr) + "���"
                    End If
                    netchr = Trim(netchr) + "ʵҧ��"
                Else
                    netchr = Trim(netchr) + "�ҷ��ǹ"
                End If
            Else
                netchr = Trim(netchr) + "�ҷ��ǹ"
            End If

            Convert = netchr
        End Function
    End Class

    Public Class ReAllSQL
        Public Shared Function gReAll(ByVal inputText As String) As String
            If Len(Trim(inputText)) > 0 Then
                inputText = inputText.Trim
                Return inputText.Replace("'", "''").Replace("\", "\\")
            Else
                Return inputText
            End If
        End Function
    End Class
    '������Ѻ �� Day Of Week
    Public Shared Function DayOfWeek(ByVal strMonth As Date) As String
        Dim tmpDay As String = DatePart(DateInterval.Weekday, strMonth)

        Select Case tmpDay
            Case "2"
                tmpDay = "�ѹ�ѹ���"
            Case "3"
                tmpDay = "�ѹ�ѧ���"
            Case "4"
                tmpDay = "�ѹ�ظ"
            Case "5"
                tmpDay = "�ѹ����ʺ��"
            Case "6"
                tmpDay = "�ѹ�ء��"
            Case "7"
                tmpDay = "�ѹ�����"
            Case "1"
                tmpDay = "�ѹ�ҷԵ��"
        End Select

        Return tmpDay
    End Function
    Public Shared Function FindMaxDataTableValue(ByRef dt As DataTable, ByVal index_column As Integer) As Integer
        Dim currentValue As Integer, maxValue As Integer
        Dim dv As DataView = dt.DefaultView
        '  For c As Integer = 0 To dt.Columns.Count - 1
        dv.Sort = dt.Columns(index_column).ColumnName + " DESC"
        currentValue = CInt(dv(0).Item(index_column))
        If currentValue > maxValue Then maxValue = currentValue
        ' Next
        Return maxValue
    End Function
    Public Shared Function FindMinDataTableValue(ByRef dt As DataTable, ByVal index_column As Integer) As Integer
        Dim currentValue As Integer, maxValue As Integer
        Dim dv As DataView = dt.DefaultView
        '  For c As Integer = 0 To dt.Columns.Count - 1
        dv.Sort = dt.Columns(index_column).ColumnName + " ASC"
        currentValue = CInt(dv(0).Item(index_column))
        If currentValue > maxValue Then maxValue = currentValue
        ' Next
        Return maxValue
    End Function
    Public Shared Function ConvertStrToDouble(ByVal strNum As String) As String

        If IsNothing(strNum) Or Trim(strNum) = "" Then

            strNum = ""
            Return strNum
        Else
            Dim a As Double = strNum
            strNum = Format(a, "#,###,###,##0.00")
            Return strNum
        End If
    End Function
End Class