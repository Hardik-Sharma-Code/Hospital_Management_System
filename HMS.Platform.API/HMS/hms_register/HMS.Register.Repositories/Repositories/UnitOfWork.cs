using HMS.Register.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRegisterRepository _registerRepository;

        public UnitOfWork(IRegisterRepository registerRepository)
        {
            _registerRepository = registerRepository;
        }

        public IRegisterRepository RegisterRepository
        {
            get { return _registerRepository; }
        }
    }
}
