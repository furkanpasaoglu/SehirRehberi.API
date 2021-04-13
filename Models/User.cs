using System.Collections.Generic;

namespace SehirRehberi.API.Models
{
    public class User
    {
        public User()
        {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<City> Cities { get; set; }
    }
}