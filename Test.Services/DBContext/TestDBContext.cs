using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Test.Services.DBContext;

public partial class TestDBContext : DbContext
{
    public TestDBContext(DbContextOptions<TestDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Response> Responses { get; set; }
    public virtual DbSet<UserValidate> UserValidates { get; set; }
    public virtual DbSet<SubProductMast> SubProductMaster { get; set; }
    public virtual DbSet<LoadSubProductMast> LoadSubProductMaster { get; set; }
    public virtual DbSet<ProductMast> ProductMaster { get; set; }
    public virtual DbSet<LoadProductMast> LoadProductMaster { get; set; }
    public virtual DbSet<SaveUserMast> SaveUserMaster{ get; set; }
    public virtual DbSet<LoadUserMast> GetUserMaster { get; set; }
    public virtual DbSet<SaveCustomerMast> SaveCustomerMaster { get; set; }
    public virtual DbSet<LoadCustomerMast> GetCustomerMaster { get; set; }
    public virtual DbSet<AddressMast> SaveAddressMaster { get; set; }
    public virtual DbSet<LoadAddressMast> GetAddressMaster { get; set; }
    public virtual DbSet<LoadList> Loadlists { get; set; }
    public virtual DbSet<GeneratSetting> SaveGeneralSettings { get; set; }
    public virtual DbSet<GeneratSetting> LoadGeneralSettings { get; set; }

    //public virtual DbSet<ProductBrand> ProductBrand { get; set; }
    //public virtual DbSet<Employee> Employees { get; set; }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    ////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //    => optionsBuilder.UseSqlServer("Server=ESLAPI\\SQLEXPRESS;User ID=sa; password=4255; Database=TestApi; Trusted_Connection=True; Encrypt=false; TrustServerCertificate=False; ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Response>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<UserValidate>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<ProductAttachDt>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<SubProductMast>( entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<ProductMast>( entity => 
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<SaveUserMast>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<LoadUserMast>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<SaveCustomerMast>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<LoadCustomerMast>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<AddressMast>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<LoadAddressMast>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<LoadList>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<GeneratSetting>(entity =>
        {
            entity.HasNoKey();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
