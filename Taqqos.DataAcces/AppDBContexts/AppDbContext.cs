using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Taqqos.Domain.Entitys.Collectors;
using Taqqos.Domain.Entitys.Deliveries;
using Taqqos.Domain.Entitys.Users;

namespace Taqqos.DataAcces.AppDBContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<DeliveryMan> DeliveryMenses { get; set; }

        public virtual DbSet<Collector> Collectors { get; set; }

        public virtual DbSet<Attachment> Attachments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attachment>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
