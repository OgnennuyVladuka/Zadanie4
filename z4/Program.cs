namespace z4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до файла:");
            string s = Console.ReadLine();
            string[] names = s.Split('/');
            int dlin = names.Length;
            Console.WriteLine("Имя файла:\r\n" +
                (names[dlin - 1]));
        }
    }
}