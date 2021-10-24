using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player
{
    // 객체화를 하지 않아도 플레이어의 내부이므로
    // 접근제한 지정자의 영향을 받지 않는다.
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    //static public void PVE(Player _Left, Monster _Right)
    //{
    //    _Left.HP -= _Right.AT;
    //    _Right.HP -= _Left.AT;
    //}

    private int AT = 100;
    private int HP = 100;

    public void Damage(int _Damage)
    {
        HP -= 100;
    }
    public void Damage(Player _Other)
    {
        // 자기 자신의 레퍼런스는 자신의 내부에서
        // 모두 public인 상태
        HP -= _Other.AT;
    }
}

public class Monster
{
    private int AT = 100;
}
namespace _14StaticFunc
{
    class Program
    {
        // 클래스에 속한 정적 함수
        static void Main(string[] args)
        {
            Console.WriteLine("static 함수");

            //Player NewPlayer1 = new Player();
            //Player NewPlayer2 = new Player();

        }
    }
}
