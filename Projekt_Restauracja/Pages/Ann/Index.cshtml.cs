using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Restauracja;
using Projekt_Restauracja.Data;

namespace Projekt_Restauracja.Pages.Ann
{
  
    public class IndexModel : PageModel
    {
        private readonly Projekt_Restauracja.Data.RestaurantDbContext _context;

        public IndexModel(Projekt_Restauracja.Data.RestaurantDbContext context)
        {
            _context = context;
        }

        public IList<Announcement> Announcement { get;set; }

        public async Task OnGetAsync()
        {
            Announcement = await _context.Announcements.ToListAsync();
        }
    }
}
