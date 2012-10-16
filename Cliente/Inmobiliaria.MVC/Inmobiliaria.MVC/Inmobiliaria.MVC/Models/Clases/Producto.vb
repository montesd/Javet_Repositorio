Imports System.Data.SqlClient
Namespace Inmobiliaria.MVC
    Public Class Producto

        Public Function GetProductos(ByVal idProyecto As Integer) As List(Of ProductoModels)
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstProductos As New List(Of ProductoModels)
            Dim oProducto As New ProductoModels
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "SP_GET_PRODUCTOS", New SqlParameter("@IDPROYECTO", idProyecto))
            If daR.HasRows Then
                While daR.Read
                    oProducto = New ProductoModels
                    With oProducto
                        .idProducto = daR("IDPRODUCTO")
                        .idProyecto = daR("IDPROYECTO")
                        .TipoProducto.idTipo = daR("IDTIPOPRODUCTO")
                        .TipoProducto.TipoProducto = daR("TIPO")
                        .areaTotal = daR("AREATOTAL")
                        .areaConstruida = daR("AREACONSTRUIDA")
                        .nroPiso = daR("NROPISO")
                        .nroHabitaciones = daR("NROHABITACIONES")
                        .nroBanhos = daR("NROBANHOS")
                        .Urbanizacion = daR("URBANIZACION")
                        .Ubicacion = daR("UBICACION")
                        .Precio = daR("PRECIO")
                    End With
                    lstProductos.Add(oProducto)
                End While
            End If

            Return lstProductos

        End Function
    End Class
End Namespace