using Microsoft.VisualBasic;
using System;
using System.Globalization;

static void main(Strings[] args)
{
    Console.WriteLine("Digite um número inteiro de 2 dígitos para o dia:");
    int dia = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite um número inteiro de 2 dígitos para o mês:");
    int mes = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite um número inteiro de 4 dígitos para o ano:");
    int ano = Convert.ToInt32(Console.ReadLine());

    var data1 = new DateTime(ano, mes, dia);

    ToLongDateString()

    Console.WriteLine($"Bom dia! A data digitada foi dia ", data1.Day, " de ", getNomeMes, " de ", data1.Year);
}