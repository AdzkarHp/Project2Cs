using System;
using System.Data.Common;
using System.Dynamic;
using System.Runtime.ExceptionServices;

class Program
{
    public static void tambahBarang()
    {
        Console.WriteLine("\n");

        List<String> addBarang = new List<string>{};

        char pilihan;
        do
        {
            Console.Write("Masukan Item : ");
            string tambahItem = Console.ReadLine();
            addBarang.Add(tambahItem);
            Console.WriteLine("Barang berhasil ditambahkan");

            // ulang kembali
            Console.Write("Apakah ada barang yang mau ditambahkan ? y/n ");
            pilihan = Console.ReadKey().KeyChar;


            Console.WriteLine("\n");

            // Agar ketika user memasukan input selain y/n maka akan ada eror dan kembali 
            char pilihanSolving = char.ToLower(pilihan);
        } while (pilihan == 'y' || pilihan == 'Y');

        Console.WriteLine("Anda memilih barang : ");

        foreach(var lihatData in addBarang)
        {
            Console.WriteLine(lihatData);
        }
    }

    public static void tampilkanBarang()
    {
        
    }

    static void Main(String [] args)
    {
        Console.WriteLine("\n");
        List<int> IDbarang = [1, 2, 3];
        List<String> daftarBarang = new List<String> {"Pizza", "Burger", "Fried Chicken"};
        List<int> hargaBarang = [10, 25, 30];
        
        // Iterate through the list
        Console.WriteLine("List Elements:");
        int index = 0;
        foreach (int urutanID in IDbarang)
        {
            // EROR ADA DI BARIS INI
            Console.WriteLine($"{urutanID}.{daftarBarang[index]} - {hargaBarang[index]}");
            index++;
        }

        Console.WriteLine(" ");
        Console.WriteLine("==================================================================================================");
        Console.WriteLine("1. Tambah Barang");
        Console.WriteLine("2. Hapus Barang");

        Console.Write("Masukan pilihan : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        switch (pilihan)
        {
            case 1:
                tambahBarang();
                break;

            case 2:
                tampilkanBarang();
                break;
        }
    }
}  
