<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="Acme_Motors.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

