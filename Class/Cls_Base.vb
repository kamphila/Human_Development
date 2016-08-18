Imports System.ComponentModel

Public MustInherit Class Cls_Base

    Protected var_corp_id As String = String.Empty
    Protected var_id As String = String.Empty
    Protected var_Branch_id As String = String.Empty
    Protected strfuncnm As String = String.Empty
    Protected strMessage As String = String.Empty

    Public Property Corp_id() As String
        Get
            Return var_corp_id
        End Get
        Set(ByVal value As String)
            var_corp_id = value
        End Set
    End Property


    Public Property Branch_id() As String
        Get
            Return var_Branch_id
        End Get
        Set(ByVal value As String)
            var_Branch_id = value
        End Set
    End Property

    Public Property id() As String
        Get
            Return var_id
        End Get
        Set(ByVal value As String)
            var_id = value
        End Set
    End Property

    Public Property message() As String
        Get
            Return strMessage
        End Get
        Set(ByVal value As String)
            strMessage = value
        End Set
    End Property

End Class
