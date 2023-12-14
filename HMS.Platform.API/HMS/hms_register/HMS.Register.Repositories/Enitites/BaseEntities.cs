using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Enitites
{
    public abstract class BaseEntities
    {
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; } = null!;

        public DateTime? LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}
