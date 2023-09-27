using BasicLogin.Model;
using BasicLogin.Repository.GenericRepository;
using BasicLogin.Repository.NonGenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogin.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        AuthenticationRepositoryMethod AuthenticationRepositoryMethod { get; }
        IRepository<EmployeeInfo> TblEmployeeInfoRepository { get; }
        IRepository<UserInfo> TblUserInfo { get; }
    }
}
