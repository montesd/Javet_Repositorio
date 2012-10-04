Namespace Inmobiliaria.Datos
    Public Class Proyecto
        Public Function D_listarProyectos(ByVal idDistrito As Integer) As DataTable

            'objEntidad.tablaUsuario = SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT * FROM USUARIO WHERE UPPER(NOMBREUSUSARIO) = UPPER('" & objUsuario.NombreUsuario & "') AND CLAVEUSUARIO = '" & objUsuario.ClaveUsuario & "'").Tables(0)

            Return SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT * FROM Proyecto where idDistrito=" & idDistrito.ToString).Tables(0)

        End Function
        Public Function D_listarTodos() As DataTable
            Return SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT p.*,d.Descripcion Distrito FROM Proyecto p inner join distrito d on p.idDistrito=d.idDistrito ").Tables(0)

        End Function
    End Class
End Namespace



