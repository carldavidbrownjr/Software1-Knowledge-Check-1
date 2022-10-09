namespace Software1_Knowledge_Check_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            bool runProgram = true;
            while (runProgram)
            {
                calculator.init();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Would you like to make another calculation?");
                Console.WriteLine("Press Y to continue. Any other key to escape");
                Console.Write("Continue [Y]? ");
                var tempInput = Console.ReadLine().ToUpper();
                switch (tempInput)
                {
                    case "Y":
                        Console.WriteLine("");
                        break;
                    case "":
                        Console.WriteLine("");
                        break;
                    default:
                        System.Environment.Exit(1);
                        break;
                }

            }
 
        }
    }
}