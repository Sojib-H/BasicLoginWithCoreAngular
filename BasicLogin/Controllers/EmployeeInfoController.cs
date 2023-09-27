using BasicLogin.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BasicLogin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeInfoController : BaseController
    {
        public EmployeeInfoController(IUnitOfWork uow)
        {
            Uow = uow;
        }

        [HttpGet("[action]")]
        public dynamic GetAllEmployee()
        {
            try
            {
                return Uow.TblEmployeeInfoRepository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
