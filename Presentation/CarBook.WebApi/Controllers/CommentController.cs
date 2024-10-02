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
        [HttpGet("GetCommentByBlogId")]
        public async Task<IActionResult> GetCommentByBlogId(int id)
        {
            var values = await _mediator.Send(new GetCommentsByBlogIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment Bilgisi Eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteComment(DeleteCommentCommand command)
        {
            await _mediator.Send(command);
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
