using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class PhyStkSubDet
{
    public short RecType { get; set; }

    public int VchCode { get; set; }

    public short VchType { get; set; }

    public string VchNo { get; set; } = null!;

    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public short SrNo { get; set; }

    public DateTime Date { get; set; }

    public DateTime DueDate { get; set; }

    public string No { get; set; } = null!;

    public double Value1 { get; set; }

    public double Value2 { get; set; }

    public double Value3 { get; set; }

    public double Balance1 { get; set; }

    public double Balance2 { get; set; }

    public double Balance3 { get; set; }

    public short ItemSrNo { get; set; }

    public DateTime MfgDate { get; set; }

    public double NewRefAmount { get; set; }

    public short MonthVal { get; set; }

    public short WarrantyMonth { get; set; }

    public DateTime OrgDate { get; set; }

    public string C1 { get; set; } = null!;

    public string C2 { get; set; } = null!;

    public string C3 { get; set; } = null!;

    public string C4 { get; set; } = null!;

    public string C5 { get; set; } = null!;

    public string C6 { get; set; } = null!;

    public string C7 { get; set; } = null!;

    public string C8 { get; set; } = null!;

    public string C9 { get; set; } = null!;

    public string C10 { get; set; } = null!;

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public double D4 { get; set; }

    public double D5 { get; set; }

    public double D6 { get; set; }

    public bool B1 { get; set; }
}
