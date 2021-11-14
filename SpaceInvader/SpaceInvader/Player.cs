using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    class Player
    {
        public int PosY { get;  set; }
        public int PosX { get; set; }

        Board board;
        Bullet bullet;

        public void Initialize(int _posX, int _posY, Board _board, Bullet _bullet)
        {
            PosX = _posX;
            PosY = _posY;

            board = _board;
            bullet = _bullet;
        }

        public void Action()
        {
            if( Console.KeyAvailable == false)
            {
                return;
            }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.LeftArrow:
                    if (PosX >= 1)
                    {
                        PosX -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if(PosX < board.Xsize - 1)
                    {
                        PosX += 1;
                    }
                    break;
                // 탄을 쐈을 때
                case ConsoleKey.Spacebar:
                    bullet.PlayerShootBullet(PosX, PosY);
                    break;
                default:
                    break;
            }
        }
    }
}
