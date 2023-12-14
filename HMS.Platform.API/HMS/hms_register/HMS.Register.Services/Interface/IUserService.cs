using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Services.Interface
{
    public interface IUserService
    {
        Task<HttpMessageResponse> LoginWithToken(UserVM model);
        Task LogOut();
    }
}
