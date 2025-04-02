using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblFlatParkingInverntory
{
    public int Id { get; set; }

    public int? FkSiteId { get; set; }

    public int? FkParkingId { get; set; }

    public string? BookingStatus { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
