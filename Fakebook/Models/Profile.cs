using System.Collections.Generic;

namespace Fakebook.Models
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public string Bio { get; set; }

        public virtual Demographic Demographic { get; set; }
        public virtual List<Interest> Interest { get; set; }
        public virtual Photo Photo { get; set; }
    }
}