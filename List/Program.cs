using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{
}

class MyList<T>
{
    int[] Arr = new int[0];
    int Capa;
    int Count;

    public void Add(T _add)
    {
        if(Count + 1 >= Capa)
        {
            // 확장
        }
    }
}
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> NewInt = new MyList<int>();
            NewInt.Add(1);
            // 배열형
            // 시퀸스

            // 내가 관리해달라고 요청하는 것이 매번 바뀌기 때무에
            // 제네릭 클래스여야 한다.
            // List<Item> NewList = new List<Item>();

            List<int> NewList = new List<int>();

            // 자료 : 넣어준 int
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1).ToString() + " Add");
                Console.WriteLine("Capacity " + NewList.Capacity); // 배열의 크기
                Console.WriteLine("Count " + NewList.Count); // 자료의 크기
                NewList.Add(i);
            }

            // 탐색에는 유리하지 않은 자료구조라고 본다.
            // 인덱스로 표현할 수 있다면 탐색에 가장 유리한 자료구조다.
            // 내부에 자료가 있는지 없는지 확인
            if (NewList.Contains(8))
            {
                Console.WriteLine("내부에 8이 있습니다.");
            }
            else
            {
                Console.WriteLine("내부에 8이 없습니다.");
            }

            // 인덱서 혹은 연산자 겹지정이라고 부른다.
            Console.WriteLine(NewList[5]);

            NewList.Remove(5); // 5가 있다면 지운다.

            NewList.RemoveAt(1); // 첫번째를 지운다.

            //NewList.RemoveAll(); 다른 리스트 혹은 배열을 넣어줬을 때 비교해서 중복되면 삭제한다.

            NewList.RemoveRange(0, 2); // 0번째부터 2개를 지워라.

            for(int i =0; i< NewList.Count; i++)
            {
                Console.Write(NewList[i]);
            }

        }
    }
}
