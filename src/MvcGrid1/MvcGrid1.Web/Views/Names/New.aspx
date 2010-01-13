<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MvcGrid1.Core.Models.Name>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	New
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>New Name</h2>
    
    <form action="<%= Url.Action("Create") %>" method="post">
    <p>
        <label for="First">First</label><br />
        <input type="text" name="First" id="First" value="<%= Model.First %>" />
    </p>
    <p>
        <label for="Last">Last</label><br />
        <input type="text" name="Last" id="Last" value="<%= Model.Last %>" />
    </p>
    <p>
        <input type="submit" value="Create" />        
    </p>
    <p>
        <%= Html.ActionLink("Return to List", "Index") %>
    </p>
    </form>

</asp:Content>
