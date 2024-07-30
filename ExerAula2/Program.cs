// See https://aka.ms/new-console-template for more information

using System;

double num;
// ler um numero
Console.Write("Digite o valor da venda: ");
num = Convert.ToDouble(Console.ReadLine()); // 67

// verificar se o numero é negativo
if (num > 500)
{
    Console.WriteLine(Convert.ToString(num-(num*0.12)));
}

else
{ 
    Console.WriteLine(Convert.ToString(num - (num * 0.06)));
}

