using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Enitites
{
    public partial class PermissionType
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string DisplayName { get; set; } = null!;

        public virtual ICollection<FeaturePermission> FeaturePermissions { get; } = new List<FeaturePermission>();
    }
}
