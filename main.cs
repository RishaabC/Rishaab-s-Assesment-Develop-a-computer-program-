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

        Console.WriteLine("Hello. Welcome to Mrs X's Year 9 Math Class. This quiz is to refresh and test your mental maths on some of our topics.");
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

        //For Loop for 5 Questions
        for (int i = 1; i < 6; i++)
        {
            //Random Number Generator
            Random rndNums = new Random();
            //returns random numbers < 40
            int num1 = rndNums.Next(10, 50);
            int num2 = rndNums.Next(50, 100);

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

            //Tries to convert input to number. 
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
                //if answer is incorrect
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
        //Random 5 Area/Perimeter Question Generator:
        //
        //


        // For Loop for 5(Questions 6 to 10) Area/Perimeter Questions
        for (int j = 6; j < 11; j++)
        {
            Random rndNums2 = new Random();
            // Random Shape and Operator Picker
            // Random Shape(1 = square, 2 = rectangle, 3 = triangle)
            int shape = rndNums2.Next(1, 4);
            // Random operator(1 =  Area, 2 = Perimeter)
            int operation = rndNums2.Next(1, 3);

            // Random Length and Height Picker
            // Picks random value between 5 and 30 for both
            int length = rndNums2.Next(5, 25);
            int height = rndNums2.Next(5, 25);
            //Third side for triangle(if asked)
            int sideC = rndNums2.Next(5, 25);

            switch (shape)
            {
                // Square   
                case 1:
                    // Square Area
                    //Operation 1 means Area, This is chosen at random
                    if (operation == 1)
                    {
                        //Prompts Question
                        Console.WriteLine($"{j}. Find the Area of a Square with the length and height of {length}?(Answer in numbers ONLY)");
                        //Finds Square Area
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
                        //If userInput isn't correct then it tells the user
                        else
                        {
                            Console.WriteLine($"Incorrect, The area of a Square is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    // Square Perimeter
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
                        //If userInput is incorrect then tells user
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
                        Console.WriteLine($"{j}. Find the Perimeter of a Triangle with the side lengths of {length},{height} and {sideC}?(Answer in numbers ONLY)");
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
                        //If the answer is incorrect, tell the user.
                        else
                        {
                            Console.WriteLine($"Incorrect, The perimeter of a Rectangle is {correctAns}");
                            Console.WriteLine();
                        }
                    }
                    break;
                }
                
                //Notify When moving to next section(Happens last)
                if(j == 10)
                {
                    Console.WriteLine($"We will now be moving to the next section");
                            Console.WriteLine();
                }
            
            }

        //
        //
        //5 Random Algebra Questions Generator:
        //
        //

        for (int k = 11; k < 16; k++)
        {
            //Array Num Random Generator
            //Random Variable
            Random rndNums3 = new Random();
            //Min and Max values for array
            int minVal = 5;
            int maxVal = 25;
            //New array of 6
            int[] numarr = new int[6];

            //Assigns random values to array
            for (int l = 0; l < numarr.Length; l++)
            {
                numarr[l] = rndNums3.Next(minVal, maxVal);
            }

            //Var which picks which index in array and take its value
            int numpicker = rndNums3.Next(0, 6);
            int numpicker2 = rndNums3.Next(0, 6);

            //Randomly Get our first and second var
            int firstVar = numarr[numpicker];
            int secondVar = numarr[numpicker2];


            //Operation Picker
            //1= +, 2 =-
            int operationNum = rndNums3.Next(1, 3);


            //Ask Question
            switch (operationNum)
            {
                //Algebraic Addition:
                case 1:
                    //Prompts Question
                    Console.WriteLine($"{k}. What is {firstVar}x + {secondVar}x (Answer with numbers and letters ONLY)");
                    //Find Addition of 2 Var's
                    int additionAns = firstVar + secondVar;
                    //Converts Correct Answer to a string
                    string correctAns3 = additionAns + "x";
                    //Gets user input
                    string userInput3 = Console.ReadLine();
                    //convert to lowercase and removes spaces
                    userInput3 = userInput3.ToLower().Replace(" ", "");
                    userInput3 = userInput3.Replace(" ", "");
                    //Checks Answer, If correct:
                    if (correctAns3 == userInput3)
                    {
                        Console.WriteLine($"Correct, Answer is {correctAns3}");
                        score++;
                        Console.WriteLine();
                    }
                    //If Incorrect:
                    else
                    {
                        Console.WriteLine($"Incorrect, Answer is {correctAns3}");
                        Console.WriteLine();
                    }
                    break;
                //Algebraic Subtraction:
                case 2:
                    //Prompts Question
                    Console.WriteLine($"{k}. What is {firstVar}x - {secondVar}x (Answer with numbers and letters ONLY)");
                    //Find difference of 2 Var's
                    int minusAns = firstVar - secondVar;
                    //Converts Correct Answer to a string
                    string correctAns4 = minusAns + "x";
                    //Gets user input
                    string userInput4 = Console.ReadLine();
                    //convert to lowercase and removes spaces
                    userInput4 = userInput4.ToLower();
                    userInput4 = userInput4.Replace(" ", "");
                    //Checks Answer, If correct:
                    if (correctAns4 == userInput4)
                    {
                        Console.WriteLine($"Correct, Answer is {correctAns4}");
                        score++;
                        Console.WriteLine();
                    }
                    //If person answer x or 0 instead of 1x or 0x
                    else if (minusAns == 0 || minusAns == 1)
                    {
                        if (userInput4 == "x" || userInput4 == "0")
                        {
                            Console.WriteLine($"Correct, Answer is {minusAns}");
                            //score++;
                            Console.WriteLine();
                        }
                    }
                    //If Incorrect:
                    else
                    {
                        Console.WriteLine($"Incorrect, Answer is {correctAns4}");
                        Console.WriteLine();
                    }

                    break;

            }
            //Notify When 5 questions are done
                if(k == 15)
                {
                    Console.WriteLine($"We have now finished. Well Done. Here are the results");
                            Console.WriteLine();
                }
        }
                                
        //
        //
        //End Screen:
        //
        //
    }
}
