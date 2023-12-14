using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Enitites
{
    public partial class FeaturePermission
    {
        public Guid Id { get; set; }

        public Guid? FeatureId { get; set; }

        public Guid? PermissionTypeId { get; set; }

        public virtual Feature? Feature { get; set; }

        public virtual PermissionType? PermissionType { get; set; }

        public virtual ICollection<RoleFeaturePermission> RoleFeaturePermissions { get; } = new List<RoleFeaturePermission>();

    }
}
