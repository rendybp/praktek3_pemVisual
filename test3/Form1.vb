Public Class Form1

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        If CInt(nilaiInput.Text) >= 65 Then
            MessageBox.Show("Selamat Anda dinyatakan LULUS", "HASIL UJIAN",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Anda dinyatakan TIDAK LULUS", "HASIL UJIAN",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnUlangi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlangi.Click
        namaInput.Text = " "
        nimInput.Text = "0"
        nilaiInput.Text = "0"
        namaInput.Focus()
    End Sub
End Class
