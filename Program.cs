using System;
namespace Classwork1
{
  class Program
  {
    static void Main(string[] args)
    {
      Human human1 = new Human("bob", 67);
      Student student1 = new Student("alice", 15, "collage", false);
      Human student2 = new Student("mclovin", 18, "MIT");
      human1.Simple();
      human1.Print();
      student1.Simple();
      student1.Print();
      student2.Simple();
      student2.Print();

      Human[] queue = new Human[] {human1, student1, student2};
      
      for (int i = 0; i < queue.Length; i++)
      {
	if (queue[i] is Student)
	  Console.WriteLine((queue[i] as Student).Uni);

	Student s = queue[i] as Student;
	if (s != null)
	  Console.WriteLine((queue[i] as Student).Uni);
      }

    }
  }

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

