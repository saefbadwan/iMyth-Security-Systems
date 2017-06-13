' بسم الله الرحمن الرحيم

Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class IMSS_LOGS_OPER
    Implements IDisposable
    Private _IMSS_OleBDConn As New OleDbConnection
    Private _IMSS_OleDBCommand As OleDbCommand
    Private _IMSS_Prov As String = "Provider=Microsoft.JET.OLEDB.4.0;"
    Private _IMSS_DataSource As String = "Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & _
    "\IMSS\Data\_IMSS_Logs.mdb;Jet OLEDB:Database Password=19911024;"
    Private _IMSS_ConnectionString = _IMSS_Prov & _IMSS_DataSource
    Public Sub New()
        ' IMSS Create Connection On Class Load
        _IMSS_OleBDConn.ConnectionString = _IMSS_ConnectionString
    End Sub
    ' IMSS Open Connection
    Public ReadOnly Property _IMSS_Connect As Integer
        Get
            Try
                If Not _IMSS_OleBDConn.State = ConnectionState.Open Then
                    _IMSS_OleBDConn.Open()
                    Return 1 : End If
            Catch ex As Exception
                Return 0
            End Try
            Return 0
        End Get
    End Property

    ' IMSS Close Connection
    Public ReadOnly Property _IMSS_Disconnect As Integer
        Get
            Try
                If Not _IMSS_OleBDConn.State = ConnectionState.Closed Then
                    _IMSS_OleBDConn.Close()
                    Return 1
                End If
            Catch ex As Exception
                Return 0
            End Try
            Return 0
        End Get
    End Property
    Public Sub _IMSS_FORCE_COLSE()
        On Error Resume Next
        If _IMSS_OleBDConn.State = ConnectionState.Open Then _IMSS_OleBDConn.Close()
    End Sub
    ' OleDbCommand = New OleDbCommand(strCreate, conDatabase)
    Private Sub _IMSS_INSERT(ByVal _IMSS_ITEMS() As String)
        _IMSS_OleDBCommand = New OleDbCommand("INSERT INTO " & _IMSS_ITEMS(0) & " ( " & _IMSS_ITEMS(1) & ") VALUES ( @IMSS_TARGET)", _IMSS_OleBDConn)
        _IMSS_OleDBCommand.Parameters.AddWithValue("@IMSS_TARGET", _IMSS_ITEMS(2))
        _IMSS_OleDBCommand.ExecuteNonQuery()
        _IMSS_OleDBCommand.Dispose()
    End Sub
    Public Function _IMSS_INSERT_INTO(ByVal _IMSS_VALUE_STATUS As String, ByVal _IMSS_INSERT_TYPE As Integer) As Integer
        On Error GoTo _IMSS_ONError
        Select Case _IMSS_INSERT_TYPE
            Case 0
                _IMSS_INSERT(New String() {"IMSS_LOGS", "_IMSS_SECURITYLOGS", _IMSS_VALUE_STATUS}) : Return 1 : Exit Select
            Case 1
                _IMSS_INSERT(New String() {"IMSS_LOGS", "_IMSS_SYSTEMS_LOGS", _IMSS_VALUE_STATUS}) : Return 1 : Exit Select
            Case 2
                _IMSS_INSERT(New String() {"IMSS_LOGS", "_IMSS_USB_LOGS", _IMSS_VALUE_STATUS}) : Return 1 : Exit Select
            Case 3
                _IMSS_INSERT(New String() {"IMSS_LOGS", "_IMSS_QUARANTINE_LOGS", _IMSS_VALUE_STATUS}) : Return 1 : Exit Select
            Case 4
                _IMSS_INSERT(New String() {"IMSS_LOGS", "_IMSS_SETTINGS_LOGS", _IMSS_VALUE_STATUS}) : Return 1 : Exit Select
            Case Else
                Return 0 : Exit Select
        End Select
