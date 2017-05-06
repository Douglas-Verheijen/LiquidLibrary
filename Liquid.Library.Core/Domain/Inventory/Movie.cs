using System.Runtime.Serialization;

namespace Liquid.Library.Domain.Inventory
{
    [DataContract]
    public class Movie : Entity
    {
        [DataMember]
        public virtual string Name { get; set; }

        [DataMember]
        public virtual MovieFormat Format { get; set; }
    }

    public enum MovieFormat
    {
        DVD,
        BluRay,
        VHS
    }
}
