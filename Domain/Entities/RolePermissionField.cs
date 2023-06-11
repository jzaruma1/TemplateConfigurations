using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RolePermissionField
    {
        public int Id { get; set; }
        public int MenuRolePermissionId { get; set; }
        public MenuRolePermission MenuRolePermission { get; set; }
        public string KeyField { get; set; }
        public string CodeField { get; set; }
    }
}
