using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.data;
using OdeToFood.core;

namespace OdeToFood.Pages.Restaurents
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurentData restaurentData;

        public string Message { get; set; }
        public IEnumerable <Restaurent> Restaurents { get; set; }

        public ListModel(IConfiguration config,
                         IRestaurentData restaurentData )
        {
            this.config = config;
        }

        public void OnGet()
        {
            Message = config["Message"];
            Restaurents = restaurentData.GetAll();
        }
    }
}
