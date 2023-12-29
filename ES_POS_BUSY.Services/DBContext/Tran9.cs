using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran9
{
    public int VchCode { get; set; }

    public int PartyCode { get; set; }

    public int FormCode { get; set; }

    public short SrNo { get; set; }

    public short VchType { get; set; }

    public DateTime Date { get; set; }

    public string FormNo { get; set; } = null!;

    public int BillCode { get; set; }

    public double Amount { get; set; }
}
