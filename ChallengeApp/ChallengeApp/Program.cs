using System;
using System.Collections.Generic;

namespace ChallengeApp;

class Program
{
    static void Main(string[] args)
    {
        // 1. Tworzenie obiektów
        var emp1 = new Employee("Adam", "Kowalski", 30);
        var emp2 = new Employee("Monika", "Nowak", 25);
        var emp3 = new Employee("Piotr", "Zieliński", 35);

        // 2. Dodawanie ocen
        emp1.AddRating(8); emp1.AddRating(7); emp1.AddRating(9);
        emp1.AddRating(10); emp1.AddRating(6);

        emp2.AddRating(10); emp2.AddRating(10); emp2.AddRating(9);
        emp2.AddRating(10); emp2.AddRating(8);

        emp3.AddRating(5); emp3.AddRating(6); emp3.AddRating(4);
        emp3.AddRating(7); emp3.AddRating(5);

        // 2b. Kary (ujemne punkty)
        emp1.AddPenalty(3);   // Adam dostał karę -3
        emp3.AddPenalty(10);  // Piotr dostał karę -10

        // 3. Logika wyszukiwania lidera
        var employees = new List<Employee> { emp1, emp2, emp3 };
        Employee? bestEmployee = null;
        int maxPoints = int.MinValue;

        foreach (var emp in employees)
        {
            if (emp.TotalPoints > maxPoints)
            {
                maxPoints = emp.TotalPoints;
                bestEmployee = emp;
            }
        }

        // 4. Wyświetlanie wyników
        if (bestEmployee != null)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("ZWYCIĘZCA RANKINGU:");
            Console.WriteLine($"{bestEmployee.FirstName} {bestEmployee.LastName}");
            Console.WriteLine($"Wiek: {bestEmployee.Age}");
            Console.WriteLine($"Wynik całkowity: {bestEmployee.TotalPoints}");
            Console.WriteLine("--------------------------------------");
        }//
    }
}