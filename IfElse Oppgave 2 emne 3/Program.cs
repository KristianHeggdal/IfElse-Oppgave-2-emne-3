// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int number1 = 5;
int number2 = 5;
bool isEqual = false;

int Run()
{
    if (number1 == number2)
    {
        isEqual = true;
        Console.WriteLine("tallene er like");
    }
    else
    {
        isEqual = false;
        Console.WriteLine("tallene er ulike");
    }

    if (isEqual)
    {
        Console.WriteLine($"summen er:{number1*number2}");
    }
    else
    {
       Console.WriteLine($"summen er:{number1+number2}");
    }

    return number1;
}

Run();