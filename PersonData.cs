namespace phone_book
{
    public class PersonData
    {
        private static List<Person> phoneList;
        static PersonData()
        {
            phoneList = new List<Person>();
            phoneList.Add(new Person(){Name ="Reyhan", Number="05449999911"});
            phoneList.Add(new Person(){Name ="Merve", Number="05449999922"});
            phoneList.Add(new Person(){Name ="Zafer", Number="05449999933"});
            phoneList.Add(new Person(){Name ="Fatih", Number="05449999944"});
            phoneList.Add(new Person(){Name ="Nilüfer", Number="05449999955"});

        }
        public static List<Person> PhoneList
        {
            get { return phoneList; }
        }

    }



}