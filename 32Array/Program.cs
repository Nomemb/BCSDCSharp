using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32Array
{
    class Program
    {
        class Item
        {
            public string Name;
            public int AT;
            public int DF;
        }
        static void Main(string[] args)
        {
            // 배열은 기본자료형에 속한다.

            // 모든 자료형은 구조체 혹은 클래스에 가깝다.
            // 멤버변수와 멤버함수가 있다.
            // int가 10개 생겼다.
            int[] ArrInt = new int[10];
            
            //ArrInt[0]은 int형
            for (int i = 0; i < ArrInt.Length; i++)
            {
                Console.WriteLine(ArrInt[i]);
            }
            // 아이템이 많을 때 사용한다.

            // 아이템이라는 참조형을 
            // 담을 수 있는 공간이 10개 생겼다.

            // 아이템이라는 메모리를
            // 가리킬 수 있는 참조형이 10개 생겼다.
            Item[] ArrItem = new Item[10];
            for (int i = 0; i < ArrInt.Length; i++)
            {
                ArrItem[i] = new Item();
            }
            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "전설검";
            ArrItem[2].Name = "갑옷";
            ArrItem[3].Name = "중갑옷";
            ArrItem[4].Name = "포션";

            for(int i=0; i< ArrItem.Length; i++)
            {
                Console.WriteLine(ArrItem[i].Name);
            }

        }
    }
}
