using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant;

public static class MenuParser
{

    public static void Parser(string selected)
    {
        if (selected.Contains("burger"))
        {
            selected = selected.Replace("burger", "Burger ");
        }
        if (selected.Contains("fries"))
        {
            selected = selected.Replace("fries", "Fries ");
        }
        if (selected.Contains("chicken"))
        {
            selected = selected.Replace("chicken", "Chicken ");
        }
        if (selected.Contains("pizza"))
        {
            selected = selected.Replace("pizza", "Pizza ");
        }
        if (selected.Contains("sandwich"))
        {
            selected = selected.Replace("sandwich", "Sandwich ");
        }
        if (selected.Contains("onionrings"))
        {
            selected = selected.Replace("onionrings", "Onionrings ");
        }
        if (selected.Contains("milkshake"))
        {
            selected = selected.Replace("milkshake", "Milkshake ");
        }
        if (selected.Contains("coke"))
        {
            selected = selected.Replace("coke", "Coke ");
        }
        if (selected.Length != 0)
        {
            Console.WriteLine();
            Console.WriteLine(selected);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Строка пуста или такого нет");
            Console.WriteLine();
        }
    }
}
