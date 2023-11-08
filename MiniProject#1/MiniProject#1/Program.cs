using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_1 {
    internal class Program {
        static void Main() {

            string operationInput = "";
            while (operationInput != "6") {
                Console.WriteLine("Menu: \n1. Addition \n2. Subtraction \n3. Multiplication\n4. Division\n5. Power\n6. Exit");
                Console.Write("Please select an operation (1-6): ");
                operationInput = Console.ReadLine();
                
                if (operationInput == "6") {
                    Console.WriteLine("Goodbye!");
                    continue;
                }

                Console.WriteLine("Please enter your numbers using spaces to seperate.");

                string numberInput = Console.ReadLine();

                string[] numberInputs = numberInput.Split(' ');

                int operation;
                float[] numbers = new float[numberInputs.Length];

                if (numberInputs.Length < 2) {
                    Console.WriteLine("Please enter at least 2 numbers!\n");
                    continue;
                }

                try {
                    operation = int.Parse(operationInput);
                    for (int i = 0; i < numberInputs.Length; i++) {
                        numbers[i] = float.Parse(numberInputs[i]);
                    }
                } catch {
                    Console.WriteLine("Please enter valid numbers!\n");
                    continue;
                }

                if (operation == 5 && numbers.Length > 2) {
                    Console.WriteLine("Please enter not more than two numbers for this operation!\n");
                    continue;
                }

                string result = doMath(numbers, operation);

                Console.WriteLine(result + "\n");

            }
        }

        static string doMath(float[] numbers, int operation) {
            float result = 0;
            string[] numbersStringArr = new string[numbers.Length];
            string numberString = "";

            switch (operation) {
                case 1:
                    foreach (float number in numbers) {
                       result += number;
                       numbersStringArr[Array.IndexOf(numbers, number)] = number.ToString();
                       numberString = string.Join(" + ", numbersStringArr);
                    }
                    break;
                case 2:
                    result = numbers[0];
                    numbersStringArr[0] = numbers[0].ToString();
                    for (int i = 1; i < numbers.Length; i++) {
                        result -= numbers[i];
                        numbersStringArr[i] = numbers[i].ToString();
                        numberString = string.Join(" - ", numbersStringArr);
                    }
                    break;
                case 3:
                    result = numbers[0];
                    numbersStringArr[0] = numbers[0].ToString();
                    for (int i = 1; i < numbers.Length; i++) {
                        result *= numbers[i];
                        numbersStringArr[i] = numbers[i].ToString();
                        numberString = string.Join(" * ", numbersStringArr);
                    }
                    break;
                case 4:
                    result = numbers[0];
                    numbersStringArr[0] = numbers[0].ToString();
                    for (int i = 1; i < numbers.Length; i++) {
                        result /= numbers[i];
                        numbersStringArr[i] = numbers[i].ToString();
                        numberString = string.Join(" / ", numbersStringArr);
                    }
                    break;
                case 5:
                    result = (float)Math.Pow(numbers[0], numbers[1]);
                    numberString = $"{numbers[0]}^{numbers[1]}";
                    break;
            }

            return $"{numberString} = {result}";
        }
    }
}
