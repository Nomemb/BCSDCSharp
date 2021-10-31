using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inven NewInven = new Inven(5, 3);
            Item NewItem = new Item("철검", 100 );

            // 아이템 배열을 멤버변수로 가졌다.

            NewInven.ItemIn(new Item("철검", 100));
            NewInven.ItemIn(new Item("갑옷", 100));

            while (true)
            {
                NewInven.Render();
                Console.ReadKey();
            }
        }
    }
}
