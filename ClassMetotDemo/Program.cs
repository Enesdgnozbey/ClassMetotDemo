using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 362606;
            musteri1.Name = "Enes Doğan";
            musteri1.Surname = "ÖZBEY";
            musteri1.Age = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Halil fatih";
            musteri2.Surname = "kaya";
            musteri2.Age = 20;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2 };

            for(int i = 0; i < musteris.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Müşteri Bilgileri\n" + musteris[i].Id + "\n" + musteris[i].Name + musteris[i].Surname + "\n" + musteris[i].Age);

                MusteriManager musteriManager = new MusteriManager();
                musteriManager.Add(musteri1);
                musteriManager.Delete(musteri1);
                musteriManager.Update(musteri1);

                
                

            }


        }
    }
}
