Imports System.Net.Mail


Public Class IMSS_REGE_SUB_FUNCTIONS
    '<DllImport("Kernel32.dll")> _
    'Private Shared Function GetLocaleInfo(ByVal Locale As UInteger, ByVal LCType As UInteger, <Out()> ByVal lpLCData As System.Text.StringBuilder, ByVal cchDate As Integer) As Integer
    'End Function

    'Private Const LOCALE_SYSTEM_DEFAULT As UInteger = &H400
    'Private Const LOCALE_SENGCOUNTRY As UInteger = &H1002

    'Private Shared Function GetInfo(ByVal lInfo As UInteger) As String
    '    Dim lpLCdata = New System.Text.StringBuilder(256)
    '    Dim ret As Integer = GetLocaleInfo(LOCALE_SYSTEM_DEFAULT, lInfo, lpLCdata, lpLCdata.Capacity)
    '    If ret = 0 Then
    '        Return lpLCdata.ToString().Substring(0, ret - 1)
    '    End If
    '    Return String.Empty
    'End Function
    'Public Shared Function _IMSS_GET_COUNTRY(ByVal _IMSS_IP_ADDRESS As String) As String
    '    Try
    '        If _IMSS_IP_ADDRESS.Length > 0 Then
    '            Return _IMSS_GetCountry(_IMSS_IP_ADDRESS)
    '        Else
    '            Dim _IMSS_Country As String = (GetInfo(LOCALE_SENGCOUNTRY))
    '            If _IMSS_Country.Length > 0 Then
    '                Return _IMSS_Country
    '            Else
    '                Return "_IMSS_ERROR_10"
    '            End If
    '        End If
    '    Catch
    '        Try
    '            Return (GetInfo(LOCALE_SENGCOUNTRY))
    '        Catch
    '            Return "_IMSS_ERROR_4"
    '        End Try
    '    End Try
    'End Function

    'Public Shared Function _IMSS_GetExternalIp() As String
    '    Try
    '        Dim ExternalIP As String
    '        ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
    '        ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
    '                     .Matches(ExternalIP)(0).ToString()
    '        Return ExternalIP
    '    Catch
    '        Return Nothing
    '    End Try
    'End Function

    'Private Shared Function _IMSS_GetCountry(ByVal _IMSS_IP_ADDRESS As String)
    '    Try
    '        Return (New WebClient()).DownloadString("http://api.ipinfodb.com/v3/ip-city/?key=bf3497a82f93e7f4a4fd0baa9c9b3703001364a548b3348d5934894106d738b4&ip=" & _IMSS_IP_ADDRESS)
    '    Catch
    '        Return ""
    '    End Try

    'End Function

    Public Shared Function _IMSS_CLEANUP_STRING_TEXT(ByVal _IMSS_TEXT As String) As String
        If Not String.IsNullOrEmpty(_IMSS_TEXT.Replace("'", "").Replace("/", "").Replace("\", "").Replace("?", "")) Then
            Return _IMSS_TEXT.Replace("'", "").Replace("/", "").Replace("\", "").Replace("?", "")
        Else
            Return "_IMSS_Name_ERROR_FILTRING"
        End If
    End Function
    Public Shared Function _IMSS_ReCheckTestBox(ByVal _IMSS_TEXT As String) As String
        If String.IsNullOrEmpty(_IMSS_TEXT) Then
            Return "_IMSS_Name_ERROR"
        Else
            Return _IMSS_CLEANUP_STRING_TEXT(_IMSS_TEXT)
        End If
    End Function

    Public Shared Function _IMSS_EmailAddressChecker(ByVal emailAddress As String) As Boolean
        Try
            Dim testAddress = New MailAddress(emailAddress)
            Return True
        Catch ex As FormatException
            Return False
        End Try
    End Function
End Class
