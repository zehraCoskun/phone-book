namespace phone_book
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***REHBER UYGULAMASINA HOGELDİNİZ***");
        start:
            Console.WriteLine("--**--**--**--**--**--");
            Console.WriteLine("Yapmak istediğiniz islemi giriniz");
            Console.WriteLine("(1) Numara Eklemek");
            Console.WriteLine("(2) Numara Silmek");
            Console.WriteLine("(3) Numara Güncellemek");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama Yapma");
            Console.WriteLine("Çıkmak için lütfen (6)'ya basınız");
            string choose = Console.ReadLine();
            if (choose == "1")
            {
                Bussiness.AddNumber();
            }
            else if (choose == "2")
            {
                Bussiness.DeleteNumber();
            }
            else if (choose == "3")
            {
                Bussiness.UpdateNumber();
            }
            else if (choose == "4")
            {
                Bussiness.ListContacts();
            }
            else if (choose == "5")
            {
                Bussiness.FindNumber();
            }
            else if (choose == "6")
            {
                Console.WriteLine("<3 İyi Günler Dileriz <3 ");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tuslama yapınız");
            }

        MainMenu:
            Console.WriteLine("Ana Menüye dönmek için 'a' tusuna basınız");
            string MainMenuChoose = Console.ReadLine();
            if (MainMenuChoose == "a")
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Hatalı giris yaptınız");
                goto MainMenu;
            }
        }

    }

}