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
        var result = await _userRepository.GetUserByCredentialsAsync(surname, password);

        if (result is null)
        {
            throw new AuthException();
        }

        return result.Id;
    }
}