using System;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
class Program
{
    //program hello world (c# main function)
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
    /*
    //kode : const
    const float phi = 3.14f;
    //deklarasi variabel & kata kunci var
    string name = "hevi";
    // ini merupakan komentar single line
    /* ini komentar multi line */

    /*
    // tipe data number
    int umur = 18;
    float phiphi = 3.14f;
    double tinggiBadan = 165.8;

    Console.WriteLine(phi);
    Console.WriteLine(tinggiBadan);
    Console.WriteLine(umur);
    */
    /*
    // string & backslash
    string firstName;
    string lastName = "DNCC";

    firstName = "Divisi Game";

    Console.WriteLine(firstName);
    Console.WriteLine(lastName);
    
    string hari = "senin \tselasa \trabu \tkamis \tjumat \tsabtu \tminggu";
    string bulan = "januari \tfebruari \tmaret \tapril \tjuni \tjuli";
    string anime = "\"Fate Series\"";

    Console.WriteLine(hari);
    Console.WriteLine(bulan);
    Console.WriteLine(anime);
    */
    /*
    //manipulasi string
    string txt = "selamat pagi hevi";
    string txtUpper = txt.ToUpper();
    string txtLower = txt.ToLower();
    Console.WriteLine(txtUpper);
    Console.WriteLine(txtLower);
    
    Console.WriteLine("Panjang Karakter dari txt adalah :"+txt.Length);

    //string interpolation
    
    string nama = "hevi ananda";
    var date = DateTime.Now;
    
    Console.WriteLine($"Perkenalkan nama saya {nama}, Hari ini adalah {date.DayOfWeek}");
    */
    /*
    //boolean
    bool benar = true;
    bool salah = false;
    
    if(benar == true){
        Console.WriteLine("Ini adalah pernyataan benar");
}else{
        Console.WriteLine("Ini adalah pernyataan salah");
    */

/*
      int angkaInt = 50;
      float angkaFloat = angkaInt;
      
      float angka1 = 3.56f;
      int angka2 = (int)angka1;
      
      Console.WriteLine(angkaFloat);
      Console.WriteLine(angka2);
      
      int angkaToString = 99;
      
      Console.WriteLine($"hasil dalam String adalah : {angkaToString}()");
       
       string pertama = "10";
       string kedua = "5";
       int sum = int.Parse(pertama) + int.Parse(kedua);
       Console.Write(sum);
       */
        /*
       //operasi aritmatika
       var hasil = 10 + 10;
       var hasil1 = 50-30;
       var hasil2 = -23;
       var hasil3 = 4 * 7;
       var hasil4 = 25 / 5;
       var hasil5 = 30 % 4;

       Console.WriteLine(hasil);
       Console.WriteLine(hasil1);
       Console.WriteLine(hasil2);
       Console.WriteLine(hasil3);
       Console.WriteLine(hasil4);
       Console.WriteLine(hasil5);
       */
        /*
       //increment dan decrement
       int a = 3;
       Console.WriteLine(a); //output 3
       Console.WriteLine(++a); //output 4
       Console.WriteLine(a); //output 4

        int a = 3;
       Console.WriteLine(a); //output 3
       Console.WriteLine(a++); //output 3
       Console.WriteLine(a); //output 4

        int a = 3;
       Console.WriteLine(a); //output 3
       Console.WriteLine(--a); //output 2
       Console.WriteLine(a); //output 2

        int a = 3;
       Console.WriteLine(a); //output 3
       Console.WriteLine(a--); //output 3
       Console.WriteLine(a); //output 2
    */
    /*
    //membuat array
    string[] divisi = ( "web", "mobile", "game" "multimedia" "jaringan" );
    Console.WriteLine(divisi[0]);
    Console.WriteLine(divisi[1]);
    Console.WriteLine(divisi[2]);
    Console.WriteLine(divisi[3]);
    Console.WriteLine(divisi[4]);

    string[] names = new string[5];
    names[0] = "web";
    names[0] = "mobile";
    names[0] = "game";
    names[0] = "multimedia";
    names[0] = "jaringan";
*/
/*
//kode array 2d
int[,] number = new int[2,3];
int[,] numbers = {{1, 2, 3}, {4, 5, 6}};
Console.WriteLine(number[0, 1]); //output 2
Console.WriteLine(number[1, 2]); //output 6
/*
//kode array 3d
int[,,] number = new int[2, 2, 3];
int[,,] numbers = {{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}, {10, 11, 12}}};
Console.WriteLine(number[0, 0, 0]); //output 2
Console.WriteLine(number[1, 1, 0]); //output \\
*/
/*
//list
var names = new List<string> { "Game", "Mobile", "web"};
for (inti = 0; i < names.Count; "")

Console.Write(names[i] + " ");
List<int> angka = new List<int>();
angka.Add(1);
angka.Add(2);
angka.Add(3);
angka.AddRange(new int[3] {4, 5, 6});
angka.Remove(1);
angka.RemoveAt(o)
*/
/*
int i = 5;
if (10> i)
{
Console.WriteLine("benar");
}
else
{
Console.WriteLine("salah");
*/
/*
int nilai = 75;
if (nilai >= 90)
{
    Console.WriteLine("Anda mendapatkan A.");
}
else if (nilai >= 80)
{
    Console.WriteLine("Anda mendapatkan B.");
}
else if (nilai >= 70)
{
    Console.WriteLine("Anda mendapatkan C.");
}
    Console.WriteLine("Anda mendapatkan D atau E.");
}
else
{
*/
/*
int nilai = 75; switch (nilai)
{
    case > 95:
        Console.WriteLine("Memuaskan");
    break;
    case > 80:
        Console.WriteLine("Baik");
    break;
    case >= 75:
        Console.WriteLine("Cukup");
    break;
    default:
        Console.WriteLine("Kurang");
    break;
    }<#227-240 switch (nilai)
*/
/*
int angka = 10;
string hasil =(angka % 2 == 0) ? "Genap" : "Ganjil";
Console.WriteLine(hasil);
*/
/*
for (int i = 0; 1 < 5: 1++)
{
        Console.WriteLine("Perulanngan ke " + i);
 *?
*/
/*
int 1 = 0 
white (in = 5)
{
    Console.WriteLine("perulangan ke " + 1);
    i++;
    */
    /*
int i = 0;
int[] angka = new int [5] {1, 2, 3, 4, 5, };
foreach (int a in angka)
{
    Console.WriteLine("ini adalah isi arrau urut dari indeks ke " + i++ + yaitu" + a)
    */
    /*
    for (int i = 0; i < 18; i++)
    {
        Console.WriteLine("perulangan ke" + I);
    if (i == 5)
    {
    break;
    }
    */
    /*
    for (int i=0; i< 10; i++)
{
if (1 X 2 == 0)
{
continue;
}
Console.WriteLine(1):
*/
/*
public static void Main(string[] args)
{
Tampil();
}
public static void Tampil ( )
{
    Console.WriteLine("Game");
}
*/
/*
public static void Main(string[] args)
{
    Tampil();
}
public static void Tampil()
{
    Console.WriteLine("Game");
    */

    /*
public static void Main(string[] args)
{
    int hasil = Return();

    Console.WriteLine(hasil);
}
pubiic static int Counter(int damage);
{
    return damage 5 jt + 5 jt
    */
}
}
}
