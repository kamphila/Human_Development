Imports System
Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.OleDb
Public Class cls_sc_permission_corp

#Region "connectbase"
    Private cnn As OleDbConnection
    Private trn As OleDbTransaction
    Private adp As OleDbDataAdapter
    Private IsoLevel As IsolationLevel = IsolationLevel.ReadUncommitted
    Private strConnectString As String = ""
    Private Function GetConnectionString() As String

        Dim servername As String = ""
        Dim dbname As String = ""
        Dim userid As String = ""
        Dim password As String = ""


        Dim i As Integer
        Dim a(20) As String
        Dim myTextFile As New StreamReader(AppDomain.CurrentDomain.BaseDirectory() & "humanoDB.ini")

        Try
            Do
                a(i) = myTextFile.ReadLine
                i = i + 1
            Loop Until myTextFile.Peek = -1


            Dim encript As New LionEncript.LionEncript
            servername = a(5)
            dbname = a(3)
            userid = a(7)
            password = encript.Decode(a(9), 2)

        Catch
        Finally
            myTextFile.Close()
        End Try
        Dim strServerName As String = Convert.ToString(servername)
        Dim strUserID As String = Convert.ToString(userid)
        Dim strPassword As String = Convert.ToString(password)
        Dim strDatabaseName As String = Convert.ToString(dbname)
        'Dim strServerName As String = Convert.ToString("192.168.1.9")
        'Dim strUserID As String = Convert.ToString("humano")
        'Dim strPassword As String = Convert.ToString("humano")
        'Dim strDatabaseName As String = Convert.ToString("humano_GD_Test")

        strConnectString = "Provider=SQLOLEDB;data source=" + strServerName + ";User ID=" + strUserID + ";password=" + strPassword + ";Initial Catalog=" + strDatabaseName
        strConnectString &= ";Min Pool Size=5; Max Pool Size= 10000;Connect Timeout=36000;"
        Return strConnectString
    End Function

    Public Function CreateCommand(ByVal StrSQL As String) As OleDbCommand
        If trn Is Nothing Then
            Return New OleDbCommand(StrSQL, New OleDbConnection(GetConnectionString))
        Else
            Return New OleDbCommand(StrSQL, cnn, trn)
        End If
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
#End Region
#Region "property"


    Private strid As String = String.Empty
    Private strlevel_id As String = String.Empty
    Private strperson_id As String = String.Empty
    Private struserlogin_id As String = String.Empty
    Private strcorp_id As String = String.Empty
    Private strbranch_id As String = String.Empty
    Private strstation_id As String = String.Empty
    Private strstatus As String = String.Empty
    Private strudt_app As String = String.Empty
    Private strcorp As String = String.Empty
    Private strlast_action As String = String.Empty
    Private strlast_udt As String = String.Empty
    Private struser_id As String = String.Empty
    Private strsession_id As String = String.Empty
    Private strcreate_by As String = String.Empty
    Private strcreate_date As String = String.Empty
    Private strlock_data As String = String.Empty
    Private strlock_detail As String = String.Empty
    Private strudt_code As String = String.Empty

    Public Property id() As String
        Get
            Return strid
        End Get
        Set(ByVal value As String)
            strid = value
        End Set
    End Property
    Public Property level_id() As String
        Get
            Return strlevel_id
        End Get
        Set(ByVal value As String)
            strlevel_id = value
        End Set
    End Property
    Public Property person_id() As String
        Get
            Return strperson_id
        End Get
        Set(ByVal value As String)
            strperson_id = value
        End Set
    End Property
    Public Property userlogin_id() As String
        Get
            Return struserlogin_id
        End Get
        Set(ByVal value As String)
            struserlogin_id = value
        End Set
    End Property
    Public Property corp_id() As String
        Get
            Return strcorp_id
        End Get
        Set(ByVal value As String)
            strcorp_id = value
        End Set
    End Property
    Public Property branch_id() As String
        Get
            Return strbranch_id
        End Get
        Set(ByVal value As String)
            strbranch_id = value
        End Set
    End Property
    Public Property station_id() As String
        Get
            Return strstation_id
        End Get
        Set(ByVal value As String)
            strstation_id = value
        End Set
    End Property
    Public Property status() As String
        Get
            Return strstatus
        End Get
        Set(ByVal value As String)
            strstatus = value
        End Set
    End Property
    Public Property udt_app() As String
        Get
            Return strudt_app
        End Get
        Set(ByVal value As String)
            strudt_app = value
        End Set
    End Property
    Public Property corp() As String
        Get
            Return strcorp
        End Get
        Set(ByVal value As String)
            strcorp = value
        End Set
    End Property
    Public Property last_action() As String
        Get
            Return strlast_action
        End Get
        Set(ByVal value As String)
            strlast_action = value
        End Set
    End Property
    Public Property last_udt() As String
        Get
            Return strlast_udt
        End Get
        Set(ByVal value As String)
            strlast_udt = value
        End Set
    End Property
    Public Property user_id() As String
        Get
            Return struser_id
        End Get
        Set(ByVal value As String)
            struser_id = value
        End Set
    End Property
    Public Property session_id() As String
        Get
            Return strsession_id
        End Get
        Set(ByVal value As String)
            strsession_id = value
        End Set
    End Property
    Public Property create_by() As String
        Get
            Return strcreate_by
        End Get
        Set(ByVal value As String)
            strcreate_by = value
        End Set
    End Property
    Public Property create_date() As String
        Get
            Return strcreate_date
        End Get
        Set(ByVal value As String)
            strcreate_date = value
        End Set
    End Property
    Public Property lock_data() As String
        Get
            Return strlock_data
        End Get
        Set(ByVal value As String)
            strlock_data = value
        End Set
    End Property
    Public Property lock_detail() As String
        Get
            Return strlock_detail
        End Get
        Set(ByVal value As String)
            strlock_detail = value
        End Set
    End Property
    Public Property udt_code() As String
        Get
            Return strudt_code
        End Get
        Set(ByVal value As String)
            strudt_code = value
        End Set
    End Property

