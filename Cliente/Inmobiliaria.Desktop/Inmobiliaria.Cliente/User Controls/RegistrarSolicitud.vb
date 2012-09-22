Imports libreria
Public Class RegistrarSolicitud

    Private Sub RegistrarSolicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim distrito As New libreria.Distrito
        Me.cboDistrito.Properties.DataSource = distrito.D_listarDistritos
        Me.cboDistrito.Properties.ValueMember = "idDistrito"
        Me.cboDistrito.Properties.DisplayMember = "Descripcion"


        Dim tipo As New Libreria.Tipo
        Me.cboTipo.Properties.DataSource = tipo.D_listarTodos
        Me.cboTipo.Properties.ValueMember = "idTipo"
        Me.cboTipo.Properties.DisplayMember = "Descripcion"
    End Sub

   
    Private Sub cboDistrito_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDistrito.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cboDistrito.EditValue IsNot Nothing AndAlso Not IsDBNull(cboDistrito.EditValue) Then
                Dim proyecto As New Libreria.Proyecto
                Me.cboProyectos.Properties.DataSource = proyecto.D_listarProyectos(cboDistrito.EditValue)
                Me.cboProyectos.Properties.ValueMember = "idProyecto"
                Me.cboProyectos.Properties.DisplayMember = "Descripcion"
            End If
        End If
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click, SimpleButton1.Click
        If cboProyectos.EditValue IsNot Nothing Then
            Dim producto As New Libreria.Producto
            Me.GridControl1.DataSource = producto.D_listarProductos(cboProyectos.EditValue)
        End If
    End Sub

    Private Sub GroupControl1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class
