' بسم الله الرحمن الرحيم

Imports System.Drawing
Imports System.Windows.Forms

Public Class IMSS_Utilities
    Private _IMSS_OptimizeComputerControlUint As New IMSS_OptimizeComputerControlUint
    Private IMSS_CleanUpUtilities As New IMSS_CleanUpUtilities
    Private IMSS_InternetUtilities As New IMSS_InternetUtilities
    Private IMSS_FamilyUtilities As New IMSS_FamilyUtilities
    Private IMSS_RepairUtilities As New IMSS_RepairUtilities
    Private IMSS_OthersUtilies As New IMSS_OtherUtilities
    Private IMSS_LogSection As New IMSS_LogSection
    Public WriteOnly Property _IMSS_OptimizeClickProperty As Boolean
        Set(ByVal _IMSS_Starts As Boolean)
            'For i = 0 To -834 Step -4
            '    Application.DoEvents()
            '    Me.Location = New Point(i, 0)
            'Next i : Me.Location = New Point(-834, 0)
            '_IMSS_ControlHoolders.Location = New Point(7, -400)
            _IMSS_ControlHoolders.Location = New Point(7, 5)
            _IMSS_ButtonCleanupClick(False)
        End Set
    End Property

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OptimizeC.Click
        _IMSS_OptimizeComputerClick()
    End Sub

    Private Sub _IMSS_OptimizeComputerClick()
        ' _IMSS_PlayButtonClickSound()
        _IMSS_SetMenuButtonBackColor(Color.White, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
           Color.AliceBlue, Color.AliceBlue, _IMSS_OptimizeC)
        _IMSS_ReSetPanelControls(True, False, False, False, False, False, False, _IMSS_OptimizeComputerControlUint)
        'IMSS_CleanUpUtilities._IMSS_SET_SILDING_AS_DEFAULT = False
    End Sub

    Private Sub _IMSS_SetMenuButtonBackColor(ByVal _IMSS_Button1_Color As Color, _
                                               ByVal _IMSS_Button2_Color As Color, _
                                               ByVal _IMSS_Button3_Color As Color, _
                                               ByVal _IMSS_Button4_Color As Color, _
                                               ByVal _IMSS_Button5_Color As Color, _
                                               ByVal _IMSS_Button6_Color As Color, _
                                               ByVal _IMSS_Button7_Color As Color, _
                                               ByRef _IMSS_TARGET_BUTTON As Button)
        _IMSS_OptimizeC.BackColor = _IMSS_Button1_Color
        _IMSS_CleanUp.BackColor = _IMSS_Button2_Color
        _IMSS_Internet.BackColor = _IMSS_Button3_Color
        _IMSS_Family.BackColor = _IMSS_Button4_Color
        _IMSS_Repair.BackColor = _IMSS_Button5_Color
        _IMSS_Other.BackColor = _IMSS_Button6_Color
        _IMSS_Log.BackColor = _IMSS_Button7_Color

        Dim _IMSS_Font As New Font("Arial", 9.75, FontStyle.Regular)

        _IMSS_OptimizeC.Font = _IMSS_Font
        _IMSS_OptimizeC.FlatAppearance.BorderSize = 0
        _IMSS_CleanUp.Font = _IMSS_Font
        _IMSS_CleanUp.FlatAppearance.BorderSize = 0
        _IMSS_Internet.Font = _IMSS_Font
        _IMSS_Internet.FlatAppearance.BorderSize = 0
        _IMSS_Family.Font = _IMSS_Font
        _IMSS_Family.FlatAppearance.BorderSize = 0
        _IMSS_Repair.Font = _IMSS_Font
        _IMSS_Repair.FlatAppearance.BorderSize = 0
        _IMSS_Other.Font = _IMSS_Font
        _IMSS_Other.FlatAppearance.BorderSize = 0
        _IMSS_Log.Font = _IMSS_Font
        _IMSS_Log.FlatAppearance.BorderSize = 0

        _IMSS_TARGET_BUTTON.Font = New Font("MS Reference Sans Serif", 7.9, FontStyle.Bold)

        _IMSS_TARGET_BUTTON.FlatAppearance.BorderSize = 1
        _IMSS_TARGET_BUTTON.FlatAppearance.BorderColor = Color.LightGray
        _IMSS_Control_Assistance_Uint.Focus()
    End Sub
    Private Sub _IMSS_PlayButtonClickSound()
        My.Computer.Audio.Play(ConfigurationResureses.LinkVar._IMSS_MOUSE_CLICK, AudioPlayMode.Background)
    End Sub
    Private Sub _IMSS_CleanUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CleanUp.Click
        _IMSS_ButtonCleanupClick(True)
    End Sub

    Public Sub _IMSS_ButtonCleanupClick(ByVal _IMSS_STATUS As Boolean)
        '  If _IMSS_STATUS = True Then _IMSS_PlayButtonClickSound()
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.White, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
           Color.AliceBlue, Color.AliceBlue, _IMSS_CleanUp)
        _IMSS_ReSetPanelControls(False, True, False, False, False, False, False, IMSS_CleanUpUtilities)
    End Sub

    Private Sub _IMSS_Internet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Internet.Click
        '  _IMSS_PlayButtonClickSound()
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.White, Color.AliceBlue, Color.AliceBlue, _
           Color.AliceBlue, Color.AliceBlue, _IMSS_Internet)
        _IMSS_ReSetPanelControls(False, False, True, False, False, False, False, IMSS_InternetUtilities)
        ' IMSS_CleanUpUtilities._IMSS_SET_SILDING_AS_DEFAULT = False
    End Sub

    Private Sub _IMSS_Family_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Family.Click
        ' _IMSS_PlayButtonClickSound()
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.White, Color.AliceBlue, _
           Color.AliceBlue, Color.AliceBlue, _IMSS_Family)
        _IMSS_ReSetPanelControls(False, False, False, True, False, False, False, IMSS_FamilyUtilities)
        '   IMSS_CleanUpUtilities._IMSS_SET_SILDING_AS_DEFAULT = False
    End Sub

    Private Sub _IMSS_Repair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Repair.Click
        ' _IMSS_PlayButtonClickSound()
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.White, _
           Color.AliceBlue, Color.AliceBlue, _IMSS_Repair)
        _IMSS_ReSetPanelControls(False, False, False, False, True, False, False, IMSS_RepairUtilities)
        '    IMSS_CleanUpUtilities._IMSS_SET_SILDING_AS_DEFAULT = False
    End Sub

    Private Sub _IMSS_Other_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Other.Click
        ' _IMSS_PlayButtonClickSound()
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
           Color.White, Color.AliceBlue, _IMSS_Other)
        _IMSS_ReSetPanelControls(False, False, False, False, False, True, False, IMSS_OthersUtilies)
    End Sub

    Private Sub _IMSS_Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Log.Click
        IMSS_LogSection._IMSS_LoadLog()
        ' _IMSS_PlayButtonClickSound()
        _IMSS_SetMenuButtonBackColor(Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, Color.AliceBlue, _
           Color.AliceBlue, Color.White, _IMSS_Log)
        _IMSS_ReSetPanelControls(False, False, False, False, False, False, True, IMSS_LogSection)
    End Sub

    Private Sub IMSS_Utilities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _IMSS_SET_LOCATIONS_SIZE() ' Set panels locations and size
        _IMSS_Add_Controls() ' Add controls panels to main control panel
    End Sub
