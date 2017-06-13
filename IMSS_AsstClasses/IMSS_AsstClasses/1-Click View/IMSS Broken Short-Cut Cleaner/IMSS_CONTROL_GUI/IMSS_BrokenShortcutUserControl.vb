Imports System.Windows.Forms

Public Class IMSS_BrokenShortcutUserControl


#Region "Thread Control Varibales"

    Public Property _IMSS_EXIT_CURRENT_PROCESS As Boolean = False

#End Region

    Private _IMSS_Desktop_Path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Private _IMSS_Documint_Path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Private _IMSS_History As String = Environment.GetFolderPath(Environment.SpecialFolder.History)
    Private _IMSS_Recent As String = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
    Private _IMSS_StartMenu As String = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
    Private _IMSS_Templates As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates)
    Private _IMSS_Favorites As String = Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
    Private _IMSS_InternetCache As String = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)

    Private _IMSS_TARGETS_TO_SCAN As New List(Of String)

    Public Sub New()

        InitializeComponent()

        _IMSS_TARGETS_TO_SCAN.Clear()

        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_Desktop_Path)
        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_Documint_Path)
        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_History)
        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_Recent)
        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_StartMenu)
        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_Templates)
        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_Favorites)
        _IMSS_TARGETS_TO_SCAN.Add(_IMSS_InternetCache)

    End Sub


    Public Property _IMSS_GET_SELECT_STATUS As Boolean
        Get
            Return _IMSS_SelectedValue.Checked
        End Get
        Set(ByVal _IMSS_VALUE As Boolean)
            _IMSS_SelectedValue.Checked = _IMSS_VALUE
        End Set
    End Property


    Public Sub _IMSS_START_CLEANNING()

        For Each _IMSS_TARGET As String In _IMSS_TARGETS_TO_SCAN

            If _IMSS_EXIT_CURRENT_PROCESS = True Then Return

            If Not String.IsNullOrEmpty(_IMSS_TARGET) Then

                If IO.Directory.Exists(_IMSS_TARGET) Then

                    RaiseEvent _IMSS_DO_MINOR_TEXT(IO.Path.GetFileName(_IMSS_TARGET))

                    Dim _IMSS_LOCAL_TARGETS() As String = IO.Directory.GetFiles(_IMSS_TARGET, "*.lnk", IO.SearchOption.TopDirectoryOnly)

                    _IMSS_SCAN_TARGET(_IMSS_LOCAL_TARGETS, _IMSS_LOCAL_TARGETS.Length())

                End If
            End If

        Next _IMSS_TARGET

    End Sub

    Private Sub _IMSS_SCAN_TARGET(ByRef _IMSS_LIST_OF_TARGET_FILES() As String, ByVal _IMSS_MAX_VALUE_PROGRESS As Integer)

        If _IMSS_EXIT_CURRENT_PROCESS = True Then Return

        RaiseEvent _IMSS_SEUPE_MAX_PROGRESS(_IMSS_MAX_VALUE_PROGRESS)

        For Each _IMSS_TARGETS In _IMSS_LIST_OF_TARGET_FILES

            If Not String.IsNullOrEmpty(_IMSS_TARGETS) Then

                If IO.File.Exists(_IMSS_TARGETS) Then

                    RaiseEvent _IMSS_DO_PROGRESS(1)

                    RaiseEvent _IMSS_DO_TEXT(_IMSS_TARGETS)

                    If _IMSS_CHECK_LINK_TARGET(_IMSS_TARGETS) = True Then

                        Try
                            _IMSS_DELETE_TARGET(_IMSS_TARGETS)
                        Catch : End Try

                    End If

                End If

            End If

        Next _IMSS_TARGETS

    End Sub

    Private Sub _IMSS_DELETE_TARGET(ByVal _IMSS_TARGET As String)

        If IO.Directory.Exists(_IMSS_TARGET) Then

            RaiseEvent _IMSS_DO_PROBLEMS()

            IO.Directory.Delete(_IMSS_TARGET)

        ElseIf IO.File.Exists(_IMSS_TARGET) Then

            RaiseEvent _IMSS_DO_PROBLEMS()

            IO.File.Delete(_IMSS_TARGET)

        End If

    End Sub
    Private Function _IMSS_CHECK_LINK_TARGET(ByVal FileName As String) As Boolean
        On Error GoTo _IMSS_ON_ERROR
        Dim Obj As Object : Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object : Shortcut = Obj.CreateShortcut(FileName)
        If IO.Path.HasExtension(Shortcut.TargetPath) Then
            If IO.File.Exists(Shortcut.TargetPath) Then Return False Else Return True
        Else
            If IO.Directory.Exists(Shortcut.TargetPath) Then Return False Else Return True
        End If
_IMSS_ON_ERROR:
        Return False
    End Function


    Private Sub _IMSS_OptionLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles _IMSS_OptionLinkLabel.LinkClicked

        Dim _IMSS_BrokenShortcutOptins As New IMSS_BrokenShortcutOptions(_IMSS_TARGETS_TO_SCAN)

        AddHandler _IMSS_BrokenShortcutOptins._IMSS_EDIT_TARGETS, Sub(_IMSS_TARGETS As List(Of String))

                                                                      _IMSS_TARGETS_TO_SCAN.Clear()

                                                                      _IMSS_TARGETS_TO_SCAN.AddRange(_IMSS_TARGETS)

                                                                  End Sub
        _IMSS_BrokenShortcutOptins.ShowDialog()

    End Sub

#Region "Udpate GUI Events"

    Public Delegate Sub _IMSS_DO_PROGRESS_DELEGATE(ByVal _IMSS_VALUE As Integer)

    Public Delegate Sub _IMSS_DO_TEXT_DELEGATE(ByVal _IMSS_TEXT As String)

    Public Delegate Sub _IMSS_DO_PROBLEMS_DELEGATE()

    Public Event _IMSS_SEUPE_MAX_PROGRESS As _IMSS_DO_PROGRESS_DELEGATE

    Public Event _IMSS_DO_PROGRESS As _IMSS_DO_PROGRESS_DELEGATE

    Public Event _IMSS_DO_TEXT As _IMSS_DO_TEXT_DELEGATE

    Public Event _IMSS_DO_MINOR_TEXT As _IMSS_DO_TEXT_DELEGATE

    Public Event _IMSS_DO_PROBLEMS As _IMSS_DO_PROBLEMS_DELEGATE

#End Region

End Class
