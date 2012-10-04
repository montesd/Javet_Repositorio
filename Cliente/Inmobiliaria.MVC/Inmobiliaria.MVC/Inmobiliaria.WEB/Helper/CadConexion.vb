Imports System.Configuration.ConfigurationManager
Namespace Inmobiliaria.MVC
    Public Class CadConexion
        Public Shared Function GetCadConexion() As String
            Return ConnectionStrings("cnx").ConnectionString
        End Function
    End Class
End Namespace

