using System.Data.Entity;
using CodeFirstDemo.Models;

namespace CodeFirstDemo.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDB")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
