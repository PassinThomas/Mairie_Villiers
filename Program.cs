using System;

namespace projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            int resultat=0;
            

            Console.Write("Enter the first number in your basic equation: ");
            firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number in your basic equation: ");
            secondNum = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");
                

        string op=Console.ReadLine();
        switch (op)
        {
            case "a" :
                resultat=(firstNum + secondNum);
                break;
            case "s" :
                resultat=(firstNum - secondNum);
                break;
            case "m" : 
                resultat=(firstNum * secondNum);
                break;
            case "d" : 
                resultat=(firstNum / secondNum);
                break;
        }
                Console.Write(resultat);

        }
        
    }
}
