' بسم الله الرحمن الرحيم
Imports System.Collections.Generic
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Collections.Specialized
Imports System.Windows.Forms
Imports System.Collections
Imports System.ComponentModel

Public Class IMSS_VirusTotal

    Private apiKey As String = "f0dd5b55358bc30e9710233c99cf5caa58fdf8fa32333cf7f93d6eaf3369045e"

    Public Function checkWebsite(ByVal websiteUrl As String) As String
        Try
            ' Erzeuge WebClient
            ServicePointManager.Expect100Continue = False
            Dim wClient As New WebClient()

            ' Erzeuge Post-Data Collection und füge den API-Key hinzu
            Dim postCollection As New NameValueCollection()
            postCollection.Add("key", apiKey)
            postCollection.Add("url", websiteUrl)
            wClient.QueryString = postCollection

            ' Sende Anfrage an VirusTotal
            Dim respondArray As Byte() = wClient.UploadValues("https://www.virustotal.com/api/scan_url.json", "POST", postCollection)

            ' Konvertiere Anfrage und werte diesen aus
            Dim respondString As String = System.Text.Encoding.UTF8.GetString(respondArray, 0, respondArray.Length)
            Dim values As Hashtable = jsonParser(respondString)

            ' Überprüfe ob Verarbeitet wurde
            If Convert.ToInt16(values("result")) = 1 Then
                ' Gebe HashID als Url zurück
                Return "https://www.virustotal.com/url-scan/report.html?id=" & Convert.ToString(values("scan_id"))
            Else
                Return "ERROR"
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            Return "ERROR"
        End Try
    End Function


    Public Function checkFile(ByVal fileUrl As String) As String
        Try
            ' Überprüfe ob Datie vorhanden
            If Not File.Exists(fileUrl) Then
                Throw New FileNotFoundException("File can't be found !")
            End If

            ' Erzeuge WebClient als Binary Stream
            ServicePointManager.Expect100Continue = False
            Dim wClient As New WebClient()
            wClient.Headers.Add("Content-Type", "binary/octet-stream")

            ' Erzeuge Post-Data Collection und füge den API-Key hinzu
            Dim postCollection As New NameValueCollection()
            postCollection.Add("key", apiKey)
            wClient.QueryString = postCollection

            ' Sende Anfrage an VirusTotal
            Dim respondArray As Byte() = wClient.UploadFile("https://www.virustotal.com/api/scan_file.json", "POST", fileUrl)

            ' Konvertiere Anfrage und werte diesen aus
            Dim respondString As String = System.Text.Encoding.UTF8.GetString(respondArray, 0, respondArray.Length)

            Dim values As Hashtable = jsonParser(respondString)

            ' Überprüfe ob Verarbeitet wurde
            If Convert.ToInt16(values("result")) = 1 Then
                ' Gebe HashID als Url zurück
                Return "https://www.virustotal.com/file-scan/report.html?id=" & Convert.ToString(values("scan_id"))
            Else
                Return "ERROR"
            End If
        Catch ex As Exception
            ' MessageBox.Show(ex.ToString())
            Return "ERROR"
        End Try
    End Function


    Friend Function jsonParser(ByVal jsonCode As String) As Hashtable
        Dim valuePairs As New Hashtable()

        ' Splitte die einzelnen Fragmente in einzelne Datenpakete
        Dim dataParts As String() = jsonCode.Split(","c)

        ' Für jedes Datenfragment
        For Each dataPart As String In dataParts

            ' Variable
            Dim VstartIndex As Integer = dataPart.IndexOf(""""c, 0) + 1
            Dim VendIndex As Integer = dataPart.IndexOf(""""c, VstartIndex)
            Dim variable As String = dataPart.Substring(VstartIndex, VendIndex - VstartIndex)

            ' Value
            Dim AstartIndex As Integer = dataPart.IndexOf(""""c, dataPart.IndexOf(":"c, VendIndex)) + 1
            Dim AendIndex As Integer = dataPart.IndexOf(""""c, AstartIndex + 1)
            Dim value As String = dataPart.Substring(AstartIndex, AendIndex - AstartIndex)

            ' Überprüfe Value
            If [String].IsNullOrEmpty(value.Replace(" ", "")) Then
                ' Es handelt sich um eine Zahl (keine "-Zeichen vorhanden)
                AstartIndex = dataPart.IndexOf(":"c, VendIndex + 1)

                ' Prüfe ob letztes Datenpaket
                If dataPart.IndexOf("}"c, AstartIndex) = -1 Then
                    ' Nicht das letzte Datensegment
                    value = dataPart.Substring(AstartIndex + 1, dataPart.Length - AstartIndex - 1).Replace(" ", "")
                Else
                    ' Das letzte Datensegment
                    Dim nextBracket As Integer = dataPart.IndexOf("}"c, AstartIndex) - 1
                    value = dataPart.Substring(AstartIndex + 1, nextBracket - AstartIndex).Replace(" ", "")
                End If
            End If
            valuePairs.Add(variable, value)
        Next
        Return valuePairs
    End Function
End Class
