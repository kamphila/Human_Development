Imports System.Data.OleDb
Imports System.ComponentModel

Public Class Cls_Position
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(id As String)
        If String.Empty.Equals(id) = False Then
            Me.getById(id)
        End If
    End Sub

#End Region

#Region "Property"

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _code As String
    Public Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _name2 As String
    Public Property name2() As String
        Get
            Return _name2
        End Get
        Set(ByVal value As String)
            _name2 = value
        End Set
    End Property

    Private _strfuncnm As String
    Public Property strfuncnm() As String
        Get
            Return _strfuncnm
        End Get
        Set(ByVal value As String)
            _strfuncnm = value
        End Set
    End Property

    Private _station As String
    Public Property station() As String
        Get
            Return _station
        End Get
        Set(ByVal value As String)
            _station = value
        End Set
    End Property

    Public ReadOnly Property expStation() As Cls_Station
        Get
            Return New Cls_Station(_station)
        End Get
    End Property

#End Region

#Region "Function"
    Sub clear()
        _id = String.Empty
        _code = String.Empty
        _name = String.Empty
        _name2 = String.Empty
        _strfuncnm = String.Empty
        _station = String.Empty
    End Sub

    Function getById(id As String) As Boolean
        _id = id
        Dim dt As DataTable
        dt = Retreive()
        If dt.Rows.Count > 0 Then
            code = dt.Rows(0).Item("position_code").ToString()
            name = dt.Rows(0).Item("name_01").ToString()
            name2 = dt.Rows(0).Item("name_02").ToString()
            station = dt.Rows(0).Item("station_id").ToString()
        End If
        Return True
    End Function

    Public Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If _id.Length > 0 Then
                strwc = " and id ='" & _id.ToString() & "'"
            End If
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from position where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "and status='1'"
            strcommand = strcommand & vbCrLf & "order by position_code "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt

            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function RetreivePositionByStation(mode As String, strStationType As String, strPositionCode As String, strPositionName As String) As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim cmd As New OleDbCommand
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If mode = "Condition" Then
                strcommand = "select p.id,s.id as stationid ,p.position_code,p.name_01 as p_name,st.name_01 as st_name from station_type st"
                strcommand = strcommand & vbCrLf & "inner join station s on st.id = s.st_type"
                strcommand = strcommand & vbCrLf & "inner join position p on s.id = p.station_id"
                strcommand = strcommand & vbCrLf & "where st.corp = '" & GBCorp & "' "
                strcommand = strcommand & vbCrLf & "and s.status ='1' "
                strcommand = strcommand & vbCrLf & "and p.status ='1' "
                strcommand = strcommand & vbCrLf & " and st.id = ? "
                strcommand = strcommand & vbCrLf & " and p.position_list_id <> 'STD_POSITION' "
                strcommand = strcommand & vbCrLf & "and s.id is not null "
                If strPositionCode <> String.Empty Then
                    strcommand = strcommand & vbCrLf & " and p.position_list_id = ? "
                End If
                If strPositionName <> String.Empty Then
                    strcommand = strcommand & vbCrLf & " and p.name_01 like ? "
                End If
                strcommand = strcommand & vbCrLf & " Order by p.position_code,p.name_01 "

                cmd = SqlDB.CreateCommand(strcommand)
                cmd.Parameters.AddWithValue("@p1", strStationType)
                If strPositionCode <> String.Empty Then
                    cmd.Parameters.AddWithValue("@p2", strPositionCode)
                End If
                If strPositionName <> String.Empty Then
                    cmd.Parameters.AddWithValue("@p3", "%" & strPositionName & "%")
                End If
            ElseIf mode = "All" Then
                strcommand = "select p.id,s.id as stationid,p.position_code,p.name_01 as p_name,st.name_01 as st_name from station_type st"
                strcommand = strcommand & vbCrLf & "inner join station s on st.id = s.st_type"
                strcommand = strcommand & vbCrLf & "inner join position p on s.id = p.station_id"
                strcommand = strcommand & vbCrLf & "where st.corp = '" & GBCorp & "' "
                strcommand = strcommand & vbCrLf & "and s.status ='1' "
                strcommand = strcommand & vbCrLf & "and p.status ='1' "
                strcommand = strcommand & vbCrLf & "and p.position_list_id <> 'STD_POSITION' "
                strcommand = strcommand & vbCrLf & "and s.id is not null "
                strcommand = strcommand & vbCrLf & " Order by p.position_code,p.name_01 "
                cmd = SqlDB.CreateCommand(strcommand)
            End If
            dt = SqlDB.GetDataTable(cmd)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function RetiveStation(p1 As Object) As DataTable
        Dim dt As New DataTable()
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            strcommand = "select st.* "
            strcommand = strcommand & vbCrLf & "from station st "
            strcommand = strcommand & vbCrLf & " inner join station_type stt on st.st_type = stt.id "
            strcommand = strcommand & vbCrLf & " where st.corp = '" & GBCorp & "' and st.status = '1' "
            strcommand = strcommand & vbCrLf & " and stt.status ='1'"
            strcommand = strcommand & vbCrLf & " and stt.id = '" & p1 & "'"
            strcommand = strcommand & vbCrLf & "order by stt.st_level "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
        Return dt
    End Function

    Function RetreivePersonDataFromPosition(ByVal strPositionId As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim cmd As New OleDbCommand
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            strcommand = "select "
            strcommand = strcommand & vbCrLf & "pd.id as pd_id,pd.em_code,pd.prefix_01,pd.name_01,pd.sname_01 "
            strcommand = strcommand & vbCrLf & ",p.name_01 as pname,s.name_01 as sname "
            strcommand = strcommand & vbCrLf & "from station_type st "
            strcommand = strcommand & vbCrLf & "inner join station s on st.id = s.st_type "
            strcommand = strcommand & vbCrLf & "inner join position p on s.id = p.station_id "
            strcommand = strcommand & vbCrLf & "inner join per_position ps on ps.position_id = p.id "
            strcommand = strcommand & vbCrLf & "inner join person_data pd on pd.id = ps.person_id "
            strcommand = strcommand & vbCrLf & " where st.corp = ? "
            strcommand = strcommand & vbCrLf & " and p.id =? "
            strcommand = strcommand & vbCrLf & " and s.status ='1' "
            strcommand = strcommand & vbCrLf & " and p.status ='1' "
            strcommand = strcommand & vbCrLf & " and ps.position_type ='1' "
            strcommand = strcommand & vbCrLf & " and ps.position_status ='1' "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", strPositionId)
            dt = SqlDB.GetDataTable(cmd)
            Return dt
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
        Return dt
    End Function

    Function RetreivePersonDataFromPosition(ByVal strPositionId As String, ByVal strPerson_data As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim cmd As New OleDbCommand
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            strcommand = "select "
            strcommand = strcommand & vbCrLf & "pd.id as pd_id,pd.em_code,pd.prefix_01,pd.name_01,pd.sname_01 "
            strcommand = strcommand & vbCrLf & ",p.name_01 as pname,s.id as s_id,s.name_01 as sname "
            strcommand = strcommand & vbCrLf & "from station_type st "
            strcommand = strcommand & vbCrLf & "inner join station s on st.id = s.st_type "
            strcommand = strcommand & vbCrLf & "inner join position p on s.id = p.station_id "
            strcommand = strcommand & vbCrLf & "inner join per_position ps on ps.position_id = p.id "
            strcommand = strcommand & vbCrLf & "inner join person_data pd on pd.id = ps.person_id "
            strcommand = strcommand & vbCrLf & " where st.corp = ? "
            strcommand = strcommand & vbCrLf & " and p.id =? "
            strcommand = strcommand & vbCrLf & " and pd.id =? "
            strcommand = strcommand & vbCrLf & " and s.status ='1' "
            strcommand = strcommand & vbCrLf & " and p.status ='1' "
            strcommand = strcommand & vbCrLf & " and ps.position_type ='1' "
            strcommand = strcommand & vbCrLf & " and ps.position_status ='1' "
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", strPositionId)
            cmd.Parameters.AddWithValue("@p3", strPerson_data)
            dt = SqlDB.GetDataTable(cmd)
            Return dt
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
        Return dt
    End Function

#End Region

End Class
