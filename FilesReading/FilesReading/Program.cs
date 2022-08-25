internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            using (StreamReader reader = new StreamReader("StringReader.txt"))
            {
                Console.WriteLine("Print content of .txt files: ");
                Console.WriteLine(); 
                Console.WriteLine(reader.ReadToEnd());
            }
        } catch(Exception e)
        {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.ToString());
        }
    }
}