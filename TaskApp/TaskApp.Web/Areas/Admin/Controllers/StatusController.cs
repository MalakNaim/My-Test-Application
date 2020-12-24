using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using Unit.Data;
using TaskApp.Areas.Admin.Controllers;
using TaskApp.Helper;
using TaskApp.Data.DbEntity;
using AutoMapper;
using TaskApp.Web.ViewModels;
using TaskApp.Web.DTOs;
using TaskApp.Areas.Admin.Controllers;
using TaskApp.Data;
using TaskApp.DbEntity;
using TaskApp.Web.DTOs.StatusDTO;

namespace Unit.Data.Areas.Admin.Controllers
{

    public class StatusController : BaseController
    {

        public StatusController(UserManager<IdentityUser> userManager,TaskAppDbContext context, IMapper mapper) : base(userManager,context,mapper)
        { 
        }

        // GET: Admin/Statuss
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult IndexAjax([FromBody]dynamic data)
        {

            DataTableParameters d = new DataTableParameters(data);

            var query = _context.Status.Where(x => x.IsDelete == false && (x.Name.Contains(d.SearchKey) || d.SearchKey == null)).OrderByDescending(x => x.CreatedAt).ToList();

            int totalCount = query.Count();

            var items = query.Skip(d.Start).Take(d.Length).ToList();
            var itemsVM = _mapper.Map<List<Status>, List<StatusVM>>(items);
            var result =
               new
               {
                   draw = d.Draw,
                   recordsTotal = totalCount,
                   recordsFiltered = totalCount,
                   data = itemsVM
               };

            return Json(result);
        }


        // GET: Admin/Statuss/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Status = await _context.Status
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Status == null)
            {
                return NotFound();
            }

            return View(Status);
        }

        // GET: Admin/Statuss/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateStatusDTO statusDTO)
        {
            if (ModelState.IsValid)
            {
                var status = _mapper.Map<CreateStatusDTO, Status>(statusDTO);
                var isExists = _context.Status.Count(x => x.Name == statusDTO.Name) > 0;
                if (isExists)
                {
                    return Json(new
                    {
                        msg = "w: This Type was added before",
                        status = 0,
                        close = 0
                    });
                }
                 status.CreatedBy = ViewBag.UserID;
                _context.Add(status);
                await _context.SaveChangesAsync();
                return Json(new {
                    msg="s: Type Added Successfully" ,
                    status= 1,
                    close= 1
                });
            }
            return View(statusDTO);
        }

        // GET: Admin/Statuss/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Status = await _context.Status.FindAsync(id);
            var status = _mapper.Map<Status, EditStatusDTO>(Status);
            if (Status == null)
            {
                return NotFound();
            }
            return View(status);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditStatusDTO statusDTO)
        {
            if (id != statusDTO.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var isExists = _context.Status.Count(x => x.Name == statusDTO.Name && x.ID != statusDTO.ID) > 0;
                if (isExists)
                {
                    return Json(new
                    {
                        msg = "w: This Type was added before",
                        status = 0,
                        close = 0
                    });
                }
                var StatusDB = _context.Status.Find(id);
                StatusDB.Name = statusDTO.Name;
                StatusDB.UpdatedAt = DateTime.Now;
                StatusDB.UpdatedBy = ViewBag.UserID;              
                _context.Update(StatusDB);
                await _context.SaveChangesAsync();
                return Json(new
                {
                    msg = "s: Type Updated Successfully",
                    status = 1,
                    close = 1
                });
            }
            return View(statusDTO);
        }

        // GET: Admin/Statuss/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Status = await _context.Status
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Status == null)
            {
                return NotFound();
            }
            Status.IsDelete = true;
            _context.Update(Status);
            await _context.SaveChangesAsync();
            return Json(new
            {
                msg = "s: Type Deleted Successfully",
                status = 1,
                close = 1
            });
        }

      
        private bool StatusExists(int id)
        {
            return _context.Status.Any(e => e.ID == id);
        }
    }
}
