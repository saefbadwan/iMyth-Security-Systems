Public Class SharedMethods
    Public Shared Function _IMSS_CheckIfUrlIsExsits(ByVal _IMSS_URL As String) As Boolean
        Dim req As System.Net.WebRequest
        Dim res As System.Net.WebResponse
        req = System.Net.WebRequest.Create(_IMSS_URL)
        Try
            res = req.GetResponse()
            req.Abort()
            res.Close()
            Return True
        Catch
            Return False
        End Try
    End Function
    Public Shared Function _IMSS_FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"B", "KB", "MB", "GB"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop

        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function
End Class
