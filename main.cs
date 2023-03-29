using System;

class Program
{
    public static void Main(string[] args)
    {
        //
        //
        //Prompts User with Instructions to  Quiz
        //
        //`

        Console.WriteLine("Hello. Welcome to Mrs X's Year 9 Math Class. This quiz is to refresh and test your mental math on some of our topics.");
        Console.WriteLine();
        Console.WriteLine("There are 15 questions with 3 sections. Number, Area and Algebra. You will get 2 attempts per question. Good Luck!");
        Console.WriteLine();

        //
        //
        //Score counter:
        //
        //
        
        int score = 0;

        //
        //
        //Random 5 Number Question Generator:
        //
        //

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
            int correctAns = num1 + num2;

            //Asks Questions and gets user input
            Console.WriteLine($"{i}. What is the sum of {num1} and {num2}(Answer in numbers)?");
            string userInput = Console.ReadLine();

            //Removes all non Numeric values
            int numAns;
            bool isNumber;

            //Null Variables
            numAns = 0;
            isNumber = true;

            //Trys to convert input to number. 
            try
            {
                numAns = Convert.ToInt32(userInput);
            }
            //Stops errors if cannot convert
            catch (FormatException)
            {
                isNumber = false;
            }

            //checks answer
            //if answer is correct
            if (isNumber == true)
            {
                if (numAns == correctAns && i != 5)
                {
                    Console.WriteLine($"Correct, Answer is {correctAns}.");
                    score++;
                    Console.WriteLine();
                }
                //if answer is inncorrect
                else if (numAns != correctAns && i != 5)
                {
                    Console.WriteLine($"Incorrect, Answer is {correctAns}");
                    score++;
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
            if (numAns == correctAns && i == 5)
            {
                Console.WriteLine($"Correct, Answer is {correctAns}. We will now moving to the next section");
            }
            else if (i == 5)
            {
                Console.WriteLine($"Incorrect, Answer is {correctAns}. We will now be moving to the next section");
            }
            Console.WriteLine();

        }


        //
        //
        //Random 5 A/P Question Generator:
        //
        //


        // For Loop for 5(Questions 6 to 10) Area/Perimeter Questions
        for (int j = 6; j < 11; j++)
        {
            Random rndNums2 = new Random();
            // Random Shape and Operator Picker
            // Random Shape(1 = sqaure, 2 = rectangle, 3 = triangle)
            int shape = rndNums2.Next(1, 4);
            // Random operator(1 =  Area, 2 = Perimeter)
            int operation = rndNums2.Next(1, 3);

            // Random Length and Height Picker
            // Picks random value between 5 and 30 for both
            int length = rndNums2.Next(5, 30);
            int height = rndNums2.Next(5, 30);
            //Third side for triangle
            int sideC = rndNums2.Next(5, 30);

            switch (shape)
            {
                // Square   
                case 1:
                    // Sqaure Area
                    //Operation 1 means Area, This is choosen at random
                    if (operation == 1)
                    {
                        //Prompts Question
                        Console.WriteLine($"{j}. Find the Area of a Square with the length and height of {length}?(Answer in numbers ONLY)");
                        //Finds Sqaure Area
                        int correctAns = length * length; 
                        //Gets User Input
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        //Checks Answer, If correct then moves on
                        if (userInput2 == correctAns)
                        {
                            Console.WriteLine($"Correct, The area of a Square is {correctAns}");
                            //Adds 1 to the total score
                            score++;
                            Console.WriteLine();
                        }
                        //If userInput isnt correct then it tells the user
                        else
                        {
                            Console.WriteLine($"Incorrect, The area of a Square is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    // Sqaure Perimeter
                    else
                    {
                        //Prompts Question
                        Console.WriteLine($"{j}. Find the Perimeter of a Square with the length and height of {length}?(Answer in numbers ONLY)");
                        //Gets Sqaure Perimeter
                        int correctAns = 4 * (length);
                        //Gets User Input
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        //Checks Answer
                        if (userInput2 == correctAns)
                        {
                            Console.WriteLine($"Correct, The perimeter of a Square is {correctAns}");
                            //Adds 1 to the total score
                            score++;
                            Console.WriteLine();
                        }
                        //If userInput is inncorrect then tells user
                        else
                        {
                            Console.WriteLine($"Incorrect, The perimeter of a Square is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    break;
                // Rectangle
                case 2:
                    // Rectangle Area
                    if (operation == 1)
                    {
                        //Prompts Question
                        Console.WriteLine($"{j}. Find the Area of a Rectangle with the length {length} and height {height}?(Answer in numbers ONLY)");
                        //Calculates Rect. Area
                        int correctAns = length * height;
                        //Gets User Input and converts it
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        //Checks Answer
                        if (userInput2 == correctAns)
                        {
                            Console.WriteLine($"Correct, The area of a Rectangle is {correctAns}");
                            //Adds 1 to the total score
                            score++;
                            Console.WriteLine();
                        }
                        //If user input Incorrect,  tells user
                        else
                        {
                            Console.WriteLine($"Incorrect, The area of a Rectangle is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    // Rectangle Perimeter
                    else
                    {
                        //Prompts Question
                        Console.WriteLine($"{j}. Find the Perimeter of a Rectangle with the length of {length} and height of {height}?(Answer in numbers ONLY)");
                        //Calculates Rect. Perimeter
                        int correctAns = 2 * (length + height);
                        //Gets and converts User Input
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        //Checks Answer
                        if (userInput2 == correctAns)
                        {
                            Console.WriteLine($"Correct, The perimeter of a Rectangle is {correctAns}");
                            //Adds 1 to the total score
                            score++;
                            Console.WriteLine();
                        }
                        //If User Input is incorrect, tells user
                        else
                        {
                            Console.WriteLine($"Incorrect, The perimeter of a Rectangle is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    break;
                // Triangle
                case 3:
                    // Triangle Area
                    if (operation == 1)
                    {
                        //Prompts Question
                        Console.WriteLine($"{j}. Find the Area of a Triangle with the length {length} and height {height}?(Answer in numbers ONLY)");
                        //Calculates Triangle Area
                        int correctAns = length * height * 1/2;
                        //Gets and converts user input
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        //Checks Answer
                        if (userInput2 == correctAns)
                        {
                            Console.WriteLine($"Correct, The area of a Triangle is {correctAns}");
                            //Adds 1 to the total score
                            score++;
                            Console.WriteLine();
                        }
                        //If user Input is incorrect, tells the user
                        else
                        {
                            Console.WriteLine($"Incorrect, The area of a Triangle is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    // Triangle Perimeter
                    else
                    {
                        //Prompts Question
                        Console.WriteLine($"{j}. Find the Perimeter of a Triangle with the side length's of {length},{height} and {sideC}?(Answer in numbers ONLY)");
                        //Calculates Triangle Area
                        int correctAns = length + height + sideC;
                        //Gets and Converts User Input
                        int userInput2 = Convert.ToInt32(Console.ReadLine());
                        //Checks answer
                        if (userInput2 == correctAns)
                        {
                            Console.WriteLine($"Correct, The perimeter of a Rectangle is {correctAns}");
                            //Adds 1 to the total score
                            score++;
                            Console.WriteLine();
                        }
                        //If answer is incorrect, tells user.
                        else
                        {
                            Console.WriteLine($"Incorrect, The perimeter of a Rectangle is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    break;
                }
                
                //Notify's When moving to next section(Happens last)
                if(j == 10)
                {
                    Console.WriteLine($"We will now be moving to the next section");
                            Console.WriteLine();
                }
            
            }



            //5 Algbera Questions
            //End Screen
    }
}
