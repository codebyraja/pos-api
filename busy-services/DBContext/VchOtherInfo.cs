using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class VchOtherInfo
{
    public int VchCode { get; set; }

    public string Of1 { get; set; } = null!;

    public string Of2 { get; set; } = null!;

    public string Of3 { get; set; } = null!;

    public string Of4 { get; set; } = null!;

    public string Of5 { get; set; } = null!;

    public string Of6 { get; set; } = null!;

    public string Of7 { get; set; } = null!;

    public string Of8 { get; set; } = null!;

    public string Of9 { get; set; } = null!;

    public string Of10 { get; set; } = null!;

    public string Transport { get; set; } = null!;

    public string Station { get; set; } = null!;

    public string GrNo { get; set; } = null!;

    public string VehicleNo { get; set; } = null!;

    public string ItemDesc { get; set; } = null!;

    public string Form31No { get; set; } = null!;

    public string Form31IssuedOn { get; set; } = null!;

    public string TotalQty { get; set; } = null!;

    public string PurchaseBillNo { get; set; } = null!;

    public string PurchaseBillDate { get; set; } = null!;

    public string Narration1 { get; set; } = null!;

    public string Narration2 { get; set; } = null!;

    public string InvoicePrepTime { get; set; } = null!;

    public string GoodsRemovalTime { get; set; } = null!;

    public DateTime GrDate { get; set; }

    public string VchNotes { get; set; } = null!;

    public short I1 { get; set; }

    public string Of11 { get; set; } = null!;

    public string Of12 { get; set; } = null!;

    public string Of13 { get; set; } = null!;

    public string Of14 { get; set; } = null!;

    public string Of15 { get; set; } = null!;

    public string Of16 { get; set; } = null!;

    public string Of17 { get; set; } = null!;

    public string Of18 { get; set; } = null!;

    public string Of19 { get; set; } = null!;

    public string Of20 { get; set; } = null!;

    public string PortCode { get; set; } = null!;

    public double Distance { get; set; }

    public bool EwayBillReqd { get; set; }

    public short TransportMode { get; set; }

    public string PinCode { get; set; } = null!;

    public DateTime EwayBillDate { get; set; }

    public bool EwayBillPrinted { get; set; }

    public short EwayBillSubType { get; set; }

    public short EwayBillTranType { get; set; }

    public bool EinvoiceReq { get; set; }

    public bool CombinedEwayBillEinvoice { get; set; }

    public bool DispatchDetReq { get; set; }

    public string DispatcherPartyName { get; set; } = null!;

    public string DispatchAddr1 { get; set; } = null!;

    public string DispatchAddr2 { get; set; } = null!;

    public string DispatchAddr3 { get; set; } = null!;

    public string DispatchAddr4 { get; set; } = null!;

    public string DispatchPlace { get; set; } = null!;

    public string DispatchPin { get; set; } = null!;

    public int DispatchStateCode { get; set; }

    public string DispatchGstin { get; set; } = null!;
}
