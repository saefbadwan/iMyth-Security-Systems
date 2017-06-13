Imports System.Drawing

Public Class _IMSS_MINI_UINT
    Public Property _IMSS_Main_Title As String
        Get
            Return _IMSS_Title.Text
        End Get
        Set(ByVal _IMSS_Value As String)
            _IMSS_Title.Text = _IMSS_Value
        End Set
    End Property
    Public Property _IMSS_Main_Text As String
        Get
            Return _IMSS_TargetText_Label.Text
        End Get
        Set(ByVal _IMSS_Value As String)
            _IMSS_TargetText_Label.Text = _IMSS_Value
        End Set
    End Property
    Public Property _IMSS_Main_Logo As Image
        Get
            Return _IMSS_PictureBox_Logo.Image
        End Get
        Set(ByVal _IMSS_TargetImage As Image)
            _IMSS_PictureBox_Logo.Image = _IMSS_TargetImage
        End Set
    End Property

    Public Property _IMSS_SET_RATING_TOTAL As Integer
        Get
            Return _IMSS_RATING_CONTROL.Rating
        End Get
        Set(ByVal _IMSS_RATING_TOTAL As Integer)
            _IMSS_RATING_CONTROL.Rating = _IMSS_RATING_TOTAL
        End Set
    End Property

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.support.im-ss.net/")
    End Sub
End Class
