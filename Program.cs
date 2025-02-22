using System;
using System.ComponentModel.Design;
/*
Console.WriteLine("< Bu \"KALKULYATOR\" dasturi >");

Console.WriteLine("Ikkita son kiriting: ");
Console.Write("1-son: ");
double son1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2-son: ");
double son2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Bajariladigan arifmetik amalni kiriting, iltimos faqat +, -, *, /, % amallarini kiriting:\n>>> ");
char amal = Convert.ToChar(Console.ReadLine());

double natija = 0;
if (amal == '+')
{
    natija = son1 + son2;
}
else if (amal == '-')
{
    natija = son1 - son2;
}
else if (amal == '*')
{
    natija = son1 * son2;
}
else if (amal == '/')
{
    natija = son1 / son2;
}
else if (amal == '%')
{
    natija = son1 % son2;
}

Console.WriteLine($"'{amal}' amali uchun natija: {natija}");
*/
/*
Console.WriteLine("< Bu \"KETMA-KET RAQAMLAR YIG\'INDISINI HISOBLASH\" DASTURI >");

Console.Write("Musbat butun son kiriting:\n>>> ");
int N = Convert.ToInt32(Console.ReadLine());

int natija = (N+1)*N/2;
Console.WriteLine($"{N} sonigacha bo'lgan raqamlar yig'indisi: {natija}.");
*/
Console.WriteLine("< Bu \"PARITET TEKSHIRUVI\" DASTURI >");

Console.Write("Biror butun son kiriting: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($"'{n}' soni juft.");
}
else
{
    Console.WriteLine($"'{n}' soni toq.");
}
