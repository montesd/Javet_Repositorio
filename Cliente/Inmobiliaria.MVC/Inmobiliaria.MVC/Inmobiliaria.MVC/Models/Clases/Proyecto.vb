Imports System.Data.SqlClient
Namespace Inmobiliaria.MVC
    Public Class ProyectoLogic

        Public Function GetProyectos() As List(Of ProyectoModel)
            Dim conDAo As New ConexionDAO

            Dim daR As SqlClient.SqlDataReader
            Dim lstProyectos As New List(Of ProyectoModel)
            Dim oProyecto As New ProyectoModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "SP_GETPROYECTOS")
            If daR.HasRows Then
                While daR.Read
                    oProyecto = New ProyectoModel
                    oProyecto.idProyecto = daR("IDPROYECTO")
                    oProyecto.Proyecto = daR("PROYECTO")
                    oProyecto.Distrito.Descripcion = daR("DISTRITO")
                    oProyecto.Distrito.idDistrito = daR("IDDISTRITO")
                    oProyecto.Urbanizacion = daR("URBANIZACION")

                    lstProyectos.Add(oProyecto)
                End While
            End If


            Return lstProyectos
        End Function

        Public Function GetProyectos(ByVal idDistrito As Integer) As List(Of ProyectoModel)
            Dim conDAo As New ConexionDAO

            Dim daR As SqlClient.SqlDataReader
            Dim lstProyectos As New List(Of ProyectoModel)
            Dim oProyecto As New ProyectoModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "SP_GETPROYECTOS", New SqlClient.SqlParameter("@idDistrito", idDistrito))
            If daR.HasRows Then
                While daR.Read
                    oProyecto = New ProyectoModel
                    oProyecto.idProyecto = daR("IDPROYECTO")
                    oProyecto.Proyecto = daR("PROYECTO")
                    oProyecto.Distrito.Descripcion = daR("DISTRITO")
                    oProyecto.Distrito.idDistrito = daR("IDDISTRITO")
                    oProyecto.Urbanizacion = daR("URBANIZACION")

                    lstProyectos.Add(oProyecto)
                End While
            End If


            Return lstProyectos
        End Function

    End Class

End Namespace
