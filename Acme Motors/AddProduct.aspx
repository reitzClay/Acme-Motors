<%@ Page Title="Add Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Acme_Motors.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowModelStateErrors="true" />
    <asp:FormView runat="server" ID="addVehicleForm"
        ItemType="Acme_Motors.Models.Product"
        InsertMethod="addVehicleForm_InsertItem" DefaultMode="Insert"
                       
        RenderOuterTable="true" OnItemInserted="addVehicleForm_ItemInserted">
        <InsertItemTemplate>
            <fieldset>
                <ol>
                    <asp:DynamicEntity ID="DynamicEntity1" runat="server" Mode="Insert" />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Insert" CommandName="Insert" />
                </ol>                                
            </fieldset>
        </InsertItemTemplate>
    </asp:FormView>
    <br /><br />
</asp:Content>
