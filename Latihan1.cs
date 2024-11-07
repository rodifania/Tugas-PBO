using System;

namespace Hello
{
    class Latihan1
    {
        static void Main(string[] args)
        {
            Ucapan();
            Latihan1 objek=new Latihan1();
            objek.Kata();
            objek.angka(4, 8);

        }

        static void Ucapan()
        {
            Console.WriteLine("Selamat Pagi!");
        }
         public void Kata()
        {
            Console.WriteLine("Selamat Siang!");
        }


           public void angka(int a,int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a+b);


        }

    }
}

