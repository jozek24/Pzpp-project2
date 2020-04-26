using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OSKManager.Model
{
    public class Instructor : IEntity<Guid>
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string Surname { get; set; }

        public Address Address { get; set; }
        public Gender Gender { get; set; }

        public List<Category> CategoryPermissions { get; set; }
        public DateTime? LicenceExpireTime { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}