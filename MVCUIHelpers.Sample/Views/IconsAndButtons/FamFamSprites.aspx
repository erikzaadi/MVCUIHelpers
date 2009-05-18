<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Fam Fam Sprites
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Fam Fam Sprites</h2>
    <h3>
        Icon:</h3>
    <h4>
        <%= Html.FamFamSprites(FamFamSpritesEnum.thumb_up)%>
    </h4>
    <h4 class="clear">
        Code
    </h4>
    <h4>
        <div>
            <code>&lt;%= Html.FamFamSprites(FamFamSpritesEnum.thumb_up) %&gt;</code>
        </div>
    </h4>
    <h3>
        Link:</h3>
    <h4>
        <div>
            <%= Html.FamFamSpritesLink("All Icons", FamFamSpritesEnum.photos, Url.Action("FamFamSpritesAll"), MVCUIHelpers.Shared.Direction.Ltr, new { @class = "MergedAttributeForClass", rel="AnyOtherAttributesWillBeFine"}, null , null) %>
        </div>
    </h4>
    <h4 class="clear">
        Code</h4>
    <h4>
        <div>
            <code>&lt;%= Html.FamFamSpritesLink("All Icons", FamFamSpritesEnum.photos, Url.Action("FamFamSpritesAll"),
                MVCUIHelpers.Shared.Direction.Ltr, new { @class = "MergedAttributeForClass", rel="AnyOtherAttributesWillBeFine"},
                null , null) %&gt;</code>
        </div>
    </h4>
    <h3>
        Button:</h3>
    <h4>
        <%= Html.FamFamSpritesButton("SampleButton", FamFamSpritesEnum.find, MVCUIHelpers.Shared.ButtonType.Button) %></h4>
    <h4 class="clear">
        Code</h4>
    <h4>
        <div>
            <code>&lt;%= Html.FamFamSpritesButton("SampleButton", FamFamSpritesEnum.find, MVCUIHelpers.Shared.ButtonType.Button)
                %&gt;</code>
        </div>
    </h4>
</asp:Content>
