Public Class Form3
    Dim x = 1
    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Form2.Show()
        End If
        If e.KeyCode = Keys.E And x = 1 Then
            PictureBox2.Hide()
            PictureBox3.show()
            x = 2
        End If
        If e.KeyCode = Keys.A And x = 2 Then
            PictureBox3.Hide()
            PictureBox4.Show()
            x = 3
        End If
        If e.KeyCode = Keys.C And x = 3 Then
            PictureBox4.Hide()
            PictureBox5.Show()
            x = 4
        End If
        If e.KeyCode = Keys.D And x = 4 Then
            PictureBox5.Hide()
            PictureBox6.Show()
            x = 5
        End If
        If e.KeyCode = Keys.X And x = 5 Then
            PictureBox6.Hide()
            PictureBox7.Show()
            x = 6
        End If
        If e.KeyCode = Keys.V And x = 6 Then
            PictureBox7.Hide()
            PictureBox8.Show()
            x = 7
        End If
        If e.KeyCode = Keys.S And x = 7 Then
            PictureBox8.Hide()
            PictureBox9.Show()
            x = 8
        End If
        If e.KeyCode = Keys.P And x = 8 Then
            PictureBox9.Hide()
            PictureBox10.Show()
            x = 9
        End If
        If e.KeyCode = Keys.U And x = 9 Then
            PictureBox10.Hide()
            PictureBox11.Show()
            x = 10
        End If
        If e.KeyCode = Keys.H And x = 10 Then
            PictureBox11.Hide()
            Timer1.Stop()
            Form5.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox2.Show()
        PictureBox1.Hide()
        Timer1.Start()
        label1.text = 10
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            Timer1.Stop()
            Form4.Show()
        End If
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Form9.Show()
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click

    End Sub
End Class