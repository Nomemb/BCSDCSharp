using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 객체가 생기면 만들어진다.
    private int HP = 100;

    //public void Damage(int _Dmg)
    //{
    //    // C#은 어떻게 
    //    // HP -= _Dmg;
    //    this.HP -= _Dmg;
    //}

     // 멤버함수의 호출이란 어짜피 넣을 것을 대신 넣게 해준다.
    public void Heal(/*Player _this,*/ int _Heal)
    {
        // 멤버함수에서 멤버 변수를 쓴다면
        // 앞에 this.가 생략된 것이다.
        // this.HP라는 것을 잊으면 안된다.
        HP += _Heal;
    }

    public static void Damage(Player _this, int _Dmg)
    {
        // static을 객체로 특정할 수 없기 때문에 this를 사용할 수 없다.
        _this.HP -= _Dmg;
    }

    // 정적 멤버변수만을 정적 멤버함수에서 사용할 수 있다.
    private static int StTest = 100;
    public static void PVP(Player _Left, Player _Right)
    {
        StTest = 50;
        // 객체에 영향을 받지 않는 것
        // 정적 멤버함수, 정적 멤버변수
        // HP = 1000;
    }

}
namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            //NewPlayer1.Damage(100);
            Player.Damage(NewPlayer1, 100);

            Player.PVP(NewPlayer1, NewPlayer2);
        }
    }
}
