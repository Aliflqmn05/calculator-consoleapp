using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu Kalkulator:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            

            Console.Write("Pilih operasi yang ingin Anda lakukan (1-5): ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan angka pertama: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            double hasil = 0;

            switch (pilihan)
            {
                case 1:
                    hasil = angka1 + angka2;
                    Console.WriteLine("Hasil penjumlahan: " + hasil);
                    break;
                case 2:
                    hasil = angka1 - angka2;
                    Console.WriteLine("Hasil pengurangan: " + hasil);
                    break;
                case 3:
                    hasil = angka1 * angka2;
                    Console.WriteLine("Hasil perkalian: " + hasil);
                    break;
                case 4:
                    if (angka2 != 0)
                        hasil = angka1 / angka2;
                        Console.WriteLine("Hasil pembagian: " + hasil);
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih 1-5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
