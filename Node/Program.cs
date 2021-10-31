
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 단순히 자료구조에서만 사용하는 것은 아니다.
// 여러가지 자료를 보관해야 하므로 제네릭을 사용한다.
class Node<T>
{
    public T Data;

    // 자신 안에 자기 자신을 또 가지는 형태로 되어있는 클래스이다.
    public Node<T> Next = null;
    public Node<T> Prev = null;

    public Node(T _Data)
    {
        Data = _Data;
    }
}

namespace Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> Node1 = new Node<int>(10);
            Node<int> Node2 = new Node<int>(999);
            Node<int> Node3 = new Node<int>(578);

            Node1.Next = Node2;
            Node2.Next = Node3;

            Node<int> CurNode = Node1;
            while (CurNode != null)
            {
                Console.WriteLine(CurNode.Data);
                CurNode = CurNode.Next;
            }

        }
    }
}
