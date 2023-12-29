using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Excise
{
    public short RecType { get; set; }

    public int VchCode { get; set; }

    public string DocName { get; set; } = null!;

    public string VchNo { get; set; } = null!;

    public short SrNo { get; set; }

    public DateTime Date { get; set; }

    public double Value { get; set; }

    public double Balance { get; set; }

    public double Value1 { get; set; }

    public double Balance1 { get; set; }

    public double Value2 { get; set; }

    public double Balance2 { get; set; }

    public double Value3 { get; set; }

    public double Value4 { get; set; }

    public double Value5 { get; set; }

    public short ValueType { get; set; }

    public short SupplierType { get; set; }

    public string ChallanNo { get; set; } = null!;

    public string BankCode { get; set; } = null!;

    public DateTime DateOfDeposit { get; set; }

    public DateTime PeriodEnding { get; set; }

    public short Dummy { get; set; }

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public double D4 { get; set; }

    public double D5 { get; set; }

    public int BranchCode { get; set; }

    public short ClearanceType { get; set; }

    public string NotificationAvailed { get; set; } = null!;

    public string NotificationNo { get; set; } = null!;
}
