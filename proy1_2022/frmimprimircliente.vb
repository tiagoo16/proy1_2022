Public Class frmimprimircliente
    Private Sub frmimprimircliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proy1_2022DataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Proy1_2022DataSet.clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class