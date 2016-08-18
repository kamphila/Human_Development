Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Imports System.Configuration
Imports System.IO
Public Class SQLServerconnection
    Private arrKeys As New ArrayList
    Private arrVals As New ArrayList
    Public ConnString As String
    Private DSET As DataSet
    Private DVIEW As DataView
    Private dr As SqlDataReader
    Dim a(20) As String
#Region "ParametersProtected Function"
    Sub ParametersClear()
        If Not IsNothing(arrKeys) And Not IsNothing(arrVals) Then
            arrKeys.Clear()
            arrVals.Clear()
        End If
    End Sub

    Protected Function ParametersCount() As Integer
        Return arrKeys.Count
    End Function

    Sub ParametersAdd(ByVal strKeys, ByVal strVals)
        arrKeys.Add(strKeys)
        arrVals.Add(strVals)
    End Sub
#End Region
    Public Sub New()
        Try
            Call ReadINI()
            ' ConnString = ConfigurationSettings.AppSettings("ConnectionString")
            If a(1) = 2 Then
                ConnString = "server=" & a(5) & ";uid=" & a(7) & ";password=humano" & ";database=" & a(3) & ";Max Pool size=400;Connect Timeout=600;Connection Lifetime=600;"
            ElseIf a(1) = 8 Then
                ConnString = "Provider=SQLNCLI10;Server=" & a(5) & ";uid=" & a(7) & ";password=humano" & ";database=" & a(3) & ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub Close()
        ParametersClear()
        arrKeys = Nothing
        arrVals = Nothing
        DSET = Nothing
        dr = Nothing
    End Sub
    Function ReadINI() As String
        Dim i As Integer = 0
        Dim reader As StreamReader = _
       New StreamReader(Application.StartupPath & "\humanoDB.ini")
        Try
            Do
                a(i) = reader.ReadLine
                i = i + 1
            Loop Until reader.Peek = -1
        Catch
        Finally
            reader.Close()
        End Try


    End Function
    Protected Function SQL_Execute(ByVal ReqSQL As String) As Integer
        If CInt(a(1)) = 2 Then
            Dim SQLConn As New SqlConnection
            Dim SQLDataAdapter As New SqlDataAdapter
            Dim SQLCommand As New SqlCommand
            Dim i As Integer

            Try
                SQLConn.ConnectionString = ConnString
                SQLCommand.CommandText = ReqSQL
                SQLCommand.Connection = SQLConn
                SQLCommand.CommandType = CommandType.Text

                SQLConn.Open()
                Return SQLCommand.ExecuteNonQuery()

            Catch ex As Exception
                If SQLConn.State = ConnectionState.Open Then
                    SQLConn.Close()
                End If
                SQLConn = Nothing
                SQLCommand = Nothing
                'Close()
                Throw ex
            End Try

        ElseIf CInt(a(1)) = 8 Then

            Dim SQLConn As New OleDb.OleDbConnection
            Dim SQLDataAdapter As New OleDb.OleDbDataAdapter
            Dim SQLCommand As New OleDb.OleDbCommand
            Dim i As Integer

            Try
                SQLConn.ConnectionString = ConnString
                SQLCommand.CommandText = ReqSQL
                SQLCommand.Connection = SQLConn
                SQLCommand.CommandType = CommandType.Text

                SQLConn.Open()
                Return SQLCommand.ExecuteNonQuery()

            Catch ex As Exception
                If SQLConn.State = ConnectionState.Open Then
                    SQLConn.Close()
                End If
                SQLConn = Nothing
                SQLCommand = Nothing
                'Close()
                Throw ex
            End Try
        End If

    End Function
    Protected Function SQL_DataSet(ByVal SQL As String) As DataSet
        If CInt(a(1)) = 2 Then
            Dim DSET As DataSet
            Dim SQLConn As New SqlConnection
            Dim SQLDataAdapter As New SqlDataAdapter
            Dim SQLCommand As New SqlCommand
            'Dim i As Integer

            Try
                DSET = New DataSet
                SQLConn.ConnectionString = ConnString
                SQLCommand.CommandText = SQL
                SQLCommand.Connection = SQLConn
                SQLCommand.CommandType = CommandType.Text
                SQLDataAdapter.SelectCommand = SQLCommand

                SQLDataAdapter.Fill(DSET)

                Return DSET

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                SQLConn = Nothing
                SQLDataAdapter = Nothing
                SQLCommand = Nothing
                DSET = Nothing
                Close()
                Throw ex
            End Try
        ElseIf CInt(a(1)) = 8 Then
            Dim SQLConn As New OleDb.OleDbConnection
            Dim SQLDataAdapter As New OleDb.OleDbDataAdapter
            Dim SQLCommand As New OleDb.OleDbCommand
            'Dim i As Integer

            Try
                DSET = New DataSet
                SQLConn.ConnectionString = ConnString
                SQLCommand.CommandText = SQL
                SQLCommand.Connection = SQLConn
                SQLCommand.CommandType = CommandType.Text
                SQLDataAdapter.SelectCommand = SQLCommand

                SQLDataAdapter.Fill(DSET)

                Return DSET

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                SQLConn = Nothing
                SQLDataAdapter = Nothing
                SQLCommand = Nothing
                DSET = Nothing
                Close()
                Throw ex
            End Try
        End If

    End Function
End Class
