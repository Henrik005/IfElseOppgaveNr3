// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;


int num1 = 20;
int num2 = 10;


bool NumberCheck()
{
    if (num1 == 30 || num2 == 30 || (num1 + num2) == 30)
    {
        return true;
    }

    return false;
}

NumberCheck();
Console.WriteLine($"{NumberCheck()}");