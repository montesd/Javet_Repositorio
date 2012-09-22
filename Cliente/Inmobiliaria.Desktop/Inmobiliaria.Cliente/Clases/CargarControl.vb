Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors

Public Class CargarControl


    Private Shared Function GetBaseViewByControl(ByVal control As Control) As BaseView
        If control Is Nothing Then
            Return Nothing
        End If
        For Each cntl As Control In control.Controls
            If TypeOf cntl Is GridControl Then
                Return (CType(cntl, GridControl)).MainView
            End If
        Next cntl
        Return Nothing
    End Function

    Public Shared Sub CloseCustomizationForm(ByVal control As Control)
        Dim view As BaseView = GetBaseViewByControl(control)
        If TypeOf view Is GridView Then
            CType(view, GridView).DestroyCustomization()
        End If
    End Sub

    Public Shared Sub CloseForm(ByVal control As Control)
        Dim view As BaseView = GetBaseViewByControl(control)
        If TypeOf view Is GridView Then
            CType(view, GridView).DestroyCustomization()
        End If

        If Not control Is Nothing Then
            control.Visible = False
        End If
    End Sub

    Public Overloads Shared Function MostrarModulo(ByVal Control As DevExpress.XtraEditors.XtraUserControl, ByVal oldControl As Control, ByVal groupControl As DevExpress.XtraEditors.GroupControl) As Boolean

        Dim currentCursor As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        groupControl.Parent.SuspendLayout()
        groupControl.SuspendLayout()
        Try
            'Dim oldControl As Control = Nothing
            'If Not Instance.CurrentModuleBase Is Nothing Then
            '    oldControl = Instance.CurrentModuleBase.TModule
            'End If

            Control.Bounds = groupControl.DisplayRectangle
            'Instance.CurrentModuleBase = item
            Control.Visible = False
            groupControl.Controls.Add(Control)
            Control.Dock = DockStyle.Fill

            CloseCustomizationForm(oldControl)

            Control.Visible = True
            If Not oldControl Is Nothing Then
                oldControl.Visible = False
            End If
        Finally
            oldControl = Control
            groupControl.ResumeLayout(True)
            groupControl.Parent.ResumeLayout(True)
            Cursor.Current = currentCursor
        End Try

        Return True
    End Function

    Public Overloads Shared Function MostrarModulo(ByVal Control As UserControl, ByVal oldControl As Control, ByVal groupControl As GroupControl) As Boolean

        Dim currentCursor As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        groupControl.Parent.SuspendLayout()
        groupControl.SuspendLayout()
        Try
            'Dim oldControl As Control = Nothing
            'If Not Instance.CurrentModuleBase Is Nothing Then
            '    oldControl = Instance.CurrentModuleBase.TModule
            'End If

            Control.Bounds = groupControl.DisplayRectangle
            'Instance.CurrentModuleBase = item
            Control.Visible = False
            groupControl.Controls.Add(Control)
            Control.Dock = DockStyle.Fill

            CloseCustomizationForm(oldControl)

            Control.Visible = True
            If Not oldControl Is Nothing Then
                oldControl.Visible = False
            End If
        Finally
            oldControl = Control
            groupControl.ResumeLayout(True)
            groupControl.Parent.ResumeLayout(True)
            Cursor.Current = currentCursor
        End Try

        Return True
    End Function
End Class

Public Class Util

    Public Shared Function FechaACadena(ByVal fecha As DateTime) As String
        Dim Anio As String = ""
        Dim Mes As String = ""
        Dim Dia As String = ""

        Anio = fecha.Year.ToString
        Mes = fecha.Month.ToString
        Dia = fecha.Day.ToString

        If Mes.Length = 1 Then
            Mes = "0" & Mes
        End If
        If Dia.Length = 1 Then
            Dia = "0" & Dia
        End If

        Return Anio & "-" & Mes & "-" & Dia
    End Function


    Public Shared Function HoraACadena(ByVal fecha As DateTime) As String
        Dim hora As String = ""
        Dim minuto As String = ""
        Dim segundo As String = ""

        hora = fecha.Hour.ToString
        minuto = fecha.Minute.ToString
        segundo = fecha.Second.ToString

        If minuto.Length = 1 Then
            minuto = "0" & minuto
        End If
        If segundo.Length = 1 Then
            segundo = "0" & segundo
        End If

        Return hora & "-" & minuto & "-" & segundo
    End Function


End Class