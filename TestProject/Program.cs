// See https://aka.ms/new-console-template for more information

using System;

int i = 0;
while (true)
{
    if (i == 10)
    {
        break;      // Non-Compliant
    }

    Console.WriteLine(i);
    i++;
}

Console.WriteLine("Hello, World!");