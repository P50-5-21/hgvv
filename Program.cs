namespace ConsoleApp16
{

        internal class Program
        {

            public static ConsoleKeyInfo kyky;

            static void Main(string[] args)
            {
                Milo();
            }
            static void List_0_1()
            {
                List<string> zametki = new List<string>();
                Console.WriteLine("Заказ тортов в SAHHouse, торты на ваш выбор");
                Console.WriteLine("Выберите параметр торта");
                Console.WriteLine("---------------");
                zametki.Add("   Форма торта");
                zametki.Add("   Размер торта");
                zametki.Add("   Вкус коржей");
                zametki.Add("   Количество коржей");
                zametki.Add("   Глазурь");
                zametki.Add("   Декор");
                zametki.Add("   Конец заказов");
                zametki.Add("                ");
                zametki.Add("Цена заказа: ");
                zametki.Add("Ваш торт: ");
                foreach (string item in zametki)
                {
                    Console.WriteLine(item);
                }
            }
            static void Milo()
            {

                List_0_1();
                int position = 3;
                Console.SetCursorPosition(0, position);
                Console.Write("->");
                do
                {
                    kyky = Console.ReadKey();
                    if (kyky.Key == ConsoleKey.UpArrow)
                    {
                        Console.SetCursorPosition(0, position--);
                        Console.Write("->");
                    }
                    else if (kyky.Key == ConsoleKey.DownArrow)
                    {
                        Console.SetCursorPosition(0, position++);
                        Console.Write("->");
                    }
                    Console.Write("\r" + new string(' ', 2) + "\r");
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                    if (kyky.Key == ConsoleKey.LeftArrow)
                    {
                        Console.Clear();

                        Console.SetCursorPosition(0, 0);

                        Console.SetCursorPosition(0, 1);
                        List_0_1();
                    }
                    if (kyky.Key == ConsoleKey.RightArrow)
                    {
                        Console.Clear();

                        Console.SetCursorPosition(0, 0);

                        Console.SetCursorPosition(0, 1);
                        List_0_1();
                    }
                    if (kyky.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                } while (true);
                if (position == 2)
                {

                }
            }
        }
    }