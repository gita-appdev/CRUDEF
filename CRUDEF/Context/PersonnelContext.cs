using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CRUDEF.Models;

#nullable disable

namespace CRUDEF.Context
{
    public partial class PersonnelContext : DbContext
    {
        public PersonnelContext()
        {
        }

        public PersonnelContext(DbContextOptions<PersonnelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Personnel> Personnel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.Property(e => e.PersonnelId).HasColumnName("Personnel_ID");

                entity.Property(e => e.ABranch)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("A_Branch");

                entity.Property(e => e.ARank)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("A_Rank");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AltOfficeSymbol).HasColumnName("Alt_Office_Symbol");

                entity.Property(e => e.DliHire)
                    .HasColumnType("datetime")
                    .HasColumnName("DLI_Hire");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Type");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("F_Name");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("L_Name");

                entity.Property(e => e.Location1).HasColumnName("Location_1");

                entity.Property(e => e.Location2).HasColumnName("Location_2");

                entity.Property(e => e.MName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("M_Name");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Office_Phone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
