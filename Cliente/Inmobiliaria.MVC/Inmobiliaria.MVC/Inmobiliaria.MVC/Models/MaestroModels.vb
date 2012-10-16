Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class TipoDocumentoModel

    Private idTipoDocumentoValue As Integer
    <DisplayName("Codigo Tipo Documento")> _
     Public Property idTipoDocumento() As Integer
        Get
            Return idTipoDocumentoValue
        End Get
        Set(ByVal value As Integer)
            idTipoDocumentoValue = value
        End Set
    End Property


    Private DescripcionValue As String
    <DisplayName("Tipo de Documento")> _
     Public Property Descripcion() As String
        Get
            Return DescripcionValue
        End Get
        Set(ByVal value As String)
            DescripcionValue = value
        End Set
    End Property


End Class

Public Class TipoClienteModel

    Private idTipoClienteValue As Integer
    <DisplayName("Codigo Tipo Cliente")> _
     Public Property idTipoCliente() As Integer
        Get
            Return idTipoClienteValue
        End Get
        Set(ByVal value As Integer)
            idTipoClienteValue = value
        End Set
    End Property
    Private DescripcionValue As String
    <DisplayName("Tipo de Cliente")> _
    Public Property Descripcion() As String
        Get
            Return DescripcionValue
        End Get
        Set(ByVal value As String)
            DescripcionValue = value
        End Set
    End Property
End Class

Public Class EstadoCivilModel

    Private idEstadoCivilValue As Integer
    <DisplayName("Codigo Estado Civil")> _
     Public Property idEstadoCivil() As Integer
        Get
            Return idEstadoCivilValue
        End Get
        Set(ByVal value As Integer)
            idEstadoCivilValue = value
        End Set
    End Property


    Private DescripcionValue As String
    <DisplayName("Estado Civil")> _
     Public Property Descripcion() As String
        Get
            Return DescripcionValue
        End Get
        Set(ByVal value As String)
            DescripcionValue = value
        End Set
    End Property


End Class

Public Class DistritoModel

    Private idDistritoValue As Integer
    <DisplayName("Codigo Distrito")> _
     Public Property idDistrito() As Integer
        Get
            Return idDistritoValue
        End Get
        Set(ByVal value As Integer)
            idDistritoValue = value
        End Set
    End Property


    Private DescripcionValue As String
    <DisplayName("Distrito")> _
     Public Property Descripcion() As String
        Get
            Return DescripcionValue
        End Get
        Set(ByVal value As String)
            DescripcionValue = value
        End Set
    End Property




End Class

Public Class TipoProductoModel

    Private idTipoValue As Integer
    <DisplayName("Codigo Tipo Producto")> _
 Public Property idTipo() As Integer
        Get
            Return idTipoValue
        End Get
        Set(ByVal value As Integer)
            idTipoValue = value
        End Set
    End Property

    Private tipoProductoValue As String
    <DisplayName("Tipo Producto")> _
Public Property TipoProducto() As String
        Get
            Return tipoProductoValue
        End Get
        Set(ByVal value As String)
            tipoProductoValue = value
        End Set
    End Property


End Class
