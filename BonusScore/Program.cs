// Problem 2. Bonus Score

//   Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//       If the score is between 1 and 3, the program multiplies it by 10.
//       If the score is between 4 and 6, the program multiplies it by 100.
//       If the score is between 7 and 9, the program multiplies it by 1000.
//       If the score is 0 or more than 9, the program prints “invalid score”.

using System;
namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());
            int scoreFirstOption = score * 10;
            int scoreSecondOption = score * 100;
            int scoreThirdOption = score * 1000;
            if (score >= 1 && score < 4) 
            {
                Console.WriteLine(scoreFirstOption);
            }
            if (score > 3 && score < 7)
            {
                Console.WriteLine(scoreSecondOption);
            }
            if (score > 6 && score < 10)
            {
                Console.WriteLine(scoreThirdOption);
            }

            Console.WriteLine("Inavalid value");
        }
    }
}



