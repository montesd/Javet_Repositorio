Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class CotizacionModels

    Private idCotizacionValue As Integer
    Private ClienteValue As ClienteModel
    Private ProductoValue As ProductoModels
    Private FechaCotizacionValue As String
    Private ProyectoValue As ProyectoModel
    Private estadoValue As Integer
    Private montoValue As Decimal

    Public Sub New()
        ClienteValue = New ClienteModel
        ProductoValue = New ProductoModels
        ProyectoValue = New ProyectoModel
    End Sub


    Public Property Proyecto() As ProyectoModel
        Get
            Return ProyectoValue
        End Get
        Set(ByVal value As ProyectoModel)
            ProyectoValue = value
        End Set
    End Property

    Public Property Monto() As Decimal
        Get
            Return montoValue
        End Get
        Set(ByVal value As Decimal)
            montoValue = value
        End Set
    End Property

    Public Property Estado() As Integer
        Get
            Return estadoValue
        End Get
        Set(ByVal value As Integer)
            estadoValue = value
        End Set
    End Property



    Public Property FechaCotizacion() As String
        Get
            Return FechaCotizacionValue
        End Get
        Set(ByVal value As String)
            FechaCotizacionValue = value
        End Set
    End Property





    Public Property Producto() As ProductoModels
        Get
            Return ProductoValue
        End Get
        Set(ByVal value As ProductoModels)
            ProductoValue = value
        End Set
    End Property


    Public Property Cliente() As ClienteModel
        Get
            Return ClienteValue
        End Get
        Set(ByVal value As ClienteModel)
            ClienteValue = value
        End Set
    End Property

    Public Property idCotizacion() As Integer
        Get
            Return idCotizacionValue
        End Get
        Set(ByVal value As Integer)
            idCotizacionValue = value
        End Set
    End Property



End Class
