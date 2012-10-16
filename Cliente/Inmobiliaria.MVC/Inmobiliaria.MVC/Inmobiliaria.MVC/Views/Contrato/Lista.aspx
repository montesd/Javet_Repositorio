<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of Inmobiliaria.MVC.ListaContratoViewModels)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Lista
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lista de Contratos</h2>
    
     <div class="contentbox">
            	<table width="100%">
                	<thead>
                    	<tr>
                        	<th>Fecha Contrato</th>
                            <th>Cliente</th>
                            <th>Nro Documento</th>
                            <th>Proyecto</th>
                            <th>Distrito</th>
                            <th>Urbanizacion</th>
                            <th>Tipo</th>
                            <th>Area Total</th>
                            <th>Monto Total</th>
                            <th>Monto Inicial</th>
                            <th>Monto Mensual</th>
                            <th>Nro Cuotas</th>
                            
                        </tr>
                    </thead>
                    <tbody>
                     <%For Each var As Inmobiliaria.MVC.ContratoModel In Model.Contratos%>
                     <tr>
                        <td><%= var.FechaContrato%> </td>
                        <td><%= var.Cliente.NombreCliente%></td>
                        <td><%= var.Cliente.nroDocumento%></td>
                        <td><%= var.Proyecto.Proyecto%></td>
                        <td><%= var.Proyecto.Distrito.Descripcion%></td>
                        <td><%= var.Proyecto.Urbanizacion%></td>
                        <td><%= var.Producto.TipoProducto.TipoProducto%></td>
                        <td><%= var.Producto.areaTotal%></td>
                        <td><%= var.MontoTotal%></td>
                        <td><%= var.MontoInicial%></td>
                        <td><%= var.MontoMensual%></td>
                        <td><%= var.NroCuotas%></td>
                        
                    </tr>

                    <% Next%>
                    	
                    </tbody>
                </table>
                <div class="extrabottom" style="display:none;">
                	<ul>
                    	<li><img SRC="../../Content/img/icons/icon_edit.png" alt="Edit" /> Edit</li>
                        <li><img SRC="../../Content/img/icons/icon_approve.png" alt="Approve" /> Approve</li>
                        <li><img SRC="../../Content/img/icons/icon_unapprove.png" alt="Unapprove" /> Unapprove</li>
                        <li><img SRC="../../Content/img/icons/icon_delete.png" alt="Delete" /> Remove</li>
                    </ul>
                    <div class="bulkactions">
                    	<select>
                        	<option>Select bulk action...</option>
                        </select>
                        <input type="submit" value="Apply" class="btn" />
                    </div>
                </div>
                <ul class="pagination">
                	<li class="text">Previous</li>
                    <li class="page"><a href="#" title="">1</a></li>
                    <li><a href="#" title="">2</a></li>
                    <li><a href="#" title="">3</a></li>
                    <li><a href="#" title="">4</a></li>
                    <li class="text"><a href="#" title="">Next</a></li>
                </ul>
                <div style="clear: both;"></div>
            </div>

</asp:Content>


