using System.ComponentModel;

namespace Liquid.Library.Domain.Inventory
{
    public class Music : Entity
    {
        [DisplayName("Album Name")]
        public virtual string AlbumName { get; set; }

        [DisplayName("Artist Name")]
        public virtual string ArtistName { get; set; }

        public virtual MusicFormat Format { get; set; }
    }

    public enum MusicFormat
    {
        CD,
        Digital,
        Record
    }
}
