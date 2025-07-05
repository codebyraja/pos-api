using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Stdet
{
    public int VchCode { get; set; }

    public short Stcategory { get; set; }

    public double StassValue { get; set; }

    public double Strate { get; set; }

    public double Sbcrate { get; set; }

    public double Kkcrate { get; set; }

    public double StcessRate { get; set; }

    public double SthecessRate { get; set; }
}
