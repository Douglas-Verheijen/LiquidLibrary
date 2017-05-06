using Liquid.Library.Domain.Inventory;
using System;
using System.Threading.Tasks;

namespace Liquid.Library.Commands.Inventory.Books
{
    public class PatchCommand : Command, ICommand
    {
        public Book Book { get; set; }

        public Guid Id { get; set; }

        public async Task Execute()
        {
            await Patch("/api/v2.0/book/", Book);
        }
    }
}
