using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Inven
{
    Item[] ArrItem;
    int ItemX;


    // 생성자를 사용해서 인벤토리를 new 하는 순간 x와 y를 넣어준다.
    // 실수를 방지하기 위해서
    public Inven(int _X, int _Y)
    {
        // 방어코드는 선택이 아니다.
        // 방어코드 : switch문의 default같은 것
        // 
        if (1 > _X)
        {
            _X = 1;
        }
        if (1 > _Y)
        {
            _Y = 1;
        }

        ItemX = _X;
        ArrItem = new Item[(_X * _Y)];
    }

    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (i != 0 && i % ItemX == 0)
            {
                Console.WriteLine("");
            }
            if (null == ArrItem[i])
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("■");
            }
        }
    }

    // 객체의 교류
    public void ItemIn(Item _Item)
    {
        int Index = 0;

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (ArrItem[i] == null)
            {
                Index = i;
                break;
            }
        }
        ArrItem[Index] = _Item;
    }

    public void ItemIn(Item _Item, int _Order)
    {
        if (ArrItem.Length < _Order || ArrItem[_Order] != null)
        {
            return;
        }
        else
        {
            ArrItem[_Order] = _Item;
        }
        
    }
}

