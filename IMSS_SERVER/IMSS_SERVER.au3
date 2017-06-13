#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.8.1
 Author:         myName

 Script Function:
	Template AutoIt script.

#ce ----------------------------------------------------------------------------

; Script Start - Add your code below here
#NoTrayIcon
#include <GUIConstantsEx.au3>
#include <EditConstants.au3>
#include <StaticConstants.au3>
#include <FileConstants.au3>
#include <ColorConstants.au3>
#include <ProgressConstants.au3>
#include <File.au3>
Opt('MustDeclareVars', 1)
;~ _IMSS_DecryptioGUI()
  Global $aPathSplit = _PathSplit(@ScriptDir, "", "", "", "")
Local $_IMSS_sFilePath = $aPathSplit[1] & "\PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA"
if FileExists($_IMSS_sFilePath) Then
    MainGUI()
ElseIf FileExists($aPathSplit[1] & "\PROTECTED_FILES\IMSS_PASSWD.IMSSDATA") Then
	_IMSS_LOGOUTGUI()
 Else
	Exit
 EndIf
Func MainGUI()
  Local $Button1, $Button2, $msg,$_IMSS_TextBoxPassword,$_IMSS_PasswordLabel,$_IMSS_PAsswordDescription_Label,$_IMSS_PasswordCheck
  GUICreate("IMSS LOGIN",400,100)
   GUISetState(@SW_SHOW)
   $_IMSS_PasswordLabel = GUICtrlCreateLabel("Please insert your password here to start decryption process !", 3, 3, 300, 20)
   $_IMSS_PasswordLabel = GUICtrlCreateLabel("Password : ", 3, 32, 60, 20)
   $_IMSS_PasswordCheck = GUICtrlCreateLabel("", 4, 80, 160, 20)
   $_IMSS_TextBoxPassword = GUICtrlCreateInput("", 60, 30, 334, 20,$ES_PASSWORD)

   $Button2 = GUICtrlCreateButton("Close",200, 74,100,24)
   $Button1 = GUICtrlCreateButton("Login", 300, 74,100,24)
  GUISetState()

  ; Run the GUI until the window is closed
  While 1
    $msg = GUIGetMsg()
    Select
     Case $msg = $GUI_EVENT_CLOSE
       ExitLoop
	Case $msg = $Button1
	   Local $_IMSS_INSERTED_PASSWORD_UINT = GUICtrlRead($_IMSS_TextBoxPassword)
			if _IMSS_CheckPasswordUint($_IMSS_INSERTED_PASSWORD_UINT) = True Then
			   GUICtrlSetColor($_IMSS_PasswordCheck, $COLOR_GREEN)
			   GUICtrlSetData($_IMSS_PasswordCheck, "")
			   GUISetState(@SW_Hide)
		  	   _IMSS_DecryptioGUI()
			Else
			   GUICtrlSetColor($_IMSS_PasswordCheck, $COLOR_RED)
			   GUICtrlSetData($_IMSS_TextBoxPassword, "")
			   GUICtrlSetData($_IMSS_PasswordCheck, "ACCESS REJECTED")
			EndIf
;~        MsgBox(0, 'Button 1', 'Button 1 was pressed')
     Case $msg = $Button2
       Exit
    EndSelect
  WEnd
EndFunc

