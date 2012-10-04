<%@ Page Language="VB" Inherits="System.Web.Mvc.ViewPage(Of Inmobiliaria.MVC.LogOnModel)" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>LogOn2</title>
    <link href="../../Content/styles/layout.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/styles/login.css" rel="stylesheet" type="text/css" />
    <!-- Theme Start -->
    <link href="../../Content/themes/blue/styles.css" rel="stylesheet" type="text/css" />


</head>
<body>
   <div id="logincontainer">
    	<div id="loginbox">
        	<div id="loginheader">
            </div>
                 
            <div id="innerlogin">
             <% Using Html.BeginForm() %>
            	
                    <%= Html.ValidationSummary(True, "El inicio de sesión no se realizó correctamente. Corrija los errores y vuelva a intentarlo.")%>
      
                	<p><%= Html.LabelFor(Function(m) m.UserName) %></p>
                    <div class="editor-field">
                     <%= Html.TextBoxFor(Function(m) m.UserName, New With {.Class = "logininput"})%>
                    <%= Html.ValidationMessageFor(Function(m) m.UserName) %>
                    </div>
                	
                    <p>  <%= Html.LabelFor(Function(m) m.Password) %></p>
                    <div class="editor-field">
                    <%= Html.PasswordFor(Function(m) m.Password, New With {.Class = "logininput"})%>
                    <%= Html.ValidationMessageFor(Function(m) m.Password) %>
                    </div>
                	<div class="editor-label">
                    <%= Html.CheckBoxFor(Function(m) m.RememberMe) %>
                    <%= Html.LabelFor(Function(m) m.RememberMe) %>
                    </div>
                   
                   	<input type="submit" class="loginbtn" value="Iniciar Sesion" /><br />
                    
                   
                <% End Using %>
            </div>
            
        </div>
        <img SRC="../../Content/img/login_fade.png" alt="Fade" />
    </div>
</body>
</html>
