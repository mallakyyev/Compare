using Compare.DAL.Models.Configuration;
using Compare.DAL.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Compare.DAL.Data
{
    public static class StartupData
    {
        public async static Task CreateDataTask(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var dbContext = services.GetRequiredService<ApplicationDbContext>();
                await dbContext.Database.MigrateAsync();

                var context = services.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await context.Roles.AnyAsync())
                {
                    await context.CreateAsync(new IdentityRole
                    {
                        Name = "Admin"
                    });
                    await context.CreateAsync(new IdentityRole
                    {
                        Name = "User"
                    });
                    await context.CreateAsync(new IdentityRole
                    {
                        Name = "Organization"
                    });
                }

                var directoryManagement = await context.Roles.FirstOrDefaultAsync(s => s.Name == "Directory management");

                //Роль управление каталогом
                if (directoryManagement == null)
                {
                    await context.CreateAsync(new IdentityRole
                    {
                        Name = "Directory management"
                    });
                }

                var userContext = services.GetRequiredService<UserManager<ApplicationUser>>();

                var admin = await userContext.FindByNameAsync("Admin");

                if (admin == null)
                {
                    ApplicationUser adminUser = new ApplicationUser
                    {
                        FirstName = "Administrator",
                        LastName = "Site",
                        FullName = "Admin Site",
                        Email = $"administrator@compare.app",
                        UserName = "Administrator",
                        EmailConfirmed = true
                    };

                    await userContext.CreateAsync(adminUser, "Password!1");
                    await userContext.AddToRoleAsync(adminUser, "Admin");
                }

                List<Language> languages = new List<Language>();
                languages.Add(new Language() { Culture = "ru", LanguageCode = "ru", Name = "Русский", Published = true });
                //languages.Add(new Language() { Culture = "en", LanguageCode = "en", Name = "English", Published = true });
                languages.Add(new Language() { Culture = "tk", LanguageCode = "tk", Name = "Türkmençe", Published = true });

                //var _dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                foreach (var lng in languages)
                {
                    var language = await dbContext.Languages.SingleOrDefaultAsync(s => s.Culture == lng.Culture);
                    if (language == null)
                    {
                        dbContext.Languages.Add(lng);
                        await dbContext.SaveChangesAsync();
                    }
                }
            }
        }
    }
}
