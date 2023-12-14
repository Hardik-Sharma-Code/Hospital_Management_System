using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Enitites
{
    public partial class RoleFeaturePermission
    {
        public Guid Id { get; set; }

        public Guid RoleId { get; set; }

        public Guid FeaturePermissionId { get; set; }

        public bool IsAllowed { get; set; }

        public virtual FeaturePermission FeaturePermission { get; set; } = null!;

        public virtual Role Role { get; set; } = null!;
    }
}
