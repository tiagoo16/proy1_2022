Public Class frmmain
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.Show()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        frmLocalidad.Show()
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub RespIvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RespIvaToolStripMenuItem.Click
        frmIvavb.Show()
    End Sub

    Private Sub ImprimirIvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirIvaToolStripMenuItem.Click
        frmImprimirTasasIVA.Show()
    End Sub

    Private Sub ImprimirClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirClienteToolStripMenuItem.Click
        frmimprimircliente.Show()
    End Sub
End Class