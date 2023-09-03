namespace Skeleton.BLL.Exceptions;

public class TestNotFoundException : Exception
{
    public TestNotFoundException() 
        : base("Selected test wasn't found")
    {
    }
}