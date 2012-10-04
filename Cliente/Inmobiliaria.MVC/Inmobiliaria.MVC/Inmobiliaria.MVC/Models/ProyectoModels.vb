
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class ProyectoModel

    Private idProyectoValue As Integer
    Private proyectoValue As String
    Private urbanizacionValue As String
    Private DistritoValue As DistritoModel

    Public Sub New()
        DistritoValue = New DistritoModel
    End Sub

    <Required()> _
    <DisplayName("Codigo Proyecto")> _
    Public Property idProyecto() As Integer
        Get
            Return idProyectoValue
        End Get
        Set(ByVal value As Integer)
            idProyectoValue = value
        End Set
    End Property

    <Required()> _
    <DisplayName("Nombre de proyecto")> _
    Public Property Proyecto() As String
        Get
            Return proyectoValue
        End Get
        Set(ByVal value As String)
            proyectoValue = value
        End Set
    End Property


    <Required()> _
    <DisplayName("Urbanizacion")> _
    Public Property Urbanizacion() As String
        Get
            Return urbanizacionValue
        End Get
        Set(ByVal value As String)
            urbanizacionValue = value
        End Set
    End Property


    Public Property Distrito() As DistritoModel
        Get
            Return DistritoValue
        End Get
        Set(ByVal value As DistritoModel)
            DistritoValue = value
        End Set
    End Property





End Class
