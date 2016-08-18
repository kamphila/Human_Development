Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Net.Dns
Imports System.Configuration
Imports System.Threading
Imports System.Globalization
Public Class cls_myfunc
    Dim encript As New LionEncript.LionEncript
    Dim SqlDb As New Cls_SqlDB
    Dim username As String = ""
    Public Property Config() As SortedList
        Get
            Return ConfigValue
        End Get
        Set(ByVal value As SortedList)
            ConfigValue = value
            App_Path = ConfigValue.Item("Application Path")
            App_Name = ConfigValue.Item("Application Name")
            Service_Type = CInt(ConfigValue.Item("Service Type"))
            PageLimit = ConfigValue.Item("Page Limit")
            Lang_Index = CInt(ConfigValue.Item("Language Index"))
            username = ConfigValue("Username")

            If username = "HROD" Then
                gb_empcd = "HROD"
                gb_userloginid = "HROD"
            Else
                gb_empcd = SqlDb.GetDataTable("SELECT person_id from user_login where username='" & username & "'").Rows(0)(0).ToString
                gb_userloginid = SqlDb.GetDataTable("SELECT id from user_login where username='" & username & "'").Rows(0)(0).ToString
            End If
            gb_corpid = ConfigValue("Corporate ID")
            gb_date = SqlDb.GetDateTime_String.ToString()
            gb_Login_Session = ConfigValue.Item("Login Session")
            gb_User_Session = ConfigValue.Item("User Session")
            gb_Lang = CInt(ConfigValue.Item("Language Index"))
            gb_Culture = ConfigValue.Item("Corporate Culture")

            'Thread.CurrentThread.CurrentCulture = New CultureInfo(gb_Culture)
            'Thread.CurrentThread.CurrentUICulture = New CultureInfo(gb_Culture)
            'System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture(gb_Culture)
            'System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture

            System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

            'If gb_Lang = 1 Then
            '    gb_Culture = "th-TH"
            'Else
            '    gb_Culture = "en-US"
            'End If
            'gb_date = SqlDb.GetDataTable("SELECT convert(varchar(30),getdate(),120)").Rows(0)(0).ToString
            'gb_date = SqlDb.GetDataTable("SELECT convert(varchar(30),getdate(),105)+' '+convert(varchar(30),getdate(),108)").Rows(0)(0).ToString
        End Set
    End Property
    Public Function f_rpl_pk(ByVal value)
        Return value.Replace("'", "")
    End Function
    Public Function f_rpl_date(ByVal value)
        Return value.Replace("'", "''")
    End Function
    Public Function f_rpl_number(ByVal value)
        Return value
    End Function
    Public Function f_rpl_text(ByVal value)
        Return value.Replace("'", "''")
    End Function
    Public Function field_chk_null(ByVal value)
        If IsNothing(value) Then
            Return ""
        Else
            Return value

        End If
    End Function
    Public Function check_datetime(ByVal value)
        If value = "" Then
            Return "NULL"
        Else
            Return "'" + value + "'"
        End If
    End Function
    Public Function check_number(ByVal value)
        If value = "" Then
            Return "0"
        Else
            Return value.Replace(",", "")
        End If
    End Function
    Public Function check_decimal(ByVal value)
        If value = "" Then
            Return "0.00"
        Else
            Return value.Replace(",", "")
        End If
    End Function
    Public Function CheckDateNull(ByVal strDateNull)
        'strDateNull = Format(cNull(strDateNull, "String"), "dd/MM/yyyy")
        If Trim(strDateNull) <> "" Then
            If Right(strDateNull, 4) < 2400 Then
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4)
                    strDateNull = strYear1 & "-" & strDay1 & "-" & strMonth1
                    'strDateNull = strYear1 & "-" & strMonth1 & "-" & strDay1
                End If
            Else
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4) - 543
                    strDateNull = strYear1 & "-" & strDay1 & "-" & strMonth1
                    'strDateNull = strYear1 & "-" & strMonth1 & "-" & strDay1
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
    Public Function CheckDateNull1(ByVal strDateNull)
        If Trim(strDateNull) <> "" Then
            If Right(strDateNull, 4) < 2400 Then
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4)
                    strDateNull = strDay1 & "-" & strMonth1 & "-" & strYear1
                    'strDateNull = strYear1 & "-" & strMonth1 & "-" & strDay1
                End If
            Else
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4) - 543
                    strDateNull = strDay1 & "-" & strMonth1 & "-" & strYear1
                    'strDateNull = strYear1 & "-" & strMonth1 & "-" & strDay1
                End If
            End If
        End If

        'If Trim(strDateNull) <> "" Then
        '    Dim strDay1, strMonth1, strYear1 As String
        '    strDay1 = Left(Trim(strDateNull), 2)
        '    strMonth1 = Mid(Trim(strDateNull), 4, 2)
        '    strYear1 = Right(Trim(strDateNull), 4)
        '    strDateNull = strDay1 & "-" & strMonth1 & "-" & strYear1
        '    'strDateNull = strYear1 & "-" & strMonth1 & "-" & strDay1
        'End If

        If strDateNull = "" Then
            strDateNull = "NULL"
        Else
            strDateNull = "'" & strDateNull & "'"
        End If
        Return strDateNull
    End Function

    Public Function CheckDateNull2(ByVal strDateNull)
        If Trim(strDateNull) <> "" Then
            If Right(strDateNull, 4) < 2400 Then
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4)
                    'strDateNull = strYear1 & "-" & strDay1 & "-" & strMonth1
                    strDateNull = strYear1 & "-" & strMonth1 & "-" & strDay1
                End If
            Else
                If Left(Utility.GetDateToday, 4) < 2400 Then
                    Dim strDay1, strMonth1, strYear1 As String
                    strDay1 = Left(Trim(strDateNull), 2)
                    strMonth1 = Mid(Trim(strDateNull), 4, 2)
                    strYear1 = Right(Trim(strDateNull), 4) - 543
                    'strDateNull = strYear1 & "-" & strDay1 & "-" & strMonth1
                    strDateNull = strYear1 & "-" & strMonth1 & "-" & strDay1
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

    Public Shared Function Convert_Culture(ByVal strDate As String, _
                                         ByVal Culture As String)
        If Culture = "en-US" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4) - 543
                strDate = strDay & "/" & strMonth & "/" & strYear
                'strDate = strMonth & "/" & strDay & "/" & strYear
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4)
                strDate = strDay & "/" & strMonth & "/" & strYear
                'strDate = strMonth & "/" & strDay & "/" & strYear
            End If

        ElseIf Culture = "th-TH" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                'strMonth = convertMonth(strMonth)
                strYear = Right(strDate, 4) + 543
                strDate = strDay & "/" & strMonth & "/" & strYear
                'strDate = strMonth & "/" & strDay & "/" & strYear
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                'strMonth = convertMonth(strMonth)
                strYear = Right(strDate, 4) + 543
                strDate = strDay & "/" & strMonth & "/" & strYear
                'strDate = strMonth & "/" & strDay & "/" & strYear
            End If
        End If
        Return strDate
    End Function
    Public Shared Function Convert_Culture_YMD(ByVal strDate As String, _
                                         ByVal Culture As String)
        If Culture = "en-US" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4) - 543
                strDate = strYear & "-" & strMonth & "-" & strDay
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                strYear = Right(strDate, 4)
                strDate = strYear & "-" & strMonth & "-" & strDay
            End If

        ElseIf Culture = "th-TH" Then
            If Right(strDate, 4) > 2400 Then
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                'strMonth = convertMonth(strMonth)
                strYear = Right(strDate, 4) + 543
                strDate = strYear & "-" & strMonth & "-" & strDay
            Else
                Dim strDay, strMonth, strYear As String
                strDay = Left(strDate, 2)
                strMonth = Mid(strDate, 4, 2)
                'strMonth = convertMonth(strMonth)
                strYear = Right(strDate, 4) + 543
                strDate = strYear & "-" & strMonth & "-" & strDay
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
    Public Shared Function convertMonth(ByVal strMonth As String)
        Dim tmpDay As String = ""
        If Trim(strMonth) <> "" And Trim(strMonth) <> "---" Then
            Select Case strMonth
                Case "01"
                    tmpDay = "มกราคม"
                Case "02"
                    tmpDay = "กุมภาพันธ์"
                Case "03"
                    tmpDay = "มีนาคม"
                Case "04"
                    tmpDay = "เมษายน"
                Case "05"
                    tmpDay = "พฤษภาคม"
                Case "06"
                    tmpDay = "มิถุนายน"
                Case "07"
                    tmpDay = "กรกฎาคม"
                Case "08"
                    tmpDay = "สิงหาคม"
                Case "09"
                    tmpDay = "กันยายน"
                Case "10"
                    tmpDay = "ตุลาคม"
                Case "11"
                    tmpDay = "พฤศจิกายน"
                Case "12"
                    tmpDay = "ธันวาคม"
            End Select
        Else
            tmpDay = "ทั้งหมด"
        End If
        Return tmpDay
    End Function
End Class
