namespace Skeleton.BLL.Exceptions;

public class UserNotFoundExceptionException : Exception
{
    public UserNotFoundExceptionException()
        : base($"Such user doesn't exist")
    {
    }
}

public class UserRegistrationFailedException : Exception
{
    public UserRegistrationFailedException(string password)
        : base($"User with password {password} already exists")
    {
        // easter egg
    }
}