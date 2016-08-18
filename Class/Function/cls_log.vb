Imports Microsoft.VisualBasic
'Imports ClassLogic
Imports System
Imports System.Data
Imports System.Net.DNS
Imports System.Configuration
Imports System.IO
'Imports System.Web.UI
'Imports System.Web.UI.ClientScriptManager
'Imports System.Web.UI.Control
'Imports System.Web.UI.UserControl
'Imports System.Web.UI.WebControls
'Imports System.Web.UI.TemplateControl
'Imports System.Web.SessionState
'Imports System.Web.HttpContext
Public Class cls_log
    Dim date_time As String = ""
    Dim sqlDb As New Cls_SqlDB
    Dim file_name As Array

    Public Sub WriteError(ByVal form As String, ByVal sub_function As String, ByVal message As String)
        'date_time = sqlDb.GetDataTable("SELECT CONVERT(VARCHAR(10),GETDATE(),103)").Rows(0)(0).ToString()
        date_time = sqlDb.GetDataTable("SELECT CONVERT(VARCHAR(10),GETDATE(),103)+' '+convert(varchar(30),getdate(),108)").Rows(0)(0).ToString()

        file_name = sqlDb.GetDataTable("SELECT CONVERT(VARCHAR(10),GETDATE(),103)").Rows(0)(0).ToString().Split("/")
        Dim FILENAME As String = System.AppDomain.CurrentDomain.BaseDirectory() & ConfigurationSettings.AppSettings("log_data") & "ErrorLog_" & file_name(0) & "_" & file_name(1) & "_" & file_name(2) & ".txt"
        Dim objStreamWriter As StreamWriter
        If File.Exists(FILENAME) = False Then
            ' objStreamWriter = File.CreateText(FILENAME)
        End If
        objStreamWriter = File.AppendText(FILENAME)
        objStreamWriter.WriteLine(date_time + vbTab + form + vbTab + sub_function + vbTab + message)
        objStreamWriter.Close()
    End Sub
End Class
