Imports System.Text
Imports System.IO
Imports System.Net

Public Class IMSS_SQLConnect
    Public Shared Sub _IMSS_SEND_VIA_PHP(ByRef _IMSS_INFO() As String)
        On Error Resume Next
        _IMSS_POST_PHP_REGEDIT(ConfigurationResureses.LinkVar._IMSS_MainURL & "IMSS_INSERT/IMSS_COMMAND_INSERT.php", _
    "POST", "_IMSS_GETName=" & _IMSS_INFO(0) & _
    "&_IMSS_GETEmailAddress=" & _IMSS_INFO(1) & _
    "&IMSS_GET_PC_User_Name=" & _IMSS_INFO(2) & _
    "&IMSS_GET_OS_Version_String=" & _IMSS_INFO(3))
        System.Threading.Thread.Sleep(400)
    End Sub

    Private Shared Sub _IMSS_POST_PHP_REGEDIT(ByVal url As String, ByVal method As String, ByVal data As String)
        On Error Resume Next
        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(url)
        request.Method = method
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        dataStream.Close()
        response.Close()
    End Sub
End Class
