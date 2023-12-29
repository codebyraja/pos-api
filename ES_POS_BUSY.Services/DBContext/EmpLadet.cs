using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class EmpLadet
{
    public int EmpCode { get; set; }

    public short Latype { get; set; }

    public short SrNo { get; set; }

    public DateTime DueDate { get; set; }

    public double Amount { get; set; }

    public double IntAmt { get; set; }

    public double Total { get; set; }

    public string Remarks { get; set; } = null!;
}
