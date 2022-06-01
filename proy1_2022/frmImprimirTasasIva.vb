Public Class frmImprimirTasasIva
    Private Sub frmImprimirTasasIva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proy1_2022DataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.Proy1_2022DataSet.localidades)
        'TODO: esta línea de código carga datos en la tabla 'Proy1_2022DataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Proy1_2022DataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'Proy1_2022DataSet.Resp_Iva' Puede moverla o quitarla según sea necesario.
        Me.Resp_IvaTableAdapter.Fill(Me.Proy1_2022DataSet.Resp_Iva)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub
End Class