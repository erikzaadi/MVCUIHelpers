<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    jQuery UI
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        jQuery UI</h2>
    <hr />
    <h3>
        Icon:</h3>
    <h4>
        <%= Html.jQueryUIIcon(jQueryUIIconsEnum.alert) %>
    </h4>
    <h4 class="clear">
        Code
    </h4>
    <div>
        <code>&lt;%= Html.jQueryUIIcon(jQueryUIIconsEnum.alert) %&gt;</code>
    </div>
    <hr />
    <h3>
        Fluid Style Icon:</h3>
    <h4>
        <% Html.jQueryFluidIcon()
            .jQueryUIIcon(jQueryUIIconsEnum.alert)
            .HtmlAttributes(new { @class = "ui-state-highlight" })
            .Render();%>
    </h4>
    <h4 class="clear">
        Code
    </h4>
    <div>
        <code>&lt;% Html.jQueryFluidIcon()<br />
            .jQueryUIIcon(jQueryUIIconsEnum.alert)<br />
            .HtmlAttributes(new { @class = "ui-state-highlight" })<br />
            .Render();%&gt;</code>
    </div>
    <hr />
    <h3>
        Link:</h3>
    <div>
        <%= Html.jQueryUIIconLink("All Icons", jQueryUIIconsEnum.script, Url.Action("jQueryUIAll"), MVCUIHelpers.Shared.Direction.Ltr, new { @class = "MergedAttributeForClass", rel="AnyOtherAttributesWillBeFine"}, null , null)%>
    </div>
    <h4 class="clear">
        Code</h4>
    <div>
        <code>&lt;%= Html.jQueryUIIconLink("All Icons", jQueryUIIconsEnum.script, Url.Action("jQueryUIAll"),
            MVCUIHelpers.Shared.Direction.Ltr, new { @class = "MergedAttributeForClass", rel="AnyOtherAttributesWillBeFine"},
            null , null)%&gt;</code>
    </div>
    <hr />
    <h3>
        Fluid Style Link:</h3>
    <div>
        <% Html.jQueryFluidLink()
               .Text("All Icons")
               .jQueryUIIcon(jQueryUIIconsEnum.link)
               .URL(Url.Action("jQueryUIAll"))
               .InnerSpanHtmlAttributes(new { @class = "ui-widget-header" })
               .Render();%>
    </div>
    <h4 class="clear">
        Code</h4>
    <div>
        <code>&lt;%= Html.jQueryUIIconLink("All Icons", jQueryUIIconsEnum.script, Url.Action("jQueryUIAll"),
            MVCUIHelpers.Shared.Direction.Ltr, new { @class = "MergedAttributeForClass", rel="AnyOtherAttributesWillBeFine"},
            null , null)%&gt;</code>
    </div>
    <hr />
    <h3>
        Button:</h3>
    <h4>
        <%= Html.jQueryUIIconButton("SampleButton", jQueryUIIconsEnum.search, MVCUIHelpers.Shared.ButtonType.Button) %></h4>
    <h4 class="clear">
        Code</h4>
    <div>
        <code>&lt;%= Html.jQueryUIIconButton("SampleButton", jQueryUIIconsEnum.search, MVCUIHelpers.Shared.ButtonType.Button)
            %&gt;</code>
    </div>
    <hr />
    <h3>
        Fluid Style Button:</h3>
    <h4>
        <% Html.jQueryFluidButton()
            .Text("SampleButton")
            .jQueryUIIcon(jQueryUIIconsEnum.search)
            .HtmlAttributes(new { @class = "ui-corner-all ui-state-default" })
            .Render(); %></h4>
    <h4 class="clear">
        Code</h4>
    <div>
        <code>&lt;% Html.jQueryFluidButton()<br />
            .Text("SampleButton")<br />
            .jQueryUIIcon(jQueryUIIconsEnum.search)<br />
            .HtmlAttributes(new { @class = "ui-corner-all ui-state-default" })<br />
            .Render(); %&gt;</code>
    </div>
    <hr />
    <h3>
        Generic Element:</h3>
    <h4>
        <%= Html.jQueryUIIconForElement("SampleInnerText", jQueryUIIconsEnum.calculator, "div") %></h4>
    <h4 class="clear">
        Code</h4>
    <div>
        <code>&lt;%= Html.jQueryUIIconForElement("SampleInnerText", jQueryUIIconsEnum.calculator,
            "div") %&gt;</code>
    </div>
    <hr />
    <h3>
        Generic Fluid Element:</h3>
    <h4>
        <% Html.jQueryFluidGeneric()
               .Text("SampleInnerText")
               .jQueryUIIcon(jQueryUIIconsEnum.arrow_2_e_w)
               .Element("div")
               .InnerSpanHtmlAttributes(new { @class = "ui-state-disabled" })
               .InnerIconHtmlAttributes(new { @class = "ui-state-hover" })
               .HtmlAttributes(new { @class = "ui-widget" })
               .Render(); %></h4>
    <h4 class="clear">
        Code</h4>
    <div>
        <code>&lt;% Html.jQueryFluidGeneric()<br />
            .Text("SampleInnerText")<br />
            .jQueryUIIcon(jQueryUIIconsEnum.arrow_2_e_w)<br />
            .Element("div")<br />
            .InnerSpanHtmlAttributes(new { @class = "ui-state-disabled" })<br />
            .InnerIconHtmlAttributes(new { @class = "ui-state-hover" })<br />
            .HtmlAttributes(new { @class = "ui-widget" })<br />
            .Render(); %&gt;</code>
    </div>
</asp:Content>
