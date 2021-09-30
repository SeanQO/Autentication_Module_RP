using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Autentication_Module_RP.Data;
using System;
using System.Linq;

namespace Autentication_Module_RP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RDPCUserContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RDPCUserContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Username = "admin",
                        Password = "admin",
                        Firstname = "admin",
                        Lastname = "admin",
                        BirthDate = "03/03/2001"
                    },

                    new User
                    {
                        Username = "admin2",
                        Password = "admin2",
                        Firstname = "admin2",
                        Lastname = "admin2",
                        BirthDate = "04/04/2001"
                    },

                    new User
                    {
                        Username = "admin3",
                        Password = "admin3",
                        Firstname = "admin3",
                        Lastname = "admin3",
                        BirthDate = "05/05/2001"
                    },

                    new User
                    {
                        Username = "admin4",
                        Password = "admin4",
                        Firstname = "admin4",
                        Lastname = "admin4",
                        BirthDate = "06/06/2001"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
