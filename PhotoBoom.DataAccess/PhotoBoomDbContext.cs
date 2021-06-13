using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhotoBoom.Entities;

namespace PhotoBoom.DataAccess
{
    class PhotoBoomDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-PEIGBBR;Database=BoomPhotoDb;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }

        public DbSet<Photo> Photos { get; set; }
    }
}
