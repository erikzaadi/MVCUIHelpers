<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    jQuery UI
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        jQuery UI</h2>
    <h3>
        Icon:</h3>
    <h4>
        <%= Html.jQueryUIIcon(jQueryUIIconsEnum.alert) %>
    </h4>
    <h4 class="clear">
        Code
    </h4>
    <h4>
        <div>
            <code>&lt;%= Html.jQueryUIIcon(jQueryUIIconsEnum.alert) %&gt;</code>
        </div>
    </h4>
    <h3>
        Link:</h3>
    <h4>
        <div>
            <%= Html.jQueryUIIconLink("All Icons", jQueryUIIconsEnum.script, Url.Action("jQueryUIAll"), MVCUIHelpers.Shared.Direction.Ltr, new { @class = "MergedAttributeForClass", rel="AnyOtherAttributesWillBeFine"}, null , null)%>
        </div>
    </h4>
    <h4 class="clear">
        Code</h4>
    <h4>
        <div>
            <div>
                <code>&lt;%= Html.jQueryUIIconLink("All Icons", jQueryUIIconsEnum.script, Url.Action("jQueryUIAll"),
                    MVCUIHelpers.Shared.Direction.Ltr, new { @class = "MergedAttributeForClass", rel="AnyOtherAttributesWillBeFine"},
                    null , null)%&gt;</code>
            </div>
        </div>
    </h4>
    <h3>
        Button:</h3>
    <h4>
        <%= Html.jQueryUIIconButton("SampleButton", jQueryUIIconsEnum.search, MVCUIHelpers.Shared.ButtonType.Button) %></h4>
    <h4 class="clear">
        Code</h4>
    <h4>
        <div>
            <div>
                <code>&lt;%= Html.jQueryUIIconButton("SampleButton", jQueryUIIconsEnum.search, MVCUIHelpers.Shared.ButtonType.Button)
                    %&gt;</code>
            </div>
        </div>
    </h4>
</asp:Content>
