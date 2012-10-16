Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class ContratoModel

    Private idSolicitudValue As Integer
    Private clienteValue As ClienteModel
    Private CotizacionValue As CotizacionModels
    Private productoValue As ProductoModels
    Private proyectoValue As ProyectoModel
    Private MontoTotalValue As Decimal
    Private MontoMensualValue As Decimal
    Private MontoInicialValue As Decimal
    Private NroCuotasValue As Integer

    Private FechaContratoValue As String
    Public Property FechaContrato() As String
        Get
            Return FechaContratoValue
        End Get
        Set(ByVal value As String)
            FechaContratoValue = value
        End Set
    End Property



   




    Public Sub New()
        clienteValue = New ClienteModel
        CotizacionValue = New CotizacionModels
        productoValue = New ProductoModels
        proyectoValue = New ProyectoModel
    End Sub
    Public Property Proyecto() As ProyectoModel
        Get
            Return proyectoValue
        End Get
        Set(ByVal value As ProyectoModel)
            proyectoValue = value
        End Set
    End Property

    Public Property NroCuotas() As Integer
        Get
            Return NroCuotasValue
        End Get
        Set(ByVal value As Integer)
            NroCuotasValue = value
        End Set
    End Property
    Public Property Producto() As ProductoModels
        Get
            Return productoValue
        End Get
        Set(ByVal value As ProductoModels)
            productoValue = value
        End Set
    End Property

    Public Property MontoInicial() As Decimal
        Get
            Return MontoInicialValue
        End Get
        Set(ByVal value As Decimal)
            MontoInicialValue = value
        End Set
    End Property

    Public Property MontoMensual() As Decimal
        Get
            Return MontoMensualValue
        End Get
        Set(ByVal value As Decimal)
            MontoMensualValue = value
        End Set
    End Property

    Public Property MontoTotal() As Decimal
        Get
            Return MontoTotalValue
        End Get
        Set(ByVal value As Decimal)
            MontoTotalValue = value
        End Set
    End Property

    Public Property Cotizacion() As CotizacionModels
        Get
            Return CotizacionValue
        End Get
        Set(ByVal value As CotizacionModels)
            CotizacionValue = value
        End Set
    End Property


    
    Public Property idSolicitud() As Integer
        Get
            Return idSolicitudValue
        End Get
        Set(ByVal value As Integer)
            idSolicitudValue = value
        End Set
    End Property


    Public Property Cliente() As ClienteModel
        Get
            Return clienteValue
        End Get
        Set(ByVal value As ClienteModel)
            clienteValue = value
        End Set
    End Property




End Class


