using System;

namespace _02CharacterMultypl
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstWord = input[0];
            string secondWord = input[1];


            var longestWord = firstWord;
            var shortersWord = secondWord;
            if (firstWord.Length < shortersWord.Length)
            {
                longestWord = secondWord;
                shortersWord = firstWord;
            }

            Console.WriteLine(CharMultiply(longestWord, shortersWord));
        }
        public static int CharMultiply(string longestWord, string shortersWord)
        {
            int result = 0;
            for (int i = 0; i < shortersWord.Length; i++)
            {


                result += shortersWord[i] * longestWord[i];

            }
            for (int i = shortersWord.Length; i < longestWord.Length; i++)
            {
                result += longestWord[i];
            }

            return result;
        }
    }
}
