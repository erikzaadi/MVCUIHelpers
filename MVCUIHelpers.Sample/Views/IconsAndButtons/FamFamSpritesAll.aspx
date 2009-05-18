<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Fam Fam Sprites All Icons
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Fam Fam Sprites All Icons</h2>
    <% foreach (var icon in Enum.GetValues(typeof(FamFamSpritesEnum)))
       { %>
    <div class="clear">
        <h3>
            <%= Html.FamFamSprites((FamFamSpritesEnum)icon) %>
            &nbsp;
            <%=icon %>
        </h3>
    </div>
    <%} %>
</asp:Content>
