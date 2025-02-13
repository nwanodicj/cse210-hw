using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectionActivity:ListingActivity
    {
        protected List<string> _prompts;
        protected List<string> _Question;

        public string GetRandomReflectionPrompt()
        {
            return _prompt;
        }

        public void SetRandomReflectionPrompt()
        {
            Console.WriteLine("Think of a time when you stood up for someone else.");
            Thread.Sleep(12000);
            Console.WriteLine();

            Console.WriteLine("Think of a time when you did something really difficult.");
            Thread.Sleep(12000);
            Console.WriteLine();
                
            Console.WriteLine("Think of a time when you helped someone in need.");
            Thread.Sleep(12000);
            Console.WriteLine();

            Console.WriteLine("Think of a time when you did something truly selfless.");
            Thread.Sleep(12000);
            Console.WriteLine();
              
        }

        public void GetQuestion()
        {
            List<string> RelatedExperience = new List<string>();
            RelatedExperience.Add("-Why was this experience meaningful to you?");
            RelatedExperience.Add("-Have you ever done anything like this before?");
            RelatedExperience.Add("-How did you get started?");
            RelatedExperience.Add("-How did you feel when it was complete?");
            RelatedExperience.Add("-What made this time different than other times when you were not as successful?");
            RelatedExperience.Add("-What is your favorite thing about this experience?");
            RelatedExperience.Add("-What could you learn from this experience that applies to other situations?");
            RelatedExperience.Add("-What did you learn about yourself through this experience?");
            RelatedExperience.Add("-How can you keep this experience in mind in the future?");

            foreach (string r in RelatedExperience)
            {
                
                Console.WriteLine(r);
                Thread.Sleep(3000);
                Console.Write("\b \b");

                List<string> AnimationStrings = new List<string>();
                AnimationStrings.Add("|");
                AnimationStrings.Add("/");
                AnimationStrings.Add("-");
                AnimationStrings.Add("\\");
                AnimationStrings.Add("|");
                AnimationStrings.Add("/");
                AnimationStrings.Add("-");
                AnimationStrings.Add("\\");


                DateTime StartTime = DateTime.Now;
                DateTime EndTime = StartTime.AddSeconds(15);

                int a = 0;

                while (DateTime.Now < EndTime)
                {
                    string s = AnimationStrings[a];
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b");

                    a++;

                    if (a >= AnimationStrings.Count)
                    {
                        a = 0;
                    }
                }
            }    
        }


        public void StartReflectionActivity()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Reflection activity");
            Console.WriteLine();
        }

        public void EndActivity()
        {
            //Console.WriteLine($"Ending activity: {ActivityName}");
            // Add more functionality as needed
        }
    }
}