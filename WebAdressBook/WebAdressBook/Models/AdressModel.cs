namespace WebAdressBook.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdressModel : DbContext
    {
        public AdressModel()
            : base("name=AdressModel")
        {
        }

        public virtual DbSet<AdressBook> AdressBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
