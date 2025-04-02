using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblSiteAssign
{
    public int Id { get; set; }

    public int? FkChannelPartnerId { get; set; }

    public int? FkSiteId { get; set; }

    public DateTime? AssignedDate { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
