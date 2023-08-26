using AutoMapper;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Mapping
{
    public class AutoMapperProfileWeb : Profile
    {
        public AutoMapperProfileWeb()
        {
            CreateMap<UserDto,UserModel>()
                .ForMember(user => user.id,
                    opt => opt.MapFrom(userModel =>userModel.id))
                .ForMember(user => user.name,
                    opt => opt.MapFrom(userModel => userModel.name))
                .ForMember(user => user.surname,
                    opt => opt.MapFrom(userModel => userModel.surname))
                .ForMember(user => user.password,
                    opt => opt.MapFrom(userModel => userModel.password))
                .ForMember(user => user.phone,
                    opt => opt.MapFrom(userModel => userModel.phone))
                .ForMember(user => user.login,
                    opt => opt.MapFrom(userModel => userModel.login));

            CreateMap<UserModel, UserDto>()
                .ForMember(user => user.id,
                    opt => opt.MapFrom(userModel => userModel.id))
                .ForMember(user => user.name,
                    opt => opt.MapFrom(userModel => userModel.name))
                .ForMember(user => user.surname,
                    opt => opt.MapFrom(userModel => userModel.surname))
                .ForMember(user => user.password,
                    opt => opt.MapFrom(userModel => userModel.password))
                .ForMember(user => user.phone,
                    opt => opt.MapFrom(userModel => userModel.phone))
                .ForMember(user => user.login,
                    opt => opt.MapFrom(userModel => userModel.login));
        }
    }
}
