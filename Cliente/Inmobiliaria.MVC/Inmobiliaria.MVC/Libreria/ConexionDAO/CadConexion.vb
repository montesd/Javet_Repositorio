Imports System.Configuration.ConfigurationManager
Namespace Inmobiliaria.Datos
    Public Class CadConexion
        Public Shared Function GetCadConexion() As String
            Return Configuration.ConfigurationManager.ConnectionStrings("cnx").ConnectionString
        End Function
    End Class
End Namespace

