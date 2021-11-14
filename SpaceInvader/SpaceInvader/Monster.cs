using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvader
{
    class Monster
    {
        public int PosX;
        public int PosY;
        Player player;
        Random random = new Random();
        Board board;
        Bullet bullet;
        // true : 왼 -> 오 false : 오 -> 왼
        private bool direction = true;
        // 양쪽의 끝을 만나면 true값이 된다.
        public Monster[,] MonsterList = new Monster[4, 12];

        public void Initialize(int _posX, int _posY, Board _board, Player _player, Bullet _bullet)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    MonsterList[i, j] = new Monster();
                    MonsterList[i, j].PosX = j + _posX;
                    MonsterList[i, j].PosY = i + _posY;
                }
            }
            board = _board;
            player = _player;
            bullet = _bullet;
        }

        public void Test()
        {
            MonsterList[0, 0] = null;
            Console.WriteLine(MonsterList[0, 0].PosX);
        }
        // true 반환시 마지막 칸이라 옆으로 옮기는게 불가능
        // 아래로 모든 칸들을 내려줘야 한다.
        // false 반환시 옆으로 옮기는게 가능하다.
        public bool MoveCheck()
        {
            if (direction == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (MonsterList[i, j] != null)
                        {
                            if (MonsterList[i, j].PosX + 1 == board.Xsize)
                            {
                                direction = false;
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (MonsterList[i, j] != null)
                        {
                            if (MonsterList[i, j].PosX - 1 == -1)
                            {
                                direction = true;
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }
        // true 반환시 list는 전부 null인 상태로 플레이어의 승리
        public bool ListNullCheck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (MonsterList[i, j] != null)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public void Move()
        {
            int bottomMonster = lastCheck();
            // 모두 처치되었을 경우에는 게임클리어 메세지를 나오게 하고 게임 종료한다.
            if (ListNullCheck())
            {
                board.GameClear();
            }
            if (direction)
            {
                if (MoveCheck())
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            // 마지막 몬스터가 플레이어보다 4칸 위까지 내려왔을 경우 패배처리한다.
                            if(i==bottomMonster && MonsterList[i,j] != null && MonsterList[i,j].PosY+4 == player.PosY)
                            {
                                board.GameOver();
                            }
                            if (MonsterList[i, j] != null)
                            {
                                MonsterList[i, j].PosY += 1;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            // 마지막 몬스터가 플레이어보다 4칸 위까지 내려왔을 경우 패배처리한다.
                            if (i == bottomMonster && MonsterList[i, j] != null && MonsterList[i, j].PosY + 4 == player.PosY)
                            {
                                board.GameOver();
                            }
                            if (MonsterList[i, j] != null)
                            {
                                MonsterList[i, j].PosX += 1;
                            }
                        }
                    }
                }
            }
            else
            {
                if (MoveCheck())
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {                            
                            // 마지막 몬스터가 플레이어보다 4칸 위까지 내려왔을 경우 패배처리한다.
                            if (i == bottomMonster && MonsterList[i, j] != null && MonsterList[i, j].PosY + 4 == player.PosY)
                            {
                                board.GameOver();
                            }
                            if (MonsterList[i, j] != null)
                            {
                                MonsterList[i, j].PosY += 1;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            // 마지막 몬스터가 플레이어보다 4칸 위까지 내려왔을 경우 패배처리한다.
                            if (i == bottomMonster && MonsterList[i, j] != null && MonsterList[i, j].PosY + 4 == player.PosY)
                            {
                                board.GameOver();
                            }
                            if (MonsterList[i, j] != null)
                            {
                                MonsterList[i, j].PosX -= 1;
                            }
                        }
                    }
                }
            }
        }
        public void Render()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (MonsterList[i, j] != null)
                    {
                        board.Tile[MonsterList[i, j].PosY, MonsterList[i, j].PosX] = TileType.Monster;
                    }
                }
            }
        }

        public int lastCheck()
        {
            for (int i = 3; i > -1; i--)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (MonsterList[i, j] != null)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }
        public void RandomShoot()
        {
            int last = lastCheck();
            for (int i = 0; i < 12; i++)
            {
                if (MonsterList[last, i] != null)
                {
                    int rand = random.Next(0, 100);
                    if (rand < 5)
                    {
                        bullet.MonsterShootBullet(MonsterList[last, i].PosX, MonsterList[last, i].PosY);
                    }
                }
            }
        }
    }
}
