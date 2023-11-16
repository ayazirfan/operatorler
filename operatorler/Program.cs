Console.WriteLine("*****Atama ve İşlemli atama***");
// Atama ve İşlemli atama
int x = 3;
int y = 3;
y = y+2;

Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
y /= 5;
Console.WriteLine(y);
x *= 2;
Console.WriteLine(x);

Console.WriteLine("*****Mantıksal operatörler***");
//Mantıksal operatörler
// || $$ !

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted)
    Console.WriteLine("Perfect!");

if(isSuccess || isCompleted)
    Console.WriteLine("Great!");

if(isSuccess && !isCompleted)
    Console.WriteLine("Fine!");

Console.WriteLine("*****İlişkisel operatörler***");
// İlişkisel operatörler
//< > <= >= == != 

int a = 3 ;
int b = 4 ;

bool sonuc = a<b;

Console.WriteLine(sonuc);
sonuc = a>b;
Console.WriteLine(sonuc);
sonuc = a>=b;
Console.WriteLine(sonuc);
sonuc = a<=b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a!=b;
Console.WriteLine(sonuc);


Console.WriteLine("*****Aritmetik Operaörler***");

int sayı1 = 5;
int sayı2 = 10;
int sonuc1 = sayı1/sayı2;
Console.WriteLine(sonuc1);

sonuc1 = sayı1*sayı2;
Console.WriteLine(sonuc1);
sonuc1 = sayı1+sayı2;
Console.WriteLine(sonuc1);
sonuc1 = ++sayı1;
Console.WriteLine(sonuc1);


Console.WriteLine("*****MOD***");

int sonuc2 = 20%3;
Console.WriteLine(sonuc2);











