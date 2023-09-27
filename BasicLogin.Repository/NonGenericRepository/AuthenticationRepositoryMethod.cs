using BasicLogin.Model;
using BasicLogin.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Repository.NonGenericRepository
{
    public class AuthenticationRepositoryMethod : RepositoryImplementation<dynamic>
    {

        public AuthenticationRepositoryMethod(ApplicationDBContext context) : base(context) { }
        private ApplicationDBContext Context => _context;
        public SessionDataModel Login(LoginEntity user)
        {
            try
            {
                var retMsg = "";
                var loginuser = (from Ei in Context.EmployeeInfo
                                 join Ui in Context.UserInfo on Ei.EmpID equals Ui.EmpID
                                 where Ei.Email == user.LoginID && Ui.Password == user.Password
                                 select new
                                 {
                                     Ui,
                                     Ei
                                 }).FirstOrDefault();
                if (loginuser == null)
                {
                    retMsg = "Invalid username or password";
                }
                else
                {
                    if (loginuser.Ui.IsActive == false)
                    {
                        retMsg = user.LoginID + " is Deactive";
                    }
                    else
                    {

                        return new SessionDataModel()
                        {
                            MsgCode = "OK",
                            Msg = "Successfull",
                            UserID = loginuser.Ui.UserID,
                            UserName = loginuser.Ei.EmpName,
                            CompanyID = loginuser.Ui.CompanyID,
                        };
                    }
                }
                return new SessionDataModel()
                {
                    MsgCode = "Error",
                    Msg = retMsg
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
