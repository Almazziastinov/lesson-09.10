using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lesson_09._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Random rnd = new Random();
            int[] bavar = new int[17];
            int[] shols = new int[21];
            Console.WriteLine(Bear(bavar, shols));



            Console.WriteLine("Задание 3");
            var students = new List<string>()
            {
                { "Арещенко Мария  Балл: 278\nПредметы: Рус.Яз., Математика, Физика"},
                { "Шипило Анна  Балл: 270\nПредметы: Рус.Яз., Математика, Физика"},
                { "Игуменов Илья  Балл 263\nПредметы: Рус.Яз., Математика, Физика" },
                { "Зиастинов Алмаз  Балл 258\nПредметы: Рус.Яз., Математика, Физика" }

            };
            List<string> value = students;
            foreach(var items in value)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("menu\nЕсли вы новый студент и вас нет в списке напешите: новый студен\nЕсли вы хотите удалить себя из списка впишите: удалить\nЕсли вы хотите отсортировать список впишите: сортировка ");
            string newstud = Console.ReadLine();
            if (newstud == "новый студен")
            {
                Console.WriteLine("Впишите, пожалуйста, ваши: имя, фамилия, общее количество баллов, предметы, которые сдавали");
                string name = Console.ReadLine();
                int ball = Convert.ToInt32(Console.ReadLine());
                string predmety = Console.ReadLine();
                students.Add(name);
                students.Add(ball.ToString());
                students.Add(predmety);
                Console.WriteLine(items);
            }
            string name1 = Console.ReadLine();
            bool conteinsValue = students.ContainsValue(name1);

        }
            static string Bear(int[]a, int[]b)
        {
            Random rnd = new Random();
            int sumbv = 0;
            int sumsh = 0;
            for(int i = 0; i<a.Length; i++)
            {
                a[i] = rnd.Next(0, 9);
                Console.Write(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(0, 9);
                Console.Write(b[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]==5)
                {
                    sumbv += 1;
                }

            }
            for (int i = 0; i < b.Length; i++)
            {
                if(b[i] ==5)
                {
                    sumsh += 1;
                }

            }
            if(sumbv == sumsh)
            {
                return "все пьют";

            }
            else
            {
                return"никто не пьёт";
            }
        }
    }
}
