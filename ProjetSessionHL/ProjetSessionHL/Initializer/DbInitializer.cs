using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetSessionHL.Data;
using ProjetSessionHL.Models;
using ProjetSessionHL.Utility;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetSessionHL.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ProjetSessionDbContext _db;

        public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ProjetSessionDbContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public void Initialize()
        {
            // Exécuter les migrations sont effectuées
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex) { }

            // Créer les rôles suivants si aucun rôle ne figure dans la bd
            if (!_roleManager.RoleExistsAsync(AppConstants.AdminRole).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(AppConstants.AdminRole))
                .GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(AppConstants.CoachRole))
                .GetAwaiter().GetResult();

                // Créer un User pour le rôle Admin
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "rapId@ProjetSession.com",
                    Email = "rapId@ProjetSession.com",
                    NickName = "rapId",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true
                }, "Admin123$").GetAwaiter().GetResult();
                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email ==
               "rapId@ProjetSession.com");
                _userManager.AddToRoleAsync(user, AppConstants.AdminRole)
                .GetAwaiter().GetResult();

                // Créer deux Users pour le rôle Coach
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "fNs@ProjetSession.com",
                    Email = "fNs@ProjetSession.com",
                    NickName = "fNs",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true,
                }, "Coach123$").GetAwaiter().GetResult();
                ApplicationUser user2 = _db.ApplicationUsers.FirstOrDefault(u => u.Email ==
               "fNs@ProjetSession.com");
                _userManager.AddToRoleAsync(user2, AppConstants.CoachRole)
                .GetAwaiter().GetResult();

                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "beaulo@ProjetSession.com",
                    Email = "beaulo@ProjetSession.com",
                    NickName = "beaulo",
                    PhoneNumber = "1111111111",
                    EmailConfirmed = true,
                }, "Coach123$").GetAwaiter().GetResult();
                ApplicationUser user3 = _db.ApplicationUsers.FirstOrDefault(u => u.Email ==
               "beaulo@ProjetSession.com");
                _userManager.AddToRoleAsync(user3, AppConstants.CoachRole)
                .GetAwaiter().GetResult();
            }
        }
    }
}
