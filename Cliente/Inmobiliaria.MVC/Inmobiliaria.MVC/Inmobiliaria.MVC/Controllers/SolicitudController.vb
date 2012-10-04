
Namespace Inmobiliaria.MVC
    Public Class SolicitudController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Solicitud
        Public Function Index() As ActionResult
            Dim maestrosL As New MaestrosLogic
            Dim solicitud As New IndexSolicitudViewModels
            solicitud.Distritos = maestrosL.GetDistritos
            solicitud.Tipos = maestrosL.GetTipoProducto
            Return View(solicitud)
        End Function

        Public Function GetProyectosDistritoID(ByVal id As String) As JsonResult
            Dim proyectoL As New ProyectoLogic
            Return Json(proyectoL.GetProyectos(id))

        End Function


    End Class
End Namespace