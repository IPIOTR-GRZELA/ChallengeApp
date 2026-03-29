using System;
using System.Collections.Generic;

namespace ChallengeApp;

class Employee
{
    static void Main(string[] args)
    {
        // 1. Tworzenie obiektów
        var emp1 = new Program("Adam", "Kowalski", 30);
        var emp2 = new Program("Monika", "Nowak", 25);
        var emp3 = new Program("Piotr", "Zieliński", 35);

        // 2. Dodawanie ocen
        emp1.AddRating(8); emp1.AddRating(7); emp1.AddRating(9); emp1.AddRating(10); emp1.AddRating(6);
        emp2.AddRating(10); emp2.AddRating(10); emp2.AddRating(9); emp2.AddRating(10); emp2.AddRating(8);
        emp3.AddRating(5); emp3.AddRating(6); emp3.AddRating(4); emp3.AddRating(7); emp3.AddRating(5);

        var employees = new List<Program> { emp1, emp2, emp3 };

        // 3. Logika wyszukiwania lidera
        Program bestEmployee = null;
        int maxPoints = -1;

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
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ZWYCIĘZCA RANKINGU:");
            Console.WriteLine($"{bestEmployee.FirstName} {bestEmployee.LastName}");
            Console.WriteLine($"Wiek: {bestEmployee.Age}");
            Console.WriteLine($"Wynik całkowity: {bestEmployee.TotalPoints}");
            Console.WriteLine("----------------------------------");
        }
    }
}