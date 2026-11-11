using System.Net;
int round_am;
Console.WriteLine("podaj liczbe tur");
    do
    {
        bool parse = int.TryParse(Console.ReadLine(), out round_am);
        if (parse == true)
        {
            if(round_am < 1 || round_am > 10)
            {
                Console.WriteLine("podana wartosc jest niepoprawna");
                continue;
            }
            else
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("wpisano niepoprawna wartosc");
            continue;
        }
    
    }
    while(round_am < 1 || round_am > 10);
    Console.WriteLine("Zaczynam gre na: " + round_am + " tur");
    

    
