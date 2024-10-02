﻿using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers.Read
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorsQuery, List<GetAllBlogsWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllBlogsWithAuthorsQueryResult>> Handle(GetAllBlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllBlogsWithAuthors();
            return values.Select(x => new GetAllBlogsWithAuthorsQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                BlogId = x.BlogId,
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                Description = x.Description,
                AuthorDescription  = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl,
                
            }).ToList();
        }
    }
}
