using System.Reflection.Metadata.Ecma335;
using ConsoleApp1;



namespace ConsoleApp1
{
    class Program
    {

        public static List<character> list = new List<character>();
        public static int index;
        static void Main(string[] args)
        {
            list.Add(new character(0,"Bulbasaur", 3, "Dame"));
            list.Add(new character(1,"Kala", 5, "Dame"));
            list.Add(new character(2,"Fido", 19, "Mann"));
            
            
            choosePet();

        }

        public static void choosePet()
        {
            Console.WriteLine("Velg ditt dyr med å taste inn Iden");
            for (int i=0; i < list.Count; i++)
            {
                var character = list[i];
                Console.WriteLine("petId:" + " " + i + " " + "Navn:" + " " + character.name + " " + "Alder:" + " " + character.age + "år" + " " + "Kjønn:" + " " + character.gender); }
            index = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine(list[index].name);
          Menu();
        }
        //public static void newPet()
        //{
        //    int newId = Convert.ToInt32(Console.ReadLine());
        //    string newName = Console.ReadLine();
        //    int newAge = Convert.ToInt32(Console.ReadLine());
        //    string newGender = Console.ReadLine();
           
        //   list.Add(new character(newId, newName, newAge, newGender));
           
        //}

        public static void Menu()
        {
            
            //Console.Clear();
            Say("1", $"Gi {list[index].name} mat");
            Say("2", $"Kos med {list[index].name}");
            Say("3", $"Sjekk om {list[index].name} må på do");
            Say("4", $"Har {list[index].name} lyst til å kose? ");
            Say("5", "choose new pet");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine($"{ list[index].name} er mett, fornøyd og har et smil rundt munnen!");
            }
            else if (option == "2")
            {
                Console.WriteLine($"Du og { list[index].name} har fått et sterkere bånd. Bulbasaur elsker kos, og slikker deg i ansiktet!");
            }
            else if (option == "3")
            {
                Console.WriteLine($"{ list[index].name} bjeffer, klynker og klatrer opp på deg om å få gå på do! {list[index].name} må på do med engang!");
            }
            else if (option == "4")
            {
                Console.WriteLine("Nei");
            }
            else if (option == "5")
            {
                choosePet();
            }
            else
            {
                Console.WriteLine($"Error! {list[index].name} is now dead");
                list.Remove(list[index]);
                choosePet();
            }

            
            Menu();
        }
        static void Say(string prefix, string message)
        {
            Console.Write("[");
            Console.Write(prefix);
            Console.WriteLine("]" + message);
        }
    }
}
    
