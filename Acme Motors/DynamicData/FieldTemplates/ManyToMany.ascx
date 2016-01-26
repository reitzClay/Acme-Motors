<%@ Control Language="C#" CodeBehind="ManyToMany.ascx.cs" Inherits="Acme_Motors.ManyToManyField" %>

<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
      <asp:DynamicHyperLink runat="server"></asp:DynamicHyperLink>
    </ItemTemplate>
</asp:Repeater>

