namespace ConsoleApp_160924
{
    class Solutions
    {
        public void Pattern1()
        {
            int space_count = 5;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <=7; j++)
                {
                    if (j <= i || j>=8-i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        //space logic
                        if(j<=space_count+1)
                        { 
                            Console.Write(" ");
                        }
                        
                    }
                }
                space_count -= 1;

                Console.WriteLine();
            }
        }
        public void Series2()
        {
            int n1 = 2;//even place
            int n2 = 9;
            for (int i = 1; i <= 18; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($" {n2 * n2 * n2} ");
                    n2 = n2 - 1;
                }
                else
                {
                    Console.Write($" {n1}");
                    n1 = n1 + 2;
                }
            }
        }
        public void Series1()
        {
            int n1 = 2;//even place
            int n2 = 9;
            for (int i = 0; i < 9; i++)
            {
                Console.Write($"{n1} {n2*n2*n2} ");
                n1 = n1 + 2;
                n2 = n2 - 1;
            }
        }
        public void DigitOccurenceInNumber()
        {

            int[] arr = new int[10];

            int no;
            Console.WriteLine("Enter number");
            no = int.Parse(Console.ReadLine());//12132
            double rem;
            while (no > 0)//0>0
            {
                rem = no % 10;//1
                arr[(int)rem]++;    //arr[1]++
                no = no / 10;//0
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine($"{i}-->{arr[i]} times");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solutions s1 = new Solutions();
            // s1.DigitOccurenceInNumber();
            //s1.Series1();
            //Console.WriteLine("\n-----------------\n");
            //s1.Series2();
            s1.Pattern1();
        }
    }
}
