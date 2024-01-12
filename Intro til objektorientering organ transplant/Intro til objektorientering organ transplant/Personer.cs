using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class Personer
    {
        public int numberofkidney {  get; set; }
        public string name { get; set; }
        public int happiness { get; set; }
        public int age { get; set; }
        public string hospital {  get; set; }
        
        public int survivalchance { get; set; }

        public int daysathospital { get; set; }

        public Personer(int NumberOfKidney, string Name, int Happiness, int Age, string Hospital, int SurvivalChance, int DaysAtHospital)
        {
            numberofkidney = NumberOfKidney;
            name = Name;
            happiness = Happiness;
            age = Age;
            hospital = Hospital;
            survivalchance = SurvivalChance;
            daysathospital = DaysAtHospital;
        }

        public Personer()
        {

        }
    }
}
