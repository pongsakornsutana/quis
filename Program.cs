using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many roses to plant ??");
            string manyroses = Console.ReadLine();
            Console.WriteLine("want to plant sunflowers");
            string sunflowers = Console.ReadLine();
            Detailedinformation detailedinformation = new Detailedinformation();
            Roses roses = new Roses("2","Roseswhite", "very beautiful","2","10.5","6");
           
        }
        class Roses{
            public int ID;
            public string nametree;
            public string expandtree;
            public int Amount;
            public string high;
            public string Circumference;

            class Sunflower
            {
                public int ID;
                public string nametree;
                public string expandtree;
                public int Amount;
                public string high;
                public string Circumference;
            }
            class Detailedinformation
            {
            List<Roses> listRoses;
            public Detailedinformation() {
                listRoses = new List<Roses>();
                public void addRosesToDetailinformation(Roses roses) {

                    listRoses.Add(Roses);
                }
            }
            }

        static List<Detailedinformation> ListDetailedinformation() {

            return listDetailedinformation;
            }
        
    }
}
