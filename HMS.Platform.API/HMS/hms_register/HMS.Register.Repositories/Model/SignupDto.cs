using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories
{
    public class SignupDto
    {
        public string Email { get; set; } = null!;

        public string Pasword { get; set; } = null!;
    }
}
