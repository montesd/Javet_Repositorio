Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Public Class ProductoModels
    Private idProductoValue As Integer
    Private idProyectoValue As Integer
    Private tipoProductoValue As TipoProductoModel
    Private areaTotalValue As Decimal
    Private areaContruidaValue As Decimal
    Private nroPisoValue As Integer
    Private nroHabitacionesValue As Integer
    Private ubicacionValue As String

    Private urbanizacionValue As String

    Private precioValue As Decimal
    Public Property Precio() As Decimal
        Get
            Return precioValue
        End Get
        Set(ByVal value As Decimal)
            precioValue = value
        End Set
    End Property

    Public Property Urbanizacion() As String
        Get
            Return urbanizacionValue
        End Get
        Set(ByVal value As String)
            urbanizacionValue = value
        End Set
    End Property

    Public Sub New()
        tipoProductoValue = New TipoProductoModel
    End Sub


    Public Property idProducto() As Integer
        Get
            Return idProductoValue
        End Get
        Set(ByVal value As Integer)
            idProductoValue = value
        End Set
    End Property



    Public Property idProyecto() As Integer
        Get
            Return idProyectoValue
        End Get
        Set(ByVal value As Integer)
            idProyectoValue = value
        End Set
    End Property


    Public Property TipoProducto() As TipoProductoModel
        Get
            Return tipoProductoValue
        End Get
        Set(ByVal value As TipoProductoModel)
            tipoProductoValue = value
        End Set
    End Property





    Public Property areaTotal() As Decimal
        Get
            Return areaTotalValue
        End Get
        Set(ByVal value As Decimal)
            areaTotalValue = value
        End Set
    End Property



    Public Property areaConstruida() As Decimal
        Get
            Return areaContruidaValue
        End Get
        Set(ByVal value As Decimal)
            areaContruidaValue = value
        End Set
    End Property


    Public Property nroPiso() As Integer
        Get
            Return nroPisoValue
        End Get
        Set(ByVal value As Integer)
            nroPisoValue = value
        End Set
    End Property


    Public Property nroHabitaciones() As Integer
        Get
            Return nroHabitacionesValue
        End Get
        Set(ByVal value As Integer)
            nroHabitacionesValue = value
        End Set
    End Property


    Private nroBanhosValue As Integer
    Public Property nroBanhos() As Integer
        Get
            Return nroBanhosValue
        End Get
        Set(ByVal value As Integer)
            nroBanhosValue = value
        End Set
    End Property



    Public Property Ubicacion() As String
        Get
            Return ubicacionValue
        End Get
        Set(ByVal value As String)
            ubicacionValue = value
        End Set
    End Property



End Class
