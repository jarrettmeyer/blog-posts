using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MvcSecurity.Lib.ActionFilters
{
    [TestClass]
    public class CustomAuthorizeAttributeTests
    {
        [TestMethod]
        public void IsUserInRoleShouldReturnFalse()
        {
            var userRoles = SiteRoles.ProjectLead;
            var auth = new CustomAuthorizeAttribute(SiteRoles.Manager);            
            var result = auth.IsUserInRole(userRoles);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsUserInRoleShouldReturnTrue()
        {
            var userRoles = SiteRoles.ProjectLead;
            var auth = new CustomAuthorizeAttribute(SiteRoles.Manager | SiteRoles.ProjectLead);            
            var result = auth.IsUserInRole(userRoles);
            Assert.IsTrue(result);
        }
    }
}
