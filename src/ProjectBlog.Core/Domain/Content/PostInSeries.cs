using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectBlog.Core.Domain.Content
{
    [Table("PostInSeries")]
    [PrimaryKey(nameof(PostId), nameof(SeriesId))]
    public class PostInSeries
    {
        public Guid PostId { get; set; }
        public Guid SeriesId { get; set; }
        public int DisplayOrder { get; set; }
    }
}
