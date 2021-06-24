namespace ARACOTO.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        //public SqlConnection Conn = new SqlConnection();

        public virtual DbSet<AO_ARACKAYIT> AO_ARACKAYIT { get; set; }
        public virtual DbSet<AO_ARACTIP> AO_ARACTIP { get; set; }
        public virtual DbSet<AO_MALZEME> AO_MALZEME { get; set; }
        public virtual DbSet<AO_MALZEMEHAREKETLERI> AO_MALZEMEHAREKETLERI { get; set; }
        public virtual DbSet<AO_MUSTERILER> AO_MUSTERILER { get; set; }
        public virtual DbSet<AO_SERVISFIS> AO_SERVISFIS { get; set; }
        public virtual DbSet<AO_SERVISFISSATIR> AO_SERVISFISSATIR { get; set; }
        public virtual DbSet<AO_STOK> AO_STOK { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AO_SERVISFISSATIR>()
                .Property(e => e.miktar)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AO_SERVISFISSATIR>()
                .Property(e => e.fiyat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AO_STOK>()
                .Property(e => e.miktar)
                .HasPrecision(18, 0);


        }
    }
}
