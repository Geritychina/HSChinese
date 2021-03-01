using System;
using System.Collections.Generic;
using System.Text;
using HSChinese.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HSChinese.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectGroup> SubjectGroups { get; set; }

        public DbSet<SubjectGroupStudents> SubjectGroupStudents { get; set; }

        public DbSet<UserSubject> UserSubjects { get; set; }

       
    
 


        //Relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);




            modelBuilder.Entity<UserSubject>()
            .HasKey(u => new { u.UserId, u.SubjectId });

            modelBuilder.Entity<User>()
                .HasMany(u => u.Subjects)
                .WithOne(s => s.Student)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<Subject>()
                .HasMany(sb => sb.Users)
                .WithOne(usb => usb.Subject)
                .HasForeignKey(sb => sb.SubjectId);


            modelBuilder.Entity<SubjectGroupStudents>()
                .HasKey(n => new { n.UserId, n.SubjectGroupId });

            modelBuilder.Entity<User>()
                .HasMany(u => u.SubjectGroups)
                .WithOne(p => p.User)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<SubjectGroup>()
                .HasMany(r => r.GroupStudents)
                .WithOne(u => u.SubjectGroup)
                .HasForeignKey(u => u.SubjectGroupId);


            modelBuilder.Entity<SubjectGroup>()
                .HasMany(u => u.Subjects)
                .WithOne(u => u.SubjectGroup)
                .HasForeignKey(r => r.SubjectGroupId);






        }


    }
}
