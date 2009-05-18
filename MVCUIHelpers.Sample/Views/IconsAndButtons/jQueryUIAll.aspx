<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    jQuery UI All Icons
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        jQuery UI All Icons</h2>
    <% foreach (var icon in Enum.GetValues(typeof(jQueryUIIconsEnum)))
       { %>
    <div class="clear">
        <h3>
            <%= icon %></h3>
        <div class="clear">
            <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
            No Class</div>
        <div class="clear">
            <span class="ui-state-error" title="ui-state-error">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-error </span>
        </div>
        <div class="clear">
            <span class="ui-state-highlight" title="ui-state-highlight">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-highlight</span>
        </div>
        <div class="clear">
            <span class="ui-state-active" title="ui-state-active">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-active</span></div>
        <div class="clear">
            <span class="ui-state-disabled" title="ui-state-disabled">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-disabled</span></div>
        <div class="clear">
            <span class="ui-state-focus" title="ui-state-focus">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-focus</span></div>
        <div class="clear">
            <span class="ui-state-default" title="ui-state-default">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-default</span></div>
        <div class="clear">
            <span class="ui-state-hover" title="ui-state-hover">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-hover</span></div>
        <div class="clear">
            <span class="ui-state-processing" title="ui-state-processing">
                <%= Html.jQueryUIIcon((jQueryUIIconsEnum)icon) %>
                ui-state-processing</span></div>
    </div>
    <%} %>
</asp:Content>
