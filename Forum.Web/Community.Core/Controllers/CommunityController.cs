using Community.Core.Repository;
using Community.Core.ViewModels;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Community.Core.Controllers
{

    public class CommunityController : RenderMvcController
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();

        public override ActionResult Index(RenderModel model)
        {
            var communityModel = new CommunityViewModel(model.Content)
            {
                Posts = _unitOfWork.PostRepository.Find()
            };

            return View(communityModel);
        }

        public ActionResult Create(RenderModel model)
        {

            return View("Forms/Create");
        }

        [HttpGet()]
        public ActionResult Post(RenderModel model, string name)
        {
            var url = Url.Action("Post");
            var communityModel = new CommunityViewModel(model.Content)
            {
                Post = _unitOfWork.PostRepository.Find(x => x.Title == name).First()
            };

            return View(communityModel);
        }

        protected override void Dispose(bool disposing)
        {
            _unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}