<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDescargar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(21, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(509, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'btnAnadir
        '
        Me.btnAnadir.BackColor = System.Drawing.Color.White
        Me.btnAnadir.Location = New System.Drawing.Point(21, 114)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(509, 56)
        Me.btnAnadir.TabIndex = 14
        Me.btnAnadir.Text = "Añadir "
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(549, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(710, 646)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 676)
        Me.Panel1.TabIndex = 18
        '
        'btnDescargar
        '
        Me.btnDescargar.BackColor = System.Drawing.Color.White
        Me.btnDescargar.Location = New System.Drawing.Point(21, 187)
        Me.btnDescargar.Name = "btnDescargar"
        Me.btnDescargar.Size = New System.Drawing.Size(509, 60)
        Me.btnDescargar.TabIndex = 18
        Me.btnDescargar.Text = "Descargar"
        Me.btnDescargar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1259, 646)
        Me.Controls.Add(Me.btnDescargar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAnadir As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDescargar As Button
End Class
