// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

Console.Clear();

//Problema 1

double valor = 1000;
double juros = 0.053;
int periodo = 6;

Console.WriteLine("Problema 1 : Juros Compostos");

double rendimento = valor*Math.Pow((1+juros),periodo);

Console.WriteLine($"Rendimento do valor {valor:C} com {juros:P} em {periodo} meses vai render:");
Console.WriteLine($"{rendimento:F}");

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.ReadKey();

//Problema 2

valor = 3800;
juros = 0.0125;
periodo = 6;

Console.WriteLine("Problema 2 : Tabela 6 meses");

Console.WriteLine($"Rendimento do valor {valor:C} com {juros:P} em {periodo} meses vai render:");

for(int i = 0; i < periodo+1; i++){
    rendimento = valor*Math.Pow(1+juros,i);
    Console.WriteLine($"Mês: {i} | Juros: {rendimento-valor:F} | Rendimento: {rendimento:F}");
}

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.ReadKey();

//Problema 3

Console.WriteLine("Problema 3 : Rendimento com entradas");

Console.Write("Digite o valor: R$");
valor = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o juros: ");
juros = Convert.ToDouble(Console.ReadLine())/100;

Console.Write("Digite o Tempo (mês): ");
periodo = Convert.ToInt16(Console.ReadLine());

rendimento = valor*Math.Pow(1+juros,periodo);

Console.WriteLine($"O rendimento total foi de R${rendimento:F}");

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.ReadKey();

//Problema 4

Console.WriteLine("Problema 4 : Saque no 5º mês");

valor = 2000;
juros = 0.02;
periodo = 8;
double saque = 1000;

Console.WriteLine($"Rendimento do valor {valor:C} com {juros:P} em {periodo} meses vai render:");

for(int i = 0; i < periodo+1; i++){
    rendimento = valor*Math.Pow(1+juros,i);
    if(i>5){
        rendimento = valor*Math.Pow(1+juros,i-5);
    }
    double resgate = 0;
    if(i == 5){
        resgate = saque;
    }

    Console.WriteLine($"Mês: {i} | juros: {rendimento-valor:F} | rendimento: {rendimento:F} | resgate: {resgate}");
    if(i == 5){
        valor = rendimento - resgate;
    }
}

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.ReadKey();

//Problema 5

Console.WriteLine("Problema 5: Valor inicial para ter resultado final R$7390.61");

Console.WriteLine("Quanto de Juros vai ter?");
juros = Convert.ToDouble(Console.ReadLine())/100;
periodo = 6;
rendimento = 7390.61;
valor = rendimento/Math.Pow(1+juros,periodo);

Console.WriteLine($"Para ter como rendimento total R$7390,61 com {juros:P} de juros, deve ter R${valor:F} como valor inicial");
Console.ReadKey();