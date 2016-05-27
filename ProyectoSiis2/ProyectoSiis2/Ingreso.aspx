<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ingreso.aspx.cs" Inherits="ProyectoSiis2.ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">


     <div>
         <h1>Insertar Reserva</h1>
        <table class="auto-style1">
            <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Identificacion"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Nombre Solicitante"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="TxtNombreSolicitante" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Elemento a Prestar"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="TxtElementoAPrestar" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Fecha Prestamo"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="TxtFechaPrestao" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Observaciones"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="TxtObservaciones" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td class ="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Fecha Devolucion"></asp:Label>

                </td>
                <td>
                    <asp:TextBox ID="Txtfechadevolucion" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
            <td class="auto-style2"> &nbsp;

            </td>
            <td>
                <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
                <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" />
            </td>
            </tr>
            </table>
          </div>
        <p>
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
        </p>
    


</asp:Content>
