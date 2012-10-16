Imports System.Data.SqlClient
Namespace Inmobiliaria.MVC

   
    Public Class MaestrosLogic

        Public Function GetDistritos_TipoProducto(ByVal idTipoProducto As Integer) As List(Of DistritoModel)
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstDistrito As New List(Of DistritoModel)
            Dim oDistrito As New DistritoModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "GET_DISTRITO_PRODUCTO", New SqlClient.SqlParameter("@IDTIPOPRODUCTO", idTipoProducto))
            If daR.HasRows Then
                While daR.Read
                    oDistrito = New DistritoModel
                    oDistrito.idDistrito = daR("IDDISTRITO")
                    oDistrito.Descripcion = UCase(daR("DESCRIPCION"))

                    lstDistrito.Add(oDistrito)
                End While
            End If
            Return lstDistrito
        End Function
        Public Function GetDistritos() As List(Of DistritoModel)
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstDistrito As New List(Of DistritoModel)
            Dim oDistrito As New DistritoModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "GET_DISTRITO")
            If daR.HasRows Then
                While daR.Read
                    oDistrito = New DistritoModel
                    oDistrito.idDistrito = daR("IDDISTRITO")
                    oDistrito.Descripcion = daR("DESCRIPCION")

                    lstDistrito.Add(oDistrito)
                End While
            End If
            Return lstDistrito
        End Function
        Public Function GetTipoProducto() As List(Of TipoProductoModel)
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstTipo As New List(Of TipoProductoModel)
            Dim oTipo As New TipoProductoModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "GET_TIPOPRODUCTO")
            If daR.HasRows Then
                While daR.Read
                    oTipo = New TipoProductoModel
                    oTipo.idTipo = daR("IDTIPO")
                    oTipo.TipoProducto = UCase(daR("DESCRIPCION"))

                    lstTipo.Add(oTipo)
                End While
            End If
            Return lstTipo
        End Function
    End Class
End Namespace

