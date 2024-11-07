using System;

class Program
{
    static void Main() //method
    {
        // Daftar harga kue
        decimal[] hargaKue = { 50000, 40000, 10000, 20000, 30000 };
        
        // Menampilkan menu pilihan kue
        Console.WriteLine("Pilih kue yang ingin dibeli:");
        Console.WriteLine("1. Kue Coklat - Rp50.000");
        Console.WriteLine("2. Kue Vanila - Rp40.000");
        Console.WriteLine("3. Kue Cookies - Rp10.000");
        Console.WriteLine("4. Kue Brownies - Rp20.000");
        Console.WriteLine("5. Cheesecake - Rp30.000");

        // Membaca input pilihan pengguna
        Console.Write("Masukkan nomor pilihan kue (1-5): ");
        int pilihanKue;
        if (!int.TryParse(Console.ReadLine(), out pilihanKue) || pilihanKue < 1 || pilihanKue > 5)
        {
            Console.WriteLine("Pilihan tidak valid.");
            return; // Keluar dari program jika input tidak valid
        }

        // Menampilkan jumlah kue yang ingin dibeli
        Console.Write("Masukkan jumlah kue yang ingin dibeli: ");
        int jumlahKue;
        if (!int.TryParse(Console.ReadLine(), out jumlahKue) || jumlahKue < 1)
        {
            Console.WriteLine("Jumlah tidak valid.");
            return; // Keluar dari program jika jumlah tidak valid
        }

        // Menghitung harga per kue yang dipilih
        decimal hargaKueTerpilih = hargaKue[pilihanKue - 1]; 
        decimal totalBiaya = hargaKueTerpilih * jumlahKue;

        // Menentukan nama kue berdasarkan pilihan
        string namaKue;
        switch (pilihanKue)
        {
            case 1:
                namaKue = "Kue Coklat";
                break;
            case 2:
                namaKue = "Kue Vanila";
                break;
            case 3:
                namaKue = "Kue Cookies";
                break;
            case 4:
                namaKue = "Kue Brownies";
                break;
            case 5:
                namaKue = "Cheesecake";
                break;
            default:
                namaKue = "Tidak Dikenal";
                break;
        }

        // Menampilkan detail pembelian
        Console.WriteLine("\nDetail Pembelian:");
        Console.WriteLine("Kue: " + namaKue);
        Console.WriteLine("Harga per Kue: Rp" + hargaKueTerpilih); 
        Console.WriteLine("Jumlah Kue: " + jumlahKue);
        Console.WriteLine("Total Biaya: Rp" + totalBiaya);
    }
}
