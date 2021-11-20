/*3.Напишите в классе Student метод-инвариант класса
 *Класс Student написала, но не нашла общего решения для методов-инвариантов в классе*/

using System;

namespace lab_17
{ 
    class Student 
    {
        //Закрытые поля
        private string fio;
        private int group, a, b, c;
        public Student(string fio, int group, int a, int b, int c) // Конструктор
        {
            this.fio = fio;
            this.group = group;
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Sr() //Метод вычесления среднего
        {
            return ((double)(a + b + c) / 3);
        }
        public void Vivod() // Метод для вывода информации
        {
            Console.WriteLine("ФИО : {0}", fio);
            Console.WriteLine("Группа: {0}", group);
            Console.WriteLine("Оценки :{0} {1} {2}", a, b, c);
            Console.WriteLine("Средний балл : {0}", Sr());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Иванов Иван Иванович", 24, 5, 4, 2);
            student.Vivod();
            Console.ReadKey();
        }
    }
}
