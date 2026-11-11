char blankspace = ' ';
char star = '*';
int star_am;
int Theight_check_h;
int Theight_static;
int blankspace_am;
int temp5=0;
int.TryParse(Console.ReadLine(), out  Theight_check_h);
int Theight = Theight_check_h;
if (Theight_check_h>2 && Theight_check_h<10){
    Theight_static=(Theight*2)-1;
for (int i =0; i<= Theight ; i++)
{
    temp5++;
    star_am = (temp5*2)-1;
    blankspace_am = (Theight_static-star_am)/2;
        if (blankspace_am >= 0)
        {
            string line = new string(star,star_am);
            string blank = new string(blankspace,blankspace_am);
            Console.WriteLine(blank+line+blank);
            star_am=star_am-2;
        }
        else
        {
            string line = new string(star,1);
            string blank = new string(blankspace,(Theight_static-1)/2);
            Console.WriteLine(blank+line+blank);
        }
    
}
}
else
{
    Console.WriteLine("niepoprawna wartosc");
}