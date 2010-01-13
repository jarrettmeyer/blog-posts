<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<Name>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>
    
    <form action="<%= Url.Action("Update") %>" method="put">
    <input type="hidden" name="Id" id="Id" value="<%= Model.Id %>" />
    <p>
        <label for="First">First</label><br />
        <input type="text" name="First" id="First" value="<%= Model.First %>" />
    </p>
    
    <p>
        <label for="Last">Last</label><br />
        <input type="text" name="Last" id="Last" value="<%= Model.Last %>" />
    </p>
    
    <p>
        <input type="submit" value="Update" />
    </p>
    
    </form>

</asp:Content>
