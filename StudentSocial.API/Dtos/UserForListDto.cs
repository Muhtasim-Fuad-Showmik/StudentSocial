using System;

namespace StudentSocial.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string StudentId { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
    }
}