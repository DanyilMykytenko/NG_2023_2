using Skeleton.BLL.Exceptions;
using Skeleton.BLL.Interfaces;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Guid> AuthenticateAsync(string surname, string password)
    {
        throw new NotImplementedException();
    }
}