<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIvavb
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIvavb))
        Me.Proy1_2022DataSet = New proy1_2022.proy1_2022DataSet()
        Me.Resp_IvaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Resp_IvaTableAdapter = New proy1_2022.proy1_2022DataSetTableAdapters.Resp_IvaTableAdapter()
        Me.TableAdapterManager = New proy1_2022.proy1_2022DataSetTableAdapters.TableAdapterManager()
        Me.Resp_IvaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Resp_IvaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Resp_IvaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Proy1_2022DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Resp_IvaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Resp_IvaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Resp_IvaBindingNavigator.SuspendLayout()
        CType(Me.Resp_IvaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Proy1_2022DataSet
        '
        Me.Proy1_2022DataSet.DataSetName = "proy1_2022DataSet"
        Me.Proy1_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Resp_IvaBindingSource
        '
        Me.Resp_IvaBindingSource.DataMember = "Resp_Iva"
        Me.Resp_IvaBindingSource.DataSource = Me.Proy1_2022DataSet
        '
        'Resp_IvaTableAdapter
        '
        Me.Resp_IvaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.Resp_IvaTableAdapter = Me.Resp_IvaTableAdapter
        Me.TableAdapterManager.UpdateOrder = proy1_2022.proy1_2022DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Resp_IvaBindingNavigator
        '
        Me.Resp_IvaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Resp_IvaBindingNavigator.BindingSource = Me.Resp_IvaBindingSource
        Me.Resp_IvaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Resp_IvaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Resp_IvaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Resp_IvaBindingNavigatorSaveItem})
        Me.Resp_IvaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Resp_IvaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Resp_IvaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Resp_IvaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Resp_IvaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Resp_IvaBindingNavigator.Name = "Resp_IvaBindingNavigator"
        Me.Resp_IvaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Resp_IvaBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Resp_IvaBindingNavigator.TabIndex = 0
        Me.Resp_IvaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Resp_IvaBindingNavigatorSaveItem
        '
        Me.Resp_IvaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Resp_IvaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Resp_IvaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Resp_IvaBindingNavigatorSaveItem.Name = "Resp_IvaBindingNavigatorSaveItem"
        Me.Resp_IvaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Resp_IvaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Resp_IvaDataGridView
        '
        Me.Resp_IvaDataGridView.AutoGenerateColumns = False
        Me.Resp_IvaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Resp_IvaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Resp_IvaDataGridView.DataSource = Me.Resp_IvaBindingSource
        Me.Resp_IvaDataGridView.Location = New System.Drawing.Point(-22, 28)
        Me.Resp_IvaDataGridView.Name = "Resp_IvaDataGridView"
        Me.Resp_IvaDataGridView.Size = New System.Drawing.Size(477, 220)
        Me.Resp_IvaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_resp_iva"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_resp_iva"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "descrip_iva"
        Me.DataGridViewTextBoxColumn2.HeaderText = "descrip_iva"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'frmIvavb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Resp_IvaDataGridView)
        Me.Controls.Add(Me.Resp_IvaBindingNavigator)
        Me.Name = "frmIvavb"
        Me.Text = "frmIvavb"
        CType(Me.Proy1_2022DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Resp_IvaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Resp_IvaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Resp_IvaBindingNavigator.ResumeLayout(False)
        Me.Resp_IvaBindingNavigator.PerformLayout()
        CType(Me.Resp_IvaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Proy1_2022DataSet As proy1_2022DataSet
    Friend WithEvents Resp_IvaBindingSource As BindingSource
    Friend WithEvents Resp_IvaTableAdapter As proy1_2022DataSetTableAdapters.Resp_IvaTableAdapter
    Friend WithEvents TableAdapterManager As proy1_2022DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Resp_IvaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Resp_IvaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Resp_IvaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
