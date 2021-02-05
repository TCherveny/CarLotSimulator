using System;
using System.Collections.Generic;
using System.Text;

public static class CarLotList
{
    static CarLotList()
    {
        Name = "Car Nation";
    }

    public static string Name { get; set; }

    public static void PrintName()
    {
        Console.WriteLine($"The name of this carlot is {Name}");
    }

    public static string AddExclamation(string input)
    {
        return input += "!";
    }

}
