using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    enum BulletType
    {
        // PlayerBullet
        PB,
        // MonsterBullet
        MB,
    }
    class Bullet
    {
        Board board;
        Player player;
        Monster monster;
        Random random;
        public List<List<int>> PlayerBullet = new List<List<int>>();
        public List<List<int>> MonsterBullet = new List<List<int>>();

        public void Initialize(Board _board, Player _player, Monster _monster)
        {
            board = _board;
            player = _player;
            monster = _monster;
        }
        // 플레이어의 현재 좌표를 받아와서 한 칸 위쪽에 총알 생성
        public void PlayerShootBullet(int posX, int posY)
        {
            PlayerBullet.Add(new List<int> { posY - 1, posX });
        }

        // 몬스터의 현재 좌표를 받아와서 한 칸 아래에 총알 생성
        // 이때 몬스터의 제일 아래있는 인베이더들만 총알을 발사할 수 있다.
        public void MonsterShootBullet(int posX, int posY)
        {
            MonsterBullet.Add(new List<int> { posY +1 , posX });
        }

        public void Move()
        {
            for (int i = 0; i < PlayerBullet.Count; i++)
            {
                if (PlayerBullet[i][0] == 0)
                {
                    PlayerBullet.RemoveAt(i);
                }
                else if (board.Tile[PlayerBullet[i][0] - 1, PlayerBullet[i][1]] != TileType.Null)
                {
                    //// 몬스터도 null이면 bullet을 위칸으로 올려줘야 한다.
                    //if (monster.nullCheck(PlayerBullet[i][0] - 1, PlayerBullet[i][1]))
                    //{
                    //    PlayerBullet[i][0] -= 1;
                    //}
                    Crash(PlayerBullet[i][0] - 1, PlayerBullet[i][1], BulletType.PB);
                    PlayerBullet.RemoveAt(i);

                }
                else
                {
                    PlayerBullet[i][0] -= 1;
                }
            }
            for (int i = 0; i < MonsterBullet.Count; i++)
            {
                if (MonsterBullet[i][0] == board.Ysize - 1)
                {
                    MonsterBullet.RemoveAt(i);
                }
                else if (board.Tile[MonsterBullet[i][0] + 1, MonsterBullet[i][1]] != TileType.Null)
                {
                    Crash(MonsterBullet[i][0] + 1, MonsterBullet[i][1], BulletType.MB);
                    MonsterBullet.RemoveAt(i);
                }
                else
                {
                    MonsterBullet[i][0] += 1;
                }
            }
        }
        public void Crash(int posY, int posX, BulletType _type)
        {
            if (_type == BulletType.PB)
            {
                if (board.Tile[posY, posX] == TileType.Monster)
                {
                    for (int i = 3; i > -1; i--)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            if (monster.MonsterList[i, j] != null && monster.MonsterList[i, j].PosY == posY && monster.MonsterList[i, j].PosX == posX)
                            {
                                monster.MonsterList[i, j] = null;
                            }
                        }
                    }
                }
                else if (board.Tile[posY, posX] == TileType.MonsterBullet)
                {
                    for (int i = 0; i < MonsterBullet.Count; i++)
                    {
                        if (MonsterBullet[i][0] == posY && MonsterBullet[i][1] == posX)
                        {
                            MonsterBullet.RemoveAt(i);
                        }
                    }
                }
            }
            else
            {
                if (board.Tile[posY, posX] == TileType.Player)
                {
                    board.Tile[posY, posX] = TileType.Null;
                    board.GameOver();
                }
            }
        }
        public void Render()
        {
            for (int i = 0; i < PlayerBullet.Count; i++)
            {
                board.Tile[PlayerBullet[i][0], PlayerBullet[i][1]] = TileType.PlayerBullet;
            }
            for (int i = 0; i < MonsterBullet.Count; i++)
            {
                board.Tile[MonsterBullet[i][0], MonsterBullet[i][1]] = TileType.MonsterBullet;
            }
        }
    }
}
