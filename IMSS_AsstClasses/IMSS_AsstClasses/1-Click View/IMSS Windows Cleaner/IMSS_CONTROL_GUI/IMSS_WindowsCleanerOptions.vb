Imports System.Windows.Forms

Public Class IMSS_WindowsCleanerOptions

    Public Delegate Sub _IMSS_TARGETS_SETTINGS_DELEGATES(ByRef _IMSS_TARGETS_SETTINGS() As Boolean)

    Public Event _IMSS_TARGETS_SETTINGS As _IMSS_TARGETS_SETTINGS_DELEGATES


    Public Sub New(ByRef _IMSS_TARGETS_SETTINGS() As Boolean) ' boolean for the selected target to clean process


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        For Each _IMSS_ITEM As ListViewItem In _IMSS_SELECTED_TARGETS.Items

            _IMSS_ITEM.Checked = _IMSS_TARGETS_SETTINGS(_IMSS_ITEM.Index)

        Next _IMSS_ITEM

    End Sub

    Private Sub _IMSS_OK_Click(sender As Object, e As EventArgs) Handles _IMSS_OK.Click

        Dim _IMSS_TARGET_SETTINGS(3) As Boolean

        For Each _IMSS_ITEM As ListViewItem In _IMSS_SELECTED_TARGETS.Items

            _IMSS_TARGET_SETTINGS(_IMSS_ITEM.Index) = _IMSS_ITEM.Checked

        Next _IMSS_ITEM

        RaiseEvent _IMSS_TARGETS_SETTINGS(_IMSS_TARGET_SETTINGS)

        Me.Close()

    End Sub

    Private Sub _IMSS_CANCEL_Click(sender As Object, e As EventArgs) Handles _IMSS_CANCEL.Click

        Me.Close()

    End Sub
End Class