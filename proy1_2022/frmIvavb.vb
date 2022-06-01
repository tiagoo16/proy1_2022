Public Class frmIvavb
    Private Sub Resp_IvaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Resp_IvaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Resp_IvaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Proy1_2022DataSet)

    End Sub

    Private Sub frmIvavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proy1_2022DataSet.Resp_Iva' Puede moverla o quitarla según sea necesario.
        Me.Resp_IvaTableAdapter.Fill(Me.Proy1_2022DataSet.Resp_Iva)

    End Sub

    Private Sub Resp_IvaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Resp_IvaDataGridView.CellContentClick

    End Sub
End Class