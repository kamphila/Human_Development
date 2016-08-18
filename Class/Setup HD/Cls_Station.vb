Public Class Cls_Station

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

#End Region

#Region "Function"

    Function getById(id As String) As Boolean
        _id = id
        Dim dt As DataTable
        dt = Retreive()
        If dt.Rows.Count > 0 Then
            code = dt.Rows(0).Item("st_code").ToString()
            name = dt.Rows(0).Item("name_01").ToString()
            name2 = dt.Rows(0).Item("name_02").ToString()
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
            strcommand = strcommand & vbCrLf & "from station where corp = '" & GBCorp & "' " & strwc
            strcommand = strcommand & vbCrLf & "and status='1'"
            strcommand = strcommand & vbCrLf & "order by st_code "
            dt = SqlDB.GetDataTable(strcommand)
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

    Function RetreiveStationType() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            strcommand = "select * "
            strcommand = strcommand & vbCrLf & "from station_type where corp = '" & GBCorp & "' and status = '1' "
            strcommand = strcommand & vbCrLf & "order by st_level "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

#End Region

End Class
