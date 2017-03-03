using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    // This is how set get and set methods for an array
    class AnimeDemo
    {
        public string anime { get; set; }
        public string dayOfAiring { get; set; }
        private string [] characters = new string [5];
        
        public void SetChar(int i, string character)
        {
            characters[i] = character;
        }

        public string GetChar(int i)
        {
            return characters[i];
        }
    }
    class Anime
    {
        public static void Main()
        {
            AnimeDemo a = new AnimeDemo {anime ="Bleach", dayOfAiring="Tuesday" };
            Console.WriteLine(a.anime);
            Console.WriteLine(a.dayOfAiring); 
            a.SetChar(0, "Ichigo");
            a.SetChar(1, "Rukia");
            a.SetChar(2, "Yodoyichi");
            a.SetChar(3, "Rangiku");
            a.SetChar(4, "Orihime");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a.GetChar(i));
            }
        }
    }
}
