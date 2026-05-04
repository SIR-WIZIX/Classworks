namespace GenericsEasy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      p.Print<int>(5);
    }

    public void Print<T>(T param)
    {
      Console.WriteLine(param);
    }

    public class Person<T>
    {
      private T _id;
      public T Id => _id;

      public Person(T id)
      {
	_id = id;
      }
    }
  }
}
