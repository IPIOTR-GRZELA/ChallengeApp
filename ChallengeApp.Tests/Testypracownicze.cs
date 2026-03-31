using NUnit.Framework;
using ChallengeApp;

namespace ChallengeApp.Tests;

[TestFixture]
public class EmployeeTests
{
    [Test]
    public void AddRating_ValidRatings_SumsCorrectly()
    {
        var emp = new Employee("Adam", "Kowalski", 30);
        emp.AddRating(8); emp.AddRating(7); emp.AddRating(9);
        emp.AddRating(10); emp.AddRating(6);
        Assert.That(emp.TotalPoints, Is.EqualTo(40));
    }

    [Test]
    public void AddRating_OutOfRange_0_IsIgnored()
    {
        var emp = new Employee("Test", "Test", 20);
        emp.AddRating(0);
        Assert.That(emp.TotalPoints, Is.EqualTo(0));
    }

    [Test]
    public void AddRating_OutOfRange_11_IsIgnored()
    {
        var emp = new Employee("Test", "Test", 20);
        emp.AddRating(11);
        Assert.That(emp.TotalPoints, Is.EqualTo(0));
    }

    [Test]
    public void AddPenalty_ReducesTotalPoints()
    {
        var emp = new Employee("Adam", "Kowalski", 30);
        emp.AddRating(10); emp.AddRating(10);
        emp.AddPenalty(5);
        Assert.That(emp.TotalPoints, Is.EqualTo(15));
    }

    [Test]
    public void AddPenalty_CanMakeTotalNegative()
    {
        var emp = new Employee("Test", "Test", 20);
        emp.AddRating(3);
        emp.AddPenalty(10);
        Assert.That(emp.TotalPoints, Is.EqualTo(-7));
    }

    [Test]
    public void Employee_FullScenario_AdamWithPenalty()
    {
        var emp = new Employee("Adam", "Kowalski", 30);
        emp.AddRating(8); emp.AddRating(7); emp.AddRating(9);
        emp.AddRating(10); emp.AddRating(6);
        emp.AddPenalty(3);
        Assert.That(emp.TotalPoints, Is.EqualTo(37));
    }
}