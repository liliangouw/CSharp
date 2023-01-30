namespace refout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //会报错，因为i,j没有赋值
            //int i; int j;
            //RefTest(ref i, ref j);

            int i = 1; int j = 2;
            RefTest(ref i, ref j);
            Console.WriteLine($"i={i.ToString()};j={j.ToString()}");
            int k; int l;
            OutTest(out k, out l);
            Console.WriteLine($"k={k.ToString()};l={l.ToString()}");

            Console.ReadLine();
        }
        static void RefTest(ref int i, ref int j)
        {
            i = 3; j = 4;
        }
        static void OutTest(out int i, out int j)
        {
            //必须在退出前给i,j赋值
            i = 0;
            j = 1;
        }
    }
}