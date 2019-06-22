<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeFile="VendedorMan01.aspx.cs" Inherits="VendedorMan01" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        Matenimiento de Vendedores</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Vendedor" OnClick="btnNuevo_Click" />
    </p>
    <p class="center">
        <asp:GridView ID="grvDatos" runat="server" Width="784px" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="grvDatos_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField ButtonType="Image" ImageUrl="~/Images/Editar.png" Text="Botón" CommandName="Editar" />
                <asp:BoundField DataField="cod_ven" HeaderText="Codigo" />
                <asp:BoundField DataField="nom_ven" HeaderText="Nombres" />
                <asp:BoundField DataField="ape_ven" HeaderText="Apellidos" />
                <asp:BoundField DataField="sue_ven" DataFormatString="{0:n}" HeaderText="Sueldo(S/.)" />
                <asp:BoundField DataField="fec_ing" DataFormatString="{0:d}" HeaderText="Fecha de Ingreso" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                <asp:ButtonField ButtonType="Image" CommandName="Eliminar" ImageUrl="~/Images/Cancelar.png" Text="Botón" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>

    <%--Este es el panel  que contiene los mensajes de error--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
               <cc1:ModalPopupExtender ID="mpeMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />
                <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: none;" Width="300"> 
                                    <table border="0" width="300px" style="margin: 0px; padding: 0px; background-color:darkred ; 
                                        color: #FFFFFF;"> 
                                        <tr> 
                                            <td align="center"> 
                                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" /> 
                                            </td> 
                                            <td width="12%"> 
                                                <asp:ImageButton ID="btnCerrar" runat="server" ImageUrl="~/Images/Cancelar.png" Style="vertical-align: top;" 
                                                    ImageAlign="Right" /> 
                                            </td> 
                                        </tr> 
                         
                                    </table> 
                                    <div> 
                                        <asp:Label ID="lblMensaje" runat="server" Text="" ForeColor ="Black" /> 
                                    </div> 
                                    <div> 
                                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" /> 
                                    </div> 
                                </asp:Panel> 

    <%--Este es el panel para el Popup de Insertar--%>
              <asp:LinkButton ID="lnkInsertar"   runat="server" ></asp:LinkButton>
            <cc1:ModalPopupExtender ID="mpInsertar" runat="server" TargetControlID="lnkInsertar" 
                    PopupControlID="pnlInsertar" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />
    <asp:Panel ID="pnlInsertar" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width ="700px"> 
                    <table border="0" width="700px" style="margin: 0px; padding: 0px; color: #FFFFFF;"> 
                        <tr style="background-color:darkred""> 
                            <td align="center" colspan="2"> 
                                <asp:Label ID="Label1" runat="server" Text="Insertar Vendedor" /> 
                                &nbsp;&nbsp;&nbsp;&nbsp;
                            </td> 
                        </tr> 
                         <tr>
                             <td class="auto-style4">
                                   <asp:Label ID="Label2" runat="server" Text="Ingresar Nombre" CssClass="labelContenido" /> 
                             </td>
                             <td>
                                 <asp:TextBox ID="txtNom" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                             </td>

                         </tr>
                         <tr>
                             <td class="auto-style4">
                                   <asp:Label ID="Label3" runat="server" Text="Ingresar Apellido" CssClass="labelContenido" /> 
                             </td>
                             <td>
                                 <asp:TextBox ID="txtApe" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                             </td>

                         </tr>
                         <tr>
                             <td class="auto-style4">
                                   <asp:Label ID="Label4" runat="server" Text="Ingresar Fecha" CssClass="labelContenido" /> 
                             </td>
                             <td>
                                 <asp:TextBox ID="txtFecIng" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                                 <cc1:CalendarExtender ID="txtFecIng_CalendarExtender" runat="server" BehaviorID="txtFecIng_CalendarExtender" TargetControlID="txtFecIng" />
                             </td>

                         </tr>
                         <tr>
                             <td class="auto-style4">
                                   <asp:Label ID="Label5" runat="server" Text="Ingresar Sueldo" CssClass="labelContenido" /> 
                             </td>
                             <td>
                                 <asp:TextBox ID="txtSue" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                             </td>

                         </tr>
                         <tr>
                             <td class="auto-style4">
                                   <asp:Label ID="Label6" runat="server" Text="Seleccione Tipo" CssClass="labelContenido" /> 
                             </td>
                             <td>
                                 <asp:DropDownList ID="cboTipo" runat="server">
                                     <asp:ListItem Value="0">--Seleccione--</asp:ListItem>
                                     <asp:ListItem Value="1">Estable</asp:ListItem>
                                     <asp:ListItem Value="2">Contratado</asp:ListItem>
                                 </asp:DropDownList>
                             </td>

                         </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblError" runat="server" Text=".." cssClass="labelContenido"></asp:Label>
                            </td>
                        </tr>
                    </table> 
                    <div> 
                        
                    </div> 
                    <div> 
                        <asp:Button ID="btnGravar" runat="server" Text="Aceptar" OnClick="btnGravar_Click"/>  
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /> 
                    </div> 
                </asp:Panel> 
</asp:Content>

