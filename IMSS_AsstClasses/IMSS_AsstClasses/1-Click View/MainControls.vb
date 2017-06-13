Imports System.Windows.Forms
Imports System.Threading
Imports System.Drawing

Public Class MainControls

    Private _IMSS_CURRENT_PROCESSING_CONTROL As Object = Nothing

    Private _IMSS_ON_CANCEL As Boolean = False

    Private _IMSS_LIST_OF_THREADS As New List(Of Thread)

    Private _IMSS_TOTAL_PROBLEMS As Long = 0
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_StartMaintenanc_Label.Click
        For i As Integer = 0 To -(Me._IMSS_MainPanel.Height / 2) Step -60
            Me._IMSS_MainPanel.Location = New System.Drawing.Point(Me._IMSS_MainPanel.Location.X, i)
            Application.DoEvents()
        Next i : Me._IMSS_MainPanel.Location = New System.Drawing.Point(Me._IMSS_MainPanel.Location.X, -(Me._IMSS_MainPanel.Height / 2))

        _IMSS_SetupProcessingGUI()

        Dim _IMSS_THREAD As New Thread(Sub()

                                           If _IMSS_BrokenShortcut_Control._IMSS_GET_SELECT_STATUS = True Then

                                               Me.Invoke(New MethodInvoker(AddressOf _IMSS_AddOneToCatgory))

                                               _IMSS_DO_CURRENT_CATORGY_TEXT("Cleaning Broken Shortcut Files ... ")

                                               _IMSS_CURRENT_PROCESSING_CONTROL = _IMSS_BrokenShortcut_Control

                                               _IMSS_BrokenShortcut_Control._IMSS_START_CLEANNING()

                                           End If

                                           If _IMSS_BrowserCleaner_Control._IMSS_GET_SELECT_STATUS = True Then

                                               Me.Invoke(New MethodInvoker(AddressOf _IMSS_AddOneToCatgory))

                                               _IMSS_DO_CURRENT_CATORGY_TEXT("Cleaning Browsers Files ... ")

                                               _IMSS_CURRENT_PROCESSING_CONTROL = _IMSS_BrowserCleaner_Control

                                               _IMSS_BrowserCleaner_Control._IMSS_START_CLEANNING()

                                           End If

                                           If _IMSS_WindowsCleaner_Control._IMSS_GET_SELECT_STATUS = True Then

                                               Me.Invoke(New MethodInvoker(AddressOf _IMSS_AddOneToCatgory))

                                               _IMSS_DO_CURRENT_CATORGY_TEXT("Cleaning Windows Temp Files ... ")

                                               _IMSS_CURRENT_PROCESSING_CONTROL = _IMSS_WindowsCleaner_Control

                                               _IMSS_WindowsCleaner_Control._IMSS_START_CLEANNING()

                                           End If

                                           Me.Invoke(New MethodInvoker(Sub()

                                                                           _IMSS_ON_COMPLETE(True)

                                                                       End Sub))

                                       End Sub) : _IMSS_LIST_OF_THREADS.Add(_IMSS_THREAD)

        _IMSS_THREAD.Start()

    End Sub




    Private Sub _IMSS_DO_PROGRESS(ByVal _IMSS_VALUE As Integer) Handles _IMSS_WindowsCleaner_Control._IMSS_DO_PROGRESS, _IMSS_BrowserCleaner_Control._IMSS_DO_PROGRESS, _IMSS_BrokenShortcut_Control._IMSS_DO_PROGRESS
        If _IMSS_CurrentProgress_ProgressBar.InvokeRequired = True Then
            _IMSS_CurrentProgress_ProgressBar.Invoke(New MethodInvoker(Sub()
                                                                           _IMSS_DO_PROGRESS(_IMSS_VALUE)
                                                                       End Sub))
        Else
            _IMSS_CurrentProgress_ProgressBar.Value += _IMSS_VALUE
        End If

    End Sub

    Private Sub _IMSS_SET_MAX_PROGRESS(ByVal _IMSS_VALUE As Integer) Handles _IMSS_WindowsCleaner_Control._IMSS_SEUPE_MAX_PROGRESS, _IMSS_BrowserCleaner_Control._IMSS_SEUPE_MAX_PROGRESS, _IMSS_BrokenShortcut_Control._IMSS_SEUPE_MAX_PROGRESS
        If _IMSS_CurrentProgress_ProgressBar.InvokeRequired = True Then
            _IMSS_CurrentProgress_ProgressBar.Invoke(New MethodInvoker(Sub()
                                                                           _IMSS_SET_MAX_PROGRESS(_IMSS_VALUE)
                                                                       End Sub))
        Else
            _IMSS_CurrentProgress_ProgressBar.Maximum = _IMSS_VALUE
            _IMSS_CurrentProgress_ProgressBar.Value = 0 ' Reset ProgressBar
        End If
    End Sub

    Private Sub _IMSS_DO_TEXT(ByVal _IMSS_TEXT As String) Handles _IMSS_WindowsCleaner_Control._IMSS_DO_TEXT, _IMSS_BrowserCleaner_Control._IMSS_DO_TEXT, _IMSS_BrokenShortcut_Control._IMSS_DO_TEXT
        If _IMSS_CurrentFile.InvokeRequired = True Then
            _IMSS_CurrentFile.Invoke(New MethodInvoker(Sub()

                                                           _IMSS_DO_TEXT(_IMSS_TEXT)

                                                       End Sub))
        Else

            Application.DoEvents() ' For more 1000 invoke

            _IMSS_CurrentFile.Text = _IMSS_TEXT
        End If
    End Sub

    Private Sub _IMSS_DO_MINOR_TEXT(ByVal _IMSS_TEXT As String) Handles _IMSS_WindowsCleaner_Control._IMSS_DO_MINOR_TEXT, _IMSS_BrowserCleaner_Control._IMSS_DO_MINOR_TEXT, _IMSS_BrokenShortcut_Control._IMSS_DO_MINOR_TEXT
        If _IMSS_MINOR_CATGORY_LABEL.InvokeRequired = True Then
            _IMSS_MINOR_CATGORY_LABEL.Invoke(New MethodInvoker(Sub()
                                                                   _IMSS_DO_MINOR_TEXT(_IMSS_TEXT)
                                                               End Sub))
        Else
            _IMSS_MINOR_CATGORY_LABEL.Text = _IMSS_TEXT
        End If
    End Sub

    Private Sub _IMSS_SWET_PROBLEMS() Handles _IMSS_WindowsCleaner_Control._IMSS_DO_PROBLEMS, _IMSS_BrokenShortcut_Control._IMSS_DO_PROBLEMS, _IMSS_BrowserCleaner_Control._IMSS_DO_PROBLEMS

        _IMSS_TOTAL_PROBLEMS += 1

    End Sub

    Private Delegate Sub _IMSS_DO_CURRENT_CATORGY_TEXT_DELEGATE(ByVal _IMSS_TEXT As String)
    Private Sub _IMSS_DO_CURRENT_CATORGY_TEXT(ByVal _IMSS_TEXT As String)
        If _IMSS_CurrentCatgory_Label.InvokeRequired = True Then
            _IMSS_CurrentCatgory_Label.Invoke(New _IMSS_DO_CURRENT_CATORGY_TEXT_DELEGATE(AddressOf _IMSS_DO_CURRENT_CATORGY_TEXT), _IMSS_TEXT)
        Else
            _IMSS_CurrentCatgory_Label.Text = _IMSS_TEXT
        End If
    End Sub

    Private Sub _IMSS_SetupProcessingGUI()

        Dim _IMSS_CLEANUP_UINTS_TOTAL As Int16 = 0


        For Each _IMSS_CONTROL As Object In _IMSS_CONTROLS_PANEL.Controls

            Try

                _IMSS_CONTROL._IMSS_EXIT_CURRENT_PROCESS = False

            Catch : End Try

            If _IMSS_CONTROL._IMSS_GET_SELECT_STATUS() = True Then
                _IMSS_CLEANUP_UINTS_TOTAL += 1
            End If


        Next _IMSS_CONTROL

        _IMSS_TOTAL_PROBLEMS = 0
        _IMSS_LoadingGif.Enabled = True
        _IMSS_Progress_StepIndicator.CurrentStep = 0
        _IMSS_Progress_StepIndicator.StepCount = CType(_IMSS_CLEANUP_UINTS_TOTAL, Integer)
        _IMSS_OverAllProgress_Label.Text = "0/" & _IMSS_CLEANUP_UINTS_TOTAL.ToString()
        _IMSS_OverAllProgress_Label.Tag = _IMSS_CLEANUP_UINTS_TOTAL.ToString()

    End Sub

    Private Sub _IMSS_AddOneToCatgory()

        _IMSS_OverAllProgress_Label.Text = (CType(_IMSS_OverAllProgress_Label.Text.Split("/")(0), Int16) + 1) & "/" & _IMSS_OverAllProgress_Label.Tag().ToString()

        _IMSS_Progress_StepIndicator.CurrentStep += 1

    End Sub

    Private Sub _IMSS_Skip_Button_Click(sender As Object, e As EventArgs) Handles _IMSS_Skip_Button.Click

        If Not (_IMSS_CURRENT_PROCESSING_CONTROL) Is Nothing Then

            _IMSS_CURRENT_PROCESSING_CONTROL._IMSS_EXIT_CURRENT_PROCESS = True

        End If

    End Sub

    Private Sub _IMSS_CancelAll_Button_Click(sender As Object, e As EventArgs) Handles _IMSS_CancelAll_Button.Click

        For Each _IMSS_THREAD In _IMSS_LIST_OF_THREADS

            If Not (_IMSS_THREAD) Is Nothing Then

                Try

                    _IMSS_THREAD.Abort()

                Catch : End Try

            End If

        Next _IMSS_THREAD

        _IMSS_ON_COMPLETE(False)

    End Sub

    Private Sub _IMSS_ON_COMPLETE(ByVal _IMSS_SUCCESS_STATUS As Boolean)

        _IMSS_LoadingGif.Enabled = False

        For i As Integer = -(Me._IMSS_MainPanel.Height / 2) To 0 Step +60
            Application.DoEvents()
            Me._IMSS_MainPanel.Location = New System.Drawing.Point(Me._IMSS_MainPanel.Location.X, i)
        Next i : Me._IMSS_MainPanel.Location = New System.Drawing.Point(Me._IMSS_MainPanel.Location.X, 0)

        If (_IMSS_SUCCESS_STATUS = True) Then

            Dim _IMSS_CompleteUi As New CompleteUi

            _IMSS_CompleteUi._IMSS_SET_RESULT = _IMSS_TOTAL_PROBLEMS.ToString("#,##0") & " - Problem was fixed"
            _IMSS_CompleteUi.Show()

        End If

    End Sub

    Private Sub _IMSS_LOW_SETTING_BUTTON_Click(sender As Object, e As EventArgs) Handles _IMSS_LOW_SETTING_BUTTON.Click

        _IMSS_ReSetControlsSettings(New Color() {Color.LightGray, Color.WhiteSmoke, Color.WhiteSmoke})

    End Sub

    Private Sub _IMSS_NORMAL_SETTING_BUTTON_Click(sender As Object, e As EventArgs) Handles _IMSS_NORMAL_SETTING_BUTTON.Click

        _IMSS_ReSetControlsSettings(New Color() {Color.WhiteSmoke, Color.LightGray, Color.WhiteSmoke})

    End Sub

    Private Sub _IMSS_ADVANCED_SETTING_BUTTON_Click(sender As Object, e As EventArgs) Handles _IMSS_ADVANCED_SETTING_BUTTON.Click

        _IMSS_ReSetControlsSettings(New Color() {Color.WhiteSmoke, Color.WhiteSmoke, Color.LightGray})

    End Sub

    Private Sub _IMSS_ReSetControlsSettings(ByVal _IMSS_SETTINGS() As Color)

        _IMSS_LOW_SETTING_BUTTON.BackColor = _IMSS_SETTINGS(0)

        _IMSS_NORMAL_SETTING_BUTTON.BackColor = _IMSS_SETTINGS(1)

        _IMSS_ADVANCED_SETTING_BUTTON.BackColor = _IMSS_SETTINGS(2)

    End Sub

End Class
