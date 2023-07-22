using AutoMapper;
using Blog.Entity.DTOs.Roles;
using Blog.Entity.Entities;
using Blog.Web.Consts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;

        public RoleController(UserManager<AppUser> userManager, IMapper mapper) 
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        [Authorize(Roles = $"{RoleConsts.Superadmin}, {RoleConsts.Admin}")]
        public async Task <IActionResult> Index()
        {
            var usersWithRole = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<RoleDto>>(usersWithRole);
            foreach (var item in map)
            {
                var findUser = await userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(findUser));

                item.Role = role;
            }
           
            return View(map);
        }
    }
}
