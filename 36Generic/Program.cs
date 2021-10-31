using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적 클래스
// 정적 함수와 정적 변수만을 내부에 둘 수 있다
// 생성자를 만들 수 없다.
public static class GTest
{
    // 제네릭 함수의 용법
    // 멤버함수에도 통용된다.
    // 자료형을 변수처럼 사용하고 싶을 때 사용한다.
    // 함수의 식별자에 <다양한 자료형을 대표할 이름>을 쓴다.
    // 내가 코드를 덜 쓰고 싶을때 사용한다.
    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);
        return _Value;
    }

    public static T ConsolePrint<T, U>(T _Value, U _Value2)
    {
        Console.WriteLine(_Value);
        Console.WriteLine(_Value2);

        return _Value;
    }

    //public static void ConsolePrint(int _Value)
    //{
    //    Console.WriteLine(_Value);
    //}
    //public static void ConsolePrint(string _Text)
    //{
    //    Console.WriteLine(_Text);
    //}
}


class Program
{
    static void Main(string[] args)
    {
        GTest.ConsolePrint(1000);
        GTest.ConsolePrint(100.23101f);

    }
}

