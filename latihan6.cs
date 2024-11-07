using System;

namespace Hello 
{
    class latihan6
    {
        static void Main(string[] args)
        {
            latihan6 objek=new latihan6();
            Console.WriteLine(objek.Ucapan("Selamat Pagi!"));
        }
        public string Ucapan(string a)
        {
            return a;
        }
    }
}