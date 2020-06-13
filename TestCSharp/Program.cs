using System;
using Widgets;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            WidgetModule.printNumbersFunction(a, b);
            WidgetModule.sumNumberFunction(a, b);

            Console.WriteLine(WidgetsModule.widgetName);
        }
    }
}
