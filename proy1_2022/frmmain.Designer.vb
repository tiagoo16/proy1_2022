<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RespIvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirIvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.LocalidadesToolStripMenuItem, Me.RespIvaToolStripMenuItem, Me.ImprimirIvaToolStripMenuItem, Me.ImprimirClienteToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'LocalidadesToolStripMenuItem
        '
        Me.LocalidadesToolStripMenuItem.Name = "LocalidadesToolStripMenuItem"
        Me.LocalidadesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LocalidadesToolStripMenuItem.Text = "Localidades"
        '
        'RespIvaToolStripMenuItem
        '
        Me.RespIvaToolStripMenuItem.Name = "RespIvaToolStripMenuItem"
        Me.RespIvaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RespIvaToolStripMenuItem.Text = "Resp_Iva"
        '
        'ImprimirIvaToolStripMenuItem
        '
        Me.ImprimirIvaToolStripMenuItem.Name = "ImprimirIvaToolStripMenuItem"
        Me.ImprimirIvaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirIvaToolStripMenuItem.Text = "Imprimir Iva"
        '
        'ImprimirClienteToolStripMenuItem
        '
        Me.ImprimirClienteToolStripMenuItem.Name = "ImprimirClienteToolStripMenuItem"
        Me.ImprimirClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirClienteToolStripMenuItem.Text = "Imprimir cliente"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmain"
        Me.Text = "frmmain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RespIvaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirIvaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirClienteToolStripMenuItem As ToolStripMenuItem
End Class
