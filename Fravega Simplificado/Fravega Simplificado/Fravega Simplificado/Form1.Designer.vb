<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label10 = New Label()
        lblStock = New Label()
        Label8 = New Label()
        Panel2 = New Panel()
        txtDescripcion = New TextBox()
        txtModelo = New TextBox()
        RadioButtonHeladera = New RadioButton()
        RadioButtonLavarropas = New RadioButton()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        btnAlta = New Button()
        txtConsumo = New TextBox()
        txtCapacidad = New TextBox()
        txtColor = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        btnComprar = New Button()
        txtPreciodeCompra = New TextBox()
        txtCantidadCompra = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Panel5 = New Panel()
        btnVender = New Button()
        txtPreciodeVenta = New TextBox()
        txtCantidadVenta = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(lblStock)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(386, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(274, 82)
        Panel1.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(159, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 25)
        Label10.TabIndex = 2
        Label10.Text = "Unid."
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStock.ForeColor = Color.White
        lblStock.Location = New Point(112, 20)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(20, 25)
        lblStock.TabIndex = 1
        lblStock.Text = "-"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(22, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 25)
        Label8.TabIndex = 0
        Label8.Text = "STOCK"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Panel2.Controls.Add(txtDescripcion)
        Panel2.Controls.Add(txtModelo)
        Panel2.Controls.Add(RadioButtonHeladera)
        Panel2.Controls.Add(RadioButtonLavarropas)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(368, 180)
        Panel2.TabIndex = 1
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(102, 52)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(217, 23)
        txtDescripcion.TabIndex = 5
        ' 
        ' txtModelo
        ' 
        txtModelo.Location = New Point(102, 17)
        txtModelo.Name = "txtModelo"
        txtModelo.Size = New Size(153, 23)
        txtModelo.TabIndex = 4
        ' 
        ' RadioButtonHeladera
        ' 
        RadioButtonHeladera.AutoSize = True
        RadioButtonHeladera.Location = New Point(183, 132)
        RadioButtonHeladera.Name = "RadioButtonHeladera"
        RadioButtonHeladera.Size = New Size(72, 19)
        RadioButtonHeladera.TabIndex = 3
        RadioButtonHeladera.TabStop = True
        RadioButtonHeladera.Text = "Heladera"
        RadioButtonHeladera.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonLavarropas
        ' 
        RadioButtonLavarropas.AutoSize = True
        RadioButtonLavarropas.Location = New Point(78, 132)
        RadioButtonLavarropas.Name = "RadioButtonLavarropas"
        RadioButtonLavarropas.Size = New Size(82, 19)
        RadioButtonLavarropas.TabIndex = 2
        RadioButtonLavarropas.TabStop = True
        RadioButtonLavarropas.Text = "Lavarropas"
        RadioButtonLavarropas.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 1
        Label2.Text = "Descripción:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 0
        Label1.Text = "Modelo:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Panel3.Controls.Add(btnAlta)
        Panel3.Controls.Add(txtConsumo)
        Panel3.Controls.Add(txtCapacidad)
        Panel3.Controls.Add(txtColor)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(12, 198)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(368, 171)
        Panel3.TabIndex = 2
        ' 
        ' btnAlta
        ' 
        btnAlta.BackColor = Color.Fuchsia
        btnAlta.FlatStyle = FlatStyle.Flat
        btnAlta.ForeColor = Color.White
        btnAlta.Location = New Point(251, 33)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(100, 111)
        btnAlta.TabIndex = 8
        btnAlta.Text = "ALTA"
        btnAlta.UseVisualStyleBackColor = False
        ' 
        ' txtConsumo
        ' 
        txtConsumo.Location = New Point(121, 126)
        txtConsumo.Name = "txtConsumo"
        txtConsumo.Size = New Size(63, 23)
        txtConsumo.TabIndex = 7
        ' 
        ' txtCapacidad
        ' 
        txtCapacidad.Location = New Point(121, 82)
        txtCapacidad.Name = "txtCapacidad"
        txtCapacidad.Size = New Size(63, 23)
        txtCapacidad.TabIndex = 6
        ' 
        ' txtColor
        ' 
        txtColor.Location = New Point(121, 30)
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(100, 23)
        txtColor.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(190, 129)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 15)
        Label7.TabIndex = 4
        Label7.Text = "Watt"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(190, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 3
        Label6.Text = "Kg/Litros"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(43, 127)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 2
        Label5.Text = "Consumo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 15)
        Label4.TabIndex = 1
        Label4.Text = "Capacidad:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 0
        Label3.Text = "Color:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel4.Controls.Add(btnComprar)
        Panel4.Controls.Add(txtPreciodeCompra)
        Panel4.Controls.Add(txtCantidadCompra)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(Label11)
        Panel4.Location = New Point(386, 100)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(274, 137)
        Panel4.TabIndex = 3
        ' 
        ' btnComprar
        ' 
        btnComprar.BackColor = Color.Purple
        btnComprar.FlatStyle = FlatStyle.Popup
        btnComprar.Location = New Point(47, 102)
        btnComprar.Name = "btnComprar"
        btnComprar.Size = New Size(211, 23)
        btnComprar.TabIndex = 4
        btnComprar.Text = "Comprar"
        btnComprar.UseVisualStyleBackColor = False
        ' 
        ' txtPreciodeCompra
        ' 
        txtPreciodeCompra.Location = New Point(159, 61)
        txtPreciodeCompra.Name = "txtPreciodeCompra"
        txtPreciodeCompra.Size = New Size(100, 23)
        txtPreciodeCompra.TabIndex = 3
        ' 
        ' txtCantidadCompra
        ' 
        txtCantidadCompra.Location = New Point(159, 20)
        txtCantidadCompra.Name = "txtCantidadCompra"
        txtCantidadCompra.Size = New Size(100, 23)
        txtCantidadCompra.TabIndex = 2
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(43, 64)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 15)
        Label12.TabIndex = 1
        Label12.Text = "Precio de Compra:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(42, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(58, 15)
        Label11.TabIndex = 0
        Label11.Text = "Cantidad:"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel5.Controls.Add(btnVender)
        Panel5.Controls.Add(txtPreciodeVenta)
        Panel5.Controls.Add(txtCantidadVenta)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(Label13)
        Panel5.Location = New Point(386, 243)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(274, 126)
        Panel5.TabIndex = 4
        ' 
        ' btnVender
        ' 
        btnVender.BackColor = Color.Purple
        btnVender.FlatStyle = FlatStyle.Popup
        btnVender.Location = New Point(47, 84)
        btnVender.Name = "btnVender"
        btnVender.Size = New Size(211, 26)
        btnVender.TabIndex = 4
        btnVender.Text = "Vender"
        btnVender.UseVisualStyleBackColor = False
        ' 
        ' txtPreciodeVenta
        ' 
        txtPreciodeVenta.BackColor = Color.Yellow
        txtPreciodeVenta.ForeColor = Color.Black
        txtPreciodeVenta.Location = New Point(159, 49)
        txtPreciodeVenta.Name = "txtPreciodeVenta"
        txtPreciodeVenta.ReadOnly = True
        txtPreciodeVenta.Size = New Size(99, 23)
        txtPreciodeVenta.TabIndex = 3
        ' 
        ' txtCantidadVenta
        ' 
        txtCantidadVenta.Location = New Point(159, 20)
        txtCantidadVenta.Name = "txtCantidadVenta"
        txtCantidadVenta.Size = New Size(100, 23)
        txtCantidadVenta.TabIndex = 2
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(47, 54)
        Label14.Name = "Label14"
        Label14.Size = New Size(91, 15)
        Label14.TabIndex = 1
        Label14.Text = "Precio de Venta:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(43, 23)
        Label13.Name = "Label13"
        Label13.Size = New Size(58, 15)
        Label13.TabIndex = 0
        Label13.Text = "Cantidad:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(672, 381)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Fravega"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents RadioButtonHeladera As RadioButton
    Friend WithEvents RadioButtonLavarropas As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAlta As Button
    Friend WithEvents txtConsumo As TextBox
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnComprar As Button
    Friend WithEvents txtPreciodeCompra As TextBox
    Friend WithEvents txtCantidadCompra As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCantidadVenta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnVender As Button
    Friend WithEvents txtPreciodeVenta As TextBox

End Class
