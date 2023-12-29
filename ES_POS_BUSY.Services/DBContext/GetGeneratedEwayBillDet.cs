using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class GetGeneratedEwayBillDet
{
    public string GenByGstin { get; set; } = null!;

    public string EwayBillNo { get; set; } = null!;

    public DateTime EwayBillDate { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string FromGstin { get; set; } = null!;

    public string FromTradeName { get; set; } = null!;

    public string ToGstin { get; set; } = null!;

    public string ToTradeName { get; set; } = null!;

    public double InvValue { get; set; }

    public string Hsncode { get; set; } = null!;

    public string Hsndesc { get; set; } = null!;

    public DateTime Date1 { get; set; }

    public short RecType { get; set; }

    public string DeliveryPincode { get; set; } = null!;

    public string DeliveryPlace { get; set; } = null!;

    public string DeliveryStateCode { get; set; } = null!;
}
