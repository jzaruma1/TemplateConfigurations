using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MenuRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public int Order { get; set; }
        public IEnumerable<MenuRolePermission> MenuRolePermissions { get; set; }
    }
}
