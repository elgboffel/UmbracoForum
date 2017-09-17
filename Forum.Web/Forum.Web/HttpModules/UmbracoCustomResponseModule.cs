using System;
using System.Web;
using Umbraco.Web;

namespace Niras.Web.HttpModules
{
    public class UmbracoCustomResponseModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication app)
        {
            app.EndRequest += new EventHandler(App_EndRequest);
        }

        private void App_EndRequest(object sender, EventArgs e)
        {
            var app = (HttpApplication)sender;
            try
            {
                if (UmbracoContext.Current != null)
                {
                    var contentRequest = UmbracoContext.Current.PublishedContentRequest;
                    if (contentRequest != null)
                    {
                        var content = contentRequest.PublishedContent;
                        var Response = app.Context.Response;

                        if (content.HasValue("umbracoPermanentRedirect"))
                        {
                            string url = content.GetPropertyValue<string>("umbracoPermanentRedirect");
                            Response.RedirectPermanent(url, true);
                        }

                        if (content.HasValue("umbracoExternalUrl"))
                        {
                            string url = content.GetPropertyValue<string>("umbracoExternalUrl");
                            //Response.Write(string.Format("<script>window.open('{0}','_blank');</script>", url));
                            Response.Redirect(url, true);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw new NotImplementedException("Permanent redirect: ", exception);
            }
        }
    }
}
