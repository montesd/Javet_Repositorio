Namespace Inmobiliaria.MVC
    Public Class CotizacionController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Cotizacion

        Function Index() As ActionResult
            Dim maestrosL As New MaestrosLogic
            Dim cotizacion As New IndexCotizacionViewModels
            Dim cliente As New ClienteModel
            Dim tipoProducto As New TipoProductoModel With {.idTipo = 0, .TipoProducto = "SELECCIONE"}
            cotizacion.Tipos = maestrosL.GetTipoProducto
            cotizacion.Tipos.Insert(0, tipoProducto)
            cotizacion.Cliente = cliente
            Return View(cotizacion)
        End Function

        '
        ' GET: /Cotizacion/Details/5

        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' GET: /Cotizacion/Create

        Function Create() As ActionResult
            Return View()
        End Function

        '
        ' POST: /Cotizacion/Create

        <HttpPost> _
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
        
        '
        ' GET: /Cotizacion/Edit/5

        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /Cotizacion/Edit/5

        <HttpPost> _
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        '
        ' GET: /Cotizacion/Delete/5

        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        '
        ' POST: /Cotizacion/Delete/5

        <HttpPost> _
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        <HttpPost()> _
        Function GetCliente(ByVal nroDocumento As String) As ActionResult
            Dim clienteLogic As New Cliente

            Dim listaClientes As New List(Of ClienteModel)
            listaClientes = clienteLogic.GetCliente(nroDocumento)
           
            Return Json(listaClientes, JsonRequestBehavior.AllowGet)
        End Function
        <HttpPost()> _
        Public Function ObtieneProductos_Proyecto(ByVal idProyecto As String) As ActionResult
            Dim producto As New Producto
            Dim lista As New List(Of ProductoModels)
            lista = producto.GetProductos(idProyecto)
            Return Json(lista, JsonRequestBehavior.AllowGet)
        End Function

    End Class
End Namespace