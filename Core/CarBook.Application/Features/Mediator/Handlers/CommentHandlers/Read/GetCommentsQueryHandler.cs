using CarBook.Application.Features.Mediator.Queries.CommentQueries;
using CarBook.Application.Features.Mediator.Results.CommentResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CommentInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers.Read
{
    public class GetCommentsQueryHandler : IRequestHandler<GetCommentsQuery, List<GetCommentsQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetCommentsQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentsQueryResult>> Handle(GetCommentsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllCommentsWithBlogTitleAsync();
            return values.Select(x => new GetCommentsQueryResult
            {
                BlogId = x.BlogId,
                CommentId = x.CommentId,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Title = x.Blog.Title
            }).ToList();
        }
    }
}
