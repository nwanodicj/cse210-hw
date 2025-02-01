using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();// User input Grade Percentage
        int gradePercentage = int.Parse(grade);

        string additionalSign = "+";// Grade Sign
        string minusSign = "-";// Grade Sign

        string gradeLetter = "";// Grade Letters (A, B, C, D, F)

        if (gradePercentage >= 94)// Conditions for Grade Letters
        {
            gradeLetter = "A";
            Console.WriteLine($"Your grade is {gradeLetter}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 90 || gradePercentage == 92)
        {
            gradeLetter = "A";
            Console.WriteLine($"Your grade is {gradeLetter}{minusSign}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 87 || gradePercentage == 89)
        {
            gradeLetter = "B";
            Console.WriteLine($"Your grade is {gradeLetter}{additionalSign}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 83 || gradePercentage == 86)
        {
            gradeLetter = "B";
            Console.WriteLine($"Your grade is {gradeLetter}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 80 || gradePercentage == 82)
        {
            gradeLetter = "B";
            Console.WriteLine($"Your grade is {gradeLetter}{minusSign}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 77 || gradePercentage == 79)
        {
            gradeLetter = "C";
            Console.WriteLine($"Your grade is {gradeLetter}{additionalSign}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 73 || gradePercentage == 76)
        {
            gradeLetter = "C";
            Console.WriteLine($"Your grade is {gradeLetter}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 70 || gradePercentage == 72)
        {
            gradeLetter = "C";
            Console.WriteLine($"Your grade is {gradeLetter}{minusSign}.");

            int passMark = 70;
            if(gradePercentage >= passMark)
            {
                Console.WriteLine($"Congratulations! You have passed the course.");
            }
        }

        else if (gradePercentage >= 67 || gradePercentage == 69)
        {
            gradeLetter = "D";
            Console.WriteLine($"Your grade is {gradeLetter}{additionalSign}.");
            
            int passMark = 70;
            if(gradePercentage <= passMark)
            {
                Console.WriteLine($"Thank you for offering this course, we encourage you to have a growth mindset, never give up, we know you will do better as you will reapply next time.");
                Console.WriteLine("You have not passed the course.");
            }
        }

        else if (gradePercentage >= 63 || gradePercentage == 66)
        {
            gradeLetter = "D";
            Console.WriteLine($"Your grade is {gradeLetter}.");

            int passMark = 70;
            if(gradePercentage <= passMark)
            {
                Console.WriteLine($"Thank you for offering this course, we encourage you to have a growth mindset, never give up, we know you will do better as you will reapply next time.");

                Console.WriteLine("You have not passed the course.");
            }
        }

        else if (gradePercentage >= 60 || gradePercentage == 62)
        {
            gradeLetter = "D";
            Console.WriteLine($"Your grade is {gradeLetter}{minusSign}.");

            int passMark = 70;
            if(gradePercentage <= passMark)
            {
                Console.WriteLine($"Thank you for offering this course, we encourage you to have a growth mindset, never give up, we know you will do better as you will reapply next time.");

                Console.WriteLine("You have not passed the course.");
            }
        }

        else if (gradePercentage < 60)
        {
            gradeLetter = "F";
            Console.WriteLine($"Your grade is {gradeLetter}.");

            int passMark = 70;
            if(gradePercentage <= passMark)
            {
                Console.WriteLine($"Thank you for offering this course, we encourage you to have a growth mindset, never give up, we know you will do better as you will reapply next time.");

                Console.WriteLine("You have not passed the course.");
                Console.WriteLine("");
            }
        }
    }
    
}