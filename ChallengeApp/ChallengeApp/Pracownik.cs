namespace ChallengeApp;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Prywatna lista – nikt z zewnątrz nie może jej bezpośrednio modyfikować
    private readonly List<int> _ratings = new();

    public Employee(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    /// <summary>Dodaje ocenę w zakresie 1–10 (dodatnie punkty).</summary>
    public void AddRating(int rating)
    {
        if (rating >= 1 && rating <= 10)
            _ratings.Add(rating);
    }

    /// <summary>
    /// Dodaje ujemne punkty karne (np. spóźnienia, błędy).
    /// Wartość powinna być dodatnia – zostanie odjęta od sumy.
    /// </summary>
    public void AddPenalty(int penalty)
    {
        if (penalty > 0)
            _ratings.Add(-penalty);
    }

    /// <summary>Suma wszystkich punktów (oceny minus kary).</summary>
    public int TotalPoints => _ratings.Sum();

    /// <summary>Liczba dodanych ocen (łącznie z karami).</summary>
    public int RatingsCount => _ratings.Count;
}