using Projet_UAA6_Recap.Services;


Console.WriteLine("Projet setup avec des tests avec xUnit");

double res1 = MathService.Addition(23, 19);
Console.WriteLine($"23 + 19 = {res1}");

double res2 = MathService.Addition(0.1, 0.2);
Console.WriteLine($"0.1 + 0.2 = {res2}");