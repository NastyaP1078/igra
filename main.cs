using System;

namespace Project
{
    class MainClass
    {
        static string goldUp = "Золото увеличилось";
        static string goldDown = "Золото уменьшилось";
        static string repUp = "Репутация увеличилась";
        static string repDown = "Репутация уменьшилась";
        static string warsUp = "Военная сила увеличилась";
        static string warsDown = "Военная сила уменьшилась";
        static int numVopros = 1;
        int numButton = 0;
        public static void Main(string [] args)
        {
            string[] vopros = new string[9]
            {
            "В честь коронации в нашем госсударстве принято устраивать пир, но золота в казне не так много, что прикажете?",
            "В соседнем царстве произошел пожар, желаете ли вы оказать помощь?",
            "В западной части госсудараства приезжие устроили переполох, что прикажете?",
            "На границе государств найдео месторождение полезных ископаемых!",
            "МЯТЕЖ! Что прикажете?",
            "Госсударство стало мишенью чумы!",
            "У нас голод простых граждан, что будем делать?",
            "Есть подозрения на нападение против соседних государств.",
            "Вы окружены вражескими войсками!"
            };
            string[] otv1 = new string[9]
            {
           "Устраиваем пир!",
           "Да, это улучшит наши отношения.",
           "За решетку!",
           "Добыть.",
           "Договориться мирно.",
           "Устранить болезнь путем сжигания заразившихся.",
           "Взять в долг у соседнего госсударства.",
           "Не вмешиваться",
           "Вступить в войну!"
            };
            string[] otv2 = new string[9]
            {
           "Мы не можем себе это позволить.",
           "Нет, пусть сами разбираются!",
           "Отвезите из восвоясе.",
           "Уведомить остальные госсударства",
           "Разогнать!",
           "Изолировать горожан",
           "Мы сами справимся!",
           "Отправить войска на помощь",
           "Создать коалицию."
            };
            for (int i = 0; i < vopros.Length; i++)
            {
                string bac;
                int numButton = 0;
                Console.WriteLine("_______________________");
                Console.WriteLine(vopros[i]);
                Console.WriteLine("1 - " + otv1[i]);
                Console.WriteLine("2 - " + otv2[i]);
                bac = Console.ReadLine();
                numButton = Convert.ToInt32(bac);
                if (i == 0)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine(goldDown);
                        Console.WriteLine(repUp);
                    }
                    if (numButton == 2)
                    {
                        Console.WriteLine(repDown);
                    }
                }

                if (i == 1)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine(repUp);
                    }
                    if (numButton == 2)
                    {
                        Console.WriteLine(repDown);
                    }
                }

                if (i == 2)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine(repUp);
                        Console.WriteLine(warsDown);
                    }
                    if (numButton == 2)
                    {
                        Console.WriteLine(repDown);
                        Console.WriteLine(warsUp);
                    }
                }

                if (i == 3)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine(repUp);
                        Console.WriteLine(warsDown);
                        Console.WriteLine(goldUp);
                    }
                    if (numButton == 2)
                    {
                        Console.WriteLine(warsUp);
                    }
                }

                if (i == 4)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine(repUp);
                        Console.WriteLine(goldDown);
                    }
                    if (numButton == 2)
                    {
                        Console.WriteLine(repDown);
                    }
                }

                if (i == 5)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine(repDown);
                        Console.WriteLine(goldDown);
                    }
                    if (numButton == 2)
                    {
                        Console.WriteLine(goldDown);
                    }
                }

                if (i == 6)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine(repUp);
                        Console.WriteLine(goldDown);
                    }
                    if (numButton == 2)
                    {
                        Console.WriteLine(repDown);
                    }
                    Console.WriteLine("От следущих вопросов сильно зависит судьба государства!");
                }
                if (i == 7)
                {
                    if (numButton == 2)
                    {
                        Console.WriteLine("Вы сделали неправильный выбор. Поражение!");
                        break;
                    }
                }
                if (i == 8)
                {
                    if (numButton == 1)
                    {
                        Console.WriteLine("Вы сделали неправильный выбор. Поражение!");
                        break;
                    }

                    if (numButton == 2)
                    {
                        Console.WriteLine("Поздравляем! Вы отлично умеете управлять госссударством! ПОБЕДА!");
                        break;
                    }
                }
            }

        }
    }
}
