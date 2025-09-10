Public Class Lavarropas
    Inherits Electro
    Private capacidad As Double
    Private consumo As Integer
    Public Property capacidad2 As Double
        Get
            Return capacidad
        End Get
        Set(value As Double)
            If value >= 0 Then
                capacidad = value
            Else
                MsgBox("Capacidad Invalida")

            End If
        End Set
    End Property
    Public Property consumo2 As Integer
        Get
            Return consumo
        End Get
        Set(value As Integer)
            If value >= 0 Then
                consumo = value
            Else
                MsgBox("Consumo Invalido")

            End If
        End Set

    End Property
    Public Sub New()

    End Sub
    Public Sub New(capacidad As Double, consumo As Integer, modelo As String, descripcion As String, stock As Integer, preciocompra As Integer)
        MyBase.New(modelo, descripcion, stock, preciocompra)
        Me.capacidad2 = capacidad
        Me.consumo2 = consumo
    End Sub

    Public Function PrecioVenta(preciocompra As Integer, stock As Integer) As Double
        Dim precioventa2 As Double
        If stock >= 100 Then
            precioventa2 = preciocompra
        Else
            precioventa2 = preciocompra + (preciocompra * 30 / 100)
        End If
        Return precioventa2
    End Function

End Class
