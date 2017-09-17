using System.Collections.Generic;

namespace Forum.Web.Models.UmbracoIdentity
{
    public class RoleManagementModel
    {
        public IEnumerable<string> AvailableRoles { get; set; }
        public IEnumerable<string> AssignedRoles { get; set; }
    }
}
