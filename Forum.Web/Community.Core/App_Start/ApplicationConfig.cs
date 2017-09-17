using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.Routing;

namespace Community.Core
{
    public class ApplicationConfig : ApplicationEventHandler
    {

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            RouteTable.Routes.LowercaseUrls = true;

            RouteTable.Routes.MapUmbracoRoute(
                "CommunityRoute",
                "Community/{name}",
                new
                {
                    controller = "Community",
                    action = "Post",
                    name = UrlParameter.Optional
                },
                new CommunityRouteHandler());
        }
    }

    public class CommunityRouteHandler : UmbracoVirtualNodeRouteHandler
    {
        protected override IPublishedContent FindContent(RequestContext requestContext, UmbracoContext umbracoContext)
        {
            UmbracoHelper helper = new UmbracoHelper(umbracoContext);
            string documentAlias = "community";

            //if (helper.UmbracoContext.PublishedContentRequest == null)
            //    return null;

            //var currentPage = helper.AssignedContentItem;

            //if (currentPage.DocumentTypeAlias.InvariantEquals(documentAlias))
            //    return currentPage;
            //else
            //    return null;

            return helper.TypedContentAtRoot()
                .First()
                .Descendants()
                .First(x => x.DocumentTypeAlias.InvariantEquals(documentAlias));
        }
    }
}

