using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GTest<T>
{
    public T Data;
}
namespace DataStructEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> NewDic;

            List<Dictionary<string, int>> NewTest;

            Dictionary<string, int> DicTest = new Dictionary<string, int>();
            List<int> ListTest = new List<int>();
            LinkedList<int> LinkedListTest = new LinkedList<int>();

            ListTest.Add(1);
            ListTest.Add(2);
            ListTest.Add(3);
            ListTest.Add(4);
            ListTest.Add(5);

            LinkedListTest.AddLast(1);
            LinkedListTest.AddLast(2);
            LinkedListTest.AddLast(3);
            LinkedListTest.AddLast(4);
            LinkedListTest.AddLast(5);


            DicTest.Add("일", 1);
            DicTest.Add("이", 2);
            DicTest.Add("삼", 3);
            DicTest.Add("사", 4);
            DicTest.Add("오", 5);

            // var : 그 시점에서 가장 알맞은 자료형이 되어 준다.

            foreach(var item in ListTest)
            {
                Console.WriteLine(item);
            }
            foreach (var item in LinkedListTest)
            {
                Console.WriteLine(item);
            }
            foreach (var item in DicTest)
            {
                Console.WriteLine(item);
            }


        }
    }
}
