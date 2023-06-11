using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuRole> MenuRoles { get; set; }
        public DbSet<MenuRolePermission> MenuRolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermissionField> RolePermissionFields { get; set; }
    }
}
