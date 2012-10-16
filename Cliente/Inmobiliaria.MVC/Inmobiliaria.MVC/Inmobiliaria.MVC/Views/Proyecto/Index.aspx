<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of Inmobiliaria.MVC.IndexProyectoViewModels)" %>


<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listado de Proyectos</asp:Content>
<asp:Content ID="Header" ContentPlaceHolderID="HeaderContent" runat="server">


    
    
    <script src="../../Content/jqControles/grid.locale-es.js" type="text/javascript"></script>
    <script src="../../Content/jqControles/jquery.jqGrid.min.js" type="text/javascript"></script>
    <script src="../../Content/plugins/jquery.searchFilter.js" type="text/javascript"></script>
    <script src="../../Content/plugins/ui.multiselect.js" type="text/javascript"></script>
    <script src="../../Content/plugins/jquery.contextmenu.js" type="text/javascript"></script>
    <script src="../../Content/plugins/jquery.tablednd.js" type="text/javascript"></script>


  

</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    

    <h2>Proyectos</h2>
       
    <div class="contentbox">
            	<table width="100%">
                	<thead>
                    	<tr>
                        	<th>Codigo de Proyecto</th>
                            <th>Proyecto</th>
                            <th>Codigo de Distrito</th>
                            <th>Distrito</th>
                            <th>Urbanizacion</th>
                            <th>Acciones</th>
                            <th><input name="" type="checkbox" value="" id="checkboxall" /></th>
                        </tr>
                    </thead>
                    <tbody>
                     <%For Each var As Inmobiliaria.MVC.ProyectoModel In Model.Proyectos%>
                     <tr>
                        <td><%= var.idProyecto%> </td>
                        <td><%= var.proyecto%></td>
                        <td><%= var.Distrito.idDistrito%></td>
                        <td><%= var.Distrito.Descripcion%></td>
                        <td><%= var.urbanizacion%></td>
                        <td>
                            	<a href="#" title=""><img SRC="../../Content/img/icons/icon_edit.png" alt="Edit" /></a>
                            	<a href="#" title=""><img SRC="../../Content/img/icons/icon_approve.png" alt="Approve" /></a>
                                <a href="#" title=""><img SRC="../../Content/img/icons/icon_unapprove.png" alt="Unapprove" /></a>
                                <a href="#" title=""><img SRC="../../Content/img/icons/icon_delete.png" alt="Delete" /></a>
                            </td>
                            <td><input type="checkbox" value="" name="checkall" /></td>
                    </tr>

                    <% Next%>
                    	
                    </tbody>
                </table>
                <div class="extrabottom">
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
