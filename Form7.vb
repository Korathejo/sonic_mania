Public Class Form7
    Dim x As Byte
    Dim y As Byte = 0
    Public Sub Form7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Form2.Show()
        End If
    End Sub

    Public Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        x = 1
    End Sub
    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        x = 4
    End Sub
    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        x = 3
    End Sub
    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click
        x = 2
    End Sub

    Public Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If x = 1 Then
            PictureBox1.Hide()
            PictureBox9.Width = PictureBox9.Width * 2
            PictureBox9.Height = 225
            PictureBox9.Location = New Point(400, 225)
            y = y + 1
        Else : Form8.Show()
        End If
    End Sub
    Public Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        If x = 2 Then
            PictureBox2.Hide()
            PictureBox10.Width = PictureBox10.Width * 2
            PictureBox10.Height = 225
            PictureBox10.Location = New Point(800, 225)
            y = y + 1
        Else : Form8.Show()
        End If
    End Sub
    Public Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        If x = 3 Then
            PictureBox3.Hide()
            PictureBox8.Width = PictureBox8.Width * 2
            PictureBox8.Height = 225
            PictureBox8.Location = New Point(400, 450)
            y = y + 1
        Else : Form8.Show()
        End If
    End Sub
    Public Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        If x = 4 Then
            PictureBox4.Hide()
            PictureBox7.Width = PictureBox7.Width * 2
            PictureBox7.Height = 225
            PictureBox7.Location = New Point(800, 450)
            y = y + 1
        Else : Form8.Show()
        End If
    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If y = 4 Then
            Form5.Show()
            Timer1.Stop()
        End If
        Label1.Text = Label1.Text + 1
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Text = 0
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form9.Show()
    End Sub
End Class