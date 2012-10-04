<%@ Page Language="VB" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
   Bienvenido :: Inmobiliaria MDR
</asp:Content>
<asp:Content ID="indexRef" ContentPlaceHolderID="HeaderContent" runat="server">
 
    <link rel="stylesheet" href="../../Content/themes/default/default.css" type="text/css" media="screen" />
    
    <link rel="stylesheet" href="../../Content/themes/light/light.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="../../Content/themes/dark/dark.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="../../Content/themes/bar/bar.css" type="text/css" media="screen" />
    <link href="../../Content/css/style.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/css/nivo-slider.css" rel="stylesheet" type="text/css" />
    <script src="../../Content/jqControles/jquery.nivo.slider.js" type="text/javascript"></script>

  

 
</asp:Content>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
    
   <div id="wrapper">
        

        <div class="slider-wrapper theme-default">
            <div id="slider" class="nivoSlider">
            <img src="../../Content/img/slide_1.jpg"  data-thumb="../../Content/img/slide_1.jpg" 
            alt="" title="Pensamos en tu bienestar" />
            <img src="../../Content/img/slide_2.jpg" data-thumb="../../Content/img/slide_2.jpg" alt=""
            title="Pensamos en tu bienestar"/>
            <img src="../../Content/img/slide_3.jpg" data-thumb="../../Content/img/slide_3.jpg" 
            alt="" title="Pensamos en tu bienestar" />
            <img src="../../Content/img/slide_4.jpg" data-thumb="../../Content/img/slide_4.jpg" alt="" title="Pensamos en tu bienestar"
            />
               
            </div>
            
        </div>

    </div>

   
    <script type="text/javascript">
        $(window).load(function () {
            $('#slider').nivoSlider();
        });
    </script>





    
</asp:Content>
