using Liquid.Library.Commands.Inventory.Books;
using Liquid.Library.Domain.Inventory;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Liquid.Library.UI.Controllers.Api
{
    public class BookController : ApiController
    {
        [HttpGet]
        [Route("api/books")]
        public async Task<IHttpActionResult> Get()
        {
            var command = new GetCommand();
            await command.Execute();

            return Ok(command.Books);
        }

        [HttpGet]
        [Route("api/books/{id}")]
        public async Task<IHttpActionResult> Get(Guid id)
        {
            if (id == null)
                return NotFound();
            
            var command = new LoadCommand() { Id = id };
            await command.Execute();

            return Ok(command.Book);
        }
        
        [HttpPost]
        [Route("api/books")]
        public async Task<IHttpActionResult> Post([FromBody]Book book)
        {
            if (book == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var command = new PostCommand() { Book = book };
            await command.Execute();

            return Ok(command.Id);
        }

        [HttpPatch]
        [Route("api/books")]
        public async Task<IHttpActionResult> Patch([FromBody]Book book)
        {
            if (book == null)
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var command = new PatchCommand() { Book = book };
            await command.Execute();

            return Ok();
        }

        [HttpDelete]
        [Route("api/books/{id}")]
        public async Task<IHttpActionResult> Delete(Guid id)
        {
            if (id == null)
                return NotFound();

            var command = new DeleteCommand() { Id = id };
            await command.Execute();

            return Ok();
        }
    }
}