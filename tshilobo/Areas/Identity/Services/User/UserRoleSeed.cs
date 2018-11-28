using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using tshilobo.Areas.Identity.Data;
using tshilobo.Enities;
using tshilobo.Models;

/// <summary>
/// Author  :   Bondo kalombo
/// Date    :   20/11/2018
/// Purpose :   Seeds the UserRole table with User Roles which are going to 
/// be used for access privileges
/// </summary>
namespace tshilobo.Areas.Identity.Services.User
{
    public static class UserRoleSeed
    {
        /// <summary>
        /// Roles in order of highest privilege from high to low.
        /// 1. SuperUser - 2. ChurchAdmin - 3. MainChurchLeader - 4. JuniorChurchLeader
        /// 5. DepartmentLeader - 6. SubDepartmentLeader - 7. ChurchMember - 8. BranchMember
        /// 9. - ApplicationUser - 10. Guest
        /// </summary>
        /// <param name="context"></param>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        //public static async Task InitializeAsync(tshiloboContext context, IServiceProvider serviceProvider)
        //{
        //    // Create database schema if none exists
        //    context.Database.EnsureCreated();
        //    var _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

        //    string[] roleNames = { "MainChurchLeader", "ChurchAdmin", "ApplicationUser", "JuniorChurchLeader", "BranchMember", "DepartmentLeader", "ChurchMember", "SubDepartmentLeader", "SuperUser", "Guest" };

        //    IdentityResult roleResult;

        //    foreach(var roleName in roleNames)
        //    {
        //        var roleExists = await _roleManager.RoleExistsAsync(roleName);

        //        if (!roleExists)
        //        {
        //            roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
        //        }
        //    }

        //    // Create the default Admin account and apply the Admin role           
        //    var user = new tshiloboUser
        //    {
        //        UserName = "admin@tshilobo.com",
        //        Email = "admin@tshilobo.com",
        //        FirstName = "Admin",
        //        LastName = "Tshilobo",
        //        GenderId = Convert.ToInt32(1),
        //        DisplayName = "Tshilbo (Admin)",
        //        DateOfBirth = new DateTime(Convert.ToInt32(1990), Convert.ToInt32(11), Convert.ToInt32(1), 0, 0, 0)
        //    };
        //}

        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tshiloboContext(serviceProvider.GetRequiredService<DbContextOptions<tshiloboContext>>()))
            {
                context.Database.EnsureCreated();

                var _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                string[] roleNames = { "MainChurchLeader", "ChurchAdmin", "ApplicationUser", "JuniorChurchLeader", "BranchMember", "DepartmentLeader", "ChurchMember", "SubDepartmentLeader", "SuperUser", "Guest" };

                IdentityResult roleResult;

                foreach (var roleName in roleNames)
                {
                    var roleExists = await _roleManager.RoleExistsAsync(roleName);

                    if (!roleExists)
                    {
                        roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }
            }
        }
    }
}
