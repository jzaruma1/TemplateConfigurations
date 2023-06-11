using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService) { 
            _menuService = menuService;
        }


        [HttpGet(Name = "MenuOptions")]
        public async Task<IEnumerable<Menu>> Get(string role)
        {
            return await _menuService.GetMenuOptions(null, role);
        }
    }
}