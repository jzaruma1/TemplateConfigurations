using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace Application.Services
{
    public class MenuService : IMenuService
    {
        private readonly DataContext _dataContext;
        public MenuService(DataContext dataContext)
        {
            _dataContext = dataContext;

        }
        public async Task<IEnumerable<Menu>> GetMenuOptions(int? parentId, string role)
        {
            var rootItems = await _dataContext.Menus
                 .Include(x => x.MenuRoles.Where(y => y.RoleName == role)).ThenInclude(x=> x.MenuRolePermissions).ThenInclude(x=> x.Permission)
                 .Include(x => x.MenuRoles.Where(y => y.RoleName == role)).ThenInclude(x=> x.MenuRolePermissions).ThenInclude(x=> x.RolePermissionFields)
                .Where(m => m.ParentMenuId == parentId && m.MenuRoles.Any(r => r.RoleName == role))
                .ToListAsync();

            foreach (var item in rootItems)
            {
                item.ChildMenus = await GetMenuOptions(item.Id, role);
            }

            return rootItems;

        }
    }
}
