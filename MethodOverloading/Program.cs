//Create an Add method:
//This Add method takes 2 integer parameters
//Create an overload of the Add method:
//This Add method needs to have 2 decimal parameters
//Create another overload of the Add method:
//This Add method  returns a string
//And this Add method takes 3 parameters
// 2 integer parameters
// 1 boolean parameters
//If the boolean parameter is equal to true:
//This Add method will return the sum of the 2 numbers
//This Add method adds the word “dollar” at the end of the string if the total is equal to 1 dollar
//This Add method adds the word “dollars” at the end of the string if the total is equal to any other amount 
//If the boolean parameter is not equal to true:
//This Add method will just return the sum of the 2 numbers


namespace MethodOverloading
{
    class program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal numb1, decimal numb2)
        {
            return numb1 + numb2;
        }

        public static string Add(int number1, int number2, bool isMoney)
        {
            int sum = number1 + number2;
           

            if (isMoney)
            {
                if (sum >= 2)
                {
                    return $"{sum} dollars";
                }
                else
                {
                    return $"{sum} dollar";
                }
            }
            else
            {
                return $"{sum}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(14, 15));
            Console.WriteLine(Add(.14m, .15m));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(1, 1, true));
            Console.WriteLine(Add(2, 2, false));
        }
    }
}