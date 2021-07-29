using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GogsExhibition;
using GogsExhibition.Classes;
using NLog;
using GogsExhibition.Controllers.Abstraction;
using Microsoft.AspNetCore.Authorization;

namespace GogsExhibition.Controllers
{  
    public class CountriesController : OverloadedController<Country>
    {
        public CountriesController(DbSets dbSets, ILogger logger) : base(dbSets, logger)
        {
        }
    }
}
