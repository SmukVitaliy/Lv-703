using System;
namespace VitaliySmuk_HomeWork_4;
class VitaliySmuk
{
    static void Main(string[] args)
    {
        var persons = new Person[4];
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i] = Person.Input(i);
        }
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i].Output();
            persons[i].Age();
        }
        Console.WriteLine("\nTo check if you are still very young =) and to know if there is anyone with same name like you press enter");
        Console.ReadLine();
        for (int i = 0; i < persons.Length; i++)
        {
            persons[i].ChangeName();
            persons[i].Output();
        }
        for (int i = 0; i < persons.Length; i++)
        {
            for (int x = i + 1; x < 4; x++)
            {
                if (persons[i] == persons[x])
                {
                    Console.WriteLine($"\nname {i + 1} is same vith name {x + 1}");
                }
            }
        }
    }
}
