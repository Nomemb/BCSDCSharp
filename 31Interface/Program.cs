using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의자료형인데
interface QuestUnit
{
    // 멤버변수를 넣을 수 없다.
    // int A = 0;
    // 함수의 형태만 물려줄 수 있는 문법이다.
    // 무조건 public이어야 한다.
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}

// 인터페이스는 함수 구현을 강제할 수 있다.
// 상속, 포함의 개념이다.
// 무조건 talk를 구현해야 한다.
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}
class NPC : FightUnit, QuestUnit
{
   public  void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}
class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();
        // QuestUnit QuestUnit = new QuestUnit()은 불가능

        QuestUnit NewQuestUnit = NewNPC;

        // 업캐스팅이 된다.
        NewPlayer.Talk(NewNPC);
        NewNPC.Talk(NewPlayer);
    }
}

