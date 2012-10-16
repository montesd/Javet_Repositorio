<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage(Of Inmobiliaria.MVC.IndexCotizacionViewModels)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Cotizacion</asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
        <script src="../../Scripts/MicrosoftAjax.js" type="text/javascript"></script>
        <script src="../../Scripts/MicrosoftMvcAjax.js" type="text/javascript"></script>
        <script type="text/javascript" >


       function AgregarCotizacion(idProducto) { 
            
       }
        function BuscaCliente() {
                $.post("/Cotizacion/GetCliente/",
        {
            nroDocumento: $('#Cliente_nroDocumento').val()
        },
        function (data) {
            // alert("JSON Data: " + json.Resultado);

            if (data.length > 0) {

                $('#Cliente_NombreCliente').val(data[0].NombreCliente);
                $('#Cliente_ApellidosCliente').val(data[0].ApellidosCliente);
                $('#Cliente_TipoCliente_Descripcion').val("PERSONA NATURAL");
                $('#Cliente_EstadoCivil_Descripcion').val(data[0].EstadoCivil.Descripcion);

                $('#hdnIdCliente').val(data[0].idCliente);
            }
            else {
                alert("No se encontro cliente con el numero de documento solicitado");
                $('#hdnIdCliente').val("");
                $('#Cliente_NombreCliente').val("");
                $('#Cliente_ApellidosCliente').val("");
                $('#Cliente_TipoCliente_Descripcion').val("");
                $('#Cliente_EstadoCivil_Descripcion').val("");
            }
        },
         "json");
            }


    function CargaProducto() {
        //$('listaProducto')
        var idProyecto = $('#cboProyectos').val()
        $.post("/Cotizacion/ObtieneProductos_Proyecto/",
        { idProyecto: idProyecto },
        function (data) {
            $("#listaProducto tbody").remove();
            if (data == null || data.length == 0) {
               alert("No se encontraron productos...");
            }
            else {
                $("#listaProducto tbody").remove();
                var fila = '';
                $("#listaProducto").append("<tbody>");

                for (var i = 0; i < data.length; i++) {
                    fila = "<td><a href='#' onClick='AgregarCotizacion(" + data[i].idProducto + ")'><img SRC='../../Content/img/icons/Add-32.png' width='16px' alt='Add' /></a></td>";
                    fila += "<td>" + data[i].TipoProducto.TipoProducto + "</td>";
                    fila += "<td>" + data[i].Urbanizacion + "</td>";
                    fila += "<td>" + data[i].Ubicacion + "</td>";
                    fila += "<td>" + data[i].Precio + "</td>";
                    fila += "<td>" + data[i].areaTotal + "</td>";
                    fila += "<td>" + data[i].areaConstruida + "</td>";
                    fila += "<td>" + data[i].nroPiso + "</td>";
                    fila += "<td>" + data[i].nroHabitaciones + "</td>";
                    fila += "<td>" + data[i].nroBanhos + "</td>";
                    
                    $("#listaProducto").append(
                        $("<tr></tr>")
                            .html(fila)
                        );
                }

                $("#listaProducto").append("</tbody>");
            }
        }, "json"
        );
    }

            function CargaProyecto() {

                $('#cboProyectos').html('<option selected>CARGANDO</option>');
                $.post("/Proyecto/GetProyectosDistrito/",
        {
            idDistrito: $('#cboDistritos').val()
        },
        function (data) {
            $("#cboProyectos option").remove();
            if (data == null || data.length == 0) {

                alert("No se encontraron proyectos para el distrito seleccionado");
            }
            else {
                $("#cboProyectos").append(
                 $("<option></option>") // Yes you can do this.
                       .text("SELECCIONE")
                       .val(0)
                );
                for (var i = 0; i < data.length; i++) {
                    $("#cboProyectos").append( // Append an object to the inside of the select box
                    $("<option></option>") // Yes you can do this.
                       .text(data[i].Proyecto)
                       .val(data[i].idProyecto)
                     );
                }

            }

        },
         "json");

    }

    function CargaDistrito() {

        $('#cboDistritos').html('<option selected>CARGANDO</option>');


        $.post("/Maestro/GetDistritos_Tipo/",
        {
            tipo: $('#Tipos_0__TipoProducto').val()
        },
        function (data) {
            $("#cboDistritos option").remove();
            if (data == null || data.length == 0) {

                alert("No se encontraron distritos para el tipo seleccionado");
            }
            else {
                $("#cboDistritos").append(
                 $("<option></option>") // Yes you can do this.
                       .text("SELECCIONE")
                       .val(0)
                );
                for (var i = 0; i < data.length; i++) {
                    $("#cboDistritos").append( // Append an object to the inside of the select box
                    $("<option></option>") // Yes you can do this.
                       .text(data[i].Descripcion)
                       .val(data[i].idDistrito)
                     );
                }

            }

        },
         "json");

    }

        </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
 <% Using Html.BeginForm() %>
    
   <div class="contentcontainer xsml left">
            <div class="headings alt">
                <h2>Información del Cliente</h2>
            </div>
            <div class="contentbox">
                    <p>
                        <label for="textfield"><strong>
                        <%= Html.LabelFor(Function(m) m.Cliente.nroDocumento)%></strong>
                        </label>
                        
                        <%= Html.TextBoxFor(Function(m) m.Cliente.nroDocumento, New With {.class = "inputbox"})%>

                        <input type="button" id="idLinkEnvia" onclick="BuscaCliente()" value="Enviar" class="btn" />
                                                
                                              
                    </p>
            		<p>
                        <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Cliente.NombreCliente)%>
                        </strong></label>
                        <%= Html.TextBoxFor(Function(m) m.Cliente.NombreCliente, New With {.class = "inputbox", .disabled = "disabled"})%>

                        <input type="hidden" id="hdnIdCliente" />
                        
                    </p>
                    <p>
                        <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Cliente.ApellidosCliente)%></strong></label>
                        <%= Html.TextBoxFor(Function(m) m.Cliente.ApellidosCliente, New With {.class = "inputbox", .disabled = "disabled"})%>
                    </p>
                    <p>
                        <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Cliente.TipoCliente.Descripcion)%></strong></label>
                        <%= Html.TextBoxFor(Function(m) m.Cliente.TipoCliente.Descripcion, New With {.class = "inputbox", .disabled = "disabled"})%>
                    </p>
                    <p>
                        <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Cliente.EstadoCivil.Descripcion)%></strong></label>
                        <%= Html.TextBoxFor(Function(m) m.Cliente.EstadoCivil.Descripcion, New With {.class = "inputbox", .disabled = "disabled"})%>
                    </p>
                    
           </div>
        </div>

        <div class="contentcontainer xmed left" style="margin-left:5px;">
            <div class="headings alt">
                <h2>Datos de Cotizacion</h2>
            </div>
             <div class="contentbox">
            <div class="xsml left">
             <p>
                 <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Tipos(0).TipoProducto)%></strong></label>
                  <%= Html.DropDownListFor(Function(m) m.Tipos(0).TipoProducto, New SelectList(Model.Tipos, "idTipo", "TipoProducto"), New With {.onchange = "CargaDistrito()"})%>
             </p>
             
             </div>
             <div class="xsml left">
            <p>
                 <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Proyecto.Distrito.Descripcion)%></strong></label>
                 <select id="cboDistritos" onchange="CargaProyecto()">
                   <option  value="0">SELECCIONE</option>
                 </select>
             </p>
             </div>
             <div class="xsml left">
              <p>
                 <label for="textfield"><strong><%= Html.LabelFor(Function(m) m.Proyecto.proyecto)%></strong></label>
                 <select id="cboProyectos" onchange="CargaProducto()">
                   <option  value="0">SELECCIONE</option>
                 </select>
             </p>
             </div>
           <%-- <input id="btnCargar" type="button" value="Cargar" class="btn"  onclick="CargaProducto()"/>--%>
          
              <div style="clear: both; padding:5px;"></div>
             <div class="lrg">
            	<table width="100%" id="listaProducto">
                	<thead>
                    	<tr>
                            <th><input name="" type="checkbox" value="" id="checkboxall" /></th>
                            <th>Tipo</th>
                        	<th>Urbanizacion</th>
                            <th>Ubicacion</th>
                            <th>Precio (US$)</th>
                            <th>Area Total</th>
                            <th>Area Const</th>
                            <th>Nro Piso</th>
                            <th>Nro Hab</th>
                            <th>Nro Ba&ntilde;os</th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
                <div style="clear: both;"></div>
            </div>
            
             </div>
              

        </div>

          <% End Using%>
    
</asp:Content>



