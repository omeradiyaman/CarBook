using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers.Read
{
    public class GetAuthorByBlogIdQueryHandler : IRequestHandler<GetAuthorByBlogIdQuery, List<GetAuthorByBlogIdQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetAuthorByBlogIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAuthorByBlogIdQueryResult>> Handle(GetAuthorByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAuthorByBlogId(request.Id);
            return values.Select(x=> new GetAuthorByBlogIdQueryResult {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
                BlogId = x.BlogId
            }).ToList();
        }
    }
}
