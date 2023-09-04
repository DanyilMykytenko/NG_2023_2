namespace Skeleton.BLL.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException()
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

public class UserModelEmptyFieldException : Exception
{
    public UserModelEmptyFieldException()
        : base($"Name, Surname or Password fields were empty")
    {
    }
}