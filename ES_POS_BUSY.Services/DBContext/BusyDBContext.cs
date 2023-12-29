using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ES_POS_BUSY.Services.DBContext;

public partial class BusyDBContext : DbContext
{
    public BusyDBContext()
    {
    }

    public BusyDBContext(DbContextOptions<BusyDBContext> options)
        : base(options)
    {
    }
    public virtual DbSet<ImportProduct> ImportProducts { get; set; } 
    public virtual DbSet<CustomerDetails> CustomersDetails {get; set;}
    public virtual DbSet<BusyImportProduct> SaveImportBusyProduct {  get; set; }

    //public virtual DbSet<AmcwarrDet> AmcwarrDets { get; set; }

    //public virtual DbSet<BillingDet> BillingDets { get; set; }

    //public virtual DbSet<BrsopBal> BrsopBals { get; set; }

    //public virtual DbSet<CheckList> CheckLists { get; set; }

    //public virtual DbSet<CloudSyncIncr> CloudSyncIncrs { get; set; }

    //public virtual DbSet<CloudSyncIncrDet> CloudSyncIncrDets { get; set; }

    //public virtual DbSet<CloudSyncStatus> CloudSyncStatuses { get; set; }

    //public virtual DbSet<Config> Configs { get; set; }

    //public virtual DbSet<DailyMessage> DailyMessages { get; set; }

    //public virtual DbSet<DailySum> DailySums { get; set; }

    //public virtual DbSet<DataSync> DataSyncs { get; set; }

    //public virtual DbSet<DeletedInfo> DeletedInfos { get; set; }

    //public virtual DbSet<DeletedMaster> DeletedMasters { get; set; }

    //public virtual DbSet<EmpLadet> EmpLadets { get; set; }

    //public virtual DbSet<EventLog> EventLogs { get; set; }

    //public virtual DbSet<Excise> Excises { get; set; }

    //public virtual DbSet<ExternalDatum> ExternalData { get; set; }

    //public virtual DbSet<Folio1> Folio1s { get; set; }

    //public virtual DbSet<GetGeneratedEwayBillDet> GetGeneratedEwayBillDets { get; set; }

    //public virtual DbSet<Gstinfo> Gstinfos { get; set; }

    //public virtual DbSet<GstitcpendingVchDet> GstitcpendingVchDets { get; set; }

    //public virtual DbSet<Gstr1info> Gstr1infos { get; set; }

    //public virtual DbSet<Gstr2ainfo> Gstr2ainfos { get; set; }

    //public virtual DbSet<Gstr2binfo> Gstr2binfos { get; set; }

    //public virtual DbSet<Gstr3binfo> Gstr3binfos { get; set; }

    //public virtual DbSet<Help1> Help1s { get; set; }

    //public virtual DbSet<Help1AddnInfo> Help1AddnInfos { get; set; }

    //public virtual DbSet<Help2> Help2s { get; set; }

    //public virtual DbSet<Image> Images { get; set; }

    //public virtual DbSet<ItemDesc> ItemDescs { get; set; }

    //public virtual DbSet<ItemParamDet> ItemParamDets { get; set; }

    //public virtual DbSet<ItemSerialNo> ItemSerialNos { get; set; }

    //public virtual DbSet<ItemSninstallDet> ItemSninstallDets { get; set; }

    //public virtual DbSet<JobFinishedRef> JobFinishedRefs { get; set; }

    //public virtual DbSet<Lock> Locks { get; set; }

    //public virtual DbSet<MastFootPrint> MastFootPrints { get; set; }

    //public virtual DbSet<Master1> Master1s { get; set; }

    //public virtual DbSet<MasterAddressInfo> MasterAddressInfos { get; set; }

    //public virtual DbSet<MasterSupport> MasterSupports { get; set; }

    //public virtual DbSet<Oeddet> Oeddets { get; set; }

    //public virtual DbSet<OrgSalePurc> OrgSalePurcs { get; set; }

    //public virtual DbSet<PackingDetail> PackingDetails { get; set; }

    //public virtual DbSet<Patch> Patches { get; set; }

    //public virtual DbSet<PhyStkSubDet> PhyStkSubDets { get; set; }

    //public virtual DbSet<Posdet> Posdets { get; set; }

    //public virtual DbSet<QueryLog> QueryLogs { get; set; }

    //public virtual DbSet<RepColSize> RepColSizes { get; set; }

    //public virtual DbSet<RepOptValue> RepOptValues { get; set; }

    //public virtual DbSet<ReportNote> ReportNotes { get; set; }

    //public virtual DbSet<Stdet> Stdets { get; set; }

    //public virtual DbSet<Tc> Tcs { get; set; }

    //public virtual DbSet<Td> Tds { get; set; }

    //public virtual DbSet<TradingExcise> TradingExcises { get; set; }

    //public virtual DbSet<Tran1> Tran1s { get; set; }

    //public virtual DbSet<Tran10> Tran10s { get; set; }

    //public virtual DbSet<Tran11> Tran11s { get; set; }

    //public virtual DbSet<Tran12> Tran12s { get; set; }

    //public virtual DbSet<Tran2> Tran2s { get; set; }

    //public virtual DbSet<Tran3> Tran3s { get; set; }

    //public virtual DbSet<Tran4> Tran4s { get; set; }

    //public virtual DbSet<Tran5> Tran5s { get; set; }

    //public virtual DbSet<Tran6> Tran6s { get; set; }

    //public virtual DbSet<Tran7> Tran7s { get; set; }

    //public virtual DbSet<Tran8> Tran8s { get; set; }

    //public virtual DbSet<Tran9> Tran9s { get; set; }

    //public virtual DbSet<Vatinfo> Vatinfos { get; set; }

    //public virtual DbSet<VchGstsumItemWise> VchGstsumItemWises { get; set; }

    //public virtual DbSet<VchOtherInfo> VchOtherInfos { get; set; }

    //public virtual DbSet<VchTempTagging> VchTempTaggings { get; set; }

    //public virtual DbSet<VchTemplate> VchTemplates { get; set; }

    //public virtual DbSet<VchVataccInfo> VchVataccInfos { get; set; }

    //public virtual DbSet<VchVatsum> VchVatsums { get; set; }

