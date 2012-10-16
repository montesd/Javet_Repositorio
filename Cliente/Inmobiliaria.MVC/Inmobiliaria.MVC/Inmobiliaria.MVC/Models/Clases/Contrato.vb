Imports System.Data.SqlClient
Namespace Inmobiliaria.MVC
    Public Class Contrato
        Public Function InsertContrato(ByVal oContrato As ContratoModel) As Integer
            Dim conDAo As New ConexionDAO
            Dim sqlparam(6) As SqlParameter
            sqlparam(0) = New SqlParameter("@IDCLIENTE", oContrato.Cliente.idCliente)
            sqlparam(1) = New SqlParameter("@IDCOTIZACION", oContrato.Cotizacion.idCotizacion)
            sqlparam(2) = New SqlParameter("@MONTOTOTAL", oContrato.MontoTotal)
            sqlparam(3) = New SqlParameter("@MONTOINICIAL", oContrato.MontoInicial)
            sqlparam(4) = New SqlParameter("@MONTOMENSUAL", oContrato.MontoMensual)
            sqlparam(5) = New SqlParameter("@NROCUOTAS", oContrato.NroCuotas)
            Return SqlHelper.ExecuteNonQuery(conexion, CommandType.StoredProcedure, "SP_INS_CONTRATO", sqlparam)
        End Function
        Public Function GetContratos() As List(Of ContratoModel)
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstContratos As New List(Of ContratoModel)
            Dim oContrato As New ContratoModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "GET_CONTRATOS")
            If daR.HasRows Then
                While daR.Read
                    oContrato = New ContratoModel
                    With oContrato
                        .FechaContrato = daR("FECHACONTRATO")
                        .Cliente.NombreCliente = daR("CLIENTE")
                        .Cliente.nroDocumento = daR("NRODOCUMENTO")
                        .Proyecto.Proyecto = daR("PROYECTO")
                        .Proyecto.Distrito.Descripcion = daR("DISTRITO")
                        .Proyecto.Urbanizacion = daR("URBANIZACION")
                        .Producto.TipoProducto.TipoProducto = daR("TIPO")
                        .Producto.areaTotal = daR("AREATOTAL")
                        .MontoTotal = daR("MONTOTOTAL")
                        .MontoInicial = daR("MONTOINICIAL")
                        .MontoMensual = daR("MONTOMENSUAL")
                        .NroCuotas = daR("NROCUOTAS")

                    End With
                    lstContratos.Add(oContrato)
                End While
            End If
            Return lstContratos
        End Function
    End Class
End Namespace
