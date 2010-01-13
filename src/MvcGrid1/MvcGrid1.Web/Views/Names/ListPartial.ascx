<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Name>" %>

<tr class="name" id="name-<%= Model.Id %>">
    <td><%= Html.Encode(Model.Last)%></td>
    <td><%= Html.Encode(Model.First)%></td>
    <td><a class="edit-link" href="<%= Url.Action("Edit", new { id = Model.Id }) %>">Edit</a></td>
</tr>

