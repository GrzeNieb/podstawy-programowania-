int goldperday;
int goldsum=0;
int days = 1;
int goldenday=0;
Console.WriteLine("podaj ile dni podrozy");
for (int.TryParse(Console.ReadLine(), out int daysoftravel); daysoftravel>0 && daysoftravel<=7; daysoftravel--)
{
    Console.WriteLine("Ile zlota dnia "+days+"?");
    int.TryParse(Console.ReadLine(), out goldperday);
    goldsum=goldsum+goldperday;
    days++;
    if (goldperday >= 10)
    {
        goldenday++;
    }
}
Console.WriteLine("suma zlota to: "+goldsum);
Console.WriteLine("ilosc dni gdzie bylo wiecej niz 10 zlota: "+goldenday);

