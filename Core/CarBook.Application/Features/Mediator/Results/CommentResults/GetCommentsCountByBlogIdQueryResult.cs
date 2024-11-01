using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.CommentResults
{
    public class GetCommentsCountByBlogIdQueryResult
    {
        public int BlogId { get; set; }
        public int CommentCount { get; set; }

    }
}
