using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_1 {
    internal class Program {
        static void Main(string[] args) {
            
            while(true) {
                Console.WriteLine("Menu: \n1. Addition \n2. Subtraction \n3. Multiplication\n4. Division\n5. Exit");
                Console.Write("Please select an operation (1-5): ");
                string operationInput = Console.ReadLine();
                
                if (operationInput == "5") {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.Write("Please enter your first number: ");
                string firstNumberInput = Console.ReadLine();
                Console.Write("Please enter your second number: ");
                string secondNumberInput = Console.ReadLine();

                int operation;
                int firstNumber;
                int secondNumber;

                try {
                    operation = int.Parse(operationInput);
                    firstNumber = int.Parse(firstNumberInput);
                    secondNumber = int.Parse(secondNumberInput);
                } catch {
                    Console.WriteLine("Please enter valid numbers!");
                    continue;
                }

                int[] numbers = { firstNumber, secondNumber };

                string result = doMath(numbers, operation);

                Console.WriteLine(result);

            }
        }

        static string doMath(int[] numbers, int operation) {
            int result = 0;
            string[] numbersStringArr = new string[numbers.Length];
            string numberString = "";

            switch (operation) {
                case 1:
                    foreach (int number in numbers) {
                       result += number;
                       numbersStringArr[Array.IndexOf(numbers, number)] = number.ToString();
                       numberString = string.Join(" + ", numbersStringArr);
                    }
                    break;
                case 2:
                    result = numbers[0];
                    foreach (int number in numbers) {
                        if (number != numbers[0]) {
                            result -= number;
                        }
                    }
                    break;
            }

            
                

            return $"{numberString} = {result}";
        }
    }
}
