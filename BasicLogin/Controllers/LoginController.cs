using BasicLogin.Infrastructure;
using BasicLogin.Model;
using BasicLogin.Repository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace BasicLogin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : BaseController
    {
        public LoginController(IUnitOfWork uow)
        {
            Uow = uow;
        }
        [HttpPost("[action]")]
        public async Task<SessionDataModel> Login([FromBody] LoginEntity entity)
        {
            try
            {
                var key = "b14ca5898a4e4133bbce2ea2315a1916";
                entity.Password = AesOperation.EncryptString(key, entity.Password);
                var search = Uow.AuthenticationRepositoryMethod.Login(entity);

                if (search.MsgCode == "OK")
                {
                    //entity.Token = CreateJwt(search);
                    //var UserList = Uow.TblUserInfo.FirstOrDefault(m=>m.UserID == search.UserID);
                    //UserList.Token = entity.Token;
                    //await Uow.TblUserInfo.Update(UserList);
                    return new SessionDataModel()
                    {
                        MsgCode = "OK",
                        Msg = "Successfull",
                        UserID = search.UserID,
                        UserName = search.UserName,
                        CompanyID = search.CompanyID,
                        Token = "",
                    };
                }
                else
                {
                    return new SessionDataModel()
                    {
                        MsgCode = "Error",
                        Msg = search.Msg,
                    };

                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
