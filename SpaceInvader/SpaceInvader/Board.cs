using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TileType
{
    Null,
    Player,
    Monster,
    PlayerBullet,
    MonsterBullet,

}
namespace SpaceInvader
{
    class Board
    {
        public int Xsize;
        public int Ysize;

        public TileType[,] Tile { get; set; }
        Player player;
        Monster monster;
        Bullet bullet;

        public Board()
        {

        }

        public void Initailize(int _Xsize, int _Ysize, Player _player, Monster _monster, Bullet _bullet)
        {
            Xsize = _Xsize;
            Ysize = _Ysize;
            player = _player;
            monster = _monster;
            bullet = _bullet;
            Tile = new TileType[Ysize, Xsize];

        }
        public void Clear()
        {
            for (int y = 0; y < Ysize; y++)
            {
                for (int x = 0; x < Xsize; x++)
                {
                    Tile[y, x] = TileType.Null;
                }
            }
        }
        public void Render()
        {
            Tile[player.PosY, player.PosX] = TileType.Player;
            monster.Render();
            bullet.Render();
            for (int y = 0; y < Ysize; y++)
            {
                for (int x = 0; x < Xsize; x++)
                {
                    Console.Write(GetTileType(Tile[y, x]));
                }
            Console.WriteLine();
            }
            for (int i = 0; i < Xsize; i++)
                Console.Write("--");
            Console.WriteLine();
        }
        public string GetTileType(TileType type)
        {
            switch (type)
            {
                case TileType.Player:
                    return "凸";
                case TileType.Monster:
                    return "＃";
                case TileType.PlayerBullet:
                    return " ↑";
                case TileType.MonsterBullet:
                    return " ↓";
                default:
                    return "  ";
            }
        }

        public void GameOver()
        {
            Console.WriteLine("GameOver!");
            Environment.Exit(0);
        }
        public void GameClear()
        {
            Console.WriteLine("GameClear!");
            Environment.Exit(0);
        }
    }
}

