<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Gestion.aspx.cs" Inherits="ProyectoSiis2.Gestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">

      <div>
    <asp:GridView ID="GvDatos" runat="server" AutoGenerateColumns="False" DataKeyNames="IdElemento" OnRowDeleting="GvDatos_RowDeleting" >
                <Columns>
                    <asp:BoundField DataField="IdElemento" HeaderText="Id Elemento" />
                    <asp:BoundField DataField="NumeroPlaca" HeaderText="Numero Placa" />
                    <asp:BoundField DataField="NumeroSerial" HeaderText="Numero Serial" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                    <asp:TemplateField HeaderText="Eliminar">
                         <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" Text="Eliminar" CausesValidation="False" CommandName="Delete"></asp:LinkButton>
                    </ItemTemplate>
                       
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
</div>
      <p>
            <asp:Label ID = "mensaje" runat = "server"></asp:Label>
        </p>
</asp:Content>
