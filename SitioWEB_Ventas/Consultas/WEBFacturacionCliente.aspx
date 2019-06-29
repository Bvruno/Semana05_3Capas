<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeFile="WEBFacturacionCliente.aspx.cs" Inherits="Consultas_WEBFacturacionCliente" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 322px;
        }
        .auto-style2 {
            width: 260px;
        }
        .auto-style3 {
            width: 260px;
            height: 26px;
        }
        .auto-style4 {
            width: 322px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;</p>
    <p class="tituloForm">
        FACTURACION DE CLIENTE ENTRE FECHAS</p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Consultas/Consultas.aspx">Retornar</asp:HyperLink>
    </p>
    <table class="w-100">
        <tr>
            <td class="auto-style2">Seleccion Cliente</td>
            <td class="auto-style1">
                <asp:DropDownList ID="cboCliente" runat="server" CssClass="offset-sm-0" Width="166px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Elija fecha de Inicio</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtFI" runat="server" CssClass="TextBoxDerecha"></asp:TextBox>
                <cc1:CalendarExtender ID="txtFI_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="txtFI">
                </cc1:CalendarExtender>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style2">Elija fecha de Fin</td>
            <td class="auto-style1">
                <asp:TextBox ID="txtFF" runat="server" CssClass="TextBoxDerecha"></asp:TextBox>
                <cc1:CalendarExtender ID="txtFF_CalendarExtender" runat="server" BehaviorID="TextBox2_CalendarExtender" TargetControlID="txtFF">
                </cc1:CalendarExtender>
            </td>
            <td>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores" Text="Label"></asp:Label>
            </td>
            <td class="auto-style1">
                &nbsp;
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvFacturas" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" ShowHeaderWhenEmpty="True" Width="705px">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="num_fac" HeaderText="Nro. Factura" />
                        <asp:BoundField DataField="fec_fac" DataFormatString="{0:d}" HeaderText="Fec. Facturacion">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="fec_can" DataFormatString="{0:d}" HeaderText="Fec. Cancelacion" />
                        <asp:BoundField DataField="total" DataFormatString="{0:n}" HeaderText="Total (S./)">
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                    </Columns>
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <SortedAscendingCellStyle BackColor="#FAFAE7" />
                    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                    <SortedDescendingCellStyle BackColor="#E1DB9C" />
                    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>

