Namespace Inmobiliaria.MVC
    Public Class MaestroController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Maestro

        Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost()> _
        Public Function GetDistritos_Tipo(ByVal tipo As String) As ActionResult
            Dim maestro As New MaestrosLogic
            Return Json(maestro.GetDistritos_TipoProducto(Convert.ToInt32(tipo)), JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost()> _
        Public Function GetTipoProducto() As ActionResult
            Dim maestro As New MaestrosLogic
            Return Json(maestro.GetTipoProducto(), JsonRequestBehavior.AllowGet)
        End Function

    End Class
End Namespace