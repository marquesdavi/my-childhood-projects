Imports System.Net


Public Class Form1



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "Arquivo para download|*.jpg|.exe|*.exe|.rar|*.rar|.zip|*.zip|.mp3|*.mp3|.iso|*.iso|.torrent|*.torrent"
        SaveFileDialog1.ShowDialog()
        TextBox2.Text = SaveFileDialog1.FileName
    End Sub


    Public WithEvents download As WebClient


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        download = New WebClient
        download.DownloadFileAsync(New Uri(TextBox1.Text), TextBox2.Text)
        If TextBox2.Text = "" Then
            MsgBox("Indique uma pasta de destino!", MsgBoxStyle.Critical)
        End If
        If TextBox1.Text = "" Then
            MsgBox("Indique uma URL para download!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub download_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles download.DownloadFileCompleted
        MessageBox.Show("Download completado!")
        ProgressBar1.Value = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub



    Private Sub download_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub



End Class
