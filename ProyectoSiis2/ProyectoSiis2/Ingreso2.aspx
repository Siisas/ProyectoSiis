<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Ingreso2.aspx.cs" Inherits="ProyectoSiis2.Ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoCuerpo" runat="server">
 
    <div>
    <asp:GridView ID="GvDatos" runat="server" AutoGenerateColumns="False" DataKeyNames="IdElemento" >
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

    

        <div>
    <h1> Insertar Elemento </h1>
        <table class = "auto-style1">
               <tr>
                   <td class = "auto-style2">
                       <asp:Label ID = "Label1" runat = "server" Text = "Id Elemento"></asp:Label>
                   </td>
                   <td style="margin-left: 120px">
                       <asp:TextBox ID = "TxtIdElemento" runat = "server"></asp:TextBox> 
                   </td>
               </tr>

               <tr>
                   <td class = "auto-style2">
                       <asp:Label ID = "Label2" runat = "server" Text = "Numero Placa"></asp:Label>
                   </td>
                   <td>
                       <asp:TextBox ID = "TxtNumeroPlaca" runat = "server"></asp:TextBox> 
                  </td>
               </tr>

               <tr>
                    <td class = "auto-style2">
                        <asp:Label ID = "Label3" runat = "server" Text = "Numero Serial"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID = "TxtNumeroSerial" runat = "server"></asp:TextBox> 
                    </td>
               </tr>

               <tr>
                   <td class = "auto-style2">
                        <asp:Label ID = "Label4" runat = "server" Text = "Marca"></asp:Label>
                   </td>
                   <td>
                        <asp:TextBox ID = "TxtMarca" runat = "server"></asp:TextBox> 
                   </td>
               </tr>

               <tr>
                    <td class = "auto-style2">
                           <asp:Label ID = "Label5" runat = "server" Text = "Modelo"></asp:Label>
                    </td>
                    <td>
                           <asp:TextBox ID = "TxtModelo" runat = "server"></asp:TextBox> 
                    </td>
                </tr>
             
            <tr>
                    <td class = "auto-style2">
                           <asp:Label ID = "Label6" runat = "server" Text = "Descripción"></asp:Label>
                    </td>
                    <td>
                           <asp:TextBox ID = "TxtDescripcion" runat = "server"></asp:TextBox> 
                    </td>
                </tr>

                <tr>
                     <td  class = "auto-style2">&nbsp;</td>
                     <td> 
                            <asp:Button ID = "BtnGuardar" runat = "server" Text = "Guardar" OnClick="BtnGuardar_Click"/>
                            <asp:Button ID = "BtnCancelar" runat = "server" Text = "Cancelar"/>
                     </td>
                </tr>
        </table>


    </div>
        <p>
            <asp:Label ID ="Label7" runat="server"></asp:Label>
        </p>
    



</asp:Content>
