using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblSiteParking
{
    public int ParkingId { get; set; }

    public string? ParkingNumber { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
