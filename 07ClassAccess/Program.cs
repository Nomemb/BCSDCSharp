using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    
    // 객체지향의 캡슐화(은닉화)
    // 접근제한 지정자.

    public int HP; // 외부에도 공개
    protected int ATT; // 자식에게만 공개
    private int DEF; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("플레이어가 싸운다");
    }
} 

namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // 만들어진 객체의 내용을 사용하기 위해서 객체의 이름.을 사용한다.
            // NewPlayer.
            // 접근제한 지정자를 사용하지 않아서 외부에 공개하지 않도록 했다.
            NewPlayer.HP = 0;
        }
    }
}
