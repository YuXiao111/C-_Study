using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Study
{
    internal class Program
    {
        //优点：
        //1.简洁性：Lambda表达式允许你以简洁的方式编写函数或操作。这使得代码更加紧凑和易读。
        //2.匿名性：Lambda表达式没有明确的名称，这使得它们特别适合于只使用一次的短小的函数。
        //3.灵活性：Lambda表达式可以与委托（delegate）和表达式树（expression tree）一起使用，为编程提供了很大的灵活性。你可以将Lambda表达式作为参数传递给方法，或者在LINQ查询中定义筛选、投影和排序等操作。
        //4.类型推断：在Lambda表达式中，编译器可以根据上下文推断参数类型，从而减少了编写冗余代码的需要。
        //5.与LINQ结合：Lambda表达式是LINQ查询的基石。它们允许你以声明性的方式定义数据转换和操作，使查询更加直观和易于理解。
        //6.代码复用：虽然Lambda表达式本身可能是匿名的，但你可以将它们赋值给变量或传递给方法，从而在不同的上下文中复用相同的代码逻辑。

        //缺点：
        //1.可读性：对于不熟悉Lambda表达式的开发人员来说，它们可能会降低代码的可读性。特别是在复杂的Lambda表达式中，理解其功能和意图可能需要更多的时间和努力。
        //2.调试困难：由于Lambda表达式通常是匿名的，所以在调试过程中可能会遇到一些困难。例如，你可能无法直接跳转到Lambda表达式的定义，或者难以确定其执行路径。
        //3.性能开销：虽然Lambda表达式的性能开销通常是可以接受的，但在某些高性能的场景中，它们可能会引入额外的开销。这是因为Lambda表达式在运行时需要被编译成委托或表达式树，这可能会增加内存使用和CPU负担。
        //4.不适合大型逻辑：Lambda表达式最适合用于简短、简单的逻辑。对于复杂的逻辑，最好使用完整的方法或类来实现，以提高代码的可读性和可维护性。
        //5.与静态类型系统的交互：Lambda表达式与静态类型系统之间的交互可能会变得复杂。在某些情况下，你可能需要显式指定参数类型或返回类型，以确保代码的正确性和可编译性。
        //6.学习曲线：对于初学者来说，Lambda表达式可能是一个学习上的挑战。它们需要一定的编程经验和理解才能有效地使用。
        static void Main(string[] args)
        {
            //1.
            // 使用Lambda表达式定义一个委托  
            //Func<int, int, int> add = (x, y) => x + y;
            //int result = add(3, 4); // result 为 7  
            //Console.WriteLine(result);
            //Console.ReadKey();

            //2.
            // 使用Lambda表达式在List<int>上应用ForEach  
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //numbers.ForEach(n => Console.WriteLine(n));
            //Console.ReadKey();

            //3.
            // 使用Lambda表达式在LINQ查询中筛选偶数  
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            evenNumbers.ForEach(n => Console.WriteLine(n));
            Console.ReadKey();
        }
    }
}
