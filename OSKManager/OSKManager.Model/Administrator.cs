using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OSKManager.Model
{
    public class Administrator : IEntity<Guid>
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Length must be less then 50 characters.")]
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Gender Gender { get; set; }
    }
}
