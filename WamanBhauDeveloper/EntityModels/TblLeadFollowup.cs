using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblLeadFollowup
{
    public int Id { get; set; }

    public string? FollowUpNote { get; set; }

    public DateTime? NextFollowUpDate { get; set; }

    public string? ReminderText { get; set; }

    public DateTime? FollowUpDate { get; set; }

    public string? FollowUpType { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
