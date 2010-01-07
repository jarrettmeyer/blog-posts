using System;
using System.Web;

namespace MvcSecurity.Lib
{
    public class HttpScope : IScope
    {
        private readonly HttpSessionStateBase _session;

        public HttpScope(HttpSessionStateBase session)
        {
            if (session == null) throw new ArgumentNullException("session");
            _session = session;
            InitializeSession();
        }

        public bool IsAuthenticated
        {
            get { return string.IsNullOrEmpty(Username) == false; }
        }

        public SiteRoles Roles
        {
            get { return (SiteRoles)_session[SessionKeys.Roles]; }
        }

        public string Username
        {
            get { return (string)_session[SessionKeys.Username]; }
        }

        public void ClearSession()
        {
            InitializeSession();
        }

        private void InitializeSession()
        {            
            _session[SessionKeys.Username] = string.Empty;
        }

        public void Login(string username, SiteRoles roles)
        {
            if (string.IsNullOrEmpty(username)) throw new ArgumentException("username is null or empty!", "username");
            _session[SessionKeys.Roles] = roles;
            _session[SessionKeys.Username] = username;
        }
    }
}
