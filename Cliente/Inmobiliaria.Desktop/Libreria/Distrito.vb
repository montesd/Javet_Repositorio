Namespace Libreria

    Public Class Distrito
        Public Function D_listarDistritos() As DataTable

            'objEntidad.tablaUsuario = SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT * FROM USUARIO WHERE UPPER(NOMBREUSUSARIO) = UPPER('" & objUsuario.NombreUsuario & "') AND CLAVEUSUARIO = '" & objUsuario.ClaveUsuario & "'").Tables(0)

            Return SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT * FROM DISTRITO").Tables(0)

        End Function
    End Class

End Namespace

