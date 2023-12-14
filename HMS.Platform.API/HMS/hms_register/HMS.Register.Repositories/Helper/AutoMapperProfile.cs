using AutoMapper;
using HMS.Register.Repositories.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Register.Repositories.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Register,RegisterDto>();
            CreateMap<SignUp,SignupDto>();
        }
    }
}
