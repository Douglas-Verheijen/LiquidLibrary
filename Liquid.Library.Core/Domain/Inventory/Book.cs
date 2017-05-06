using System;

namespace Liquid.Library.Domain.Inventory
{
    public class Book : Entity
    {        
        public virtual string Name { get; set; }
        
        public virtual string Author { get; set; }
        
        public virtual string ISBN { get; set; }
    }
}
