using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 멤버변수 : 클래스 내부에 있다고 해서 멤버변수이다.
    int Att;
    int Hp;

    void Fight()
    {
        // 선언되는 순간 지역변수는 메모리화 된다.
        int Damage = 0;

        Console.WriteLine("플레이어가 싸운다");
    }
} // 게임에서 사용하기 위해서 여기까지 설계했다.

namespace _06LocalVar
{
    // C#은 고지식한 객체지향 언어이다.
    // 프로그램의 시작조차도 class안에 묶어놔야 한다.
    class Program
    {
        // 시작용 함수
        static void Main(string[] args)
        {
            // 함수 안에 있으면 지역변수이다.
            // 지역변수는 함수 내부에서만 사용가능하다.

            int Att = 0;
            Att = 50;
            // 객체화
            // 클래스는 설계도다.
            // Player의 설계대로 플레이어를 만드는데 그 이름을 NewPlayer라고 하라.
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            Console.WriteLine("지역변수");
        }
    }
}
