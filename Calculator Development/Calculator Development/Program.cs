// Hello World! program
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            double num01;
            double num02;
            double num03;
            double num04 = 3;
            bool calc = true;
          

            while (calc)

            {
                Console.Title = "SimpleCalculator";
                try
                {
                    

                    Console.Write("\nInput a number: ");
                    num01 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Input a second number: ");
                    num02 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Input a third number: ");
                    num03 = Convert.ToDouble(Console.ReadLine());

                    double result = (num01 + num02 + num03) / num04;
                    Console.Write("The result is: " + result + "\n");

                    Console.WriteLine("Type next to continue each time you are done with your equation.");
                    string next = "next";



                    if (Console.ReadLine() == next)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.Write("Please enter a valid number: " + e.Message);


                }
            }


            while (calc)
            {
                {
                    try
                    {

                        Console.Write("\nInput enter a number: ");
                        num01 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Input enter a second number: ");
                        num02 = Convert.ToDouble(Console.ReadLine());

                        double resultt = (num01 * num02);
                        Console.Write("The result is: " + resultt + "\n");



                        string next = "next";

                        if (Console.ReadLine() == next)
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Write("Please enter a valid number: " + e.Message);
                    }
                }
            }

            while (calc)
            {
                {
                    try
                    {

                        Console.Write("\nInput enter a number: ");
                        num01 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Input enter a second number: ");
                        num02 = Convert.ToDouble(Console.ReadLine());

                        double resullt = (num01 + num02);
                        Console.Write("The result is: " + resullt + "\n");



                        string next = "next";

                        if (Console.ReadLine() == next)
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Write("Please enter a valid number: " + e.Message);
                    }
                }
            }


            while (calc)
            {
                {
                    try
                    {

                        Console.Write("\nInput enter a number: ");
                        num01 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Input enter a second number: ");
                        num02 = Convert.ToDouble(Console.ReadLine());

                        double resullt = (num01 - num02);
                        Console.Write("The result is: " + resullt + "\n");



                        string next = "next";

                        if (Console.ReadLine() == next)
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Write("Please enter a valid number: " + e.Message);
                    }
                }
            }

            while (calc)
            {
                {
                    try
                    {

                        Console.Write("\nInput enter a number: ");
                        num01 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Input enter a second number: ");
                        num02 = Convert.ToDouble(Console.ReadLine());

                        double resullt = (num01 / num02);
                        Console.Write("The result is: " + resullt + "\n");



                        string next = "next";

                        if (Console.ReadLine() == next)
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Write("Please enter a valid number: " + e.Message);
                    }
                }
            }

            
        }   
    }
}