using System;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

class atm
{
    public static void Main()
    {
        float balance = 500;
        float deposit_amount;
        float withdraw_amount;
        int user_selection;
        int pin = 1234;
        int active_session = 1;
        Console.WriteLine("Please enter your PIN: ");
        int pin_entered = int.Parse(Console.ReadLine());
        if (pin == pin_entered)
            while (active_session == 1)
            {
                Console.WriteLine("1. Balance       2. Withdraw\n");
                Console.WriteLine("3. Deposit       4. Exit\n");
                Console.WriteLine("Please make a selection: ");
                user_selection = int.Parse(Console.ReadLine());
                switch (user_selection)
                {
                    case 1:
                        Console.WriteLine("\n Your current balance is : {0} ", balance);
                        break;
                    case 2:
                        Console.WriteLine("\n Please enter the amount to withdraw: ");
                        withdraw_amount = float.Parse(Console.ReadLine());
                        if (withdraw_amount > balance)
                        {
                            Console.WriteLine("\n You do not have a sufficient funds for that transaction.");
                        }
                        else
                        {
                            balance = balance - withdraw_amount;
                            Console.WriteLine("\n Your new balance is:  {0}", balance);
                            Console.WriteLine("\n\n Please collect your cash and remove your card. ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n Please enter the amount to deposit: ");
                        deposit_amount = float.Parse(Console.ReadLine());
                        balance = balance + deposit_amount;
                        Console.WriteLine("Your new balance is {0}", balance);
                        break;
                    case 4:
                        Console.WriteLine("\n Thank you. Goodbye.");
                        active_session = 0;
                        break;
                }
            }
        else if (pin != pin_entered)
            Console.WriteLine("\n Incorrect PIN. Goodbye.");
    }
}