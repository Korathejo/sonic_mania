Public Class Form1


    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        Else : Me.Hide()
            Form2.Show()
        End If
    End Sub
End Class

