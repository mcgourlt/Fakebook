using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fakebook.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Username { get; set; }
        public string MemberName { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime LastLogin { get; set; }

        public virtual Profile Profile { get; set; }
        //public virtual Friend Friend { get; set; }
        //public virtual Message Message { get; set; }
    }
}