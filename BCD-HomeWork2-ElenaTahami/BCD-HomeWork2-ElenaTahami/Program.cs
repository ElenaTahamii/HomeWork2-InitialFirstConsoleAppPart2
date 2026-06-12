using System;

class Student
{
    private string name = "";
    private int age;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public void Introduce()

    {
        Console.WriteLine($" hello My Name is  {Name} and I am  {Age}  years old");
    }
}

class Program
{
    static void Main()

    {

        Student p = new Student();
        p.Name = "Elena";
        p.Age = 33;
        p.Introduce();
    }

}
