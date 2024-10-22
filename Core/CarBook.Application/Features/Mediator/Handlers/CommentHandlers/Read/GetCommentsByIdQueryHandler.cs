using CarBook.Application.Features.Mediator.Queries.CommentQueries;
using CarBook.Application.Features.Mediator.Results.CommentResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers.Read
{
    public class GetCommentsByIdQueryHandler : IRequestHandler<GetCommentsByIdQuery, GetCommentsByIdQueryResult>
    {
        private readonly IRepository<Comment> _repository;

        public GetCommentsByIdQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<GetCommentsByIdQueryResult> Handle(GetCommentsByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetCommentsByIdQueryResult
            {
                BlogId = value.BlogId,
                CommentId = value.CommentId,
                CreatedDate = value.CreatedDate,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Name = value.Name,
            };
        }
    }
}
