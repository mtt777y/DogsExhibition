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

namespace GogsExhibition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexesController : OverloadedController<Sex>
    {
        public SexesController(DbSets dbSets, ILogger logger) : base(dbSets, logger)
        {
        }
    }
}
