using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

            //ViewBag.SiteList = _context.TblSitemasters.Select(r => r.SiteName).ToList(); 
            //ViewBag.PropertyTypeList = _context.TblPropertyTypes.Select(r => r.Name).ToList(); 
            //ViewBag.SourceList = _context.TblLeadSources.Select(r => r.SourceName).ToList(); 
            //ViewBag.ChannelPartnerList = _context.TblChannelPartners.Select(r => r.FirstName).ToList(); 
            //ViewBag.AssignUser = _context.TblUsers.Select(r => r.FullName).ToList();

            ViewBag.SiteList = _context.TblSitemasters.Where(x => x.IsDeleted == false).Select(x => new
            {
                Id = x.SiteId,
                Name = x.SiteName
            }).ToList();

            ViewBag.PropertyTypeList = _context.TblPropertyTypes.Where(x => x.IsDeleted == false).Select(x => new
            {
                Id = x.Id,
                PropertyName = x.Name
            }).ToList();

            ViewBag.SourceList = _context.TblLeadSources.Where(x => x.IsDeleted == false).Select(x => new
            {
                Id = x.SourceId,
                SourceName = x.SourceName
            }).ToList();

            ViewBag.ChannelPartnerList = _context.TblChannelPartners.Where(x => x.IsDeleted == false).Select(x => new
            {
                Id = x.ChannelPartnerId,
                ChannnelName = x.FirstName
            }).ToList();

            ViewBag.AssignUser = _context.TblUsers.Where(x => x.IsDeleted == false).Select(x => new
            {
                Id = x.UserId,
                UserName = x.FullName
            }).ToList();

            return View(GetLeadMaster);
        }

        


        //[HttpGet]
        //public IActionResult GetDropdownList()
        //{
        //    var siteList = _context.TblSitemasters.Where(x => x.IsDeleted == false).OrderBy(x => x.SiteName)
        //        .Select(x => new
        //        {
        //            Id = x.SiteId,
        //            SelectSiteName = x.SiteName,
        //        }).ToList();

        //    var propertyTypeList = _context.TblPropertyTypes.Where(x => x.IsDeleted == false).OrderBy(x => x.Name)
        //        .Select(x => new
        //        {
        //            Id = x.Id,
        //            SelectPropertyName = x.Name,
        //        }).ToList();

        //    var soursNameList = _context.TblLeadSources.Where(x => x.IsDeleted == false).OrderBy(x => x.SourceName)
        //        .Select(x => new
        //        {
        //            Id = x.SourceId,
        //            SelectSourceName = x.SourceName,
        //        }).ToList();

        //    var channelPartnerNameList = _context.TblChannelPartners.Where(x => x.IsDeleted == false).OrderBy(x => x.FirstName)
        //        .Select(x => new
        //        {
        //            Id = x.ChannelPartnerId,
        //            SelectChannelPName = x.FirstName,
        //        }).ToList();

        //    var AssignUserNameList = _context.TblUsers.Where(x => x.IsDeleted == false).OrderBy(x => x.FullName)
        //        .Select(x => new
        //        {
        //            Id = x.UserId,
        //            userName = x.FullName,
        //        }).ToList();

        //    var viewModel = new LeadMasterViewModel
        //    {
        //        SiteNameList = new SelectList(siteList, "Id", "SelectSiteName"),
        //        PropertyTypeList = new SelectList(propertyTypeList, "Id", "SelectPropertyName"),
        //        SourcList = new SelectList(soursNameList, "Id", "SelectSourceName"),
        //        ChannelPartnerList = new SelectList(channelPartnerNameList, "Id", "SelectChannelPName"),
        //        AssignUserList = new SelectList(AssignUserNameList, "Id", "userName"),
        //    };

        //    return View(viewModel);
        //}


        [HttpGet]
        public JsonResult GetDropdownList()
        {
            var siteList = _context.TblSitemasters.Where(x => x.IsDeleted == false).OrderBy(x => x.SiteName)
                .Select(x => new
                {
                    Id = x.SiteId,
                    SelectSiteName = x.SiteName,
                }).ToList();

            var propertyTypeList = _context.TblPropertyTypes.Where(x => x.IsDeleted == false).OrderBy(x => x.Name)
                .Select(x => new
                {
                    Id = x.Id,
                    SelectPropertyName = x.Name,
                }).ToList();

            var soursNameList = _context.TblLeadSources.Where(x => x.IsDeleted == false).OrderBy(x => x.SourceName)
                .Select(x => new
                {
                    Id = x.SourceId,
                    SelectSourceName = x.SourceName,
                }).ToList();

            var channelPartnerNameList = _context.TblChannelPartners.Where(x => x.IsDeleted == false).OrderBy(x => x.FirstName)
                .Select(x => new
                {
                    Id = x.ChannelPartnerId,
                    SelectChannelPName = x.FirstName,
                }).ToList();

            var assignUserNameList = _context.TblUsers.Where(x => x.IsDeleted == false).OrderBy(x => x.FullName)
                .Select(x => new
                {
                    Id = x.UserId,
                    SelectUserName = x.FullName,
                }).ToList();

            return Json(new
            {
                siteList,
                propertyTypeList,
                soursNameList,
                channelPartnerNameList,
                assignUserNameList
            });
        }


        [HttpPost]
        public async Task<IActionResult> AddLead(LeadMasterViewModel addLead)
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
                FkSiteId = addLead.FkSiteId,
                FkPropertyTypeId = addLead.FkPropertyTypeId,
                FkSourceId = addLead.FkSourceId,
                FkChannelPartnerId = addLead.FkChannelPartnerId,
                FkUserIdAssigned = addLead.FkUserIdAssigned,
                IsDeleted = false,
                CreatedAt = DateTime.Now
            };
            _context.TblLeadMasters.Add(LeadViewModel);
            await _context.SaveChangesAsync();

            return RedirectToAction("Leads");
        }
    }
}
