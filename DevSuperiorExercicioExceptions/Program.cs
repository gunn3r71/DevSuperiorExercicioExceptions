using System;
using System.Globalization;
using DevSuperiorExercicioExceptions.Entities;
using DevSuperiorExercicioExceptions.Entities.Exceptions;

namespace DevSuperiorExercicioExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                account.Withdraw(amount);

                Console.WriteLine($"New balance: {account.Balance.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            catch (TransactionException ex)
            {

                Console.WriteLine($"Transaction error: {ex.Message}" );
            }
            catch (FormatException)
            {
                Console.WriteLine($"Please, verify your inputs");
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error");
            }
        }
    }
}