#Region " IMSS Add Controls To Assistance Uint And Set Default Panel"
    Private Sub _IMSS_Add_Controls()
        _IMSS_OptimizeComputerControlUint.Dock = DockStyle.Fill
        _IMSS_Control_Assistance_Uint.Controls.Add(_IMSS_OptimizeComputerControlUint)
        IMSS_CleanUpUtilities.Dock = DockStyle.Fill
        _IMSS_Control_Assistance_Uint.Controls.Add(IMSS_CleanUpUtilities)
        IMSS_InternetUtilities.Dock = DockStyle.Fill
        _IMSS_Control_Assistance_Uint.Controls.Add(IMSS_InternetUtilities)
        IMSS_FamilyUtilities.Dock = DockStyle.Fill
        _IMSS_Control_Assistance_Uint.Controls.Add(IMSS_FamilyUtilities)
        IMSS_RepairUtilities.Dock = DockStyle.Fill
        _IMSS_Control_Assistance_Uint.Controls.Add(IMSS_RepairUtilities)
        IMSS_OthersUtilies.Dock = DockStyle.Fill
        _IMSS_Control_Assistance_Uint.Controls.Add(IMSS_OthersUtilies)
        IMSS_LogSection.Dock = DockStyle.Fill
        _IMSS_Control_Assistance_Uint.Controls.Add(IMSS_LogSection)
        _IMSS_ReSetPanelControls(False, True, False, False, False, False, False, IMSS_CleanUpUtilities)
    End Sub
    Private Sub _IMSS_SET_LOCATIONS_SIZE()
        '_IMSS_Control_Assistance_Uint.Location = New Point(186, 8)
        _IMSS_Control_Assistance_Uint.Size = New Point(640, 379)
    End Sub
#End Region
    Private Sub _IMSS_ReSetPanelControls(ByVal _IMSS_Panel_1 As Boolean, ByVal _IMSS_Panel_2 As Boolean, ByVal _IMSS_Panel3 As Boolean _
                                            , ByVal _IMSS_Panel4 As Boolean, ByVal _IMSS_Panel5 As Boolean, ByVal _IMSS_Panel6 As Boolean, ByVal _IMSS_LogSection As Boolean, ByRef _IMSS_TargetPanel As Control)
        _IMSS_OptimizeComputerControlUint.Visible = _IMSS_Panel_1
        IMSS_CleanUpUtilities.Visible = _IMSS_Panel_2
        IMSS_InternetUtilities.Visible = _IMSS_Panel3
        IMSS_FamilyUtilities.Visible = _IMSS_Panel4
        IMSS_RepairUtilities.Visible = _IMSS_Panel5
        IMSS_OthersUtilies.Visible = _IMSS_Panel6
        _IMSS_TargetPanel.BringToFront()
        _IMSS_TargetPanel.Refresh()
    End Sub

End Class
