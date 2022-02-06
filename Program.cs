namespace TotalAdd_Ex3_3
{
    class Program
    {

        private static int total(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("1. 請輸入一個整數值：");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("2. 由 1 累計到 {0} 的總和為：{1}", num, total(num));
            Console.Read();
        }
    }
}