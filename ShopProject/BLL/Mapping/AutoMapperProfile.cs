using AutoMapper;
using BLL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserModel, User>()
                .ForMember(user => user.Id,
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
                    opt => opt.MapFrom(userModel => userModel.login))
                .ReverseMap();

            CreateMap<User, UserModel>()
               .ForMember(user => user.id,
                   opt => opt.MapFrom(userModel => userModel.Id))
               .ForMember(user => user.name,
                   opt => opt.MapFrom(userModel => userModel.name))
               .ForMember(user => user.surname,
                   opt => opt.MapFrom(userModel => userModel.surname))
               .ForMember(user => user.password,
                   opt => opt.MapFrom(userModel => userModel.password))
               .ForMember(user => user.phone,
                   opt => opt.MapFrom(userModel => userModel.phone))
               .ForMember(user => user.login,
                   opt => opt.MapFrom(userModel => userModel.login))
               .ReverseMap();
        }
    }
}
