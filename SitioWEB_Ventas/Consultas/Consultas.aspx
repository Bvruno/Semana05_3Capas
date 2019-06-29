<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeFile="Consultas.aspx.cs" Inherits="Consultas_Consultas" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<table class="tituloForm">
        CONSULTAS DEL SISTEMA
        <tr>
            <td class="style2">
                <asp:Image ID="Image1" runat="server" Height="267px" 
                    ImageUrl="~/Images/Consultas.jpg" Width="274px" />
            </td>
            <td>
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="Faq">
                    <HoverNodeStyle Font-Underline="True" ForeColor="Purple" />
                    <Nodes>
                        <asp:TreeNode NavigateUrl="~/Consultas/ListarFacturasVendedor.aspx" 
                            Text="Listar Facturas Vendedor" Value="Listar Facturas Vendedor">
                        </asp:TreeNode>
                        <asp:TreeNode 
                            Text="Listar Facturas Cliente" Value="Listar Facturas Cliente" NavigateUrl="~/Consultas/WEBFacturacionCliente.aspx">
                        </asp:TreeNode>
                        <asp:TreeNode Text="Listar Productos Proveedor" 
                            Value="Listar Productos Proveedor"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/Consultas/WebConsultaOCProveedorFechas.aspx" Text="Listar Ordenes Proveedor Fechas" Value="Listar Ordenes Proveedor Fechas"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/MenuPrincipal.aspx" Text="Retornar Menu" Value="Retornar Menu"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="DarkBlue" 
                        HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" 
                        VerticalPadding="0px" />
                </asp:TreeView>
            </td>
        </tr>
    </table>
&nbsp;
</asp:Content>

