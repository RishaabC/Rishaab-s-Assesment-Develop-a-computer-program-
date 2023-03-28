using System;

class Program
{
    public static void Main(string[] args)
    {
        //Prompts User with Instructions to  Quiz
        Console.WriteLine("Hello. Welcome to Mrs X's Year 9 Math Class. This quiz is to refresh and test your mental math on some of our topics.");
        Console.WriteLine();
        Console.WriteLine("There are 15 questions with 3 sections. Number, Area and Algebra. You will get 2 attempts per question. Good Luck!");
        Console.WriteLine();

        

        //Right and wrong counter:
        int rCounter = 0;
        int wCounter = 0;
        //int amountR = rCounter - 15;
        //int amountW = wCounter - 15;

        

        //Random 5 Number Question Generator
        //Number Variables
        int num1 = 0;
        int num2 = 0;

        //For Loop for 5 Questions
        for (int i = 1; i < 6; i++)
        {
            //Random Number Generator
            Random rndNums = new Random();
            //returns random numbers < 40
            num1 = rndNums.Next(10, 50);
            num2 = rndNums.Next(50, 100);

            //totals num1 and num2
            int sum = num1 + num2;

            //Asks Questions and gets user input
            Console.WriteLine($"{i}. What is the sum of {num1} and {num2}(Answer in numbers)?");
            string input = Console.ReadLine();

            //Removes all non Numeric values
            
            //Null Variables
            int number = 0;
            bool isNumber = true;
            
            //Trys to convert input to number. 
            try
            {
                number = Convert.ToInt32(input);
            }
            //Stops errors if cannot convert
            catch (FormatException)
            {
                isNumber = false;
            }
            
            //checks answer
            //if answer is correct
            if (isNumber == true){
                if (number == sum)
                {
                    Console.WriteLine($"Correct, Answer is {sum}.");
                    rCounter++;
                    Console.WriteLine();
                }
                //if answer is inncorrect
                else if (number != sum)
                {
                    Console.WriteLine($"Incorrect, Answer is {sum}");
                    wCounter++;
                    Console.WriteLine();
                }
            }
            //If isNumber was false
            else
            {
                Console.WriteLine("Invalid input. Please enter only numbers, Here is another question");
                Console.WriteLine();
                i--;
            }
            
            //Informs user we are moving to the next section
            if (number == sum && i == 5)
            {
                Console.WriteLine($"Correct, Answer is {sum}. We will now moving to the next section");
            }
            else if (i == 5)
            {
                Console.WriteLine($"Incorrect, Answer is {sum}. We are moving to the next section");
            }

        }




        //Random 5 A/P Question Generator


        
        //5 Algbera Questions


        
        //End Screen
    }
}