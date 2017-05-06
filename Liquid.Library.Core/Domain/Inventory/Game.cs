using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Liquid.Library.Domain.Inventory
{
    [DataContract]
    public class Game : Entity
    {
        [Required]
        [DataMember]
        public virtual string Name { get; set; }
    }
}
