using System;

namespace MvcSecurity.Lib
{
    [Serializable, Flags]
    public enum SiteRoles
    {
        None = 0,
        Developer = 1,
        Manager = 2,
        ProjectLead = 4
    }
}
