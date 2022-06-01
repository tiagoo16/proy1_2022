Public Class frmlogin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If Me.txtusuario.Text = "tiago" And Me.txtcontraseña.Text = "1234" Then
            Dim frm As New frmmain
            frm.ShowDialog()
            Me.Close()
        Else
            MsgBox("Los datos son incorrectos", MsgBoxStyle.Critical, "Datos incorrectos")
            Me.txtcontraseña.Clear()
            Me.txtusuario.Clear()
            Me.txtusuario.Focus()
        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged
        Me.txtusuario.Select()
    End Sub
End Class