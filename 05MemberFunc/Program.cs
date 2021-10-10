using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 행동에 대해서 설명
// 맵에서 움직이다. 몬스터를 공격한다. NPC와 대화한다. 스킬을 사용한다 등등...
// 행동을 표현하는 것이 멤버함수다.


class Player
{
    // 명사만으로는 부족하다.
    int ATT;
    int HP;

    // 행동으로 나타나게 된다.
    void Move()
    {

    }

    void Fight()
    {

    }

    void Talk()
    {

    }

    void SkillUse()
    {

    }
}

// RPG를 만든다 -> 프로젝트 생성
// 주인공이 있다 -> 클래스 생성
// 주인공이 공격력이 있다 -> 멤버변수 생성
// 주인공이 공격한다 -> 멤버함수 생성