<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="PrestamoElemento.aspx.cs" Inherits="ProyectoSiis2.PrestamoElemento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
    <link href="../bootstrap.min.css" rel="stylesheet">

    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <link href="../ie10-viewport-bug-workaround.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="justified-nav.css" rel="stylesheet">

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="../ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->




    <div class="container">

        <!-- The justified navigation menu is meant for single line per list item.
           Multiple lines will require custom code not provided by Bootstrap. -->
        <div class="masthead">

            <nav >
                <ul class="nav nav-justified">
                    <li><a  href="Home.aspx"">Inicio</a></li>
                    <li><a  href="IngresoELemento.aspx">Ingreso Elemento</a></li>
                    <li class="active" ><a  href="#">Prestamo</a></li>
                    <li><a  href="#">Devolución</a></li>
                    <li><a  href="ReservaElemento.aspx">Reservas</a></li>
                    <li><a  href="InventarioElemento.aspx">Inventarios</a></li>
                </ul>
            </nav>
        </div>

        <!-- /container -->


        <!-- Bootstrap core JavaScript
    ================================================== -->
        <!-- Placed at the end of the document so the pages load faster -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
        <script>window.jQuery || document.write('<script src="../js/vendor/jquery.min.js"><\/script>')</script>
        <script src="../js/bootstrap.min.js"></script>
        <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
        <script src="../js/ie10-viewport-bug-workaround.js"></script>


        <%--<div>
        <img id="logoingreso" src="../imagenes/ingreso.jpg"/>
        <a href="Ingreso2.aspx">
            <div class="ingreso">Ingreso </div>
        </a>

        <img id="logogestion" src="../imagenes/gestionInv.jpg"/>

        <a href="Gestion.aspx">
            <div class="gestion">Gestion </div>
        </a>
        
        <a href="Prestamo.aspx">
            <div class="prestamo">Prestamo</div>
        </a>
        <img id="logoprestamo" src="../imagenes/prestamo.jpg"/>

        <img id="logotrazabilidad" src="..//imagenes/trazabilidad.jpg"/>


        <a href="../index.html">
            <div class="trazabilidad">Trazabilidad</div>
        </a>
        
        <a href="devolucion.html">
            <div class="devolucion">Devolución</div>
        </a>
        <img id="logodevolucion" src="../imagenes/devolucion.jpg"/>
        <img id="logoreservas" src="../imagenes/reservas.jpg"/>
        <a href="Reserva.aspx">
            <div class="reservas">Reservas</div>
        </a>
       
    </div>--%>

        <%--<div class="jumbotron">
        <h1>Bienvenidos al Sistema de Información Inventario Sena</h1>
        <p>This example is a quick exercise to illustrate how the default, static navbar and fixed to top navbar work. It includes the responsive CSS and HTML, so it also adapts to your viewport and device.</p>
        <p>
          <a class="btn btn-lg btn-primary" href="../../components/#navbar" role="button">View navbar docs &raquo;</a>
        </p>
      </div>--%>


        <%--<script src="../../assets/js/ie10-viewport-bug-workaround.js"></script>
</asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
        
        <h1>Bienvenidos al Sistema de Información Inventario Sena</h1>
       
       <h2>Consultec Restrepo</h2>
        --%>

        <div class="jumbotron">
            
        </div>
        <footer class="footer">
            <div class="container">
                <h2>Sena  ©2016  ADSI Ficha 908163  Instructor Jesus Rubio  </h2>
            </div>
        </footer>
</asp:Content>
