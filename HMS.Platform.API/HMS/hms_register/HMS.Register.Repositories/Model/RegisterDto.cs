using HMS.Register.Repositories.Enitites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Model
{
    public class RegisterDto:BaseEntities
    {
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string Gender { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Pasword { get; set; } = null!;
    }
}
