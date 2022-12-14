using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Provinsi> Provinsis { set; get; }
        public DbSet<Perusahaan> Perusahaans { set; get; }
        public DbSet<Penempatan> Penempatans { set; get; }
    }
}
