using System;
using System.Collections;

namespace CCC
{

    public abstract class J32006
    {

        public static void Execute()
        {

            // Display instructions
            Console.WriteLine("Enter words:");

            ArrayList words = new ArrayList();
            string nextWord;
            int nextTime;
            string[] buttons = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            int lastButton = 0;

            do
            {
                nextWord = Console.ReadLine();
                if (nextWord != "halt")
                {
                    words.Add(nextWord);
                }
            }
            while (nextWord != "halt");

            for (int i = 0; i < words.Count; i ++)
            {
                nextTime = 0;
                nextWord = words[i].ToString();

                for (int k = 0; k < nextWord.Length; k ++)
                {

                    string c = nextWord[k].ToString();

                    for (int j = 0; j < buttons.Count(); j ++)
                    {
                        if (buttons[j].Contains(c))
                        {

                            nextTime += buttons[j].IndexOf(c) + 1;

                            if(lastButton == j && k != nextWord.Length - 1)
                            {
                                nextTime += 2;
                            }

                            lastButton = j;
                        }

                    }

                }

                Console.WriteLine(nextTime);

            }



        }

    }

}