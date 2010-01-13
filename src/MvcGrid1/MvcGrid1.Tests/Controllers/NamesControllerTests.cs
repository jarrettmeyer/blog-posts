using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvcGrid1.Core.Lib.Data;
using MvcGrid1.Core.Models;

namespace MvcGrid1.Core.Controllers
{
    [TestClass]
    public class NamesControllerTests
    {
        public HttpContextBase AjaxContext
        {
            get
            {
                var context = new Mock<HttpContextBase>();
                context.SetupGet(x => x.Request).Returns(AjaxRequest);
                return context.Object;
            }
        }

        public HttpRequestBase AjaxRequest
        {
            get
            {
                var request = new Mock<HttpRequestBase>();
                request.SetupGet(x => x.Headers).Returns(new System.Net.WebHeaderCollection { { "X-Requested-With", "XMLHttpRequest" } });
                return request.Object;
            }
        }

        public IRepository Repository
        {
            get
            {
                var repository = new Mock<IRepository>();
                repository.Setup(r => r.FindSingle<Name>(n => It.IsAny<bool>())).Returns(new Name());
                return repository.Object;
            }
        }

        public HttpContextBase StandardContext
        {
            get
            {
                var context = new Mock<HttpContextBase>();
                context.SetupGet(x => x.Request).Returns(StandardRequest);
                return context.Object;
            }
        }

        public HttpRequestBase StandardRequest
        {
            get
            {
                var request = new Mock<HttpRequestBase>();
                return request.Object;
            }
        }

        [TestMethod]
        public void DetailsAjaxRequestShouldReturnPartial()
        {                        
            var controller = new NamesController(Repository);
            controller.ControllerContext = new ControllerContext(AjaxContext, new RouteData(), controller );
            var result = controller.Details(1);
            Assert.IsInstanceOfType(result, typeof(PartialViewResult));
        }

        [TestMethod]
        public void DetailsShouldReturnView()
        {
            var controller = new NamesController(Repository);
            controller.ControllerContext = new ControllerContext(StandardContext, new RouteData(), controller);
            var result = controller.Details(1);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}