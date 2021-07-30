using GogsExhibition.Classes;
using NLog;
using GogsExhibition.Controllers.Abstraction;

namespace GogsExhibition.Controllers
{
    public class UsersController : OverloadedController<User>
    {
        public UsersController(DbSets dbSets, ILogger logger) : base(dbSets, logger)
        {
        }
    }
}
