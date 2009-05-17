<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Icons And Buttons
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Icons And Buttons</h2>
    <h3>
        This MVC UI Helper is here to save some time for creating nice looking icons, links
        and buttons for your views</h3>
    <h4>
        The helper includes two (for now) implemented helpers:</h4>
    <h5>
        <%= Html.ActionLink("jQuery UI","jQueryUI") %></h5>
    <h6>
        Uses the jQuery UI theme css framework icons</h6>
    <h5>
        <%= Html.ActionLink("Fam Fam Sprites", "FamFamSprites")%></h5>
    <h6>
        Uses FamFamFam icons (originally from a plugin to the BluePrintCSS framework)</h6>
</asp:Content>
