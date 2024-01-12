using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace app
{
    internal class Methods
    {
        //public void chooseBerntsKidney()
        //{
        //    kåre.numberofkidney.
        //}
        public delegate void ConstructorPersonerDelegate(Personer personer, Personer Bernt);
        public static void transferPersonerConstructor(ConstructorPersonerDelegate constructorDelegate, Personer gajg)
        {
            Personer personer = new Personer();

            constructorDelegate(personer, gajg);

            Console.WriteLine($"Received parameters for {personer.name}: numberofkidney: {personer.numberofkidney}, name: {personer.name}, happiness: {personer.happiness}%, age: {personer.age}, hospital: {personer.hospital}, survivalchance: {personer.survivalchance}%, daysathospital: {personer.daysathospital}");

        }

        public static void transferkidney(Personer person)
        {
            int numberOfKidney = person.numberofkidney;

            Console.WriteLine($"Because you chose to transfer the kidney, {person.name} now has amount of kidneys of: {numberOfKidney}. Both are very happy now!");
        }
        public static void happinessAfterSuccessfulSurgery(Personer person)
        {
            int happiness = person.happiness;

            Console.WriteLine($"{person.name} happiness: {happiness}%");
        }
    }
}
