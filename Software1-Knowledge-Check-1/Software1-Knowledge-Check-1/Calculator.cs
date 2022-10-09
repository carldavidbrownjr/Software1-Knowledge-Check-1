using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1_Knowledge_Check_1
{
    public class Calculator
    {
        private int first;
        private int second;
        private int operation;
        private string operationString;
        private string operationSymbol;
        private double resultDouble;
        private int inputCount;
        private const string indent = "    ";
        public int init()
        {
            //reinitialize object variables to default
            resetVariables();


            // get operator from user
            int returnValue = -1;
            while (returnValue <= 0 )
            {
                returnValue = this.getOperator();
            }
            //get numbers from user
            returnValue = -1;
            while (returnValue <= 0)
            {
                returnValue = this.getNumbers();
            }
            this.doOperations();
            return returnValue;

        }

        private void resetVariables()
        {
            this.first = 0;
            this.second = 0;
            this.operation = -1;
            this.operationString = "";
            this.operationSymbol = "";
            this.resultDouble = 0.0;
            this.inputCount = 0;
        }

        private int getOperator()
        {
            int returnValue = -1;
            Console.WriteLine("Hello.    Choose between options 1 through 4.");
            Console.WriteLine("{0}(1) for Addition.", indent);
            Console.WriteLine("{0}(2) for Subtraction.", indent);
            Console.WriteLine("{0}(3) for Multiplication.", indent);
            Console.WriteLine("{0}(4) for Division", indent);
            Console.WriteLine("");
            Console.WriteLine("{0}(Q) to Quit", indent);
            Console.Write("Operation: ");
            var tempInput = Console.ReadLine().ToUpper();
            switch (tempInput)
            {
                case "1":
                    this.operation = 1;
                    this.operationString = "add";
                    this.operationSymbol = "+";
                    returnValue = 1;
                    break;
                case "2":
                    this.operation = 2;
                    this.operationString = "substract";
                    this.operationSymbol = "-";
                    returnValue = 1;
                    break;
                case "3":
                    this.operation = 3;
                    this.operationString = "multiply";
                    this.operationSymbol = "*";
                    returnValue = 1;
                    break;
                case "4":
                    this.operation = 4;
                    this.operationString = "divide";
                    this.operationSymbol = "/";
                    returnValue = 1;
                    break;
                case "Q":
                    System.Environment.Exit(1);
                    break;
                default:
                    
                    returnValue = -1;
                    break;
            }
            switch (returnValue)
            {
                case 1:
                    
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("ERROR: Invalid User Input");
                    Console.WriteLine("");
                    break;
            }
            
            return returnValue;
        }
        private int getNumbers()
        {
            int returnValue = -1;
            int tempInteger = 0;
            while( this.inputCount < 2)
            {
                Console.WriteLine("");
                tempInteger = this.inputCount;
                tempInteger++;
                Console.Write("Input Number [{0}]: ", tempInteger);
                try
                {
                    switch (this.inputCount)
                    {
                        case 0: 
                            this.first = int.Parse(Console.ReadLine());
                            Console.WriteLine($"User Input [1]({this.first})");
                            this.inputCount++;
                            break;
                        case 1:
                            this.second= int.Parse(Console.ReadLine());
                            Console.WriteLine($"User Input [2]({this.first})");
                            this.inputCount++;
                            break;
                        default: 
                            break;

                    }

                }
                catch
                {
                    Console.WriteLine("ERROR PARSING ASCII");
                }

            }
            if (this.inputCount == 2)
            {
                returnValue = 1;
            }

            return returnValue;
        }
        private void doOperations()
        {
            switch (this.operation)
            {
                case 1:
                    Console.Write($"{this.first} {this.operationSymbol} {this.second} = ");
                    Console.Write(this.Add());
                    break;
                case 2: 
                    Console.Write($"{this.first} {this.operationSymbol} {this.second} = ");
                    Console.Write(this.Subtract());
                    break;
                case 3:
                    Console.Write($"{this.first} {this.operationSymbol} {this.second} = ");
                    Console.Write(this.Multiply());
                    break;
                case 4:
                    Console.Write($"{this.first} {this.operationSymbol} {this.second} = ");
                    Console.Write(this.Divide());
                    break;
                default:
                    Console.WriteLine("This should have been caught already.. What are you doing?");
                    break;
            }
        }
        private int Add()
        {
            return this.first + this.second;
        }

        private int Subtract()
        {
            return this.first - this.second;
        }

        private int Multiply()
        {
            return this.first * this.second;
        }

        private double Divide()
        {
            return (double) this.first / (double) this.second;
        }
    }
}
