<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Name>" %>

<tr class="name" id="name-<%= Model.Id %>">
    <input type="hidden" name="Id" id="Id" value="<%= Model.Id %>" />
    <td>
        <input type="text" name="Last" id="Last" value="<%= Model.Last %>" />
    </td>
    <td>
        <input type="text" name="First" id="First" value="<%= Model.First %>" />
    </td>
    <td>
        <input type="submit" value="Update" id="updateRowButton" />
        <input type="reset" value="Cancel" id="cancelRowButton" />
    </td>
</tr>

