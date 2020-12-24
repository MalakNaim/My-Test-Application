using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using TaskApp.Data; 

namespace TaskApp.Areas.Admin.Controllers
{
    [Area("Admin")]
     
     public class BaseController : Controller
    {
        protected readonly UserManager<IdentityUser> _userManager;
        protected readonly TaskAppDbContext _context;
        protected String UserId;
        protected int CurrentAccountID;
        protected String UserEmail;
        public int UserType;
        protected readonly IMapper _mapper; 
        public BaseController(UserManager<IdentityUser> userManager, TaskAppDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }
       
        public override void OnActionExecuting(ActionExecutingContext context)
        {
             ViewBag.db = _context;
            if (User.Identity.IsAuthenticated)
            {
                base.OnActionExecuting(context);
                { 
                }
            }
        }
    }
}