/*
 * Multiplicação rápida - Um algoritmo para multiplicação 
 * rápida por 11 de números de 2 dígitos funciona assim: 
 * para multiplicar 81 x 11, some os dígitos do número 
 * (8 + 1 = 9) e insira o resultado entre os dígitos 
 * (891). Se a soma der maior que 9, incremente o dígito 
 * da esquerda: 56 x 11 = 616. Faça um programa que efetue 
 * multiplicações por 11 usando este algoritmo.
 */
using System;

Console.WriteLine("Olá, escreva os dois dígitos do número" +
    " que deseja multiplicar por 11:");
int numeroDigitado = Console.ReadLine();
int primeiroNumero = Convert.ToInt32(numeroDigitado.ToString().Substring(0, 1));
int segundoNumero = Convert.ToInt32(numeroDigitado.ToString().Substring(1, 1));
int somaDigitos = primeiroNumero + segundoNumero;

if (somaDigitos > 9)
{
    primeiroNumero++;
    somaDigitos = Convert.ToInt32(somaDigitos.ToString().Substring(1, 1));

    Console.WriteLine($" {numeroDigitado} x 11 = {primeiroNumero}{somaDigitos}{segundoNumero}");
} 
else
{
    Console.WriteLine($" {numeroDigitado} x 11 = {primeiroNumero}{somaDigitos}{segundoNumero}");
}

