namespace TouchpointDBWebService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TouchpointDBContext : DbContext
    {
        public TouchpointDBContext()
            : base("name=TouchpointDBContext2")
        {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<DeltagerIKursus> DeltagerIKursus { get; set; }
        public virtual DbSet<Kursist> Kursist { get; set; }
        public virtual DbSet<Kursus> Kursus { get; set; }
        public virtual DbSet<Serie> Serie { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<Underviser> Underviser { get; set; }
        public virtual DbSet<UnderviserPåKursus> UnderviserPåKursus { get; set; }
        public virtual DbSet<UndervisningsSted> UndervisningsSted { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kursist>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursist>()
                .Property(e => e.Adresse)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursist>()
                .Property(e => e.Land)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursist>()
                .Property(e => e.By)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursist>()
                .Property(e => e.tlf)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursist>()
                .Property(e => e.Navn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursist>()
                .HasMany(e => e.DeltagerIKursus)
                .WithRequired(e => e.Kursist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kursus>()
                .Property(e => e.Pris)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kursus>()
                .Property(e => e.Sprog)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursus>()
                .Property(e => e.Depositum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kursus>()
                .Property(e => e.Beskrivelse)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursus>()
                .Property(e => e.Varighed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursus>()
                .Property(e => e.Titel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kursus>()
                .HasMany(e => e.DeltagerIKursus)
                .WithRequired(e => e.Kursus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kursus>()
                .HasMany(e => e.UnderviserPåKursus)
                .WithRequired(e => e.Kursus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Serie>()
                .Property(e => e.KursusSerie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Serie>()
                .Property(e => e.Beskrivelse)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Underviser>()
                .Property(e => e.Navn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Underviser>()
                .Property(e => e.Adresse)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Underviser>()
                .Property(e => e.tlf)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Underviser>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Underviser>()
                .HasMany(e => e.Kursus)
                .WithRequired(e => e.Underviser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Underviser>()
                .HasMany(e => e.UnderviserPåKursus)
                .WithRequired(e => e.Underviser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UndervisningsSted>()
                .Property(e => e.Lokale)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UndervisningsSted>()
                .Property(e => e.Adresse)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UndervisningsSted>()
                .HasMany(e => e.Kursus)
                .WithRequired(e => e.UndervisningsSted)
                .WillCascadeOnDelete(false);
        }
    }
}
