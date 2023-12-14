using HMS.Register.Repositories.Interface;
using HMS.Register.Repositories.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Repositories
{
    public class RegisterRepository : IRegisterRepository
    {
        public RegisterRepository()
        {

        }
        public RegisterDto Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RegisterDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public RegisterDto GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(RegisterDto obj)
        {
            throw new NotImplementedException();
        }

        public RegisterDto Update(RegisterDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
