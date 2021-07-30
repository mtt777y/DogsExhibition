using GogsExhibition.Classes;
using NLog;
using GogsExhibition.Controllers.Abstraction;

namespace GogsExhibition.Controllers
{
    public class RolesController : OverloadedController<Role>
    {
        public RolesController(DbSets dbSets, ILogger logger) : base(dbSets, logger)
        {
        }
    }
}
