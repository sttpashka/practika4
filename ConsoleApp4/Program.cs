namespace ежедневник
{
    class D01
    {
        public void Data01()
        {
            Console.WriteLine("21.11.22");
            Console.WriteLine(" 1.Приехать в зал");
            Console.WriteLine(" 2.Поспать");
        }
    }

    class D02
    {
        public void Data2()
        {
            Console.WriteLine("22.11.22");
            Console.WriteLine(" Сделать практику");
            Console.WriteLine(" Поспать");
        }
    }


    class D03
    {
        public void Data03()
        {
            Console.WriteLine("24.11.22");
            Console.WriteLine(" Поиграть");
            Console.WriteLine(" Поспать");
        }
    }




    class MainClass
    {

        public static void Main(string[] ages)
        {


            int position = 1;
            string[] Day2 = new string[] { "Приехать в зал \n —---------------------\n Описание: Качать банки. \n Дата:21.11.22" };
            string[] Day02 = new string[] { "Поспать \n —-----------------------\n Описание : Выспаться. \n Дата :21.11.22" };

            D02 date08 = new D02();
            date08.Data2();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, position);

                }
                Console.Clear();
                date08.Data2();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                if (key.Key == ConsoleKey.Enter && position == 1)
                {
                    Console.Clear();
                    Console.WriteLine(Day2[0]);
                }

                if (key.Key == ConsoleKey.Enter && position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Day02[0]);
                }

                string[] Day7 = new string[] { "Сделать практику \n —----------------------------------------\n Описание: 4 и 5 практики надо. \n Дата: 22.11.22 " };
                string[] Day07 = new string[] { "Поспать \n —----------------------------------------\n Описание : Выспаться хорошенько. \n Дата : 22.11.22" };

                D01 date07 = new D01();


                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    int positi = 1;
                    date07.Data01();
                    while (true)
                    {
                        ConsoleKeyInfo k = Console.ReadKey();
                        if (k.Key == ConsoleKey.UpArrow)
                        {
                            positi--;
                        }

                        else if (k.Key == ConsoleKey.DownArrow)
                        {
                            positi++;
                        }
                        else if (k.Key == ConsoleKey.Enter)
                        {
                            Console.SetCursorPosition(0, positi);

                        }
                        Console.Clear();
                        date07.Data01();
                        Console.SetCursorPosition(0, positi);
                        Console.WriteLine("->");

                        if (k.Key == ConsoleKey.Enter && position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(Day7[0]);
                        }

                        if (k.Key == ConsoleKey.Enter && position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(Day07[0]);
                        }
                        if (key.Key == ConsoleKey.RightArrow)
                        {
                            date08.Data2();
                        }
                    }



                }

                string[] Day3 = new string[] { "Поиграть в игрульки \n —----------------------------------------\n Описание: Отдых \n Дата :24.11.22" };
                string[] Day03 = new string[] { "Поспать \n —----------------------------------------\n Описание : Поспать как убитый \n Дата :24.11.22" };
                D03 date09 = new D03();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    int positio = 1;
                    date09.Data03();
                    while (true)
                    {
                        ConsoleKeyInfo ke = Console.ReadKey();
                        if (ke.Key == ConsoleKey.UpArrow)
                        {
                            positio--;
                        }

                        else if (ke.Key == ConsoleKey.DownArrow)
                        {
                            positio++;
                        }
                        else if (ke.Key == ConsoleKey.Enter)
                        {
                            Console.SetCursorPosition(0, positio);

                        }
                        Console.Clear();
                        date09.Data03();
                        Console.SetCursorPosition(0, positio);
                        Console.WriteLine("->");

                        if (ke.Key == ConsoleKey.Enter && position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(Day3[0]);
                        }

                        if (ke.Key == ConsoleKey.Enter && position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(Day03[0]);
                        }


                    }

                }

            }

        }

    }

}