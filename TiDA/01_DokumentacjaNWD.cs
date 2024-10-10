using System;

int NWD(int a, int b)
{
    while (b != a)
    {
        if (a > b)
            a -= b;
        if (b > a)
            b -= a;
    }

    return a;
}

Console.Write("Podaj a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Podaj a: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(NWD(a, b));

//**********************************************
//  nazwa funkcji: < NWD >
//  opis funkcji: < funkcja oblicz największy wspólny dzielnik dwóch liczb >
//  parametry: < nazwa parametru 1 – liczba
//               nazwa parametru 2 – liczba >
//  zwracany typ i opis: < zwraca typ int największego wspólnego dzielnika dwóch liczb >
//  autor: < numer zdającego >
//***********************************************

// draw.io - schematy blokowe
