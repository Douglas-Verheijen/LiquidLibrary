using Liquid.Library.Domain.Inventory;
using System;
using System.Threading.Tasks;

namespace Liquid.Library.Commands.Inventory.Books
{
    public class LoadCommand : Command, ICommand
    {
        public Guid Id { get; set; }

        public Book Book { get; set; }

        public async Task Execute()
        {
            var response = await Get<Book>($"/api/v2.0/book/{Id.ToString()}");
            Book = response;
        }
    }
}
