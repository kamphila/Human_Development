Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Record_Development_Detail
    Inherits Cls_Base
    Implements INotifyPropertyChanged
    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

    Public Sub New()

    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub

    Private _resultdev_master As String = String.Empty
    Private _annual_detail As String = String.Empty
    Private _seq As Integer
    Private _person_data As String = String.Empty
    Private _position As String = String.Empty
    Private _station As String = String.Empty
    Private _join As String = String.Empty
    Private _passed As String = String.Empty
    Private _score As Integer

    Public Property resultdev_master() As String
        Get
            Return _resultdev_master
        End Get
        Set(value As String)
            _resultdev_master = value
        End Set
    End Property

    Public Property annual_detail() As String
        Get
            Return _annual_detail
        End Get
        Set(value As String)
            _annual_detail = value
        End Set
    End Property

    Public Property seq() As Integer
        Get
            Return _seq
        End Get
        Set(value As Integer)
            _seq = value
        End Set
    End Property

    Public Property person_data() As String
        Get
            Return _person_data
        End Get
        Set(value As String)
            _person_data = value
        End Set
    End Property

    Public Property position() As String
        Get
            Return _position
        End Get
        Set(value As String)
            _position = value
        End Set
    End Property

    Public Property station() As String
        Get
            Return _station
        End Get
        Set(value As String)
            _station = value
        End Set
    End Property

    Public Property join() As String
        Get
            Return _join
        End Get
        Set(value As String)
            _join = value
        End Set
    End Property

    Public Property passed() As String
        Get
            Return _passed
        End Get
        Set(value As String)
            _passed = value
        End Set
    End Property

    Public Property score() As Integer
        Get
            Return _score
        End Get
        Set(value As Integer)
            _score = value
        End Set
    End Property

    Public ReadOnly Property expannual_detail As Cls_Annual_Detail
        Get
            Return New Cls_Annual_Detail(_annual_detail)
        End Get
    End Property

    Public ReadOnly Property expperson_data As cls_person
        Get
            Return New cls_person(_person_data)
        End Get
    End Property

    Public ReadOnly Property expposition As Cls_Position
        Get
            Return New Cls_Position(_position)
        End Get
    End Property

    Public ReadOnly Property expstation As Cls_Station
        Get
            Return New Cls_Station(_station)
        End Get
    End Property

    Public Sub Clear()
        var_id = String.Empty
        _resultdev_master = String.Empty
        _annual_detail = String.Empty
        _seq = 0
        _person_data = String.Empty
        _position = String.Empty
        _station = String.Empty
        _join = String.Empty
        _passed = String.Empty
        _score = 0
    End Sub

    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        SetProperty(dt)
    End Function

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " rdd_id= '" & var_id.ToString() & "'"
            End If
            If _resultdev_master.Length > 0 Then
                strwc = strwc & " and rdd_resultdev_master ='" & _resultdev_master.ToString() & "'"
            End If
            strcommand = "select * from hd_resultdev_detail "
            strcommand = strcommand & vbCrLf & "where corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "order by rdd_seq "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Save(SqlDB As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = String.Empty
        Try
            strcommand = "insert into hd_resultdev_detail ("
            strcommand = strcommand & vbCrLf & "corp,branch,rdd_id,rdd_resultdev_master,rdd_annual_detail"
            strcommand = strcommand & vbCrLf & ",rdd_seq,rdd_person_data,rdd_position,rdd_station,rdd_join"
            strcommand = strcommand & vbCrLf & ",rdd_passed,rdd_score,rdd_create_by,rdd_create_date"
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", var_id)
            cmd.Parameters.AddWithValue("@p4", _resultdev_master)
            cmd.Parameters.AddWithValue("@p5", _annual_detail)
            cmd.Parameters.AddWithValue("@p6", _seq)
            cmd.Parameters.AddWithValue("@p7", _person_data)
            cmd.Parameters.AddWithValue("@p8", _position)
            cmd.Parameters.AddWithValue("@p9", _station)
            cmd.Parameters.AddWithValue("@p10", _join)
            cmd.Parameters.AddWithValue("@p11", _passed)
            cmd.Parameters.AddWithValue("@p12", _score)
            cmd.Parameters.AddWithValue("@p13", GBUsername)
            cmd.Parameters.AddWithValue("@p14", DateTime.Now)
            SqlDB.Exec(cmd)
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Update(SqlDb As Cls_SqlDB) As Boolean
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Dim strErrmsg As String = String.Empty
        Try
            strcommand = "update hd_resultdev_detail"
            strcommand = strcommand & vbCrLf & "set corp = ?"
            strcommand = strcommand & vbCrLf & ",branch = ?"
            strcommand = strcommand & vbCrLf & ",rdd_resultdev_master = ?"
            strcommand = strcommand & vbCrLf & ",rdd_annual_detail = ?"
            strcommand = strcommand & vbCrLf & ",rdd_seq =?"
            strcommand = strcommand & vbCrLf & ",rdd_person_data =?"
            strcommand = strcommand & vbCrLf & ",rdd_position =?"
            strcommand = strcommand & vbCrLf & ",rdd_station =?"
            strcommand = strcommand & vbCrLf & ",rdd_join =?"
            strcommand = strcommand & vbCrLf & ",rdd_passed =?"
            strcommand = strcommand & vbCrLf & ",rdd_score =?"
            strcommand = strcommand & vbCrLf & ",rdd_edit_by =?"
            strcommand = strcommand & vbCrLf & ",rdd_edit_date =?"
            strcommand = strcommand & vbCrLf & "where rdd_id =?"
            cmd = SqlDb.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_Branch_id)
            cmd.Parameters.AddWithValue("@p3", _resultdev_master)
            cmd.Parameters.AddWithValue("@p4", _annual_detail)
            cmd.Parameters.AddWithValue("@p5", _seq)
            cmd.Parameters.AddWithValue("@p6", _person_data)
            cmd.Parameters.AddWithValue("@p7", _position)
            cmd.Parameters.AddWithValue("@p8", _station)
            cmd.Parameters.AddWithValue("@p9", _join)
            cmd.Parameters.AddWithValue("@p10", _passed)
            cmd.Parameters.AddWithValue("@p11", _score)
            cmd.Parameters.AddWithValue("@p12", GBUsername)
            cmd.Parameters.AddWithValue("@p13", DateTime.Now)
            cmd.Parameters.AddWithValue("@p14", var_id)
            SqlDb.Exec(cmd)
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Delete(SqlDB As Cls_SqlDB)
        Dim bSucc = True
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Try
            strcommand = "delete from hd_resultdev_detail "
            strcommand = strcommand & vbCrLf & "where rdd_id=?"
            cmd = SqlDB.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", var_id)
            SqlDB.Exec(cmd)
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            bSucc = False
        End Try
        Return bSucc
    End Function

    Public Sub SetProperty(dt As DataTable)
        If dt.Rows.Count > 0 Then
            For row As Integer = 0 To dt.Rows.Count - 1
                _resultdev_master = cNull(dt.Rows(row).Item("rdd_resultdev_master"), "S")
                _annual_detail = cNull(dt.Rows(row).Item("rdm_annual_detail"), "S")
                _seq = cNull(dt.Rows(row).Item("rdd_seq"), "N")
                _person_data = cNull(dt.Rows(row).Item("rdd_person_data"), "S")
                _position = cNull(dt.Rows(row).Item("rdd_position"), "S")
                _station = cNull(dt.Rows(row).Item("rdd_station"), "S")
                _join = cNull(dt.Rows(row).Item("rdd_join"), "S")
                _passed = cNull(dt.Rows(row).Item("rdd_passed"), "S")
                _score = cNull(dt.Rows(row).Item("rdd_score"), "N")
            Next
        End If
    End Sub
End Class
