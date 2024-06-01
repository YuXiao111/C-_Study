using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "for循环删除集合中的元素";
            List<string> list = new List<string>() { "red","green",null, "blue", "blue", "gray","yellow","white","orange" };

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == "blue")
            //    {
            //        list.Remove("blue");
            //    }
            //}
            for(int i=list.Count-1; i>=0; i--)
            {
                if ("blue".Equals(list[i]))
                {
                    list.Remove("blue");
                }
            }

            //Lambda表达式
            //对于列表list中的每一个元素p，都执行Console.WriteLine(p)操作
            list.ForEach(p=>Console.WriteLine(p));
            Console.ReadKey();
        }
    }
}
