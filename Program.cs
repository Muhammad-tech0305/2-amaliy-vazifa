using System;

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