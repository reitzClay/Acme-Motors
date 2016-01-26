<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="Acme_Motors.ProductDetails__" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="productDetail" runat="server" ItemType="Acme_Motors.Models.Product" SelectMethod="GetProduct" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.ProductName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align:match-parent;">
                        <!--<b>Description:</b><br /><%#: Item.Description %>-->
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Product Number:</b>&nbsp;<%#: Item.ProductID %></span>
                        <br />
                    </td>                    
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
