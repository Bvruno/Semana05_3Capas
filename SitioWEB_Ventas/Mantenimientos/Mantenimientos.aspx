<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeFile="Mantenimientos.aspx.cs" Inherits="Mantenimientos_Mantenimientos" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>MANTENIMIENTOS DEL SISTEMA</div>
    <table class="style1">
        <tr>
            <td width ="180px">
                <asp:Image ID="Image1" runat="server" Height="467px" 
                    ImageUrl="~/Images/Mantenimientos.jpg" Width="329px" />
            </td>
            <td>
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="Inbox" Height="133px" 
                    Width="283px" Font-Size="X-Large">
                    <HoverNodeStyle Font-Underline="True" />
                    <Nodes>
                        <asp:TreeNode NavigateUrl="~/Mantenimientos/VendedorMan01.aspx" Text="Vendedor" 
                            Value="Vendedor"></asp:TreeNode>
                        <asp:TreeNode Text="Proveedor" Value="Proveedor"></asp:TreeNode>
                        <asp:TreeNode Text="Cliente" Value="Cliente"></asp:TreeNode>
                        <asp:TreeNode Text="Producto" Value="Producto"></asp:TreeNode>
                        <asp:TreeNode NavigateUrl="~/MenuPrincipal.aspx" Text="Retornar al menu principal" Value="Retornar al menu principal"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" 
                        HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" HorizontalPadding="0px" 
                        VerticalPadding="0px" />
                </asp:TreeView>
            </td>
        </tr>
    </table>
</asp:Content>

