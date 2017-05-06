using Liquid.Library.Domain.Inventory;
using System;
using System.Threading.Tasks;

namespace Liquid.Library.Commands.Inventory.Books
{
    public class PostCommand : Command, ICommand
    {
        public Book Book { get; set; }

        public Guid Id { get; set; }

        public async Task Execute()
        {
            var response = await Post<Guid>("/api/v2.0/book/", Book);
            Id = response;
        }
    }
}
