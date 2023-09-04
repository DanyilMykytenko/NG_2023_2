using AutoMapper;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.BLL.Models.UpdateModels;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public Task AddUserAsync(AddUserModel userModel)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUserAsync(UpdateUserModel userModel)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> GetUserAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}