using System;
using System.Collections.Generic;

namespace ES_POS_BUSY.Services.DBContext;

public partial class Image
{
    public short Type { get; set; }

    public int Code { get; set; }

    public byte[] Image1 { get; set; } = null!;

    public string FormatType1 { get; set; } = null!;

    public byte[] Image2 { get; set; } = null!;

    public string FormatType2 { get; set; } = null!;
}
