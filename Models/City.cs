using System.Collections.Generic;

namespace SehirRehberi.API.Models
{
    public class City
    {
        public City()
        {
            Photos = new List<Photo>();
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Photo> Photos { get; set; }
        public User User { get; set; }
    }
}