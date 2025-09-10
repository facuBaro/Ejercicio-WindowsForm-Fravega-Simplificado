Public Class Electro
    Private modelo As String
    Private descripcion As String
    Private stock As Integer
    Private preciocompra As Integer


    Public Property modelo2 As String
        Get
            Return modelo
        End Get
        Set(value As String)
            Dim longitud As Integer
            Dim aux As Integer

            longitud = Len(value)
            For i = 0 To longitud - 1

                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Modelo invalido, no debe contener valores numericos")

            Else
                modelo = value
            End If
        End Set
    End Property

    Public Property descripcion2 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            Dim longitud As Integer
            Dim aux As Integer

            longitud = Len(value)
            For i = 0 To longitud - 1

                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Descripcion invalida, no debe contener valores numericos")

            Else
                descripcion = value
            End If
        End Set
    End Property
    Public Property stock2 As Integer
        Get
            Return stock
        End Get
        Set(value As Integer)
            If value >= 0 Then
                stock = value
            Else
                MsgBox("Error en el stock")

            End If
        End Set
    End Property
    Public Property preciocompra2 As Integer
        Get
            Return precioCompra
        End Get
        Set(value As Integer)
            If value >= 0 Then
                preciocompra = value
            Else
                MsgBox("Error en el precio de compra")

            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(modelo As String, descripcion As String, stock As Integer, preciocompra As Integer)
        Me.modelo2 = modelo
        Me.descripcion2 = descripcion
        Me.stock2 = stock
        Me.preciocompra2 = preciocompra

    End Sub
    Public Sub Comprar(CantidadComprada As Integer, PrecioUnitario As Integer)
        stock2 = stock2 + CantidadComprada
        preciocompra2 = PrecioUnitario
    End Sub
    Public Function Vender(CantidadVender As Integer) As Boolean
        Dim resultado As Boolean
        If CantidadVender <= stock2 Then
            resultado = True
            stock2 = stock2 - CantidadVender
        Else
            resultado = False
        End If
        Return resultado
    End Function
    Public Function PrecioVenta() As Double
        Dim precioventa2 As Double
        precioventa2 = preciocompra2 + (preciocompra2 * 20 / 100)
        Return precioventa2
    End Function

End Class
