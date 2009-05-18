<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<div>
    <%= Html.ActionLink(ViewContext.RouteData.Values["Controller"].ToString(),"Index") %>
    <% if (ViewContext.RouteData.Values["Action"].ToString() != "Index")
       { %>
    &nbsp;&gt;&nbsp;
    <%= Html.ActionLink(ViewContext.RouteData.Values["Action"].ToString(),ViewContext.RouteData.Values["Action"].ToString())%>
    <%} %>
</div>
