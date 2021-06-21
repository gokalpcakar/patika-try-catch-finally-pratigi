using System;

namespace patika_try_catch_finally_pratigi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            // finally{
            //     Console.WriteLine("İşlem Tamamlandı");
            // }

            try
            {
                // int a = int.Parse(null);
                // int b = int.Parse("test");
                int c = int.Parse("-20000000000000000000000000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz.");
                Console.WriteLine(ex);                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);                
            }
            finally{
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }
        }
    }
}
