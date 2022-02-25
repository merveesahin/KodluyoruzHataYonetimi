using System;

namespace Hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz!");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi: " +sayi);
            }
            catch (Exception exe)
            {
                Console.WriteLine("Hata:" + exe.Message.ToString());
            
            }
            finally
            {
                Console.WriteLine("Islem tamamlandi.");
            }
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                //int a = int.Parse("-80000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("cok kucuk yada buyuk deger");
                Console.WriteLine(ex);
            }
            finally 
            {
                Console.WriteLine("islem basarili");
            }
        }
    }
}
