using Microsoft.AspNetCore.Mvc.Rendering;

namespace WamanBhauDeveloper.Models
{
    public class LeadMasterViewModel
    {
        public int LeadId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNo1 { get; set; }

        public string ContactNo2 { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int FkSiteId { get; set; }
        public string SiteName { get; set; }

        public DateTime ContactDate { get; set; }

        public int FkPropertyTypeId { get; set; }
        public int FkSourceId { get; set; }

        public int FkChannelPartnerId { get; set; }

        public string BudgetRangeFrom { get; set; }

        public string BudgetRangeTo { get; set; }

        public int FkUserIdAssigned { get; set; }
        public string AssignedToName { get; set; }

        public string LeadStatus { get; set; }

        public string LeadCategory { get; set; }

        public string FloorPreference { get; set; }

        public string Note { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int UpdatedBy { get; set; }

        public SelectList SiteNameList { get; set; } = new SelectList(Enumerable.Empty<SelectListItem>());
        public SelectList PropertyTypeList { get; set; } = new SelectList(Enumerable.Empty<SelectListItem>());
        public SelectList SourcList { get; set; } = new SelectList(Enumerable.Empty<SelectListItem>());
        public SelectList ChannelPartnerList { get; set; } = new SelectList(Enumerable.Empty<SelectListItem>());
        public SelectList AssignUserList { get; set; } = new SelectList(Enumerable.Empty<SelectListItem>());

    }

    //public class LeadViewModel
    //{
    //    public List<LeadMasterViewModel> Leads { get; set; } = new List<LeadMasterViewModel>();
    //    public LeadMasterViewModel LeadForm { get; set; } = new LeadMasterViewModel();
    //}
}
