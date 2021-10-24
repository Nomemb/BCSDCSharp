using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    // 디폴트 접근은 Private
    //string Name = "NONE";
    //int AT;
    //int HP;

    protected string Name = "NONE";
    protected int AT = 10;
    protected int HP = 100;

    // 오버라이딩
    // 자식에서 만약 GetAT를 재구현하면
    // 자식의 형태의 GetAt를 호출한다.
    // 다형성( 동적바인딩 )의 핵심 문법중 하나 
    public virtual int GetAT()
    {
        Console.WriteLine("FIGHTUNIT의 GETAT");
        return AT;
    }

    // 프로터피는 VIRTUAL이 가능하다.
    public virtual int DMGAT
    {
        get
        {
            Console.WriteLine("FIGHTUNIT의 DMGAT");
            return AT;
        }
    }
    // 업캐스팅
    //DamageFightUnit
    // 첫번째 목적 : 상속의 개념을 지키기 위해서
    // 코드를 적게 치고 최대한의 효과를 가지고 싶다.
    public void Damage(FightUnit _OtherFightUnit)
    {
        // 각자 플레이어면 플레이어의 것이 되어야 한다.
        // _OtherFightUnit.AT
        int AT = _OtherFightUnit.DMGAT;
        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "의 데미지를 입었습니다.");
        HP -= _OtherFightUnit.AT;
    }

    // 오버로딩
    //DamagePlayer
    //함수가 너무 많아진다는 단점이 있다.
    //public void Damage(Player _OtherFightUnit, int _DamagePlus)
    //{
    //    Console.WriteLine(_OtherFightUnit.Name + "에게" + _OtherFightUnit.AT + "의 데미지를 입었습니다.");
    //    HP -= _OtherFightUnit.AT;
    //}


}

class Player : FightUnit
{
    int ItemAT = 5;

    public override int DMGAT
    {
        get
        {
            Console.WriteLine("플레이어의 DMGAT");
            return AT + ItemAT;
        }
    }
    // 무조건 이름을 넣어야 만들 수 있다.
    public Player(string _Name)
    {
        Name = _Name;
    }
}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public override int GetAT()
    {
        Console.WriteLine("몬스터의 GETAT");

        return AT + MonsterLv;
    }

    public override int DMGAT
    {
        get
        {
            Console.WriteLine("몬스터의 DMGAT");
            return AT + MonsterLv;
        }
    }

    public Monster(string _Name)
    {
        Name = _Name;
    }
}
namespace _30Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터");

            //NewPlayer.GetAT();
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);
        }
    }
}
