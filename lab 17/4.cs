/*4.Напишите макрос MyAssert, который выводит сообщение об ошибке,  
 *имя файла и номер строки только при работе на уровне отладки.*/

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace lab_17
{
    class MyAssert
    {
        int a = 3, b = 4, x = 5;
        Console.WriteLine(a + b);
        Console.WriteLine(b - a);
        MyAssert(x != 5);

        [Conditional("DEBUG")]
        static void MyAssert(
            bool x,
            [CallerArgumentExpression("x")] string message = null,
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (!x)
            {
                Console.WriteLine($"ERROR!! Assert {message} failed");
                Console.WriteLine($" on line {sourceLineNumber} in file {sourceFilePath}");
            }
        }
    }
}
