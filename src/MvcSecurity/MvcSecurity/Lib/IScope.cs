namespace MvcSecurity.Lib
{
    public interface IScope
    {
        bool IsAuthenticated { get; }
        SiteRoles Roles { get; }
        string Username { get; }

        void ClearSession();
        void Login(string username, SiteRoles roles);
    }
}
