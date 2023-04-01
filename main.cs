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
        
        //While Loop for If they want to play again
        bool isReplaying = true;
        while (isReplaying)
        {

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
            int i = 0;
            for (i = 1; i < 6; i++)
            {
                //Random Number Generator
                Random rndNums = new Random();
                //returns random numbers frmo 5 to 80
                int num1 = rndNums.Next(5, 40);
                int num2 = rndNums.Next(40, 80);

                //totals num1 and num2
                int correctAns = num1 + num2;

                //Asks Questions and gets user input
                Console.WriteLine($"{i}. What is the sum of {num1} and {num2}(Answer in whole numbers)?");
                Console.WriteLine();
                string userInput = Console.ReadLine();

                //Removes all non Numeric values
                int numAns;
                bool isNumber;

                //Null Variables
                numAns = 0;
                isNumber = true;

                //Checks User Input
                isNumberFunc(userInput, ref numAns, ref isNumber);

                //checks answer
                //if answer is correct
                if (isNumber == true)
                {
                    if (numAns == correctAns && i != 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Correct, answer is {correctAns}.");
                        score++;
                        Console.WriteLine();
                    }
                    //if answer is incorrect
                    else if (numAns != correctAns && i != 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Incorrect, answer is {correctAns}");
                        Console.WriteLine();
                    }
                }
                //If isNumber was false
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter only numbers. Here is another question");
                    Console.WriteLine();
                    //Gives another question
                    i--;
                }

                //Informs user we are moving to the next section
                if (numAns == correctAns && i == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Correct, Answer is {correctAns}. We will now moving to the next section");
                }
                else if (i == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Incorrect, Answer is {correctAns}. We will now be moving to the next section");
                }
                Console.WriteLine();

            }


            //
            //
            //Random 5 Area/Perimeter Question Generator:
            //
            //


            // For Loop for 5 more (Questions 6 to 10)
            int j = 0;
            for (j = 6; j < 11; j++)
            {
                Random rndNums2 = new Random();
                // Random Shape and Operator Picker
                // Random Shape(1 = square, 2 = rectangle, 3 = triangle)
                int shape = rndNums2.Next(1, 4);
                // Random operator(1 =  Area, 2 = Perimeter)
                int operation = rndNums2.Next(1, 3);

                // Random Length and Height Picker
                // Picks random value between 5 and 20 for both
                int length = rndNums2.Next(5, 20);
                int height = rndNums2.Next(5, 20);
                //Third side for triangle(if asked)
                int sideC = rndNums2.Next(5, 20);

                switch (shape)
                {
                    // Square   
                    case 1:
                        // Square Area
                        //Operation 1 means Area, This is chosen at random
                        if (operation == 1)
                        {
                            //Prompts Question
                            Console.WriteLine($"{j}. Find the AREA of a SQUARE with the length and height of {length}?(Answer in whole numbers ONLY)");
                            Console.WriteLine();
                            //Finds Square Area
                            int correctAns = length * length;
                            //Gets User Input
                            int userInput2 = Convert.ToInt32(Console.ReadLine());
                            //Checks Answer, If correct then moves on
                            if (userInput2 == correctAns)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Correct, the AREA of a SQAURE is {correctAns}");
                                //Adds 1 to the total score
                                score++;
                                Console.WriteLine();
                            }
                            //If userInput isn't correct then it tells the user
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Incorrect, the AREA of a SQUARE is {correctAns}");
                                Console.WriteLine();
                            }
                        }
                        // Square Perimeter
                        else
                        {
                            //Prompts Question
                            Console.WriteLine($"{j}. Find the PERIMETER of a SQAURE with the length and height of {length}?(Answer in whole numbers ONLY)");
                            //Gets Sqaure Perimeter
                            int correctAns = 4 * (length);
                            //Gets User Input
                            int userInput2 = Convert.ToInt32(Console.ReadLine());
                            //Checks Answer
                            if (userInput2 == correctAns)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Correct, the PERIMETER of a SQAURE is {correctAns}");
                                //Adds 1 to the total score
                                score++;
                                Console.WriteLine();
                            }
                            //If userInput is incorrect then tells user
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Incorrect, the PERIMETER of a SQUARE is {correctAns}");
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
                            Console.WriteLine($"{j}. Find the AREA of a RECTANGLE with the length {length} and height {height}?(Answer in whole numbers ONLY)");
                            //Calculates Rect. Area
                            int correctAns = length * height;
                            //Gets User Input and converts it
                            int userInput2 = Convert.ToInt32(Console.ReadLine());
                            //Checks Answer
                            if (userInput2 == correctAns)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Correct, The AREA of a RECTANGLE is {correctAns}");
                                //Adds 1 to the total score
                                score++;
                                Console.WriteLine();
                            }
                            //If user input Incorrect,  tells user
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Incorrect, The AREA of a RECTANGLE is {correctAns}");
                                Console.WriteLine();
                            }
                        }
                        // Rectangle Perimeter
                        else
                        {
                            //Prompts Question
                            Console.WriteLine($"{j}. Find the PERIMETER of a RECTANGLE with the length of {length} and height of {height}? (Answer in whole numbers ONLY)");
                            //Calculates Rect. Perimeter
                            int correctAns = 2 * (length + height);
                            //Gets and converts User Input
                            int userInput2 = Convert.ToInt32(Console.ReadLine());
                            //Checks Answer
                            if (userInput2 == correctAns)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Correct, the PERIMETER of a RECTANGLE is {correctAns}");
                                //Adds 1 to the total score
                                score++;
                                Console.WriteLine();
                            }
                            //If User Input is incorrect, tells user
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Incorrect, the PERIMETER of a RECTANGLE is {correctAns}");
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
                            Console.WriteLine($"{j}. Find the AREA of a TRIANGLE with the length {length} and height {height}? (Answer in whole numbers ONLY)");
                            //Calculates Triangle Area
                            int correctAns = (length * height)/2;
                            //Gets and converts user input
                            int userInput2 = Convert.ToInt32(Console.ReadLine());
                            //Checks Answer
                            if (userInput2 == correctAns)
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Correct, the AREA of a TRIANGLE is {correctAns}");
                                //Adds 1 to the total score
                                score++;
                                Console.WriteLine();
                            }
                            //If user Input is incorrect, tells the user
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Incorrect, the AREA of a TRIANGLE is {correctAns}");
                                Console.WriteLine();
                            }
                        }
                        // Triangle Perimeter
                        else
                        {
                            //Prompts Question
                            Console.WriteLine($"{j}. Find the PERIMETER a TRIANGLE with the side lengths of {length},{height} and {sideC}? (Answer in whole numbers ONLY)");
                            //Calculates Triangle Area
                            int correctAns = length + height + sideC;
                            //Gets and Converts User Input
                            int userInput2 = Convert.ToInt32(Console.ReadLine());
                            //Checks answer
                            if (userInput2 == correctAns)
                            {
                                Console.WriteLine($"Correct, the PERIMETER of a TRIANGLE is {correctAns}");
                                //Adds 1 to the total score
                                score++;
                                Console.WriteLine();
                            }
                            //If the answer is incorrect, tell the user.
                            else
                            {
                                Console.WriteLine($"Incorrect, the PERIMETER of a TRIANGLE is {correctAns}");
                                Console.WriteLine();
                            }
                        }
                        break;
                }

                //Notify When moving to next section(Happens last)
                if (j == 10)
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

            int k = 0;
            for (k = 11; k < 16; k++)
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
                int l = 0;
                for (l = 0; l < numarr.Length; l++)
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
                        Console.WriteLine($"{k}. What is {firstVar}x + {secondVar}x (Answer with whole numbers and X ONLY)");
                        //Find Addition of 2 Var's
                        int additionAns = firstVar + secondVar;
                        //Converts Correct Answer to a string
                        string correctAns3 = additionAns + "x";
                        //Gets user input
                        string userInput3 = Console.ReadLine();
                        //convert to lowercase and removes spaces(ensures dynamic input)
                        userInput3 = userInput3.ToLower();
                        userInput3 = userInput3.Replace(" ", "");
                        //Checks Answer, If correct:
                        if (correctAns3 == userInput3)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Correct, answer is {correctAns3}");
                            score++;
                            Console.WriteLine();
                        }
                        //If Incorrect:
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Incorrect, answer is {correctAns3}");
                            Console.WriteLine();
                        }
                        break;
                    //Algebraic Subtraction:
                    case 2:
                        //Prompts Question
                        Console.WriteLine($"{k}. What is {firstVar}x - {secondVar}x (Answer with numbers and X ONLY)");
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
                            Console.WriteLine();
                            Console.WriteLine($"Correct, answer is {correctAns4}");
                            score++;
                            Console.WriteLine();
                        }
                        //If person answer x or 0 instead of 1x or 0x
                        else if (minusAns == 0 || minusAns == 1)
                        {
                            if (userInput4 == "x" || userInput4 == "0")
                            {
                                Console.WriteLine();
                                Console.WriteLine($"Correct, answer is {minusAns}");
                                score++;
                                Console.WriteLine();
                            }
                        }
                        //If Incorrect:
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Incorrect, answer is {correctAns4}");
                            Console.WriteLine();
                        }

                        break;

                }
                //Notify When 5 questions are done
                if (k == 15)
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

            //Prompts User with Info If more than 8 Questions Wrong
            if (score < 8)
            {
                Console.WriteLine($"Tough Luck, You got {score} out of 15. Better luck next time.");
            }
            //If 8 or More Questions correct:
            else
            {
                Console.WriteLine($"Congrat's, you got {score} out of 15 Great Job!");
            }

            //
            //
            //Replay or Not:
            //
            //    

            // Ask user if they want to replay or quit
            Console.WriteLine();
            Console.WriteLine("Do you want to replay? (Y/N)");
            //Gets User Input
            string userInput5 = Console.ReadLine();
            userInput5 = userInput5.ToUpper();

            //If they Answer Y
            switch (userInput5)
            {
                case "Y":
                    i = 0;
                    j = 0;
                    k = 0;
                    score = 0;
                    Console.WriteLine();
                    Console.WriteLine("Great lets play again!");
                    Console.WriteLine();
                    isReplaying = true;
                    break;
                //If they answer No
                case "N":
                    isReplaying = false;
                    Console.WriteLine("Thanks for playing");
                    break;
                //If Invalid Input
                default:
                    Console.WriteLine("Invalid input. Please enter a Y or N answer.");
                    break;
            }

        }

        //Function that checks if it is a Num for 1st section
        static void isNumberFunc(string userInput, ref int numAns, ref bool isNumber)
        {
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
        }
    }
}