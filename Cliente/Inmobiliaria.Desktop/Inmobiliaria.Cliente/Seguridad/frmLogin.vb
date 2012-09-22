Imports Libreria

Public Class FrmLogin

    Private Sub frmLogin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then End 'Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If e.KeyChar = Chr(13) Then

            If Me.txtUserName.Text.Trim <> "" And Me.txtPassword.Text.Trim = "" Then Me.txtPassword.Focus()
            If Me.txtUserName.Text.Trim <> "" And Me.txtPassword.Text.Trim <> "" Then Ingresar()

        End If
    End Sub

    Dim veces% = 0

    Private Sub txtPassword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then

            If Me.txtUserName.Text.Trim <> "" And Me.txtPassword.Text.Trim <> "" Then Ingresar()
            If Me.txtUserName.Text.Trim = "" And Me.txtPassword.Text.Trim <> "" Then Me.txtUserName.Focus()

        End If
    End Sub


    Sub Ingresar()




        Dim usuario As New Libreria.Usuario

        

        Dim tablaIngreso As New DataTable

        tablaIngreso = usuario.D_ListarUsuarioAcceso(txtUserName.Text, txtPassword.Text)

        If tablaIngreso.Rows.Count > 0 Then
            Modulo.usuario = txtUserName.Text
            Me.Visible = False



            'rFrmPrincipal.ShowDialog()
            Me.Close()
            Me.Dispose()

        Else

            MessageBox.Show("No Tiene acceso al sistema favor de revisar los datos ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.txtPassword.Text = ""
            Me.txtPassword.Focus()

        End If

       


    End Sub



    
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
End Class