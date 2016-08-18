Public Class Cls_Competency
    Inherits Cls_Base
    Private var_code As String = String.Empty
    Private var_name As String = String.Empty
    Private var_name2 As String = String.Empty
    Private var_groupname As String = String.Empty

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
    Public Property code() As String
        Get
            Return var_code
        End Get
        Set(ByVal value As String)
            var_code = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return var_name
        End Get
        Set(ByVal value As String)
            var_name = value
        End Set
    End Property

    Public Property name2() As String
        Get
            Return var_name2
        End Get
        Set(ByVal value As String)
            var_name2 = value
        End Set
    End Property

    Public Property groupname() As String
        Get
            Return var_groupname
        End Get
        Set(ByVal value As String)
            var_groupname = value
        End Set
    End Property
#End Region

#Region "Function"
    Function getById(id As String) As Boolean
        var_id = id
        Dim dt As DataTable
        dt = Retreive()
        If dt.Rows.Count > 0 Then
            var_id = dt.Rows(0).Item("id").ToString()
            var_code = dt.Rows(0).Item("com_code").ToString()
            var_name = dt.Rows(0).Item("name_01").ToString()
            var_name2 = dt.Rows(0).Item("name_02").ToString()
            var_groupname = dt.Rows(0).Item("groupname").ToString()
        End If
        Return True
    End Function

    Function RetreiveForSearch(strCode As String, strName As String, strGroup As String) As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and competency.id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select competency.* ,competency_group.name_01 as groupname ,competency_group.name_02 as groupname2 "
            strcommand = strcommand & vbCrLf & " from competency left join competency_group on competency.com_group_id = competency_group.id "
            strcommand = strcommand & vbCrLf & "where competency.competency_list_id = 'STD_COMPETENCY' and competency.com_code is not null " & strwc
            If strCode <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and competency.com_code like '%" & strCode & "%'"
            End If
            If strName <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and competency.name_01 like '%" & strName & "%'"
            End If
            If strGroup <> String.Empty Then
                strcommand = strcommand & vbCrLf & " and competency_group.name_01 like '%" & strGroup & "%'"
            End If
            strcommand = strcommand & vbCrLf & " order by com_code "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

    Function Retreive() As DataTable
        Try
            Dim SqlDB As New Cls_SqlDB
            Dim strcommand As String = String.Empty
            Dim strwc As String = String.Empty
            Dim dt As New DataTable
            If var_id.Length > 0 Then
                strwc = " and competency.id ='" & var_id.ToString() & "'"
            End If
            strcommand = "select competency.* ,competency_group.name_01 as groupname ,competency_group.name_02 as groupname2 "
            strcommand = strcommand & vbCrLf & " from competency left join competency_group on competency.com_group_id = competency_group.id "
            strcommand = strcommand & vbCrLf & "where competency.competency_list_id = 'STD_COMPETENCY' and competency.com_code is not null " & strwc
            strcommand = strcommand & vbCrLf & " order by com_code "
            dt = SqlDB.GetDataTable(strcommand)
            Return dt
            strfuncnm = New System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name
        Catch ex As Exception
            Throw New Exception(strfuncnm & vbCrLf & "Error:" & ex.Message)
        End Try
    End Function

#End Region
End Class