#End Region
    Public Function Retrieve() As DataTable
        Dim strcommand As String = String.Empty
        Dim dt As New DataTable
        Dim strwc As String = String.Empty
        If userlogin_id <> "HROD" Then
            If GBLangIndex = 1 Then
                strcommand = "select branch_id ,station.name_01 branch_name"
            Else
                strcommand = "select branch_id ,station.name_02 branch_name"
            End If

            strcommand = strcommand & vbCrLf & "from sc_permission_corp inner join station"
            strcommand = strcommand & vbCrLf & "on sc_permission_corp.branch_id=station.id"
            strcommand = strcommand & vbCrLf & "and sc_permission_corp.corp_id=station.corp"
            strcommand = strcommand & vbCrLf & "where sc_permission_corp.corp_id='" & corp_id & "' "
            strcommand = strcommand & vbCrLf & "and userlogin_id='" & userlogin_id & "' "
            strcommand = strcommand & vbCrLf & "and station.status=1"
            strcommand = strcommand & vbCrLf & "and sc_permission_corp.status=1"
        Else
            If GBLangIndex = 1 Then
                strcommand = "select station.id as branch_id ,station.name_01 branch_name"
            Else
                strcommand = "select station.id as branch_id ,station.name_02 branch_name"
            End If
            strcommand = strcommand & vbCrLf & "from station inner join station_type"
            strcommand = strcommand & vbCrLf & "on station.st_type=station_type.id"
            strcommand = strcommand & vbCrLf & "and station.corp=station_type.corp"
            strcommand = strcommand & vbCrLf & "where station.corp='" & corp_id & "' "
            strcommand = strcommand & vbCrLf & "and station.status=1"
            strcommand = strcommand & vbCrLf & "and station_type.status=1"
            strcommand = strcommand & vbCrLf & "and short_code='B'"
        End If

        dt = GetDataTable(strcommand)
        Return dt


    End Function
End Class
