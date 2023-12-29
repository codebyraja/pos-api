using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran3
{
    public int RefCode { get; set; }

    public short RecType { get; set; }

    public short Method { get; set; }

    public int VchCode { get; set; }

    public short VchType { get; set; }

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public int RefGrp { get; set; }

    public short SrNo { get; set; }

    public DateTime Date { get; set; }

    public DateTime DueDate { get; set; }

    public string No { get; set; } = null!;

    public short Status { get; set; }

    public short Type { get; set; }

    public int BrokerCode { get; set; }

    public double Value1 { get; set; }

    public double Value2 { get; set; }

    public double Value3 { get; set; }

    public double Balance1 { get; set; }

    public double Balance2 { get; set; }

    public double Balance3 { get; set; }

    public short ItemSrNo { get; set; }

    public DateTime MfgDate { get; set; }

    public short TranType { get; set; }

    public int Cm1 { get; set; }

    public int Cm2 { get; set; }

    public int Cm3 { get; set; }

    public short ApprovalStatus { get; set; }

    public double NewRefAmount { get; set; }

    public string Narration { get; set; } = null!;

    public int BranchCode { get; set; }

    public short NewRefVchType { get; set; }

    public int NewRefVchCode { get; set; }
}
