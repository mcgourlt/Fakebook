using System;

namespace Fakebook.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool ProfilePicture { get; set; }
    }
}