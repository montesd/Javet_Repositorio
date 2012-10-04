Imports System.Data.SqlClient
Namespace Inmobiliaria.MVC
    Public Class UsuarioLogic
        Public Function ValidaUsuario(ByRef oUsuario As UsuarioModel) As Boolean
            Dim conDAo As New ConexionDAO
            Dim daR As SqlClient.SqlDataReader
            Dim lstDistrito As New List(Of DistritoModel)
            Dim oDistrito As New DistritoModel

            daR = SqlHelper.ExecuteReader(conexion, CommandType.StoredProcedure, "GET_USUARIOS", New SqlClient.SqlParameter("@COD_USUARIO", oUsuario.codUsuario))

            If daR.HasRows Then
                While daR.Read
                    oUsuario.codUsuario = daR("COD_USUARIO")
                    oUsuario.nomUsuario = IIf(IsDBNull(daR("NOM_USUARIO")), "", daR("NOM_USUARIO"))

                    oUsuario.FechaIngreso = IIf(IsDBNull(daR("FECHAINGRESO")), "", daR("FECHAINGRESO"))
                    oUsuario.fechaInicio = IIf(IsDBNull(daR("FECHAINICIO")), "", daR("FECHAINICIO"))
                    oUsuario.FechaTermino =IIf(IsDBNull( daR("FECHATERMINO")),"",daR("FECHATERMINO"))
                    oUsuario.estadoUsuario = IIf(IsDBNull(daR("ESTADO_USUARIO")), 0, daR("ESTADO_USUARIO"))
                    oUsuario.idTipo = IIf(IsDBNull(daR("ID_TIPO")), 0, daR("ID_TIPO"))
                    oUsuario.codPersonal = IIf(IsDBNull(daR("COD_PERSONAL")), 0, daR("COD_PERSONAL"))

                    If (oUsuario.Clave = daR("CLAVE")) Then
                        Return True
                    Else
                        Return False
                    End If

                End While
            Else
                Return False
            End If

        End Function
    End Class
End Namespace

