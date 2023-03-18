using HaberFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HaberFinder.DataAccess
{
    public class HaberDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //Test edebilmek için Buraya Doğru Server Adresleri verilmelidir.Ben Bilgilerimi temizledim
            optionsBuilder.UseSqlServer("Server=MyServer; Database=Haberler; uid=sa;pwd=**;");

        }

        public DbSet<Haber> Habers { get; set; }
    }
}
