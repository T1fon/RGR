using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VisualFinal.Models.Database
{
    public partial class datbaseContext : DbContext
    {
        public datbaseContext()
        {
        }

        public datbaseContext(DbContextOptions<datbaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bid> Bids { get; set; } = null!;
        public virtual DbSet<Bidder> Bidders { get; set; } = null!;
        public virtual DbSet<Horse> Horses { get; set; } = null!;
        public virtual DbSet<HorseRelative> HorseRelatives { get; set; } = null!;
        public virtual DbSet<Jockey> Jockeys { get; set; } = null!;
        public virtual DbSet<Race> Races { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(
                               "Data Source=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName
                                + "\\Assets\\datbase.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bid>(entity =>
            {
                entity.HasKey(e => new { e.RaceNumber, e.HorseName, e.BidderName });

                entity.ToTable("Bid");

                entity.Property(e => e.RaceNumber).HasColumnName("Race Number");

                entity.Property(e => e.HorseName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Horse name");

                entity.Property(e => e.BidderName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Bidder name");

                entity.Property(e => e.Incom).HasColumnType("DOUBLE");

                entity.HasOne(d => d.BidderNameNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.BidderName)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.HorseNameNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.HorseName)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RaceNumberNavigation)
                    .WithMany(p => p.Bids)
                    .HasForeignKey(d => d.RaceNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Bidder>(entity =>
            {
                entity.HasKey(e => e.BidderName);

                entity.ToTable("Bidder");

                entity.Property(e => e.BidderName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Bidder name");

                entity.Property(e => e.Success).HasColumnType("DOUBLE");
            });

            modelBuilder.Entity<Horse>(entity =>
            {
                entity.HasKey(e => e.HorseName);

                entity.ToTable("Horse");

                entity.Property(e => e.HorseName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Horse name");

                entity.Property(e => e.NumOfLosing).HasColumnName("Num of losing");

                entity.Property(e => e.NumOfWining).HasColumnName("Num of wining");

                entity.Property(e => e.Sex).HasColumnType("CHAR");
            });

            modelBuilder.Entity<HorseRelative>(entity =>
            {
                entity.HasKey(e => e.HorseName);

                entity.ToTable("Horse Relatives");

                entity.Property(e => e.HorseName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Horse name");

                entity.Property(e => e.Dad).HasColumnType("VARCHAR (20)");

                entity.Property(e => e.Mum).HasColumnType("VARCHAR (20)");

                entity.HasOne(d => d.HorseNameNavigation)
                    .WithOne(p => p.HorseRelative)
                    .HasForeignKey<HorseRelative>(d => d.HorseName)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Jockey>(entity =>
            {
                entity.HasKey(e => e.HorseName);

                entity.ToTable("Jockey");

                entity.Property(e => e.HorseName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Horse name");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (20)");

                entity.Property(e => e.NumberOfLosing).HasColumnName("Number of losing");

                entity.Property(e => e.NumberOfWining).HasColumnName("Number of wining");

                entity.HasOne(d => d.HorseNameNavigation)
                    .WithOne(p => p.Jockey)
                    .HasForeignKey<Jockey>(d => d.HorseName)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.HasKey(e => e.RaceNumber);

                entity.ToTable("Race");

                entity.Property(e => e.RaceNumber)
                    .ValueGeneratedNever()
                    .HasColumnName("Race number");

                entity.Property(e => e.Date).HasDefaultValueSql("\"DD.MM.YY\"");

                entity.Property(e => e.TimeRace)
                    .HasColumnName("Time Race")
                    .HasDefaultValueSql("\"00:00:00\"");

                entity.Property(e => e.TipeRace).HasColumnName("Tipe race");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => new { e.HorseName, e.RaceNumber });

                entity.ToTable("Result");

                entity.Property(e => e.HorseName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Horse name");

                entity.Property(e => e.RaceNumber).HasColumnName("Race number");

                entity.Property(e => e.AgeWeight)
                    .HasColumnName("Age/Weight")
                    .HasDefaultValueSql("\"0/0\"");

                entity.Property(e => e.Backlog).HasDefaultValueSql("\"00.00.00\"");

                entity.HasOne(d => d.HorseNameNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.HorseName)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RaceNumberNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.RaceNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
