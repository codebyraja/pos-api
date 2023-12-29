using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class VchVatsum
{
    public int VchCode { get; set; }

    public double SaleAmt { get; set; }

    public double TaxRate { get; set; }

    public double TaxAmt { get; set; }

    public double SurchargeRate { get; set; }

    public double SurchargeAmt { get; set; }

    public short TaxType { get; set; }

    public double ActualSaleAmt { get; set; }

    public bool TaxOnMrp { get; set; }
}
