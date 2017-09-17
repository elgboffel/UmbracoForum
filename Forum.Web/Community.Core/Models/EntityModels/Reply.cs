using System;

namespace Community.Core.EntityModels
{
    public class Reply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual DateTime? UpdateDate { get; set; }

        public int MemberId { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

    }
}
