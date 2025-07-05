using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class OrgSalePurc
{
    public int VchCode { get; set; }

    public string VchNo { get; set; } = null!;

    public DateTime VchDate { get; set; }

    public double TaxableAmt { get; set; }

    public double TaxAmt { get; set; }

    public double TaxAmt1 { get; set; }

    public double SchgAmt { get; set; }

    public short RegType { get; set; }
}
