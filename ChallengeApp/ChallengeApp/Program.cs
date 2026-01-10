var name = "Ewa";
var sex = "female";
var age = 33;

if (sex  == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat .");
}
else if(name == "Ewa"&& age == 30) 

{
    Console.WriteLine("Ewa lat 30 .");
}
else if(sex != "female" && age <18)
    {
    Console.WriteLine("Niepełnoletni mężczyzna");
}
// Wszystkie warunki 
else if (sex == "female"|| age <30 || name == "Ewa" || age == 30)
{
    
}