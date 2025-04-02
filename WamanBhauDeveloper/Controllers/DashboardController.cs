using Microsoft.AspNetCore.Mvc;
using WamanBhauDeveloper.EntityModels;
using WamanBhauDeveloper.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WamanBhauDeveloper.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DbWamanbhauDevelopersContext _context;

        public DashboardController(DbWamanbhauDevelopersContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["ActiveMenu"] = "Dashboard";
            return View();
        }

        //public IActionResult Leads(string searchTerm = "", int pageNumber = 1, int pageSize = 10)
        //{
        //    var leadQuery = _context.TblLeadMasters
        //        .Where(x => x.IsDeleted == false)
        //        .Select(x => new LeadMasterViewModel
        //        {
        //            LeadId = x.LeadId,
        //            FirstName = x.FirstName,
        //            LastName = x.LastName,
        //            ContactNo1 = x.ContactNo1,
        //            Email = x.Email,
        //            AssignedToName = _context.TblUsers
        //                .Where(u => u.UserId == x.FkUserIdAssigned)
        //                .Select(u => u.FullName)
        //                .FirstOrDefault(),
        //            SiteName = _context.TblSitemasters
        //                .Where(s => s.SiteId == x.FkSiteId)
        //                .Select(s => s.SiteName)
        //                .FirstOrDefault()
        //        });

        //    if (!string.IsNullOrEmpty(searchTerm))
        //    {
        //        leadQuery = leadQuery.Where(x => x.FirstName.Contains(searchTerm) || x.LastName.Contains(searchTerm) || x.ContactNo1.Contains(searchTerm));
        //    }

        //    var leadList = leadQuery.ToList(); 
        //    return View(leadList);
        //}


        //public IActionResult Leads(string searchTerm = "", int pageNumber = 1, int pageSize = 10)
        //{
        //    List<LeadMasterViewModel> GetLeadMaster = new List<LeadMasterViewModel>();

        //    var LeadList = _context.TblLeadMasters.Where(x => x.IsDeleted == false && x.LeadId != 0).ToList();

        //    foreach (var item in LeadList)
        //    {
        //        LeadMasterViewModel lead = new LeadMasterViewModel();

        //        lead.LeadId = item.LeadId;
        //        lead.FirstName = item.FirstName;
        //        lead.LastName = item.LastName;
        //        lead.ContactNo1 = item.ContactNo1;
        //        lead.Email = item.Email;
        //        lead.SiteName = _context.TblSitemasters.Where(x => x.SiteId == item.FkSiteId && x.IsDeleted == false).Select(x => x.SiteName).FirstOrDefault();
        //        lead.AssignedToName = _context.TblUsers.Where(x => x.UserId == item.FkUserIdAssigned && x.IsDeleted == false).Select(x => x.FullName).FirstOrDefault();
        //    }

        //    return View(GetLeadMaster);
        //}


        //public IActionResult Leads(string searchTerm = "", int pageNumber = 1, int pageSize = 10)
        //{
        //    List<LeadMasterViewModel> GetLeadMaster = new List<LeadMasterViewModel>();

        //    var LeadList = _context.TblLeadMasters
        //                            .Where(x => x.IsDeleted == false && x.LeadId != 0)
        //                            .AsQueryable();

        //    if (!string.IsNullOrEmpty(searchTerm))
        //    {
        //        LeadList = LeadList.Where(x => x.FirstName.Contains(searchTerm) ||
        //                                        x.LastName.Contains(searchTerm) ||
        //                                        x.ContactNo1.Contains(searchTerm) ||
        //                                        x.Email.Contains(searchTerm));
        //    }

        //    var paginatedLeads = LeadList
        //        .Skip((pageNumber - 1) * pageSize)
        //        .Take(pageSize)
        //        .ToList();

        //    foreach (var item in paginatedLeads)
        //    {
        //        LeadMasterViewModel lead = new LeadMasterViewModel();

        //        lead.LeadId = item.LeadId;
        //        lead.FirstName = item.FirstName;
        //        lead.LastName = item.LastName;
        //        lead.ContactNo1 = item.ContactNo1;
        //        lead.Email = item.Email;

        //        lead.SiteName = _context.TblSitemasters
        //                                .Where(x => x.SiteId == item.FkSiteId && x.IsDeleted == false)
        //                                .Select(x => x.SiteName)
        //                                .FirstOrDefault();

        //        lead.AssignedToName = _context.TblUsers
        //                                     .Where(x => x.UserId == item.FkUserIdAssigned && x.IsDeleted == false)
        //                                     .Select(x => x.FullName)
        //                                     .FirstOrDefault();

        //        GetLeadMaster.Add(lead);
        //    }

        //    ViewData["ActiveMenu"] = "Leads";
        //    return View(GetLeadMaster);
        //}


        public IActionResult ChannelPartners()
        {
            ViewData["ActiveMenu"] = "ChannelPartners";
            return View();
        }

        public IActionResult UserManagement()
        {
            ViewData["ActiveMenu"] = "UserManagement";
            return View();
        }

        public IActionResult Flats()
        {
            ViewData["ActiveMenu"] = "Flats";
            return View();
        }

        public IActionResult Parkings()
        {
            ViewData["ActiveMenu"] = "Parkings";
            return View();
        }





        public IActionResult LeadDetails()
        {
            ViewData["ActiveMenu"] = "Leads";
            return View();
        }

        public IActionResult ChannelPartnerDetails()
        {
            ViewData["ActiveMenu"] = "ChannelPartners";
            return View();
        }

        public IActionResult ChannelPartnerAnalytics()
        {
            ViewData["ActiveMenu"] = "ChannelPartners";
            return View();
        }
    }
}
