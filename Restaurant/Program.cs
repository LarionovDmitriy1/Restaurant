﻿using Restaurant;

void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Меню ресторана");
    Console.WriteLine();
    Console.WriteLine("1. Burger");
    Console.WriteLine("2. Fries");
    Console.WriteLine("3. Chicken");
    Console.WriteLine("4. Pizza");
    Console.WriteLine("5. Sandwich");
    Console.WriteLine("6. Onionrings");
    Console.WriteLine("7. Milkshake");
    Console.WriteLine("8. Coke");
    Console.WriteLine();
    Console.WriteLine("Ваш заказ");
}
void SelectedMenuItem()
{
    string menu = Console.ReadLine();
    MenuParser.Parser(menu);
}
while (true)
{
    Menu();
    SelectedMenuItem();
}