//Variables();

using Business.Concrete;
using Entities.Concrete;
using System;

SelamVer("Melih");
SelamVer("Engin");
SelamVer("Ahmet");
SelamVer();

int sonuc = Topla(6, 58);

//Diziler / Arrays

string student1 = "Melih";
string student2 = "Engin";
string student3 = "Kerem";

Console.WriteLine(student1);
Console.WriteLine(student2);
Console.WriteLine(student3);

string[] students = new string[3];
students[0] = "Melih";
students[1] = "Engin";
students[2] = "Kerem";

students = new string[4];
students[3] = "İlker";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Antalya", "Diyarbakır" };
cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

Person person1 = new Person();
person1.FirstName = "MELİH";
person1.LastName = "DİNÇER";
person1.DateOfBirthYear = 1990;
person1.NationalIdentity = 1234567890;

Person person2 = new Person();
person2.FirstName = "Engin";

foreach (string city in cities1)
{
    Console.WriteLine(city);
}

List<string> newCities1 = new List<string> { "Ankara 1", "Istanbul 1", "İzmir 1" };
newCities1.Add("Adana 1");
foreach (var city in newCities1)
{
    Console.WriteLine(city);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();
static void Variables()
{
    string message = "Merhaba";
    double amount = 100000; //db den gelir
    int number = 100;
    bool inLogged = false;

    string name = "Melih";
    string surname = "Dinçer";
    int birthYear = 1990;
    long tcNo = 12345678910;

    Console.WriteLine(amount * 1.18);
    Console.WriteLine(amount * 1.18);
}

static void SelamVer(string name = "isimsiz")
{
    Console.WriteLine($"Merhaba {name}");
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine($"Toplam: {sonuc.ToString()}");
    return sonuc;
}
