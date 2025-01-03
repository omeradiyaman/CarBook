﻿using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Bilgisi Eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _mediator.Send(new DeleteBlogCommand(id));
            return Ok("Blog Bilgisi silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Bilgisi Güncellendi.");
        }
        [HttpGet("GetLast3BlogsWithAuthorsList")]
        public async Task<IActionResult> GetLast3BlogsWithAuthorsList()
        {
            var values = await _mediator.Send(new GetLast3BlogsWithAuthorsQuery());
            return Ok(values);
        }
        [HttpGet("GetAllBlogsWithAuthorsList")]
        public async Task<IActionResult> GetAllBlogsWithAuthorsList()
        {
            var values = await _mediator.Send(new GetAllBlogsWithAuthorsQuery());
            return Ok(values);
        }
        [HttpGet("GetAuthorByBlogId")]
        public async Task<IActionResult> GetAuthorByBlogId(int id)
        {
            var values = await _mediator.Send(new GetAuthorByBlogIdQuery(id));
            return Ok(values);
        }
    }
}
