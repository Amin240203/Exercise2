namespace Exercise2
{
    internal class Program
    {
        //deinisika array dengan ukuran maksimun
        private int[] a = new int[36];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan jumlah Element/Data array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray maksimum 20 element\n");
            }
            Console.WriteLine("");
            Console.WriteLine(".....................");
            Console.WriteLine("Masukkan elemet Array");
            Console.WriteLine(".....................");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}