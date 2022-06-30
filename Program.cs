namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // String urunadi = "Lenovo";
            // double urunfiyati = 3655;
            // string urunaciklamasi = "Lenovo Bilgisayar"; 

            Product Lenovo = new Product();
            Lenovo.Adi = "Lenovo Bilgisayar";
            Lenovo.Fiyat = 1500;
            Lenovo.Aciklama = "Lenovo Bilgisayar";

            Product HpComputer = new Product();
            HpComputer.Adi = "Hp 250 G4";
            HpComputer.Fiyat = 2500;
            HpComputer.Aciklama = "HP Gaming Computer ";

            Product[] computers = new Product[] { Lenovo, HpComputer };
            
            foreach (Product computer in computers)
            {
                Console.WriteLine(computer.Adi); 
                Console.WriteLine(computer.Fiyat);
                Console.WriteLine(computer.Aciklama);   

                

            }

            Console.WriteLine("---------Methods---------"); 
            ChartManager chartManager = new ChartManager();
            chartManager.Ekle(Lenovo);
            chartManager.Ekle(HpComputer);

            chartManager.Ekle2("Monster Notebook", "Monster Oyuncu Bilgisayari", 12599 , 65);
            chartManager.Ekle2("Legion Laprop", "Oyuncu Bikgisayarı", 1399, 54); 

            




        }
    }
}