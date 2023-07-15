//SINGLE RESPONSIBILITY
//EACH UNIT OF CODE MUST HAVE THE ONLY ONE AIM

int GetSum(int a, int b)
{
    return a + b;
}

int GetNumber(int a)
{
    return a;
}

GetSum(GetNumber(1), GetNumber(2));