using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

class Program
{ 
    
    static void Main(String[] args)
    {
        List<string> nama_Barang = new List<string> {"Sendal swallow", "Snack", "Rokok surya"};
        List<int> harga_Barang = new List<int> {15000, 5000, 31000};
        
        Console.WriteLine(" ");
        Console.WriteLine("Daftar barang");
        Console.WriteLine("======================================");
        Console.WriteLine(" ");
        
        for(int i = 0; i < nama_Barang.Count; i++)
        {
            Console.WriteLine(nama_Barang[i] + " RP -" + harga_Barang[i] );
        }

        Console.WriteLine(" ");
        Console.Write("Masukan nama barang : ");
        string? input_Barang = Console.ReadLine();

        if(string.IsNullOrEmpty(input_Barang))
        {
            Console.WriteLine("Lu mau beli apa si goblok !");
        }
        if(nama_Barang.Contains(input_Barang))
        {
            int index = nama_Barang.IndexOf(input_Barang);
            Console.WriteLine("Anda telah membeli " + nama_Barang + " -Rp" + harga_Barang);
        }
        else
        {
            Console.WriteLine("Ga ada barangnya disini kontol");
        }
    }
}