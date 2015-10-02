Public Class Form1


    Private Sub ubah(sender As Object, e As EventArgs)

    End Sub

    Private Sub ganti_Click(sender As Object, e As EventArgs) Handles ganti.Click
        If Me.BackColor = Color.PeachPuff Then
            Me.BackColor = Color.MediumTurquoise
        Else
            Me.BackColor = Color.PeachPuff
        End If
    End Sub

    Private Sub form_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.PeachPuff
    End Sub
End Class
