using System;
using System.Security.Cryptography.X509Certificates;

namespace project
{

    class Uczen
    {

        public string name;
        public int height;
        public int weight;
        public int lvl;
        public int speed;
        public int atack;
        public int magic;
        public int defend;
        public string klikucha;
    }
    class program
    {

        static void Main()
        {
            Uczen n1 = new Uczen();
            n1.name = "Babina";
            n1.height = 400;
            n1.weight = 300;
            n1.speed = 99999;
            n1.atack = 99999;
            n1.magic = 99999;
            n1.defend = 99999;
            n1.klikucha = "ЛЕГЕНДА БАЗЫ";

            Console.WriteLine("Name: " + n1.name);
            Console.WriteLine("Height: " + n1.height);
            Console.WriteLine("Weight: " + n1.weight);
            Console.WriteLine("Speed: " + n1.speed);
            Console.WriteLine("Atack: " + n1.atack);
            Console.WriteLine("Magic: "+ n1.magic);
            Console.WriteLine("Defend: " + n1.defend);
            Console.WriteLine("id: " + n1.name);
        }


    }
    
}
    
