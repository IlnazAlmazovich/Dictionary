using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    //Заполнить очередь именами студентов из группы. 
                    //Создать словарь где ID записи будет генерироваться с помощью класса Random
                    //а значения будут браться из созданной ранее очереди
                    //Затем пользователь вводит случайное число. Определить  есть ли запись с ID равное числу который ввёл пользователь
            try
            {

                    Queue students = new Queue();
                    students.Enqueue("Белов Юрий");
                    students.Enqueue("Сафина Ильдина");
                    students.Enqueue("Платонова Полина");
                    students.Enqueue("Рюхова Софья");
                    students.Enqueue("Кулыев Денис");
                    students.Enqueue("Строй Владислав");
                    students.Enqueue("Данилова Даша");
                    students.Enqueue("Кузнецова Лера");

                    Random random = new Random();
                    Dictionary<int, string> dictionary = new Dictionary<int, string>();

                    foreach (var stud in students)
                    {
                        int key = random.Next(0,100); 
                        dictionary.Add(key, stud.ToString());
                    }

                    foreach (var d in dictionary)
                    {
                        Console.WriteLine($"ID: {d.Key} - ФИО: {d.Value}");
                    }

                Console.WriteLine("Введите ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                if (dictionary.ContainsKey(id))
                {
                    Console.WriteLine($"Запись с ID {id} существует. Имя студента: {dictionary[id]}");
                }
                else
                {
                    Console.WriteLine($"Запись с ID {id} не найдена");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
