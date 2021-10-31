using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Player
{
    // 다른곳에 정의될 수도 있기 때문에, 플레이어의 안에 넣어주기도 한다.
    public enum PLAYERJOB
    {
        NOVICE,
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIREMAGE,
    }
    // 직업에 대한 멤버변수가 있어야 한다.
    PLAYERJOB Job = PLAYERJOB.NOVICE; 

    void ClassChange()
    {

    }
}
class Inven
{
    private int SelectIndex = 0;

     public void InnerClassTest()
    {
        InvenSlot NewInvenSlot = new InvenSlot();
      
        NewInvenSlot.Select(this);
    }
    // 자기 클래스 내부에 이너클래스를 생성할 수 있다.
    public class InvenSlot
    {
        int Index;

        public void Select(Inven _inven)
        {
            // 자신을 가지고 있는 클래스의 멤버변수를 public처럼 사용할 수 있다.
            _inven.SelectIndex = 100;
        }
    }
    // 안에 넣었을 때의 장점
    // 1. 이름 중복에서 자유롭다.
    // 자신과 관련된 자료형들을 자신 내부에 들고 있는 게 좋다.
    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN
    }
    // 어느 방향으로 움직이겠느냐?
    void SelectMove()
    {

    }
}
namespace _35InnerUserDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // Player.
            Inven NewInven = new Inven();
            NewInven.InnerClassTest();
            Inven.INVENDIR IDIR = Inven.INVENDIR.ID_LEFT; 

        }
    }
}
