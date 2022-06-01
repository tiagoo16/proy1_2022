Public Class frmLocalidad
    Private Sub LocalidadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LocalidadesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LocalidadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Proy1_2022DataSet)

    End Sub

    Private Sub frmLocalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proy1_2022DataSet.localidades' Puede moverla o quitarla según sea necesario.
        Me.LocalidadesTableAdapter.Fill(Me.Proy1_2022DataSet.localidades)

    End Sub


    Private Sub LocalidadesDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles LocalidadesDataGridView.KeyDown
        Dim wfrm As Integer = Nothing

        If wfrm = 1 Then
            If e.KeyData = Keys.Enter Then
                Dim frm As frmClientes = CType(Owner, frmClientes)
                frm.CpTextBox.Text = Me.LocalidadesDataGridView.CurrentRow.Cells(0).Value
                wfrm = 0
                Me.Close()
            End If
        End If
    End Sub
End Class