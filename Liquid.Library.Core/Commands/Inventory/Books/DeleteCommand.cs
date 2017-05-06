using System;
using System.Threading.Tasks;

namespace Liquid.Library.Commands.Inventory.Books
{
    public class DeleteCommand : Command, ICommand
    {
        public Guid Id { get; set; }

        public async Task Execute()
        {
            await Delete($"/api/v2.0/book/{Id.ToString()}");
        }
    }
}
