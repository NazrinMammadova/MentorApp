using MentorApp.DAL;
using MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            PricingVM pricingVM = new PricingVM();
            pricingVM.Pricings = _context.Pricings.Include(p=>p.PricingServices).ToList();
            pricingVM.Services = _context.Services.ToList();

            return View(pricingVM);

        }

    }
}
