Public Class Iniciando

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment("1")
        If ProgressBar1.Value = 50 Then
            ProgressBar1.Value = 80
        End If
        If ProgressBar1.Value = 100 Then
            Sistema.Show()
            Me.Hide()
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
