using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Tomagtachi
{
    public class methods
    {
        public static pet newpet(string name, string type,int health, int happiness, int bordem, int hunger, int sleep)
        {
            pet tomogachi = new pet();
            {
                tomogachi.name = name;
                tomogachi.type = type;
                tomogachi.health = health;
                tomogachi.happiness = happiness;
                tomogachi.boredom = bordem;
                tomogachi.hunger = hunger;
                tomogachi.sleep = sleep;
                
            }
            return tomogachi;
        }
        public static activity newactivity(string name, int health, int happiness, int boredom, int hunger, int sleep)
        {
            activity action = new activity();
            {
                action.name = name;
                action.healthvaluechange = health;
                action.happinessvaluechange = happiness;
                action.boredomvaluechange = boredom;
                action.hungervaluechange = hunger;
                action.sleepvaluechange = sleep;
                return action;
            }
        }
        public static void uploaddeadpet(pet tomagathci)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\vivek\Documents\Vs Projects\Tomogatchi\Tomagtachi\Tomagtachi\Properties\Past pets.txt", true))
            {
                file.WriteLine(tomagathci.name + "," + tomagathci.type + "," + tomagathci.health + "," + tomagathci.happiness + "," + tomagathci.boredom + "," + tomagathci.hunger + "," + tomagathci.sleep);
                file.Close();
            }
        }
        public static void savepet(pet tomogatchi)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\vivek\Documents\Vs Projects\Tomogatchi\Tomagtachi\Tomagtachi\Properties\current pet.txt"))
            {
                file.WriteLine(tomogatchi.name + "," + tomogatchi.type + "," + tomogatchi.health + "," + tomogatchi.happiness + "," + tomogatchi.boredom + "," + tomogatchi.hunger + "," + tomogatchi.sleep);
                file.Close();
            }
        }
        public static void pettimedamadge(pet tomogatchi)
        {
            tomogatchi.health += -1; tomogatchi.happiness += -1; tomogatchi.boredom += -1; tomogatchi.hunger += -1; tomogatchi.sleep += -1; savepet(tomogatchi);
        }

        public static void activitystatsupdate(pet tomogatchi, activity act)
        {
            tomogatchi.health += act.healthvaluechange; tomogatchi.happiness += act.happinessvaluechange; tomogatchi.boredom += act.boredomvaluechange; tomogatchi.hunger += act.hungervaluechange; tomogatchi.sleep += act.sleepvaluechange; savepet(tomogatchi);
        }

        public static Boolean petdead(pet tomogatchi)
        {
            if(tomogatchi.health <= 0 | tomogatchi.happiness <= 0 | tomogatchi.boredom <= 0 | tomogatchi.hunger <= 0 | tomogatchi.sleep <= 0)
                {
                uploaddeadpet(tomogatchi);
                return true;
                }
            else return false;
        }
        public static pet returnpet()
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\vivek\Documents\Vs Projects\Tomogatchi\Tomagtachi\Tomagtachi\Properties\current pet.txt"))
            {
                var line = file.ReadLine();
                var values = line.Split(',');
                file.Close();
                return newpet(values[0], values[1], Int32.Parse(values[2]), Int32.Parse(values[3]), Int32.Parse(values[4]), Int32.Parse(values[5]), Int32.Parse(values[6]));
            }
        }
        public static void revieve() 
        {
            activity dogreborn = methods.newactivity("dog", 50, 50, 50, 50, 50);
            activity catreborn = methods.newactivity("cat", 35, 35, 60, 60, 60);
            activity fishreborn = methods.newactivity("fish", 35, 35, 60, 60, 60);
            activity snakereborn = methods.newactivity("snake", 55, 55, 30, 55, 55);
            pet revieved = returnpet();

            switch (revieved.type) 
            {
                case "Dog":
                    activitystatsupdate(revieved, dogreborn);
                    break;
                case "Cat":
                    activitystatsupdate(revieved, catreborn);
                    break;
                case "Fish":
                    activitystatsupdate(revieved, fishreborn);
                    break;
                case "Snake":
                    activitystatsupdate(revieved, snakereborn);
                    break;
            }
        }
        public static int updaterandom(int linecount)
        {
            Random Rnd = new Random();
            int pickedquestion = Rnd.Next(linecount);
            return pickedquestion;
        }

        public static List<string> getwords()
        {
            //importing words and hints
            using (var reader = new StreamReader(@"C:\Users\vivek\Documents\Vs Projects\Tomogatchi - Copy\Tomagtachi\Tomagtachi\Properties\finalwordsandhints.txt"))
            {
                List<string> Word = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('|');

                    Word.Add(values[0]); ;
                }
                return Word;
            }

        }
        public static List<string> gethints()
        {
            //importing words and hints
            using (var reader = new StreamReader(@"C:\Users\vivek\Documents\Vs Projects\Tomogatchi - Copy\Tomagtachi\Tomagtachi\Properties\finalwordsandhints.txt"))
            {
                List<string> Hint = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split('|');

                    Hint.Add(values[1]);
                }
                return Hint;
            }

        }
        public static int linecount()
        {
            //getting line count
            List<string> Word = getwords();
            int linecount = 0;
            foreach (var value in Word)
            {
                linecount++;
            }
            return linecount;
        }
    }
}
