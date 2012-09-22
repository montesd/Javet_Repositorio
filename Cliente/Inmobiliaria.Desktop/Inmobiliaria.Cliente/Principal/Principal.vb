Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils.Drawing

Public Class Principal
    Public oldControl As Control = Nothing

    Private Sub MostrarModulo(ByVal Control As UserControl)
        pcMain.SuspendLayout()
        Try
            CargarControl.MostrarModulo(Control, oldControl, GroupControl1)
            oldControl = Control

        Finally
            pcMain.ResumeLayout()
        End Try
    End Sub

    'Private Sub InitSkinGallery()

    '    Dim imageButton As SimpleButton = New SimpleButton()
    '    For Each cnt As SkinContainer In SkinManager.Default.Skins
    '        imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName)
    '        Dim gItem As GalleryItem = New GalleryItem()
    '        Dim groupIndex As Integer = 0
    '        If cnt.SkinName.IndexOf("Office") > -1 Then
    '            groupIndex = 1
    '        End If
    '        rgbiSkins.Gallery.Groups(groupIndex).Items.Add(gItem)
    '        gItem.Caption = cnt.SkinName

    '        gItem.Image = GetSkinImage(imageButton, 32, 17, 2)
    '        gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5)
    '        gItem.Caption = cnt.SkinName
    '        gItem.Hint = cnt.SkinName
    '        rgbiSkins.Gallery.Groups(1).Visible = False
    '    Next cnt
    'End Sub

    Private Sub Principal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FrmLogin.ShowDialog()
        Me.Opacity = 1
        'lbl_nombreLocal.Text = Modulo.NOM_Sede
        'lblUsuario.Text = Modulo.usuario
    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub btnProyectos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProyectos.ItemClick
        Dim control As New xucProyectos
        MostrarModulo(control)
    End Sub

    Private Sub btnRegistrarSolicitud_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRegistrarSolicitud.ItemClick
        Dim control As New RegistrarSolicitud
        MostrarModulo(control)
    End Sub
End Class