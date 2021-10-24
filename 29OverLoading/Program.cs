using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}
class Player
{

    // 물리방어
    int AttDef = 5;
    // 화염방어
    int FireDef = 5;
    // 냉기방어
    int IceDef = 5;
    int Hp = 100;

    public Player()
    {

    }

    public Player(int _Hp)
    {
        Hp = _Hp;
    }
    static void Func(int _Value)
    {

    }

    // 함수 오버로딩
    // Damageint
    public void Damage(int _Damage)
    {
        Hp -= _Damage;
    }

    // Damagefloat
    public void Damage(float _Damage)
    {

    }

    // 컴파일 당시 서로 다른 함수라고 생각함
    // Damageintint
    public void Damage(int _Damage, DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;
            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;
            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;
            default:
                break;
        }
    }

    // Damagefloatint
    public void Damage(float _dddd, DMGTYPE _Type)
    {

    }
}

namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(1000);
            NewPlayer.Damage(100, DMGTYPE.FIREDMG);
        }
    }
}
