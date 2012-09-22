Imports System.Data.SqlClient
Namespace Libreria
    Module Modulo
        Public conexion As New SqlConnection
        Public comando As SqlCommand
        Public adaptador As SqlDataAdapter
        Public transac As SqlTransaction
    End Module
End Namespace

