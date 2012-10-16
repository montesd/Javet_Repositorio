
Imports System.Collections.Generic

Public Class IndexContratoViewModels
    'public int NumberOfGenres { get; set; }
    '   public List<string> Genres { get; set; }
    Public Property NroSolicitud As Integer
    Public Property Solicitud As ContratoModel
    Public Property Cliente As ClienteModel
    Public Property Proyecto As ProyectoModel
    Public Property Distritos As List(Of DistritoModel)
    Public Property Proyectos As List(Of ProyectoModel)
    Public Property Tipos As List(Of TipoProductoModel)
    Public Property Productos As List(Of ProductoModels)
    Public Property Resultado As String







End Class
