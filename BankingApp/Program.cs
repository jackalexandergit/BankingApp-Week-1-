/* Author: Jack Alexander
 * Date: 24/09/2026
 */

void BuildBankingApp()
{

    int choice;
    double depositAmount;
    double accountBalance = 1000.00; 

    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1: Deposit or withdraw funds");
    Console.WriteLine("2: View current account information");
    Console.WriteLine("\nPlease choose an option (1-2)\n");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1 || choice == 2)
    {
        if (choice == 1)
        {
            Console.WriteLine("\nYou have chosen to deposit or withdraw funds.");
            Console.WriteLine("\nPlease enter the amount you wish to deposit or withdraw:");
            Console.Write("\nInclude pence using a decimal point: ");
            depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nYour original account balance was {accountBalance}");

            accountBalance += depositAmount;
            Console.WriteLine($"\nYour new account balance is {accountBalance}");
        }
        else if (choice == 2)
        {
            Console.WriteLine("\nYou have chosen to view current account information.");
            Console.WriteLine($"\nYour current account balance is {accountBalance}");
        }
    }
    else
    {
        accountBalance = 1000.00;
        Console.WriteLine($"\nYour current account balance is {accountBalance}");
    }

    Console.ReadKey();
}

BuildBankingApp();