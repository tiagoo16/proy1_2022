Public Class frmClientes
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Proy1_2022DataSet)

    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proy1_2022DataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Proy1_2022DataSet.clientes)

    End Sub

    Private Sub CpTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CpTextBox.KeyDown
        If Me.CpTextBox.Text = "" Then
            If e.KeyData = Keys.Enter Then
                Dim wfrm As Integer
                wfrm = 1
                Dim frm As New frmLocalidad
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ClientesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub

    Private Sub Id_resp_ivaTextBox_TextChanged(sender As Object, e As EventArgs) Handles Id_resp_ivaTextBox.TextChanged

    End Sub

    Private Sub Id_resp_ivaTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Id_resp_ivaTextBox.KeyDown
        If Me.Id_resp_ivaTextBox.Text = "" Then
            If e.KeyData = Keys.Enter Then
                Dim wfrm As Integer
                wfrm = 1
                Dim frm As New frmIvavb
                AddOwnedForm(frm)
                frm.ShowDialog()
            End If
        End If
    End Sub
End Class