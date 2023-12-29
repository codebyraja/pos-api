using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class ReportNote
{
    public int NoteId { get; set; }

    public short RepId { get; set; }

    public short SubRepId { get; set; }

    public short NoteRepId { get; set; }

    public int MasterCode { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Description { get; set; } = null!;

    public bool NotesCarried { get; set; }

    public DateTime FinYear { get; set; }
}
