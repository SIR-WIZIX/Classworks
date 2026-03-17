using System;
namespace Classwork1
{
  public abstract class Animal
  {
    protected int _age;

    public int Age => _age;

    public Animal(int age)
    {
      _age = age;
    }

    public void Print()
    {
      Console.Write(_age + "\n");
    }

    public virtual string GenerateName()
    {
      return "Oleg";
    }
    public abstract void Voice();
  }

  public class Cat : Animal
  {
    public Cat(int age) : base(age){}

    public new void Print()
    {
      Console.Write(_age + " years\n");
    }

    public override string GenerateName()
    {
      return "Neko";
    }

    public override void Voice()
    {
      Console.Write("~meow~\n");
    }
  }

  public class Dog : Animal
  {
    public Dog(int age) : base(age){}

    public override void Voice()
    {
      Console.Write("BARK!\n");
    }
  }
}

