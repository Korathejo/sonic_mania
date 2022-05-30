Public Class Form6
    Dim v As Integer = 0
    Dim d As Integer = 0
    Dim e As Integer = 0

   
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim x As Integer = CInt((3 * Rnd()))
        Randomize()
        PictureBox5.Show()
        PictureBox5.BringToFront()
        If x = 1 Then
            Label1.Text = "Empate"
            PictureBox9.Show()
            PictureBox9.BringToFront()
            Label7.Text = Label7.Text + 1
        End If
        If x = 2 Then
            Label1.Text = "Derrota"
            PictureBox10.Show()
            PictureBox10.BringToFront()
            Label6.Text = Label6.Text + 1
        End If
        If x = 3 Then
            Label1.Text = "Vitória"
            PictureBox11.Show()
            PictureBox11.BringToFront()
            Label5.Text = Label5.Text + 1
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim x As Integer = CInt((3 * Rnd()))
        Randomize()
        PictureBox6.Show()
        PictureBox6.BringToFront()
        If x = 1 Then
            Label1.Text = "Vitória"
            PictureBox9.Show()
            PictureBox9.BringToFront()
            Label5.Text = Label5.Text + 1
        End If
        If x = 2 Then
            Label1.Text = "Empate"
            PictureBox10.Show()
            PictureBox10.BringToFront()
            Label7.Text = Label7.Text + 1
        End If
        If x = 3 Then
            Label1.Text = "Derrota"
            PictureBox11.Show()
            PictureBox11.BringToFront()
            Label6.Text = Label6.Text + 1
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim x As Integer = CInt((3 * Rnd()))
        Randomize()
        PictureBox7.Show()
        PictureBox7.BringToFront()
        If x = 1 Then
            Label1.Text = "Derrota"
            PictureBox9.Show()
            PictureBox9.BringToFront()
            Label6.Text = Label6.Text + 1
        End If
        If x = 2 Then
            Label1.Text = "Vitória"
            PictureBox10.Show()
            PictureBox10.BringToFront()
            Label5.Text = Label5.Text + 1
        End If
        If x = 3 Then
            Label1.Text = "Empate"
            PictureBox11.Show()
            PictureBox11.BringToFront()
            Label7.Text = Label7.Text + 1
        End If
    End Sub

    Private Sub Form6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Form2.Show()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form9.Show()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub
End Class