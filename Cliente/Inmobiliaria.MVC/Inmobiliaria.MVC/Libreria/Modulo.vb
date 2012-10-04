Imports System.Data.SqlClient
Namespace Inmobiliaria.Datos
    Module Modulo
        Public conexion As New SqlConnection(CadConexion.GetCadConexion)
        Public comando As SqlCommand
        Public adaptador As SqlDataAdapter
        Public transac As SqlTransaction
    End Module
End Namespace

