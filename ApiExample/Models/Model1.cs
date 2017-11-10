namespace ApiExample.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<udata> udatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<udata>()
                .Property(e => e.uname)
                .IsUnicode(false);

            modelBuilder.Entity<udata>()
                .Property(e => e.ucity)
                .IsUnicode(false);
        }
    }
}
