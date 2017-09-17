using Community.Core.EntityModels;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web.Models;

namespace Community.Core.ViewModels
{
    public class CommunityViewModel : RenderModel
    {
        public CommunityViewModel(IPublishedContent content) : base(content)
        {

        }

        public Post Post { get; set; }

        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
