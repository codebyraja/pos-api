using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class DataSync
{
    public int Uid { get; set; }

    public int BranchCode { get; set; }

    public short RecType { get; set; }

    public short Type { get; set; }

    public short Vmtype { get; set; }

    public string MasterName { get; set; } = null!;

    public string VchNo { get; set; } = null!;

    public DateTime Date { get; set; }

    public int VchSrCode { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string LastModifiedBy { get; set; } = null!;

    public DateTime LastModificationTime { get; set; }

    public string ApprovedBy { get; set; } = null!;

    public DateTime ApprovalTime { get; set; }

    public DateTime ServerInTime { get; set; }

    public string M1 { get; set; } = null!;

    public string M2 { get; set; } = null!;

    public string MasterName1 { get; set; } = null!;

    public string ComputerName { get; set; } = null!;

    public string OldVchSrName { get; set; } = null!;

    public short OldVchType { get; set; }

    public string VchSrName { get; set; } = null!;

    public string DeletedBy { get; set; } = null!;

    public DateTime DeletionTime { get; set; }

    public short Srno { get; set; }

    public short CheckType { get; set; }

    public bool ClearFullVch { get; set; }

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public double D4 { get; set; }

    public double D5 { get; set; }

    public string OldMasterName { get; set; } = null!;

    public DateTime OldDate { get; set; }

    public string OldVchNo { get; set; } = null!;

    public string OldIdentity { get; set; } = null!;
}
