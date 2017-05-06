namespace Liquid.Library.Domain
{
    public class User : Entity
    {
        public virtual string Email { get; set; }

        public virtual string Firstname { get; set; }

        public virtual string Lastname { get; set; }

        public virtual string Username { get; set; }

        //public virtual bool IsActivated { get; set; }
    }
}
