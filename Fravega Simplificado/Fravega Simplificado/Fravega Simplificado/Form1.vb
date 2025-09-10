Public Class Form1
    Dim Lavarropas As Lavarropas
    Dim Heladera As Heladera
    Dim auxiliar As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnComprar.Enabled = False
        btnVender.Enabled = False
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        txtCantidadCompra.Text = ""
        txtCantidadVenta.Text = ""
        txtPreciodeCompra.Text = ""
        txtPreciodeVenta.Text = ""
        'Reinicio las variables para que no haya problema con los datos del objeto creado anteriormente
        Heladera = Nothing
        Lavarropas = Nothing
        lblStock.Text = 0
        If (RadioButtonHeladera.Checked = True) Then

            auxiliar = "Heladera"
            Dim capacidad As Double = txtCapacidad.Text
            Dim consumo As Integer = txtConsumo.Text
            Dim color As String = txtColor.Text
            Heladera = New Heladera(capacidad, consumo, color, txtModelo.Text, txtDescripcion.Text, Val(lblStock.Text), Val(txtPreciodeCompra.Text))

        End If
        If (RadioButtonLavarropas.Checked = True) Then
            auxiliar = "Lavarropas"
            Dim capacidad As Double = txtCapacidad.Text
            Dim consumo As Integer = txtConsumo.Text
            Lavarropas = New Lavarropas(capacidad, consumo, txtModelo.Text, txtDescripcion.Text, Val(lblStock.Text), Val(txtPreciodeCompra.Text))

        End If
        btnComprar.Enabled = True
        btnVender.Enabled = True

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        txtPreciodeVenta.Text = ""

        If (auxiliar = "Heladera") Then
            Heladera.Comprar(Val(txtCantidadCompra.Text), Val(txtPreciodeCompra.Text))
            lblStock.Text = Heladera.stock2
            txtPreciodeVenta.Text = Convert.ToString(Heladera.PrecioVenta(Heladera.preciocompra2))
        End If
        If (auxiliar = "Lavarropas") Then
            Lavarropas.Comprar(Val(txtCantidadCompra.Text), Val(txtPreciodeCompra.Text))
            lblStock.Text = Lavarropas.stock2
            txtPreciodeVenta.Text = Convert.ToString(Lavarropas.PrecioVenta(Lavarropas.preciocompra2, Lavarropas.stock2))
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        If (auxiliar = "Heladera") Then
            Dim resultadoVenta As Boolean
            resultadoVenta = Heladera.Vender(Val(txtCantidadVenta.Text))
            If (resultadoVenta = True) Then
                MsgBox("La venta se realizo con exito")
                lblStock.Text = Convert.ToString(Heladera.stock2)
            Else
                MsgBox("La venta fallo debido a la falta de Stock")
            End If
        End If
        If (auxiliar = "Lavarropas") Then
            Dim resultadoVenta As Boolean
            resultadoVenta = Lavarropas.Vender(Val(txtCantidadVenta.Text))
            If (resultadoVenta = True) Then
                MsgBox("La venta se realizo con exito")
                lblStock.Text = Convert.ToString(Lavarropas.stock2)
            Else
                MsgBox("La venta fallo debido a la falta de Stock")
            End If
        End If
    End Sub
End Class
