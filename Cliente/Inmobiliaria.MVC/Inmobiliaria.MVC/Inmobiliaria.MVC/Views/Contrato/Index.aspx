<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage(Of Inmobiliaria.MVC.IndexContratoViewModels)" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Registrar Solicitudes</asp:Content>
<asp:Content ID="Header" ContentPlaceHolderID="HeaderContent" runat="server">
<script src="../../Scripts/MicrosoftAjax.js" type="text/javascript"></script>
        <script src="../../Scripts/MicrosoftMvcAjax.js" type="text/javascript"></script>
<script type="text/javascript">


    function VerificaBanco() {
        $.post("/Contrato/VerificaBanco/",
        {
            nroDocumento: $('#Cliente_nroDocumento').val()
        },
        function (data) {
            // alert("JSON Data: " + json.Resultado);

            if (data.Resultado == "Aprobado") {
                alert("El cliente ya fue aprobado por el banco.");
                $('#Cliente_NombreCliente').val(data.Cliente.NombreCliente);
                $('#Cliente_ApellidosCliente').val(data.Cliente.ApellidosCliente);
                $('#Cliente_TipoCliente_Descripcion').val("PERSONA NATURAL");
                $('#Cliente_EstadoCivil_Descripcion').val(data.Cliente.EstadoCivil.Descripcion);

                CargarDatosCliente($('#Cliente_nroDocumento').val());

            } else if (data.Resultado == "Nothing") {
                alert("No se encontro al cliente");
            } else {
                alert("El cliente no fue aprobado por el banco.");
                $('#Cliente_NombreCliente').val("");
                $('#Cliente_ApellidosCliente').val("");
                $('#Cliente_TipoCliente_Descripcion').val("");
                $('#Cliente_EstadoCivil_Descripcion').val("");
            }
        },
         "json");
    }

    function CargarDatosCliente(nroDoc) {
        $.post("/Contrato/GetCliente_NroDoc/",
        { nroDocumento: nroDoc },
        function (data) {
            if (data.length > 0) {
                $("#hdnIdCliente").val(data[0].idCliente);
                CargaCotizacion(data[0].idCliente);
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
    function CargaCotizacion(idCliente) {
        //$('listaProducto')
        $.post("/Contrato/GetCotizacionesCliente/",
        { idCliente: idCliente },
        function (data) {
            $("#listaProducto tbody").remove();
            if (data == null || data.length == 0) {

                alert("No se encontraron cotizaciones...");
            }
            else {
                $("#listaProducto tbody").remove();
                var fila = '';
                $("#listaProducto").append("<tbody>");

                for (var i = 0; i < data.length; i++) {
                    fila = "<td><input name='' type='checkbox' value='' id='chk" + data[i].idCotizacion + "' onchange='Detalle(this," + data[i].idCotizacion + "," + data[i].Monto + ")'/></td>";
                    fila += "<td>" + data[i].idCotizacion + "</td>";
                    fila += "<td>" + data[i].FechaCotizacion + "</td>";
                    fila += "<td>" + data[i].Proyecto.Proyecto + "</td>";
                    fila += "<td>" + data[i].Producto.TipoProducto.TipoProducto + "</td>";
                    fila += "<td>" + data[i].Monto + "</td>";
                    fila += "<td>" + data[i].Producto.Ubicacion + "</td>";
                                       

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
    function Detalle(cb, id,monto) {
        if (cb.checked == true) {
            $("#txtMontoTotal").val(monto)
            $("#hdnIdCotizacion").val(id);
        }
        else {
            $("#txtMontoTotal").val('')
        }
     
    }

   

    function GenerarContrato() {
        $.post("/Contrato/GenerarContrato/",
        { idCliente: $("#hdnIdCliente").val(),
          idCotizacion: $("#hdnIdCotizacion").val(),
          MontoTotal: $("#txtMontoTotal").val(),
          MontoInicial: $("#txtMontoInicial").val(),
          MontoMensual: $("#txtMontoMensual").val(),
          NroCuotas: $("#txtNroCuotas").val()
           },
        function (data) {
           alert("El contrato se genero con exito")
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

                        <input type="button" id="idLinkEnvia" onclick="VerificaBanco()" value="Enviar" class="btn" />
                                                
                                              
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

        <div class="contentcontainer med left">
            <div class="headings alt">
                <h2>Datos de Cotizacion</h2>
            </div>
             <div class="contentbox">
             

             <div class="lrg">
            	<table width="100%" id="listaProducto">
                	<thead>
                    	<tr>
                            <th><input name="" type="checkbox" value="" id="checkboxall" /></th>
                        	<th>Cotizacion</th>
                            <th>Fec Cotizacion</th>
                            <th>Proyecto</th>
                            <th>Tipo</th>
                            <th>Monto</th>
                            <th>Ubicacion</th>
                            
                            
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
                <div style="clear: both;"></div>
            </div>
            <div style="clear: both; padding:15px;"></div>
            <div class="colm left">
             <p>
                 <label for="textfield"><strong>Monto Total</strong></label>
                 <input type="text" class="smlbox" id="txtMontoTotal" disabled="disabled" /> 
                 <input type="hidden" id="hdnIdCotizacion" />
             </p>
             
             </div>
             <div class="colm left">
            <p>
                 <label for="textfield"><strong>Monto Inicial</strong></label>
                 <input type="text" class="smlbox" id="txtMontoInicial" /> 
             </p>
             </div>
             <div class="colm left">
              <p>
                 <label for="textfield"><strong>Monto Mensual</strong></label>
                 <input type="text" class="smlbox" id="txtMontoMensual" /> 
                 
             </p>
             </div>
             <div class="colm left">
             <p>
                <label for="textfield"><strong>Nro Cuotas</strong></label>
                <input type="text" class="smlbox" id="txtNroCuotas" /> 
                <input id="idCargar" type="button" value="Generar Contrato" class="btn"  onclick="GenerarContrato()"/>
                </p>
             </div>
             </div>
              

        </div>

          <% End Using%>

  
</asp:Content>
