

using System.ComponentModel;
double y = 0; double x = 0; 

Console.WriteLine("Calculador em C#");
Console.WriteLine("----------------");
Console.WriteLine("Digite o número que deseja calcular");
 y = double.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número que deseja calcular");
 x = double.Parse(Console.ReadLine());
Console.WriteLine("Ele irá te mostrar os seguintes resultados");
Console.WriteLine("\t+ adição");
Console.WriteLine("\t- subtração");
Console.WriteLine("\t/ divisão");
Console.WriteLine("\t* multiplicação");
Console.WriteLine("\t^  Raiz");
Console.WriteLine("qual delas?");


switch (Console.ReadLine())
{
    case "+":
        Console.WriteLine($"Resultado: {y} + {x} = " + (x + y));
        break;
    case "-":
        Console.WriteLine($"Resultado: {y} - {x} = " + (x - y));
        break;
    case "*":
        Console.WriteLine($"Resultado: {y} * {x} = " + (x * y));
        break;
    case "/":
        Console.WriteLine($"Resultado: {y} / {x} = " + (x / y));
        break;  

}

        Console.WriteLine("Pressione qualquer tecla para fechar");
        Console.ReadKey();




