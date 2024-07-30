// See https://aka.ms/new-console-template for more information

void Exer1()
{
    int num;
    Console.Write("Digite um numero: ");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Convert.ToString(num*num));
}


void Exer2()
{
    int num;
    Console.Write("Digite um numero: ");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Convert.ToString(num * 2));
}


void Exer3()
{
    double n1,n2,n3,n4;
    Console.Write("Digite o Primeiro numero: ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o Segundo numero: ");
    n2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o Terceiro numero: ");
    n3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o quarto numero: ");
    n4 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Convert.ToString((n1+n2+n3+n4)/4));
}


void Exer4()
{
    double km, lt;
    Console.Write("Digite a Quilometragem: ");
    km = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a Quantidade de Litros: ");
    lt = Convert.ToDouble(Console.ReadLine());
       
    Console.WriteLine(Convert.ToString(km/lt));
}

void Exer5()
{
    double preco, quant, anos;
    Console.Write("Digite o preço do Cigarro: ");
    preco = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a Quantidade consumida por dia: ");
    quant = Convert.ToDouble(Console.ReadLine());
    Console.Write("Há quantos anos fumando: ");
    anos = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(Convert.ToString((anos*365)*(preco*quant)));
}


void Exer6()
{
    int valor,notas50,notas20,notas10;
    Console.Write("Digite o valor a ser sacado: ");
    valor = Convert.ToInt32(Console.ReadLine());
    notas50 = valor / 50;
    notas20 = (valor % 50)/20;
    notas10 = ((valor % 50)%20)/10;

    Console.WriteLine(Convert.ToString("50: "+notas50+"\t20: "+notas20+"\t10: "+notas10));
}



void Exer7()
{
    int idade, meses, anos, dias;
    Console.Write("Digite a idade em dias: ");
    idade = Convert.ToInt32(Console.ReadLine());
    anos = idade / 365;
    meses = (idade % 365)/30;
    dias = (idade % 365) % 30;

    

    Console.WriteLine(Convert.ToString(anos + " Anos, "+ meses +" meses, "+ dias + " dias."));
}

Exer6();
