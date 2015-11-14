using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fakebook.Models
{
    public class Friend
    {
        [Required]
        public int FriendID { get; set; }
        //public int MemberID { get; set; }
        public DateTime DateFriended { get; set; }

        public virtual Member Member { get; set; }
    }
}