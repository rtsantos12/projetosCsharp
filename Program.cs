using System;
Console.WriteLine("Conversor 1.0");
Console.WriteLine("insira a opção 1, 2 ou 3");

int opção = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("digite o valor em graus");

double graus = Convert.ToInt32(Console.ReadLine());

double resultado = graus - 32 / 1.8;
double resultado2 = graus * 1.8 + 32;


do
{
    switch (opção)
    {
        case 1:
            opção = 1;
            Console.WriteLine(resultado);
            break;

        case 2:opção = 2;
            Console.WriteLine(resultado2);
            break;
        
            default:
            break;

        
    
    }
    if (opção == 3)
    {
        Console.WriteLine("pressione enter para voltar ao menu");
        Console.ReadLine();
        Console.Clear();

    }
    


} while (opção == 3);












