char znak = ' ';
char znak1 = '*';
int temp;
int temp2;
int temp3;
int temp4;
int temp5=0;
int temp6=0;
int.TryParse(Console.ReadLine(), out  temp2);
int Theight = temp2;
if (temp2>2 && temp2<10){
    temp3=(Theight*2)-1;
for (int i =0; i<= Theight ; i++)
{
    temp5++;
    temp = (temp5*2)-1;
    temp4 = (temp3-temp)/2;
    string line = new string(znak1,temp);
    string blank = new string(znak,temp4);
    Console.WriteLine(blank+line+blank);
    temp=temp-2;
}

}
else
{
    Console.WriteLine("niepoprawna wartosc");
}