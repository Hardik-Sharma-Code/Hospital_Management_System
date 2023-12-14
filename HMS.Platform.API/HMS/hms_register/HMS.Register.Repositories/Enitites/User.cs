using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Enitites
{
    public partial class User:BaseEntities
    {
        public string Id { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string ProfilePic { get; set; } 

        public string Email { get; set; }

        public short UserLevel { get; set; }

        public Guid? RoleId { get; set; }

        public bool? IsActive { get; set; }

        public virtual Role? Role { get; set; }
    }
}