_IMSS_ONError:
        Return 0
    End Function
    Private Sub _IMSS_READ_TARGET(ByVal _IMSS_ITEMS() As String, ByRef _IMSS_TEXTOUTPUT As TextBox)
        _IMSS_OleDBCommand = New OleDbCommand("SELECT * FROM " & _IMSS_ITEMS(0), _IMSS_OleBDConn)
        Dim reader As OleDbDataReader = _IMSS_OleDBCommand.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                Application.DoEvents()
                If Not reader(_IMSS_ITEMS(1)) Is DBNull.Value = True Then _IMSS_TEXTOUTPUT.Text += reader(_IMSS_ITEMS(1)) & Environment.NewLine
            End While
        End If
        reader.Close()
        _IMSS_OleDBCommand.Dispose()
    End Sub
    Public Function _IMSS_LOAD_TARGET_LIST(ByVal _IMSS_TARGET_STATUS As Integer, ByRef _IMSS_TEXTOUTPUT As TextBox) As Integer
        On Error GoTo _IMSS_ONError
        Select Case _IMSS_TARGET_STATUS
            Case 0
                _IMSS_READ_TARGET(New String() {"IMSS_LOGS", "_IMSS_SECURITYLOGS"}, _IMSS_TEXTOUTPUT) : Return 1 : Exit Select
            Case 1
                _IMSS_READ_TARGET(New String() {"IMSS_LOGS", "_IMSS_SYSTEMS_LOGS"}, _IMSS_TEXTOUTPUT) : Return 1 : Exit Select
            Case 2
                _IMSS_READ_TARGET(New String() {"IMSS_LOGS", "_IMSS_USB_LOGS"}, _IMSS_TEXTOUTPUT) : Return 1 : Exit Select
            Case 3
                _IMSS_READ_TARGET(New String() {"IMSS_LOGS", "_IMSS_QUARANTINE_LOGS"}, _IMSS_TEXTOUTPUT) : Return 1 : Exit Select
            Case 4
                _IMSS_READ_TARGET(New String() {"IMSS_LOGS", "_IMSS_SETTINGS_LOGS"}, _IMSS_TEXTOUTPUT) : Return 1 : Exit Select
            Case Else
                Return 0 : Exit Select
        End Select
_IMSS_ONError:
        Return 0
    End Function

    Private Sub _IMSS_DELTE(ByVal _IMSS_TARGET As String)
        _IMSS_OleDBCommand = New OleDbCommand("UPDATE IMSS_LOGS SET " & _IMSS_TARGET & " = NULL", _IMSS_OleBDConn)
        _IMSS_OleDBCommand.ExecuteNonQuery()
        _IMSS_OleDBCommand.Dispose()
    End Sub

    Public Function _IMSS_DELETE_TARGET(ByVal _IMSS_TARGET As Integer)
        On Error GoTo _IMSS_ONError
        Select Case _IMSS_TARGET
            Case 0
                _IMSS_DELTE("_IMSS_SECURITYLOGS") : Return 1 : Exit Select
            Case 1
                _IMSS_DELTE("_IMSS_SYSTEMS_LOGS") : Return 1 : Exit Select
            Case 2
                _IMSS_DELTE("_IMSS_USB_LOGS") : Return 1 : Exit Select
            Case 3
                _IMSS_DELTE("_IMSS_QUARANTINE_LOGS") : Return 1 : Exit Select
            Case 4
                _IMSS_DELTE("_IMSS_SETTINGS_LOGS") : Return 1 : Exit Select
            Case Else
                Return 0
        End Select
_IMSS_ONError:
        Return 0
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    Public Shared Sub _IMSS_SQL_INSERT(ByVal _IMSS_STATUS As String, ByVal _IMSS_OPER As Integer)
        Try
            Dim _IMSS_SQL_TARGET As New ConfigurationResureses.IMSS_LOGS_OPER
            If _IMSS_SQL_TARGET._IMSS_Connect() = 1 Then
                _IMSS_SQL_TARGET._IMSS_INSERT_INTO(_IMSS_STATUS, _IMSS_OPER)
            End If
            If _IMSS_SQL_TARGET._IMSS_Disconnect() = 1 Then _IMSS_SQL_TARGET.Dispose() Else _IMSS_SQL_TARGET._IMSS_FORCE_COLSE() : _IMSS_SQL_TARGET.Dispose()
        Catch : End Try
    End Sub

End Class
