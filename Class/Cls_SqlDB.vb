Imports System
Imports System.Data
Imports System.Text
Imports System.Data.Sql
Imports System.Collections
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration.Assemblies
Imports System.IO
Imports Microsoft.Win32
Imports System.Globalization
Imports System.Security.Cryptography

Public Class Cls_SqlDB
    Private cnn As OleDbConnection
    Private trn As OleDbTransaction
    Private adp As OleDbDataAdapter
    Private IsoLevel As IsolationLevel = IsolationLevel.ReadUncommitted
    Private strConnectString As String = ""
    Public gnKeyFieldLen As Integer = 20

    Private Function GetConnectionString() As String
        Dim servername As String = ""
        Dim dbname As String = ""
        Dim userid As String = ""
        Dim password As String = ""
        Dim i As Integer
        Dim a(20) As String
        Dim myTextFile As New StreamReader(GBApp_Path & "humanoDB.ini")
        Try
            Do
                a(i) = myTextFile.ReadLine
                i = i + 1
            Loop Until myTextFile.Peek = -1
            'ConnString = "server=" & a(5) & ";uid=" & a(7) & ";password=humano" & ";database=" & a(3) & ";Max Pool size=400;Connect Timeout=600;Connection Lifetime=600;"

            Dim encript As New LionEncript.LionEncript
            servername = a(5)
            'servername = "SERVER\sqlexpress"
            dbname = a(3)
            userid = a(7)
            password = encript.Decode(a(9), 2)
            'servername = "CHOKHON\SQL2005"
            'dbname = "humano1"
            'userid = "sa"
            'password = "123456"
        Catch
        Finally
            myTextFile.Close()
        End Try
        Dim strServerName As String = Convert.ToString(servername)
        Dim strUserID As String = Convert.ToString(userid)
        Dim strPassword As String = Convert.ToString(password)
        Dim strDatabaseName As String = Convert.ToString(dbname)
        'Dim strServerName As String = Convert.ToString(".\SQL2008")
        'Dim strUserID As String = Convert.ToString("humano")
        'Dim strPassword As String = Convert.ToString("humano")
        'Dim strDatabaseName As String = Convert.ToString("humano")
        strConnectString = "Provider=SQLOLEDB;data source=" + strServerName + ";User ID=" + strUserID + ";password=" + strPassword + ";Initial Catalog=" + strDatabaseName
        strConnectString &= ";Min Pool Size=5; Max Pool Size= 10000;Connect Timeout=36000;"
        Return strConnectString
    End Function

    Public Sub New()
        Try
            'string strConnectString = ConfigurationSettings.AppSettings["strConnOledb"].ToString(); 
            strConnectString = GetConnectionString()
            cnn = New OleDbConnection(strConnectString)
        Catch ex As Exception
            Throw (New Exception("SqlDb:SqlDb():" + ex.Message))
        End Try
    End Sub


    Public Sub BeginTrans()
        Try
            If cnn.State = ConnectionState.Closed Then
                cnn.Open()
            End If
            'cmd = cnn.CreateCommand(); 
            'cmd.Transaction = trn; 
            trn = cnn.BeginTransaction(IsoLevel)
        Catch ex As Exception
            Throw New Exception("SqlDb:BeginTrans():" + ex.Message)
        End Try
    End Sub

    Public Sub RollbackTrans()
        Try
            If Not trn Is Nothing Then
                trn.Rollback()
                'strTranName 
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Throw New Exception("SqlDb:RollbackTrans():" + ex.Message)
        Finally
            trn = Nothing
            cnn.Close()
        End Try
    End Sub

    Public Sub CommitTrans()
        Try
            trn.Commit()
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            Throw New Exception("SqlDb:CommitTrans():" + ex.Message)
        Finally
            trn = Nothing
            cnn.Close()
        End Try

    End Sub

    Public Function CreateCommand(ByVal StrSQL As String) As OleDbCommand
        If trn Is Nothing Then
            Return New OleDbCommand(StrSQL, New OleDbConnection(strConnectString))
        Else
            Return New OleDbCommand(StrSQL, cnn, trn)
        End If
    End Function

    Public Sub Exec(ByVal str As String)
        Dim cmd As OleDbCommand = CreateCommand(str)
        Try

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("SqlDb:Execute(string):" + ex.Message)
        End Try
    End Sub

    Public Sub Exec(ByVal cmd As OleDbCommand)
        'Dim cmd As OleDbCommand = CreateCommand(str)
        Try

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("SqlDb:Execute(string):" + ex.Message)
        End Try
    End Sub


    Public Function ExecQuery(ByVal str As String) As DataTable
        Dim cmd As OleDbCommand = CreateCommand(str)

        Try
            adp = Nothing
            adp = New OleDbDataAdapter(cmd)

            Dim dst As New DataSet()
            adp.Fill(dst)
            Return dst.Tables(0)
        Catch ex As Exception
            Throw (New Exception("SqlDb:Query2DataTable(string):" + ex.Message + " "))
        End Try
    End Function

    Public Function GetDataset(ByVal str As String) As DataSet
        Dim cmd As OleDbCommand = CreateCommand(str)
        Try
            adp = Nothing
            adp = New OleDbDataAdapter(cmd)

            Dim dst As New DataSet()
            adp.Fill(dst)
            Return dst
        Catch ex As Exception
            Throw (New Exception("SqlDb:Query2DataTable(string):" + ex.Message + " "))
        End Try

    End Function

    Public Function GetDataRow(ByVal cmd As OleDbCommand) As DataRow
        Try
            adp = Nothing
            adp = New OleDbDataAdapter(cmd)

            Dim dst As New DataSet()
            adp.Fill(dst)
            If dst.Tables(0).Rows.Count = 0 Then
                Return Nothing
            Else
                Return dst.Tables(0).Rows(0)
            End If
        Catch ex As Exception
            Throw New Exception("SqlDb:Query2DataRow(string):" + ex.Message)
        End Try

    End Function

    Public Function GetDataTable(ByVal cmd As OleDbCommand) As DataTable
        Try
            adp = Nothing
            adp = New OleDbDataAdapter(cmd)

            Dim dst As New DataSet()
            adp.Fill(dst)
            Return dst.Tables(0)
        Catch ex As Exception
            Throw (New Exception("SqlDb:Query2DataTable(string):" + ex.Message + " "))
        End Try
    End Function

    Public Function GetDataTable(ByVal str As String) As DataTable
        Dim cmd As OleDbCommand = CreateCommand(str)
        Try
            adp = Nothing
            adp = New OleDbDataAdapter(cmd)
            Dim dst As New DataSet()
            adp.Fill(dst)
            cmd.CommandTimeout = 360000
            Return dst.Tables(0)
        Catch ex As Exception
            Throw (New Exception("SqlDb:Query2DataTable(string):" + ex.Message + " "))
        End Try
    End Function

    Public Function ExecReder(ByVal cmd As OleDbCommand) As Object
        Dim drd As OleDbDataReader = cmd.ExecuteReader()
        If drd.Read() Then
            Dim obj As Object = drd.GetValue(0)
            drd.Close()
            Return obj
        End If
        drd.Close()
        Return DBNull.Value
    End Function

    Public Function GetDateTime() As DateTime
        Dim cmd As OleDbCommand = CreateCommand("select getdate()")
        Dim dr As DataRow = GetDataRow(cmd)
        Dim datetime As DateTime = Convert.ToDateTime(dr(0))
        If datetime.Year > 2473 Then
            datetime = datetime.AddYears(-543)
        End If
        Return datetime
    End Function

    Public Function GetDateTime_String() As String
        Dim cmd As OleDbCommand = CreateCommand("select convert(nvarchar(30),getdate(),100)")
        Dim dr As DataRow = GetDataRow(cmd)
        Dim datetime As String = dr(0).ToString()
        Return datetime
    End Function

    Public Function GetDateTime_db() As String
        Dim cmd As OleDbCommand = CreateCommand("select convert(nvarchar(30),getdate(),102)")
        Dim dr As DataRow = GetDataRow(cmd)
        Dim datetime As String = dr(0).ToString().Replace(".", "-")
        Return datetime
    End Function

    Public Property Transaction() As OleDbTransaction
        Get
            Return trn
        End Get
        Set(ByVal value As OleDbTransaction)
            trn = value
        End Set
    End Property
    Public Property Connection() As OleDbConnection
        Get
            Return cnn
        End Get
        Set(ByVal value As OleDbConnection)
            cnn = value
        End Set
    End Property

    Public Property IsolationLevel() As IsolationLevel
        Get
            Return IsoLevel
        End Get
        Set(ByVal value As IsolationLevel)
            IsoLevel = value
        End Set
    End Property
    Public Shared Function DefaultDateNull() As Date
        Dim _cultureInfo As New Globalization.CultureInfo("en-US")
        Dim result As Date
        result = Convert.ToDateTime("1900/01/01", _cultureInfo)
        Return result
    End Function
    Public Shared Function StringToDate(ByVal _DateStr As String) As Date
        Dim _cultureInfo As New Globalization.CultureInfo("en-US")
        Dim dd As String
        Dim mm As String
        Dim yyyy As String
        Dim result As Date
        Try
            If Not IsDBNull(_DateStr) Then
                dd = Mid(_DateStr, 1, 2)
                mm = Mid(_DateStr, 4, 2)
                yyyy = Mid(_DateStr, 7, 4)
                If Val(yyyy) > 2500 Then yyyy = Val(yyyy) - 543
                result = Convert.ToDateTime(yyyy & "/" & mm & "/" & dd, _cultureInfo)
            End If
        Catch
            result = DefaultDateNull()
        End Try
        Return result
    End Function
    Public Shared Function DateToStringTH(ByVal _Date As DateTime) As String

        Dim result As String = ""
        Try
            If Not IsDBNull(_Date) Then
                Dim yyyy As String = _Date.ToString("yyyy")
                If Val(yyyy) < 2500 Then
                    result = _Date.ToString("dd/MM") & "/" & Val(yyyy) + 543
                Else
                    result = _Date.ToString("dd/MM/yyyy")
                End If
            End If
        Catch
            result = ""
        End Try
        Return result
        Return _Date.ToString("MM/dd/yyyy")
    End Function

    Public Function GenKeyValue() As String
        Return GenKeyValue(KeyValuePrefixType.NO, gnKeyFieldLen)
    End Function

    Public Function GenKeyValue(type As KeyValuePrefixType) As String
        Return GenKeyValue(type, gnKeyFieldLen)
    End Function

    Public Function GenKeyValue(type As KeyValuePrefixType, nMaxSize As Integer) As String
        Dim sYMD As String = ""
        If type = KeyValuePrefixType.YM Then
            sYMD = DateTime.Now.ToString("yyMM", New CultureInfo("en-US"))
        End If
        If type = KeyValuePrefixType.YMD Then
            sYMD = DateTime.Now.ToString("yyMMdd", New CultureInfo("en-US"))
        End If
        nMaxSize = nMaxSize - sYMD.Length
        Return sYMD & GetUniqueKey(nMaxSize)
    End Function

    Public Function GetUniqueKey(nMaxSize As Integer) As String
        If nMaxSize = 0 Then
            nMaxSize = 1
        End If
        Dim sCharKey As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim cACharKey As Char() = New Char(sCharKey.Length - 1) {}
        cACharKey = sCharKey.ToCharArray()
        Dim aData As Byte() = New Byte(0) {}
        Dim crypto As New RNGCryptoServiceProvider()
        crypto.GetNonZeroBytes(aData)
        aData = New Byte(nMaxSize - 1) {}
        crypto.GetNonZeroBytes(aData)
        Dim result As New StringBuilder(nMaxSize)
        For Each b As Byte In aData
            result.Append(cACharKey(b Mod (cACharKey.Length - 1)))
        Next
        Return result.ToString()
    End Function

    Public Enum KeyValuePrefixType
        NO
        YMD
        YM
    End Enum


End Class
