Console.WriteLine("podaj swoj wzrost:");
double wzrost = double.Parse(Console.ReadLine());

if (wzrost <= 152.9)
{
    Console.WriteLine("jestes karłowaty");
}
else if (wzrost > 152.9 && wzrost <= 162.9)
{
    Console.WriteLine("jestes niski");
}
else if (wzrost > 162.9 && wzrost <= 172)
{
    Console.WriteLine("jestes sredniego wzrostu");
}
else if (wzrost > 172 && wzrost <= 177.9)
{
    Console.WriteLine("jestes wysoki");
}
else if (wzrost > 177.9)
{
    Console.WriteLine("jestes bardzo wysoki");
}