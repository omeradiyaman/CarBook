using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.Features.Mediator.Queries.CommentQueries;
using CarBook.Application.Features.Mediator.Results.CommentResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CommentList()
        {
            var values = await _mediator.Send(new GetCommentsQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> CommentList(int id)
        {
            var value = await _mediator.Send(new GetCommentsByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("GetCommentsByBlogId")]
        public async Task<IActionResult> GetCommentsByBlogId(int id)
        {
            var values = await _mediator.Send(new GetCommentsByBlogIdQuery(id));
            return Ok(values);
        }

        [HttpGet("GetCommentsCountByBlogId")]
        public async Task<IActionResult> GetCommentsCountByBlogId(int id)
        {
            var values = await _mediator.Send(new GetCommentsCountByBlogIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment Bilgisi Eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _mediator.Send(new DeleteCommentCommand(id));
            return Ok("Comment Bilgisi silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment Bilgisi Güncellendi.");
        }
    }
}
