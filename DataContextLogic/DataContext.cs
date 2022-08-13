using CoreLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextLogic
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
      
        public DbSet<Header> headers { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ContactUs> contacts { get; set; }
        public DbSet<TeamMember> teamMembers { get; set; }



    }
}
