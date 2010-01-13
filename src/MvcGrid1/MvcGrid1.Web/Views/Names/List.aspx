<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<Name>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Names
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%= Url.IncludeJs("application.names.js") %>

    <h2>Names</h2>
    
    <form action="<%= Url.Action("Save") %>" method="post">
    <table id="names-table" style="width:99%;">
        <thead>
            <tr>
                <td style="width:40%;font-weight:bold;background-color:#ddd;">Last</td>
                <td style="width:40%;font-weight:bold;background-color:#ddd;">First</td>
                <td style="width:19%;font-weight:bold;background-color:#ddd;">&nbsp;</td>
            </tr>
        </thead>
        <tbody>
            <% foreach (var name in Model) { %> 
                <% Html.RenderPartial("ListPartial", name); %>
            <% } %>
        </tbody>
        <tfoot>
            <tr id="add-name">
                <td colspan="3" style="text-align:center">
                    <a href="<%= Url.Action("New") %>" id="addNameLink">Add Name</a>
                </td>
            </tr>
        </tfoot>
    </table>
    </form>

</asp:Content>
