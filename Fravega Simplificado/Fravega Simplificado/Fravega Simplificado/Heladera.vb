Imports System.Reflection
Imports Microsoft.VisualBasic.Devices

Public Class Heladera
    Inherits Electro
    Private capacidad As Double
    Private consumo As Integer
    Private color As String
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
    Public Property color2 As String
        Get
            Return color
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
                MsgBox("Color invalido, no debe contener valores numericos")
            Else
                color = value
            End If
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(capacidad As Double, consumo As Integer, color As String, modelo As String, descripcion As String, stock As Integer, preciocompra As Integer)
        MyBase.New(modelo, descripcion, stock, preciocompra)
        Me.capacidad2 = capacidad
        Me.consumo2 = consumo
        Me.color2 = color

    End Sub
    Public Function PrecioVenta(preciocompra As Integer) As Double
        Dim precioventa2 As Double
        precioventa2 = preciocompra + (preciocompra * 40 / 100)
        Return precioventa2
    End Function

End Class
