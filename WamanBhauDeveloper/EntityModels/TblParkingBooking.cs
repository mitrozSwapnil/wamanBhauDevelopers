using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblParkingBooking
{
    public int Id { get; set; }

    public int? FkParkingId { get; set; }

    public int? FkLeadId { get; set; }

    public int? FkAssignedUserId { get; set; }

    public DateTime? BookingDate { get; set; }

    public string? BookingAmount { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
