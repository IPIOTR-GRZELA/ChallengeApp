using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeApp;

public class Program
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    //
    // Lista ocen jest prywatna, aby nikt z zewnątrz nie mógł jej uszkodzić
    private List<int> _ratings = new List<int>();

    public Program(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public void AddRating(int rating)
    {
        if (rating >= 1 && rating <= 10)
        {
            _ratings.Add(rating);
        }
    }

    // Właściwość obliczana na bieżąco
    public int TotalPoints => _ratings.Sum();
}