' بسم الله الرحمن الرحيم

Module MainCore
    Sub Main()
        Dim strStartupArguments() As String = System.Environment.GetCommandLineArgs()
        If UBound(strStartupArguments) > 0 Then
            For i As Integer = 1 To UBound(strStartupArguments) Step 1
                _IMSS_CHECK_ITEM_TYPE(strStartupArguments(i))
            Next : Else : Application.Exit()
        End If : Application.Exit()
    End Sub
    Private Sub _IMSS_CHECK_ITEM_TYPE(ByVal _IMSS_STATUS_NAME As String)
        On Error Resume Next
        If IO.File.Exists(_IMSS_STATUS_NAME) = True Then : IO.File.Delete(_IMSS_STATUS_NAME)
        ElseIf IO.Directory.Exists(_IMSS_STATUS_NAME) = True Then : IO.Directory.Delete(_IMSS_STATUS_NAME)
        Else ' ERORR
        End If
    End Sub
End Module
