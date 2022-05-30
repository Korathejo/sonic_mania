Public Class Form8

    Private Sub Form8_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Form8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class