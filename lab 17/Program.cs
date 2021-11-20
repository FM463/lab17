/*1.Напишите операторы защиты от дублирования для заголовочного файла Student.h.
 * На C# нет заголовочных файлов и защита от дублирования не нужна.
 * 2.Сделайте так, чтобы сообщения о работе конструкторов и деструктора класса Student 
 * выдались на экран только в режиме отладки.*/

using System;

Test();
GC.Collect();
GC.WaitForPendingFinalizers();

static void Test()
{
    var student = new Student();
    Console.WriteLine(student);
}

internal sealed class Student
{
    public Student()
    {
#if DEBUG
        Console.WriteLine("constructed");
#endif
    }

    ~Student()
    {
#if DEBUG
        Console.WriteLine("destrtucted");
#endif
    }
}  /*на C# не принято использовать деструкторы, лучше использовать IDisposable или IAsyncDisposable
