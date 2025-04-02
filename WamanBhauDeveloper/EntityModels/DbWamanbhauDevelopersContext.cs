using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace WamanBhauDeveloper.EntityModels;

public partial class DbWamanbhauDevelopersContext : DbContext
{
    public DbWamanbhauDevelopersContext()
    {
    }

    public DbWamanbhauDevelopersContext(DbContextOptions<DbWamanbhauDevelopersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblChannelPartner> TblChannelPartners { get; set; }

    public virtual DbSet<TblFlatBookingStatus> TblFlatBookingStatuses { get; set; }

    public virtual DbSet<TblFlatInventoryStatus> TblFlatInventoryStatuses { get; set; }

    public virtual DbSet<TblFlatParkingInverntory> TblFlatParkingInverntories { get; set; }

    public virtual DbSet<TblLeadFollowup> TblLeadFollowups { get; set; }

    public virtual DbSet<TblLeadMaster> TblLeadMasters { get; set; }

    public virtual DbSet<TblLeadSource> TblLeadSources { get; set; }

    public virtual DbSet<TblLockingPeriod> TblLockingPeriods { get; set; }

    public virtual DbSet<TblParkingBooking> TblParkingBookings { get; set; }

    public virtual DbSet<TblPropertyType> TblPropertyTypes { get; set; }

    public virtual DbSet<TblSiteAssign> TblSiteAssigns { get; set; }

    public virtual DbSet<TblSiteFlat> TblSiteFlats { get; set; }

    public virtual DbSet<TblSiteParking> TblSiteParkings { get; set; }

    public virtual DbSet<TblSiteWing> TblSiteWings { get; set; }

    public virtual DbSet<TblSitemaster> TblSitemasters { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    public virtual DbSet<TblUserAccess> TblUserAccesses { get; set; }

    public virtual DbSet<TblUserrole> TblUserroles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<TblChannelPartner>(entity =>
        {
            entity.HasKey(e => e.ChannelPartnerId).HasName("PRIMARY");

            entity.ToTable("tbl_channel_partner");

            entity.Property(e => e.ContactNo).HasMaxLength(45);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(250);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblFlatBookingStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_flat_booking_status");

            entity.Property(e => e.BookingAmount).HasMaxLength(45);
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkFlateId).HasColumnName("Fk_FlateId");
            entity.Property(e => e.FkLeadId).HasColumnName("Fk_LeadId");
            entity.Property(e => e.FkUserId).HasColumnName("Fk_UserId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblFlatInventoryStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_flat_inventory_status");

            entity.Property(e => e.BookingStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkFlatId).HasColumnName("Fk_FlatId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblFlatParkingInverntory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_flat_parking_inverntory");

            entity.Property(e => e.BookingStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkParkingId).HasColumnName("Fk_ParkingId");
            entity.Property(e => e.FkSiteId).HasColumnName("Fk_SiteId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLeadFollowup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_lead_followup");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FollowUpDate).HasColumnType("datetime");
            entity.Property(e => e.FollowUpType).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.NextFollowUpDate).HasColumnType("datetime");
            entity.Property(e => e.ReminderText)
                .HasMaxLength(50)
                .HasColumnName("Reminder_Text");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLeadMaster>(entity =>
        {
            entity.HasKey(e => e.LeadId).HasName("PRIMARY");

            entity.ToTable("tbl_lead_master");

            entity.Property(e => e.BudgetRangeFrom)
                .HasMaxLength(45)
                .HasColumnName("BudgetRange_From");
            entity.Property(e => e.BudgetRangeTo)
                .HasMaxLength(45)
                .HasColumnName("BudgetRange_To");
            entity.Property(e => e.ContactDate).HasColumnType("datetime");
            entity.Property(e => e.ContactNo1).HasMaxLength(45);
            entity.Property(e => e.ContactNo2).HasMaxLength(45);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.FkChannelPartnerId).HasColumnName("Fk_ChannelPartnerId");
            entity.Property(e => e.FkSiteId).HasColumnName("Fk_SiteId");
            entity.Property(e => e.FkPropertyTypeId).HasColumnName("Fk_PropertyTypeId");
            entity.Property(e => e.FkSourceId).HasColumnName("Fk_SourceId");
            entity.Property(e => e.FkUserIdAssigned).HasColumnName("Fk_UserId_Assigned");
            entity.Property(e => e.FloorPreference).HasMaxLength(50);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.LeadCategory).HasMaxLength(50);
            entity.Property(e => e.LeadStatus).HasMaxLength(45);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLeadSource>(entity =>
        {
            entity.HasKey(e => e.SourceId).HasName("PRIMARY");

            entity.ToTable("tbl_lead_source");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.SourceName).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblLockingPeriod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_locking_period");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.LockingPeriodDays).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblParkingBooking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_parking_booking");

            entity.Property(e => e.BookingAmount).HasMaxLength(45);
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkAssignedUserId).HasColumnName("Fk_AssignedUserId");
            entity.Property(e => e.FkLeadId).HasColumnName("Fk_LeadId");
            entity.Property(e => e.FkParkingId).HasColumnName("Fk_ParkingId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPropertyType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_property_type");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSiteAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_site_assign");

            entity.Property(e => e.AssignedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkChannelPartnerId).HasColumnName("Fk_ChannelPartnerId");
            entity.Property(e => e.FkSiteId).HasColumnName("Fk_SiteId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSiteFlat>(entity =>
        {
            entity.HasKey(e => e.FlatId).HasName("PRIMARY");

            entity.ToTable("tbl_site_flat");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkPropertyTypeId).HasColumnName("Fk_PropertyTypeId");
            entity.Property(e => e.FkWingId).HasColumnName("Fk_WingId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSiteParking>(entity =>
        {
            entity.HasKey(e => e.ParkingId).HasName("PRIMARY");

            entity.ToTable("tbl_site_parking");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.ParkingNumber).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSiteWing>(entity =>
        {
            entity.HasKey(e => e.WingId).HasName("PRIMARY");

            entity.ToTable("tbl_site_wing");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkSiteId).HasColumnName("Fk_SiteId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.WingName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblSitemaster>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PRIMARY");

            entity.ToTable("tbl_sitemaster");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.SiteName).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("tbl_user");

            entity.Property(e => e.ContactNo).HasMaxLength(45);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FkRoleId).HasColumnName("Fk_RoleId");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblUserAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tbl_user_access");

            entity.Property(e => e.AccessMenuItem).HasMaxLength(100);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.FkRoleId).HasColumnName("Fk_RoleId");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.ReadPermission).HasColumnName("Read_Permission");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.WritePermission).HasColumnName("Write_Permission");
        });

        modelBuilder.Entity<TblUserrole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");

            entity.ToTable("tbl_userrole");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.RoleName).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
