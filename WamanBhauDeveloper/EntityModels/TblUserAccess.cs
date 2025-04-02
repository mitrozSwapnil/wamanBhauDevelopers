using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblUserAccess
{
    public int Id { get; set; }

    public int? FkRoleId { get; set; }

    public string? AccessMenuItem { get; set; }

    public int? ReadPermission { get; set; }

    public int? WritePermission { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
