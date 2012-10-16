Namespace Inmobiliaria.MVC
    Public Class ProyectoController
        Inherits System.Web.Mvc.Controller

        ' GET: /Proyecto

        Function Index() As ActionResult
            Dim data As New ProyectoLogic
            Dim vista As New IndexProyectoViewModels
            vista.Proyectos = data.GetProyectos
            vista.NroProyectos = vista.Proyectos.Count
            vista.Proyecto = Nothing
            Return View(vista)
        End Function

        <HttpPost()> _
        Public Function GetProyectosDistrito(ByVal idDistrito As String) As ActionResult
            Dim proyectoL As New ProyectoLogic
            Dim var As New JsonResult
            var = Json(proyectoL.GetProyectos(Convert.ToInt32(idDistrito)), JsonRequestBehavior.AllowGet)
            Return var
        End Function

        <HttpGet()> _
        Public Function GetProyectosArray() As ProyectoModel()
            Dim proyectoL As New ProyectoLogic
            Dim retorno() As ProyectoModel = proyectoL.GetProyectos().ToArray
            Return retorno
        End Function


    End Class


    
End Namespace