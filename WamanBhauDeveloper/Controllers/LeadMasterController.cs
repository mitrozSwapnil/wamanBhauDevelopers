using Microsoft.AspNetCore.Mvc;
using WamanBhauDeveloper.EntityModels;
using WamanBhauDeveloper.Models;

namespace WamanBhauDeveloper.Controllers
{
    public class LeadMasterController : Controller
    {
        private readonly DbWamanbhauDevelopersContext _context;

        public LeadMasterController(DbWamanbhauDevelopersContext context)
        {
            _context = context;
        }

        public IActionResult Leads(string searchTerm = "", int pageNumber = 1, int pageSize = 10)
        {
            List<LeadMasterViewModel> GetLeadMaster = new List<LeadMasterViewModel>();

            var LeadList = _context.TblLeadMasters
                                    .Where(x => x.IsDeleted == false && x.LeadId != 0)
                                    .AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                LeadList = LeadList.Where(x => x.FirstName.Contains(searchTerm) ||
                                                x.LastName.Contains(searchTerm) ||
                                                x.ContactNo1.Contains(searchTerm) ||
                                                x.Email.Contains(searchTerm));
            }

            var paginatedLeads = LeadList
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            foreach (var item in paginatedLeads)
            {
                LeadMasterViewModel lead = new LeadMasterViewModel();

                lead.LeadId = item.LeadId;
                lead.FirstName = item.FirstName;
                lead.LastName = item.LastName;
                lead.ContactNo1 = item.ContactNo1;
                lead.Email = item.Email;

                lead.SiteName = _context.TblSitemasters
                                        .Where(x => x.SiteId == item.FkSiteId && x.IsDeleted == false)
                                        .Select(x => x.SiteName)
                                        .FirstOrDefault();

                lead.AssignedToName = _context.TblUsers
                                             .Where(x => x.UserId == item.FkUserIdAssigned && x.IsDeleted == false)
                                             .Select(x => x.FullName)
                                             .FirstOrDefault();

                GetLeadMaster.Add(lead);
            }

            ViewData["ActiveMenu"] = "Leads";
            return View(GetLeadMaster);
        }


        [HttpGet]
        public IActionResult AddLead()
        {
            return View(new  LeadMasterViewModel());
        }

        [HttpPost]
        public IActionResult AddLead(LeadMasterViewModel addLead)
        {
            if(addLead.LeadId != 0)
            {
                var LeadViewModel = new TblLeadMaster
                {
                    FirstName = addLead.FirstName,
                    LastName = addLead.LastName,
                    ContactNo1 = addLead.ContactNo1,
                    ContactNo2 = addLead.ContactNo2,
                    Email = addLead.Email,
                    Address = addLead.Address,
                    ContactDate = addLead.ContactDate,
                    BudgetRangeFrom = addLead.BudgetRangeFrom,
                    BudgetRangeTo = addLead.BudgetRangeTo,
                    LeadStatus = addLead.LeadStatus,
                    LeadCategory = addLead.LeadCategory,
                    FloorPreference = addLead.FloorPreference,
                    Note = addLead.Note,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now
                };
                _context.TblLeadMasters.Add(LeadViewModel);
                _context.SaveChanges();
            }
            return RedirectToAction("Leads");
        }
    }
}
