using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblSitemaster
{
    public int SiteId { get; set; }

    public string? SiteName { get; set; }

    public string? SiteLocation { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
