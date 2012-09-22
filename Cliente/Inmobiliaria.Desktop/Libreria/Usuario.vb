Namespace Libreria
    Public Class Usuario
        Public Function D_ListarUsuarioAcceso(ByVal usuario As String, ByVal clave As String) As DataTable

            'objEntidad.tablaUsuario = SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT * FROM USUARIO WHERE UPPER(NOMBREUSUSARIO) = UPPER('" & objUsuario.NombreUsuario & "') AND CLAVEUSUARIO = '" & objUsuario.ClaveUsuario & "'").Tables(0)

            Return SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT * FROM USUARIOS WHERE UPPER(COD_USUARIO) = UPPER('" & usuario & "') AND CLAVE = '" & clave & "'").Tables(0)

        End Function
    End Class
End Namespace

