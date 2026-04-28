namespace April
{

  internal class Program
  {
    static void Main(string[] args)
    {
      string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      string filePath = Path.Combine(folderPath, "example.txt");

      System.Console.WriteLine(folderPath);

      if (!File.Exists(filePath))
      {
	File.Create(filePath).Close();
      }

      if (!File.Exists(filePath)) throw new Exception("file not created");


     folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
     string dirPath = Path.Combine(folderPath, "example_dir");

      System.Console.WriteLine(dirPath);

      if (!Directory.Exists(dirPath))
      {
	Directory.CreateDirectory(dirPath);
      }

      if (!Directory.Exists(dirPath)) throw new Exception("dir not created");


      string filePath1 = Path.Combine(dirPath, "example.txt");


      if (!File.Exists(filePath1))
      {
	File.Create(filePath1).Close();
      }

      if (!File.Exists(filePath1)) throw new Exception("file not created");

      File.WriteAllText(filePath1, "lox\r\n");
      File.AppendAllText(filePath1, "sam lox, ponyal!\r\n");

      File.Encrypt(filePath1);
    }
  }

}
