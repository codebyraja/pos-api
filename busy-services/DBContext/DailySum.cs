using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class DailySum
{
    public int MasterCode1 { get; set; }

    public int MasterCode2 { get; set; }

    public short MasterType { get; set; }

    public DateTime Date { get; set; }

    public double Dr1 { get; set; }

    public double Dr2 { get; set; }

    public double Dr3 { get; set; }

    public double Cr1 { get; set; }

    public double Cr2 { get; set; }

    public double Cr3 { get; set; }

    public double D1 { get; set; }

    public double D2 { get; set; }

    public double D3 { get; set; }

    public double D4 { get; set; }
}
