using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblChannelPartner
{
    public int ChannelPartnerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ContactNo { get; set; }

    public string? Email { get; set; }

    public string? Location { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
