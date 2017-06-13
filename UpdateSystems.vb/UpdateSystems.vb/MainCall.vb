Imports System.Xml
Imports System.Windows.Forms
Imports System.Net

Public Class MainCall

    Public Property _IMSS_UPDATE_ASMBLE_URL As String = String.Empty
    Public Property _IMSS_UPDATE_CONFIG_URL As String = String.Empty
    Public Property _IMSS_CURRENT_VERSION As String = String.Empty
    Public Property _IMSS_UPDATE_CHECK_LENGTH As Short = 4
    Public Property _IMSS_UPDATE_CHECK_TYPE As Boolean = True

    Private _IMSS_UPDATE_VERSION As String = "Sub update"

    Private Delegate Sub _IMSS_Delegate()
    Private _IMSS_CONTROL_FORM As Form = Nothing

    Private _IMSS_DateConfigFile As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\IMSS\ConfigUpdate.IMSSDATA"

    Public Sub New(Optional ByRef IMSS_CONTROL_FORM As Form = Nothing)

        _IMSS_CONTROL_FORM = IMSS_CONTROL_FORM

    End Sub

    Public Sub _IMSS_RUN_UPDATE_SYSTEM()

        If _IMSS_UPDATE_CHECK_TYPE() = True Then ' If the update set to auto.

            _IMSS_CheckUpdates() ' Check for updates now.

        Else

            If _IMSS_CheckDateOfUpdate() = True Then ' Check for updates when the length is active.

                _IMSS_CheckUpdates() ' Check for updates now.

            End If

        End If

    End Sub

    Private Sub _IMSS_CheckUpdates()

        Dim _IMSS_THREAD As New Threading.Thread(Sub()

                                                     If _IMSS_IsConnectionAvailable() = True Then ' Check the internet connection

                                                         If _IMSS_CheckIfNewVersionIsAvilble() = True Then

                                                             ' If update is available 


                                                             _IMSS_CONTROL_FORM.Invoke(New _IMSS_Delegate(Sub()

                                                                                                              Dim _IMSS_UpdateUint As New MainWindow()
                                                                                                              With _IMSS_UpdateUint
                                                                                                                  ._IMSS_UPDATE_ASMBLE_URL = Me._IMSS_UPDATE_ASMBLE_URL
                                                                                                                  ._IMSS_UPDATE_VERSION = Me._IMSS_UPDATE_VERSION
                                                                                                              End With
                                                                                                              _IMSS_UpdateUint.Show()
                                                                                                          End Sub))



                                                         Else

                                                             ' If update is not a available

                                                             Exit Sub

                                                         End If

                                                     End If

                                                 End Sub) : _IMSS_THREAD.Start()

    End Sub

    Public Function _IMSS_QuickCheckForUpdates() As Boolean

        If _IMSS_IsConnectionAvailable() = True Then

            If _IMSS_CheckIfNewVersionIsAvilble() = True Then

                Return True

            Else

                Return False

            End If

        Else

            Return False

        End If

    End Function

    Private Function _IMSS_CheckIfNewVersionIsAvilble() As Boolean

        Dim _IMSS_UPDATE_STATUS As Boolean = False

        If SharedMethods._IMSS_CheckIfUrlIsExsits(_IMSS_UPDATE_CONFIG_URL) Then

            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(New Uri(_IMSS_UPDATE_CONFIG_URL))

            ' NB! Use the following line ONLY if the website is protected
            ' request.Credentials = New System.Net.NetworkCredential("username", "password")

            ' Call the remote site, and parse the data in a response object

            Dim response As System.Net.HttpWebResponse = request.GetResponse()

            ' Check if the response is OK (status code 200)
            If response.StatusCode = System.Net.HttpStatusCode.OK Then

                ' Parse the contents from the response to a stream object
                Dim stream As System.IO.Stream = response.GetResponseStream()
                ' Create a reader for the stream object
                Dim reader As New System.IO.StreamReader(stream)
                ' Read from the stream object using the reader, put the contents in a string
                Dim contents As String = reader.ReadToEnd()
                ' Create a new, empty XML document
                Dim document As New System.Xml.XmlDocument()

                ' Load the contents into the XML document

                document.LoadXml(contents)
                Dim XmlReader = New XmlNodeReader(document)

                While XmlReader.Read

                    If XmlReader.Name.ToString() = "_IMSS_VERSION" Then
                        Dim _IMSS_VERSION As Integer = CType(XmlReader.ReadInnerXml, Integer)
                        _IMSS_UPDATE_VERSION = _IMSS_VERSION
                        If _IMSS_VERSION = _IMSS_CURRENT_VERSION Then
                            _IMSS_UPDATE_STATUS = False
                        ElseIf _IMSS_VERSION > _IMSS_CURRENT_VERSION Then
                            _IMSS_UPDATE_STATUS = True
                        Else
                            _IMSS_UPDATE_STATUS = False
                        End If
                    End If

                End While
                stream.Close()
                reader.Close()
            End If
            response.Close()
            request.Abort()
        Else
            _IMSS_UPDATE_STATUS = False
        End If

        If _IMSS_UPDATE_STATUS = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function _IMSS_IsConnectionAvailable() As Boolean
        Dim _IMSS_URL As New System.Uri("http://www.google.com/")
        Dim _IMSS_WebRequest As System.Net.WebRequest
        _IMSS_WebRequest = System.Net.WebRequest.Create(_IMSS_URL)
        Dim _IMSS_WebResponse As System.Net.WebResponse
        Try
            _IMSS_WebResponse = _IMSS_WebRequest.GetResponse()
            _IMSS_WebResponse.Close()
            _IMSS_WebRequest = Nothing
            Return True
        Catch
            _IMSS_WebRequest = Nothing
            Return False
        End Try
    End Function

    Private Function _IMSS_CheckDateOfUpdate() As Boolean

        _IMSS_SetupUpdateDate()

        If (DateTime.Now.Subtract(New IO.FileInfo(_IMSS_DateConfigFile).LastWriteTime).Days >= _IMSS_UPDATE_CHECK_LENGTH) = True Then
            Try
                IO.File.Delete(_IMSS_DateConfigFile)
            Catch : End Try
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub _IMSS_SetupUpdateDate()


        If Not IO.File.Exists(_IMSS_DateConfigFile) Then

            IO.File.Create(_IMSS_DateConfigFile).Dispose()

        End If

    End Sub

End Class
