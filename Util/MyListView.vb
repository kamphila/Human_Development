Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections

Public Class MyListView
    Inherits ListView
    'Variables
    Private m_dataMember As String
    Private m_dataSource As DataSet
    Private m_collection As Collection
    Private columnWidth As Integer = 100
    Private cm As CurrencyManager
    Private m_DisplayableProperties As String = String.Empty
    Private m_Type As Type

    'Constructor
    Public Sub New()
        'set default settings for listView
        Me.View = View.Details
        Me.FullRowSelect = True
        Me.MultiSelect = False
        Me.BackColor = Color.Wheat
        Me.ForeColor = Color.Brown
        Me.HideSelection = False
    End Sub

    'Properties
    Public Property DisplayableProperties() As String
        Get
            Return Me.m_DisplayableProperties
        End Get
        Set(value As String)
            Me.m_DisplayableProperties = value
        End Set
    End Property

    Public Property TypeCol() As Type
        Get
            Return Me.m_Type
        End Get
        Set(value As Type)
            Me.m_Type = value
        End Set
    End Property

    Public Property DataMember() As String
        Get
            Return Me.m_dataMember
        End Get
        Set(value As String)
            Me.m_dataMember = value
        End Set
    End Property

    Public Property DataSource() As DataSet
        Get
            Return Me.m_dataSource
        End Get
        Set(value As DataSet)
            Me.m_dataSource = value
            Me.dataBindControl()
            Me.setCurrencyManager()
        End Set
    End Property

    Public Property DataSource2() As Collection
        Get
            Return Me.m_collection
        End Get
        Set(value As Collection)
            Me.m_collection = value
            Me.dataBindControl2()
            Me.setCurrencyManager2()
        End Set
    End Property


    'Methods
    Private Sub setCurrencyManager()
        'Assign CurrencyManager [from BindingContext]
        Me.cm = DirectCast(Me.BindingContext(Me.m_dataSource.Tables(m_dataMember)), CurrencyManager)
    End Sub

    Private Sub dataBindControl()
        Me.Clear()

        Dim newItem As ListViewItem

        'Add columns to ListView
        For Each col As DataColumn In Me.m_dataSource.Tables(m_dataMember).Columns
            MyBase.Columns.Add(col.ColumnName, columnWidth, HorizontalAlignment.Left)
        Next

        For i As Integer = 0 To Me.m_dataSource.Tables(m_dataMember).Rows.Count - 1
            newItem = New ListViewItem()
            'First Column
            newItem.Text = Me.m_dataSource.Tables(m_dataMember).Rows(i).ItemArray(0).ToString()
            'SubItems
            For subItems As Integer = 1 To MyBase.Columns.Count - 1
                newItem.SubItems.Add(Me.m_dataSource.Tables(m_dataMember).Rows(i).ItemArray(subItems).ToString())
            Next

            Me.Items.Add(newItem)
        Next
    End Sub

    Private Sub MyListView_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Me.SelectedItems.Count > 0 Then
            'set Position of CurrencyManager to selectedIndex of ListView
            cm.Position = Me.SelectedItems(0).Index
        End If
    End Sub


    Private Sub MyListView_TabIndexChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.TabIndexChanged
        If Me.SelectedItems.Count > 0 Then
            'set Position of CurrencyManager to selectedIndex of ListView
            cm.Position = Me.SelectedItems(0).Index
        End If
    End Sub

    'Private Sub InitializeComponent()
    '    Me.SuspendLayout()
    '    '
    '    'MyListView
    '    '
    '    Me.ResumeLayout(False)
    'End Sub

    Private Sub dataBindControl2()
        Me.Items.Clear()

        Dim newItem As ListViewItem

        'Add columns to ListView
        'For Each col As DataColumn In Me.m_dataSource.Tables(m_dataMember).Columns
        '    MyBase.Columns.Add(col.ColumnName, columnWidth, HorizontalAlignment.Left)
        'Next

        For i As Integer = 0 To Me.m_dataSource.Tables(m_dataMember).Rows.Count - 1
            newItem = New ListViewItem()
            'First Column
            newItem.Text = Me.m_dataSource.Tables(m_dataMember).Rows(i).ItemArray(0).ToString()
            'SubItems
            For subItems As Integer = 1 To MyBase.Columns.Count - 1
                newItem.SubItems.Add(Me.m_dataSource.Tables(m_dataMember).Rows(i).ItemArray(subItems).ToString())
            Next

            Me.Items.Add(newItem)
        Next
    End Sub

    Private Sub setCurrencyManager2()
        Throw New NotImplementedException
    End Sub


End Class
