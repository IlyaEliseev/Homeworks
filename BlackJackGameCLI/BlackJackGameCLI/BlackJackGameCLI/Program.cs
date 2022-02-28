// See https://aka.ms/new-console-template for more information
using BlackJackGameCLI;

Shoe shoe = new();
shoe.FillShoe();

Card Card = Shoe.GetCard();
Console.ReadKey();