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

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("......................");
            Console.WriteLine("Shorted array elements");
            Console.WriteLine("......................");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
        }
        public void SelectionSortArray()
        {
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[min];
                        a[min] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.read();
            myList.SelectionSortArray();
            myList.display();
            Console.WriteLine("\n\nPress Return to exit.");
            Console.Read();
        }
    }
}