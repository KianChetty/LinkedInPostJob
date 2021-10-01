using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkedInPostJob.Shared;
using Microsoft.EntityFrameworkCore;


namespace Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

            
        }


        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>().HasData(

                        new Job
                        {
                            Id = 1,
                            JobTitle = "Developer",
                            Location = "Western Cape",
                            JobType = "Full Time",
                            Department = "IT",
                            Description = "The job of a software developer depends on the needs of the company,organization,or team they are on.Some build and maintain systems that run devices and networks.Others develop applications that make it possible for people to perform specific tasks on computers, cellphones, or other devices",
                            Compensation = "R10000"

                        }
                 ); 
        }

    }
}