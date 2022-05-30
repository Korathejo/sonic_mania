Public Class Form5

    Public Sub Form5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Form10.Close()
            Form7.Close()
            Form2.Show()
        End If
    End Sub
End Class