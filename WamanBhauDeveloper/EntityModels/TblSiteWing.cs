using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblSiteWing
{
    public int WingId { get; set; }

    public string? WingName { get; set; }

    public int? FkSiteId { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
