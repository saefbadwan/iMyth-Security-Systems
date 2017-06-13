Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Module _IMSS_MD5SCANNER
    Public Function _IMSS_Get_MD5_Hashes(ByVal _IMSS_TARGET_PATH As String, ByVal _IMSS_VBS_SCAN As Boolean) As String

        On Error Resume Next

        If (_IMSS_VBS_SCAN = True) Then

            Dim _IMSS_COPY_PATH As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS\" & IO.Path.GetFileName(_IMSS_TARGET_PATH)

            If IO.File.Exists(_IMSS_COPY_PATH) Then
                IO.File.Delete(_IMSS_COPY_PATH)
            End If

            IO.File.Copy(_IMSS_TARGET_PATH, _IMSS_COPY_PATH)

            System.Threading.Thread.Sleep(40)

            Dim _IMSS_LOCAL_HASHES As String = _IMSS_GET_HASHES(_IMSS_COPY_PATH)

            If IO.File.Exists(_IMSS_COPY_PATH) Then IO.File.Delete(_IMSS_COPY_PATH)

            Return _IMSS_LOCAL_HASHES

        Else

            Return _IMSS_GET_HASHES(_IMSS_TARGET_PATH)

        End If

    End Function

    Private Function _IMSS_GET_HASHES(ByVal _IMSS_TARGET_PATH As String) As String
        Dim m As New MD5CryptoServiceProvider
        Dim f As New FileStream(_IMSS_TARGET_PATH, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
        m.ComputeHash(f)
        Dim hash As Byte() = m.Hash
        Dim builder As New StringBuilder
        Dim num As Byte
        For Each num In hash
            builder.Append(String.Format("{0:X2}", num))
        Next
        m.Clear()
        f.Close()
        Return (builder.ToString())
        Exit Function
    End Function

End Module