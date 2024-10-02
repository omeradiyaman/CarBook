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
    public class GetCommentsByBlogIdQueryHandler : IRequestHandler<GetCommentsByBlogIdQuery, List<GetCommentsByBlogIdQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetCommentsByBlogIdQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentsByBlogIdQueryResult>> Handle(GetCommentsByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetCommentsByBlogId(request.Id);
            return values.Select(x => new GetCommentsByBlogIdQueryResult
            {
                BlogId = x.BlogId,
                CommentId = x.CommentId,
                Description = x.Description,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                CreatedDate = x.CreatedDate,
            }).ToList();
        }
    }
}
