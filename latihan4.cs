using System;

namespace Hello
{
    class latihan4
    {
        static void Main(string[] args)
        {
            latihan4 objek = new latihan4();
            objek.Ucapan("Selamat Pagi!");
        }

        // Corrected method declaration with a body
        public void Ucapan(string a)
        {
            Console.WriteLine(a); // Method body added here
        }
        
    }
}
