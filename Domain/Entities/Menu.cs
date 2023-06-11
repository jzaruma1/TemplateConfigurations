using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public int? ParentMenuId { get; set; }
        public Menu ParentMenu { get; set; }
        public bool IsHidden { get; set; }
        public IEnumerable<Menu> ChildMenus { get; set;}
        public IEnumerable<MenuRole> MenuRoles { get; set; }
    }
}
