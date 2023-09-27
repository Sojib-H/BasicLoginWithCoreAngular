using BasicLogin.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BasicLogin.Controllers
{
    public class BaseController : Controller
    {
        protected IUnitOfWork Uow { get; set; }
    }
}
