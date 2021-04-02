using System;
using System.Collections.Generic;

namespace data_set_program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> scores = new List<int>();
            Random rand = new Random();

            names.AddRange( new string[] { "Adam", "BLAHAJ", "Jon K", "Jacklyn", "Julien"} );
            foreach(string s in names){
                scores.Add(rand.Next(0,100));
            }

            int highest = 0;
            for(int i = 0; i < scores.Count; i++){
                if(scores[i] > scores[highest]){
                    highest = i;
                }
            }
            Console.WriteLine($"The highest score is {scores[highest]} from {names[highest]}!");
        }
    }
}
