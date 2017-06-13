Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class _IMSS_MD5SCANNER
    Public Shared Function _IMSS_Get_MD5_Hashes(ByVal filename As String) As String
        On Error Resume Next
        Dim m As New MD5CryptoServiceProvider
        Dim f As New FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
        m.ComputeHash(f)
        Dim hash As Byte() = m.Hash
        Dim builder As New StringBuilder
        Dim num As Byte
        For Each num In hash
            builder.Append(String.Format("{0:X2}", num))
        Next
        m.Clear()
        f.Close()
        Return (builder.ToString)
        Exit Function
    End Function
End Class