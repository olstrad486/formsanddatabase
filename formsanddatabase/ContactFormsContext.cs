using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace formsanddatabase
{
    public class ContactFormsContext : DbContext
    {
        public DbSet<ContactForm> ContactForms { get; set; }

        public ContactFormsContext(DbContextOptions<ContactFormsContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=contactforms.db");
        }
    }
    [Table("contactform")]
    public class ContactForm
    {
        [Column("id")]
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}
