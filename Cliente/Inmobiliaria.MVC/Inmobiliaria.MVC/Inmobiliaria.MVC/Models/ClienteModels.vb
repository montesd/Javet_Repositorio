Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class ClienteModel

    Private idClienteValue As Integer
    Private nombreClienteValue As String
    Private apellidosClienteValue As String
    Private idTipoDocumentoValue As Integer
    Private nroDocumentoValue As String
    Private estadoValue As Integer
    Private TipoClienteValue As TipoClienteModel
    Private EstadoCivilValue As EstadoCivilModel

    Public Sub New()
        TipoClienteValue = New TipoClienteModel
        EstadoCivilValue = New EstadoCivilModel
    End Sub

    <DisplayName("Codigo Cliente")> _
    Public Property idCliente() As Integer
        Get
            Return idClienteValue
        End Get
        Set(ByVal value As Integer)
            idClienteValue = value
        End Set
    End Property


   
    <DisplayName("Nombre Cliente")> _
    Public Property NombreCliente() As String
        Get
            Return nombreClienteValue
        End Get
        Set(ByVal value As String)
            nombreClienteValue = value
        End Set
    End Property

  
    <DisplayName("Apellidos Cliente")> _
    Public Property ApellidosCliente() As String
        Get
            Return apellidosClienteValue
        End Get
        Set(ByVal value As String)
            apellidosClienteValue = value
        End Set
    End Property


   
    Public Property TipoCliente() As TipoClienteModel
        Get
            Return TipoClienteValue
        End Get
        Set(ByVal value As TipoClienteModel)
            TipoClienteValue = value
        End Set
    End Property


   
    Public Property EstadoCivil() As EstadoCivilModel
        Get
            Return EstadoCivilValue
        End Get
        Set(ByVal value As EstadoCivilModel)
            EstadoCivilValue = value
        End Set
    End Property


    
    Public Property idTipoDocumento() As Integer
        Get
            Return idTipoDocumentoValue
        End Get
        Set(ByVal value As Integer)
            idTipoDocumentoValue = value
        End Set
    End Property


    <DisplayName("Nro Documento")> _
    Public Property nroDocumento() As String
        Get
            Return nroDocumentoValue
        End Get
        Set(ByVal value As String)
            nroDocumentoValue = value
        End Set
    End Property


    <DisplayName("Estado")> _
     Public Property Estado() As Integer
        Get
            Return estadoValue
        End Get
        Set(ByVal value As Integer)
            estadoValue = value
        End Set
    End Property



End Class
