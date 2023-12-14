using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Enitites
{
    public partial class Role:BaseEntities
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public short UserLevel { get; set; }

        public bool IsSystemRole { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<RoleFeaturePermission> RoleFeaturePermissions { get; } = new List<RoleFeaturePermission>();

        public virtual ICollection<User> Users { get; } = new List<User>();

    }
}
