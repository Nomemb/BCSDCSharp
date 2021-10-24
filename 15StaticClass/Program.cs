using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적 클래스
// 정적 멤버변수와 정적 멤버함수만 가질 수 있다.
static class StClass
{
    // 일반 멤버변수는 선언만 해도 오류가 난다.
    // int TEST = 100;
}
class Player
{
    // 함수의 위치는 문법적으론 어디있든 상관없다.

    static void Main(String[] args)
    {
        Console.WriteLine("정적 멤버 함수");
    }
}
namespace _15StaticClass
{
    class Program
    {
    }
}
