using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSKManager.Model
{
    public class Student : IEntity<Guid>
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string LastName { get; set; }

        //public string PhoneNumber { get; set; }
        //public string Email { get; set; }
        //public string PhotoPath { get; set; }
        //public string Password { get; set; }

        public Address Address { get; set; }
        public Gender Gender { get; set; }

        public DateTime Birthdate { get; set; }

        [Required]
        public string PersonalIdNumber { get; set; }

        public ICollection<string> PkkNumber { get; set; }
        public Instructor Instructor { get; set; }




        public ICollection<int> CoursesId { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}