using System;
using System.Collections.Generic;

namespace WamanBhauDeveloper.EntityModels;

public partial class TblUserrole
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? UpdatedBy { get; set; }
}
