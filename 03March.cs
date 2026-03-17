using System;
namespace Classwork1
{
  public class Human
  {
    protected string _name;
    protected int _age;
    protected bool _isMale;

    public Human(string name, int age, bool isMale = true)
    {
      _name = name;
      _age = age;
      _isMale = isMale;
    }

    public void Simple()
    {
      Console.WriteLine("Human method");
    }

    public virtual void Print()
    {
      Console.Write($"Human:\n|Name: {_name}\n|Age: {_age}\n");
    }
  }

  public class Student : Human
  {
    private string _uni;

    public string Uni => _uni;

    public Student(string name, int age, string uni, bool isMale = true) : base(name, age, isMale)
    {
      _uni = uni;
    }

    public override void Print()
    {
      Console.Write($"Student:\n|Name: {_name}\n|Age: {_age}\n|Uni: {_uni}\n");
    }

    public new void Simple()
    {
      Console.WriteLine("Student method");
    }
  }
}

