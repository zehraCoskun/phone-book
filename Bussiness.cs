namespace phone_book
{
    public static class Bussiness
    {
        
        public static void AddNumber()
        {
            Console.WriteLine("İsim giriniz");
            string newNameA = Console.ReadLine();
            Console.WriteLine("Numara giriniz");
            string newNumberA = Console.ReadLine();
            PersonData.PhoneList.Add(new Person() { Name = newNameA, Number = newNumberA });

            Console.WriteLine(newNameA + " basarıyla eklendi");
        }
        public static void DeleteNumber()
        {
            Console.WriteLine("Silmek istediğiniz kisinin ismini yazınız");
            string deleteName = Console.ReadLine();
            var DeleteName = PersonData.PhoneList.Find(i => i.Name == deleteName);

            if (PersonData.PhoneList.Remove(DeleteName))
            {
                Console.WriteLine(deleteName + " basarıyla silindi");
            }
            else { Console.WriteLine("Böyle bir kayıt zaten mevcut degil"); }
        }
        
        public static void UpdateNumber()
        {
            Console.WriteLine("Güncellemek istediginiz kisinin adını giriniz");
            string updateName = Console.ReadLine();
            Console.WriteLine("İsmini değistirmek için (0)'a");
            Console.WriteLine("numarayı güncellemek için (9)'a");
            string updateChoose = Console.ReadLine();
            if (updateChoose == "0")
            {
                Console.WriteLine("Vermek istediginiz yeni ismi giriniz");
                string updateNewName = Console.ReadLine();

                foreach (Person item in PersonData.PhoneList)
                {
                    if (item.Name == updateName)
                    {
                        Console.WriteLine(updateName + ", " + updateNewName + " olarak değistiriliyor");
                        item.Name = updateNewName;
                    }
                }
            }
            else if (updateChoose == "9")
            {
                Console.WriteLine("Kisinin yeni numarasını giriniz");
                string updateNewNumber = Console.ReadLine();

                foreach (Person item in PersonData.PhoneList)
                {
                    if (item.Name == updateName)
                    {
                        Console.WriteLine(updateName + "'in numarası " + updateNewNumber + " olarak değistiriliyor");
                        item.Number = updateNewNumber;
                    }
                }
            }
            Console.WriteLine("Kisi bilgisi basarıyla güncellendi");
        }
        
        public static void ListContacts()
        {
            Console.WriteLine("Rehberiniz ; ");

            foreach (Person item in PersonData.PhoneList)
            {
                Console.WriteLine("Kisi : " + item.Name);
                Console.WriteLine("Numara : " + item.Number);
                Console.WriteLine("-*-*-*-*-");
            }
        }

        public static void FindNumber()
        {
            Console.WriteLine("İsme göre arama yapmak için 'i'e");
            Console.WriteLine("Numaraya göre arama yapmak için 'n'ye basınız");
            string findChoose = Console.ReadLine();
            if (findChoose == "i")
            {   
                Console.WriteLine("Bulmak istediğiniz ismi giriniz");
                string findName = Console.ReadLine();
                var FindName = PersonData.PhoneList.Find(i => i.Name == findName);
                if (PersonData.PhoneList.Contains(FindName))
                {
                    Console.WriteLine(FindName.Name + " : " + FindName.Number);
                }
                else { Console.WriteLine("aradığınız kisi rehberde kayıtlı değil"); }
            }
            else if(findChoose=="n")
            {   
                Console.WriteLine("Bulmak istediğiniz numarayı giriniz");
                string findNumber = Console.ReadLine();
                var FindNumber = PersonData.PhoneList.Find(i => i.Number == findNumber);
                if (PersonData.PhoneList.Contains(FindNumber))
                {
                    Console.WriteLine(FindNumber.Name + " : " + FindNumber.Number);
                }
                else { Console.WriteLine("aradığınız kisi rehberde kayıtlı değil"); }
            }

        }
    }
}