<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProyectoSiis2.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
    <div>
        <img id="logoingreso" src="../imagenes/ingreso.jpg">
        <a href="Siis.aspx">
            <div class="ingreso">Ingreso </div>
        </a>

        <img id="logogestion" src="../imagenes/gestionInv.jpg">

        <a href="..//index.html">
            <div class="gestion">Gestion </div>
        </a>




        <a href="prestamo.html">
            <div class="prestamo">Prestamo</div>
        </a>
        <img id="logoprestamo" src="../imagenes/prestamo.jpg">

        <img id="logotrazabilidad" src="..//imagenes/trazabilidad.jpg">


        <a href="../index.html">
            <div class="trazabilidad">Trazabilidad</div>
        </a>



        <a href="devolucion.html">
            <div class="devolucion">Devolución</div>
        </a>
        <img id="logodevolucion" src="../imagenes/devolucion.jpg">
        <img id="logoreservas" src="../imagenes/reservas.jpg">
        <a href="index.html">
            <div class="reservas">Reservas</div>
        </a>

    </div>
</asp:Content>
