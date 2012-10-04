
Namespace Inmobiliaria.MVC
    Public Class SolicitudController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Solicitud

        Function Index() As ActionResult
            Dim data As New SolicitudLogic
            Dim vista As New IndexSolicitudViewModels
            vista.Proyectos = data.GetProyectos
            vista.NroProyectos = vista.Proyectos.Count
            Return View(vista)
        End Function

    End Class

    Public Class SolicitudLogic

        Public Function GetProyectos() As List(Of ProyectoModel)
            Dim conDAo As New ConexionDAO
            Dim DT As New DataTable
            Dim daR As SqlClient.SqlDataReader
            Dim lstProyectos As New List(Of ProyectoModel)
            Dim oProyecto As New ProyectoModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "SP_GETPROYECTOS")
            If daR.HasRows Then
                While daR.Read
                    oProyecto = New ProyectoModel
                    oProyecto.idProyecto = daR("IDPROYECTO")
                    oProyecto.proyecto = daR("PROYECTO")
                    oProyecto.distrito = daR("DISTRITO")
                    oProyecto.idDistrito = daR("IDDISTRITO")
                    oProyecto.urbanizacion = daR("URBANIZACION")

                    lstProyectos.Add(oProyecto)
                End While
            End If


            Return lstProyectos
        End Function
    End Class
End Namespace