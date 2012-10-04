
Imports System.Collections.Generic

Public Class IndexSolicitudViewModels
    'public int NumberOfGenres { get; set; }
    '   public List<string> Genres { get; set; }
    Public Property NroSolicitud As Integer
    Public Property Solicitud As SolicitudModel
    Public Property Cliente As ClienteModel
    Public Property Proyecto As ProyectoModel
    Public Property Distritos As List(Of DistritoModel)
    Public Property Proyectos As List(Of ProyectoModel)
    Public Property Tipos As List(Of TipoProductoModel)






End Class
