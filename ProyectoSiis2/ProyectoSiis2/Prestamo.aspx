<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Prestamo.aspx.cs" Inherits="ProyectoSiis2.Prestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
      <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="NumeroPlaca" HeaderText="Numero de Placa" />
                <asp:BoundField DataField="NumeroSerial" HeaderText="Numero de Serial" />
                <asp:BoundField DataField="ElementoAPrestar" HeaderText="Elemento A Prestar" />
                <asp:BoundField DataField="Marca" HeaderText="Marca" />
                <asp:BoundField DataField="IdPrestamo" HeaderText="IdPrestamo" />
                <asp:BoundField DataField="fechaPrestamo" HeaderText="Fecha Prestamo" />
                <asp:BoundField DataField="ElementoAPrestar" HeaderText="Elementos a prestar" />
                <asp:BoundField DataField="Observaciones" HeaderText="Observaciones" />
                            
            
            </Columns>
        </asp:GridView>
    
    </div>


</asp:Content>
