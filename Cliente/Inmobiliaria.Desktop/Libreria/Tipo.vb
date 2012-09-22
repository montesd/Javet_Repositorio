Namespace Libreria
    Public Class Tipo

        Public Function D_listarTodos() As DataTable
            Return SqlHelper.ExecuteDataset(conexion, CommandType.Text, "SELECT * FROM Tipo_Producto").Tables(0)
        End Function
    End Class
End Namespace



