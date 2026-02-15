using System;


// Definicja liczby do sprawdzenia
int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

// Inicjalizacja liczników (Twoja metoda ze wskazówki)
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

// Przechodzenie przez każdy znak i zliczanie
foreach (char letter in letters)
{
    if (letter == '0') counter0++;
    else if (letter == '1') counter1++;
    else if (letter == '2') counter2++;
    else if (letter == '3') counter3++;
    else if (letter == '4') counter4++;
    else if (letter == '5') counter5++;
    else if (letter == '6') counter6++;
    else if (letter == '7') counter7++;
    else if (letter == '8') counter8++;
    else if (letter == '9') counter9++;
}

// WYŚWIETLANIE WYNIKÓW
Console.WriteLine("------------------------");
Console.WriteLine($"Wyniki dla liczby {number}:");
Console.WriteLine("------------------------");

// Wyświetlamy tylko te cyfry, które wystąpiły (licznik > 0)
if (counter0 > 0) Console.WriteLine($"liczba 0: {counter0}");
if (counter1 > 0) Console.WriteLine($"liczba 1: {counter1}");
if (counter2 > 0) Console.WriteLine($"liczba 2: {counter2}");
if (counter3 > 0) Console.WriteLine($"liczba 3: {counter3}");
if (counter4 > 0) Console.WriteLine($"liczba 4: {counter4}");
if (counter5 > 0) Console.WriteLine($"liczba 5: {counter5}");
if (counter6 > 0) Console.WriteLine($"liczba 6: {counter6}");
if (counter7 > 0) Console.WriteLine($"liczba 7: {counter7}");
if (counter8 > 0) Console.WriteLine($"liczba 8: {counter8}");
if (counter9 > 0) Console.WriteLine($"liczba 9: {counter9}");

Console.WriteLine("------------------------");

// DODANIE PUSTYCH PÓL (ODSTĘPU)
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Dziękujemy za skorzystanie z programu!");  

// KOMUNIKAT KOŃCOWY
Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
Console.ReadKey();