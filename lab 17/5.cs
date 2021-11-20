/*5.Напишите макрос DPrint, проверяющий наличие режима отладки, 
 *и если режим отладки определен, печатающий имя и значение, передаваемое в качестве параметра.
 *6.Напишите программу-драйвер, использующую макросы MyAssert и DPrint.
 * Если и можно написать драйвер, то не на C#, а хотя бы на C++.*/

/*на C# нет макросов. Задачу можно решить с помощью инкрементального Source Generator v2 или PostSharp. 
 * Приблизительно похожее можно сделать так:*/
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

DPrint("hi");

var test = "some";
DPrint(test);

[Conditional("DEBUG")]
static void DPrint<T>(
    T value,
    [CallerArgumentExpression("value")] string name = "")
{
    Console.WriteLine($"{name}: {value}");
}
