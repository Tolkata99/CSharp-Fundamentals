using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int result = findVowelsCount(text);

            Console.WriteLine(result);
        }

        public static int findVowelsCount(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {

                char currentLetter = text[i];
                if(currentLetter == 'a' 
                    || currentLetter == 'e'
                    || currentLetter == 'o' 
                    || currentLetter == 'u'
                    || currentLetter == 'y'
                    || currentLetter == 'i')
                {
                    counter++;
                }
            }
            return counter;
        }
        
    }
}