Func _IMSS_DecryptioGUI()
     Local $_IMSS_ProgressBar, $_IMSS_LABEL_STATUS, $msg,$_IMSS_PasswordLabel
  GUICreate("IMSS LOGIN",400,90)
   GUISetState(@SW_SHOW)
   $_IMSS_PasswordLabel = GUICtrlCreateLabel("Decrypting files ... Please wait", 3, 16, 300, 20)
   $_IMSS_ProgressBar = GUICtrlCreateProgress(3, 36, 394, 20,$PBS_MARQUEE)
   $_IMSS_LABEL_STATUS = GUICtrlCreateLabel("Decrypting >> ", 3, 64, 394, 20)
  GUISetState()
  	_IMSS_Start_ProgressMarquee($_IMSS_ProgressBar) ; IMSS Starts
   _IMSS_DecrypteFiles($_IMSS_LABEL_STATUS)
   GUISetState(@SW_Hide)
   _IMSS_LOGOUTGUI()
  ; Run the GUI until the window is closed
  While 1
    $msg = GUIGetMsg()
    Select
     Case $msg = $GUI_EVENT_CLOSE
       ExitLoop
    EndSelect
  WEnd
       Exit
   EndFunc

   Func _IMSS_LOGOUTGUI()
     Local $Button1, $msg,$_IMSS_DescriptionLabel
  GUICreate("IMSS LOGIN",400,100)
   GUISetState(@SW_SHOW)
   $_IMSS_DescriptionLabel = GUICtrlCreateLabel("Please click on the logout button after your work is finished !", 3, 3, 300, 20)
   $Button1 = GUICtrlCreateButton("Logout", 300, 74,100,24)
  GUISetState()

  ; Run the GUI until the window is closed
  While 1
    $msg = GUIGetMsg()
    Select
     Case $msg = $GUI_EVENT_CLOSE
       ExitLoop
	Case $msg = $Button1
		 Local $_IMSS_ProgressBar = GUICtrlCreateProgress(3, 36, 394, 20,$PBS_MARQUEE)
		 _IMSS_Start_ProgressMarquee($_IMSS_ProgressBar)
		 _IMSS_EncrypteFiles()

    EndSelect
  WEnd
   EndFunc

   Func _IMSS_CheckPasswordUint(byref $_IMSS_StringText)
      Local $sFilePath = $aPathSplit[1] & "\PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}\IMSS_PASSWD.IMSSDATA"
    Local $hFileOpen = FileOpen($sFilePath, $FO_READ)
    If $hFileOpen = -1 Then
        Return False
    EndIf
	  Local $_IMSS_TARGET_PASSWORD_UINT= FileReadLine($hFileOpen, 1)
    FileClose($hFileOpen)
	Local $_IMSS_SplitString = StringSplit($_IMSS_TARGET_PASSWORD_UINT,"|")
	if $_IMSS_StringText = $_IMSS_SplitString[2] Then
	   Return True
	Else
	   Return False
	EndIf
   EndFunc

   Func _IMSS_DecrypteFiles(Byref $_IMSS_LABEL_STATUS)
	      Local $_IMSS_sFilePath = $aPathSplit[1] & "\PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
	      Local $_IMSS_Target_sFilePath = $aPathSplit[1] & "\PROTECTED_FILES"
		  if FileExists($_IMSS_sFilePath) Then
			FileSetAttrib($_IMSS_sFilePath, "-HS")
			FileSetAttrib($aPathSplit[1] & "\PROTECTED_FILES\IMSS_PASSWD.IMSSDATA","+HS")
			DirMove($_IMSS_sFilePath, $_IMSS_Target_sFilePath)
			Run("Explorer.exe " & $_IMSS_Target_sFilePath)
		 EndIf

	  EndFunc

	  Func _IMSS_EncrypteFiles()
		 Local $_IMSS_sFilePath = $aPathSplit[1] & "\PROTECTED_FILES.{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
		 Local $_IMSS_Target_sFilePath = $aPathSplit[1] & "\PROTECTED_FILES"
		  if FileExists($_IMSS_Target_sFilePath) Then
			FileSetAttrib($aPathSplit[1] & "\PROTECTED_FILES\IMSS_PASSWD.IMSSDATA","+N")
			DirMove($_IMSS_Target_sFilePath,$_IMSS_sFilePath)
			FileSetAttrib($_IMSS_sFilePath, "+HS")
		 EndIf
		 		 Exit
	  EndFunc


   Func _IMSS_Start_ProgressMarquee(ByRef $_IMSS_ProgressTarget)
	  GUICtrlSendMsg($_IMSS_ProgressTarget, $PBM_SETMARQUEE, True, 20)
   EndFunc
   Func _IMSS_Stop_ProgressMarquee(ByRef $_IMSS_ProgressTarget)
		 GUICtrlSendMsg($_IMSS_ProgressTarget, $PBM_SETMARQUEE, False, 20)
   EndFunc