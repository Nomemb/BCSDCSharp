using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

/*
실습해보기
고전 명작이라고 불리는 스페이스 인베이더를 구현해봅시다.

창의 크기는 64x32로 하며, 
플레이어는 아래에서 한 칸 위에서 시작하고, 인베이더들은 위에서 한 칸 아래에서 시작합니다.
한 줄 당 12마리의 인베이더가 있고, 한 칸의 간격을 두고 총 4줄의 인베이더 무리가 있습니다.
인베이더 무리들은 한꺼번에 움직이며, 왼쪽 끝에서 시작하여 오른쪽 끝에 도달하면 아랫줄로 움직입니다.
그 다음으로는 이제 오른쪽 끝에서 왼쪽 끝으로 이동하고, 마찬가지로 아랫줄로 이동합니다.
인베이더들 중 가장 앞에 있는 인베이더들은 아래를 향해 공격을 발사합니다.(발사 간격은 재량)
플레이어를 막아주는 장벽은 구현하지 않습니다.(구현하고 싶은 분들은 구현해도 됩니다)
플레이어가 모든 인베이더를 처치하면 승리하고,
인베이더가 플레이어를 죽이거나, 
플레이어보다 4줄 높은 위치에 도달하면 패배합니다.

=====여기까지 구현 =====

이외의 구현은 재량에 맡깁니다. (플레이어의 체력, 인베이더의 체력, 스코어 등등)

완전히 주어진 제시 조건도 소화하기 좀 힘들 것 같지만 가능한 할 수 있는데 까지는 해보시는걸 추천합니다.

무조건 주어진대로 구현할 필요는 없습니다. 화면 출력과 움직임, 충돌판정을 이용해 구현할 수 있는 규칙의 게임이 있다면 그것을 구현하셔도 좋습니다. (ex. 소코반 게임)

이외 모든 문의나 질문은 슬랙DM이나 트랙 채널에 공유해주세요.
 */

namespace SpaceInvader
{
    static class SpaceInvader
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            Monster monster = new Monster();
            Bullet bullet = new Bullet();
            Console.CursorVisible = false;

            board.Initailize(64, 32, player,monster, bullet);
            monster.Initialize(board.Xsize / 2 - 6, 1,board,player,bullet);
            // 아래에서 한 칸 위에서 시작, 중앙에서 시작
            player.Initialize(board.Xsize / 2, board.Ysize - 2, board, bullet);
            bullet.Initialize(board, player, monster);

            board.Render();
            while (true)
            {

                Thread.Sleep(1000 / 15);
                Console.SetCursorPosition(0, 0);
                board.Clear();
                board.Render();
                monster.RandomShoot();
                bullet.Move();
                monster.Move();
                player.Action();
            }
        }
    }
}
