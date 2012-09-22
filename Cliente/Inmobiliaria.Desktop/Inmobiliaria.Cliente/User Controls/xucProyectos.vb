Imports Libreria
Public Class xucProyectos

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub xucProyectos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim proyectos As New Libreria.Proyecto
        Me.GridControl1.DataSource = proyectos.D_listarTodos

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class