    //public virtual DbSet<VchVatsumItemWise> VchVatsumItemWises { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //=> optionsBuilder.UseSqlServer("Server=ESLAPI\\SQLEXPRESS;User ID=sa; password=4255; Database=BusyComp0003_db12023; Trusted_Connection=True; Encrypt=false; TrustServerCertificate=False; ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerDetails>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<ImportProduct>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<BusyImportProduct>(entity =>
        {
            entity.HasNoKey();
        });



        //modelBuilder.Entity<AmcwarrDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("AMCWarrDet");

        //    entity.HasIndex(e => e.MasterCode1, "01");

        //    entity.HasIndex(e => e.MasterCode2, "02");

        //    entity.HasIndex(e => e.ItemSerialNo, "03");

        //    entity.HasIndex(e => e.RefNo, "04");

        //    entity.HasIndex(e => e.ContEndDate, "05");

        //    entity.HasIndex(e => e.VchNo, "06");

        //    entity.HasIndex(e => e.Status, "07");

        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.ContEndDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ItemSerialNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Narration)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.RefNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<BillingDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("BillingDet");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.HasIndex(e => e.PartyName, "02");

        //    entity.HasIndex(e => e.MobileNo, "03");

        //    entity.HasIndex(e => e.Email, "04");

        //    entity.Property(e => e.Address1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address1Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address1SL");
        //    entity.Property(e => e.Address2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address2Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address2SL");
        //    entity.Property(e => e.Address3)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address3Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address3SL");
        //    entity.Property(e => e.Address4)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address4Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address4SL");
        //    entity.Property(e => e.AdharNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Collectorate)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cstno)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CSTNo");
        //    entity.Property(e => e.Division)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DrugLicenceNo1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DrugLicenceNo2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Ecccode)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ECCCode");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ExciseRegNo)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Fssaino)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("FSSAINo");
        //    entity.Property(e => e.Gstno)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTNo");
        //    entity.Property(e => e.Itpan)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ITPAN");
        //    entity.Property(e => e.MobileNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PartyName)
        //        .HasMaxLength(60)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PartyNameSl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("PartyNameSL");
        //    entity.Property(e => e.Plano)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("PLANo");
        //    entity.Property(e => e.Range)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Stno)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("STNo");
        //});

        //modelBuilder.Entity<BrsopBal>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("BRSOpBal");

        //    entity.HasIndex(e => new { e.MasterCode1, e.Type, e.SrNo }, "01");

        //    entity.HasIndex(e => e.MasterCode2, "02");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ClrDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.EntryDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ShortNar)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<CheckList>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("CheckList");

        //    entity.HasIndex(e => e.Code, "21");

        //    entity.HasIndex(e => e.UserName, "23");

        //    entity.HasIndex(e => e.Action, "24");

        //    entity.Property(e => e.ActionTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ComputerName)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Notes)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<CloudSyncIncr>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("CloudSyncIncr");

        //    entity.HasIndex(e => e.Code, "01");

        //    entity.HasIndex(e => e.Type, "02");

        //    entity.HasIndex(e => e.Action, "03");

        //    entity.HasIndex(e => e.EntryDateTime, "05");

        //    entity.HasIndex(e => e.Status, "07");

        //    entity.Property(e => e.BusyDocLink)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.EntryDateTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Error)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.SelfImageLink)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<CloudSyncIncrDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("CloudSyncIncrDet");

        //    entity.HasIndex(e => e.Code, "01");

        //    entity.HasIndex(e => e.SrNo, "02");

        //    entity.Property(e => e.Xmlstr)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("XMLStr");
        //});

        //modelBuilder.Entity<CloudSyncStatus>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("CloudSyncStatus");

        //    entity.HasIndex(e => e.BulkStatus, "01");

        //    entity.HasIndex(e => e.BulkComputerName, "02");

        //    entity.Property(e => e.BulkComputerName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BulkDateTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.BulkIp)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("BulkIP");
        //    entity.Property(e => e.BulkStatusDet)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.IncrComputerName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.IncrDateTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.IncrIp)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("IncrIP");
        //    entity.Property(e => e.IncrStatusDet)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //});

        //modelBuilder.Entity<Config>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Config");

        //    entity.HasIndex(e => new { e.RecType, e.Type }, "01");

        //    entity.HasIndex(e => new { e.RecType, e.L1 }, "02");

        //    entity.HasIndex(e => e.Cm1, "03");

        //    entity.HasIndex(e => e.C1, "04");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C10)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C11)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C12)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C13)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C14)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C15)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C16)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C17)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C18)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C19)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C20)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C21)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C22)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C23)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C24)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C25)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C26)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C27)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C28)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C29)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C30)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C6)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C7)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C8)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C9)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DocName)
        //        .HasMaxLength(35)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.FaVchName)
        //        .HasMaxLength(35)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.InvVchName)
        //        .HasMaxLength(35)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.M2)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //});

        //modelBuilder.Entity<DailyMessage>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("DailyMessage");

        //    entity.HasIndex(e => new { e.Date, e.VchType, e.Vscode }, "01");

        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Msg1)
        //        .HasMaxLength(96)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Msg2)
        //        .HasMaxLength(96)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Msg3)
        //        .HasMaxLength(96)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Msg4)
        //        .HasMaxLength(96)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Vscode).HasColumnName("VSCode");
        //});

        //modelBuilder.Entity<DailySum>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("DailySum");

        //    entity.HasIndex(e => e.MasterCode1, "11");

        //    entity.HasIndex(e => e.MasterCode2, "12");

        //    entity.HasIndex(e => e.Date, "13");

        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //});

        //modelBuilder.Entity<DataSync>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("DataSync");

        //    entity.HasIndex(e => new { e.BranchCode, e.RecType, e.ServerInTime }, "01");

        //    entity.Property(e => e.ApprovalTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ApprovedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ComputerName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CreatedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CreationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DeletedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DeletionTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.LastModificationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.LastModifiedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.M2)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.MasterName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.MasterName1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OldDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.OldIdentity)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.OldMasterName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OldVchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OldVchSrName)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ServerInTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Uid)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnName("UID");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchSrName)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Vmtype).HasColumnName("VMType");
        //});

        //modelBuilder.Entity<DeletedInfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("DeletedInfo");

        //    entity.HasIndex(e => new { e.Type, e.VchMastType, e.DeletionTime }, "01");

        //    entity.Property(e => e.ComputerName)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DeletedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DeletionTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Identity)
        //        .HasMaxLength(50)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<DeletedMaster>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.Name)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<EmpLadet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("EmpLADet");

        //    entity.HasIndex(e => e.EmpCode, "01");

        //    entity.HasIndex(e => e.Latype, "02");

        //    entity.HasIndex(e => e.SrNo, "03");

        //    entity.HasIndex(e => e.DueDate, "04");

        //    entity.Property(e => e.DueDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Latype).HasColumnName("LAType");
        //    entity.Property(e => e.Remarks)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<EventLog>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("EventLog");

        //    entity.HasIndex(e => e.UserName, "01");

        //    entity.HasIndex(e => e.Date, "02");

        //    entity.HasIndex(e => e.WorkedOn, "03");

        //    entity.HasIndex(e => e.Uid, "04");

        //    entity.HasIndex(e => e.SessionId, "05");

        //    entity.Property(e => e.ComputerName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Description)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.S1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Uid).HasColumnName("UID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VersionNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Excise>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Excise");

        //    entity.HasIndex(e => new { e.RecType, e.VchCode }, "01");

        //    entity.HasIndex(e => new { e.RecType, e.Date, e.ValueType, e.VchNo, e.VchCode }, "02");

        //    entity.Property(e => e.BankCode)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChallanNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DateOfDeposit)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DocName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.NotificationAvailed)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.NotificationNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PeriodEnding)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<ExternalDatum>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.HasIndex(e => new { e.KeyType, e.KeyCode }, "01");

        //    entity.Property(e => e.AppName)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C1)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Dt1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime")
        //        .HasColumnName("DT1");
        //});

        //modelBuilder.Entity<Folio1>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Folio1");

        //    entity.HasIndex(e => e.MasterCode, "01");
        //});

        //modelBuilder.Entity<GetGeneratedEwayBillDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("GetGeneratedEWayBillDet");

        //    entity.HasIndex(e => e.EwayBillNo, "01");

        //    entity.HasIndex(e => e.EwayBillDate, "02");

        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DeliveryPincode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DeliveryPlace)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DeliveryStateCode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DocDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DocNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.EwayBillDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime")
        //        .HasColumnName("EWayBillDate");
        //    entity.Property(e => e.EwayBillNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("EWayBillNo");
        //    entity.Property(e => e.FromGstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("FromGSTIN");
        //    entity.Property(e => e.FromTradeName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.GenByGstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GenByGSTIN");
        //    entity.Property(e => e.Hsncode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("HSNCode");
        //    entity.Property(e => e.Hsndesc)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("HSNDesc");
        //    entity.Property(e => e.ToGstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ToGSTIN");
        //    entity.Property(e => e.ToTradeName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Gstinfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("GSTInfo");

        //    entity.HasIndex(e => e.Date, "01");

        //    entity.HasIndex(e => e.VchCode, "02");

        //    entity.HasIndex(e => e.RecType, "03");

        //    entity.HasIndex(e => e.RecType, "04");

        //    entity.Property(e => e.AcessAmt).HasColumnName("ACessAmt");
        //    entity.Property(e => e.AcessPercent).HasColumnName("ACessPercent");
        //    entity.Property(e => e.BankAcNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BankAcType)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BankCode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BankName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cgstamt).HasColumnName("CGSTAmt");
        //    entity.Property(e => e.Cgstpercent).HasColumnName("CGSTPercent");
        //    entity.Property(e => e.ChallanDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ChallanNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChequeDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ChequeNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Description)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Igstamt).HasColumnName("IGSTAmt");
        //    entity.Property(e => e.Igstpercent).HasColumnName("IGSTPercent");
        //    entity.Property(e => e.Sgstamt).HasColumnName("SGSTAmt");
        //    entity.Property(e => e.Sgstpercent).HasColumnName("SGSTPercent");
        //});

        //modelBuilder.Entity<GstitcpendingVchDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("GSTITCPendingVchDet");

        //    entity.HasIndex(e => e.Gstin, "01");

        //    entity.HasIndex(e => e.VchNo, "02");

        //    entity.HasIndex(e => e.VchDate, "03");

        //    entity.HasIndex(e => e.ItcclaimedStatus, "04");

        //    entity.Property(e => e.BdstateCode).HasColumnName("BDStateCode");
        //    entity.Property(e => e.BdstateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("BDStateTinDigit");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Gstin)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTIN");
        //    entity.Property(e => e.Gstr2bmonth).HasColumnName("GSTR2BMonth");
        //    entity.Property(e => e.Gstr2bstatus).HasColumnName("GSTR2BStatus");
        //    entity.Property(e => e.Gstr2byear).HasColumnName("GSTR2BYear");
        //    entity.Property(e => e.GstrepBasis).HasColumnName("GSTRepBasis");
        //    entity.Property(e => e.Hsncode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("HSNCode");
        //    entity.Property(e => e.ItcclaimedMonth).HasColumnName("ITCClaimedMonth");
        //    entity.Property(e => e.ItcclaimedStatus).HasColumnName("ITCClaimedStatus");
        //    entity.Property(e => e.OrgVchDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.OrgVchNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PartyName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PartyStateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PosstateCode).HasColumnName("POSStateCode");
        //    entity.Property(e => e.PosstateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("POSStateTinDigit");
        //    entity.Property(e => e.Seno)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("SENo");
        //    entity.Property(e => e.Stptcode).HasColumnName("STPTCode");
        //    entity.Property(e => e.TaxOnMrp).HasColumnName("TaxOnMRP");
        //    entity.Property(e => e.VchDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Gstr1info>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("GSTR1Info");

        //    entity.HasIndex(e => e.Gstin, "01");

        //    entity.HasIndex(e => e.VchNo, "02");

        //    entity.HasIndex(e => e.Date, "03");

        //    entity.HasIndex(e => e.Month, "04");

        //    entity.HasIndex(e => e.Year, "05");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CFlag).HasColumnName("cFlag");
        //    entity.Property(e => e.CName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("cName");
        //    entity.Property(e => e.Cfs).HasColumnName("cfs");
        //    entity.Property(e => e.Cgst).HasColumnName("CGST");
        //    entity.Property(e => e.CheckSum)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.CompGstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CompGSTIN");
        //    entity.Property(e => e.CrDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.CrNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Desc)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DocTo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Docfrom)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Docnum).HasColumnName("docnum");
        //    entity.Property(e => e.FilDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime")
        //        .HasColumnName("filDate");
        //    entity.Property(e => e.FilType)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("filType");
        //    entity.Property(e => e.Flag)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("flag");
        //    entity.Property(e => e.Gstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTIN");
        //    entity.Property(e => e.Hsnsc)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("hsnsc");
        //    entity.Property(e => e.Igst).HasColumnName("IGST");
        //    entity.Property(e => e.InvType)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.Netissue).HasColumnName("netissue");
        //    entity.Property(e => e.Num).HasColumnName("num");
        //    entity.Property(e => e.PGst).HasColumnName("pGST");
        //    entity.Property(e => e.Pos)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("POS");
        //    entity.Property(e => e.Qty).HasColumnName("qty");
        //    entity.Property(e => e.Rchrg).HasColumnName("rchrg");
        //    entity.Property(e => e.Sgst).HasColumnName("SGST");
        //    entity.Property(e => e.SupplyType)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Totnum).HasColumnName("totnum");
        //    entity.Property(e => e.Type)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Updby)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("updby");
        //    entity.Property(e => e.Uqc)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("uqc");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Year)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Gstr2ainfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("GSTR2AInfo");

        //    entity.HasIndex(e => e.Gstin, "01");

        //    entity.HasIndex(e => e.VchNo, "02");

        //    entity.HasIndex(e => e.Date, "03");

        //    entity.HasIndex(e => e.Month, "04");

        //    entity.HasIndex(e => e.Year, "05");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cfs).HasColumnName("CFS");
        //    entity.Property(e => e.Cgst).HasColumnName("CGST");
        //    entity.Property(e => e.CheckSum)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.CompGstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CompGSTIN");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Gstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTIN");
        //    entity.Property(e => e.Igst).HasColumnName("IGST");
        //    entity.Property(e => e.InvType)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Itcavl).HasColumnName("ITCAvl");
        //    entity.Property(e => e.ItccessAmt).HasColumnName("ITCCessAmt");
        //    entity.Property(e => e.Itccgst).HasColumnName("ITCCGST");
        //    entity.Property(e => e.Itcelg)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ITCElg");
        //    entity.Property(e => e.Itcigst).HasColumnName("ITCIGST");
        //    entity.Property(e => e.Itcsgst).HasColumnName("ITCSGST");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.NoteDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.NoteNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OrgDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.OrgVchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Pos).HasColumnName("POS");
        //    entity.Property(e => e.Reason)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Sgst).HasColumnName("SGST");
        //    entity.Property(e => e.SupplierFilDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.SupplierPrd)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TradeName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Type)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Updby)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("updby");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Year)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Gstr2binfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("GSTR2BInfo");

        //    entity.HasIndex(e => e.Gstin, "01");

        //    entity.HasIndex(e => e.VchNo, "02");

        //    entity.HasIndex(e => e.Date, "03");

        //    entity.HasIndex(e => e.Month, "04");

        //    entity.HasIndex(e => e.Year, "05");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cfs).HasColumnName("CFS");
        //    entity.Property(e => e.Cgst).HasColumnName("CGST");
        //    entity.Property(e => e.CheckSum)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.CompGstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CompGSTIN");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Gstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTIN");
        //    entity.Property(e => e.Igst).HasColumnName("IGST");
        //    entity.Property(e => e.InvType)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Itcavl).HasColumnName("ITCAvl");
        //    entity.Property(e => e.ItccessAmt).HasColumnName("ITCCessAmt");
        //    entity.Property(e => e.Itccgst).HasColumnName("ITCCGST");
        //    entity.Property(e => e.Itcelg)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ITCElg");
        //    entity.Property(e => e.Itcigst).HasColumnName("ITCIGST");
        //    entity.Property(e => e.Itcsgst).HasColumnName("ITCSGST");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.NoteDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.NoteNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OrgDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.OrgVchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Pos).HasColumnName("POS");
        //    entity.Property(e => e.Reason)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Sgst).HasColumnName("SGST");
        //    entity.Property(e => e.SupplierFilDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.SupplierPrd)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TradeName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Type)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Updby)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("updby");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Year)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Gstr3binfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("GSTR3BInfo");

        //    entity.HasIndex(e => e.Gstin, "01");

        //    entity.HasIndex(e => e.Month, "02");

        //    entity.HasIndex(e => e.Year, "03");

        //    entity.HasIndex(e => e.RecType, "04");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cgst).HasColumnName("CGST");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Fee).HasColumnName("fee");
        //    entity.Property(e => e.Gstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTIN");
        //    entity.Property(e => e.Igst).HasColumnName("IGST");
        //    entity.Property(e => e.LdgId).HasColumnName("ldgID");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.Pos)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("POS");
        //    entity.Property(e => e.Sgst).HasColumnName("SGST");
        //    entity.Property(e => e.Tax).HasColumnName("tax");
        //    entity.Property(e => e.Type)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Year)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Help1>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Help1");

        //    entity.HasIndex(e => e.MasterSeries, "11");

        //    entity.HasIndex(e => e.RecType, "16");

        //    entity.HasIndex(e => e.Status, "21");

        //    entity.HasIndex(e => e.NameAlias, "26");

        //    entity.HasIndex(e => e.MasterType, "31");

        //    entity.HasIndex(e => e.NameOrAlias, "36");

        //    entity.HasIndex(e => e.Code, "41");

        //    entity.HasIndex(e => e.AdditionalInfo, "46");

        //    entity.HasIndex(e => new { e.NameOrAlias, e.Code }, "81");

        //    entity.HasIndex(e => new { e.MasterSeries, e.RecType, e.Status, e.NameAlias }, "82");

        //    entity.Property(e => e.AdditionalInfo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AddnInfoBt1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AddnInfoBt2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AddnInfoBt3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AddnInfoBt4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DefaultMccode).HasColumnName("DefaultMCCode");
        //    entity.Property(e => e.NameAlias)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Help1AddnInfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Help1AddnInfo");

        //    entity.HasIndex(e => e.Code, "21");

        //    entity.HasIndex(e => e.NameAlias, "22");

        //    entity.HasIndex(e => e.NameOrAlias, "23");

        //    entity.Property(e => e.AddnInfoBt1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AddnInfoBt2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AddnInfoBt3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AddnInfoBt4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.NameAlias)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Help2>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Help2");

        //    entity.HasIndex(e => new { e.RecType1, e.RecType2, e.RecType3, e.Name }, "01");

        //    entity.Property(e => e.Name)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Image>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.HasIndex(e => e.Code, "01");

        //    entity.HasIndex(e => e.Type, "02");

        //    entity.Property(e => e.FormatType1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.FormatType2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Image1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("image");
        //    entity.Property(e => e.Image2)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("image");
        //});

        //modelBuilder.Entity<ItemDesc>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("ItemDesc");

        //    entity.HasIndex(e => new { e.VchCode, e.SrNo }, "01");

        //    entity.Property(e => e.Desc1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc10)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc11)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc12)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc13)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc14)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc15)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc16)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc17)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc18)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc19)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc1Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Desc1SL");
        //    entity.Property(e => e.Desc2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc20)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc2Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Desc2SL");
        //    entity.Property(e => e.Desc3)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc3Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Desc3SL");
        //    entity.Property(e => e.Desc4)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc4Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Desc4SL");
        //    entity.Property(e => e.Desc5)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc6)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc7)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc8)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Desc9)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<ItemParamDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("ItemParamDet");

        //    entity.HasIndex(e => new { e.VchCode, e.VchItemSn, e.SrNo }, "01");

        //    entity.HasIndex(e => new { e.ItemCode, e.Mccode, e.VchCode, e.RecType, e.VchItemSn, e.SrNo }, "02");

        //    entity.HasIndex(e => new { e.RecType, e.ItemCode, e.Mccode, e.Date, e.C1, e.C2, e.C3, e.Value1, e.D3 }, "03");

        //    entity.HasIndex(e => e.Bcn, "04");

        //    entity.HasIndex(e => new { e.Bcn, e.VchCode }, "06");

        //    entity.HasIndex(e => new { e.Bcn, e.Value1, e.Mccode }, "07");

        //    entity.Property(e => e.AutoBcn).HasColumnName("AutoBCN");
        //    entity.Property(e => e.Bcn)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("BCN");
        //    entity.Property(e => e.C1)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C10)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C11)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C12)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C13)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C6)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C7)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C8)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C9)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Mccode).HasColumnName("MCCode");
        //    entity.Property(e => e.OrgDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.VchItemSn).HasColumnName("VchItemSN");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<ItemSerialNo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("ItemSerialNo");

        //    entity.HasIndex(e => new { e.ItemCode, e.SerialNo, e.Date, e.VchType, e.VchNo, e.VchCode }, "01");

        //    entity.HasIndex(e => new { e.VchCode, e.VchItemSn, e.GridSn }, "02");

        //    entity.HasIndex(e => new { e.ItemCode, e.Mccode, e.SerialNo, e.Value1, e.Date, e.VchCode }, "03");

        //    entity.HasIndex(e => new { e.ItemCode, e.SerialNo, e.Value1, e.Date, e.VchCode }, "04");

        //    entity.HasIndex(e => new { e.ItemCode, e.Mccode, e.VchCode, e.VchItemSn, e.GridSn, e.SerialNo }, "05");

        //    entity.HasIndex(e => new { e.ItemCode, e.Value1, e.Date, e.VchType, e.VchCode, e.VchItemSn, e.GridSn, e.SerialNo }, "06");

        //    entity.HasIndex(e => new { e.ItemCode, e.VchType, e.VchCode, e.AutoSrNo }, "07");

        //    entity.HasIndex(e => new { e.ItemCode, e.Mccode, e.VchCode, e.SerialNo, e.Value1 }, "08");

        //    entity.HasIndex(e => new { e.ItemCode, e.Mccode, e.SerialNo, e.Value1 }, "09");

        //    entity.HasIndex(e => new { e.ItemCode, e.AutoSrNo }, "10");

        //    entity.HasIndex(e => new { e.ItemCode, e.Date, e.AutoSrNo }, "11");

        //    entity.HasIndex(e => new { e.ItemCode, e.MonthVal, e.AutoSrNo }, "12");

        //    entity.HasIndex(e => new { e.SerialNo, e.Value1, e.Mccode }, "13");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C10)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C6)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C7)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C8)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C9)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.GridSn).HasColumnName("GridSN");
        //    entity.Property(e => e.Mccode).HasColumnName("MCCode");
        //    entity.Property(e => e.SerialNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchItemSn).HasColumnName("VchItemSN");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<ItemSninstallDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("ItemSNInstallDet");

        //    entity.HasIndex(e => new { e.ItemCode, e.SerialNo }, "01");

        //    entity.HasIndex(e => e.InstallCode, "02");

        //    entity.HasIndex(e => e.PartyCode, "03");

        //    entity.HasIndex(e => e.CountryCode, "04");

        //    entity.HasIndex(e => e.StateCode, "05");

        //    entity.HasIndex(e => e.CityCode, "06");

        //    entity.Property(e => e.Address1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ContactPerson)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Designation)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.EmailId)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("EmailID");
        //    entity.Property(e => e.FaxNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.InstallDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.InvoiceDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.InvoiceNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.MobileNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Narration)
        //        .HasMaxLength(94)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Organization)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PhoneNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PinCode)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.SerialNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TradeDesc)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<JobFinishedRef>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.HasIndex(e => e.MasterCode1, "01");

        //    entity.HasIndex(e => e.JobId, "02");

        //    entity.HasIndex(e => e.Date, "03");

        //    entity.HasIndex(e => e.Cm1, "04");

        //    entity.HasIndex(e => e.TranType, "05");

        //    entity.HasIndex(e => e.VchType, "06");

        //    entity.HasIndex(e => e.MasterCode2, "07");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.JobId)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("JobID");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Lock>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.Areamast).HasColumnName("AREAMAST");
        //    entity.Property(e => e.Batch).HasColumnName("BATCH");
        //    entity.Property(e => e.Batchmrpsrnoparam).HasColumnName("BATCHMRPSRNOPARAM");
        //    entity.Property(e => e.Brs).HasColumnName("BRS");
        //    entity.Property(e => e.Bsnf).HasColumnName("BSNF");
        //    entity.Property(e => e.Bsstd).HasColumnName("BSSTD");
        //    entity.Property(e => e.Bst).HasColumnName("BST");
        //    entity.Property(e => e.Cccf).HasColumnName("CCCF");
        //    entity.Property(e => e.Challanno).HasColumnName("CHALLANNO");
        //    entity.Property(e => e.CompanyName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Compcontgrpmast).HasColumnName("COMPCONTGRPMAST");
        //    entity.Property(e => e.Compegrpmast).HasColumnName("COMPEGRPMAST");
        //    entity.Property(e => e.Contdeptmast).HasColumnName("CONTDEPTMAST");
        //    entity.Property(e => e.Csu).HasColumnName("CSU");
        //    entity.Property(e => e.Dfyw).HasColumnName("DFYW");
        //    entity.Property(e => e.Entrytaxrate).HasColumnName("ENTRYTAXRATE");
        //    entity.Property(e => e.Faqgrpmast).HasColumnName("FAQGRPMAST");
        //    entity.Property(e => e.Gstu).HasColumnName("GSTU");
        //    entity.Property(e => e.Ibr).HasColumnName("IBR");
        //    entity.Property(e => e.Major).HasColumnName("MAJOR");
        //    entity.Property(e => e.Mastfp).HasColumnName("MASTFP");
        //    entity.Property(e => e.Mastfp1).HasColumnName("MASTFP1");
        //    entity.Property(e => e.Mbu).HasColumnName("MBU");
        //    entity.Property(e => e.Mebr).HasColumnName("MEBR");
        //    entity.Property(e => e.Mebr1).HasColumnName("MEBR1");
        //    entity.Property(e => e.Mffsa).HasColumnName("MFFSA");
        //    entity.Property(e => e.Minor).HasColumnName("MINOR");
        //    entity.Property(e => e.Muspo).HasColumnName("MUSPO");
        //    entity.Property(e => e.Nxtactionmast).HasColumnName("NXTACTIONMAST");
        //    entity.Property(e => e.Obamc).HasColumnName("OBAMC");
        //    entity.Property(e => e.Ospo).HasColumnName("OSPO");
        //    entity.Property(e => e.Paramdet).HasColumnName("PARAMDET");
        //    entity.Property(e => e.Pendsubstatusmast).HasColumnName("PENDSUBSTATUSMAST");
        //    entity.Property(e => e.Piipd)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("PIIPD");
        //    entity.Property(e => e.Posseriesftbsname).HasColumnName("POSSERIESFTBSNAME");
        //    entity.Property(e => e.Rgmast).HasColumnName("RGMAST");
        //    entity.Property(e => e.Rmvlocdb).HasColumnName("RMVLOCDB");
        //    entity.Property(e => e.Rw35).HasColumnName("RW35");
        //    entity.Property(e => e.Smpl).HasColumnName("SMPL");
        //    entity.Property(e => e.Sourcemast).HasColumnName("SOURCEMAST");
        //    entity.Property(e => e.Stptmc).HasColumnName("STPTMC");
        //    entity.Property(e => e.Stscgupdt).HasColumnName("STSCGUPDT");
        //    entity.Property(e => e.Stu).HasColumnName("STU");
        //    entity.Property(e => e.Substatusmast).HasColumnName("SUBSTATUSMAST");
        //    entity.Property(e => e.Tdsshe).HasColumnName("TDSSHE");
        //    entity.Property(e => e.Terbr).HasColumnName("TERBR");
        //    entity.Property(e => e.Tesrno).HasColumnName("TESRNO");
        //    entity.Property(e => e.Tofq).HasColumnName("TOFQ");
        //    entity.Property(e => e.Trackingno).HasColumnName("TRACKINGNO");
        //    entity.Property(e => e.Trademast).HasColumnName("TRADEMAST");
        //    entity.Property(e => e.Type)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.UrefBal).HasColumnName("URefBal");
        //    entity.Property(e => e.WinUser)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<MastFootPrint>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("MastFootPrint");

        //    entity.HasIndex(e => e.MasterCode, "01");

        //    entity.HasIndex(e => new { e.MasterType, e.Name }, "02");

        //    entity.Property(e => e.Name)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PartialFp)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("PartialFP");
        //    entity.Property(e => e.RemainFp)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("RemainFP");
        //});

        //modelBuilder.Entity<Master1>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Master1");

        //    entity.HasIndex(e => e.Code, "01").IsUnique();

        //    entity.HasIndex(e => new { e.MasterType, e.Name }, "02");

        //    entity.HasIndex(e => new { e.MasterType, e.Alias }, "03");

        //    entity.HasIndex(e => e.Cm1, "04");

        //    entity.HasIndex(e => e.Cm2, "05");

        //    entity.HasIndex(e => e.Cm3, "06");

        //    entity.HasIndex(e => e.Cm4, "07");

        //    entity.HasIndex(e => e.Cm5, "08");

        //    entity.HasIndex(e => e.Cm6, "17");

        //    entity.HasIndex(e => e.Cm7, "18");

        //    entity.HasIndex(e => e.Cm8, "20");

        //    entity.HasIndex(e => e.MasterType, "31");

        //    entity.HasIndex(e => e.Name, "32");

        //    entity.HasIndex(e => e.Alias, "33");

        //    entity.HasIndex(e => e.ParentGrp, "34");

        //    entity.HasIndex(e => e.D11, "35");

        //    entity.HasIndex(e => e.C2, "36");

        //    entity.HasIndex(e => e.SyncStatus, "37");

        //    entity.HasIndex(e => e.Source, "38");

        //    entity.HasIndex(e => e.I10, "39");

        //    entity.HasIndex(e => e.Cm9, "40");

        //    entity.HasIndex(e => e.Cm10, "41");

        //    entity.HasIndex(e => e.Cm11, "42");

        //    entity.HasIndex(e => e.I17, "43");

        //    entity.HasIndex(e => e.I18, "44");

        //    entity.Property(e => e.Alias)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.AliasSl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("AliasSL");
        //    entity.Property(e => e.AuthorisationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.AuthorisedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BlockedNotes)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.BlockedVchType)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C1)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C6)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm10).HasColumnName("CM10");
        //    entity.Property(e => e.Cm11).HasColumnName("CM11");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.Cm6).HasColumnName("CM6");
        //    entity.Property(e => e.Cm7).HasColumnName("CM7");
        //    entity.Property(e => e.Cm8).HasColumnName("CM8");
        //    entity.Property(e => e.Cm9).HasColumnName("CM9");
        //    entity.Property(e => e.CreatedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CreationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Hsncode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("HSNCode");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.M2)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.MasterNotes)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.MasterSeriesGrp)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.ModificationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ModifiedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Name)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.NameSl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("NameSL");
        //    entity.Property(e => e.Notes1)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Notes2)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OldIdentity)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.PrintName)
        //        .HasMaxLength(60)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PrintNameSl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("PrintNameSL");
        //    entity.Property(e => e.SelfImageLink)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.SelfImageName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Seno)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("SENO");
        //    entity.Property(e => e.Tpf1).HasColumnName("TPF1");
        //    entity.Property(e => e.Tpf2).HasColumnName("TPF2");
        //});

        //modelBuilder.Entity<MasterAddressInfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("MasterAddressInfo");

        //    entity.HasIndex(e => e.MasterCode, "01").IsUnique();

        //    entity.HasIndex(e => e.CountryCodeLong, "02");

        //    entity.HasIndex(e => e.StateCodeLong, "03");

        //    entity.HasIndex(e => e.CityCodeLong, "04");

        //    entity.HasIndex(e => e.RegionCodeLong, "05");

        //    entity.HasIndex(e => e.Mobile, "06");

        //    entity.HasIndex(e => e.Email, "07");

        //    entity.HasIndex(e => e.Itpan, "08");

        //    entity.Property(e => e.AccNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address1Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address1SL");
        //    entity.Property(e => e.Address2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address2Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address2SL");
        //    entity.Property(e => e.Address3)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address3Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address3SL");
        //    entity.Property(e => e.Address4)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Address4Sl)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("Address4SL");
        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C10)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C6)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C7)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C8)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C9)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Collectorate)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Contact)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cst)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CST");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date3)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date4)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date5)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date6)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date7)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date8)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Division)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Dlno)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("DLNo");
        //    entity.Property(e => e.Dlno2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("DLNo2");
        //    entity.Property(e => e.Ecccode)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ECCCode");
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ExciseRegNo)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Fax)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Gstno)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTNo");
        //    entity.Property(e => e.Itpan)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ITPAN");
        //    entity.Property(e => e.Itward)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ITWard");
        //    entity.Property(e => e.Lbtno)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("LBTNo");
        //    entity.Property(e => e.Lst)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("LST");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.Mobile)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Of1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF1");
        //    entity.Property(e => e.Of10)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF10");
        //    entity.Property(e => e.Of2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF2");
        //    entity.Property(e => e.Of3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF3");
        //    entity.Property(e => e.Of4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF4");
        //    entity.Property(e => e.Of5)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF5");
        //    entity.Property(e => e.Of6)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF6");
        //    entity.Property(e => e.Of7)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF7");
        //    entity.Property(e => e.Of8)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF8");
        //    entity.Property(e => e.Of9)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF9");
        //    entity.Property(e => e.Pincode)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("PINCode");
        //    entity.Property(e => e.Plano)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("PLANo");
        //    entity.Property(e => e.Range)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ServiceTaxNo)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.St37)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("ST37");
        //    entity.Property(e => e.Station)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.SupplierType)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TelNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TelNoResi)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Tinno)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("TINNo");
        //    entity.Property(e => e.Transport)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.WhatsAppNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<MasterSupport>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("MasterSupport");

        //    entity.HasIndex(e => e.Cm2, "03");

        //    entity.HasIndex(e => e.Cm3, "04");

        //    entity.HasIndex(e => e.MasterCode, "11");

        //    entity.HasIndex(e => e.Cm1, "12");

        //    entity.HasIndex(e => e.MasterType, "13");

        //    entity.HasIndex(e => e.Date, "14");

        //    entity.HasIndex(e => e.I1, "15");

        //    entity.HasIndex(e => e.I2, "16");

        //    entity.HasIndex(e => e.C1, "17");

        //    entity.HasIndex(e => e.RecType, "18");

        //    entity.HasIndex(e => e.Date1, "19");

        //    entity.HasIndex(e => e.Cm4, "20");

        //    entity.HasIndex(e => e.Cm5, "21");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.Cm6).HasColumnName("CM6");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date3)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //});

        //modelBuilder.Entity<Oeddet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("OEDDet");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.Property(e => e.HecessAmount).HasColumnName("HECessAmount");
        //    entity.Property(e => e.HecessRate).HasColumnName("HECessRate");
        //    entity.Property(e => e.Oedamount).HasColumnName("OEDAmount");
        //    entity.Property(e => e.Oedrate).HasColumnName("OEDRate");
        //});

        //modelBuilder.Entity<OrgSalePurc>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("OrgSalePurc");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.Property(e => e.VchDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<PackingDetail>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.HasIndex(e => e.SrNo, "01");

        //    entity.HasIndex(e => e.PackageNo, "02");

        //    entity.HasIndex(e => e.VchCode, "03");

        //    entity.HasIndex(e => e.Unit, "04");

        //    entity.Property(e => e.Description)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.MarkaNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PackageNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PackingMode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Remarks)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Size)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Patch>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.Property(e => e.BcnaltQty).HasColumnName("BCNAltQty");
        //    entity.Property(e => e.ConfigEwayBill).HasColumnName("ConfigEWayBill");
        //    entity.Property(e => e.ConfigUae).HasColumnName("ConfigUAE");
        //    entity.Property(e => e.CrsalesDefaultSeries).HasColumnName("CRSalesDefaultSeries");
        //    entity.Property(e => e.Dufbaf).HasColumnName("DUFBAF");
        //    entity.Property(e => e.Dufitc).HasColumnName("DUFITC");
        //    entity.Property(e => e.Ewaybill).HasColumnName("EWAYBILL");
        //    entity.Property(e => e.Ewaybillconfig).HasColumnName("EWAYBILLCONFIG");
        //    entity.Property(e => e.GroupParamOnSp).HasColumnName("GroupParamOnSP");
        //    entity.Property(e => e.GstadvanceAmt).HasColumnName("GSTAdvanceAmt");
        //    entity.Property(e => e.GstpurcBillNo).HasColumnName("GSTPurcBillNo");
        //    entity.Property(e => e.GstsumItemWiseFields).HasColumnName("GSTSumItemWiseFields");
        //    entity.Property(e => e.ImpactBssalePurc).HasColumnName("ImpactBSSalePurc");
        //    entity.Property(e => e.ItemMastTreatMrpasSp).HasColumnName("ItemMastTreatMRPAsSP");
        //    entity.Property(e => e.Itembcn).HasColumnName("ITEMBCN");
        //    entity.Property(e => e.Itemspacc).HasColumnName("ITEMSPACC");
        //    entity.Property(e => e.Mbo).HasColumnName("MBO");
        //    entity.Property(e => e.MrpnegativeStockWarning).HasColumnName("MRPNegativeStockWarning");
        //    entity.Property(e => e.Pdct3).HasColumnName("PDCT3");
        //    entity.Property(e => e.PirdiscAmt).HasColumnName("PIRDiscAmt");
        //    entity.Property(e => e.PositemAliasFld).HasColumnName("POSItemAliasFld");
        //    entity.Property(e => e.Pusjmc).HasColumnName("PUSJMC");
        //    entity.Property(e => e.Qlfld).HasColumnName("QLFld");
        //    entity.Property(e => e.Rcmpurc).HasColumnName("RCMPURC");
        //    entity.Property(e => e.Resavegstr1json).HasColumnName("RESAVEGSTR1JSON");
        //    entity.Property(e => e.Spacc).HasColumnName("SPACC");
        //    entity.Property(e => e.TemcwiseRef).HasColumnName("TEMCWiseRef");
        //    entity.Property(e => e.Ufoesa).HasColumnName("UFOESA");
        //    entity.Property(e => e.Ufrd).HasColumnName("UFRD");
        //    entity.Property(e => e.Ufsu).HasColumnName("UFSU");
        //    entity.Property(e => e.Uftcstds).HasColumnName("UFTCSTDS");
        //    entity.Property(e => e.Uftdscat).HasColumnName("UFTDSCAT");
        //    entity.Property(e => e.Umb1).HasColumnName("UMB1");
        //    entity.Property(e => e.Umbdb1).HasColumnName("UMBDB1");
        //    entity.Property(e => e.Umbsv).HasColumnName("UMBSV");
        //    entity.Property(e => e.Unitinhsn).HasColumnName("UNITINHSN");
        //    entity.Property(e => e.UpdateRcmaccTaxType).HasColumnName("UpdateRCMAccTaxType");
        //    entity.Property(e => e.UpdateStateAndTypeOfDealerInVchGst).HasColumnName("UpdateStateAndTypeOfDealerInVchGST");
        //    entity.Property(e => e.UpgradeForStptinHelp1).HasColumnName("UpgradeForSTPTinHelp1");
        //    entity.Property(e => e.Upguae).HasColumnName("UPGUAE");
        //    entity.Property(e => e.Uvgs).HasColumnName("UVGS");
        //    entity.Property(e => e.VchGstsumItemWiseLocType).HasColumnName("VchGSTSumItemWiseLocType");
        //});

        //modelBuilder.Entity<PhyStkSubDet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("PhyStkSubDet");

        //    entity.HasIndex(e => e.MasterCode1, "01");

        //    entity.HasIndex(e => e.MasterCode2, "02");

        //    entity.HasIndex(e => e.Date, "03");

        //    entity.HasIndex(e => e.VchType, "04");

        //    entity.HasIndex(e => e.VchCode, "05");

        //    entity.HasIndex(e => e.RecType, "06");

        //    entity.HasIndex(e => e.SrNo, "07");

        //    entity.HasIndex(e => e.No, "08");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C10)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C6)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C7)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C8)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C9)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DueDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.MfgDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.No)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.OrgDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Posdet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("POSDet");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.Property(e => e.CashNarr)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CcaccCode1).HasColumnName("CCAccCode1");
        //    entity.Property(e => e.CcaccCode2).HasColumnName("CCAccCode2");
        //    entity.Property(e => e.CcaccCode3).HasColumnName("CCAccCode3");
        //    entity.Property(e => e.Ccamt1).HasColumnName("CCAmt1");
        //    entity.Property(e => e.Ccamt2).HasColumnName("CCAmt2");
        //    entity.Property(e => e.Ccamt3).HasColumnName("CCAmt3");
        //    entity.Property(e => e.Ccnarr1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CCNarr1");
        //    entity.Property(e => e.Ccnarr2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CCNarr2");
        //    entity.Property(e => e.Ccnarr3)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("CCNarr3");
        //    entity.Property(e => e.ChequeNarr)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<QueryLog>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("QueryLog");

        //    entity.HasIndex(e => e.Date, "01");

        //    entity.HasIndex(e => e.RecType, "02");

        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ErrStr)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.Qry)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<RepColSize>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("RepColSize");

        //    entity.HasIndex(e => e.RepId, "01");

        //    entity.HasIndex(e => new { e.RepId, e.SubId }, "02");

        //    entity.Property(e => e.ColId).HasColumnName("ColID");
        //    entity.Property(e => e.CustomRepFormatName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.FormatName)
        //        .HasMaxLength(35)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.RepId).HasColumnName("RepID");
        //    entity.Property(e => e.SubId).HasColumnName("SubID");
        //});

        //modelBuilder.Entity<RepOptValue>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.HasIndex(e => new { e.RepId, e.ReportType }, "01");

        //    entity.Property(e => e.FieldId).HasColumnName("FieldID");
        //    entity.Property(e => e.FieldValue)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.FormatName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.RepId).HasColumnName("RepID");
        //    entity.Property(e => e.SubRepId).HasColumnName("SubRepID");
        //    entity.Property(e => e.Value)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<ReportNote>(entity =>
        //{
        //    entity.HasNoKey();

        //    entity.HasIndex(e => e.NoteId, "01");

        //    entity.HasIndex(e => e.RepId, "02");

        //    entity.HasIndex(e => e.SubRepId, "03");

        //    entity.HasIndex(e => e.NoteRepId, "04");

        //    entity.HasIndex(e => e.MasterCode, "05");

        //    entity.HasIndex(e => e.UserName, "06");

        //    entity.HasIndex(e => e.Date, "07");

        //    entity.HasIndex(e => e.NotesCarried, "08");

        //    entity.HasIndex(e => e.FinYear, "09");

        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Description)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.FinYear)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.NoteId).HasColumnName("NoteID");
        //    entity.Property(e => e.NoteRepId).HasColumnName("NoteRepID");
        //    entity.Property(e => e.RepId).HasColumnName("RepID");
        //    entity.Property(e => e.SubRepId).HasColumnName("SubRepID");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Stdet>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("STDet");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.Property(e => e.Kkcrate).HasColumnName("KKCRate");
        //    entity.Property(e => e.Sbcrate).HasColumnName("SBCRate");
        //    entity.Property(e => e.StassValue).HasColumnName("STAssValue");
        //    entity.Property(e => e.Stcategory).HasColumnName("STCategory");
        //    entity.Property(e => e.StcessRate).HasColumnName("STCessRate");
        //    entity.Property(e => e.SthecessRate).HasColumnName("STHECessRate");
        //    entity.Property(e => e.Strate).HasColumnName("STRate");
        //});

        //modelBuilder.Entity<Tc>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("TCS");

        //    entity.HasIndex(e => e.MasterCode2, "01");

        //    entity.HasIndex(e => e.Method, "02");

        //    entity.HasIndex(e => e.EntryDate, "03");

        //    entity.HasIndex(e => e.VchCode, "04");

        //    entity.HasIndex(e => e.MasterCode1, "05");

        //    entity.HasIndex(e => e.RefNo, "06");

        //    entity.HasIndex(e => e.SrNo, "07");

        //    entity.HasIndex(e => e.RefCode, "08");

        //    entity.HasIndex(e => e.RecType, "09");

        //    entity.Property(e => e.Bsrcode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("BSRCode");
        //    entity.Property(e => e.CategoryCode)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChallanNo)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChequeDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ChequeNo)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DateOfCredit)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.EntryDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Reason)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.RefNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.SubCategoryCode)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Tcsamt).HasColumnName("TCSAmt");
        //    entity.Property(e => e.Tcsrate).HasColumnName("TCSRate");
        //});

        //modelBuilder.Entity<Td>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("TDS");

        //    entity.HasIndex(e => new { e.MasterCode2, e.Method, e.EntryDate, e.VchCode }, "01");

        //    entity.HasIndex(e => new { e.MasterCode1, e.Method, e.RefNo }, "02");

        //    entity.HasIndex(e => new { e.VchCode, e.MasterCode1, e.SrNo }, "03");

        //    entity.HasIndex(e => new { e.RefCode, e.Method }, "04");

        //    entity.HasIndex(e => e.RecType, "05");

        //    entity.Property(e => e.Bsrcode)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("BSRCode");
        //    entity.Property(e => e.CertificateNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChallanNo)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChequeDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ChequeNo)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DateOfCredit)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.EntryDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Reason)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.RefNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ShecessAmt).HasColumnName("SHECessAmt");
        //    entity.Property(e => e.ShecessRate).HasColumnName("SHECessRate");
        //    entity.Property(e => e.Tdsamt).HasColumnName("TDSAmt");
        //    entity.Property(e => e.Tdsrate).HasColumnName("TDSRate");
        //});

        //modelBuilder.Entity<TradingExcise>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("TradingExcise");

        //    entity.HasIndex(e => new { e.RefCode, e.Method, e.Date, e.VchType, e.VchNo, e.VchCode }, "01");

        //    entity.HasIndex(e => new { e.ItemCode, e.Method, e.Status }, "02");

        //    entity.HasIndex(e => new { e.ItemCode, e.Method, e.RefNo }, "03");

        //    entity.HasIndex(e => new { e.VchCode, e.ItemCode, e.SrNo }, "04");

        //    entity.HasIndex(e => new { e.VchCode, e.ItemCode, e.RefNo }, "05");

        //    entity.HasIndex(e => new { e.Mccode, e.ItemCode, e.Method, e.Status }, "06");

        //    entity.HasIndex(e => new { e.Mccode, e.ItemCode, e.Method, e.RefNo }, "07");

        //    entity.HasIndex(e => new { e.VchCode, e.Mccode, e.ItemCode, e.SrNo }, "08");

        //    entity.HasIndex(e => new { e.VchCode, e.Mccode, e.ItemCode, e.RefNo }, "09");

        //    entity.HasIndex(e => new { e.AutoRg23dpageNo, e.AutoRg23dsrNo }, "10");

        //    entity.HasIndex(e => new { e.Mccode, e.AutoRg23dpageNo, e.AutoRg23dsrNo }, "11");

        //    entity.Property(e => e.AutoRg23dpageNo).HasColumnName("AutoRG23DPageNo");
        //    entity.Property(e => e.AutoRg23dsrNo).HasColumnName("AutoRG23DSrNo");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Mccode).HasColumnName("MCCode");
        //    entity.Property(e => e.MfrBillDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.MfrBillNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.MfrGoodsRemovalDateTime)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.MfrInvoicePrepDateTime)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.RefNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Rg23dpageNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("RG23DPageNo");
        //    entity.Property(e => e.Rg23dsrNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("RG23DSrNo");
        //    entity.Property(e => e.SuppRg23dpageNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("SuppRG23DPageNo");
        //    entity.Property(e => e.SuppRg23dsrNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("SuppRG23DSrNo");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran1>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran1");

        //    entity.HasIndex(e => e.VchCode, "01").IsUnique();

        //    entity.HasIndex(e => e.MasterCode1, "02");

        //    entity.HasIndex(e => e.MasterCode2, "03");

        //    entity.HasIndex(e => e.Cm5, "19");

        //    entity.HasIndex(e => e.Date, "21");

        //    entity.HasIndex(e => e.VchType, "22");

        //    entity.HasIndex(e => e.VchNo, "23");

        //    entity.HasIndex(e => e.VchSeriesCode, "24");

        //    entity.HasIndex(e => e.Cm1, "26");

        //    entity.HasIndex(e => e.Cm2, "27");

        //    entity.HasIndex(e => e.Cm3, "28");

        //    entity.HasIndex(e => e.Cm4, "29");

        //    entity.HasIndex(e => e.AutoGeneratedType, "30");

        //    entity.HasIndex(e => e.StockUpdationDate, "31");

        //    entity.HasIndex(e => e.SyncStatus, "32");

        //    entity.HasIndex(e => e.Source, "33");

        //    entity.HasIndex(e => e.Cm7, "34");

        //    entity.HasIndex(e => e.TranType, "35");

        //    entity.HasIndex(e => e.GstrecType, "36");

        //    entity.HasIndex(e => new { e.VchType, e.Date }, "62");

        //    entity.HasIndex(e => new { e.VchSeriesCode, e.AutoVchNo }, "63");

        //    entity.HasIndex(e => new { e.VchSeriesCode, e.Date, e.VchNo }, "64");

        //    entity.HasIndex(e => e.ConsignmentType, "65");

        //    entity.Property(e => e.AuthorisationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.AuthorisedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BusyDocLink)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BusyDocName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("c1");
        //    entity.Property(e => e.CheckSum)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.Cm6).HasColumnName("CM6");
        //    entity.Property(e => e.Cm7).HasColumnName("CM7");
        //    entity.Property(e => e.CreatedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CreationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.EinvAckDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime")
        //        .HasColumnName("EInvAckDate");
        //    entity.Property(e => e.EinvAckNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("EInvAckNo");
        //    entity.Property(e => e.EinvIrn)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("EInvIRN");
        //    entity.Property(e => e.EinvSignedInvoice)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("EInvSignedInvoice");
        //    entity.Property(e => e.EinvSignedInvoice2)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("EInvSignedInvoice2");
        //    entity.Property(e => e.EinvSignedInvoice3)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("EInvSignedInvoice3");
        //    entity.Property(e => e.EinvSignedInvoice4)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("EInvSignedInvoice4");
        //    entity.Property(e => e.EinvSignedInvoice5)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("EInvSignedInvoice5");
        //    entity.Property(e => e.EinvSignedQrcode)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext")
        //        .HasColumnName("EInvSignedQRCode");
        //    entity.Property(e => e.ExciseDocName)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ExtraExpenseNar1)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ExtraExpenseNar2)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Gstinfo).HasColumnName("GSTInfo");
        //    entity.Property(e => e.Gstr2bmonth).HasColumnName("GSTR2BMonth");
        //    entity.Property(e => e.Gstr2bstatus).HasColumnName("GSTR2BStatus");
        //    entity.Property(e => e.Gstr2byear).HasColumnName("GSTR2BYear");
        //    entity.Property(e => e.Gstr2status).HasColumnName("GSTR2Status");
        //    entity.Property(e => e.GstrecType).HasColumnName("GSTRecType");
        //    entity.Property(e => e.GstrepBasis).HasColumnName("GSTRepBasis");
        //    entity.Property(e => e.ItcclaimedMonth).HasColumnName("ITCClaimedMonth");
        //    entity.Property(e => e.ItcclaimedStatus).HasColumnName("ITCClaimedStatus");
        //    entity.Property(e => e.ModificationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ModifiedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.NepaliDate)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.NepaliFy)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("NepaliFY");
        //    entity.Property(e => e.OldIdentity)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.Posenabled).HasColumnName("POSEnabled");
        //    entity.Property(e => e.SelfImageLink)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.SelfImageName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.SourceDet)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Stapplicable).HasColumnName("STApplicable");
        //    entity.Property(e => e.StockUpdationDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Sttype).HasColumnName("STType");
        //    entity.Property(e => e.SyncWithIrd).HasColumnName("SyncWithIRD");
        //    entity.Property(e => e.Tcsapplicable).HasColumnName("TCSApplicable");
        //    entity.Property(e => e.Tdsapplicable).HasColumnName("TDSApplicable");
        //    entity.Property(e => e.Teapplicable).HasColumnName("TEApplicable");
        //    entity.Property(e => e.Tpf1).HasColumnName("TPF1");
        //    entity.Property(e => e.Tpf2).HasColumnName("TPF2");
        //    entity.Property(e => e.Vatinfo).HasColumnName("VATInfo");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran10>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran10");

        //    entity.HasIndex(e => e.MasterCode1, "01");

        //    entity.HasIndex(e => e.MasterCode2, "02");

        //    entity.HasIndex(e => e.VchType, "03");

        //    entity.HasIndex(e => e.C1, "04");

        //    entity.HasIndex(e => e.MasterCode3, "05");

        //    entity.HasIndex(e => e.Date, "06");

        //    entity.HasIndex(e => e.RecType, "08");

        //    entity.HasIndex(e => e.C6, "09");

        //    entity.HasIndex(e => new { e.RecType, e.MasterCode1 }, "11");

        //    entity.HasIndex(e => new { e.RecType, e.MasterCode2 }, "12");

        //    entity.HasIndex(e => new { e.RecType, e.VchType }, "13");

        //    entity.HasIndex(e => new { e.MasterCode1, e.MasterCode2 }, "14");

        //    entity.HasIndex(e => new { e.VchType, e.RecType, e.MasterCode1, e.SrNo }, "15");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C10)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C5)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C6)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C7)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C8)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C9)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //});

        //modelBuilder.Entity<Tran11>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran11");

        //    entity.HasIndex(e => e.MasterCode1, "01");

        //    entity.HasIndex(e => e.C1, "02");

        //    entity.HasIndex(e => e.Date, "03");

        //    entity.HasIndex(e => e.Cm3, "04");

        //    entity.HasIndex(e => e.TranType, "05");

        //    entity.HasIndex(e => e.VchType, "06");

        //    entity.HasIndex(e => e.RecType, "07");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.Cm6).HasColumnName("CM6");
        //    entity.Property(e => e.Cm7).HasColumnName("CM7");
        //    entity.Property(e => e.Cm8).HasColumnName("CM8");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date1)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date2)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date3)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date4)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date5)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.M1)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.M2)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.ShortNar)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran12>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran12");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.HasIndex(e => e.Date, "02");

        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.UserName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran2>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran2");

        //    entity.HasIndex(e => new { e.MasterCode1, e.Date }, "01");

        //    entity.HasIndex(e => e.MasterCode2, "02");

        //    entity.HasIndex(e => new { e.Cm1, e.Date }, "03");

        //    entity.HasIndex(e => e.VchCode, "08");

        //    entity.HasIndex(e => e.RecType, "31");

        //    entity.HasIndex(e => e.VchType, "32");

        //    entity.HasIndex(e => e.VchNo, "33");

        //    entity.HasIndex(e => e.Date, "34");

        //    entity.HasIndex(e => e.VchSeriesCode, "36");

        //    entity.HasIndex(e => e.Cm2, "38");

        //    entity.HasIndex(e => e.Cm3, "39");

        //    entity.HasIndex(e => e.Cm4, "40");

        //    entity.HasIndex(e => e.Cm5, "41");

        //    entity.HasIndex(e => e.D18, "42");

        //    entity.HasIndex(e => e.D26, "43");

        //    entity.HasIndex(e => e.Cm6, "44");

        //    entity.HasIndex(e => e.IsReturnQty, "45");

        //    entity.HasIndex(e => e.C3, "46");

        //    entity.HasIndex(e => e.TrackingNo, "47");

        //    entity.HasIndex(e => e.TrackingStatus, "48");

        //    entity.HasIndex(e => e.TranType, "49");

        //    entity.HasIndex(e => e.Cm7, "50");

        //    entity.HasIndex(e => e.Cm8, "51");

        //    entity.HasIndex(e => e.Cm9, "52");

        //    entity.HasIndex(e => e.Cm10, "53");

        //    entity.HasIndex(e => e.Cm11, "54");

        //    entity.HasIndex(e => e.Cm12, "55");

        //    entity.HasIndex(e => e.ConsignmentType, "56");

        //    entity.HasIndex(e => e.ConsignmentCleared, "57");

        //    entity.HasIndex(e => e.MasterCode2, "81");

        //    entity.Property(e => e.C1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.C4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Cfmode).HasColumnName("CFMode");
        //    entity.Property(e => e.ClrDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm10).HasColumnName("CM10");
        //    entity.Property(e => e.Cm11).HasColumnName("CM11");
        //    entity.Property(e => e.Cm12).HasColumnName("CM12");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Cm4).HasColumnName("CM4");
        //    entity.Property(e => e.Cm5).HasColumnName("CM5");
        //    entity.Property(e => e.Cm6).HasColumnName("CM6");
        //    entity.Property(e => e.Cm7).HasColumnName("CM7");
        //    entity.Property(e => e.Cm8).HasColumnName("CM8");
        //    entity.Property(e => e.Cm9).HasColumnName("CM9");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ShortNar)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TrackingNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran3>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran3");

        //    entity.HasIndex(e => e.MasterCode1, "04");

        //    entity.HasIndex(e => e.MasterCode2, "05");

        //    entity.HasIndex(e => e.RefGrp, "09");

        //    entity.HasIndex(e => e.SrNo, "20");

        //    entity.HasIndex(e => e.Date, "21");

        //    entity.HasIndex(e => e.VchType, "22");

        //    entity.HasIndex(e => e.VchCode, "23");

        //    entity.HasIndex(e => e.RefCode, "24");

        //    entity.HasIndex(e => e.RecType, "25");

        //    entity.HasIndex(e => e.Type, "26");

        //    entity.HasIndex(e => e.Method, "27");

        //    entity.HasIndex(e => e.DueDate, "28");

        //    entity.HasIndex(e => e.No, "29");

        //    entity.HasIndex(e => e.Status, "31");

        //    entity.HasIndex(e => e.ApprovalStatus, "32");

        //    entity.HasIndex(e => e.TranType, "33");

        //    entity.HasIndex(e => e.Value1, "34");

        //    entity.HasIndex(e => e.Cm1, "35");

        //    entity.HasIndex(e => e.Cm2, "36");

        //    entity.HasIndex(e => e.BrokerCode, "37");

        //    entity.HasIndex(e => e.BranchCode, "38");

        //    entity.HasIndex(e => new { e.RecType, e.MasterCode1, e.MasterCode2, e.No }, "61");

        //    entity.HasIndex(e => new { e.RefCode, e.Date }, "62");

        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Cm3).HasColumnName("CM3");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.DueDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.MfgDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Narration)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.No)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran4>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran4");

        //    entity.HasIndex(e => new { e.MasterCode1, e.MasterCode2 }, "01");

        //    entity.HasIndex(e => new { e.MasterCode1, e.SrNo }, "02");

        //    entity.HasIndex(e => e.MasterCode2, "03");

        //    entity.HasIndex(e => e.BranchCode, "06");

        //    entity.HasIndex(e => e.RecType, "07");
        //});

        //modelBuilder.Entity<Tran5>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran5");

        //    entity.HasIndex(e => new { e.MasterCode1, e.Date, e.VchType, e.VchNo, e.VchCode }, "01");

        //    entity.HasIndex(e => new { e.VchCode, e.MasterCode1, e.TranType, e.SrNo }, "02");

        //    entity.HasIndex(e => new { e.VchCode, e.TranType, e.SrNo }, "03");

        //    entity.HasIndex(e => new { e.MasterCode1, e.MasterCode2, e.Date, e.VchNo, e.VchCode }, "04");

        //    entity.HasIndex(e => new { e.MasterCode1, e.VchType, e.Date, e.VchNo, e.VchCode }, "05");

        //    entity.HasIndex(e => new { e.MasterCode1, e.MasterCode2, e.Value1, e.Date }, "06");

        //    entity.HasIndex(e => new { e.MasterCode2, e.MasterCode1, e.Value1, e.Date }, "07");

        //    entity.HasIndex(e => new { e.MasterCode1, e.VchType, e.Value1, e.Date }, "08");

        //    entity.HasIndex(e => new { e.VchType, e.MasterCode1, e.Value1, e.Date }, "09");

        //    entity.HasIndex(e => new { e.VchCode, e.MasterCode2, e.SrNo }, "10");

        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ShortNar)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TrackingNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran6>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran6");

        //    entity.HasIndex(e => new { e.MasterCode1, e.MasterCode2, e.StockType }, "01");

        //    entity.HasIndex(e => new { e.MasterCode1, e.StockType, e.SrNo }, "02");

        //    entity.HasIndex(e => e.MasterCode2, "03");
        //});

        //modelBuilder.Entity<Tran7>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran7");

        //    entity.HasIndex(e => e.MasterCode, "01");
        //});

        //modelBuilder.Entity<Tran8>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran8");

        //    entity.HasIndex(e => e.VchCode, "01").IsUnique();

        //    entity.HasIndex(e => new { e.VchType, e.Date, e.FormNo, e.VchCode }, "02");

        //    entity.HasIndex(e => new { e.VchType, e.FormNo }, "03");

        //    entity.Property(e => e.AuthorisationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.AuthorisedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CreatedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.CreationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.FormNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.FormRecDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.IssuingOffice)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ModificationTime)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ModifiedBy)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Nar1)
        //        .HasMaxLength(94)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Series)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Tran9>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Tran9");

        //    entity.HasIndex(e => new { e.VchCode, e.SrNo }, "01");

        //    entity.HasIndex(e => new { e.VchType, e.BillCode }, "02");

        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.FormNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<Vatinfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("VATInfo");

        //    entity.HasIndex(e => e.Date, "01");

        //    entity.HasIndex(e => e.VchCode, "02");

        //    entity.Property(e => e.BankAcNo)
        //        .HasMaxLength(15)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BankAcType)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BankCode)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.BankName)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChallanDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ChallanNo)
        //        .HasMaxLength(40)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ChequeDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.ChequeNo)
        //        .HasMaxLength(10)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Date)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.Description)
        //        .HasMaxLength(80)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<VchGstsumItemWise>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("VchGSTSumItemWise");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.HasIndex(e => e.ItemCode, "02");

        //    entity.HasIndex(e => e.PartyCode, "03");

        //    entity.HasIndex(e => e.TaxCatCode, "04");

        //    entity.HasIndex(e => e.Stptcode, "05");

        //    entity.HasIndex(e => e.LocType, "06");

        //    entity.HasIndex(e => e.ZeroTaxType, "07");

        //    entity.HasIndex(e => e.Hsncode, "08");

        //    entity.HasIndex(e => e.Seno, "09");

        //    entity.HasIndex(e => e.OrgVchNo, "12");

        //    entity.HasIndex(e => e.RecType, "13");

        //    entity.HasIndex(e => e.TaxRate, "14");

        //    entity.HasIndex(e => e.TaxRate1, "15");

        //    entity.HasIndex(e => e.PartyStateTinDigit, "16");

        //    entity.HasIndex(e => e.PartyStateCode, "17");

        //    entity.HasIndex(e => e.OrgVchDate, "18");

        //    entity.HasIndex(e => e.VchNo, "19");

        //    entity.HasIndex(e => e.VchDate, "20");

        //    entity.HasIndex(e => e.VchSeriesCode, "21");

        //    entity.HasIndex(e => e.VchType, "22");

        //    entity.HasIndex(e => e.Gstin, "23");

        //    entity.Property(e => e.AcessAmt).HasColumnName("ACessAmt");
        //    entity.Property(e => e.AcessRate).HasColumnName("ACessRate");
        //    entity.Property(e => e.BdstateCode).HasColumnName("BDStateCode");
        //    entity.Property(e => e.BdstateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("BDStateTinDigit");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.Cm2).HasColumnName("CM2");
        //    entity.Property(e => e.Gstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("GSTIN");
        //    entity.Property(e => e.Gstr2bmonth).HasColumnName("GSTR2BMonth");
        //    entity.Property(e => e.Gstr2bstatus).HasColumnName("GSTR2BStatus");
        //    entity.Property(e => e.Gstr2byear).HasColumnName("GSTR2BYear");
        //    entity.Property(e => e.GstrepBasis).HasColumnName("GSTRepBasis");
        //    entity.Property(e => e.Hsncode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("HSNCode");
        //    entity.Property(e => e.ItcclaimedMonth).HasColumnName("ITCClaimedMonth");
        //    entity.Property(e => e.ItcclaimedStatus).HasColumnName("ITCClaimedStatus");
        //    entity.Property(e => e.OrgVchDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.OrgVchNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PartyStateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PosstateCode).HasColumnName("POSStateCode");
        //    entity.Property(e => e.PosstateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("POSStateTinDigit");
        //    entity.Property(e => e.Seno)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("SENo");
        //    entity.Property(e => e.Stptcode).HasColumnName("STPTCode");
        //    entity.Property(e => e.TaxOnMrp).HasColumnName("TaxOnMRP");
        //    entity.Property(e => e.VchDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<VchOtherInfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("VchOtherInfo");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.Property(e => e.CombinedEwayBillEinvoice).HasColumnName("CombinedEwayBillEInvoice");
        //    entity.Property(e => e.DispatchAddr1)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DispatchAddr2)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DispatchAddr3)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DispatchAddr4)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DispatchGstin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("DispatchGSTIN");
        //    entity.Property(e => e.DispatchPin)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("DispatchPIN");
        //    entity.Property(e => e.DispatchPlace)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.DispatcherPartyName)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.EinvoiceReq).HasColumnName("EInvoiceReq");
        //    entity.Property(e => e.EwayBillDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime")
        //        .HasColumnName("EWayBillDate");
        //    entity.Property(e => e.EwayBillPrinted).HasColumnName("EWayBillPrinted");
        //    entity.Property(e => e.EwayBillReqd).HasColumnName("EWayBillReqd");
        //    entity.Property(e => e.EwayBillSubType).HasColumnName("EWayBillSubType");
        //    entity.Property(e => e.EwayBillTranType).HasColumnName("EWayBillTranType");
        //    entity.Property(e => e.Form31IssuedOn)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Form31No)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.GoodsRemovalTime)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.GrDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.GrNo)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.InvoicePrepTime)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.ItemDesc)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Narration1)
        //        .HasMaxLength(94)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Narration2)
        //        .HasMaxLength(94)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Of1)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF1");
        //    entity.Property(e => e.Of10)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF10");
        //    entity.Property(e => e.Of11)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF11");
        //    entity.Property(e => e.Of12)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF12");
        //    entity.Property(e => e.Of13)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF13");
        //    entity.Property(e => e.Of14)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF14");
        //    entity.Property(e => e.Of15)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF15");
        //    entity.Property(e => e.Of16)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF16");
        //    entity.Property(e => e.Of17)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF17");
        //    entity.Property(e => e.Of18)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF18");
        //    entity.Property(e => e.Of19)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF19");
        //    entity.Property(e => e.Of2)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF2");
        //    entity.Property(e => e.Of20)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF20");
        //    entity.Property(e => e.Of3)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF3");
        //    entity.Property(e => e.Of4)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF4");
        //    entity.Property(e => e.Of5)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF5");
        //    entity.Property(e => e.Of6)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF6");
        //    entity.Property(e => e.Of7)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF7");
        //    entity.Property(e => e.Of8)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF8");
        //    entity.Property(e => e.Of9)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("OF9");
        //    entity.Property(e => e.PinCode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PortCode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PurchaseBillDate)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PurchaseBillNo)
        //        .HasMaxLength(25)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Station)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.TotalQty)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.Transport)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.VchNotes)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnType("ntext");
        //    entity.Property(e => e.VehicleNo)
        //        .HasMaxLength(30)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<VchTempTagging>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("VchTempTagging");

        //    entity.HasIndex(e => new { e.MasterCode, e.VchType }, "01");

        //    entity.HasIndex(e => new { e.MasterType, e.VchType }, "02");
        //});

        //modelBuilder.Entity<VchTemplate>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("VchTemplate");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.HasIndex(e => e.TemplateName, "02");

        //    entity.Property(e => e.TemplateName)
        //        .HasMaxLength(20)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<VchVataccInfo>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("VchVATAccInfo");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.HasIndex(e => e.ItemCode, "02");

        //    entity.HasIndex(e => e.PartyCode, "03");

        //    entity.HasIndex(e => e.TaxCatCode, "04");

        //    entity.HasIndex(e => e.Stptcode, "05");

        //    entity.HasIndex(e => e.LocType, "06");

        //    entity.HasIndex(e => e.ZeroTaxType, "07");

        //    entity.HasIndex(e => e.Hsncode, "08");

        //    entity.HasIndex(e => e.Seno, "09");

        //    entity.HasIndex(e => e.OrgVchNo, "12");

        //    entity.HasIndex(e => e.RecType, "13");

        //    entity.HasIndex(e => e.TaxRate, "14");

        //    entity.HasIndex(e => e.TaxRate1, "15");

        //    entity.HasIndex(e => e.PartyStateTinDigit, "16");

        //    entity.HasIndex(e => e.PartyStateCode, "17");

        //    entity.HasIndex(e => e.OrgVchDate, "18");

        //    entity.HasIndex(e => e.VchNo, "19");

        //    entity.HasIndex(e => e.VchDate, "20");

        //    entity.HasIndex(e => e.VchSeriesCode, "21");

        //    entity.HasIndex(e => e.VchType, "22");

        //    entity.Property(e => e.AcessAmt).HasColumnName("ACessAmt");
        //    entity.Property(e => e.AcessRate).HasColumnName("ACessRate");
        //    entity.Property(e => e.BdstateCode).HasColumnName("BDStateCode");
        //    entity.Property(e => e.BdstateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("BDStateTinDigit");
        //    entity.Property(e => e.Cm1).HasColumnName("CM1");
        //    entity.Property(e => e.GstrepBasis).HasColumnName("GSTRepBasis");
        //    entity.Property(e => e.Hsncode)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("HSNCode");
        //    entity.Property(e => e.OrgVchDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.OrgVchNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PartyStateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //    entity.Property(e => e.PosstateCode).HasColumnName("POSStateCode");
        //    entity.Property(e => e.PosstateTinDigit)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("POSStateTinDigit");
        //    entity.Property(e => e.Seno)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')")
        //        .HasColumnName("SENo");
        //    entity.Property(e => e.Stptcode).HasColumnName("STPTCode");
        //    entity.Property(e => e.TaxOnMrp).HasColumnName("TaxOnMRP");
        //    entity.Property(e => e.VchDate)
        //        .HasDefaultValueSql("((0))")
        //        .HasColumnType("datetime");
        //    entity.Property(e => e.VchNo)
        //        .HasMaxLength(255)
        //        .HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<VchVatsum>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("VchVATSum");

        //    entity.HasIndex(e => e.VchCode, "01");

        //    entity.Property(e => e.TaxOnMrp).HasColumnName("TaxOnMRP");
        //});

        modelBuilder.Entity<VchVatsumItemWise>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VchVATSumItemWise");

            entity.HasIndex(e => new { e.VchCode, e.ItemSrNo }, "01");

            entity.HasIndex(e => e.ItemCode, "02");

            entity.Property(e => e.TaxOnMrp).HasColumnName("TaxOnMRP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
