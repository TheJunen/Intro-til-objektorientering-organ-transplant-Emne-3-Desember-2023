// See https://aka.ms/new-console-template for more information
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bernt = new Personer(1, "Bernt", 25, 27, "Oslo sykehus", 70, 120 );
            var Kåre = new Personer(2, "Kåre", 80, 31, "ingen", 100, 7);

            Methods.transferPersonerConstructor(BerntConstructorDelegateMethod, Bernt);
            Methods.transferPersonerConstructor(KåreConstructorDelegateMethod, Kåre);

            Console.WriteLine("You can now choose to transfer kidney from Kåre to Bernt. Press 1 to proceed, 2 to exit");
            var transferkidney = Console.ReadLine();
            if (transferkidney == "1")
            {
            Bernt.numberofkidney = 2;
            Kåre.numberofkidney = 1;
            Methods.transferkidney(Bernt);
            Methods.transferkidney(Kåre);
            }
            else if (transferkidney == "2")
            {
                Console.WriteLine("You have chose to exit");
                return;
            }

            Console.WriteLine("You can now choose to see how happy both person are as a result of the k. Press 1 to proceed, 2 to exit");
            var happymeasure = Console.ReadLine();
            if (happymeasure == "1")
            {
                Bernt.happiness = 100;
                Kåre.happiness = 90;
                Methods.happinessAfterSuccessfulSurgery(Bernt);
                Methods.happinessAfterSuccessfulSurgery(Kåre);
                Console.WriteLine("Both are very happy!");
            }
            else if (happymeasure == "2")
            {
                Console.WriteLine("You have chose to exit");
                return;
            }
        }

        static void BerntConstructorDelegateMethod(Personer personer, Personer bernt)
        {
            personer.numberofkidney = bernt.numberofkidney;
            personer.name = bernt.name;
            personer.happiness = bernt.happiness;
            personer.age = bernt.age;
            personer.hospital = bernt.hospital;
            personer.survivalchance = bernt.survivalchance;
            personer.daysathospital = bernt.daysathospital;
        }

        static void KåreConstructorDelegateMethod(Personer personer, Personer kåre)
        {
            personer.numberofkidney = kåre.numberofkidney;
            personer.name = kåre.name;
            personer.happiness = kåre.happiness;
            personer.age = kåre.age;
            personer.hospital = kåre.hospital;
            personer.survivalchance = kåre.survivalchance;
            personer.daysathospital = kåre.daysathospital;
        }

    }
}
