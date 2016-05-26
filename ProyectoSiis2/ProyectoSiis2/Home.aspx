<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProyectoSiis2.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
    <div>
        <img id="logoingreso" src="../imagenes/ingreso.jpg">
        <a href="Ingreso.aspx">
            <div class="ingreso">Ingreso </div>
        </a>

        <img id="logogestion" src="../imagenes/gestionInv.jpg">

        <a href="Gestion.aspx">
            <div class="gestion">Gestion </div>
        </a>




        <a href="Prestamo.aspx">
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
        <a href="Reserva.aspx">
            <div class="reservas">Reservas</div>
        </a>
        Prueba
    </div>
</asp:Content>
