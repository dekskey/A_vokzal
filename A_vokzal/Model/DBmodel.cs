namespace A_vokzal.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBmodel : DbContext
    {
        public DBmodel()
            : base("name=DBmodel")
        {
        }

        public virtual DbSet<Avtobus> Avtobus { get; set; }
        public virtual DbSet<Marshrut> Marshrut { get; set; }
        public virtual DbSet<Ostanovki> Ostanovki { get; set; }
        public virtual DbSet<Passazhir> Passazhir { get; set; }
        public virtual DbSet<Reis> Reis { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tip_avtobusa> Tip_avtobusa { get; set; }
        public virtual DbSet<Voditel> Voditel { get; set; }
        public virtual DbSet<Bilet> Bilet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avtobus>()
                .Property(e => e.nomernoy_znak)
                .IsFixedLength();

            modelBuilder.Entity<Avtobus>()
                .Property(e => e.model)
                .IsFixedLength();

            modelBuilder.Entity<Avtobus>()
                .HasMany(e => e.Reis)
                .WithRequired(e => e.Avtobus)
                .HasForeignKey(e => e.nomer_avtobusa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marshrut>()
                .HasMany(e => e.Reis)
                .WithOptional(e => e.Marshrut)
                .HasForeignKey(e => e.nomer_marshruta);

            modelBuilder.Entity<Ostanovki>()
                .Property(e => e.name_ost)
                .IsFixedLength();

            modelBuilder.Entity<Ostanovki>()
                .Property(e => e.punkt_ot)
                .IsFixedLength();

            modelBuilder.Entity<Ostanovki>()
                .Property(e => e.punkt_naz)
                .IsFixedLength();

            modelBuilder.Entity<Ostanovki>()
                .HasMany(e => e.Marshrut)
                .WithRequired(e => e.Ostanovki)
                .HasForeignKey(e => e.rasstoyanie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passazhir>()
                .Property(e => e.FIO)
                .IsFixedLength();

            modelBuilder.Entity<Passazhir>()
                .HasMany(e => e.Bilet)
                .WithRequired(e => e.Passazhir)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reis>()
                .HasMany(e => e.Bilet)
                .WithRequired(e => e.Reis)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tip_avtobusa>()
                .Property(e => e.model_avtobusa)
                .IsFixedLength();

            modelBuilder.Entity<Tip_avtobusa>()
                .HasMany(e => e.Avtobus)
                .WithRequired(e => e.Tip_avtobusa)
                .HasForeignKey(e => e.model)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voditel>()
                .Property(e => e.FIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Voditel>()
                .HasMany(e => e.Avtobus)
                .WithRequired(e => e.Voditel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bilet>()
                .Property(e => e.FIO)
                .IsFixedLength();
        }
    }
}
