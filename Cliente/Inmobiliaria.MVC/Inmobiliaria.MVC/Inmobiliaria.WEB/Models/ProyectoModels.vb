
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class ProyectoModel
    Private idProyectoValue As Integer
    Public Property idProyecto() As Integer
        Get
            Return idProyectoValue
        End Get
        Set(ByVal value As Integer)
            idProyectoValue = value
        End Set
    End Property

    Private proyectoValue As String
    Public Property proyecto() As String
        Get
            Return proyectoValue
        End Get
        Set(ByVal value As String)
            proyectoValue = value
        End Set
    End Property

    Private urbanizacionValue As String
    Public Property urbanizacion() As String
        Get
            Return urbanizacionValue
        End Get
        Set(ByVal value As String)
            urbanizacionValue = value
        End Set
    End Property

    Private idDistritoValue As Integer
    Public Property idDistrito() As Integer
        Get
            Return idDistritoValue
        End Get
        Set(ByVal value As Integer)
            idDistritoValue = value
        End Set
    End Property

    Private distritoValue As String
    Public Property distrito() As String
        Get
            Return distritoValue
        End Get
        Set(ByVal value As String)
            distritoValue = value
        End Set
    End Property



End Class
