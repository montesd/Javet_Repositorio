Imports System.Xml

Namespace Inmobiliaria.MVC

    Public Class ContratoController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Solicitud
        Public Function Index() As ActionResult
            Dim maestrosL As New MaestrosLogic
            Dim solicitud As New IndexContratoViewModels
            Dim cliente As New ClienteModel
            solicitud.Tipos = maestrosL.GetTipoProducto
            solicitud.Cliente = cliente
            Return View(solicitud)
        End Function

        Public Function Lista() As ActionResult
            Dim vistaContratos As New ListaContratoViewModels
            Dim contratLogic As New Contrato
            vistaContratos.Contratos = contratLogic.GetContratos
            vistaContratos.CantContratos = vistaContratos.Contratos.Count
            Return View(vistaContratos)
        End Function


        <HttpPost()> _
        Public Function VerificaBanco(ByVal nroDocumento As String) As ActionResult
            'model.Cliente.nroDocumento'
            'nroDocumento = "12345678"

            Dim Apellidos As String
            Dim Dni As String
            Dim EstadoCivil As String
            Dim idCliente As Integer
            Dim Nombres As String
            Dim Resultado As String
            Dim TipoDocumento As String



            Dim modelo As New IndexContratoViewModels
            Dim ClienteModelo As New ClienteModel

            Dim xmlCliente As New System.Xml.XmlDocument
            xmlCliente.Load("http://192.168.1.37:8080/MdrRest/rs/cliente-service/cliente2/" & nroDocumento & "")

            Dim objetoCliente As XmlNode = xmlCliente.ChildNodes(1)


            If objetoCliente.InnerText <> "0" Then
                With ClienteModelo
                    .ApellidosCliente = objetoCliente.ChildNodes(0).InnerText
                    .nroDocumento = objetoCliente.ChildNodes(1).InnerText
                    .EstadoCivil.Descripcion = objetoCliente.ChildNodes(2).InnerText
                    .idCliente = objetoCliente.ChildNodes(3).InnerText
                    .NombreCliente = objetoCliente.ChildNodes(4).InnerText
                    .idTipoDocumento = objetoCliente.ChildNodes(6).InnerText
                End With

                modelo.Cliente = ClienteModelo
                modelo.Resultado = objetoCliente.ChildNodes(5).InnerText

                Return Json(modelo, JsonRequestBehavior.AllowGet)
            Else
                modelo.Resultado = "Nothing"

                Return Json(modelo, JsonRequestBehavior.AllowGet)
            End If
        End Function


        

        <HttpPost()> _
        Public Function GetCliente_NroDoc(ByVal nroDocumento As String) As ActionResult
            Dim cliente As New Cliente
            Dim lista As New List(Of ClienteModel)
            lista = cliente.GetCliente(nroDocumento)
            Return Json(lista, JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost()> _
        Public Function GetCotizacionesCliente(ByVal idCliente As String) As ActionResult
            Dim cotizacion As New Cotizacion
            Dim lista As New List(Of CotizacionModels)
            lista = cotizacion.GetCotizacionCliente(idCliente)

            Return Json(lista, JsonRequestBehavior.AllowGet)
        End Function

        <HttpPost()> _
        Public Function GenerarContrato(ByVal idCliente As String, ByVal idCotizacion As String, _
                                        ByVal MontoTotal As String, ByVal MontoInicial As String, _
                                        ByVal MontoMensual As String, ByVal NroCuotas As String)
            Dim modelo As New ContratoModel
            Dim contratoLogic As New Contrato

            modelo.Cliente.idCliente = idCliente
            modelo.Cotizacion.idCotizacion = idCotizacion
            modelo.MontoTotal = MontoTotal
            modelo.MontoInicial = MontoInicial
            modelo.MontoMensual = MontoMensual
            modelo.NroCuotas = NroCuotas

            Return contratoLogic.InsertContrato(modelo)
        End Function

    End Class
End Namespace