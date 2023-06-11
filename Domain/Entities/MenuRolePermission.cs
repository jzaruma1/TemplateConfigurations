using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MenuRolePermission
    {
        public int Id { get; set; } 
        public int MenuRoleId { get; set; }
        public MenuRole MenuRole { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
        public IEnumerable<RolePermissionField> RolePermissionFields { get; set; }

    }
}
