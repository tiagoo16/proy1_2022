<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImprimirTasasIva
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Proy1_2022DataSet = New proy1_2022.proy1_2022DataSet()
        Me.Proy12022DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RespIvaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Resp_IvaTableAdapter = New proy1_2022.proy1_2022DataSetTableAdapters.Resp_IvaTableAdapter()
        Me.FKclientesidres15502E78BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New proy1_2022.proy1_2022DataSetTableAdapters.clientesTableAdapter()
        Me.LocalidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalidadesTableAdapter = New proy1_2022.proy1_2022DataSetTableAdapters.localidadesTableAdapter()
        Me.RespIvaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Proy1_2022DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Proy12022DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RespIvaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKclientesidres15502E78BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RespIvaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.RespIvaBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "proy1_2022.infIVA.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(107, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'Proy1_2022DataSet
        '
        Me.Proy1_2022DataSet.DataSetName = "proy1_2022DataSet"
        Me.Proy1_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Proy12022DataSetBindingSource
        '
        Me.Proy12022DataSetBindingSource.DataSource = Me.Proy1_2022DataSet
        Me.Proy12022DataSetBindingSource.Position = 0
        '
        'RespIvaBindingSource
        '
        Me.RespIvaBindingSource.DataMember = "Resp_Iva"
        Me.RespIvaBindingSource.DataSource = Me.Proy1_2022DataSet
        '
        'Resp_IvaTableAdapter
        '
        Me.Resp_IvaTableAdapter.ClearBeforeFill = True
        '
        'FKclientesidres15502E78BindingSource
        '
        Me.FKclientesidres15502E78BindingSource.DataMember = "FK__clientes__id_res__15502E78"
        Me.FKclientesidres15502E78BindingSource.DataSource = Me.RespIvaBindingSource
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'LocalidadesBindingSource
        '
        Me.LocalidadesBindingSource.DataMember = "localidades"
        Me.LocalidadesBindingSource.DataSource = Me.Proy12022DataSetBindingSource
        '
        'LocalidadesTableAdapter
        '
        Me.LocalidadesTableAdapter.ClearBeforeFill = True
        '
        'RespIvaBindingSource1
        '
        Me.RespIvaBindingSource1.DataMember = "Resp_Iva"
        Me.RespIvaBindingSource1.DataSource = Me.Proy12022DataSetBindingSource
        '
        'frmImprimirTasasIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmImprimirTasasIva"
        Me.Text = "frmImprimirTasasIva"
        CType(Me.Proy1_2022DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Proy12022DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RespIvaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKclientesidres15502E78BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RespIvaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Proy1_2022DataSet As proy1_2022DataSet
    Friend WithEvents Proy12022DataSetBindingSource As BindingSource
    Friend WithEvents RespIvaBindingSource As BindingSource
    Friend WithEvents Resp_IvaTableAdapter As proy1_2022DataSetTableAdapters.Resp_IvaTableAdapter
    Friend WithEvents FKclientesidres15502E78BindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As proy1_2022DataSetTableAdapters.clientesTableAdapter
    Friend WithEvents LocalidadesBindingSource As BindingSource
    Friend WithEvents LocalidadesTableAdapter As proy1_2022DataSetTableAdapters.localidadesTableAdapter
    Friend WithEvents RespIvaBindingSource1 As BindingSource
End Class
