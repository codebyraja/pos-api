using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class DailyMessage
{
    public DateTime Date { get; set; }

    public short NoOfDays { get; set; }

    public short VchType { get; set; }

    public int Vscode { get; set; }

    public string Msg1 { get; set; } = null!;

    public string Msg2 { get; set; } = null!;

    public string Msg3 { get; set; } = null!;

    public string Msg4 { get; set; } = null!;
}
