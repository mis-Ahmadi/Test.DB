using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test.db.Entities;

namespace test.db.DB
{
    public class TestDB : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public TestDB(DbContextOptions options)
        : base(options)
        {

        }
    }
}