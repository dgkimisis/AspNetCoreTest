using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTest.Repository
{
    //Order View Component
    [ViewComponent(Name = "Order")]
    public class XKU : ViewComponent 
    {
        private readonly AspNetCoreTest.Models.AspContext _aspnetcontext;

        public XKU(AspNetCoreTest.Models.AspContext aspnetcontext)
        {
            this._aspnetcontext = aspnetcontext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _aspnetcontext.Orders.ToListAsync();
            return View(items);
        }

    }
}
