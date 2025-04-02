using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblLeadMaster
{
    public int LeadId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ContactNo1 { get; set; }

    public string? ContactNo2 { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? FkSiteId { get; set; }

    public DateTime? ContactDate { get; set; }

    public int? FkPropertyTypeId { get; set; }
    public int? FkSourceId { get; set; }

    public int? FkChannelPartnerId { get; set; }

    public string? BudgetRangeFrom { get; set; }

    public string? BudgetRangeTo { get; set; }

    public int? FkUserIdAssigned { get; set; }

    public string? LeadStatus { get; set; }

    public string? LeadCategory { get; set; }

    public string? FloorPreference { get; set; }

    public string? Note { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
