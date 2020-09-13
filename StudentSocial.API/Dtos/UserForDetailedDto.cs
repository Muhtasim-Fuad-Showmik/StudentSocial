using System;
using System.Collections.Generic;
using StudentSocial.API.Models;

namespace StudentSocial.API.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string StudentId { get; set; }
        public string Major { get; set; }
        public string CoursesCompleted { get; set; }
        public string CoursesEnrolled { get; set; }
        public string University { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
        public double Cgpa { get; set; }
        public string PhotoUrl { get; set; }
    }
}