using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CRUDEF.Models
{
    public partial class PHRContext : DbContext
    {
        public PHRContext()
        {
        }

        public PHRContext(DbContextOptions<PHRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Personnel> Personnel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=MPLS-SQL-190V\\DATABASESQL;initial catalog=PHR;integrated security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.HasKey(e => e.PersId);

                entity.ToTable("Personnel", "STAFF");

                entity.Property(e => e.ActiveDutySvcId).HasColumnName("ActiveDutySvcID");

                entity.Property(e => e.AdpayGrade)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ADPayGrade");

                entity.Property(e => e.Dlideparture)
                    .HasColumnType("date")
                    .HasColumnName("DLIDeparture");

                entity.Property(e => e.Dlihire)
                    .HasColumnType("date")
                    .HasColumnName("DLIHire");

                entity.Property(e => e.Edipi)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EDIPI");

                entity.Property(e => e.Edipiencrypt).HasColumnName("EDIPIEncrypt");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.OfficialEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_BIN2");

                entity.Property(e => e.Scdleave)
                    .HasColumnType("date")
                    .HasColumnName("SCDLeave");

                entity.Property(e => e.SecurityClearance).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
