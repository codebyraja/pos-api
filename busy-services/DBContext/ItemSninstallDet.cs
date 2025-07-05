using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class ItemSninstallDet
{
    public int InstallCode { get; set; }

    public DateTime InstallDate { get; set; }

    public int ItemCode { get; set; }

    public string SerialNo { get; set; } = null!;

    public string InvoiceNo { get; set; } = null!;

    public DateTime InvoiceDate { get; set; }

    public int PartyCode { get; set; }

    public string Organization { get; set; } = null!;

    public string TradeDesc { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public int CountryCode { get; set; }

    public int StateCode { get; set; }

    public int CityCode { get; set; }

    public string PinCode { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public string Narration { get; set; } = null!;

    public short WarrMonth { get; set; }
}
