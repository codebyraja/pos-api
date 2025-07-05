using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class BillingDet
{
    public int VchCode { get; set; }

    public string PartyName { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string Address4 { get; set; } = null!;

    public string Stno { get; set; } = null!;

    public string Cstno { get; set; } = null!;

    public string Ecccode { get; set; } = null!;

    public string ExciseRegNo { get; set; } = null!;

    public string Plano { get; set; } = null!;

    public string Range { get; set; } = null!;

    public string Division { get; set; } = null!;

    public string Collectorate { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string DrugLicenceNo1 { get; set; } = null!;

    public string DrugLicenceNo2 { get; set; } = null!;

    public string Itpan { get; set; } = null!;

    public int StateCode { get; set; }

    public string Gstno { get; set; } = null!;

    public short TypeOfDealer { get; set; }

    public string AdharNo { get; set; } = null!;

    public string PartyNameSl { get; set; } = null!;

    public string Address1Sl { get; set; } = null!;

    public string Address2Sl { get; set; } = null!;

    public string Address3Sl { get; set; } = null!;

    public string Address4Sl { get; set; } = null!;

    public string Fssaino { get; set; } = null!;
}
