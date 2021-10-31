using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 보통 멤버변수가 Get, Set의 타겟이 된다.
    int AT = 10;

    public int ProAT
    {
        // 프로퍼티의 GET함수는 무조건 int를 리턴한다고 본다.
        get
        {
            if (999 < AT)
            {
                Console.WriteLine("최대치를 넘겼습니다.");
            }
            return AT;
        }

        // 무조건 int 하나가 들어온다고 생각한다.
        set
        {
            AT = value;
        }
    }
    public int GetAT()
    {
        return AT;
    }

    public void SetAT(int _Value)
    {
        if (999 < _Value)
        {
            Console.WriteLine("최대치를 넘겼습니다.");
            //while (true) { Console.ReadKey(); }
        }
        AT = _Value;
    }
}

namespace _26Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 함수를 변수처럼 사용할 수 있다.
            NewPlayer.ProAT = 100;
            int a = NewPlayer.ProAT;
        }
    }
}
