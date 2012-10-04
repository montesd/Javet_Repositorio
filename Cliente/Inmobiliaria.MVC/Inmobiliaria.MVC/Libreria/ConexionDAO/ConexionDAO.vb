Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Configuration
Namespace Inmobiliaria.Datos
    Public Class ConexionDAO
        Public Sub New()
            Configurar()
        End Sub

        Public Sub Configurar()
            Try
                conexion = New SqlConnection(CadConexion.GetCadConexion)
            Catch ex As ConfigurationException
                ' MessageBox.Show("Error al cargar la configuración del acceso a datos. " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Sub

        Public Function BeginTransaction() As String

            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Open()

            transac = conexion.BeginTransaction

            Return ""
        End Function

        Public Function CommitTransaction() As String

            transac.Commit()
            transac.Dispose()
            conexion.Close()

            Return ""
        End Function

        Public Function RollBackTransaction() As String

            transac.Rollback()
            conexion.Close()

            Return ""
        End Function
    End Class
End Namespace

