namespace pr4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int position = 1; 

            while (true)
            {

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    position = 0;
                    Console.SetCursorPosition(0, position);
                    DataB();
                    position = 1;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    position = 0;
                    Console.SetCursorPosition(0, position);
                    DataA();
                    position = 1;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;   
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++; 
                }

                Console.Clear();
                DataA();
                if (position == -1)
                {
                    position = 1;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    position = 0;
                    Console.SetCursorPosition(0, position);
                    DataB();
                    position = 1;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    position = 0;
                    Console.SetCursorPosition(0, position);
                    DataA();
                    position = 1;
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();

            }
        }
        static void DataA()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int position = 1;

            DateTime dateTime = new DateTime(2022, 10, 20);
            new DateTime(2022, 10, 20);
            Console.WriteLine(dateTime);
            Console.WriteLine("  1.Выжить");
            Console.WriteLine("  2.Не потеряться в лесу");

            if (position == 1)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Note1();
                    Console.ReadKey(key.Key == ConsoleKey.End);
                    Console.Clear();
                    DataA();
                }
            }
            if (position == 2)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    
                    Note2();
                    Console.ReadKey(key.Key == ConsoleKey.End);
                    Console.Clear();
                    DataA();
                }

            }
        }
        static void DataB()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            int position = 1;

            DateTime dateTime = new DateTime(2022, 05, 13);
            new DateTime(2022, 05, 13);
            Console.WriteLine(dateTime);
            Console.WriteLine("  1.Убийство в отеле Континенталь               ");
            Console.WriteLine("                       ");
            if (position == 1)
            {
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Note3();
                    Console.ReadKey(key.Key == ConsoleKey.End);
                    Console.Clear();
                    DataB();
                }
            }
        }
        static void DataC()
        {
            DateTime dateTime = DateTime.Now;
            new DateTime(2012, 11, 07);
            Console.WriteLine(dateTime);
        }
        static void Note1()
        {
            Console.WriteLine("Выжить");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Опиание: Не попадать Константину Алексеевичу Дзюбе на глаза");
            DateTime dateTime = new DateTime(2022, 10, 20);
            new DateTime(2022, 10, 20);
            Console.WriteLine(new DateTime(2022, 10, 20));
        }
        static void Note2()
        {
            Console.WriteLine("Не потеряться в лесу");
            Console.WriteLine("------------------");
            Console.WriteLine("Опиание: Потерялся=СМЭРТЬ");
            DateTime dateTime = new DateTime(2022, 10, 20);
            new DateTime(2022, 10, 20);
            Console.WriteLine(new DateTime(2022, 10, 20));
        }
        static void Note3()
        {
            Console.WriteLine("Убийство в отеле Континенталь");
            Console.WriteLine("---------------");
            Console.WriteLine("Опиание: Экскамьюникадо");
            DateTime dateTime = new DateTime(2022, 05, 13);
            new DateTime(2022, 05, 13);
            Console.WriteLine(new DateTime(2022, 05, 13));
        }

    }
}


    

    


