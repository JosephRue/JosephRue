using JosephRueResume.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephRueResume.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.jobs.Any())
                {
                    return;
                }
                context.jobs.AddRange(
                    new jobs
                    {
                        CompanyName = "Nicky V's",
                        StartDate = DateTime.Parse("01/01/2015"),
                    }
                    );
            }
        }
    }
}
