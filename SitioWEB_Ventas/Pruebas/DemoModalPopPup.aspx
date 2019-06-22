<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeFile="DemoModalPopPup.aspx.cs" Inherits="EjemplosExtensores_DemoModalPopPup" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 318px;
        }
        .auto-style3 {
            width: 293px;
        }
        .auto-style4 {
            width: 167px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:UpdatePanel runat="server">
        <ContentTemplate>

       
  <p class="tituloForm">
        Ejemplo de Modal PopUp AJAX</p>
    <br />
    <br />
    <table class="auto-style1">
        <tr>
            <td class="labelContenido">Ingrese Horas trabajadas</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtHoras" runat="server" CssClass="TextBoxDerecha"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Tarifa horaria</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtTarifa" runat="server" CssClass="TextBoxDerecha" ReadOnly="True"></asp:TextBox>
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/Images/Buscar.png" OnClick="btnBuscar_Click" style="width: 16px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="labelContenido">Ingrese tardanzas</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtTardanzas" runat="server" CssClass="TextBoxDerecha"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
            </td>
        </tr>
        <tr>
            <td class="labelContenido">Calculo del neto a pagar</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtNeto" runat="server" CssClass="TextBoxDerecha"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>


        <tr>
            <td class="auto-style2">
              
            </td>
            <td class="auto-style3">
              
               


            </td>
            <td>&nbsp;</td>
        </tr>


    </table>
    
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
             

    <%--Este es el panel para el Popup del tarifario--%>
              <asp:LinkButton ID="lnkTarifario"   runat="server" ></asp:LinkButton>
            <cc1:ModalPopupExtender ID="mpTarifario" runat="server" TargetControlID="lnkTarifario" 
                    PopupControlID="pnlTarifario" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />
    <asp:Panel ID="pnlTarifario" runat="server" CssClass="CajaDialogo" Style="display: none;" Width ="300px"> 
                    <table border="0" width="300px" style="margin: 0px; padding: 0px; color: #FFFFFF;"> 
                        <tr style="background-color:darkred""> 
                            <td align="center" colspan="2"> 
                                <asp:Label ID="Label1" runat="server" Text="Tarifa" /> 
                                &nbsp;&nbsp;&nbsp;&nbsp;
                            </td> 
                        </tr> 
                         <tr>
                             <td class="auto-style4">
                                   <asp:Label ID="Label2" runat="server" Text="Seleccione tarifa:" CssClass="labelContenido" /> 
                             </td>
                             <td>
<asp:DropDownList ID="cboCategoria" runat="server">
                        <asp:ListItem Value="0">--Seleccione--</asp:ListItem>
                        <asp:ListItem Value="50">Tiempo completo</asp:ListItem>
                        <asp:ListItem Value="30">Tiempo parcial</asp:ListItem>
                        <asp:ListItem Value="20">Jefe practica</asp:ListItem>
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
                        <asp:Button ID="btnAceptarTarifa" runat="server" Text="Aceptar" OnClick="btnAceptarTarifa_Click" />  <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /> 
                    </div> 
                </asp:Panel> 
                
    <br />
    <br />
     </ContentTemplate>
           
            </asp:UpdatePanel>
</asp:Content>

