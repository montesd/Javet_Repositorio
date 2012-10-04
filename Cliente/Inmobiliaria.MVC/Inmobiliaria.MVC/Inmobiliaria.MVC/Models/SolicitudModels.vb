Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class SolicitudModel

    Private idSolicitudValue As Integer
    Private clienteValue As ClienteModel

    Public Sub New()
        clienteValue = New ClienteModel
    End Sub

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


