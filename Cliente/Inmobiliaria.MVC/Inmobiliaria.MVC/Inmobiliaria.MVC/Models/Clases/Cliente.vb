Imports System.Data.SqlClient
Namespace Inmobiliaria.MVC
    Public Class Cliente
        Public Function GetCliente(ByVal nroDocumento As String) As List(Of ClienteModel)
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstClientes As New List(Of ClienteModel)
            Dim oCliente As New ClienteModel
            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "SP_GETCLIENTES", New SqlParameter("@NroDocumento", nroDocumento))
            If daR.HasRows Then
                While daR.Read
                    oCliente = New ClienteModel
                    With oCliente
                        .idCliente = daR("IDCLIENTE")
                        .NombreCliente = daR("NOMBRE")
                        .ApellidosCliente = daR("APELLIDO")
                        .nroDocumento = daR("DNI")
                        .EstadoCivil.Descripcion = daR("ESTADOCIVIL")
                    End With
                    lstClientes.Add(oCliente)
                End While
            End If
            Return lstClientes

        End Function
    End Class
End Namespace
