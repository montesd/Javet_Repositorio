<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage(Of Inmobiliaria.MVC.IndexSolicitudViewModels)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Registrar Solicitudes</asp:Content>
<asp:Content ID="Header" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <% Using Html.BeginForm() %>
    
   <div class="contentcontainer med left">
            <div class="headings alt">
                <h2>Información del Cliente</h2>
            </div>
            <div class="contentbox">
            	<input type="submit" value="Submit" class="btn" />
            		<p>
                        <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Cliente.NombreCliente)%></strong></label>
                        <%= Html.TextBoxFor(Function(m) m.Cliente.NombreCliente, "class=inputbox")%>
                        <br />
                    </p>
                    <p>
                        <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Cliente.ApellidosCliente)%></strong></label>
                        <%= Html.TextBoxFor(Function(m) m.Cliente.ApellidosCliente, "class=inputbox")%>
                        <br />
                    </p>
           </div>
        </div>

        <div class="contentcontainer med left">
            <div class="headings alt">
                <h2>Datos del Proyecto</h2>
            </div>
             <div class="contentbox">
             <p>
                 <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Proyecto.Distrito.Descripcion)%></strong></label>
                 <%= Html.DropDownListFor(Function(m) m.Proyecto.Distrito.Descripcion, New SelectList(Model.Distritos, "idDistrito", "Descripcion"))%>
                  <br />
             </p>
             <p>
                 <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Tipos(0).TipoProducto)%></strong></label>
                  <%= Html.DropDownListFor(Function(m) m.Tipos(0).TipoProducto, New SelectList(Model.Tipos, "idTipo", "TipoProducto"))%>
                  <br />
             </p>
             <p>
                 <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Proyecto.proyecto)%></strong></label>
                  <%= Html.DropDownListFor(Function(m) m.Proyecto.proyecto, New SelectList(Model.Tipos, "idTipo", "TipoProducto"))%>
                  <br />
             </p>
             </div>

        </div>

          <% End Using%>

  
</asp:Content>
