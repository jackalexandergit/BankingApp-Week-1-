/* Author: Jack Alexander
 * Date: 24/09/2026
 */

void BuildBankingApp()
{

    // initialize variables
    int choice;
    double depositAmount, withdrawAmount;
    double accountBalance = 1000.00;

    // display menu
    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1: Deposit or withdraw funds");
    Console.WriteLine("2: View current account information");
    Console.WriteLine("\nPlease choose an option (1-2)\n");

    choice = Convert.ToInt32(Console.ReadLine());

    // process user choice
    if (choice == 1 || choice == 2)
    {
        if (choice == 1)
        {
            Console.WriteLine("\nYou have chosen to deposit or withdraw funds.");
            Console.WriteLine("\nPlease select whether you would like to deposit (1) or withdraw (2):\n");
            int subChoice = Convert.ToInt32(Console.ReadLine());

            // process sub-choice
            if (subChoice == 1)
            {
                Console.WriteLine("\nYou have chosen to deposit funds.");
                Console.WriteLine("\nPlease enter the amount you wish to deposit.");
                Console.Write("\nInclude pence using a decimal point: ");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nYour previous account balance was {accountBalance}");
                accountBalance += depositAmount;
                Console.WriteLine($"\nYour new account balance is {accountBalance}");
            }
            else if (subChoice == 2)
            {
                Console.WriteLine("\nYou have chosen to withdraw funds.");
                Console.WriteLine("\nPlease enter the amount you wish to withdraw.");
                Console.Write("\nInclude pence using a decimal point: ");
                withdrawAmount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nYour previous account balance was {accountBalance}");
                accountBalance -= withdrawAmount;
                Console.WriteLine($"\nYour new account balance is {accountBalance}");
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please select either 1 or 2.");
                return;
            }
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

    // wait for user input before closing
    Console.ReadKey();
}

BuildBankingApp();