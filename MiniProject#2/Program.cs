using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniProject_2 {
    internal class Program {
        static void Main(string[] args) {

            List<Objective> objectives = new List<Objective>() {
                new Objective("Learn C#", "Me")
            };

            string operationInput = "";

            while (operationInput != "4") {
                Console.WriteLine("Menu: \n1. Add a new task \n2. Show all tasks \n3. Add a person to an existing task \n4. Exit");
                Console.Write("Please select an operation (1-4): ");
                operationInput = Console.ReadLine();

                Console.Clear();

                if (operationInput == "4") {
                    Console.WriteLine("Goodbye!");
                    continue;
                }


                switch (operationInput) {
                    case "1":
                        Console.Write("Please enter the task's text: ");
                        string name = Console.ReadLine();
                        Console.Write("Please enter a person or multiple persons separated by a ,: ");
                        string personOrPersons = Console.ReadLine();
                        if (personOrPersons.Contains(",")) {
                            List<string> persons = personOrPersons.Split(',').ToList();
                            objectives.Add(new Objective(name, persons));
                        } else {
                            objectives.Add(new Objective(name, personOrPersons));
                        }
                        Console.WriteLine("Your task has been added");
                        break;
                    case "2":
                        for (int i = 0; i < objectives.Count; i++) {
                            Console.WriteLine($"{i + 1}. Name: {objectives[i].Text}, Persons: {string.Join(", ", objectives[i].Persons.ToArray())}");
                        }
                        break; 
                    case "3":
                        for (int i = 0; i < objectives.Count; i++) {
                            Console.WriteLine($"{i + 1}. Name: {objectives[i].Text}, Persons: {string.Join(", ", objectives[i].Persons.ToArray())}");
                        }
                        Console.Write("Please enter the task's number: ");
                        int number = int.Parse(Console.ReadLine());
                        Console.Write("Please enter the person, you want to add: ");
                        string person = Console.ReadLine();
                        if (objectives.Count < number) {
                            Console.WriteLine($"That task doesn't exist");
                        } else {
                            objectives[number - 1].AddPerson(person);
                            Console.WriteLine($"{person} has been added");
                        }

                        break;
                }

                Console.WriteLine();
            }            
        }
    }
}
