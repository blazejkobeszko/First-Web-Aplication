using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Pierwszy_projekt.Models;

namespace Pierwszy_projekt.Pages
{
    public class AddressModel : PageModel
    {
        public Address Addr { get; set; }
        public void OnGet()
        {
            var SessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (SessionAddress != null)
                Addr = JsonConvert.DeserializeObject<Address>(SessionAddress);
        }
    }
}
