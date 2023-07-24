namespace Calculator
{
    //```cs
     class Program 
     {
    static void Main(string[] args) 
    {
            string value;
            do
            {
                double res;
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Choose a symbol(*, /, +, -, %, ^): ");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition: " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Substraction: " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication: " + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division: " + res);
                        break;
                    case "%":
                        res = num1 % num2;
                        Console.WriteLine("Modulus: " + res);
                        break;
                    case "^":
                        res = Math.Pow(num1, num2);
                        Console.WriteLine("Power of: " + res);
                        break;
                    default:
                        Console.WriteLine("Wrong Input: ");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }
  }
  //```cs
}