using System;
namespace Classwork1
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
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
      */
      Cat cat1  = new Cat(1);
      cat1.Voice();
      Console.Write(cat1.GenerateName() + '\n');
      cat1.Print();
      
      Animal cat2 = new Cat(2);
      cat2.Voice();
      Console.Write(cat2.GenerateName() + '\n');
      cat2.Print();

      Dog dog1 = new Dog(3);
      dog1.Voice();
      Console.Write(dog1.GenerateName() + '\n');
      dog1.Print();

      Animal dog2 = new Dog(4);
      dog2.Voice();
      Console.Write(dog2.GenerateName() + '\n');
      dog2.Print();
    }
  }
}

