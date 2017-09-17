using System;
using System.Collections.Generic;

namespace Community.Core.EntityModels
{
    public class Post 
    {
        public Post()
        {
            Replies = new HashSet<Reply>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual DateTime? UpdateDate { get; set; }

        public int MemberId { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Reply> Replies { get; set; }

    }
}
