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

namespace GogsExhibition.Controllers.Abstraction
{
    public class OverloadedController : ControllerBase
    {
        protected DbSets _context;
        protected ILogger _logger;

        public OverloadedController(DbSets dbSets, ILogger logger)
        {
            _context = dbSets;
            _logger = logger;
            _logger.Trace("Controller running....");
        }
    }

}
