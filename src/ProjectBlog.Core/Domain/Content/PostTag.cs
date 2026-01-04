using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectBlog.Core.Domain.Content
{
    [Table("PostTags")]
    [PrimaryKey(nameof(PostId), nameof(TagId))]
    public class PostTag
    {
        public Guid PostId { set; get; }
        public Guid TagId { set; get; }
    }
}
