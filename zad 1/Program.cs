int NumbersWhile = 1;
int NumbersDoWhile = 1;
Console.WriteLine("PROGRAM DO ODLICZNANIA");
Console.Write("Rosnąco: ");

while (NumbersWhile <= 10)
{
    Console.Write(NumbersWhile+++" ");
}

Console.Write("\nMalejąco: ");

do
{
    Console.Write(NumbersDoWhile+++" ");
}
while(NumbersDoWhile>0 && NumbersDoWhile<=10);

Console.Write("\nwypisane od 10 do 1 for: ");

for (int NumbersFor = 10; NumbersFor>0 && NumbersFor<=10; NumbersFor--)
{
    Console.Write(NumbersFor+ " ");
}

Console.Write("\nwypisane od 0 do 20 parzyste for: ");

for (int NumbersFor = 0; NumbersFor>-1 && NumbersFor<=20; NumbersFor=NumbersFor+2)
{
    Console.Write(NumbersFor+ " ");
}
Console.WriteLine("\nStart!");