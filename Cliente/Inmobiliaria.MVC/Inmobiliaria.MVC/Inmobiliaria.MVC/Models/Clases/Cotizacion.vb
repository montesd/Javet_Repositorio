Imports System.Data.SqlClient
Namespace Inmobiliaria.MVC

    Public Class Cotizacion

        Public Function GetCotizacionCliente(ByVal idCliente As Integer) As List(Of CotizacionModels)
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstCotizaciones As New List(Of CotizacionModels)
            Dim oCotizacion As New CotizacionModels
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "SP_GETCOTIZACION", New SqlParameter("@IDCLIENTE", idCliente))
            If daR.HasRows Then
                While daR.Read
                    oCotizacion = New CotizacionModels
                    With oCotizacion
                        .idCotizacion = daR("IDCOTIZACION")
                        .Cliente.idCliente = daR("IDCLIENTE")
                        .Cliente.NombreCliente = daR("NOMBRECLIENTE")
                        .Producto.idProducto = daR("IDPRODUCTO")
                        .FechaCotizacion = daR("FECHA_COTIZACION")
                        .Monto = daR("PRECIO")
                        .Proyecto.idProyecto = daR("IDPROYECTO")
                        .Proyecto.Proyecto = daR("PROYECTO")
                        .Producto.TipoProducto.idTipo = daR("IDTIPOPRODUCTO")
                        .Producto.TipoProducto.TipoProducto = daR("TIPOPRODUCTO")
                        .Producto.Ubicacion = daR("UBICACION")
                    End With
                    lstCotizaciones.Add(oCotizacion)
                End While
            End If


            Return lstCotizaciones

        End Function
    End Class
End Namespace


