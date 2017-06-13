Imports System.Windows.Forms

Public Class IMSS_BrokenShortcutOptions

#Region "Eevnts Var"

    Public Delegate Sub _IMSS_EDIT_TARGETS_DELEGATE(ByVal _IMSS_TARGETS As List(Of String))
    Public Event _IMSS_EDIT_TARGETS As _IMSS_EDIT_TARGETS_DELEGATE

#End Region

    Public Sub New(ByRef _IMSS_PathsList As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _IMSS_SELECTED_PATHES.Items.Clear()
        For Each _IMSS_ITEM As String In _IMSS_PathsList
            _IMSS_SELECTED_PATHES.Items.Add(IO.Path.GetFileName(_IMSS_ITEM)).Tag = _IMSS_ITEM
        Next _IMSS_ITEM

    End Sub

    Private Sub _IMSS_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub _IMSS_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_OK.Click

        Dim _IMSS_TARGET_LIST As New List(Of String)

        For Each _IMSS_ITEM As ListViewItem In _IMSS_SELECTED_PATHES.Items

            If Not String.IsNullOrEmpty(_IMSS_ITEM.Text) Then

                _IMSS_TARGET_LIST.Add(_IMSS_ITEM.Tag.ToString())

            End If

        Next _IMSS_ITEM

        RaiseEvent _IMSS_EDIT_TARGETS(_IMSS_TARGET_LIST)

        Me.Close()

    End Sub

    Private Sub _IMSS_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Remove.Click
        If Not _IMSS_SELECTED_PATHES.SelectedItems.Count = 0 Then
            Try : _IMSS_SELECTED_PATHES.SelectedItems(0).Remove() : Catch : End Try
            If Not _IMSS_SELECTED_PATHES.Items.Count = 0 Then _IMSS_SELECTED_PATHES.Items(0).Selected = True
        End If
    End Sub

    Private Sub _IMSS_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Add.Click
        If _IMSS_AddFolders.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If _IMSS_AddFolders.SelectedPath.Length > 0 Then
                If IO.Directory.Exists(_IMSS_AddFolders.SelectedPath) = True Then
                    _IMSS_SELECTED_PATHES.Items.Add(IO.Path.GetFileName(_IMSS_AddFolders.SelectedPath)).Tag = _IMSS_AddFolders.SelectedPath
                End If
            End If
        End If
    End Sub
End Class