namespace RandomNumberGen
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate the random number
            var randomGenerator = new Random();
            int randomNum =  randomGenerator.Next(0, 10);
            
            do
            {
                Console.WriteLine("Enter a random number between 0 - 10 : ");
                string userNum = Console.ReadLine();
                int userNumber = Int16.Parse(userNum);

                if (userNumber >= 0 && userNumber <= 10)
                {
                    if (userNumber == randomNum)
                    {
                        Console.WriteLine("CONGRATULATIONS!!!");
                        Console.WriteLine("Your number matches with the random number.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Numbers do not match.");
                        Console.WriteLine("Random number is " + randomNum);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            } while (true);                      
        
        }
    }
}