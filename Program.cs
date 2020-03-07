using System;
using ExWorkshop.Exceptions;

namespace ExWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                throw new CustomException("Exception Message");
                Console.WriteLine("Hello World!");
            }

            catch (ArithmeticException ex)
            {
                // System.Console.WriteLine(ex);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
            }
            
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

            
            
        }


    }
}