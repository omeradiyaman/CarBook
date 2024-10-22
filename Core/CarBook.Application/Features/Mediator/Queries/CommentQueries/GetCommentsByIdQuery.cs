using CarBook.Application.Features.Mediator.Results.CommentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentsByIdQuery : IRequest<GetCommentsByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCommentsByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
