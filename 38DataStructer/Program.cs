using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 자료구조를 만들어 보는 것은 게임프로그래머의 기초소양이다.
// 총알이 1000발 발사될 때 관리하는 방법
// NPC가 500명 있을 때 "피오나"라는 이름의 NPC를 찾는 방법
// 위 사례들을 효율적으로 할 수 있게 해주는 방법이 자료구조다.

class MyDataStruct<T>
{
    // 다음의 구조나 인터페이스를 지원한다.
    // 삽입()
    // 탐색()
    // 확장() -> 배열은 확장기능이 없다.

    public void Push(T _Data)
    {
        // if 새 자료가 들어왔을 때 사이즈를 오버하면
        //{
        //     MDS.EX(적절한 수);
        //}

    }

    public int Find(T _Data)
    {
        return 1000;
    }

    public void Ex(int _Size)
    {

    }
}
namespace _38DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자료구조라는 것은
            // int 10
            // 0 1 2 3 4 5 6 7 8 9

            // 다음의 구조나 인터페이스를 지원한다.
            // 삽입()
            // 탐색()
            // 확장() -> 배열은 확장기능이 없다.

            // 자료구조는 보통 컨테이너라는 용어를 사용한다.
            // 시퀸스 컨테이너와 연관 컨테이너, 어뎁터 컨테이너라고 분류한다.
            
            // 시퀸스 컨테이너 : 넣는 순서대로 저장한다. List(C#) Vector(C#엔 없다)
            // 연관 컨테이너 : 자료구조를 정렬해서 저장한다. Dictionary(C# 해쉬 맵) map(C++)
            // 어뎁터 컨테이너 : stack queue
            // 데이터의 메모리 구조는 배열과 노드형이다.


            // 자료구조이다.
            int[] Arr = new int[10];

            Arr[0] = 0;
            Arr[1] = 1;

            MyDataStruct<int> MDS = new MyDataStruct<int>();

            MDS.Push(100);
            MDS.Find(50);
            // 보통 자동으로 이루어진다.
            // MDS.Ex(200);
        }
    }
}
