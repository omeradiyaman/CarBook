using CarBook.Application.Features.Mediator.Queries.CommentQueries;
using CarBook.Application.Features.Mediator.Results.CommentResults;
using CarBook.Application.Interfaces.CommentInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers.Read
{
    public class GetCommentsCountByBlogIdQueryHandler : IRequestHandler<GetCommentsCountByBlogIdQuery, GetCommentsCountByBlogIdQueryResult>
    {
        private readonly ICommentRepository _repository;

        public GetCommentsCountByBlogIdQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCommentsCountByBlogIdQueryResult> Handle(GetCommentsCountByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCommentsCountByBlogId(request.Id);
            return new GetCommentsCountByBlogIdQueryResult
            {
                BlogId = request.Id,
                CommentCount = values.Result
            };
        }
    }
}
