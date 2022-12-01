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
        List<string> list = new List<string>();
        if (selected.Contains("burger"))
        {
            selected = selected.Replace("burger", "Burger ");
            list.Add(selected);
        }
        if (selected.Contains("fries"))
        {
            selected = selected.Replace("fries", "Fries ");
            list.Add(selected);
        }
        if (selected.Contains("chicken"))
        {
            selected = selected.Replace("chicken", "Chicken ");
            list.Add(selected);
        }
        if (selected.Contains("pizza"))
        {
            selected = selected.Replace("pizza", "Pizza ");
            list.Add(selected);
        }
        if (selected.Contains("sandwich"))
        {
            selected = selected.Replace("sandwich", "Sandwich ");
            list.Add(selected);
        }
        if (selected.Contains("onionrings"))
        {
            selected = selected.Replace("onionrings", "Onionrings ");
            list.Add(selected);
        }
        if (selected.Contains("milkshake"))
        {
            selected = selected.Replace("milkshake", "Milkshake ");
            list.Add(selected);
        }
        if (selected.Contains("coke"))
        {
            selected = selected.Replace("coke", "Coke ");
            list.Add(selected);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Строка пуста или такого нет");
            Console.WriteLine();
        }
    }
}
