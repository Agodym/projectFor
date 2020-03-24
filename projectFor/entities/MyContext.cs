using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace projectFor
{
    class MyContext : DbContext 
    {
        public MyContext() : base("EnglishS")
        { }
        public DbSet<entities.Answer> Answers { get; set; }
        public DbSet<entities.Group> Groups { get; set; }
        public DbSet<entities.Lesson> Lessons { get; set; }
        public DbSet<entities.LessonGroup> LG { get; set; }
        public DbSet<entities.Role> Roles { get; set; }
        public DbSet<entities.Task> Tasks { get; set; }
        public DbSet<entities.Type> Types { get; set; }
        public DbSet<entities.User> Users { get; set; }
        public DbSet<entities.Word> Words { get; set; }
    }
}
