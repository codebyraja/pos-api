using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Tran12
{
    public int VchCode { get; set; }

    public DateTime Date { get; set; }

    public string UserName { get; set; } = null!;

    public short NoOfCopies { get; set; }
}
