<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    MVC UI Helpers Content
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        MVC UI Helpers Content</h2>
    <h3>
        This library includes blah blah * lorem upsum</h3>
    <h5>
        <%=Html.ActionLink("Icons And Buttons","Index","IconsAndButtons")  %></h5>
</asp:Content>
