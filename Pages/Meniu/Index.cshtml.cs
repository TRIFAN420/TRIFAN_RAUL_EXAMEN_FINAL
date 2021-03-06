﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TRIFAN_RAUL_EXAMEN_FINAL.Data;
using TRIFAN_RAUL_EXAMEN_FINAL.Models;

namespace TRIFAN_RAUL_EXAMEN_FINAL.Pages.Meniu
{
    public class IndexModel : PageModel
    {
        private readonly TRIFAN_RAUL_EXAMEN_FINAL.Data.TRIFAN_RAUL_EXAMEN_FINALContext _context;

        public IndexModel(TRIFAN_RAUL_EXAMEN_FINAL.Data.TRIFAN_RAUL_EXAMEN_FINALContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurant.ToListAsync();
        }
    }
}
