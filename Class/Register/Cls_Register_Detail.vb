Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Cls_Register_Detail
    Inherits Cls_Base
    Implements INotifyPropertyChanged

    Public Event PropertyChanged(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    Public Sub New()

    End Sub

    Public Sub New(id As String)
        Me.getById(id)
    End Sub

    Private _register As String = String.Empty
    Private _seq As Integer
    Private _annual_detail As String = String.Empty
    Private _person_data As String = String.Empty
    Private _position As String = String.Empty
    Private _station As String = String.Empty
    Private _join As String = String.Empty
    Private _reg_datetime As DateTime = DateTime.Now

    Public Property register() As String
        Get
            Return _register
        End Get
        Set(value As String)
            _register = value
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

    Public Property annual_detail() As String
        Get
            Return _annual_detail
        End Get
        Set(value As String)
            _annual_detail = value
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

    Public Property reg_datetime() As DateTime
        Get
            Return _reg_datetime
        End Get
        Set(value As DateTime)
            _reg_datetime = value
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
        _register = String.Empty
        _seq = 0
        _annual_detail = String.Empty
        _person_data = String.Empty
        _position = String.Empty
        _station = String.Empty
        _join = String.Empty
        _reg_datetime = DateTime.Now

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
                strwc = " and red_id = '" & var_id.ToString() & "'"
            End If
            If _register.Length > 0 Then
                strwc = strwc & " and red_register ='" & _register.ToString() & "'"
            End If
            strcommand = "select * from hd_register_detail "
            strcommand = strcommand & vbCrLf & "where corp='" & GBCorp & "'" & strwc
            strcommand = strcommand & vbCrLf & "order by red_seq "
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
            strcommand = "insert into hd_register_detail ("
            strcommand = strcommand & vbCrLf & "corp,red_id,red_register,red_seq,red_annual_detail,red_person_data"
            strcommand = strcommand & vbCrLf & ",red_position,red_station,red_join,red_reg_datetime,red_create_by"
            strcommand = strcommand & vbCrLf & ",red_create_date "
            strcommand = strcommand & vbCrLf & ") values(?,?,?,?,?,?,?,?,?,?,?,?)"
            cmd = SqlDB.CreateCommand(strcommand)
            var_id = SqlDB.GenKeyValue()
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", var_id)
            cmd.Parameters.AddWithValue("@p3", _register)
            cmd.Parameters.AddWithValue("@p4", _seq)
            cmd.Parameters.AddWithValue("@p5", _annual_detail)
            cmd.Parameters.AddWithValue("@p6", _person_data)
            cmd.Parameters.AddWithValue("@p7", _position)
            cmd.Parameters.AddWithValue("@p8", _station)
            cmd.Parameters.AddWithValue("@p9", _join)
            cmd.Parameters.AddWithValue("@p10", _reg_datetime)
            cmd.Parameters.AddWithValue("@p11", GBUsername)
            cmd.Parameters.AddWithValue("@p12", DateTime.Now)
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
            strcommand = "update hd_register_detail"
            strcommand = strcommand & vbCrLf & "set corp =?"
            strcommand = strcommand & vbCrLf & ",red_register = ?"
            strcommand = strcommand & vbCrLf & ",red_seq = ?"
            strcommand = strcommand & vbCrLf & ",red_annual_detail =?"
            strcommand = strcommand & vbCrLf & ",red_person_data = ?"
            strcommand = strcommand & vbCrLf & ",red_position = ?"
            strcommand = strcommand & vbCrLf & ",red_station = ?"
            strcommand = strcommand & vbCrLf & ",red_join = ?"
            strcommand = strcommand & vbCrLf & ",red_reg_datetime =?"
            strcommand = strcommand & vbCrLf & ",red_edit_by = ?"
            strcommand = strcommand & vbCrLf & ",red_edit_date = ?"
            strcommand = strcommand & vbCrLf & "where red_id = ?"
            cmd = SqlDb.CreateCommand(strcommand)
            cmd.Parameters.AddWithValue("@p1", GBCorp)
            cmd.Parameters.AddWithValue("@p2", _register)
            cmd.Parameters.AddWithValue("@p3", _seq)
            cmd.Parameters.AddWithValue("@p4", _annual_detail)
            cmd.Parameters.AddWithValue("@p5", _person_data)
            cmd.Parameters.AddWithValue("@p6", _position)
            cmd.Parameters.AddWithValue("@p7", _station)
            cmd.Parameters.AddWithValue("@p8", _join)
            cmd.Parameters.AddWithValue("@p9", _reg_datetime)
            cmd.Parameters.AddWithValue("@p10", GBUsername)
            cmd.Parameters.AddWithValue("@p11", DateTime.Now)
            cmd.Parameters.AddWithValue("@p12", var_id)
            SqlDb.Exec(cmd)
            Return True
        Catch ex As Exception
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
            message = strfuncnm & vbCrLf & "Error:" & ex.Message
            Return False
        End Try
    End Function

    Function Delete(SqlDB As Cls_SqlDB) As Boolean
        Dim bSucc = True
        Dim cmd As New OleDbCommand
        Dim strcommand As String = String.Empty
        Dim strwc As String = String.Empty
        Try
            strcommand = "delete from hd_register_detail "
            strcommand = strcommand & vbCrLf & "where red_id =? "
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
                _register = cNull(dt.Rows(row).Item("red_register"), "S")
                _seq = cNull(dt.Rows(row).Item("red_seq"), "N")
                _annual_detail = cNull(dt.Rows(row).Item("red_annual_detail"), "S")
                _person_data = cNull(dt.Rows(row).Item("red_person_data"), "S")
                _position = cNull(dt.Rows(row).Item("red_position"), "S")
                _station = cNull(dt.Rows(row).Item("red_station"), "S")
                _join = cNull(dt.Rows(row).Item("red_join"), "S")
                _reg_datetime = cNull(dt.Rows(row).Item("red_reg_datetime"), "D")
            Next
        End If
    End Sub
End Class
