using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class PackingDetail
{
    public int SrNo { get; set; }

    public int VchCode { get; set; }

    public string PackageNo { get; set; } = null!;

    public double Weight { get; set; }

    public double EstimatedValue { get; set; }

    public string Size { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string MarkaNo { get; set; } = null!;

    public double Quantity { get; set; }

    public int Unit { get; set; }

    public string PackingMode { get; set; } = null!;
}
