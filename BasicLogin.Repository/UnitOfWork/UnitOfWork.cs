using BasicLogin.Model;
using BasicLogin.Repository.GenericRepository;
using BasicLogin.Repository.NonGenericRepository;

namespace BasicLogin.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _context { get; set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            this._context = context;
        }

        private AuthenticationRepositoryMethod authenticationRepositoryMethod;
        public AuthenticationRepositoryMethod AuthenticationRepositoryMethod
        {
            get
            {
                if (this.authenticationRepositoryMethod == null)
                {
                    this.authenticationRepositoryMethod = new AuthenticationRepositoryMethod(_context);
                }
                return this.authenticationRepositoryMethod;
            }
        }

        private IRepository<EmployeeInfo> tblEmployeeInfoRepository;
        public IRepository<EmployeeInfo> TblEmployeeInfoRepository
        {
            get
            {
                if (this.tblEmployeeInfoRepository == null)
                {
                    this.tblEmployeeInfoRepository = new RepositoryImplementation<EmployeeInfo>(_context);
                }
                return tblEmployeeInfoRepository;
            }
        }

        private IRepository<UserInfo> tblUserInfo;
        public IRepository<UserInfo> TblUserInfo
        {
            get
            {
                if (this.tblUserInfo == null)
                {
                    this.tblUserInfo = new RepositoryImplementation<UserInfo>(_context);
                }
                return tblUserInfo;
            }
        }


    }
}
