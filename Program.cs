namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int index_1 = str.IndexOf("/*");
            int index_2 = str.LastIndexOf("*/");
            str = str.Remove(index_1, index_2 - index_1 + 2);

            int index_3 = str.IndexOf("//");
            str = str.Remove(index_3);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}