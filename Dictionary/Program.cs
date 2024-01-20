using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Объявляем словарь
                Dictionary<int, string> collection = new Dictionary<int, string>()
               {
                //заполняем словарь данными
                {1210, "Кабинет Ильназа Алмазовича" },
                {302, "Кабинет Талгата Рамилевича" },
                {1305, "Кабинет Лилии Ринатовны"},
              

                //также можно заполнить и по другому
                //[1210] =  "Кабинет ОАиП",
                //[302] = "Кабинет выш.мат",
                //[1311] = "Кабинет зав.отделением"
                };
                collection.Add(1215, "Кабинет Ларисы Гавриловны");//Добавляем новый элемент в словарь
                foreach (var item in collection)
                {
                    Console.WriteLine($"ID {item.Key} = {item.Value}");// выводим на консоль словарь с добавлением нового элемента
                }
                Console.WriteLine();

                collection.Remove(302); //удаляем элемент с ID 302
                foreach (var item in collection)
                {
                    Console.WriteLine($"ID {item.Key} = {item.Value}"); //выводим на консоль словарь с удаленным элементом

                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine($" В словаре обнаружено два одинаковых ID ключа");// исключение на слущай обнаружения двух одинаковых ID
            }
            Console.ReadKey();

        }
    }
}
