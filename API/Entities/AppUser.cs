using System;
using System.Collections.Generic;
using API.Extentions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get    ; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string KnownAs { get; set; }
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string  Interests { get; set; }
        public string City { get; set; }
        public string  Country { get; set; }
        public ICollection<Photo> Photos { get; set; }

        // public int GetAge(){
        //     return DateOfBirth.CalculateAge();
        // }
    }
}