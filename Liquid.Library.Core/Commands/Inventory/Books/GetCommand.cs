using Liquid.Library.Domain.Inventory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Liquid.Library.Commands.Inventory.Books
{
    public class GetCommand : Command, ICommand
    {
        public ICollection<Book> Books { get; set; }

        public async Task Execute()
        {
            var response = await Get<List<Book>>("/api/v2.0/book/");
            Books = response;
        }
    }
}
